Imports System.Web
Imports vbRecruiter.Data

Public Class main

    Const datafile = "data.xml"

    Dim _Data As vbrData
    Dim _Home As String
    Dim WithEvents vpLoad As vbpLoader

    Public Event OnStatusUpdate(StatusText As String)

    Public Property Data As vbrData
        Get
            Return _Data
        End Get
        Set(value As vbrData)
            _Data = value
        End Set
    End Property

    Public Sub New(ByRef data As vbrData)
        _Data = data

        If Not IO.File.Exists(datafile) Then
            _Data.WriteXml(datafile)
        End If

        _Data.ReadXml(datafile)
    End Sub

    Public Sub Save()
        _Data.AcceptChanges()
        _Data.WriteXml(datafile)
        RaiseEvent OnStatusUpdate("Datafile Saved.")
    End Sub

    Public Sub Clear()
        _Data = New vbrData
        _Data.WriteXml(datafile)
    End Sub

    Public Sub Update(User As String, PW As String, URL As String, homeAddress As String, Optional doDownLoad As Boolean = True)
        vpLoad = New vbpLoader(User, PW, URL)
        _Home = homeAddress
        Dim loaddate As Date

        If doDownLoad Then
            loaddate = vpLoad.Load()
        Else
            loaddate = _Data.loadPages.Compute("Max(DTTM)", "")
        End If

        ProcessPages(loaddate)

        ProcessLocations(False)

        Save()



    End Sub

    Public Sub ProcessLocations(reset As Boolean, Optional HomeAddress As String = "")
        If HomeAddress.Length > 0 Then
            _Home = HomeAddress
        End If
        If reset Then
            For Each school As vbrData.SchoolRow In _Data.School
                school.Latitude = -1
                school.Longitude = -1
                school.SetMilesAwayNull()
            Next
            _Data.School.AcceptChanges()
        End If


        Dim rHome As Geocoding.Location = GeoCode.geoCodePlace(_Home)

        For Each school As vbrData.SchoolRow In _Data.School
            RaiseEvent OnStatusUpdate($"GeoTagging {school.Name}")
            If school.Latitude = -1 OrElse school.Longitude = -1 Then
                Dim rSchool As Geocoding.Location = GeoCode.geoCodePlace(school.Name)
                Dim rCity As Geocoding.Location = GeoCode.geoCodePlace(school.CityState)

                If rSchool Is Nothing AndAlso rCity Is Nothing Then
                ElseIf rSchool Is Nothing AndAlso rCity IsNot Nothing Then
                    school.Latitude = rCity.Latitude
                    school.Longitude = rCity.Longitude
                    If rHome IsNot Nothing Then school.MilesAway = GeoCode.distance(rCity, rHome)
                ElseIf rSchool IsNot Nothing AndAlso rCity Is Nothing Then
                    school.Latitude = rSchool.Latitude
                    school.Longitude = rSchool.Longitude
                    If rHome IsNot Nothing Then school.MilesAway = GeoCode.distance(rSchool, rHome)
                ElseIf GeoCode.distance(rSchool, rCity) > 100 Then
                    school.Latitude = rCity.Latitude
                    school.Longitude = rCity.Longitude
                    If rHome IsNot Nothing Then school.MilesAway = GeoCode.distance(rCity, rHome)
                Else
                    school.Latitude = rSchool.Latitude
                    school.Longitude = rSchool.Longitude
                    If rHome IsNot Nothing Then school.MilesAway = GeoCode.distance(rSchool, rHome)
                End If

            End If

        Next
        RaiseEvent OnStatusUpdate($"GeoTagging Complete.")
    End Sub


    Private Sub ProcessPages(loaddate As Date)

        For Each dr As vbrData.loadPagesRow In _Data.loadPages.Select($"DTTM=#{loaddate}#", "PageNo")
            RaiseEvent OnStatusUpdate($"Parsing Page #{dr.PageNo}")
            ProcessSchools(dr)
        Next
    End Sub

    Private Sub ProcessSchools(dr As vbrData.loadPagesRow)
        Dim txt As String = dr.PageText.Replace("SCHOOL NAME:", "ÆSCHOOL NAME:")
        For Each s As String In txt.Split("Æ")
            If s.Length > 1 AndAlso s.StartsWith("SCHOOL") Then
                LoadSchool(s.Trim)
            End If
        Next
    End Sub

    Private Sub LoadSchool(txt As String)
        Dim school As New schoolItem(txt)
        school.AddToTable(_Data)
    End Sub
    Private Sub vpLoad_OnPageDownLoaded(e As onPageDLEventArgs) Handles vpLoad.OnPageDownLoaded

        Dim drLoadPage As vbrData.loadPagesRow = _Data.loadPages.FindByDTTMPageNo(e.Dttm, e.PageNo)

        If drLoadPage Is Nothing Then
            drLoadPage = _Data.loadPages.NewloadPagesRow
            drLoadPage.DTTM = e.Dttm
            drLoadPage.PageNo = e.PageNo
            drLoadPage.PageText = HttpUtility.HtmlDecode(e.PageText)
            _Data.loadPages.AddloadPagesRow(drLoadPage)
            _Data.loadPages.AcceptChanges()
            RaiseEvent OnStatusUpdate($"Page #{e.PageNo } stored.")
        Else
            RaiseEvent OnStatusUpdate($"Page #{e.PageNo } hasn't changed.")
        End If

    End Sub

    Private Sub vpLoad_OnStatusUpdate(StatusText As String) Handles vpLoad.OnStatusUpdate
        RaiseEvent OnStatusUpdate(StatusText)

    End Sub
End Class
