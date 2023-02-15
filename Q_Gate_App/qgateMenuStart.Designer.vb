<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qgateMenuStart
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
        Me.pbBacktoMenu = New System.Windows.Forms.PictureBox()
        Me.pbNonDMC = New System.Windows.Forms.PictureBox()
        Me.pbDMC = New System.Windows.Forms.PictureBox()
        CType(Me.pbBacktoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNonDMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbBacktoMenu
        '
        Me.pbBacktoMenu.BackColor = System.Drawing.Color.Transparent
        Me.pbBacktoMenu.Location = New System.Drawing.Point(28, 514)
        Me.pbBacktoMenu.Name = "pbBacktoMenu"
        Me.pbBacktoMenu.Size = New System.Drawing.Size(149, 69)
        Me.pbBacktoMenu.TabIndex = 6
        Me.pbBacktoMenu.TabStop = False
        '
        'pbNonDMC
        '
        Me.pbNonDMC.BackColor = System.Drawing.Color.Transparent
        Me.pbNonDMC.Location = New System.Drawing.Point(275, 386)
        Me.pbNonDMC.Name = "pbNonDMC"
        Me.pbNonDMC.Size = New System.Drawing.Size(254, 87)
        Me.pbNonDMC.TabIndex = 1
        Me.pbNonDMC.TabStop = False
        '
        'pbDMC
        '
        Me.pbDMC.BackColor = System.Drawing.Color.Transparent
        Me.pbDMC.Location = New System.Drawing.Point(275, 275)
        Me.pbDMC.Name = "pbDMC"
        Me.pbDMC.Size = New System.Drawing.Size(254, 88)
        Me.pbDMC.TabIndex = 0
        Me.pbDMC.TabStop = False
        '
        'qgateMenuStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.MenuStart
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pbBacktoMenu)
        Me.Controls.Add(Me.pbNonDMC)
        Me.Controls.Add(Me.pbDMC)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateMenuStart"
        Me.Text = "qgateMenuStart"
        CType(Me.pbBacktoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNonDMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbDMC As PictureBox
    Friend WithEvents pbNonDMC As PictureBox
    Friend WithEvents pbBacktoMenu As PictureBox
End Class
