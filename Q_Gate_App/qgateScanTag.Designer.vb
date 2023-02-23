<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class qgateScanTag
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.lbpart = New System.Windows.Forms.Label()
        Me.pbBackToMenu = New System.Windows.Forms.PictureBox()
        Me.lbStation = New System.Windows.Forms.Label()
        Me.lbZone = New System.Windows.Forms.Label()
        Me.tbScanTag = New System.Windows.Forms.TextBox()
        Me.pbSelectModel = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackToMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSelectModel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.ScanTagFA_1
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbUserName)
        Me.Panel2.Controls.Add(Me.lbpart)
        Me.Panel2.Controls.Add(Me.pbBackToMenu)
        Me.Panel2.Controls.Add(Me.lbStation)
        Me.Panel2.Controls.Add(Me.lbZone)
        Me.Panel2.Controls.Add(Me.tbScanTag)
        Me.Panel2.Controls.Add(Me.pbSelectModel)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 600)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.LINE_ALBUM_Alert_and_button_230222_0_removebg_preview_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(632, 509)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 79)
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(425, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "User : "
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.BackColor = System.Drawing.Color.Transparent
        Me.lbUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbUserName.Location = New System.Drawing.Point(502, 9)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(19, 25)
        Me.lbUserName.TabIndex = 47
        Me.lbUserName.Text = "-"
        '
        'lbpart
        '
        Me.lbpart.AutoSize = True
        Me.lbpart.BackColor = System.Drawing.Color.Transparent
        Me.lbpart.Location = New System.Drawing.Point(25, 102)
        Me.lbpart.Name = "lbpart"
        Me.lbpart.Size = New System.Drawing.Size(0, 13)
        Me.lbpart.TabIndex = 4
        Me.lbpart.Visible = False
        '
        'pbBackToMenu
        '
        Me.pbBackToMenu.BackColor = System.Drawing.Color.Transparent
        Me.pbBackToMenu.Location = New System.Drawing.Point(28, 509)
        Me.pbBackToMenu.Name = "pbBackToMenu"
        Me.pbBackToMenu.Size = New System.Drawing.Size(154, 79)
        Me.pbBackToMenu.TabIndex = 3
        Me.pbBackToMenu.TabStop = False
        '
        'lbStation
        '
        Me.lbStation.AutoSize = True
        Me.lbStation.BackColor = System.Drawing.Color.Transparent
        Me.lbStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbStation.Location = New System.Drawing.Point(751, 47)
        Me.lbStation.Name = "lbStation"
        Me.lbStation.Size = New System.Drawing.Size(0, 25)
        Me.lbStation.TabIndex = 3
        '
        'lbZone
        '
        Me.lbZone.AutoSize = True
        Me.lbZone.BackColor = System.Drawing.Color.Transparent
        Me.lbZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbZone.Location = New System.Drawing.Point(466, 47)
        Me.lbZone.Name = "lbZone"
        Me.lbZone.Size = New System.Drawing.Size(17, 25)
        Me.lbZone.TabIndex = 2
        Me.lbZone.Text = " "
        '
        'tbScanTag
        '
        Me.tbScanTag.BackColor = System.Drawing.Color.White
        Me.tbScanTag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbScanTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbScanTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbScanTag.Location = New System.Drawing.Point(121, 304)
        Me.tbScanTag.Name = "tbScanTag"
        Me.tbScanTag.Size = New System.Drawing.Size(287, 38)
        Me.tbScanTag.TabIndex = 0
        '
        'pbSelectModel
        '
        Me.pbSelectModel.BackColor = System.Drawing.Color.Transparent
        Me.pbSelectModel.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.LINE_ALBUM_Alert_and_button_230222_1_removebg_preview
        Me.pbSelectModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSelectModel.Location = New System.Drawing.Point(701, 91)
        Me.pbSelectModel.Name = "pbSelectModel"
        Me.pbSelectModel.Size = New System.Drawing.Size(100, 92)
        Me.pbSelectModel.TabIndex = 2
        Me.pbSelectModel.TabStop = False
        '
        'qgateScanTag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateScanTag"
        Me.Text = "qgateScanTag"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackToMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSelectModel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbScanTag As TextBox
    Friend WithEvents pbSelectModel As PictureBox
    Friend WithEvents pbBackToMenu As PictureBox
    Friend WithEvents lbZone As Label
    Friend WithEvents lbStation As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbpart As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
