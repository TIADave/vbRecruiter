<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DateTmLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim ContactNameLabel As System.Windows.Forms.Label
        Dim ContactRepliedLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithDownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithoutDownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeotagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WipeDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrepVolleyballcomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LonestarPrepVolleyballcomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.schoolCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bgwUpdate = New System.ComponentModel.BackgroundWorker()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.SchoolIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DivisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilesAway = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebsiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.CreateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HtmlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsSchools = New System.Windows.Forms.BindingSource(Me.components)
        Me.VbrData = New vbRecruiter.Data.vbrData()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.List = New System.Windows.Forms.TabPage()
        Me.Map = New System.Windows.Forms.TabPage()
        Me.vbMap = New GMap.NET.WindowsForms.GMapControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.FKSchoolNotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTmDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactRepliedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.html = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.Details = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
        Me.Contact = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
        Me.Settings = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
        Me.bgwGeoTag = New System.ComponentModel.BackgroundWorker()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        DateTmLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        ContactNameLabel = New System.Windows.Forms.Label()
        ContactRepliedLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchools, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbrData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.List.SuspendLayout()
        Me.Map.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBar1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FKSchoolNotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.html, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTmLabel
        '
        DateTmLabel.AutoSize = True
        DateTmLabel.Dock = System.Windows.Forms.DockStyle.Fill
        DateTmLabel.ForeColor = System.Drawing.Color.Black
        DateTmLabel.Location = New System.Drawing.Point(3, 0)
        DateTmLabel.Name = "DateTmLabel"
        DateTmLabel.Size = New System.Drawing.Size(190, 30)
        DateTmLabel.TabIndex = 12
        DateTmLabel.Text = "Note Date:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Dock = System.Windows.Forms.DockStyle.Fill
        NoteLabel.ForeColor = System.Drawing.Color.Black
        NoteLabel.Location = New System.Drawing.Point(3, 100)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(190, 40)
        NoteLabel.TabIndex = 14
        NoteLabel.Text = "Note:"
        '
        'ContactNameLabel
        '
        ContactNameLabel.AutoSize = True
        ContactNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        ContactNameLabel.ForeColor = System.Drawing.Color.Black
        ContactNameLabel.Location = New System.Drawing.Point(199, 0)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(190, 30)
        ContactNameLabel.TabIndex = 16
        ContactNameLabel.Text = "Contact Name:"
        '
        'ContactRepliedLabel
        '
        ContactRepliedLabel.AutoSize = True
        ContactRepliedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        ContactRepliedLabel.ForeColor = System.Drawing.Color.Black
        ContactRepliedLabel.Location = New System.Drawing.Point(199, 70)
        ContactRepliedLabel.Name = "ContactRepliedLabel"
        ContactRepliedLabel.Size = New System.Drawing.Size(190, 30)
        ContactRepliedLabel.TabIndex = 18
        ContactRepliedLabel.Text = "Contact Replied:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.WipeDataToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1162, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WithDownloadToolStripMenuItem, Me.WithoutDownloadToolStripMenuItem, Me.GeotagToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(82, 29)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'WithDownloadToolStripMenuItem
        '
        Me.WithDownloadToolStripMenuItem.Name = "WithDownloadToolStripMenuItem"
        Me.WithDownloadToolStripMenuItem.Size = New System.Drawing.Size(248, 30)
        Me.WithDownloadToolStripMenuItem.Text = "With Download"
        '
        'WithoutDownloadToolStripMenuItem
        '
        Me.WithoutDownloadToolStripMenuItem.Name = "WithoutDownloadToolStripMenuItem"
        Me.WithoutDownloadToolStripMenuItem.Size = New System.Drawing.Size(248, 30)
        Me.WithoutDownloadToolStripMenuItem.Text = "Without Download"
        '
        'GeotagToolStripMenuItem
        '
        Me.GeotagToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.GeotagToolStripMenuItem.Name = "GeotagToolStripMenuItem"
        Me.GeotagToolStripMenuItem.Size = New System.Drawing.Size(248, 30)
        Me.GeotagToolStripMenuItem.Text = "Geotag"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'WipeDataToolStripMenuItem
        '
        Me.WipeDataToolStripMenuItem.Name = "WipeDataToolStripMenuItem"
        Me.WipeDataToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.WipeDataToolStripMenuItem.Text = "Wipe Data"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrepVolleyballcomToolStripMenuItem, Me.LonestarPrepVolleyballcomToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(63, 29)
        Me.ToolStripMenuItem1.Text = "Links"
        '
        'PrepVolleyballcomToolStripMenuItem
        '
        Me.PrepVolleyballcomToolStripMenuItem.Name = "PrepVolleyballcomToolStripMenuItem"
        Me.PrepVolleyballcomToolStripMenuItem.Size = New System.Drawing.Size(318, 30)
        Me.PrepVolleyballcomToolStripMenuItem.Text = "PrepVolleyball.com"
        '
        'LonestarPrepVolleyballcomToolStripMenuItem
        '
        Me.LonestarPrepVolleyballcomToolStripMenuItem.Name = "LonestarPrepVolleyballcomToolStripMenuItem"
        Me.LonestarPrepVolleyballcomToolStripMenuItem.Size = New System.Drawing.Size(318, 30)
        Me.LonestarPrepVolleyballcomToolStripMenuItem.Text = "Lonestar.PrepVolleyball.com"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status, Me.schoolCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 551)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1162, 30)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(1055, 25)
        Me.status.Spring = True
        Me.status.Text = "Welcome"
        Me.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'schoolCount
        '
        Me.schoolCount.Name = "schoolCount"
        Me.schoolCount.Size = New System.Drawing.Size(93, 25)
        Me.schoolCount.Text = "Schools: 0"
        '
        'bgwUpdate
        '
        '
        'dgv
        '
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SchoolIDDataGridViewTextBoxColumn, Me.selected, Me.NameDataGridViewTextBoxColumn, Me.DivisionDataGridViewTextBoxColumn, Me.CityStateDataGridViewTextBoxColumn, Me.MilesAway, Me.LatitudeDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.ContactNameDataGridViewTextBoxColumn, Me.ContactPhoneDataGridViewTextBoxColumn, Me.ContactEmailDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.WebsiteDataGridViewTextBoxColumn, Me.CreateDateDataGridViewTextBoxColumn, Me.UpdateDateDataGridViewTextBoxColumn, Me.HtmlDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.bsSchools
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(748, 467)
        Me.dgv.TabIndex = 2
        '
        'SchoolIDDataGridViewTextBoxColumn
        '
        Me.SchoolIDDataGridViewTextBoxColumn.DataPropertyName = "SchoolID"
        Me.SchoolIDDataGridViewTextBoxColumn.HeaderText = "SchoolID"
        Me.SchoolIDDataGridViewTextBoxColumn.Name = "SchoolIDDataGridViewTextBoxColumn"
        Me.SchoolIDDataGridViewTextBoxColumn.Visible = False
        Me.SchoolIDDataGridViewTextBoxColumn.Width = 111
        '
        'selected
        '
        Me.selected.DataPropertyName = "selected"
        Me.selected.HeaderText = "selected"
        Me.selected.Name = "selected"
        Me.selected.Visible = False
        Me.selected.Width = 75
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 95
        '
        'DivisionDataGridViewTextBoxColumn
        '
        Me.DivisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DivisionDataGridViewTextBoxColumn.DataPropertyName = "Division"
        Me.DivisionDataGridViewTextBoxColumn.HeaderText = "Division"
        Me.DivisionDataGridViewTextBoxColumn.Name = "DivisionDataGridViewTextBoxColumn"
        Me.DivisionDataGridViewTextBoxColumn.Width = 111
        '
        'CityStateDataGridViewTextBoxColumn
        '
        Me.CityStateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CityStateDataGridViewTextBoxColumn.DataPropertyName = "CityState"
        Me.CityStateDataGridViewTextBoxColumn.HeaderText = "City, State"
        Me.CityStateDataGridViewTextBoxColumn.Name = "CityStateDataGridViewTextBoxColumn"
        Me.CityStateDataGridViewTextBoxColumn.Width = 126
        '
        'MilesAway
        '
        Me.MilesAway.DataPropertyName = "MilesAway"
        Me.MilesAway.HeaderText = "Miles Away"
        Me.MilesAway.Name = "MilesAway"
        Me.MilesAway.Width = 137
        '
        'LatitudeDataGridViewTextBoxColumn
        '
        Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
        Me.LatitudeDataGridViewTextBoxColumn.Width = 103
        '
        'LongitudeDataGridViewTextBoxColumn
        '
        Me.LongitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn"
        Me.LongitudeDataGridViewTextBoxColumn.Width = 116
        '
        'ContactNameDataGridViewTextBoxColumn
        '
        Me.ContactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName"
        Me.ContactNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ContactNameDataGridViewTextBoxColumn.Name = "ContactNameDataGridViewTextBoxColumn"
        Me.ContactNameDataGridViewTextBoxColumn.Width = 95
        '
        'ContactPhoneDataGridViewTextBoxColumn
        '
        Me.ContactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone"
        Me.ContactPhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.ContactPhoneDataGridViewTextBoxColumn.Name = "ContactPhoneDataGridViewTextBoxColumn"
        Me.ContactPhoneDataGridViewTextBoxColumn.Width = 98
        '
        'ContactEmailDataGridViewTextBoxColumn
        '
        Me.ContactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactEmail"
        Me.ContactEmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.ContactEmailDataGridViewTextBoxColumn.Name = "ContactEmailDataGridViewTextBoxColumn"
        Me.ContactEmailDataGridViewTextBoxColumn.Width = 90
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Visible = False
        Me.DescriptionDataGridViewTextBoxColumn.Width = 125
        '
        'WebsiteDataGridViewTextBoxColumn
        '
        Me.WebsiteDataGridViewTextBoxColumn.DataPropertyName = "Website"
        Me.WebsiteDataGridViewTextBoxColumn.HeaderText = "Website"
        Me.WebsiteDataGridViewTextBoxColumn.Name = "WebsiteDataGridViewTextBoxColumn"
        Me.WebsiteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WebsiteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.WebsiteDataGridViewTextBoxColumn.Visible = False
        Me.WebsiteDataGridViewTextBoxColumn.Width = 103
        '
        'CreateDateDataGridViewTextBoxColumn
        '
        Me.CreateDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate"
        Me.CreateDateDataGridViewTextBoxColumn.HeaderText = "CreateDate"
        Me.CreateDateDataGridViewTextBoxColumn.Name = "CreateDateDataGridViewTextBoxColumn"
        Me.CreateDateDataGridViewTextBoxColumn.Visible = False
        Me.CreateDateDataGridViewTextBoxColumn.Width = 128
        '
        'UpdateDateDataGridViewTextBoxColumn
        '
        Me.UpdateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.UpdateDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.UpdateDateDataGridViewTextBoxColumn.HeaderText = "Updated"
        Me.UpdateDateDataGridViewTextBoxColumn.Name = "UpdateDateDataGridViewTextBoxColumn"
        Me.UpdateDateDataGridViewTextBoxColumn.Width = 117
        '
        'HtmlDataGridViewTextBoxColumn
        '
        Me.HtmlDataGridViewTextBoxColumn.DataPropertyName = "Html"
        Me.HtmlDataGridViewTextBoxColumn.HeaderText = "Html"
        Me.HtmlDataGridViewTextBoxColumn.Name = "HtmlDataGridViewTextBoxColumn"
        Me.HtmlDataGridViewTextBoxColumn.Visible = False
        Me.HtmlDataGridViewTextBoxColumn.Width = 78
        '
        'SourceDataGridViewTextBoxColumn
        '
        Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "Source"
        Me.SourceDataGridViewTextBoxColumn.HeaderText = "Source"
        Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
        Me.SourceDataGridViewTextBoxColumn.Width = 102
        '
        'bsSchools
        '
        Me.bsSchools.DataMember = "School"
        Me.bsSchools.DataSource = Me.VbrData
        '
        'VbrData
        '
        Me.VbrData.DataSetName = "vbrData"
        Me.VbrData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.List)
        Me.TabControl1.Controls.Add(Me.Map)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(762, 514)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 3
        '
        'List
        '
        Me.List.Controls.Add(Me.dgv)
        Me.List.Location = New System.Drawing.Point(4, 37)
        Me.List.Name = "List"
        Me.List.Padding = New System.Windows.Forms.Padding(3)
        Me.List.Size = New System.Drawing.Size(754, 473)
        Me.List.TabIndex = 0
        Me.List.Text = "List"
        Me.List.UseVisualStyleBackColor = True
        '
        'Map
        '
        Me.Map.Controls.Add(Me.vbMap)
        Me.Map.Location = New System.Drawing.Point(4, 32)
        Me.Map.Name = "Map"
        Me.Map.Padding = New System.Windows.Forms.Padding(3)
        Me.Map.Size = New System.Drawing.Size(754, 478)
        Me.Map.TabIndex = 1
        Me.Map.Text = "Map"
        Me.Map.UseVisualStyleBackColor = True
        '
        'vbMap
        '
        Me.vbMap.AutoScroll = True
        Me.vbMap.AutoSize = True
        Me.vbMap.Bearing = 0!
        Me.vbMap.CanDragMap = True
        Me.vbMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vbMap.EmptyTileColor = System.Drawing.Color.Navy
        Me.vbMap.GrayScaleMode = False
        Me.vbMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.vbMap.LevelsKeepInMemmory = 5
        Me.vbMap.Location = New System.Drawing.Point(3, 3)
        Me.vbMap.MarkersEnabled = True
        Me.vbMap.MaxZoom = 14
        Me.vbMap.MinZoom = 4
        Me.vbMap.MouseWheelZoomEnabled = True
        Me.vbMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.vbMap.Name = "vbMap"
        Me.vbMap.NegativeMode = False
        Me.vbMap.PolygonsEnabled = False
        Me.vbMap.RetryLoadTile = 0
        Me.vbMap.RoutesEnabled = False
        Me.vbMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.vbMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.vbMap.ShowTileGridLines = False
        Me.vbMap.Size = New System.Drawing.Size(748, 472)
        Me.vbMap.TabIndex = 0
        Me.vbMap.Zoom = 4.0R
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 35)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBar1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1162, 516)
        Me.SplitContainer1.SplitterDistance = 764
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBar1
        '
        Me.GroupBar1.AllowDrop = True
        Me.GroupBar1.AnimatedSelection = False
        Me.GroupBar1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBar1.BeforeTouchSize = New System.Drawing.Size(392, 514)
        Me.GroupBar1.BorderColor = System.Drawing.Color.White
        Me.GroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GroupBar1.CollapseImage = CType(resources.GetObject("GroupBar1.CollapseImage"), System.Drawing.Image)
        Me.GroupBar1.Controls.Add(Me.Panel1)
        Me.GroupBar1.Controls.Add(Me.tv)
        Me.GroupBar1.Controls.Add(Me.html)
        Me.GroupBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBar1.ExpandButtonToolTip = Nothing
        Me.GroupBar1.ExpandImage = CType(resources.GetObject("GroupBar1.ExpandImage"), System.Drawing.Image)
        Me.GroupBar1.FlatLook = True
        Me.GroupBar1.ForeColor = System.Drawing.Color.White
        Me.GroupBar1.GroupBarDropDownToolTip = Nothing
        Me.GroupBar1.GroupBarItemHeight = 40
        Me.GroupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() {Me.Details, Me.Contact, Me.Settings})
        Me.GroupBar1.IndexOnVisibleItems = True
        Me.GroupBar1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBar1.MinimizeButtonToolTip = Nothing
        Me.GroupBar1.Name = "GroupBar1"
        Me.GroupBar1.NavigationPaneTooltip = Nothing
        Me.GroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
        Me.GroupBar1.SelectedItem = 1
        Me.GroupBar1.Size = New System.Drawing.Size(392, 514)
        Me.GroupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark
        Me.GroupBar1.TabIndex = 0
        Me.GroupBar1.Text = "GroupBar1"
        Me.GroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
        Me.GroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 394)
        Me.Panel1.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(DateTmLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(ContactNameLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NoteTextBox, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(NoteLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTmDateTimePicker, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContactNameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContactRepliedDateTimePicker, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(ContactRepliedLabel, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(392, 363)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'NoteTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.NoteTextBox, 2)
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKSchoolNotesBindingSource, "Note", True))
        Me.NoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NoteTextBox.Location = New System.Drawing.Point(3, 143)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(386, 217)
        Me.NoteTextBox.TabIndex = 15
        '
        'FKSchoolNotesBindingSource
        '
        Me.FKSchoolNotesBindingSource.AllowNew = True
        Me.FKSchoolNotesBindingSource.DataMember = "FK_School_Notes"
        Me.FKSchoolNotesBindingSource.DataSource = Me.bsSchools
        Me.FKSchoolNotesBindingSource.Sort = "Datetm DESC"
        '
        'DateTmDateTimePicker
        '
        Me.DateTmDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FKSchoolNotesBindingSource, "DateTm", True))
        Me.DateTmDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTmDateTimePicker.Location = New System.Drawing.Point(3, 33)
        Me.DateTmDateTimePicker.Name = "DateTmDateTimePicker"
        Me.DateTmDateTimePicker.Size = New System.Drawing.Size(190, 31)
        Me.DateTmDateTimePicker.TabIndex = 13
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKSchoolNotesBindingSource, "ContactName", True))
        Me.ContactNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactNameTextBox.Location = New System.Drawing.Point(199, 33)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(190, 31)
        Me.ContactNameTextBox.TabIndex = 17
        '
        'ContactRepliedDateTimePicker
        '
        Me.ContactRepliedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKSchoolNotesBindingSource, "ContactReplied", True))
        Me.ContactRepliedDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactRepliedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ContactRepliedDateTimePicker.Location = New System.Drawing.Point(199, 103)
        Me.ContactRepliedDateTimePicker.Name = "ContactRepliedDateTimePicker"
        Me.ContactRepliedDateTimePicker.ShowCheckBox = True
        Me.ContactRepliedDateTimePicker.Size = New System.Drawing.Size(190, 31)
        Me.ContactRepliedDateTimePicker.TabIndex = 19
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.FKSchoolNotesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(392, 31)
        Me.BindingNavigator1.TabIndex = 20
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        '
        'tv
        '
        Me.tv.CheckBoxes = True
        Me.tv.Location = New System.Drawing.Point(0, 120)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(220, 180)
        Me.tv.TabIndex = 1
        '
        'html
        '
        Me.html.AutoScroll = True
        Me.html.AutoScrollMinSize = New System.Drawing.Size(263, 461)
        Me.html.BackColor = System.Drawing.Color.White
        Me.html.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.html.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
        Me.html.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.html.DefaultFormat.BackgroundColor = System.Drawing.SystemColors.Control
        Me.html.DefaultFormat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.html.Location = New System.Drawing.Point(0, 40)
        Me.html.Name = "html"
        Me.html.Size = New System.Drawing.Size(289, 476)
        Me.html.TabIndex = 0
        Me.html.Text = "<title>Select Map Marker for Info</title>"
        Me.html.Title = "Select School for Info"
        '
        'Details
        '
        Me.Details.Client = Me.html
        Me.Details.Text = "Details"
        '
        'Contact
        '
        Me.Contact.Client = Me.Panel1
        Me.Contact.Text = "My Notes"
        '
        'Settings
        '
        Me.Settings.Client = Me.tv
        Me.Settings.Text = "Settings"
        '
        'bgwGeoTag
        '
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 581)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fMain"
        Me.Text = "vbRecruiter - From the Worlds Greatest Dad and Sexiest Husband."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchools, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbrData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.List.ResumeLayout(False)
        Me.Map.ResumeLayout(False)
        Me.Map.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBar1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.FKSchoolNotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.html, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status As ToolStripStatusLabel
    Friend WithEvents WipeDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgwUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents WithDownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WithoutDownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgv As DataGridView
    Friend WithEvents bsSchools As BindingSource
    Friend WithEvents VbrData As Data.vbrData
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents List As TabPage
    Friend WithEvents Map As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents vbMap As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents GeotagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgwGeoTag As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
    Friend WithEvents html As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
    Friend WithEvents Details As Syncfusion.Windows.Forms.Tools.GroupBarItem
    Friend WithEvents Settings As Syncfusion.Windows.Forms.Tools.GroupBarItem
    Friend WithEvents tv As TreeView
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrepVolleyballcomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LonestarPrepVolleyballcomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Contact As Syncfusion.Windows.Forms.Tools.GroupBarItem
    Friend WithEvents schoolCount As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DateTmDateTimePicker As DateTimePicker
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents ContactNameTextBox As TextBox
    Friend WithEvents ContactRepliedDateTimePicker As DateTimePicker
    Friend WithEvents FKSchoolNotesBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents SchoolIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents selected As DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DivisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityStateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MilesAway As DataGridViewTextBoxColumn
    Friend WithEvents LatitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LongitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WebsiteDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents CreateDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdateDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HtmlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
End Class
