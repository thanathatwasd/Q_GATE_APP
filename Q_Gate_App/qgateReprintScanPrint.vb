Imports Nancy.Json
Public Class qgateReprintScanPrint
    Dim md As New ModelVB
    Dim partno As String
    Dim productsnp As String
    Dim boxnum As String
    Dim lotcurrent As String
    Dim shift As String
    Dim checkdate As String
    Dim status As Boolean = False
    Dim tagcompleteid As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        qgateReprintTag.Show()
        Me.Close()
    End Sub

    Private Sub pbBackReprintToMenu_Click(sender As Object, e As EventArgs) Handles pbBackReprintToMenu.Click
        qgateprintTag.Show()
        Me.Close()
    End Sub

    Private Sub tbScanTag_KeyDown(sender As Object, e As KeyEventArgs) Handles tbScanTag.KeyDown
        If e.KeyCode = Keys.Enter Then
            If getDataScanPrint(tbScanTag.Text) Then
                tbScanTag.Text = ""


            End If
        End If

    End Sub
    Public Function getDataScanPrint(tagscan As String)
        Dim tag = md.get_Data_Scan_Print(tagscan)
        If tag <> "0" Then
            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(tag)
            For Each item As Object In dict2
                tagcompleteid = item("iotc_id").ToString
                partno = item("ifts_part_no").ToString
                productsnp = item("ifts_snp").ToString
                boxnum = item("ifts_box").ToString
                lotcurrent = item("ifts_lot_current").ToString
                shift = item("iodc_shift").ToString
                checkdate = item("iotc_create_date").ToString
                lbPartNum.Text = partno
                lbQty.Text = productsnp
                lbBoxNum.Text = boxnum
                lbLotNum.Text = lotcurrent
                lbShift.Text = shift
                lbCheckDate.Text = checkdate

                status = True
            Next

        Else
            Dim Tagqr = md.get_Tag_By_Qrproduct(tagscan)
            If Tagqr <> "0" Then
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Tagqr)
                For Each item As Object In dict2
                    tagcompleteid = item("iotc_id").ToString
                    partno = item("ifts_part_no").ToString
                    productsnp = item("ifts_snp").ToString
                    boxnum = item("ifts_box").ToString
                    lotcurrent = item("ifts_lot_current").ToString
                    shift = item("iodc_shift").ToString
                    checkdate = item("iotc_create_date").ToString
                    lbPartNum.Text = partno
                    lbQty.Text = productsnp
                    lbBoxNum.Text = boxnum
                    lbLotNum.Text = lotcurrent
                    lbShift.Text = shift
                    lbCheckDate.Text = checkdate

                    status = True
                Next
            Else
                MsgBox("ไม่พบ TAG ในวันนี้")
                status = False
                tbScanTag.Text = ""
            End If
        End If
        Return status
    End Function

    Private Sub pbPrint_Click(sender As Object, e As EventArgs) Handles pbPrint.Click
        md.insert_log_reprint(tagcompleteid, num_user(0))
        btnprint()
    End Sub

    Public Function btnprint()
        If tagcompleteid <> "0" Then
            MsgBox("ปริ้น Tag สำเร็จ")

            md.insert_log_reprint(tagcompleteid, num_user(0))
            tbScanTag.Text = ""
            lbPartNum.Text = "-"
            lbQty.Text = "-"
            lbBoxNum.Text = "-"
            lbLotNum.Text = "-"
            lbShift.Text = "-"
            lbCheckDate.Text = "-"
            lbCheckDate.Text = "-"
            tagcompleteid = "0"
        Else
            MsgBox("กรุณาแสกน TAG Q-GATE")
        End If
    End Function

    Private Sub qgateReprintScanPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbZone.Text = zoneset
        lbStation.Text = setstationid
    End Sub

    Private Sub pbClear_Click(sender As Object, e As EventArgs) Handles pbClear.Click
        tbScanTag.Text = ""
        lbPartNum.Text = "-"
        lbQty.Text = "-"
        lbBoxNum.Text = "-"
        lbLotNum.Text = "-"
        lbShift.Text = "-"
        lbCheckDate.Text = "-"
        lbCheckDate.Text = "-"
        tagcompleteid = "0"
    End Sub

End Class