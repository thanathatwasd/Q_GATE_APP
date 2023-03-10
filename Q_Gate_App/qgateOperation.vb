Imports System.Globalization
Imports Nancy.Json
Public Class qgateOperation
    Dim md As New ModelVB
    Dim getsubstringname(5) As String
    Dim getpartsubstart(5) As Integer
    Dim getpartsubend(5) As Integer
    Dim getpartsubnum(5) As Integer
    Dim PartNoSub As String
    Dim PartDateSub As String
    Dim PartLotSub As String
    Dim PartShiftSub As String
    Dim PartLineSub As String
    Dim PartSerialNoSub As String
    Dim num As Integer = 0
    Dim workshift As String
    Dim t
    Dim productrank = "A"
    Dim productcheckcount As Integer = 1
    Dim workshiftid
    Dim tagfaid
    Dim namedigitid
    Dim getpartno
    Dim Ms As Integer = 0 ' เก็บมิลิวินาที
    Dim status As Boolean = False
    Dim s As Integer = 0
    Dim tagdefectNC
    Dim tagdefectNG
    Dim Timer As New Timer ' ตัวแปร Object ประเภท เวลา (หรือท่านจะใช้ Object ที่มากับ โปรแกรมก็ได้ครับ คือ Timmer'เมือ Form โหลดมา Timer เริ่มทำงาน
    Private Sub qgateOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer.Enabled = True
        btnFinish.Hide()
        Timer1.Enabled = True
        tbQrSerial.Select()
        tbcounter.Text = productcount
        lbUserName.Text = user
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        getpartno = Module1.qgate_part_no
        lbPartNum.Text = Module1.qgate_part_no
        lbPartName.Text = Module1.partnamedigit
        lbLotNum.Text = Module1.partlotno
        lbSnp.Text = Module1.partasnp
        lbProductDate.Text = Module1.partactualdate1
        lbBoxNum.Text = BoxNum
        lbCodeRank.Text = productrank
        getnumdefect()
        getboxfect()
        If tbCounterNg.Text = "" Then
            tbCounterNg.Text = "0"
        End If
        If tbCounterNc.Text = "" Then
            tbCounterNc.Text = "0"
        End If
        If lbBoxNumNc.Text = "-" Then
            lbBoxNumNc.Text = "1"
        End If
        If lbBoxNumNg.Text = "-" Then
            lbBoxNumNg.Text = "1"
        End If
    End Sub
    Private Sub btnBackToScan_Click(sender As Object, e As EventArgs) Handles btnBackToScan.Click
        productcount = 0
        qgateScanTag.Show()
        Me.Close()
    End Sub
    Private Sub tbQrSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles tbQrSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            If substringqrproduct(tbQrSerial.Text, getpartno) Then
                If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                    tbQrSerial.Enabled = False
                    btnFinish.Show()
                Else
                    tbQrSerial.Enabled = True
                    btnFinish.Hide()
                End If
            End If
        End If
    End Sub

    Public Function substringqrproduct(qrproduct As String, partno As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim subString = md.get_PartSubString(partno)
            Try
                If subString <> "0" Then
                    Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(subString)
                    For Each item As Object In dict
                        For i = num To 5 Step 1
                            getsubstringname(i) = item("mdd_name").ToString
                            getpartsubstart(i) = item("mdtd_start").ToString
                            getpartsubend(i) = item("mdtd_end").ToString
                            getpartsubnum(i) = item("mdtd_num_substring").ToString
                            num = num + 1
                            Exit For
                        Next
                    Next
                    If qrproduct.Length = getpartsubend(5) Then
                        PartNoSub = qrproduct.Substring(getpartsubstart(0), getpartsubnum(0))
                        PartDateSub = qrproduct.Substring(getpartsubend(0), getpartsubnum(1))
                        PartLotSub = qrproduct.Substring(getpartsubend(1), getpartsubnum(2))
                        PartShiftSub = qrproduct.Substring(getpartsubend(2), getpartsubnum(3))
                        PartLineSub = qrproduct.Substring(getpartsubend(3), getpartsubnum(4))
                        PartSerialNoSub = qrproduct.Substring(getpartsubend(4), getpartsubnum(5))
                        checkcodedmc(PartNoSub, partasnp, qrproduct)
                    Else
                        tbQrSerial.Text = ""
                        MsgBox("QR Code ไม่ตรงกันจำนวนเลชไม่ตรง")
                        status = False
                    End If
                Else
                    tbQrSerial.Text = ""
                    MsgBox("ไม่มี DMC นี้")
                    status = False
                End If
                Return status
            Catch ex As Exception
                MsgBox("Part ไม่ตรงกัน")
            End Try
            Return 0
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function checkcodedmc(qrdmc As String, productsnp As String, qralldmc As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            If CDbl(Val(Trim(productcount))) <> CDbl(Val(Trim(productsnp))) Then
                If qrdmc = Module1.dmcqrscan Then
                    If productcount = 0 Or s >= timetocheckqr Then 'ถ้าค่าเวลาที่เป็นมิลิวินาที
                        shift = md.get_WorkShoftTime(DateTime.Now.ToString("HH:mm:ss"))
                        Dim dict8 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(shift)
                        For Each item As Object In dict8
                            workshiftid = item("mws_shift").ToString
                        Next
                        Dim idtagfa = md.get_ID_Tag_fa(Module1.tagfa)
                        Dim idnamedigit = md.get_id_Digitname(partnamedigit)
                        Dim dict5 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(idtagfa)
                        For Each item As Object In dict5
                            tagfaid = item("ifts_id").ToString
                            lotproduct = item("ifts_lot_no_prod")
                        Next
                        Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(idnamedigit)
                        For Each item As Object In dict6
                            namedigitid = item("mdt_id").ToString
                        Next
                        Dim counttime As Integer = s
                        Dim checkduplicate = md.get_QrProduct(tbQrSerial.Text)
                        If checkduplicate = "0" Then
                            productcount = productcount + 1
                            productcheckcount = 1
                            lbQrSerialNum.Text = qralldmc
                            Dim rscountProduct = md.insert_qr_product(tagfaid, configposition, namedigitid, workshiftid, productcount, productrank,
                        productcheckcount, qralldmc, Module1.num_user(0), counttime)
                            qrproduct = tbQrSerial.Text
                            tbQrSerial.Text = ""
                            s = 0
                            tbcounter.Text = productcount
                            status = True
                        Else
                            Dim dict7 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(checkduplicate)
                            For Each item As Object In dict7
                                Dim qr = item("iodc_qrcode").ToString
                                Dim flg = item("iodc_flg").ToString
                                productcheckcount = item("iodc_check_count")
                                If flg = 0 Then
                                    productcheckcount = productcheckcount + 1
                                    productcount = productcount + 1
                                    lbQrSerialNum.Text = qralldmc
                                    Dim rscountProduct = md.update_info_part(tagfaid, configposition, workshiftid, productcount,
                        productcheckcount, Module1.num_user(0), qralldmc, counttime)
                                    s = 0
                                    tbcounter.Text = productcount
                                    qrproduct = tbQrSerial.Text
                                    tbQrSerial.Text = ""
                                    status = True
                                ElseIf flg = 1 Then
                                    tbQrSerial.Text = ""
                                    MsgBox("QR ซ้ำ")
                                    status = False
                                End If
                            Next
                        End If
                    Else
                        tbQrSerial.Text = ""
                        MsgBox("ตรวจงานให้ละเอียดด")
                        status = False
                    End If
                Else
                    tbQrSerial.Text = ""
                    MsgBox("QR Code ===== ไม่ถูก")
                    status = False
                End If
            Else
                tbQrSerial.Text = ""
                MsgBox("สินค้าครบจำนวน กรุณาแสกน tag ใหม่")
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Module1.countboxng = lbBoxNumNg.Text
        Module1.countboxnc = lbBoxNumNc.Text
        Module1.countng = tbCounterNg.Text
        Module1.countnc = tbCounterNc.Text
        finish()
        qgateScanTag.Show()
        Me.Close()
    End Sub

    Public Function finish()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            If tbcounter.Text > 0 Then
                Dim allqrproduct = md.Get_QRProductToGenQr(tagfaid)
                Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(allqrproduct)
                For Each item As Object In dict6
                    Module1.qrpro = (item("iodc_id").ToString)
                    t &= Module1.qrpro & " "
                    j += 1
                Next

                Dim a = tbcounter.Text
                Dim b
                If a.Length = 1 Then
                    b = "     " & a
                End If
                If a.Length = 2 Then
                    b = "    " & a
                End If
                If a.Length = 3 Then
                    b = "   " & a
                End If
                If a.Length = 4 Then
                    b = "  " & a
                End If
                If a.Length = 5 Then
                    b = " " & a
                End If
                If a.Length = 6 Then
                    b = a
                End If
                Dim tagqgate = (partcodemaster & partline & partplandate & partseqplan & partnotagfa & (DateTime.Now.ToString("yyyyMMdd") & b & lotcur & "                         " & (DateTime.Now.ToString("yyyyMMdd") & partseqplan & Module1.phaseplant & Box_seq)))
                md.insert_Tag_Qgate_complete(tagfaid, Box_seq, "1", Module1.num_user(0), tagqgate)
                productcount = 0
                Dim flgprinttype As String = "normalprint"
                PrintTag.Set_parameter_print(partnotagfa, partnamedigit, "1", lotcur, Box_seq, a, "1", "999", t, "001", "001", workshiftid, "01000", Locationpart, DateTime.Now.ToString("dd/MM/yyyy"), "1", lotproduct, partline, tagqgate, flgprinttype)
            End If
        Else
                MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ms += 1
        If Ms >= 10 Then
            s += 1
            Ms = 0
        End If
    End Sub

    Private Sub btnNg_Click(sender As Object, e As EventArgs) Handles btnNg.Click
        If productcount >= 1 Then
            qgateDefectNg.lbNamedefect.Text = "DMC CODE : "
            qgateDefectNg.Show()
            Me.Hide()
        Else
            MsgBox("กรุณาตรวจสินค้าก่อน ")
        End If


    End Sub

    Private Sub btnNc_Click(sender As Object, e As EventArgs) Handles btnNc.Click
        If productcount >= 1 Then
            qgateDefectNc.lbNamedefect.Text = "DMC CODE : "

            qgateDefectNc.Show()
            Me.Hide()
        Else
            MsgBox("กรุณาตรวจสินค้าก่อน ")
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        finish()
        printtagdefect()
        qgateScanTag.Show()
        Me.Close()
    End Sub
    Public Function printtagdefect()
        serialnc = ""
        serialng = ""
        Dim countng
        Dim boxng
        Dim countnc
        Dim boxnc
        Dim defectcountid
        Dim defecttype
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Try
                If tbCounterNg.Text > "0" Or tbCounterNc.Text > "0" Then
                    Dim idcount = md.Get_IDDefectCount(configposition)
                    Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(idcount)
                    For Each item As Object In dict6
                        defecttype = item("idc_type").ToString
                        If defecttype = "0" Then
                            defectcountid = item("idc_id").ToString
                            defectcountidng = defectcountid
                        Else
                            defectcountid = item("idc_id").ToString
                            defectcountidnc = defectcountid
                        End If
                    Next
                    If tbCounterNg.Text > 0 Then
                        If tbCounterNg.Text <= 9 Then
                            countng = "0000" & tbCounterNg.Text
                        ElseIf tbCounterNg.Text <= 99 Then
                            countng = "000" & tbCounterNg.Text
                        ElseIf tbCounterNg.Text <= 99 Then
                            countng = "00" & tbCounterNg.Text
                        ElseIf tbCounterNg.Text <= 99 Then
                            countng = "0" & tbCounterNg.Text
                        Else
                            countng = tbCounterNg.Text
                        End If
                        If lbBoxNumNg.Text <= 9 Then
                            boxng = "00" & lbBoxNumNg.Text
                        ElseIf lbBoxNumNg.Text <= 99 Then
                            boxng = "0" & lbBoxNumNg.Text
                        Else
                            boxng = lbBoxNumNg.Text
                        End If
                        tagdefectNG = ("DF 1" & " " & partline & "               " & lotcur & " " & partplant & " " & boxng & " " & countng & " " & partnotagfa)
                        md.insert_info_tagdefect(defectcountidng, "1", Module1.num_user(0), tagdefectNG, boxng)
                        Module1.numng = 0
                        printtagdefect(tagdefectNG)
                    End If
                    If tbCounterNc.Text > 0 Then
                        If tbCounterNc.Text <= 9 Then
                            countnc = "0000" & tbCounterNc.Text
                        ElseIf tbCounterNc.Text <= 99 Then
                            countnc = "000" & tbCounterNc.Text
                        ElseIf tbCounterNc.Text <= 99 Then
                            countnc = "00" & tbCounterNc.Text
                        ElseIf tbCounterNg.Text <= 99 Then
                            countnc = "0" & tbCounterNc.Text
                        Else
                            countnc = tbCounterNc.Text
                        End If
                        If lbBoxNumNc.Text <= 9 Then
                            boxnc = "00" & lbBoxNumNc.Text
                        ElseIf lbBoxNumNg.Text <= 99 Then
                            boxnc = "0" & lbBoxNumNc.Text
                        Else
                            boxnc = lbBoxNumNc.Text
                        End If
                        tagdefectNC = ("DF 2" & " " & partline & "               " & lotcur & " " & partplant & " " & boxnc & " " & countnc & " " & partnotagfa)
                        md.insert_info_tagdefect(defectcountidnc, "1", Module1.num_user(0), tagdefectNC, boxnc)
                        Module1.numnc = 0
                        printtagdefect(tagdefectNC)
                    End If
                End If

                md.update_Status_Defect_count(configposition, Module1.num_user(0))
            Catch ex As Exception
                MsgBox("ไม่พบ ชิ้นงานที่เป็น NG หรือ NC")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function printtagdefect(tagdefect As String)
        Dim reprintpartno As String
        Dim reprintpartname As String
        Dim reprintsnp As String
        Dim reprintcountbox As String
        Dim reprintcheckdate As String
        Dim reprintlotcurrent As String
        Dim reprintlotproduct As String
        Dim reprintshift As String
        Dim reprintlinecd As String
        Dim reprintphasename As String
        Dim reprintlocation As String
        Dim reprinttagqgate As String
        Dim tagfaid As String
        Dim qrproduct As String
        Dim tagdefectid As String
        Dim status As Boolean = False
        Dim defectcode
        Dim Producttype
        Dim defecttogenqr As String
        Dim defectcountid As String
        Module1.qrpro = ""
        qrproduct = ""
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Try
                Dim tag = md.get_Data_Scan_Print_Defect(tagdefect)
                If tag <> "0" Then
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(tag)
                    For Each item As Object In dict2
                        reprintpartno = item("ifts_part_no").ToString
                        reprintpartname = item("msp_part_name").ToString
                        reprintsnp = item("idc_count").ToString
                        reprintcountbox = item("iptd_count_box").ToString
                        reprintcheckdate = item("date_tag").ToString
                        reprintlotcurrent = item("ifts_lot_current").ToString
                        reprintshift = item("iodc_shift").ToString
                        reprintlinecd = item("ifts_line_cd").ToString
                        reprintphasename = item("mpa_name").ToString
                        reprintlocation = item("mpn_location").ToString
                        reprinttagqgate = item("iptd_tagdefect").ToString
                        tagfaid = item("ifts_id").ToString
                        tagdefectid = item("iptd_id").ToString
                        status = True
                        Producttype = item("idc_type").ToString
                        defectcountid = item("idc_id").ToString
                    Next
                    Dim count
                    defecttogenqr = ""
                    count = 1
                    Dim countdefect As Integer
                    Dim alldefect = md.Get_AllDefect(defectcountid)
                    Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(alldefect)
                    For Each item1 As Object In dict6
                        If count > 1 Then
                            defecttogenqr &= " | "
                        End If
                        defectcode = item1("md_defect_code").ToString
                        countdefect = item1("total_qty").ToString
                        defecttogenqr &= defectcode & " = " & countdefect
                        count += 1
                    Next
                End If
                PrintDefect.Set_parameter_print(reprintpartno, reprintpartname, "1", reprintlotcurrent, reprintcountbox, reprintsnp, "1", "999", defecttogenqr, "001", "001", reprintshift, "01000", reprintlocation, reprintcheckdate, "1", reprintlotproduct, reprintlinecd, reprinttagqgate, defecttogenqr, Producttype)
            Catch ex As Exception
                MsgBox("ไม่สามารถพิมพ์แท็ก Defect ได้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Public Function getnumdefect()
        Dim dt As Date = Date.Today
        Dim typedefect
        Dim a = dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim b = dt.AddDays(-1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim o = md.get_NumDefect(a, configposition, partnotagfa)
        Dim l = md.get_NumDefect(b, configposition, partnotagfa)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Try
                If o <> "0" Then
                    If TimeOfDay.ToString("HH:mm:ss") >= "08:00:00" Then
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(o)
                        For Each item As Object In dict3
                            typedefect = item("idc_type").ToString
                            If typedefect = "0" Then
                                MsgBox("1.1")
                                Module1.CountNumDefect = item("idc_count").ToString
                                tbCounterNg.Text = Module1.CountNumDefect
                            End If
                            If typedefect = "1" Then
                                MsgBox("1.2")
                                Module1.CountNumDefect = item("idc_count").ToString
                                tbCounterNc.Text = Module1.CountNumDefect
                            End If
                        Next
                    Else
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(l)
                        For Each item As Object In dict3
                            typedefect = item("idc_type").ToString
                            If typedefect = "0" Then
                                MsgBox("1.3")
                                Module1.CountNumDefect = item("idc_count").ToString
                                tbCounterNg.Text = Module1.CountNumDefect
                            End If
                            If typedefect = "1" Then
                                MsgBox("1.4")
                                Module1.CountNumDefect = item("idc_count").ToString
                                tbCounterNc.Text = Module1.CountNumDefect

                            End If
                        Next
                    End If
                Else
                    If TimeOfDay.ToString("HH:mm:ss") >= "08:00:00" Then
                        tbCounterNc.Text = Module1.numnc
                        tbCounterNg.Text = Module1.numng
                    Else
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(l)
                        For Each item As Object In dict3
                            typedefect = item("idc_type").ToString
                            If typedefect = "0" Then
                                Module1.CountNumDefect = item("idc_count").ToString
                                tbCounterNg.Text = Module1.CountNumDefect
                            End If
                            If typedefect = "1" Then
                                Module1.CountNumDefect = item("idc_count").ToString
                                tbCounterNc.Text = Module1.CountNumDefect
                            End If
                        Next
                    End If
                End If

            Catch ex As Exception
                tbCounterNc.Text = Module1.numnc
                tbCounterNg.Text = Module1.numng
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function getboxfect()
        Dim dt As Date = Date.Today
        Dim typedefect
        Dim a = dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim b = dt.AddDays(-1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim o = md.get_BoxDefect(a, configposition, partnotagfa)
            Dim l = md.get_BoxDefect(b, configposition, partnotagfa)

            Try
                If o <> "0" Then
                    If TimeOfDay.ToString("HH:mm:ss") >= "08:00:00" Then
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(o)
                        For Each item As Object In dict3
                            typedefect = item("idc_type").ToString
                            If typedefect = "0" Then
                                Module1.CountBoxDefect = item("iptd_count_box").ToString
                                lbBoxNumNg.Text = Module1.CountBoxDefect + 1
                            End If
                            If typedefect = "1" Then
                                Module1.CountBoxDefect = item("iptd_count_box").ToString
                                lbBoxNumNc.Text = Module1.CountBoxDefect + 1
                            End If
                        Next
                    Else
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(l)
                        For Each item As Object In dict3
                            typedefect = item("idc_type").ToString
                            If typedefect = "0" Then
                                Module1.CountBoxDefect = item("iptd_count_box").ToString
                                lbBoxNumNg.Text = Module1.CountBoxDefect + 1
                            End If
                            If typedefect = "1" Then
                                Module1.CountBoxDefect = item("iptd_count_box").ToString
                                lbBoxNumNc.Text = Module1.CountBoxDefect + 1
                            End If
                        Next
                    End If
                Else

                    If TimeOfDay.ToString("HH:mm:ss") >= "08:00:00" Then
                        lbBoxNumNc.Text = "1"
                        lbBoxNumNg.Text = "1"
                    Else
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(l)
                        For Each item As Object In dict3
                            typedefect = item("idc_type").ToString
                            If typedefect = "0" Then
                                Module1.CountBoxDefect = item("iptd_count_box").ToString
                                lbBoxNumNg.Text = Module1.CountBoxDefect + 1
                            End If
                            If typedefect = "1" Then
                                Module1.CountBoxDefect = item("iptd_count_box").ToString
                                lbBoxNumNc.Text = Module1.CountBoxDefect + 1
                            End If
                        Next
                    End If
                End If

            Catch ex As Exception
                lbBoxNumNc.Text = 1
                lbBoxNumNg.Text = 1
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
End Class