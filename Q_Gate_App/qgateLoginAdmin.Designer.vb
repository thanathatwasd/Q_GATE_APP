<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qgateLoginAdmin
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbBackToLogin = New System.Windows.Forms.PictureBox()
        Me.tbLoginAdmin = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbBackToLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.Login_Admin
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbBackToLogin)
        Me.Panel1.Controls.Add(Me.tbLoginAdmin)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 602)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Visible = False
        '
        'pbBackToLogin
        '
        Me.pbBackToLogin.BackColor = System.Drawing.Color.Transparent
        Me.pbBackToLogin.Location = New System.Drawing.Point(22, 508)
        Me.pbBackToLogin.Name = "pbBackToLogin"
        Me.pbBackToLogin.Size = New System.Drawing.Size(163, 81)
        Me.pbBackToLogin.TabIndex = 2
        Me.pbBackToLogin.TabStop = False
        '
        'tbLoginAdmin
        '
        Me.tbLoginAdmin.BackColor = System.Drawing.SystemColors.Window
        Me.tbLoginAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbLoginAdmin.Font = New System.Drawing.Font("MADE Dillan", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLoginAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbLoginAdmin.Location = New System.Drawing.Point(461, 324)
        Me.tbLoginAdmin.Multiline = True
        Me.tbLoginAdmin.Name = "tbLoginAdmin"
        Me.tbLoginAdmin.Size = New System.Drawing.Size(286, 47)
        Me.tbLoginAdmin.TabIndex = 0
        '
        'qgateLoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateLoginAdmin"
        Me.Text = "qgateLoginAdmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbBackToLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbLoginAdmin As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbBackToLogin As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
