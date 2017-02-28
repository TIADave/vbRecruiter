Public Class fSettings

    Dim CurrentLocation As Geocoding.Microsoft.Json.Location


    Private Sub fSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSettings()

    End Sub

    Private Sub LoadSettings()
        txtUser.Text = My.Settings.UserName
        txtPW.Text = My.Settings.PW
        txtURL.Text = My.Settings.URL
        txtAddress.Text = My.Settings.HomeAddress
    End Sub
    Private Sub SaveSettings()
        My.Settings.UserName = txtUser.Text
        My.Settings.PW = txtPW.Text
        My.Settings.URL = txtURL.Text
        My.Settings.HomeAddress = txtAddress.Text
        My.Settings.Save()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SaveSettings()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class