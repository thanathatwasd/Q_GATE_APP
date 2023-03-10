<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qgateReprintTag
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
        Me.SuspendLayout()
        '
        'qgateReprintTag
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "qgateReprintTag"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvDetail As ListView
    Friend WithEvents lvid As ColumnHeader
    Friend WithEvents lvPartNo As ColumnHeader
    Friend WithEvents lvLotNO As ColumnHeader
    Friend WithEvents lvBoxNo As ColumnHeader
    Friend WithEvents cbCalandar As DateTimePicker
    Friend WithEvents CbPartNum As ComboBox
    Friend WithEvents CbLotNum As ComboBox
    Friend WithEvents lbStation As Label
    Friend WithEvents lbZone As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbPrint As PictureBox
    Friend WithEvents pbClear As PictureBox
    Friend WithEvents pbBackReprintToMenu As PictureBox
    Friend WithEvents pnListPrint As Panel
End Class
