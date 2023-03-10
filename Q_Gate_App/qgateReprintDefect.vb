Imports Nancy.Json
Public Class qgateReprintDefect
    Dim md As New ModelVB
    Dim res As String
    Dim getLotNo
    Dim status As Boolean = False
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
    Dim tagdefect
    Dim defecttogenqr As String
    Dim defectcountid As String
    Dim defectcode
    Dim Producttype
    Dim tagdefectid As String
    Private Sub qgateReprintTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        cbCalandar.Format = DateTimePickerFormat.Custom
        cbCalandar.Value = Date.Now
        cbCalandar.CustomFormat = "dd MMMM yyyy"
        res = Convert.ToDateTime(cbCalandar.Text).ToString("yyyy-MM-dd")
        loadpartno(res)
    End Sub
    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles cbCalandar.CloseUp
        CbPartNum.Items.Clear()
        CbLotNum.Items.Clear()
        lvDetail.Items.Clear()
        res = Convert.ToDateTime(cbCalandar.Text).ToString("yyyy-MM-dd")
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim getphaseandzone = md.get_PartNoTo_Reprint_Defect(res)
            If getphaseandzone <> "0" Then
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getphaseandzone)
                For Each item As Object In dict2
                    Dim partNO = item("ifts_part_no").ToString
                    CbPartNum.Items.Add(partNO)
                    loadpartno(res)
                Next
            Else
                MsgBox("หา TAG ไม่เจอ")
            End If
        Else
            MsgBox("Waiting Internet")
        End If
    End Sub

    Public Function loadpartno(dodate As String)
        CbPartNum.Items.Clear()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim getphaseandzone = md.get_PartNoTo_Reprint_Defect(dodate)
            If getphaseandzone <> "0" Then
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getphaseandzone)
                For Each item As Object In dict2
                    Dim partNO = item("ifts_part_no").ToString
                    CbPartNum.Items.Add(partNO)
                    status = True
                Next
                CbPartNum.SelectedIndex = 0
            Else
                MsgBox("หา TAG ไม่เจอ")
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function loadlotno(dodate As String, parnum As String)
        CbLotNum.Items.Clear()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            getLotNo = md.get_LotNoTo_Reprint_Defect(dodate, parnum)
            If getLotNo <> "0" Then
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getLotNo)
                For Each item As Object In dict2
                    Dim lotcurrent = item("ifts_lot_current").ToString
                    CbLotNum.Items.Add(lotcurrent)
                    status = True
                Next
                CbLotNum.SelectedIndex = 0
            Else
                MsgBox("ไม่พบ lot นี้")
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function loadlv(dodate As String, parnum As String, lotnum As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim getBoxNo = md.get_BoxNoTo_Reprint_Defect(dodate, parnum, lotnum)
            If getBoxNo <> "0" Then
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getBoxNo)
                For Each item As Object In dict2
                    Dim idtag = item("iptd_id").ToString
                    Dim partno = item("ifts_part_no").ToString
                    Dim lotCurrent = item("ifts_lot_current").ToString
                    Dim boxno = item("iptd_count_box").ToString
                    Dim list = New ListViewItem(idtag)
                    list.SubItems.Add(partno)
                    list.SubItems.Add(lotCurrent)
                    list.SubItems.Add(boxno)
                    lvDetail.Items.Add(list)
                Next
                status = True
            Else
                MsgBox("ไม่มี detail นี้")
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbBackReprintToMenu.Click
        qgateprintTag.Show()
        Me.Close()
    End Sub
    Private Sub CbLotNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbLotNum.SelectedIndexChanged
        lvDetail.Items.Clear()
        loadlv(res, CbPartNum.SelectedItem, CbLotNum.SelectedItem)
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        qgateReprintScanPrintDefect.Show()
        Me.Close()
    End Sub
    Private Sub pbPrint_Click(sender As Object, e As EventArgs) Handles pbPrint.Click

        printtag()
    End Sub
    Public Function printtag()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim a = getid()
            Dim gettag = md.get_Tag_Print_Defect(a)
            Try
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(gettag)
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
                Dim flgprinttype As String = "reprint"
                md.insert_log_reprint_Defect(tagdefectid, num_user(0))
                PrintDefect.Set_parameter_print(reprintpartno, reprintpartname, "1", reprintlotcurrent, reprintcountbox, reprintsnp, "1", "999", defecttogenqr, "001", "001", reprintshift, "01000", reprintlocation, reprintcheckdate, "1", reprintlotproduct, reprintlinecd, reprinttagqgate, defecttogenqr, Producttype)
            Catch ex As Exception
                MsgBox("ไม่สามารถพิมพ์แท็ก Defect ได้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
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
    End Function
    Public Function getid()
        Dim rs As String = ""
        For Each lvItem As ListViewItem In lvDetail.SelectedItems
            rs = lvDetail.Items(lvItem.Index).SubItems(0).Text
        Next
        Return rs
    End Function

    Private Sub CbPartNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPartNum.SelectedIndexChanged
        CbLotNum.Items.Clear()
        loadlotno(res, CbPartNum.SelectedItem)
    End Sub

    Private Sub pbClear_Click(sender As Object, e As EventArgs) Handles pbClear.Click
        lvDetail.Items.Clear()
        CbLotNum.Items.Clear()
        CbPartNum.Items.Clear()
    End Sub

End Class