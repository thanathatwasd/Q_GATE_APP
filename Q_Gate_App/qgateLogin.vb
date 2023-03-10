Imports System.Globalization
Imports Nancy.Json
Public Class qgateLogin
    Dim md As New ModelVB
    Dim status As Boolean = False

    Dim staffname
    Dim staffcode
    Dim Macadd
    Dim partno As String
    Dim dmccheck As String
    Dim Locationpart As String
    Dim partname As String
    Private Sub qgateLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        md.get_LocalHost()
        Dim ping = md.get_DatabaseServer()
    End Sub
    Private Sub tbemcard_KeyDown(sender As Object, e As KeyEventArgs) Handles tbLoginUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
                If Macaddress <> "0" Then
                    If checkPosition() Then
                        Module1.timenow = (DateTime.Now.ToString("yyyy-MM-dd"))
                        qgateSelectMenu.Show()
                        Dim ctuser As Integer = 1
                        Module1.set_ctUser(ctuser)
                        tbLoginUser.Text = ""
                        Me.Hide()

                    End If
                Else
                    MsgBox("กรุณาติดต่อเจ้าหน้าที่")

                End If
            Else
                MsgBox("Waiting Internet")
            End If
        End If
    End Sub
    Public Function checkPosition()
        Dim mac = getMacAddress()
        Try
            If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
                Macadd = md.get_Mac_Address(mac)

                If Macadd <> "0" Then
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Macadd)
                    For Each item As Object In dict2
                        Module1.setphaseid = item("mpa_id").ToString
                        Module1.setzoneid = item("mza_id").ToString
                        Module1.setstationid = item("msa_id").ToString
                        Module1.Macaddress = item("mcd_mac_address").ToString
                        Module1.qgate_part_no = item("mcd_select_part").ToString
                        If Module1.qgate_part_no = "0" Then
                            Module1.qgate_part_no = ""
                        Else
                            Module1.qgate_part_no = Module1.qgate_part_no
                        End If
                    Next
                    checkPartTag(Module1.qgate_part_no)
                    getTypeByPosition(setphaseid, setzoneid, setstationid)
                    Dim zone = md.get_Zone_Set_menu(setzoneid)
                    Dim dict4 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(zone)
                    For Each item As Object In dict4
                        zoneset = item("mza_name").ToString
                    Next
                    checkLogin(tbLoginUser.Text)
                    Return status = True
                Else
                    tbLoginUser.Text = ""
                    MsgBox("Please Select Position By Admin")
                End If

            Else
                tbLoginUser.Text = ""
                MsgBox("Waiting Internet")
            End If
        Catch ex As Exception
            tbLoginUser.Text = ""
            MsgBox("NO MAC ADDRESS =>" & mac)
        Return status = False

        End Try
        Return status
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
                MsgBox("ไม่พบ Part no นี้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function checkLogin(empCard As String)

        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim rsCheckUser = md.get_DataUser(empCard)
            Try
                If rsCheckUser <> "0" And Macadd <> "0" Then
                    Label2.Text = rsCheckUser
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                    For Each item As Object In dict2
                        Module1.staffid = item("ss_id").ToString
                        staffname = item("ss_emp_name").ToString
                        staffcode = item("ss_emp_code").ToString
                        Module1.userpermi(0) = item("spg_id").ToString
                        Dim activelogin = md.insert_active_login(staffid)
                    Next
                    Module1.set_data_login(staffname)
                    Module1.set_date_user1(Label1.Text)
                    Module1.userpack(1)
                    Module1.num_user(0) = tbLoginUser.Text
                    Module1.qgate_date_user1 = Label1.Text
                    qgateSelectMenu.lbstaffno1.Text = staffname
                    qgateSelectMenu.lbuseremp1.Text = staffcode
                    Module1.ctUser = Module1.ctUser + 1
                    status = True
                Else
                    MsgBox("รหัสพนักงงานผิด")
                    tbLoginUser.Text = ""
                    status = False
                End If
            Catch ex As Exception
                MsgBox("ไม่พบผู้ใช้งาน")
            End Try
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub pbConfig_Click(sender As Object, e As EventArgs) Handles pbConfig.Click
        tbLoginUser.Text = ""
        qgateLoginAdmin.Show()
        Me.Hide()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Me.Close()
    End Sub
    Public Function getTypeByPosition(SelectPhase, SelectZone, cbSelectStation)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim rs1 = md.get_TypeByPosition(SelectPhase, SelectZone, cbSelectStation)
            Try
                If rs1 <> "0" Then
                    status = True
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs1)
                    For Each item As Object In dict2
                        type = item("mct_id").ToString
                        configposition = item("mcd_id").ToString
                        Module1.phaseplant = item("mpa_phase_plant").ToString
                        Module1.timetocheckqr = item("mcd_inspection_time").ToString

                    Next
                Else
                    status = False
                End If
                Return status
            Catch ex As Exception
                MsgBox("ไม่พบตำแหน่งที่เลือก")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub tbLoginUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbLoginUser.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class
