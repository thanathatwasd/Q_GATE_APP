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
        Me.tbLoginAdmin1 = New System.Windows.Forms.TextBox()
        Me.pbBackToLogin1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pbBackToLogin1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbLoginAdmin1
        '
        Me.tbLoginAdmin1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbLoginAdmin1.Font = New System.Drawing.Font("MADE Dillan", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLoginAdmin1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbLoginAdmin1.Location = New System.Drawing.Point(451, 302)
        Me.tbLoginAdmin1.Name = "tbLoginAdmin1"
        Me.tbLoginAdmin1.Size = New System.Drawing.Size(278, 44)
        Me.tbLoginAdmin1.TabIndex = 1
        '
        'pbBackToLogin1
        '
        Me.pbBackToLogin1.BackColor = System.Drawing.Color.Transparent
        Me.pbBackToLogin1.Location = New System.Drawing.Point(25, 480)
        Me.pbBackToLogin1.Name = "pbBackToLogin1"
        Me.pbBackToLogin1.Size = New System.Drawing.Size(154, 69)
        Me.pbBackToLogin1.TabIndex = 2
        Me.pbBackToLogin1.TabStop = False
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'qgateLoginAdmin
        '
        Me.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.LINE_ALBUM_หน้าจอ_Q_gate_230220_10
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbBackToLogin1)
        Me.Controls.Add(Me.tbLoginAdmin1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateLoginAdmin"
        CType(Me.pbBackToLogin1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbLoginAdmin As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbBackToLogin As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents tbLoginAdmin1 As TextBox
    Friend WithEvents pbBackToLogin1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
End Class
