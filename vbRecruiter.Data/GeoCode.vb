Imports Geocoding
Imports Geocoding.Google

Public Class GeoCode
    Public Shared Function geoCodePlace(search As String) As Geocoding.Location
        Dim geocoder As IGeocoder = New GoogleGeocoder("AIzaSyD-j5DSZaxu93mdxwBGJ4t1FKvinqfhoyE")

        Dim rval As Geocoding.Location

        Try
            Dim addresses As IEnumerable(Of Address) = geocoder.Geocode(search)
            rval = addresses(0).Coordinates
            geocoder = Nothing
        Catch ex As Exception
            rval = Nothing
        End Try


        Return rval
    End Function


    Private Shared Function EnsureInUS(rPoint As Geocoding.Location) As Boolean
        Const top = 49.3457868
        Const Left = -124.7844079
        Const Right = -66.9513812
        Const bottom = 24.7433195

        If rPoint.Latitude >= bottom AndAlso rPoint.Latitude <= top AndAlso rPoint.Longitude >= Left AndAlso rPoint.Longitude <= Right Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function distance(pt1 As Geocoding.Location, pt2 As Geocoding.Location) As Double
        Return distance(pt1.Latitude, pt1.Longitude, pt2.Latitude, pt2.Longitude)
    End Function
    Public Shared Function distance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double) As Double
        Dim theta As Double = lon1 - lon2
        Dim dist As Double = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta))
        dist = Math.Acos(dist)
        dist = rad2deg(dist)
        dist = dist * 60 * 1.1515
        Return dist
    End Function

    Private Shared Function deg2rad(ByVal deg As Double) As Double
        Return (deg * Math.PI / 180.0)
    End Function

    Private Shared Function rad2deg(ByVal rad As Double) As Double
        Return rad / Math.PI * 180.0
    End Function

End Class
