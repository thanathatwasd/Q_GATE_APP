Imports Nancy.Json
Imports System.Web.Script.Serialization
Public Class qgateReprintTag
    Dim md As New ModelVB
    Dim res As String
    Dim getLotNo
    Dim status As Boolean = False
    Private Sub qgateReprintTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        cbCalandar.Format = DateTimePickerFormat.Custom
        cbCalandar.Value = Date.Now
        cbCalandar.CustomFormat = "dd MMMM yyyy"
        res = Convert.ToDateTime(cbCalandar.Text).ToString("yyyy-MM-dd")
        loadpartno(setphaseid, setzoneid, res)

    End Sub

    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles cbCalandar.CloseUp
        CbPartNum.Items.Clear()
        CbLotNum.Items.Clear()
        lvDetail.Items.Clear()
        res = Convert.ToDateTime(cbCalandar.Text).ToString("yyyy-MM-dd")
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
    End Sub

    Public Function loadpartno(phase As String, zone As String, dodate As String)
        CbPartNum.Items.Clear()
        res = Convert.ToDateTime(cbCalandar.Text).ToString("yyyy-MM-dd")
        Dim getphaseandzone = md.get_PartNoTo_Reprint(phase, zone, dodate)
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
    End Function

    Public Function loadlotno(phase As String, zone As String, dodate As String, parnum As String)
        CbLotNum.Items.Clear()
        getLotNo = md.get_LotNoTo_Reprint(phase, zone, dodate, parnum)

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
    End Function

    Public Function loadlv(phase As String, zone As String, dodate As String, parnum As String, lotnum As String)
        Dim getBoxNo = md.get_BoxNoTo_Reprint(phase, zone, dodate, parnum, lotnum)
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
    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbBackReprintToMenu.Click
        qgateprintTag.Show()
        Me.Close()
    End Sub
    Private Sub CbLotNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbLotNum.SelectedIndexChanged
        lvDetail.Items.Clear()
        loadlv(setphaseid, setzoneid, res, CbPartNum.SelectedItem, CbLotNum.SelectedItem)
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        pnListPrint.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        qgateReprintScanPrint.Show()
        Me.Close()
    End Sub
    Private Sub pbPrint_Click(sender As Object, e As EventArgs) Handles pbPrint.Click
        Dim a = getid()
        md.insert_log_reprint(a, num_user(0))
        MsgBox("ปริ้น Tag สำเร็จ")
    End Sub
    Public Function getid()
        Dim rs As String = ""
        For Each lvItem As ListViewItem In lvDetail.SelectedItems
            rs = lvDetail.Items(lvItem.Index).SubItems(0).Text
        Next
        Return rs
    End Function

    Private Sub CbPartNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPartNum.SelectedIndexChanged
        CbLotNum.Items.Clear()
        loadlotno(setphaseid, setzoneid, res, CbPartNum.SelectedItem)
    End Sub

    Private Sub pbClear_Click(sender As Object, e As EventArgs) Handles pbClear.Click
        lvDetail.Items.Clear()
        CbLotNum.Items.Clear()
        CbPartNum.Items.Clear()
    End Sub


End Class