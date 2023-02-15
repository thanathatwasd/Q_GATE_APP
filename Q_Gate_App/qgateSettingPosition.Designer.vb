<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class qgateSettingPosition
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbConfirm = New System.Windows.Forms.PictureBox()
        Me.cbSelectZone = New System.Windows.Forms.ComboBox()
        Me.cbSelectStation = New System.Windows.Forms.ComboBox()
        Me.cbSelectPhase = New System.Windows.Forms.ComboBox()
        Me.pbBackToMenu = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackToMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.SettingStation
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbConfirm)
        Me.Panel1.Controls.Add(Me.cbSelectZone)
        Me.Panel1.Controls.Add(Me.cbSelectStation)
        Me.Panel1.Controls.Add(Me.cbSelectPhase)
        Me.Panel1.Controls.Add(Me.pbBackToMenu)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1068, 738)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(616, 463)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Select Station"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(616, 357)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Select Zone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(616, 261)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select Position"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Visible = False
        '
        'pbConfirm
        '
        Me.pbConfirm.BackColor = System.Drawing.Color.Transparent
        Me.pbConfirm.Location = New System.Drawing.Point(845, 630)
        Me.pbConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbConfirm.Name = "pbConfirm"
        Me.pbConfirm.Size = New System.Drawing.Size(197, 95)
        Me.pbConfirm.TabIndex = 7
        Me.pbConfirm.TabStop = False
        '
        'cbSelectZone
        '
        Me.cbSelectZone.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbSelectZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectZone.Font = New System.Drawing.Font("MADE Dillan", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSelectZone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cbSelectZone.FormattingEnabled = True
        Me.cbSelectZone.Location = New System.Drawing.Point(483, 396)
        Me.cbSelectZone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSelectZone.Name = "cbSelectZone"
        Me.cbSelectZone.Size = New System.Drawing.Size(499, 45)
        Me.cbSelectZone.TabIndex = 1
        '
        'cbSelectStation
        '
        Me.cbSelectStation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbSelectStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectStation.Font = New System.Drawing.Font("MADE Dillan", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSelectStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cbSelectStation.FormattingEnabled = True
        Me.cbSelectStation.Location = New System.Drawing.Point(483, 501)
        Me.cbSelectStation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSelectStation.Name = "cbSelectStation"
        Me.cbSelectStation.Size = New System.Drawing.Size(499, 45)
        Me.cbSelectStation.TabIndex = 2
        '
        'cbSelectPhase
        '
        Me.cbSelectPhase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbSelectPhase.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.cbSelectPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectPhase.Font = New System.Drawing.Font("MADE Dillan", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSelectPhase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cbSelectPhase.FormattingEnabled = True
        Me.cbSelectPhase.Location = New System.Drawing.Point(483, 299)
        Me.cbSelectPhase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSelectPhase.Name = "cbSelectPhase"
        Me.cbSelectPhase.Size = New System.Drawing.Size(499, 45)
        Me.cbSelectPhase.TabIndex = 0
        Me.cbSelectPhase.UseWaitCursor = True
        '
        'pbBackToMenu
        '
        Me.pbBackToMenu.BackColor = System.Drawing.Color.Transparent
        Me.pbBackToMenu.Location = New System.Drawing.Point(35, 630)
        Me.pbBackToMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbBackToMenu.Name = "pbBackToMenu"
        Me.pbBackToMenu.Size = New System.Drawing.Size(203, 95)
        Me.pbBackToMenu.TabIndex = 0
        Me.pbBackToMenu.TabStop = False
        '
        'qgateSettingPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1067, 738)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "qgateSettingPosition"
        Me.Text = "qgateSettingPosition"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackToMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbSelectPhase As ComboBox
    Friend WithEvents cbSelectZone As ComboBox
    Friend WithEvents cbSelectStation As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbBackToMenu As PictureBox
    Friend WithEvents pbConfirm As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
