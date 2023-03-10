<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class qgateOperation
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
        Me.lbZone = New System.Windows.Forms.Label()
        Me.lbStation = New System.Windows.Forms.Label()
        Me.lbPartNum = New System.Windows.Forms.Label()
        Me.lbPartName = New System.Windows.Forms.Label()
        Me.lbProductDate = New System.Windows.Forms.Label()
        Me.lbModel = New System.Windows.Forms.Label()
        Me.lbLotNum = New System.Windows.Forms.Label()
        Me.lbSnp = New System.Windows.Forms.Label()
        Me.lbBoxNum = New System.Windows.Forms.Label()
        Me.tbcounter = New System.Windows.Forms.TextBox()
        Me.tbCounterNg = New System.Windows.Forms.TextBox()
        Me.tbQrSerial = New System.Windows.Forms.TextBox()
        Me.lbQrSerialNum = New System.Windows.Forms.Label()
        Me.lbBoxNumNg = New System.Windows.Forms.Label()
        Me.tbCounterNc = New System.Windows.Forms.TextBox()
        Me.lbQrSerialNumNg = New System.Windows.Forms.Label()
        Me.lbBoxNumNc = New System.Windows.Forms.Label()
        Me.lbQrSerialNumNc = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.btnNg = New System.Windows.Forms.PictureBox()
        Me.btnNc = New System.Windows.Forms.PictureBox()
        Me.lbCodeRank = New System.Windows.Forms.Label()
        Me.btnBackToScan = New System.Windows.Forms.PictureBox()
        Me.btnEnd = New System.Windows.Forms.PictureBox()
        Me.btnFinish = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btnNg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBackToScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFinish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbZone
        '
        Me.lbZone.AutoSize = True
        Me.lbZone.BackColor = System.Drawing.Color.Transparent
        Me.lbZone.Font = New System.Drawing.Font("MADE Dillan", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbZone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbZone.Location = New System.Drawing.Point(463, 50)
        Me.lbZone.Name = "lbZone"
        Me.lbZone.Size = New System.Drawing.Size(0, 21)
        Me.lbZone.TabIndex = 0
        '
        'lbStation
        '
        Me.lbStation.AutoSize = True
        Me.lbStation.BackColor = System.Drawing.Color.Transparent
        Me.lbStation.Font = New System.Drawing.Font("MADE Dillan", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbStation.Location = New System.Drawing.Point(742, 50)
        Me.lbStation.Name = "lbStation"
        Me.lbStation.Size = New System.Drawing.Size(0, 21)
        Me.lbStation.TabIndex = 1
        '
        'lbPartNum
        '
        Me.lbPartNum.AutoSize = True
        Me.lbPartNum.BackColor = System.Drawing.Color.Transparent
        Me.lbPartNum.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPartNum.ForeColor = System.Drawing.Color.White
        Me.lbPartNum.Location = New System.Drawing.Point(105, 146)
        Me.lbPartNum.Name = "lbPartNum"
        Me.lbPartNum.Size = New System.Drawing.Size(22, 26)
        Me.lbPartNum.TabIndex = 2
        Me.lbPartNum.Text = "-"
        '
        'lbPartName
        '
        Me.lbPartName.AutoSize = True
        Me.lbPartName.BackColor = System.Drawing.Color.Transparent
        Me.lbPartName.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPartName.ForeColor = System.Drawing.Color.White
        Me.lbPartName.Location = New System.Drawing.Point(130, 184)
        Me.lbPartName.Name = "lbPartName"
        Me.lbPartName.Size = New System.Drawing.Size(22, 26)
        Me.lbPartName.TabIndex = 3
        Me.lbPartName.Text = "-"
        '
        'lbProductDate
        '
        Me.lbProductDate.AutoSize = True
        Me.lbProductDate.BackColor = System.Drawing.Color.Transparent
        Me.lbProductDate.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProductDate.ForeColor = System.Drawing.Color.White
        Me.lbProductDate.Location = New System.Drawing.Point(149, 221)
        Me.lbProductDate.Name = "lbProductDate"
        Me.lbProductDate.Size = New System.Drawing.Size(22, 26)
        Me.lbProductDate.TabIndex = 4
        Me.lbProductDate.Text = "-"
        '
        'lbModel
        '
        Me.lbModel.AutoSize = True
        Me.lbModel.BackColor = System.Drawing.Color.Transparent
        Me.lbModel.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbModel.ForeColor = System.Drawing.Color.White
        Me.lbModel.Location = New System.Drawing.Point(98, 258)
        Me.lbModel.Name = "lbModel"
        Me.lbModel.Size = New System.Drawing.Size(22, 26)
        Me.lbModel.TabIndex = 5
        Me.lbModel.Text = "-"
        '
        'lbLotNum
        '
        Me.lbLotNum.AutoSize = True
        Me.lbLotNum.BackColor = System.Drawing.Color.Transparent
        Me.lbLotNum.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLotNum.ForeColor = System.Drawing.Color.White
        Me.lbLotNum.Location = New System.Drawing.Point(99, 294)
        Me.lbLotNum.Name = "lbLotNum"
        Me.lbLotNum.Size = New System.Drawing.Size(22, 26)
        Me.lbLotNum.TabIndex = 6
        Me.lbLotNum.Text = "-"
        '
        'lbSnp
        '
        Me.lbSnp.AutoSize = True
        Me.lbSnp.BackColor = System.Drawing.Color.Transparent
        Me.lbSnp.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSnp.ForeColor = System.Drawing.Color.White
        Me.lbSnp.Location = New System.Drawing.Point(80, 332)
        Me.lbSnp.Name = "lbSnp"
        Me.lbSnp.Size = New System.Drawing.Size(22, 26)
        Me.lbSnp.TabIndex = 7
        Me.lbSnp.Text = "-"
        '
        'lbBoxNum
        '
        Me.lbBoxNum.AutoSize = True
        Me.lbBoxNum.BackColor = System.Drawing.Color.Transparent
        Me.lbBoxNum.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoxNum.ForeColor = System.Drawing.Color.White
        Me.lbBoxNum.Location = New System.Drawing.Point(105, 431)
        Me.lbBoxNum.Name = "lbBoxNum"
        Me.lbBoxNum.Size = New System.Drawing.Size(22, 26)
        Me.lbBoxNum.TabIndex = 8
        Me.lbBoxNum.Text = "-"
        '
        'tbcounter
        '
        Me.tbcounter.Enabled = False
        Me.tbcounter.Font = New System.Drawing.Font("MADE Dillan", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcounter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbcounter.Location = New System.Drawing.Point(128, 373)
        Me.tbcounter.Name = "tbcounter"
        Me.tbcounter.Size = New System.Drawing.Size(91, 46)
        Me.tbcounter.TabIndex = 9
        Me.tbcounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCounterNg
        '
        Me.tbCounterNg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCounterNg.Enabled = False
        Me.tbCounterNg.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCounterNg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCounterNg.Location = New System.Drawing.Point(671, 121)
        Me.tbCounterNg.Name = "tbCounterNg"
        Me.tbCounterNg.Size = New System.Drawing.Size(84, 34)
        Me.tbCounterNg.TabIndex = 10
        Me.tbCounterNg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbQrSerial
        '
        Me.tbQrSerial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbQrSerial.Font = New System.Drawing.Font("MADE Dillan", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQrSerial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbQrSerial.Location = New System.Drawing.Point(345, 435)
        Me.tbQrSerial.Name = "tbQrSerial"
        Me.tbQrSerial.Size = New System.Drawing.Size(431, 37)
        Me.tbQrSerial.TabIndex = 12
        '
        'lbQrSerialNum
        '
        Me.lbQrSerialNum.AutoSize = True
        Me.lbQrSerialNum.BackColor = System.Drawing.Color.Transparent
        Me.lbQrSerialNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQrSerialNum.ForeColor = System.Drawing.Color.White
        Me.lbQrSerialNum.Location = New System.Drawing.Point(496, 364)
        Me.lbQrSerialNum.Name = "lbQrSerialNum"
        Me.lbQrSerialNum.Size = New System.Drawing.Size(14, 20)
        Me.lbQrSerialNum.TabIndex = 13
        Me.lbQrSerialNum.Text = "-"
        '
        'lbBoxNumNg
        '
        Me.lbBoxNumNg.AutoSize = True
        Me.lbBoxNumNg.BackColor = System.Drawing.Color.Transparent
        Me.lbBoxNumNg.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoxNumNg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbBoxNumNg.Location = New System.Drawing.Point(603, 165)
        Me.lbBoxNumNg.Name = "lbBoxNumNg"
        Me.lbBoxNumNg.Size = New System.Drawing.Size(22, 26)
        Me.lbBoxNumNg.TabIndex = 14
        Me.lbBoxNumNg.Text = "-"
        '
        'tbCounterNc
        '
        Me.tbCounterNc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCounterNc.Enabled = False
        Me.tbCounterNc.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCounterNc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCounterNc.Location = New System.Drawing.Point(671, 252)
        Me.tbCounterNc.Name = "tbCounterNc"
        Me.tbCounterNc.Size = New System.Drawing.Size(84, 34)
        Me.tbCounterNc.TabIndex = 11
        Me.tbCounterNc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbQrSerialNumNg
        '
        Me.lbQrSerialNumNg.AutoSize = True
        Me.lbQrSerialNumNg.BackColor = System.Drawing.Color.Transparent
        Me.lbQrSerialNumNg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQrSerialNumNg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbQrSerialNumNg.Location = New System.Drawing.Point(512, 200)
        Me.lbQrSerialNumNg.Name = "lbQrSerialNumNg"
        Me.lbQrSerialNumNg.Size = New System.Drawing.Size(14, 20)
        Me.lbQrSerialNumNg.TabIndex = 15
        Me.lbQrSerialNumNg.Text = "-"
        '
        'lbBoxNumNc
        '
        Me.lbBoxNumNc.AutoSize = True
        Me.lbBoxNumNc.BackColor = System.Drawing.Color.Transparent
        Me.lbBoxNumNc.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoxNumNc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbBoxNumNc.Location = New System.Drawing.Point(602, 294)
        Me.lbBoxNumNc.Name = "lbBoxNumNc"
        Me.lbBoxNumNc.Size = New System.Drawing.Size(22, 26)
        Me.lbBoxNumNc.TabIndex = 16
        Me.lbBoxNumNc.Text = "-"
        '
        'lbQrSerialNumNc
        '
        Me.lbQrSerialNumNc.AutoSize = True
        Me.lbQrSerialNumNc.BackColor = System.Drawing.Color.Transparent
        Me.lbQrSerialNumNc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQrSerialNumNc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbQrSerialNumNc.Location = New System.Drawing.Point(515, 329)
        Me.lbQrSerialNumNc.Name = "lbQrSerialNumNc"
        Me.lbQrSerialNumNc.Size = New System.Drawing.Size(14, 20)
        Me.lbQrSerialNumNc.TabIndex = 17
        Me.lbQrSerialNumNc.Text = "-"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.BackColor = System.Drawing.Color.Transparent
        Me.lbUserName.Font = New System.Drawing.Font("MADE Dillan", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbUserName.Location = New System.Drawing.Point(441, 17)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(0, 21)
        Me.lbUserName.TabIndex = 18
        '
        'btnNg
        '
        Me.btnNg.BackColor = System.Drawing.Color.Transparent
        Me.btnNg.Location = New System.Drawing.Point(355, 115)
        Me.btnNg.Name = "btnNg"
        Me.btnNg.Size = New System.Drawing.Size(156, 84)
        Me.btnNg.TabIndex = 20
        Me.btnNg.TabStop = False
        '
        'btnNc
        '
        Me.btnNc.BackColor = System.Drawing.Color.Transparent
        Me.btnNc.Location = New System.Drawing.Point(356, 245)
        Me.btnNc.Name = "btnNc"
        Me.btnNc.Size = New System.Drawing.Size(156, 80)
        Me.btnNc.TabIndex = 21
        Me.btnNc.TabStop = False
        '
        'lbCodeRank
        '
        Me.lbCodeRank.AutoSize = True
        Me.lbCodeRank.BackColor = System.Drawing.Color.Transparent
        Me.lbCodeRank.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodeRank.ForeColor = System.Drawing.Color.White
        Me.lbCodeRank.Location = New System.Drawing.Point(466, 398)
        Me.lbCodeRank.Name = "lbCodeRank"
        Me.lbCodeRank.Size = New System.Drawing.Size(22, 26)
        Me.lbCodeRank.TabIndex = 22
        Me.lbCodeRank.Text = "-"
        '
        'btnBackToScan
        '
        Me.btnBackToScan.BackColor = System.Drawing.Color.Transparent
        Me.btnBackToScan.Location = New System.Drawing.Point(25, 512)
        Me.btnBackToScan.Name = "btnBackToScan"
        Me.btnBackToScan.Size = New System.Drawing.Size(158, 67)
        Me.btnBackToScan.TabIndex = 23
        Me.btnBackToScan.TabStop = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Transparent
        Me.btnEnd.Location = New System.Drawing.Point(631, 515)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(150, 64)
        Me.btnEnd.TabIndex = 24
        Me.btnEnd.TabStop = False
        '
        'btnFinish
        '
        Me.btnFinish.BackColor = System.Drawing.Color.Transparent
        Me.btnFinish.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.Finish
        Me.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFinish.Location = New System.Drawing.Point(456, 513)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(160, 75)
        Me.btnFinish.TabIndex = 24
        Me.btnFinish.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MADE Dillan", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(374, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "User :"
        '
        'Timer1
        '
        '
        'qgateOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Q_Gate_App.My.Resources.Resources.LINE_ALBUM_หน้าจอ_Q_gate_230224_0
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnBackToScan)
        Me.Controls.Add(Me.lbCodeRank)
        Me.Controls.Add(Me.btnNc)
        Me.Controls.Add(Me.btnNg)
        Me.Controls.Add(Me.lbUserName)
        Me.Controls.Add(Me.lbQrSerialNumNc)
        Me.Controls.Add(Me.lbBoxNumNc)
        Me.Controls.Add(Me.lbQrSerialNumNg)
        Me.Controls.Add(Me.lbBoxNumNg)
        Me.Controls.Add(Me.lbQrSerialNum)
        Me.Controls.Add(Me.tbQrSerial)
        Me.Controls.Add(Me.tbCounterNc)
        Me.Controls.Add(Me.tbCounterNg)
        Me.Controls.Add(Me.tbcounter)
        Me.Controls.Add(Me.lbBoxNum)
        Me.Controls.Add(Me.lbSnp)
        Me.Controls.Add(Me.lbLotNum)
        Me.Controls.Add(Me.lbModel)
        Me.Controls.Add(Me.lbProductDate)
        Me.Controls.Add(Me.lbPartName)
        Me.Controls.Add(Me.lbPartNum)
        Me.Controls.Add(Me.lbStation)
        Me.Controls.Add(Me.lbZone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "qgateOperation"
        Me.Text = " "
        CType(Me.btnNg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBackToScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFinish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbZone As Label
    Friend WithEvents lbStation As Label
    Friend WithEvents lbPartNum As Label
    Friend WithEvents lbPartName As Label
    Friend WithEvents lbProductDate As Label
    Friend WithEvents lbModel As Label
    Friend WithEvents lbLotNum As Label
    Friend WithEvents lbSnp As Label
    Friend WithEvents lbBoxNum As Label
    Friend WithEvents tbcounter As TextBox
    Friend WithEvents tbCounterNg As TextBox
    Friend WithEvents tbQrSerial As TextBox
    Friend WithEvents lbQrSerialNum As Label
    Friend WithEvents lbBoxNumNg As Label
    Friend WithEvents tbCounterNc As TextBox
    Friend WithEvents lbQrSerialNumNg As Label
    Friend WithEvents lbBoxNumNc As Label
    Friend WithEvents lbQrSerialNumNc As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents btnNg As PictureBox
    Friend WithEvents btnNc As PictureBox
    Friend WithEvents lbCodeRank As Label
    Friend WithEvents btnBackToScan As PictureBox
    Friend WithEvents btnEnd As PictureBox
    Friend WithEvents btnFinish As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
