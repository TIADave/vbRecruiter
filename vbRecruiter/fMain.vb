Imports System.ComponentModel
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Syncfusion.Windows.Forms.Tools
Imports vbRecruiter.Data
Imports vbRecruiter.Data.vbrData

Public Class fMain

    Dim WithEvents mData As Data.main

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mData = New main(VbrData)

    End Sub

    Private Sub bgwUpdate_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwUpdate.DoWork
        mData.Update(My.Settings.UserName, My.Settings.PW, My.Settings.URL, e.Argument)


    End Sub


    Private Sub bgwUpdate_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwUpdate.RunWorkerCompleted
        bsSchools.ResetBindings(False)
        LoadSettingsTree()
        RefreshPins()
        status.Text = "Ready."
    End Sub

    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClearSelected()
        With vbMap
            .SetPositionByKeywords("USA")
            .MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache
            '.MinZoom = 3
            '.MaxZoom = 17
            .DragButton = MouseButtons.Left
            .ShowCenter = False
            .Zoom = 4
            .AutoScroll = True
        End With
        LoadSettingsTree()



    End Sub

    Private Sub LoadSettingsTree()
        tv.Nodes.Clear()
        Dim dv As DataView = VbrData.Needs.AsDataView.ToTable("Years", True, "Year").AsDataView
        dv.RowFilter = "Year >= " & Now.Year
        dv.Sort = "Year"
        For Each dvr As DataRowView In dv
            Dim pNode As TreeNode = tv.Nodes.Add(dvr("Year"))
            pNode.Nodes.Add("Setter").Tag = $"(Year={dvr("Year")} and Setter=True)"
            pNode.Nodes.Add("OutsideHitter").Tag = $"(Year={dvr("Year")} and OH=True)"
            pNode.Nodes.Add("MiddleBlocker").Tag = $"(Year={dvr("Year")} and MB=True)"
            pNode.Nodes.Add("Libero").Tag = $"(Year={dvr("Year")} and Libero=True)"
            pNode.Nodes.Add("DS").Tag = $"(Year={dvr("Year")} and DS=True)"
            pNode.ExpandAll()
        Next
    End Sub

    Private Sub RefreshPins()
        vbMap.Overlays.Clear()


        Dim markers As GMapOverlay = New GMapOverlay("markers")

        For Each dr As Data.vbrData.SchoolRow In VbrData.School
            Dim marker As GMapMarker
            If dr.selected Then
                marker = New GMarkerGoogle(New PointLatLng(dr.Latitude, dr.Longitude), GMarkerGoogleType.green_small)
            Else
                marker = New GMarkerGoogle(New PointLatLng(dr.Latitude, dr.Longitude), GMarkerGoogleType.orange_small)
            End If


            marker.ToolTip = New GMapBaloonToolTip(marker)
            marker.ToolTip.TextPadding = New Size(10, 10)
            marker.ToolTipText = dr.Name
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver
            marker.Tag = dr
            markers.Markers.Add(marker)
        Next

        vbMap.Overlays.Add(markers)

        vbMap.Zoom = vbMap.Zoom + 1
        vbMap.Zoom = vbMap.Zoom - 1
    End Sub

    'Private Sub UpdateDataSource()
    '    VbrData.Clear()
    '    VbrData.Merge(mData.Data)
    '    schoolCount.Text = $"Schools: {mData.Data.School.Count}"
    'End Sub

    Private Sub mData_OnStatusUpdate(StatusText As String) Handles mData.OnStatusUpdate
        status.Text = StatusText

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim settings As New fSettings
        settings.ShowDialog(Me)
    End Sub


    Private Sub WipeDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WipeDataToolStripMenuItem.Click
        If MsgBox("This will REMOVE ALL data. Are you Sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then

            VbrData.Clear()
            mData.Save()
        End If
    End Sub

    Private Sub WithDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithDownloadToolStripMenuItem.Click
        bgwUpdate.RunWorkerAsync(True)
    End Sub

    Private Sub WithoutDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithoutDownloadToolStripMenuItem.Click
        bgwUpdate.RunWorkerAsync(False)
    End Sub

    Private Sub GeotagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeotagToolStripMenuItem.Click
        bgwGeoTag.RunWorkerAsync(False)
    End Sub

    Private Sub bgwGeoTag_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwGeoTag.DoWork
        mData.ProcessLocations(e.Argument, My.Settings.HomeAddress)
        mData.Save()


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            RefreshPins()
        End If
    End Sub

    Private Sub vbMap_OnMapZoomChanged() Handles vbMap.OnMapZoomChanged
        status.Text = $"Zoom: {vbMap.Zoom}"
    End Sub

    Private Sub vbMap_OnMarkerClick(item As GMapMarker, e As MouseEventArgs) Handles vbMap.OnMarkerClick
        Dim dr As SchoolRow = item.Tag
        ViewSchool(dr)
    End Sub

    Private Sub ViewSchool(dr As SchoolRow)
        html.Title = dr.Name
        html.Tag = $"https://en.wikipedia.org/wiki/{dr.Name.Replace(" ", "_")}"
        Dim linkedHtml As String = AddLinks(dr)
        html.LoadFromString(linkedHtml.Replace("<br />", "<br /><br />"))
        GroupBar1.SelectedItem = 0

    End Sub

    Private Function AddLinks(dr As SchoolRow) As String
        Dim wiki As String = $"<a href='https://en.wikipedia.org/wiki/{dr.Name.Replace(" ", "_")}' target='_blank'>Wiki</a>"
        Dim vball As String = String.Empty
        If Not dr.IsWebsiteNull Then
            vball = $"<a href='{dr.Website}' target='_blank'>Homepage</a>"
        End If
        Return $"<center>{vball}      {wiki}</center><br />{dr.Html}"
    End Function


    Private Sub html_LinkClicked(sender As Object, e As Syncfusion.Windows.Forms.HTMLUI.LinkForwardEventArgs) Handles html.LinkClicked
        Process.Start(e.Path)
        e.Cancel = True
    End Sub

    Private Sub fMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mData.Save()
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        If dgv.SelectedRows.Count = 1 Then
            ViewSchool(dgv.SelectedRows(0).DataBoundItem.row)
        End If

    End Sub

    Private Sub PrepVolleyballcomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrepVolleyballcomToolStripMenuItem.Click
        Process.Start("https://prepvolleyball.com")
    End Sub

    Private Sub LonestarPrepVolleyballcomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LonestarPrepVolleyballcomToolStripMenuItem.Click
        Process.Start("https://lonestar.prepvolleyball.com")
    End Sub

    Private Sub tv_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tv.AfterCheck

        UpdateSelectedList()

    End Sub

    Private Sub UpdateSelectedList()
        Dim filter As New List(Of String)
        For Each pNod As TreeNode In tv.Nodes
            For Each cNod As TreeNode In pNod.Nodes
                If cNod.Checked Then
                    filter.Add(cNod.Tag)
                End If
            Next
        Next

        Dim FilterLong As String = String.Join(" OR ", filter.ToArray)
        ClearSelected()
        If filter.Count > 0 Then
            For Each nrow As NeedsRow In VbrData.Needs.Select(FilterLong, "")
                mData.Data.School.FindBySchoolID(nrow.SchoolID).selected = True
            Next


        End If
        RefreshPins()
        dgv.Update()

    End Sub

    Private Sub ClearSelected()
        For Each dr As Data.vbrData.SchoolRow In VbrData.School
            dr.selected = False
        Next
    End Sub



    Private Sub dgv_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgv.RowPrePaint

        If dgv.Rows.Item(e.RowIndex).Cells("selected").Value = True Then
            dgv.Rows.Item(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        Else
            dgv.Rows.Item(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FKSchoolNotesBindingSource.EndEdit()
        VbrData.AcceptChanges()
        mData.Save()
    End Sub

    Private Sub bgwGeoTag_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwGeoTag.RunWorkerCompleted
        bsSchools.ResetBindings(True)
        RefreshPins()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        bgwGeoTag.RunWorkerAsync(True)
    End Sub

    Private Sub bsSchools_ListChanged(sender As Object, e As ListChangedEventArgs) Handles bsSchools.ListChanged
        schoolCount.Text = $"Schools: {bsSchools.Count}"
    End Sub
End Class
