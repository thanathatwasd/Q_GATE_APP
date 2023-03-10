<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintDefect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintDefect))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.IN_FO = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.values = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.detail_code = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'IN_FO
        '
        Me.IN_FO.AutoSize = True
        Me.IN_FO.Location = New System.Drawing.Point(40, 143)
        Me.IN_FO.Name = "IN_FO"
        Me.IN_FO.Size = New System.Drawing.Size(38, 13)
        Me.IN_FO.TabIndex = 0
        Me.IN_FO.Text = "IN_FO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Label14"
        '
        'values
        '
        Me.values.AutoSize = True
        Me.values.Location = New System.Drawing.Point(180, 209)
        Me.values.Name = "values"
        Me.values.Size = New System.Drawing.Size(38, 13)
        Me.values.TabIndex = 2
        Me.values.Text = "values"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Location = New System.Drawing.Point(410, 174)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(23, 13)
        Me.title.TabIndex = 4
        Me.title.Text = "title"
        '
        'detail_code
        '
        Me.detail_code.AutoSize = True
        Me.detail_code.Location = New System.Drawing.Point(194, 259)
        Me.detail_code.Name = "detail_code"
        Me.detail_code.Size = New System.Drawing.Size(62, 13)
        Me.detail_code.TabIndex = 5
        Me.detail_code.Text = "detail_code"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(439, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 152)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 73)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "typeProduct"
        '
        'PrintDefect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.detail_code)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.values)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.IN_FO)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrintDefect"
        Me.Text = "PrintDefect"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents IN_FO As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents values As Label
    Friend WithEvents title As Label
    Friend WithEvents detail_code As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
