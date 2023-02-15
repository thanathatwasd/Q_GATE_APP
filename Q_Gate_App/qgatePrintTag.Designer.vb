<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qgateprintTag
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
        Me.pbReprintQGate = New System.Windows.Forms.PictureBox()
        Me.pbReprintDefect = New System.Windows.Forms.PictureBox()
        Me.pbBacktoMenu = New System.Windows.Forms.PictureBox()
        CType(Me.pbReprintQGate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReprintDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBacktoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbReprintQGate
        '
        Me.pbReprintQGate.BackColor = System.Drawing.Color.Transparent
        Me.pbReprintQGate.Location = New System.Drawing.Point(444, 284)
        Me.pbReprintQGate.Name = "pbReprintQGate"
        Me.pbReprintQGate.Size = New System.Drawing.Size(245, 80)
        Me.pbReprintQGate.TabIndex = 0
        Me.pbReprintQGate.TabStop = False
        '
        'pbReprintDefect
        '
        Me.pbReprintDefect.BackColor = System.Drawing.Color.Transparent
        Me.pbReprintDefect.Location = New System.Drawing.Point(444, 386)
        Me.pbReprintDefect.Name = "pbReprintDefect"
        Me.pbReprintDefect.Size = New System.Drawing.Size(245, 82)
        Me.pbReprintDefect.TabIndex = 1
        Me.pbReprintDefect.TabStop = False
        '
        'pbBacktoMenu
        '
        Me.pbBacktoMenu.BackColor = System.Drawing.Color.Transparent
        Me.pbBacktoMenu.Location = New System.Drawing.Point(25, 509)
        Me.pbBacktoMenu.Name = "pbBacktoMenu"
        Me.pbBacktoMenu.Size = New System.Drawing.Size(155, 79)
        Me.pbBacktoMenu.TabIndex = 2
        Me.pbBacktoMenu.TabStop = False
        '
        'qgateprintTag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.Reprint
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pbBacktoMenu)
        Me.Controls.Add(Me.pbReprintDefect)
        Me.Controls.Add(Me.pbReprintQGate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateprintTag"
        Me.Text = "qgateReprintTag"
        CType(Me.pbReprintQGate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReprintDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBacktoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbReprintQGate As PictureBox
    Friend WithEvents pbReprintDefect As PictureBox
    Friend WithEvents pbBacktoMenu As PictureBox
End Class
