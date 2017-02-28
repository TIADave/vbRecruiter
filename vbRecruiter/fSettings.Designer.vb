<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnCancel = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.AutoLabel5 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(26, 41)
        Me.AutoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(195, 28)
        Me.AutoLabel1.TabIndex = 0
        Me.AutoLabel1.Text = "PrepVolleball Details:"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(105, 81)
        Me.AutoLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(112, 28)
        Me.AutoLabel2.TabIndex = 1
        Me.AutoLabel2.Text = "User Name:"
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(449, 80)
        Me.AutoLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(97, 28)
        Me.AutoLabel3.TabIndex = 2
        Me.AutoLabel3.Text = "Password:"
        '
        'AutoLabel4
        '
        Me.AutoLabel4.Location = New System.Drawing.Point(163, 134)
        Me.AutoLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AutoLabel4.Name = "AutoLabel4"
        Me.AutoLabel4.Size = New System.Drawing.Size(51, 28)
        Me.AutoLabel4.TabIndex = 3
        Me.AutoLabel4.Text = "URL:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(226, 73)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(204, 34)
        Me.txtUser.TabIndex = 4
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(556, 73)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(204, 34)
        Me.txtPW.TabIndex = 5
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(226, 128)
        Me.txtURL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(534, 34)
        Me.txtURL.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(517, 236)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(260, 48)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'btnOK
        '
        Me.btnOK.BeforeTouchSize = New System.Drawing.Size(111, 40)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.IsBackStageButton = False
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(111, 40)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.BeforeTouchSize = New System.Drawing.Size(111, 40)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.IsBackStageButton = False
        Me.btnCancel.Location = New System.Drawing.Point(143, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(226, 179)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(534, 34)
        Me.txtAddress.TabIndex = 9
        '
        'AutoLabel5
        '
        Me.AutoLabel5.Location = New System.Drawing.Point(70, 185)
        Me.AutoLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AutoLabel5.Name = "AutoLabel5"
        Me.AutoLabel5.Size = New System.Drawing.Size(144, 28)
        Me.AutoLabel5.TabIndex = 8
        Me.AutoLabel5.Text = "Home Address:"
        '
        'fSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 306)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.AutoLabel5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.AutoLabel4)
        Me.Controls.Add(Me.AutoLabel3)
        Me.Controls.Add(Me.AutoLabel2)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents btnCancel As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents AutoLabel5 As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
