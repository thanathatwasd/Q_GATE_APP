Imports Nancy.Json
Public Class qgateOperationManual
    Dim md As New ModelVB

    Dim qralldmc = "-"
    Dim workshift As String
    Dim productrank = "A"
    Dim productcheckcount As Integer = 1
    Dim workshiftid
    Dim tagfaid

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
        lbUserName.Text = Module1.num_user(0)
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        lbLotNum.Text = Module1.partlotno
        lbSnp.Text = Module1.partasnp
        lbProductDate.Text = Module1.partactualdate1
        lbBoxNum.Text = Module1.partbox
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

        Dim tagqgate = (partcodemaster & partline & partplandate & partseqplan & partnotagfa & (DateTime.Now.ToString("yyyyMMdd") & partasnp & lotcurrent & "                         " & (DateTime.Now.ToString("yyyyMMdd") & "001" & phaseplant & "001")))
        MsgBox("tagqgate==>  " & tagqgate)
        md.insert_Tag_Qgate_complete(tagfaid, "001", "1", num_user(0), tagqgate)
        productcount = 0
        productcountNC = 0
        productcountNG = 0
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
End Class