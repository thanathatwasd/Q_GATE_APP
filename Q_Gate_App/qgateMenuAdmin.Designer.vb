<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qgateMenuAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qgateMenuAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbLogout = New System.Windows.Forms.PictureBox()
        Me.pbSetStation = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSetStation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbLogout)
        Me.Panel1.Controls.Add(Me.pbSetStation)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 600)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Visible = False
        '
        'pbLogout
        '
        Me.pbLogout.BackColor = System.Drawing.Color.Transparent
        Me.pbLogout.Location = New System.Drawing.Point(24, 511)
        Me.pbLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.pbLogout.Name = "pbLogout"
        Me.pbLogout.Size = New System.Drawing.Size(161, 78)
        Me.pbLogout.TabIndex = 4
        Me.pbLogout.TabStop = False
        '
        'pbSetStation
        '
        Me.pbSetStation.BackColor = System.Drawing.Color.Transparent
        Me.pbSetStation.Location = New System.Drawing.Point(122, 264)
        Me.pbSetStation.Margin = New System.Windows.Forms.Padding(2)
        Me.pbSetStation.Name = "pbSetStation"
        Me.pbSetStation.Size = New System.Drawing.Size(262, 84)
        Me.pbSetStation.TabIndex = 3
        Me.pbSetStation.TabStop = False
        '
        'qgateMenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "qgateMenuAdmin"
        Me.Text = "qgateMenuAdmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSetStation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbLogout As PictureBox
    Friend WithEvents pbSetStation As PictureBox
    Friend WithEvents Label1 As Label
End Class
