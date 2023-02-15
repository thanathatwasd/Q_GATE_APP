<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class qgateLogin
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
        Me.tbLoginUser = New System.Windows.Forms.TextBox()
        Me.pbConfig = New System.Windows.Forms.PictureBox()
        Me.pbExit = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pbConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbLoginUser
        '
        Me.tbLoginUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbLoginUser.Font = New System.Drawing.Font("MADE Dillan", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLoginUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbLoginUser.Location = New System.Drawing.Point(134, 380)
        Me.tbLoginUser.Name = "tbLoginUser"
        Me.tbLoginUser.Size = New System.Drawing.Size(288, 44)
        Me.tbLoginUser.TabIndex = 0
        '
        'pbConfig
        '
        Me.pbConfig.BackColor = System.Drawing.Color.Transparent
        Me.pbConfig.Location = New System.Drawing.Point(695, -2)
        Me.pbConfig.Name = "pbConfig"
        Me.pbConfig.Size = New System.Drawing.Size(107, 95)
        Me.pbConfig.TabIndex = 3
        Me.pbConfig.TabStop = False
        '
        'pbExit
        '
        Me.pbExit.BackColor = System.Drawing.Color.Transparent
        Me.pbExit.Location = New System.Drawing.Point(627, 506)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(161, 82)
        Me.pbExit.TabIndex = 4
        Me.pbExit.TabStop = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Visible = False
        '
        'qgateLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.Login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbExit)
        Me.Controls.Add(Me.pbConfig)
        Me.Controls.Add(Me.tbLoginUser)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "qgate"
        CType(Me.pbConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbLoginUser As TextBox
    Friend WithEvents pbConfig As PictureBox
    Friend WithEvents pbExit As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
