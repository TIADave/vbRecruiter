Imports BingMapsRESTToolkit


Public Class BingGeoGode
    Public Shared Async Function GetLocation(schoolName As String, City As String) As Task(Of SchoolLocation)
        Const key = "AmCkGL3_pgvyBqtYXt_voBPIqda56baFF6mXhxVr3YhxUSIWhxU4uI6WXEierCtk"

        Dim geo As New GeocodeRequest
        geo.BingMapsKey = key
        geo.Query = schoolName
        geo.MaxResults = 1
        Dim r As Response = Await ServiceManager.GetResponseAsync(geo)
        Dim retPoint As New SchoolLocation(schoolName, 0, 0)
        Try
            Dim coor As Double() = DirectCast(r.ResourceSets(0).Resources(0), BingMapsRESTToolkit.Location).GeocodePoints(0).Coordinates
            retPoint = New SchoolLocation(schoolName, coor(0), coor(1))
            retPoint = EnsureInUS(retPoint)
        Catch ex As Exception
            retPoint = Nothing

        End Try

        If retPoint Is Nothing Then
            geo.Query = City

            geo.MaxResults = 1
            r = Await ServiceManager.GetResponseAsync(geo)
            Try
                Dim coor As Double() = DirectCast(r.ResourceSets(0).Resources(0), BingMapsRESTToolkit.Location).GeocodePoints(0).Coordinates
                retPoint = New SchoolLocation(schoolName, coor(0), coor(1))
            Catch ex As Exception
                retPoint = Nothing
            End Try
        End If

        Return retPoint
    End Function

    Private Shared Function EnsureInUS(rPoint As SchoolLocation) As SchoolLocation
        Const top = 49.3457868
        Const Left = -124.7844079
        Const Right = -66.9513812
        Const bottom = 24.7433195

        If rPoint.LLat >= bottom AndAlso rPoint.LLat <= top AndAlso rPoint.LLong >= Left AndAlso rPoint.LLong <= Right Then
            Return rPoint
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function distance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double, ByVal unit As Char) As Double
        Dim theta As Double = lon1 - lon2
        Dim dist As Double = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta))
        dist = Math.Acos(dist)
        dist = rad2deg(dist)
        dist = dist * 60 * 1.1515
        If unit = "K" Then
            dist = dist * 1.609344
        ElseIf unit = "N" Then
            dist = dist * 0.8684
        End If
        Return dist
    End Function

    Private Shared Function deg2rad(ByVal deg As Double) As Double
        Return (deg * Math.PI / 180.0)
    End Function

    Private Shared Function rad2deg(ByVal rad As Double) As Double
        Return rad / Math.PI * 180.0
    End Function
End Class

Public Class SchoolLocation
    Dim _SchoolName As String
    Dim _LLat As Double
    Dim _LLong As Double

    Public Sub New(_SchoolName As String, _LLat As Double, _LLong As Double)
        Me._SchoolName = _SchoolName
        Me._LLat = _LLat
        Me._LLong = _LLong
    End Sub

    Public Property SchoolName As String
        Get
            Return _SchoolName
        End Get
        Set(value As String)
            _SchoolName = value
        End Set
    End Property

    Public Property LLat As Double
        Get
            Return _LLat
        End Get
        Set(value As Double)
            _LLat = value
        End Set
    End Property

    Public Property LLong As Double
        Get
            Return _LLong
        End Get
        Set(value As Double)
            _LLong = value
        End Set
    End Property
End Class