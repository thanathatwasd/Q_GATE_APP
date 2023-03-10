Imports Nancy.Json
Public Class qgateReprintScanPrintDefect
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
    Dim tagdefectid As String = ""
    Dim status As Boolean = False
    Dim defectcode = ""
    Dim Producttype = ""
    Dim tagdefect = ""
    Dim defecttogenqr As String = ""
    Dim defectcountid As String = ""

    Private Sub qgateReprintScanPrintDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbZone.Text = zoneset
        lbStation.Text = setstationid
    End Sub
    Public Function getDataScanPrint(tagscan As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim tag = md.get_Data_Scan_Print_Defect(tagscan)
            Try
                If tag <> "0" Then
                    Module1.qrpro = ""
                    qrproduct = ""
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
                        lbPartNum.Text = reprintpartno
                        lbQty.Text = reprintsnp
                        lbBoxNum.Text = reprintcountbox
                        lbLotNum.Text = reprintlotcurrent
                        lbShift.Text = reprintshift
                        lbCheckDate.Text = reprintcheckdate
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
                Else
                    Dim Tagdefect = md.get_Tag_By_Qrproduct_Defect(tagscan)
                    Dim dict10 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Tagdefect)
                    For Each item1 As Object In dict10
                        Tagdefect = (item1("iptd_tagdefect").ToString)
                    Next
                    Dim alltagdefect = md.get_Data_Scan_Print_Defect(Tagdefect)
                    If alltagdefect <> "0" Then
                        Module1.qrpro = ""
                        qrproduct = ""
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(alltagdefect)
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
                            Producttype = item("idc_type").ToString
                            defectcountid = item("idc_id").ToString
                            lbPartNum.Text = reprintpartno
                            lbQty.Text = reprintsnp
                            lbBoxNum.Text = reprintcountbox
                            lbLotNum.Text = reprintlotcurrent
                            lbShift.Text = reprintshift
                            lbCheckDate.Text = reprintcheckdate
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
                        status = True
                    Else
                        MsgBox("ไม่พบ TAG ในวันนี้")
                        status = False
                        tbScanTag.Text = ""
                    End If
                End If
                Return status
            Catch ex As Exception
                MsgBox("ไม่สามารถพิมพ์แท็กได้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub tbScanTag_KeyDown(sender As Object, e As KeyEventArgs) Handles tbScanTag.KeyDown
        If e.KeyCode = Keys.Enter Then
            If getDataScanPrint(tbScanTag.Text) Then
            End If
        End If
    End Sub

    Private Sub pbBackReprintToMenu_Click(sender As Object, e As EventArgs) Handles pbBackReprintToMenu.Click
        qgateprintTag.Show()
        Me.Close()
    End Sub
    Public Function btnprint()
        If tagdefectid <> "0" Then
            MsgBox("ปริ้น Tag สำเร็จ")
            tbScanTag.Text = ""
            lbPartNum.Text = "-"
            lbQty.Text = "-"
            lbBoxNum.Text = "-"
            lbLotNum.Text = "-"
            lbShift.Text = "-"
            lbCheckDate.Text = "-"
            lbCheckDate.Text = "-"
            tagdefectid = "0"
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
    Private Sub pbClear_Click(sender As Object, e As EventArgs) Handles pbClear.Click
        tbScanTag.Text = ""
        lbPartNum.Text = "-"
        lbQty.Text = "-"
        lbBoxNum.Text = "-"
        lbLotNum.Text = "-"
        lbShift.Text = "-"
        lbCheckDate.Text = "-"
        lbCheckDate.Text = "-"
        tagdefectid = "0"
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        qgateReprintDefect.Show()
        Me.Close()
    End Sub

    Private Sub pbPrint_Click(sender As Object, e As EventArgs) Handles pbPrint.Click


        If reprintpartno <> "" Then
            PrintDefect.Set_parameter_print(reprintpartno, reprintpartname, "1", reprintlotcurrent, reprintcountbox, reprintsnp, "1", "999", defecttogenqr, "001", "001", reprintshift, "01000", reprintlocation, reprintcheckdate, "1", reprintlotproduct, reprintlinecd, reprinttagqgate, defecttogenqr, Producttype)
            md.insert_log_reprint_Defect(tagdefectid, num_user(0))
            btnprint()
        Else
            MsgBox("กรุณาแสกน Tag หรือ Product ก่อน")
        End If
    End Sub
End Class