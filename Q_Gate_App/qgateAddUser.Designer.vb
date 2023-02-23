<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qgateAddUser
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
        Me.tbAddUser = New System.Windows.Forms.TextBox()
        Me.btnAddUser = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btnAddUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbAddUser
        '
        Me.tbAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddUser.Location = New System.Drawing.Point(89, 57)
        Me.tbAddUser.Name = "tbAddUser"
        Me.tbAddUser.Size = New System.Drawing.Size(292, 38)
        Me.tbAddUser.TabIndex = 1
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.Transparent
        Me.btnAddUser.Location = New System.Drawing.Point(260, 126)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(84, 48)
        Me.btnAddUser.TabIndex = 2
        Me.btnAddUser.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(125, 126)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 48)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.TabStop = False
        '
        'qgateAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.LINE_ALBUM_Alert_and_button_230220_4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(470, 230)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.tbAddUser)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateAddUser"
        Me.Text = "qgateAddUser"
        CType(Me.btnAddUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As PictureBox
    Friend WithEvents tbAddUser As TextBox
    Friend WithEvents btnAddUser As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
