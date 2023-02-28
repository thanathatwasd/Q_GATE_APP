Imports Nancy.Json
Public Class qgateOperationManual
    Dim md As New ModelVB

    Dim qralldmc = "-"
    Dim workshift As String
    Dim productrank = "A"
    Dim productcheckcount As Integer = 1
    Dim workshiftid
    Dim tagfaid
    Dim t
    Dim Ms As Integer = 0 ' เก็บมิลิวินาที
    Dim status As Boolean = False
    Dim s As Integer = 0

    Dim Timer As New Timer ' ตัวแปร Object ประเภท เวลา (หรือท่านจะใช้ Object ที่มากับ โปรแกรมก็ได้ครับ คือ Timmer'เมือ Form โหลดมา Timer เริ่มทำงาน
    Private Sub qgateOperationManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnFinish.Hide()
        Timer.Enabled = True
        Timer1.Enabled = True
        tbCounter.Enabled = False
        tbCounter.Text = productcount
        tbCounterNc.Text = 0
        tbCounterNg.Text = 0
        Module1.qgate_part_no = ""
        lbUserName.Text = user
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        lbLotNum.Text = Module1.partlotno
        lbSnp.Text = Module1.partasnp
        lbProductDate.Text = Module1.partactualdate1
        lbBoxNum.Text = Module1.BoxNum
        Dim rsGetPartName = md.get_DataPartName(partnofornondmc)
        'MsgBox("partnofornondmc===> " & partnofornondmc)
        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsGetPartName)
        For Each item As Object In dict2
            Dim modelpart = item("msp_part_name").ToString
            Dim modelpartno = item("msp_part_no").ToString
            lbPartName.Text = modelpart
            lbPartNum.Text = modelpartno
        Next
    End Sub



    Private Sub btnBacktoScanTag_Click(sender As Object, e As EventArgs) Handles btnBacktoScanTag.Click
        productcount = 0
        productcountNC = 0
        productcountNG = 0
        qgateScanTag.Show()
        Me.Close()
    End Sub

    Private Sub pbPlus_Click(sender As Object, e As EventArgs) Handles pbPlus.Click
        countProduct()
        tbCounter.Text = productcount

        If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
            btnFinish.Show()


        Else
            btnFinish.Hide()

        End If


    End Sub

    Private Sub pbMinus_Click(sender As Object, e As EventArgs) Handles pbMinus.Click
        If productcount >= 1 Then
            productcount = productcount - 1
            tbCounter.Text = productcount

            If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                btnFinish.Show()


            Else
                btnFinish.Hide()

            End If

        Else
            MsgBox("ไม่สามารถลบ")
        End If

    End Sub

    Public Function countProduct()
        If CDbl(Val(Trim(productcount))) <> CDbl(Val(Trim(partasnp))) Then



            If productcount = 0 Or s >= Module1.timetocheckqr Then 'ถ้าค่าเวลาที่เป็นมิลิวินาที


                shift = md.get_WorkShoftTime(DateTime.Now.ToString("HH:mm:ss"))
                Dim dict8 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(shift)
                For Each item As Object In dict8
                    workshiftid = item("mws_shift").ToString
                Next

                Dim idtagfa = md.get_ID_Tag_fa(Module1.tagfa)
                Dim idnamedigit = "-"
                Dim dict5 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(idtagfa)
                For Each item As Object In dict5
                    tagfaid = item("ifts_id").ToString
                    lotproduct = item("ifts_lot_no_prod")
                Next
                Dim counttime As Integer = s
                productcount = productcount + 1
                Dim rscountProduct = md.insert_qr_product(tagfaid, configposition, idnamedigit, workshiftid, productcount, productrank,
                    productcheckcount, qralldmc, num_user(0), counttime)
                s = 0
                tbCounter.Text = productcount
                'MsgBox("เพิ่มสำเร็จ")


            Else
                MsgBox("ตรวจงานให้ละเอียดด")
                status = False

            End If
        Else
            MsgBox("สินค้าครบจำนวน กรุณาแสกน tag ใหม่")
            status = False

        End If
        Return status
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ให้เพิ่มค่าตัวแปรที่เป็นมิลิวินาที
        Ms += 1

        If Ms >= 10 Then
            s += 1
            Ms = 0
        End If
        Label1.Text = s.ToString

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        'Dim tagqgate = (partcodemaster & partline & partplandate & partseqplan & partnotagfa & (DateTime.Now.ToString("yyyyMMdd") & partasnp & lotcurrent & "                         " & (DateTime.Now.ToString("yyyyMMdd") & "001" & phaseplant & "001")))
        'MsgBox("tagqgate==>  " & tagqgate)
        'md.insert_Tag_Qgate_complete(tagfaid, "001", "1", num_user(0), tagqgate)
        'productcount = 0
        'productcountNC = 0
        'productcountNG = 0
        'qgateScanTag.Show()
        'Me.Close()



        'Module1.qrpro.Add(qralldmc)
        ''MsgBox(Module1.qrpro(j))
        't &= Module1.qrpro(j) & vbCrLf
        ''MsgBox("-" & t & "-")
        'j += 1


        Dim allqrproduct = md.get_QRProductToGenQr(tagfaid)
        'MsgBox("allqrproduct===> " & allqrproduct)
        Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(allqrproduct)
        For Each item As Object In dict6
            Module1.qrpro = (item("iodc_id").ToString)
            'MsgBox(Module1.qrpro(j))
            t &= Module1.qrpro & " "
            'MsgBox("-" & t & "-")

            j += 1

        Next
        'MsgBox(t)





        Dim tagqgate = (partcodemaster & partline & partplandate & partseqplan & partnotagfa & (DateTime.Now.ToString("yyyyMMdd") & partasnp & lotcu & "                         " & (DateTime.Now.ToString("yyyyMMdd") & partseqplan & phaseplant & Box_seq)))
        md.insert_Tag_Qgate_complete(tagfaid, Box_seq, "1", num_user(0), tagqgate)
        productcount = 0

        PrintTag.Set_parameter_print(partnotagfa, partnamedigit, "1", lotcur, Box_seq, partasnp, "1", "999", t, "001", "001", workshiftid, "01000", Locationpart, DateTime.Now.ToString("dd/MM/yyyy"), "1", lotproduct, partline, tagqgate)
        qgateScanTag.Show()
        Me.Close()




    End Sub

    Private Sub btnNg_Click(sender As Object, e As EventArgs) Handles btnNg.Click
        If productcount >= 1 Then
            qgateDefectNg.lbNamedefect.Text = "BOX NO : "

            qgateDefectNg.Show()
            Me.Hide()
        Else
            MsgBox("กรุณาตรวจสินค้าก่อน")
        End If

    End Sub

    Private Sub btnNc_Click(sender As Object, e As EventArgs) Handles btnNc.Click
        If productcount >= 1 Then
            qgateDefectNc.lbNamedefect.Text = "BOX NO : "

            qgateDefectNc.Show()
            Me.Hide()
        Else
            MsgBox("กรุณาตรวจสินค้าก่อน")
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        serialnc = ""
        serialng = ""
        'Dim getInfoDefectCountnc = md.get_Info_DefectCount(defectgroupnc, timenow)
        '    Dim getInfoDefectCountng = md.get_Info_DefectCount(defectgroupng, timenow)

        'md.update_Status_Defect_count(defectnc, num_user(0))
        'md.update_Status_Defect_count(defectng, num_user(0))


        '    Dim tagdefect = (partcodemaster & partline & partplandate & partseqplan & partnotagfa & (DateTime.Now.ToString("yyyyMMdd") & partasnp & lotcurrent & "                         " & (DateTime.Now.ToString("yyyyMMdd") & "001" & phaseplant & boxdefect)))

        '    productcountNC = 0
        '    productcountNG = 0
        '    boxdefect = boxdefect - 1


    End Sub
End Class