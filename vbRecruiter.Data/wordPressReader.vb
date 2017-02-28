Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class wordPressReader

    Dim _UserName As String
    Dim _PW As String
    Dim request As HttpWebRequest
    Dim cc As New CookieContainer
    Dim _PostDate As Date

    Public Property PostDate As Date
        Get
            Return _PostDate
        End Get
        Set(value As Date)
            _PostDate = value
        End Set
    End Property

    Public Sub New(_UserName As String, _PW As String)
        Me._UserName = _UserName
        Me._PW = _PW

    End Sub

    Public Sub Login(url As String)

        Dim loginUri As String = "https://prepvolleyball.com/members/login"
        Dim username As String = _UserName
        Dim password As String = _PW
        Dim reqString As String = $"amember_login={username}&amember_pass={password}&amember_redirect_url={url}"
        Dim requestData As Byte() = Encoding.UTF8.GetBytes(reqString)


        request = CType(WebRequest.Create(loginUri), HttpWebRequest)
        request.Proxy = Nothing
        request.AllowAutoRedirect = False
        request.CookieContainer = cc
        request.Method = "post"

        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = requestData.Length
        Using s As Stream = request.GetRequestStream()
            s.Write(requestData, 0, requestData.Length)
        End Using

        Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            If response.Cookies IsNot Nothing Then
                For Each currentcook As Cookie In response.Cookies
                    request.CookieContainer.Add(currentcook)    'This is the key !!!
                Next
            End If
        End Using

    End Sub

    Friend Function GetSchools(uRL As String) As String

        Dim sSource As String = GetPage(uRL)
        _PostDate = Date.Parse(GetSammichText("<span class=""tie-date"">", "</span>", sSource))
        Return GetSammichText("<div class=""entry"">", "</div><!-- .entry /-->", sSource)


    End Function

    Private Function GetSammichText(sDelimStart As String, sDelimEnd As String, sSource As String) As String

        Dim nIndexStart As Integer = sSource.IndexOf(sDelimStart) 'Find the first occurrence of f1
        Dim nIndexEnd As Integer = sSource.IndexOf(sDelimEnd, nIndexStart) 'Find the first occurrence of f2

        If nIndexStart > -1 AndAlso nIndexEnd > -1 Then '-1 means the word was not found.
            Dim res As String = Strings.Mid(sSource, nIndexStart + sDelimStart.Length + 1, nIndexEnd - nIndexStart - sDelimStart.Length) 'Crop the text between
            Return res.Replace("<br />", vbCrLf).Replace("</p>", "</p>" & vbCrLf)
        Else
            Return String.Empty
        End If
    End Function

    Public Function GetPage(URL As String) As String

        If cc.Count = 0 Then
            Login(URL)
        End If

        Dim results As String = String.Empty

        Dim newloginUri As String = URL
        Dim newrequest As HttpWebRequest = DirectCast(WebRequest.Create(URL), HttpWebRequest)
        newrequest.Proxy = Nothing
        newrequest.CookieContainer = cc
        Using newresponse As HttpWebResponse = DirectCast(newrequest.GetResponse(), HttpWebResponse)
            Using resSteam As Stream = newresponse.GetResponseStream()
                Using sr As New StreamReader(resSteam)
                    results = sr.ReadToEnd
                End Using
            End Using
        End Using

        Return results

    End Function



End Class
