Imports System.Globalization
Imports System.Net
Imports System.Web.Script.Serialization
Imports Nancy.Json
Public Class PrintDefect
    Dim lPartno As String = "NO DATA"
    Dim lPartname As String = "NO DATA"
    Dim lModel As String = "NO DATA"
    Dim lLine As String = "NO DATA"
    Dim lActualdate As String = "NO DATA"
    Dim lLocation As String = "NO DATA"
    Dim lShift As String = "NO DATA"
    Dim lPhase As String = "NO DATA"
    Dim lLot As String = "NO DATA"
    Dim lQtydefect As String = "NO DATA"
    Dim lSeq As String = "NO DATA"
    Dim lwi As String = "NO DATA"
    'Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim Defect_LB_STATUS As String = "NC" 'ชั่วคราว
    Dim qrDefectinfo As String = ""
    Dim qrDefectcodedetails As String = ""
    Dim sDefect As String = ""
    Dim lBoxno As String = "001"
    Dim pCd As String = ""
    Dim lItemtype As String = ""
    Dim qtyDefect As String = ""
    Dim lCodedefect As String = ""
    Dim TypeMenu As String = ""
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
    Private qrtagdefect As String = "NO DATA"
    Private defectcode As String = "NO DATA"

    Private typeproduct As String = "NO DATA"
    Private Sub printDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Public Sub Set_parameter_print(LB_PART_NO As String, LB_PART_NAME As String, LB_MODEL As String, LB_LOT As String, LB_COUNTBOX As String, LB_SNP As String, LB_Hide_QR_FA_SCAN As String, max_box As String, QR_PRODUCT_SCAN As String, default_box As Integer, COUNT_TEXTBOX As String, para_shift As String, cus_item_cd As String, lo As String, date_check As String, status_print As String, lProd As String, linepro As String, tagdefect As String, defect As String, producttype As String)
        Dim con_date_check As Date = date_check
        part_no = LB_PART_NO
        PART_NAME = LB_PART_NAME
        Model = LB_MODEL
        LOT_NO = LB_LOT
        LOT_PRODUCTION = lProd
        LINE = linepro
        QTY = LB_SNP
        BOX_NO = LB_COUNTBOX
        defectcode = defect
        typeproduct = producttype
        If typeproduct = "1" Then
            typeproduct = "NC"
        Else
            typeproduct = "NG"
        End If
        date_check_q_gate = con_date_check.ToString("dd/MM/yyyy")
        M_BOX = max_box
        SHIFT = para_shift
        CHECK_DATE = "NO_DATA"
        qrtagdefect = tagdefect
        Dim tem_qr As String = NEW_QR & box_seq
        QR_PRODUCT = QR_PRODUCT_SCAN
        CUST_ITEM_CD = cus_item_cd
        location = lo
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim md = New modelDefect()
        Dim bNo As String = ""
        Dim aPen = New Pen(Color.Black)
        e.Graphics.DrawLine(Pens.Azure, 10, 10, 20, 20)
        aPen.Width = 3.0F  'border 
        e.Graphics.DrawLine(aPen, 9, 5, 9, 280) 'แก้ตำแหน่งที่ 1 , 3เส้นเปิด  NC/NG
        e.Graphics.DrawLine(aPen, 120, 5, 120, 230) 'แก้ตำแหน่งที่ 1 , 3เส้นเปิด  NC/NG
        e.Graphics.DrawLine(aPen, 680, 5, 680, 250) 'แก้ตำแหน่งที่ 1 , 3 เส้นปิด  NC/NG
        e.Graphics.DrawLine(aPen, 560, 5, 560, 192) 'แก้ตำแหน่งที่ 1 , 3 เส้นปิด  NC/NG
        e.Graphics.DrawLine(aPen, 425, 100, 425, 192) 'แก้ตำแหน่งที่ 1 , 3 เส้นปิด  NC/NG
        e.Graphics.DrawLine(aPen, 320, 190, 320, 230) 'แก้ตำแหน่งที่ 1 , 3 เส้นปิด  NC/NG
        e.Graphics.DrawLine(aPen, 460, 190, 460, 230) 'แก้ตำแหน่งที่ 1 , 3 เส้นปิด  NC/NG
        e.Graphics.DrawLine(aPen, 585, 190, 585, 280) 'แก้ตำแหน่งที่ 1 , 3 เส้นปิด  NC/NG
        e.Graphics.DrawLine(aPen, 680, 5, 680, 280) 'แก้ตำแหน่งที่ 1 , 3 เส้นปิด  NC/NG
        e.Graphics.DrawLine(aPen, 8, 5, 681, 5) 'แก้ตำแหน่งที่ 2 , 4
        e.Graphics.DrawLine(aPen, 120, 55, 560, 55) 'แก้ตำแหน่งที่ 2 , 4 part no
        e.Graphics.DrawLine(aPen, 120, 100, 681, 100) 'แก้ตำแหน่งที่ 2 , 4 part name
        e.Graphics.DrawLine(aPen, 120, 145, 681, 145) 'แก้ตำแหน่งที่ 2 , 4 model
        e.Graphics.DrawLine(aPen, 120, 190, 681, 190) 'แก้ตำแหน่งที่ 2 , 4 Actual Date
        e.Graphics.FillRectangle(Brushes.Black, 10, 100, 110, 20) ' background back
        e.Graphics.DrawString("INFO.", IN_FO.Font, Brushes.White, 46, 101)
        e.Graphics.FillRectangle(Brushes.Black, 10, 210, 110, 20) ' background back
        e.Graphics.DrawString("DEFECT QR.", IN_FO.Font, Brushes.White, 16, 214)
        e.Graphics.DrawLine(aPen, 8, 230, 587, 230) 'แก้ตำแหน่งที่ 2 , 4


        ' MsgBox(sDefect)
        'e.Graphics.DrawString(typeproduct, Label1.Font, Brushes.Black, 560, 20)

        If typeproduct = "NG" Then
            e.Graphics.FillRectangle(Brushes.Black, 560, 5, 122, 97) ' NG/NC BACKGROUD Black
            e.Graphics.DrawString("NG", Label1.Font, Brushes.White, 560, 20) ' left top
        ElseIf typeproduct = "NC" Then
            e.Graphics.FillRectangle(Brushes.White, 10, 100, 110, 20) ' background back
            e.Graphics.DrawString("NC", Label1.Font, Brushes.Black, 560, 20) ' left top

        End If
        e.Graphics.DrawLine(aPen, 8, 280, 681, 280) 'แก้ตำแหน่งที่ 2 , 4
        'Details'
        e.Graphics.DrawString("PART NO:", title.Font, Brushes.Black, 130, 10)
        e.Graphics.DrawString(part_no, values.Font, Brushes.Black, 150, 31)
        e.Graphics.DrawString("PART NAME:", title.Font, Brushes.Black, 130, 60)
        e.Graphics.DrawString(PART_NAME, values.Font, Brushes.Black, 150, 78)
        e.Graphics.DrawString("MODEL:", title.Font, Brushes.Black, 130, 105)
        e.Graphics.DrawString(Model, values.Font, Brushes.Black, 150, 122)
        e.Graphics.DrawString("LINE:", title.Font, Brushes.Black, 430, 105)
        e.Graphics.DrawString(LINE, values.Font, Brushes.Black, 460, 122)
        e.Graphics.DrawString("LOT NO:", title.Font, Brushes.Black, 570, 105)
        e.Graphics.DrawString(LOT_NO, values.Font, Brushes.Black, 610, 122)
        e.Graphics.DrawString("ACTUAL DATE : ", title.Font, Brushes.Black, 130, 150)
        e.Graphics.DrawString(date_check_q_gate, values.Font, Brushes.Black, 150, 167)
        e.Graphics.DrawString("LOCATION :", title.Font, Brushes.Black, 430, 150)
        e.Graphics.DrawString(location, values.Font, Brushes.Black, 445, 167)
        e.Graphics.DrawString("SHIFT : ", title.Font, Brushes.Black, 130, 197)
        e.Graphics.DrawString(SHIFT, values.Font, Brushes.Black, 191, 210)
        e.Graphics.DrawString("PHASE :", title.Font, Brushes.Black, 325, 197)
        e.Graphics.DrawString(10, values.Font, Brushes.Black, 390, 210)
        e.Graphics.DrawString("BOX NO :", title.Font, Brushes.Black, 470, 197)
        e.Graphics.DrawString(BOX_NO, values.Font, Brushes.Black, 510, 210)
        e.Graphics.DrawString("DEFECT CODE :", detail_code.Font, Brushes.Black, 15, 236)
        e.Graphics.DrawString(defectcode, values.Font, Brushes.Black, 130, 236)
        Dim i As Integer = 1
        Dim cNumber As Integer = 1
        Dim dataDefect As String = " " '
        Dim dataQrdefectcodedetails As String = ""
        Dim mgtop As Integer = 250
        Dim mgleft As Integer = 15

        e.Graphics.DrawString(dataDefect, detail_code.Font, Brushes.Black, mgleft, mgtop)
        e.Graphics.DrawString("QTY :", title.Font, Brushes.Black, 570, 150)
        e.Graphics.DrawString(QTY, values.Font, Brushes.Black, 610, 167)
        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        qrcode.QRCodeScale = 10
        Dim bitmap_qr_box As Bitmap = qrcode.Encode(qrtagdefect)
        Dim bitmap_qr_product As Bitmap = qrcode.Encode(QR_PRODUCT)
        e.Graphics.DrawImage(bitmap_qr_box, 595, 198, 75, 75) 'button right
        e.Graphics.DrawImage(bitmap_qr_box, 25, 15, 75, 75) 'top left
        e.Graphics.DrawImage(bitmap_qr_product, 25, 128, 75, 75) 'button right
    End Sub
End Class