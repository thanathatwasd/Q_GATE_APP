<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class qgateDefectNg
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.lbStation = New System.Windows.Forms.Label()
        Me.lbZone = New System.Windows.Forms.Label()
        Me.lvDefectCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvDefectDetail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbNamedefect = New System.Windows.Forms.Label()
        Me.tbPartNo = New System.Windows.Forms.TextBox()
        Me.CbNumProduct = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(395, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "User : "
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.BackColor = System.Drawing.Color.Transparent
        Me.lbUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbUserName.Location = New System.Drawing.Point(472, 9)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(19, 25)
        Me.lbUserName.TabIndex = 47
        Me.lbUserName.Text = "-"
        '
        'lbStation
        '
        Me.lbStation.AutoSize = True
        Me.lbStation.BackColor = System.Drawing.Color.Transparent
        Me.lbStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbStation.Location = New System.Drawing.Point(722, 43)
        Me.lbStation.Name = "lbStation"
        Me.lbStation.Size = New System.Drawing.Size(16, 24)
        Me.lbStation.TabIndex = 46
        Me.lbStation.Text = "-"
        '
        'lbZone
        '
        Me.lbZone.AutoSize = True
        Me.lbZone.BackColor = System.Drawing.Color.Transparent
        Me.lbZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbZone.Location = New System.Drawing.Point(456, 43)
        Me.lbZone.Name = "lbZone"
        Me.lbZone.Size = New System.Drawing.Size(16, 24)
        Me.lbZone.TabIndex = 45
        Me.lbZone.Text = "-"
        '
        'lvDefectCode
        '
        Me.lvDefectCode.Text = "Defec Code"
        Me.lvDefectCode.Width = 180
        '
        'lvDefectDetail
        '
        Me.lvDefectDetail.Text = "Defect Detail"
        Me.lvDefectDetail.Width = 540
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvDefectCode, Me.lvDefectDetail})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(28, 151)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(726, 311)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(30, 483)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 59)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(609, 483)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 59)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lbNamedefect
        '
        Me.lbNamedefect.AutoSize = True
        Me.lbNamedefect.BackColor = System.Drawing.Color.Transparent
        Me.lbNamedefect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNamedefect.ForeColor = System.Drawing.Color.White
        Me.lbNamedefect.Location = New System.Drawing.Point(29, 103)
        Me.lbNamedefect.Name = "lbNamedefect"
        Me.lbNamedefect.Size = New System.Drawing.Size(19, 25)
        Me.lbNamedefect.TabIndex = 4
        Me.lbNamedefect.Text = "-"
        '
        'tbPartNo
        '
        Me.tbPartNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPartNo.Location = New System.Drawing.Point(157, 100)
        Me.tbPartNo.Name = "tbPartNo"
        Me.tbPartNo.Size = New System.Drawing.Size(325, 32)
        Me.tbPartNo.TabIndex = 49
        '
        'CbNumProduct
        '
        Me.CbNumProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNumProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNumProduct.FormattingEnabled = True
        Me.CbNumProduct.Location = New System.Drawing.Point(157, 99)
        Me.CbNumProduct.Name = "CbNumProduct"
        Me.CbNumProduct.Size = New System.Drawing.Size(175, 33)
        Me.CbNumProduct.TabIndex = 50
        '
        'qgateDefectNg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.LINE_ALBUM_หน้าจอ_Q_gate_230222_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.CbNumProduct)
        Me.Controls.Add(Me.tbPartNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbUserName)
        Me.Controls.Add(Me.lbStation)
        Me.Controls.Add(Me.lbZone)
        Me.Controls.Add(Me.lbNamedefect)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateDefectNg"
        Me.Text = "qgateDefectNg"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents lbStation As Label
    Friend WithEvents lbZone As Label
    Friend WithEvents lvDefectCode As ColumnHeader
    Friend WithEvents lvDefectDetail As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbNamedefect As Label
    Friend WithEvents tbPartNo As TextBox
    Friend WithEvents CbNumProduct As ComboBox
End Class
