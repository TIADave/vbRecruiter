Imports System.Text.RegularExpressions
Imports vbRecruiter.Data

Public Class vbpLoader
    Dim _UserName As String
    Dim _PW As String
    Dim _URL As String

    Dim wpLoader As wordPressReader

    Public Event OnStatusUpdate(StatusText As String)
    Public Event OnPageDownLoaded(e As onPageDLEventArgs)
    Public Sub New(_UserName As String, _PW As String, _URL As String)
        Me._UserName = _UserName
        Me._PW = _PW
        Me._URL = _URL
    End Sub

    Public Property UserName As String
        Get
            Return _UserName
        End Get
        Set(value As String)
            _UserName = value
        End Set
    End Property

    Public Property PW As String
        Get
            Return _PW
        End Get
        Set(value As String)
            _PW = value
        End Set
    End Property

    Public Property URL As String
        Get
            Return _URL
        End Get
        Set(value As String)
            _URL = value
        End Set
    End Property

    Public Function Load() As Date

        Dim rVal As Boolean = False

        RaiseEvent OnStatusUpdate("Logging into website...")

        wpLoader = New wordPressReader(UserName, PW)

        Dim FirstPage As String = String.Empty
        For I As Integer = 1 To 30
            RaiseEvent OnStatusUpdate($"Processing Page # {I}")
            Dim s As String = StripTags(wpLoader.GetSchools($"{URL}/{I}"))
            If I = 1 Then
                FirstPage = s
            Else
                If s.Equals(FirstPage) Then
                    rVal = True
                    Exit For
                End If
            End If
            Dim formatted As String = String.Empty
            For Each s1 As String In s.Split(vbCrLf)
                formatted += s1.Trim & vbCrLf
            Next

            RaiseEvent OnPageDownLoaded(New onPageDLEventArgs(wpLoader.PostDate, I, formatted.Trim))
        Next
        Return wpLoader.PostDate
    End Function
    Public Function StripTags(ByVal html As String) As String
        ' Remove HTML tags.
        Return Regex.Replace(html, "<.*?>", "")
    End Function


End Class
