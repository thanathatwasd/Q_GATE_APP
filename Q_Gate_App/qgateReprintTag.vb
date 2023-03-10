Imports Nancy.Json
Imports System.Web.Script.Serialization
Public Class qgateReprintTag
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
    Dim qrproduct As String
    Private Sub qgateReprintTag_Load(sender As Object, e As EventArgs)
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        cbCalandar.Format = DateTimePickerFormat.Custom
        cbCalandar.Value = Date.Now
        cbCalandar.CustomFormat = "dd MMMM yyyy"
        res = Convert.ToDateTime(cbCalandar.Text).ToString("yyyy-MM-dd")
        loadpartno(setphaseid, setzoneid, res)
    End Sub
    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs)

        getdatetoday()
    End Sub
    Public Function getdatetoday()
        CbPartNum.Items.Clear()
        CbLotNum.Items.Clear()
        lvDetail.Items.Clear()
        res = Convert.ToDateTime(cbCalandar.Text).ToString("yyyy-MM-dd")
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim getphaseandzone = md.get_PartNoTo_Reprint(setphaseid, setzoneid, res)
            If getphaseandzone <> "0" Then
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getphaseandzone)
                For Each item As Object In dict2
                    Dim partNO = item("ifts_part_no").ToString
                    CbPartNum.Items.Add(partNO)
                    loadpartno(setphaseid, setzoneid, res)
                Next
            Else
                MsgBox("หา TAG ไม่เจอ")
            End If
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Public Function loadpartno(phase As String, zone As String, dodate As String)
        CbPartNum.Items.Clear()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim getphaseandzone = md.get_PartNoTo_Reprint(phase, zone, dodate)
            Try
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
            Catch ex As Exception
                MsgBox("หา TAG ไม่เจอ")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Public Function loadlotno(phase As String, zone As String, dodate As String, parnum As String)
        CbLotNum.Items.Clear()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            getLotNo = md.get_LotNoTo_Reprint(phase, zone, dodate, parnum)
            Try
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
            Catch ex As Exception
                MsgBox("ไม่พบ lot นี้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Public Function loadlv(dodate As String, parnum As String, lotnum As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim getBoxNo = md.get_BoxNoTo_Reprint(dodate, parnum, lotnum)
            Try
                If getBoxNo <> "0" Then
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getBoxNo)
                    For Each item As Object In dict2
                        Dim idtag = item("iotc_id").ToString
                        Dim partno = item("ifts_part_no").ToString
                        Dim lotCurrent = item("ifts_lot_current").ToString
                        Dim boxno = item("iotc_count_box").ToString
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
            Catch ex As Exception
                MsgBox("ไม่มี detail นี้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        qgateprintTag.Show()
        Me.Close()
    End Sub
    Private Sub CbLotNo_SelectedIndexChanged(sender As Object, e As EventArgs)
        lvDetail.Items.Clear()
        loadlv(res, CbPartNum.SelectedItem, CbLotNum.SelectedItem)
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        pnListPrint.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        qgateReprintScanPrint.Show()
        Me.Close()
    End Sub
    Private Sub pbPrint_Click(sender As Object, e As EventArgs)
        printtag()
    End Sub
    Public Function printtag()
        qrproduct = ""


        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim a = getid()
            md.insert_log_reprint(a, num_user(0))
            Dim gettag = md.get_TagQgate(a)
            Try
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(gettag)
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
                Next
                Dim allqrproduct = md.Get_QRProductToGenQr(tagfaid)
                Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(allqrproduct)
                For Each item As Object In dict6
                    Module1.qrpro = (item("iodc_id").ToString)
                    qrproduct &= Module1.qrpro & " "
                    reprintsnp = item("iodc_count_item").ToString
                Next
                Dim flgprinttype As String = "reprint"
                printtag.Set_parameter_print(reprintpartno, reprintpartname, "1", reprintlotcurrent, reprintcountbox, reprintsnp, "1", "999", qrproduct, "001", "001", reprintshift, "01000", reprintlocation, reprintcheckdate, "1", reprintlotproduct, reprintlinecd, reprinttagqgate, flgprinttype)
            Catch ex As Exception
                MsgBox("ไม่สามารถออกแท็กได้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If



    End Function
    Public Function getid()
        Dim rs As String = ""
        For Each lvItem As ListViewItem In lvDetail.SelectedItems
            rs = lvDetail.Items(lvItem.Index).SubItems(0).Text
        Next
        Return rs
    End Function
    Private Sub CbPartNum_SelectedIndexChanged(sender As Object, e As EventArgs)
        CbLotNum.Items.Clear()
        loadlotno(setphaseid, setzoneid, res, CbPartNum.SelectedItem)
    End Sub
    Private Sub pbClear_Click(sender As Object, e As EventArgs)
        lvDetail.Items.Clear()
        CbLotNum.Items.Clear()
        CbPartNum.Items.Clear()
    End Sub

    Private Sub qgateReprintTag_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class