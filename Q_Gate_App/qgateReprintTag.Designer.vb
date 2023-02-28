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
        Me.lvDetail = New System.Windows.Forms.ListView()
        Me.lvid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvPartNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLotNO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvBoxNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbCalandar = New System.Windows.Forms.DateTimePicker()
        Me.CbPartNum = New System.Windows.Forms.ComboBox()
        Me.CbLotNum = New System.Windows.Forms.ComboBox()
        Me.lbStation = New System.Windows.Forms.Label()
        Me.lbZone = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbPrint = New System.Windows.Forms.PictureBox()
        Me.pbClear = New System.Windows.Forms.PictureBox()
        Me.pbBackReprintToMenu = New System.Windows.Forms.PictureBox()
        Me.pnListPrint = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackReprintToMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnListPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvDetail
        '
        Me.lvDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvid, Me.lvPartNo, Me.lvLotNO, Me.lvBoxNo})
        Me.lvDetail.Font = New System.Drawing.Font("MADE Dillan", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDetail.FullRowSelect = True
        Me.lvDetail.HideSelection = False
        Me.lvDetail.Location = New System.Drawing.Point(0, 59)
        Me.lvDetail.Name = "lvDetail"
        Me.lvDetail.Size = New System.Drawing.Size(751, 276)
        Me.lvDetail.TabIndex = 4
        Me.lvDetail.UseCompatibleStateImageBehavior = False
        Me.lvDetail.View = System.Windows.Forms.View.Details
        '
        'lvid
        '
        Me.lvid.Text = "ID"
        '
        'lvPartNo
        '
        Me.lvPartNo.Text = "PART NO"
        Me.lvPartNo.Width = 413
        '
        'lvLotNO
        '
        Me.lvLotNO.Text = "LOT NO"
        Me.lvLotNO.Width = 137
        '
        'lvBoxNo
        '
        Me.lvBoxNo.Text = "BOX NO"
        Me.lvBoxNo.Width = 136
        '
        'cbCalandar
        '
        Me.cbCalandar.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbCalandar.Font = New System.Drawing.Font("MADE Dillan", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCalandar.Location = New System.Drawing.Point(68, 13)
        Me.cbCalandar.Name = "cbCalandar"
        Me.cbCalandar.Size = New System.Drawing.Size(196, 29)
        Me.cbCalandar.TabIndex = 0
        Me.cbCalandar.Value = New Date(2023, 2, 10, 0, 0, 0, 0)
        '
        'CbPartNum
        '
        Me.CbPartNum.BackColor = System.Drawing.Color.White
        Me.CbPartNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPartNum.Font = New System.Drawing.Font("MADE Dillan", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPartNum.FormattingEnabled = True
        Me.CbPartNum.Location = New System.Drawing.Point(369, 13)
        Me.CbPartNum.Name = "CbPartNum"
        Me.CbPartNum.Size = New System.Drawing.Size(197, 29)
        Me.CbPartNum.TabIndex = 1
        '
        'CbLotNum
        '
        Me.CbLotNum.BackColor = System.Drawing.Color.White
        Me.CbLotNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLotNum.Font = New System.Drawing.Font("MADE Dillan", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbLotNum.FormattingEnabled = True
        Me.CbLotNum.Location = New System.Drawing.Point(661, 15)
        Me.CbLotNum.Name = "CbLotNum"
        Me.CbLotNum.Size = New System.Drawing.Size(85, 30)
        Me.CbLotNum.TabIndex = 2
        '
        'lbStation
        '
        Me.lbStation.AutoSize = True
        Me.lbStation.BackColor = System.Drawing.Color.Transparent
        Me.lbStation.Font = New System.Drawing.Font("MADE Dillan", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbStation.Location = New System.Drawing.Point(740, 49)
        Me.lbStation.Name = "lbStation"
        Me.lbStation.Size = New System.Drawing.Size(0, 22)
        Me.lbStation.TabIndex = 19
        '
        'lbZone
        '
        Me.lbZone.AutoSize = True
        Me.lbZone.BackColor = System.Drawing.Color.Transparent
        Me.lbZone.Font = New System.Drawing.Font("MADE Dillan", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbZone.Location = New System.Drawing.Point(464, 49)
        Me.lbZone.Name = "lbZone"
        Me.lbZone.Size = New System.Drawing.Size(0, 22)
        Me.lbZone.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(631, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(148, 65)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(466, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 65)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'pbPrint
        '
        Me.pbPrint.BackColor = System.Drawing.Color.Transparent
        Me.pbPrint.Location = New System.Drawing.Point(631, 516)
        Me.pbPrint.Name = "pbPrint"
        Me.pbPrint.Size = New System.Drawing.Size(148, 63)
        Me.pbPrint.TabIndex = 14
        Me.pbPrint.TabStop = False
        '
        'pbClear
        '
        Me.pbClear.BackColor = System.Drawing.Color.Transparent
        Me.pbClear.Location = New System.Drawing.Point(466, 516)
        Me.pbClear.Name = "pbClear"
        Me.pbClear.Size = New System.Drawing.Size(149, 63)
        Me.pbClear.TabIndex = 13
        Me.pbClear.TabStop = False
        '
        'pbBackReprintToMenu
        '
        Me.pbBackReprintToMenu.BackColor = System.Drawing.Color.Transparent
        Me.pbBackReprintToMenu.Location = New System.Drawing.Point(28, 516)
        Me.pbBackReprintToMenu.Name = "pbBackReprintToMenu"
        Me.pbBackReprintToMenu.Size = New System.Drawing.Size(149, 63)
        Me.pbBackReprintToMenu.TabIndex = 12
        Me.pbBackReprintToMenu.TabStop = False
        '
        'pnListPrint
        '
        Me.pnListPrint.BackColor = System.Drawing.Color.Transparent
        Me.pnListPrint.Controls.Add(Me.lvDetail)
        Me.pnListPrint.Controls.Add(Me.cbCalandar)
        Me.pnListPrint.Controls.Add(Me.CbPartNum)
        Me.pnListPrint.Controls.Add(Me.CbLotNum)
        Me.pnListPrint.Location = New System.Drawing.Point(28, 166)
        Me.pnListPrint.Name = "pnListPrint"
        Me.pnListPrint.Size = New System.Drawing.Size(751, 335)
        Me.pnListPrint.TabIndex = 15
        '
        'qgateReprintTag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.LINE_ALBUM_หน้าจอ
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lbStation)
        Me.Controls.Add(Me.lbZone)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbPrint)
        Me.Controls.Add(Me.pbClear)
        Me.Controls.Add(Me.pbBackReprintToMenu)
        Me.Controls.Add(Me.pnListPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateReprintTag"
        Me.Text = "qgateReprintTag"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackReprintToMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnListPrint.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
