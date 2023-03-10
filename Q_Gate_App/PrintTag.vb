
Imports System.Globalization
Public Class PrintTag
    Private part_no As String = "NO_DATA"
    Private PART_NAME As String = "NO_DATA"
    Private Model As String = "NO_DATA"
    Private LOT_NO As String = "NO_DATA"
    Private LOT_PRODUCTION As String = "No_DATA"
    Private BOX_NO As Integer = 0
    Private SHIFT As String = "NO_DATA"
    Private QTY As String = "NO_DATA"
    Private LINE As String = "NO_DATA"
    Private CHECK_DATE As String = "NO_DATA"
    Private M_BOX As String = "NO_DATA"
    Private NEW_QR As String = "NO_DATA"
    Private box_seq As String = "NO_DATA"
    Private new_gen_qr As String = "NO_DATA"
    Private QR_PRODUCT As String = "NO_DATA"
    Private WASHING_DATE As String = "NO DATA"
    Private CUST_ITEM_CD As String = "NO DATA"
    Private location As String = "NO DATA"
    Private date_check_q_gate As String = "dd/MM/yyyy"
    Private qrtagqgate As String = "NO DATA"
    Private flgprint As String = "NO DATA"
    Public Sub Set_parameter_print(LB_PART_NO As String, LB_PART_NAME As String, LB_MODEL As String, LB_LOT As String, LB_COUNTBOX As String, LB_SNP As String, LB_Hide_QR_FA_SCAN As String, max_box As String, QR_PRODUCT_SCAN As String, default_box As Integer, COUNT_TEXTBOX As String, para_shift As String, cus_item_cd As String, lo As String, date_check As String, status_print As String, lProd As String, linepro As String, tagqgate As String, flgprinttype As String)
        Dim con_date_check As Date = date_check
        part_no = LB_PART_NO
        PART_NAME = LB_PART_NAME
        Model = LB_MODEL
        LOT_NO = LB_LOT
        LOT_PRODUCTION = lProd
        LINE = linepro
        QTY = LB_SNP
        BOX_NO = LB_COUNTBOX
        flgprint = flgprinttype
        If BOX_NO <= 9 Then
            box_seq = "00" & BOX_NO
        ElseIf BoxNum <= 99 Then
            box_seq = "0" & BOX_NO
        Else
            box_seq = BOX_NO
        End If
        date_check_q_gate = con_date_check.ToString("dd/MM/yyyy")
        M_BOX = max_box
        SHIFT = para_shift
        CHECK_DATE = "NO_DATA"
        qrtagqgate = tagqgate
        Dim tem_qr As String = NEW_QR & box_seq
        QR_PRODUCT = QR_PRODUCT_SCAN
        CUST_ITEM_CD = cus_item_cd
        location = lo
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Public Sub Set_test(LB_PART_NO As String, LB_PART_NAME As String)
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim aPen = New Pen(Color.Black)
        aPen.Width = 3.0F  'border 
        'vertical
        e.Graphics.DrawLine(aPen, 80, 5, 80, 290)
        e.Graphics.DrawLine(aPen, 560, 5, 560, 290)
        e.Graphics.DrawLine(aPen, 260, 138, 260, 240)
        e.Graphics.DrawLine(aPen, 400, 188, 400, 240)
        e.Graphics.DrawLine(aPen, 220, 240, 220, 290)
        e.Graphics.DrawLine(aPen, 340, 240, 340, 290)
        e.Graphics.DrawLine(aPen, 480, 240, 480, 290)
        e.Graphics.DrawLine(aPen, 670, 5, 670, 290)
        e.Graphics.DrawLine(aPen, 80, 5, 670, 5)
        e.Graphics.DrawLine(aPen, 80, 40, 560, 40)
        e.Graphics.DrawLine(aPen, 80, 100, 670, 100)
        e.Graphics.DrawLine(aPen, 80, 140, 670, 140)
        e.Graphics.DrawLine(aPen, 80, 190, 670, 190)
        e.Graphics.DrawLine(aPen, 80, 240, 560, 240)
        e.Graphics.DrawLine(aPen, 80, 290, 670, 290)
        'TAG LAYOUT
        e.Graphics.DrawString("TBKK", Label5.Font, Brushes.Black, 10, 10)
        e.Graphics.DrawString("(Thailand) Co.,Ltd.", Label6.Font, Brushes.Black, 0, 40)
        e.Graphics.DrawString("To", Label13.Font, Brushes.Black, 102, 10)
        e.Graphics.DrawString("IHI Turbo (Thailand) Co._LTD.", Label1.Font, Brushes.Black, 130, 18)
        e.Graphics.DrawString("PART NO", Label13.Font, Brushes.Black, 90, 50)
        e.Graphics.DrawString(part_no, Label10.Font, Brushes.Black, 130, 69)
        e.Graphics.DrawString("PART NAME", Label13.Font, Brushes.Black, 90, 100)
        e.Graphics.DrawString(PART_NAME, Label1.Font, Brushes.Black, 130, 116)
        e.Graphics.DrawString("PROCESS", Label13.Font, Brushes.Black, 565, 100)
        e.Graphics.DrawString("Q-GATE", Label1.Font, Brushes.Black, 575, 116)
        e.Graphics.DrawString("MODEL", Label13.Font, Brushes.Black, 90, 145)
        e.Graphics.DrawString(Model, Label1.Font, Brushes.Black, 130, 165)
        e.Graphics.DrawString("CUSTOMER PART NO.", Label13.Font, Brushes.Black, 265, 145)
        e.Graphics.DrawString(CUST_ITEM_CD, Label1.Font, Brushes.Black, 285, 165)
        e.Graphics.DrawString("LOCATION", Label13.Font, Brushes.Black, 565, 145)
        e.Graphics.DrawString(location, Label1.Font, Brushes.Black, 575, 165)
        e.Graphics.DrawString("QTY", Label8.Font, Brushes.Black, 90, 190)
        If flgprint = "normalprint" Then
            e.Graphics.DrawString(QTY, Label12.Font, Brushes.Black, 150, 186)
        End If
        If flgprint = "reprint" Then
            e.Graphics.DrawString(QTY, Label12.Font, Brushes.Black, 150, 186)
        End If
        e.Graphics.DrawString("BOX NO.", Label13.Font, Brushes.Black, 265, 193)
        e.Graphics.DrawString(box_seq, Label10.Font, Brushes.Black, 295, 209)
        e.Graphics.DrawString("CHECK DATE | LOT NO.", title.Font, Brushes.Black, 405, 193)
        e.Graphics.DrawString(date_check_q_gate & " | " & LOT_NO, values.Font, Brushes.Black, 407, 213)
        e.Graphics.DrawString("PROD. LOT NO.", Label13.Font, Brushes.Black, 90, 245)
        e.Graphics.DrawString(LOT_PRODUCTION, Label10.Font, Brushes.Black, 130, 255)
        e.Graphics.DrawString("SHIFT", Label13.Font, Brushes.Black, 225, 245)
        e.Graphics.DrawString(SHIFT, Label10.Font, Brushes.Black, 245, 255)
        e.Graphics.DrawString("LINE", Label13.Font, Brushes.Black, 350, 245)
        e.Graphics.DrawString(LINE, Label1.Font, Brushes.Black, 370, 262)
        e.Graphics.DrawString("PHASE", Label13.Font, Brushes.Black, 482, 245)
        e.Graphics.DrawString("10", Label1.Font, Brushes.Black, 490, 262)
        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        qrcode.QRCodeScale = 10
        MsgBox(QR_PRODUCT)
        Dim bitmap_qr_box As Bitmap = qrcode.Encode(qrtagqgate)
        Dim bitmap_qr_product As Bitmap = qrcode.Encode(QR_PRODUCT)
        e.Graphics.DrawImage(bitmap_qr_box, 570, 12, 85, 85) 'TOP
        e.Graphics.DrawImage(bitmap_qr_box, 0, 210, 75, 75) 'left
        e.Graphics.DrawImage(bitmap_qr_product, 580, 210, 75, 75) 'button right
    End Sub
    Public Function covert_date(check_date As String)
        Dim year As String = check_date.Substring(0, 4)
        Dim mounth As String = check_date.Substring(5, 2)
        Dim day As String = check_date.Substring(8, 2)
        Dim result_data As String = year & mounth & day

        Return result_data
    End Function
    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
