Imports Nancy.Json
Public Class qgateReprintScanPrint
    Dim status = False
    Dim md As New ModelVB
    Dim reprintpartno As String = ""
    Dim reprintpartname As String = ""
    Dim reprintsnp As String = ""
    Dim reprintcountbox As String = ""
    Dim reprintcheckdate As String = ""
    Dim reprintlotcurrent As String = ""
    Dim reprintlotproduct As String = ""
    Dim reprintshift As String = ""
    Dim reprintlinecd As String = ""
    Dim reprintphasename As String = ""
    Dim reprintlocation As String = ""
    Dim reprinttagqgate As String = ""
    Dim tagfaid As String = ""
    Dim qrproduct As String = ""
    Dim tagqgateid As String = ""
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
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim tag = md.get_Data_Scan_Print(tagscan)
            'Try
            If tag <> "0" Then
                    qrproduct = ""
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(tag)
                    For Each item As Object In dict2
                        reprintpartno = item("ifts_part_no").ToString
                        reprintpartname = item("msp_part_name").ToString
                        reprintcountbox = item("iotc_count_box").ToString
                        reprintcheckdate = item("date_tag").ToString
                        reprintlotcurrent = item("ifts_lot_current").ToString
                        reprintlotproduct = item("ifts_lot_no_prod").ToString
                        reprintshift = item("iodc_shift").ToString
                        reprintlinecd = item("ifts_line_cd").ToString
                        reprintphasename = item("mpa_name").ToString
                        reprintlocation = item("mpn_location").ToString
                        reprinttagqgate = item("iotc_tag_qgate").ToString
                        tagfaid = item("ifts_id").ToString
                        tagqgateid = item("iotc_id").ToString
                        lbPartNum.Text = reprintpartno
                        lbBoxNum.Text = reprintcountbox
                        lbLotNum.Text = reprintlotcurrent
                        lbShift.Text = reprintshift
                        lbCheckDate.Text = reprintcheckdate
                        status = True
                    Next
                    Dim allqrproduct = md.Get_QRProductToGenQr(tagfaid)
                    Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(allqrproduct)
                    For Each item As Object In dict6
                        Module1.qrpro = (item("iodc_id").ToString)
                        qrproduct &= Module1.qrpro & " "
                        reprintsnp = item("iodc_count_item").ToString
                        lbQty.Text = reprintsnp
                    Next
                Else
                    qrproduct = ""
                    Dim Tagqr = md.get_Tag_By_Qrproduct(tagscan)
                    If Tagqr <> "0" Then
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Tagqr)
                        For Each item As Object In dict2
                            reprintpartno = item("ifts_part_no").ToString
                            reprintpartname = item("msp_part_name").ToString
                            reprintcountbox = item("iotc_count_box").ToString
                            reprintcheckdate = item("date_tag").ToString
                            reprintlotcurrent = item("ifts_lot_current").ToString
                            reprintlotproduct = item("ifts_lot_no_prod").ToString
                            reprintshift = item("iodc_shift").ToString
                            reprintlinecd = item("ifts_line_cd").ToString
                            reprintphasename = item("mpa_name").ToString
                            reprintlocation = item("mpn_location").ToString
                            reprinttagqgate = item("iotc_tag_qgate").ToString
                            tagfaid = item("ifts_id").ToString
                            tagqgateid = item("iotc_id").ToString
                            lbPartNum.Text = reprintpartno
                            lbQty.Text = reprintsnp
                            lbBoxNum.Text = reprintcountbox
                            lbLotNum.Text = reprintlotcurrent
                            lbShift.Text = reprintshift
                            lbCheckDate.Text = reprintcheckdate
                            status = True
                        Next
                        Dim allqrproduct = md.Get_QRProductToGenQr(tagfaid)
                        Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(allqrproduct)
                        For Each item As Object In dict6
                            Module1.qrpro = (item("iodc_id").ToString)
                            qrproduct &= Module1.qrpro & " "
                            reprintsnp = item("iodc_count_item").ToString
                            lbQty.Text = reprintsnp
                        Next
                    Else
                        MsgBox("ไม่พบ TAG ในวันนี้")
                        status = False
                        tbScanTag.Text = ""
                    End If
                End If
                Return status
            'Catch ex As Exception
            '    MsgBox("ไม่สามารถพิมพ์แท็กได้")
            'End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub pbPrint_Click(sender As Object, e As EventArgs) Handles pbPrint.Click
        If reprintpartno <> "" Then

            md.insert_log_reprint(tagqgateid, num_user(0))
            Dim flgprinttype As String = "reprint"
            PrintTag.Set_parameter_print(reprintpartno, reprintpartname, "1", reprintlotcurrent, reprintcountbox, reprintsnp, "1", "999", qrproduct, "001", "001", reprintshift, "01000", reprintlocation, reprintcheckdate, "1", reprintlotproduct, reprintlinecd, reprinttagqgate, flgprinttype)
            btnprint()
        Else
            MsgBox("กรุณาแสกน Tag หรือ Product ก่อน")
        End If
    End Sub
    Public Function btnprint()
        If tagqgateid <> "0" Then
            md.insert_log_reprint(tagqgateid, num_user(0))
            tbScanTag.Text = ""
            lbPartNum.Text = "-"
            lbQty.Text = "-"
            lbBoxNum.Text = "-"
            lbLotNum.Text = "-"
            lbShift.Text = "-"
            lbCheckDate.Text = "-"
            lbCheckDate.Text = "-"
            tagqgateid = "0"
            qrproduct = ""
            reprintpartno = ""
            reprintpartname = ""
            reprintcountbox = ""
            reprintcheckdate = ""
            reprintlotcurrent = ""
            reprintlotproduct = ""
            reprintshift = ""
            reprintlinecd = ""
            reprintphasename = ""
            reprintlocation = ""
            reprinttagqgate = ""
            tagfaid = ""
            reprintsnp = ""
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
        tagqgateid = "0"
    End Sub
End Class