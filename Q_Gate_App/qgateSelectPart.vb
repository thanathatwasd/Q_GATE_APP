Imports Nancy.Json
Public Class qgateSelectPart
    Dim status As Boolean = False
    Dim md As New ModelVB
    Dim user As String
    Dim partno As String
    Dim dmccheck As String
    Dim Locationpart As String
    Dim partname As String


    Private Sub qgateSelectPart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getpart()
        Timer1.Enabled = True
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        lbUserName.Text = Module1.num_user(0)
    End Sub


    Private Sub pbCancelPart_Click(sender As Object, e As EventArgs) Handles pbCancelPart.Click
        qgateScanTag.Show()
        Me.Close()
    End Sub

    Private Sub pbConfirm_Click(sender As Object, e As EventArgs) Handles pbConfirm.Click
        getpartname(cbSelectPart.Text)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub
    Public Function checkLogin()
        user = Module1.get_data_login()
        Dim rsCheckUser = md.insert_log_part(cbSelectPart.Text, user)
    End Function

    Public Function infoselectpart()
        Dim part
        Dim partcount = 1
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim rsGetPartInfo = md.get_Info_part(cbSelectPart.Text, Label1.Text)
            Try
                If rsGetPartInfo <> "0" Then
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsGetPartInfo)
                    For Each item As Object In dict2
                        part = item("isp_count").ToString
                    Next
                    part = part + 1
                    partcount = partcount + 1
                    Dim insertPartInfo = md.update_info_part(cbSelectPart.Text, part, user, Label1.Text)
                    status = False
                Else
                    Dim insertPartInfo = md.insert_info_part(cbSelectPart.Text, partcount, user)
                    status = True
                End If
                Return status

            Catch ex As Exception
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function getpart()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then

            Dim rsGetPartNo = md.get_DataPart()
            Try
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsGetPartNo)
                If rsGetPartNo <> "0" Then
                    status = True
                    For Each item As Object In dict2
                        Dim modelpart = item("msp_part_no").ToString
                        cbSelectPart.Items.Add(modelpart)
                    Next
                Else
                    status = False
                End If
                Return status
            Catch ex As Exception
                MsgBox("ไม่มี Part No")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function getpartname(part As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            If part <> "" Then
                Dim rsGetPartName = md.get_DataPartName(part)
                Try
                    If rsGetPartName <> "0" Then
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsGetPartName)
                        For Each item As Object In dict2
                            Dim modelpart = item("msp_part_name").ToString
                            Dim modelpartno = item("msp_part_no").ToString
                            Module1.getpartname = modelpart
                            Module1.qgate_part_select = Trim(modelpart)
                            Module1.qgate_part_no = Trim(modelpartno)
                        Next
                        checkPartTag(Module1.qgate_part_no)
                        checkLogin()
                        infoselectpart()
                        qgateScanTag.Show()
                        md.update_Config_Select_Part(Trim(cbSelectPart.SelectedItem), Trim(Macaddress))
                        status = True
                        Me.Close()
                    Else
                        status = False
                    End If
                Catch ex As Exception
                    MsgBox("ไม่มี Part No")
                End Try
            Else
                MsgBox("Please Select PART")
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function checkPartTag(PartNoSub As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim rsCheckUser = md.get_PartTagFA((PartNoSub))
            Try
                If rsCheckUser <> "0" Then
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                    For Each item As Object In dict2
                        partno = item("mpn_part_no").ToString
                        dmccheck = item("mpn_dmc_check").ToString
                        Locationpart = item("mpn_location").ToString
                        partname = item("msp_part_name").ToString
                    Next
                    Module1.dmcqrscan = dmccheck
                    Module1.Locationpart = Locationpart
                    Module1.partnamedigit = partname
                End If
            Catch ex As Exception
                MsgBox("ไม่มีข้อมูลของแท็กนี้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
End Class