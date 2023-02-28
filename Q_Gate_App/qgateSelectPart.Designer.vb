<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class qgateSelectPart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qgateSelectPart))
        Me.cbSelectPart = New System.Windows.Forms.ComboBox()
        Me.pbConfirm = New System.Windows.Forms.PictureBox()
        Me.pbCancelPart = New System.Windows.Forms.PictureBox()
        Me.lbStation = New System.Windows.Forms.Label()
        Me.lbZone = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        CType(Me.pbConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCancelPart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSelectPart
        '
        Me.cbSelectPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectPart.Font = New System.Drawing.Font("MADE Dillan", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSelectPart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cbSelectPart.FormattingEnabled = True
        Me.cbSelectPart.Location = New System.Drawing.Point(80, 305)
        Me.cbSelectPart.Name = "cbSelectPart"
        Me.cbSelectPart.Size = New System.Drawing.Size(334, 43)
        Me.cbSelectPart.TabIndex = 0
        '
        'pbConfirm
        '
        Me.pbConfirm.BackColor = System.Drawing.Color.Transparent
        Me.pbConfirm.Location = New System.Drawing.Point(620, 508)
        Me.pbConfirm.Name = "pbConfirm"
        Me.pbConfirm.Size = New System.Drawing.Size(168, 80)
        Me.pbConfirm.TabIndex = 2
        Me.pbConfirm.TabStop = False
        '
        'pbCancelPart
        '
        Me.pbCancelPart.BackColor = System.Drawing.Color.Transparent
        Me.pbCancelPart.Location = New System.Drawing.Point(23, 508)
        Me.pbCancelPart.Name = "pbCancelPart"
        Me.pbCancelPart.Size = New System.Drawing.Size(159, 80)
        Me.pbCancelPart.TabIndex = 1
        Me.pbCancelPart.TabStop = False
        '
        'lbStation
        '
        Me.lbStation.AutoSize = True
        Me.lbStation.BackColor = System.Drawing.Color.Transparent
        Me.lbStation.Font = New System.Drawing.Font("MADE Dillan", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbStation.Location = New System.Drawing.Point(748, 49)
        Me.lbStation.Name = "lbStation"
        Me.lbStation.Size = New System.Drawing.Size(0, 24)
        Me.lbStation.TabIndex = 5
        '
        'lbZone
        '
        Me.lbZone.AutoSize = True
        Me.lbZone.BackColor = System.Drawing.Color.Transparent
        Me.lbZone.Font = New System.Drawing.Font("MADE Dillan", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbZone.Location = New System.Drawing.Point(463, 49)
        Me.lbZone.Name = "lbZone"
        Me.lbZone.Size = New System.Drawing.Size(0, 24)
        Me.lbZone.TabIndex = 4
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MADE Dillan", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MADE Dillan", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(357, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "User :"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.BackColor = System.Drawing.Color.Transparent
        Me.lbUserName.Font = New System.Drawing.Font("MADE Dillan", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbUserName.Location = New System.Drawing.Point(429, 12)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(0, 24)
        Me.lbUserName.TabIndex = 47
        '
        'qgateSelectPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbStation)
        Me.Controls.Add(Me.lbZone)
        Me.Controls.Add(Me.pbConfirm)
        Me.Controls.Add(Me.pbCancelPart)
        Me.Controls.Add(Me.cbSelectPart)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateSelectPart"
        Me.Text = "qgateSelectPart"
        CType(Me.pbConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCancelPart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbSelectPart As ComboBox
    Friend WithEvents pbCancelPart As PictureBox
    Friend WithEvents pbConfirm As PictureBox
    Friend WithEvents lbStation As Label
    Friend WithEvents lbZone As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbUserName As Label
End Class
