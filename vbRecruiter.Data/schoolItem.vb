Public Class schoolItem

    Dim _SchoolName As String
    Dim _FirstSeen As Date
    Dim _LastUpdate As Date
    Dim _CityState As String
    Dim _Division As String
    Dim _Latitude As Double
    Dim _Longitude As Double
    Dim _ContactName As String
    Dim _ContactPhone As String
    Dim _ContactEmail As String
    Dim _Description As String
    Dim _ContactSentOn As Date
    Dim _ResponseReceived As Date
    Dim _Notes As String
    Dim _Website As String
    Dim _Html As String


    Dim _Needs As New Dictionary(Of Integer, needItem)

    Public Property Division As String
        Get
            Return _Division
        End Get
        Set(value As String)
            _Division = value
        End Set
    End Property

    Public Property Website As String
        Get
            Return _Website
        End Get
        Set(value As String)
            _Website = value
        End Set
    End Property

    Public Property Html As String
        Get
            Return _Html
        End Get
        Set(value As String)
            _Html = value
        End Set
    End Property

    Public Sub New(LoadText As String)
        Dim LastYearFound As Integer = -1

        Dim itms As String() = LoadText.Split(vbCrLf)
        _Html = GetHTML(itms)
        Me._SchoolName = itms(0).Trim.Replace("SCHOOL NAME:", "").Trim
        LastYearFound = -1
        For Each lnItm As String In itms


            Dim tagItm As String() = lnItm.Trim.Split(":")
            For I As Integer = 0 To tagItm.Count - 1
                tagItm(I) = tagItm(I).Trim
            Next
            If tagItm.Count >= 2 Then

                If tagItm(0).ToUpper.Contains("WEBSITE") Then
                    _Website = lnItm.Substring(tagItm(0).Length + 2).Trim
                    If Not _Website.StartsWith("http://") Then
                        _Website = $"http://{_Website}"
                    End If

                ElseIf Val(tagItm(0).Trim & "") > 0 Then
                    LastYearFound = Val(tagItm(0) & "")
                    If Not _Needs.ContainsKey(LastYearFound) Then
                        _Needs.Add(LastYearFound, New needItem(LastYearFound, tagItm(1).Trim))
                    End If

                ElseIf LastYearFound > 0 AndAlso tagItm(0).ToUpper.Contains("SCHOLARSHIP") Then
                    If _Needs.ContainsKey(LastYearFound) Then
                        _Needs(LastYearFound).Scolarships = tagItm(1).Trim
                    End If
                ElseIf LastYearFound > 0 AndAlso tagItm(0).ToUpper.Contains("REQUIREMENT") Then
                    If _Needs.ContainsKey(LastYearFound) Then
                        _Needs(LastYearFound).Requirements = tagItm(1).Trim
                    End If
                ElseIf tagItm(0).ToUpper.StartsWith("LOCATION") Then
                    _CityState = tagItm(1).Trim
                ElseIf tagItm(0).ToUpper.Contains("PHONE") Then
                    _ContactPhone = tagItm(1).Trim
                ElseIf tagItm(0).ToUpper.Contains("MAIL") Then
                    _ContactEmail = tagItm(1).Trim
                ElseIf tagItm(0).ToUpper.Contains("DESCRIPTION") Then
                    _Description = tagItm(1).Trim
                ElseIf tagItm(0).ToUpper.Contains("NOTE") Then
                    _Notes = tagItm(1).Trim
                ElseIf tagItm(0) = "Pages" Then
                    Debug.Print("done")
                Else

                    Select Case tagItm(0).Trim.ToUpper
                        Case "DIVISION"
                            _Division = tagItm(1).Trim
                        Case "CONTACT NAME"
                            _ContactName = tagItm(1).Trim
                        Case "SCHOOL NAME"
                        Case Else
                            MsgBox($"Unknown Tag: {tagItm(0).Trim } Text: {tagItm(1).Trim}")
                    End Select

                End If
            End If
        Next
    End Sub

    Private Function GetHTML(itm As String()) As String

        Dim html As String = String.Empty
        For Each s As String In itm
            s = s.Trim
            If s.Length > 0 Then
                html += $"<b>{s.Substring(0, s.IndexOf(":") + 1)}</b>{s.Substring(s.IndexOf(":") + 1)}<br />"
            End If
        Next
        Return html


    End Function

    Public Sub AddToTable(ByRef ds As vbrData)
        Dim dr As vbrData.SchoolRow

        If ds.School.Select($"Name='{Me._SchoolName}'", "").Count = 0 Then
            dr = ds.School.NewSchoolRow
            dr.Name = _SchoolName
            dr.CreateDate = Now
            dr.CityState = _CityState
            dr.ContactName = _ContactName
            dr.ContactPhone = _ContactPhone
            dr.ContactEmail = _ContactEmail
            dr.Description = _Description
            dr.Division = _Division
            dr.Website = _Website
            dr.Source = "prepVB"
            ds.School.AddSchoolRow(dr)
        Else
            dr = ds.School.Select($"Name='{Me._SchoolName}'", "")(0)
        End If
        dr.UpdateDate = Now
        dr.Html = _Html

        For Each need As KeyValuePair(Of Integer, needItem) In Me._Needs
            Dim drNeed As vbrData.NeedsRow = ds.Needs.FindBySchoolIDYear(dr.SchoolID, need.Key)

            If drNeed Is Nothing Then
                drNeed = ds.Needs.NewNeedsRow
                drNeed.SchoolID = dr.SchoolID
                drNeed.Year = need.Key
                ds.Needs.AddNeedsRow(drNeed)
            End If

            drNeed.Setter = need.Value.Setter
            drNeed.OH = need.Value.OutsideHitter OrElse need.Value.PinHitter
            drNeed.MB = need.Value.MiddleBlocker
            drNeed.Libero = need.Value.Libero
            drNeed.DS = need.Value.DS
            drNeed.Notes = need.Value.Notes
            drNeed.Scolarships = need.Value.Scolarships
            drNeed.Requirements = need.Value.Requirements
            drNeed.AcceptChanges()
        Next


    End Sub

End Class

