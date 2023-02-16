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

    Dim Timer As New Timer ' ตัวแปร Object ประเภท เวลา (หรือท่านจะใช้ Object ที่มากับ โปรแกรมก็ได้ครับ คือ Timmer'เมือ Form โหลดมา Timer เริ่มทำงาน

    Private Sub qgateOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer.Enabled = True
        btnFinish.Hide()
        Timer1.Enabled = True
        tbQrSerial.Select()
        tbcounter.Text = productcount
        tbCounterNc.Text = productcountNC
        tbCounterNg.Text = productcountNG
        lbUserName.Text = Module1.num_user(0)
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        getpartno = Module1.qgate_part_no
        lbPartNum.Text = Module1.qgate_part_no
        lbPartName.Text = Module1.get_partname()
        lbLotNum.Text = Module1.partlotno
        lbSnp.Text = Module1.partasnp
        lbProductDate.Text = Module1.partactualdate1
        lbBoxNum.Text = Module1.partbox

        Label5.Text = timetocheckqr

    End Sub

    Private Sub btnBackToScan_Click(sender As Object, e As EventArgs) Handles btnBackToScan.Click
        productcount = 0
        productcountNC = 0
        productcountNG = 0
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

        Dim subString = md.get_PartSubString(partno)
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
                'MsgBox("PartNoSu===>" & PartNoSub)
                PartDateSub = qrproduct.Substring(getpartsubend(0), getpartsubnum(1))
                ' MsgBox("PartDateSub" & PartDateSub)
                PartLotSub = qrproduct.Substring(getpartsubend(1), getpartsubnum(2))
                ' MsgBox("PartLotSub===>" & PartLotSub)
                PartShiftSub = qrproduct.Substring(getpartsubend(2), getpartsubnum(3))
                ' MsgBox("PartShiftSub===>" & PartShiftSub)
                PartLineSub = qrproduct.Substring(getpartsubend(3), getpartsubnum(4))
                ' MsgBox("PartLineSub===>" & PartLineSub)
                PartSerialNoSub = qrproduct.Substring(getpartsubend(4), getpartsubnum(5))
                ' MsgBox("PartSerialNoSub===>" & PartSerialNoSub)
                checkcodedmc(PartNoSub, partasnp, qrproduct)
            Else
                tbQrSerial.Text = ""
                MsgBox("QR Code ไม่ตรงกันจำนวนเลชไม่ตรง")

                status = False
            End If
        Else
            tbQrSerial.Text = ""
            MsgBox("ไม่มี model")
            status = False
        End If
        Return status
    End Function
    Public Function checkcodedmc(qrdmc As String, productsnp As String, qralldmc As String)
        If CDbl(Val(Trim(productcount))) <> CDbl(Val(Trim(productsnp))) Then
            If qrdmc = Module1.dmcqrscan Then
                If productcount = 0 Or s >= timetocheckqr Then 'ถ้าค่าเวลาที่เป็นมิลิวินาที
                    shift = md.get_WorkShoftTime(DateTime.Now.ToString("HH:mm:ss"))
                    Dim dict8 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(shift)
                    For Each item As Object In dict8
                        workshiftid = item("mws_shift").ToString
                    Next
                    'Dim rsworkshift = md.get_IdWorkShift(shift)
                    Dim idtagfa = md.get_ID_Tag_fa(Module1.tagfa)
                    Dim idnamedigit = md.get_id_Digitname(partnamedigit)
                    'Dim dict4 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsworkshift)
                    'For Each item As Object In dict4
                    '    workshiftid = item("mws_id").ToString
                    'Next
                    Dim dict5 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(idtagfa)
                    For Each item As Object In dict5
                        tagfaid = item("ifts_id").ToString
                        lotcurrent = item("ifts_lot_current").ToString
                    Next
                    Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(idnamedigit)
                    For Each item As Object In dict6
                        namedigitid = item("mdt_id").ToString
                    Next
                    Dim counttime As Integer = s
                    Dim checkduplicate = md.get_QrProduct(tbQrSerial.Text)

                    If checkduplicate = "0" Then
                        productcount = productcount + 1
                        'MsgBox("tagfaid=====> " & tagfaid)
                        'MsgBox("configposition=====> " & configposition)
                        'MsgBox("namedigitid=====> " & namedigitid)
                        'MsgBox("workshiftid=====> " & workshiftid)
                        'MsgBox("productcount=====> " & productcount)
                        'MsgBox("productrank=====> " & productrank)
                        'MsgBox("productcheckcount=====> " & productcheckcount)
                        'MsgBox("qralldmc=====> " & qralldmc)
                        'MsgBox("num_user(0)=====> " & num_user(0))
                        'MsgBox("counttime=====> " & counttime)
                        MsgBox("INSERT===>>>>>> ")
                        productcheckcount = 1


                        Module1.qrpro.Add(qralldmc)
                        'MsgBox(Module1.qrpro(j))
                        t &= Module1.qrpro(j) & vbCrLf
                        'MsgBox("-" & t & "-")
                        j += 1



                        Dim rscountProduct = md.insert_qr_product(tagfaid, configposition, namedigitid, workshiftid, productcount, productrank,
                        productcheckcount, qralldmc, num_user(0), counttime)
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

                                Dim rscountProduct = md.update_info_part(tagfaid, configposition, workshiftid, productcount,
                        productcheckcount, num_user(0), qralldmc, counttime)
                                s = 0
                                tbcounter.Text = productcount
                                MsgBox("update===>>>>>> ")
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
    End Function

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        MsgBox(t)
        Dim tagqgate = (partcodemaster & partline & partplandate & partseqplan & partnotagfa & (DateTime.Now.ToString("yyyyMMdd") & partasnp & lotcurrent & "                         " & (DateTime.Now.ToString("yyyyMMdd") & "001" & phaseplant & "001")))
        md.insert_Tag_Qgate_complete(tagfaid, "001", "1", num_user(0), tagqgate)
        productcount = 0
        productcountNC = 0
        productcountNG = 0
        qgateScanTag.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'ให้เพิ่มค่าตัวแปรที่เป็นมิลิวินาที
        MS += 1

        If Ms >= 10 Then
            s += 1
            Ms = 0
        End If
        Label3.Text = s.ToString

    End Sub

    Private Sub btnNg_Click(sender As Object, e As EventArgs) Handles btnNg.Click
        If productcount >= 1 Then
            qgateDefectNg.lbNamedefect.Text = "PART NO : "

            qgateDefectNg.Show()
            Me.Hide()
        Else
            MsgBox("กรุณาตรวจสินค้าก่อน")
        End If

    End Sub

    Private Sub btnNc_Click(sender As Object, e As EventArgs) Handles btnNc.Click
        If qrproduct <> "" Then
            qgateDefectNc.lbNamedefect.Text = "PART NO : "

            qgateDefectNc.Show()
            Me.Hide()
        Else
            MsgBox("กรุณาตรวจสินค้าก่อน")
        End If
    End Sub
End Class