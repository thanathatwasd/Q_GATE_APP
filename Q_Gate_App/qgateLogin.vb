Imports Nancy.Json
Public Class qgateLogin
    Dim md As New ModelVB
    Dim status As Boolean = False

    Dim staffname
    Dim staffcode
    Dim Macaddress
    Private Sub qgateLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        md.get_LocalHost()
        Dim ping = md.get_DatabaseServer()


    End Sub
    Private Sub tbemcard_KeyDown(sender As Object, e As KeyEventArgs) Handles tbLoginUser.KeyDown


        If e.KeyCode = Keys.Enter Then
            If My.Computer.Network.Ping("192.168.161.101") Then


                Macaddress = md.get_Mac_Address(getMacAddress)

                If Macaddress <> "0" Then
                    If checkLogin(tbLoginUser.Text) Then

                        qgateSelectMenu.Show()
                        Dim ctuser As Integer = 1
                        Module1.set_ctUser(ctuser)
                        tbLoginUser.Text = ""
                        Me.Hide()

                    Else
                        MsgBox("Login Fail")
                        tbLoginUser.Text = ""
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


        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Macaddress)
        For Each item As Object In dict2
            setphaseid = item("mpa_id").ToString
            setzoneid = item("mza_id").ToString
            setstationid = item("msa_id").ToString


        Next

        getTypeByPosition(setphaseid, setzoneid, setstationid)
        MsgBox(type)
        Dim zone = md.get_Zone_Set_menu(setzoneid)


        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(zone)
        For Each item As Object In dict3
            zoneset = item("mza_name").ToString

        Next




    End Function
    Public Function checkLogin(empCard As String)
        checkPosition()
        Dim rsCheckUser = md.get_DataUser(empCard)
        'MsgBox("rsCheckUser ==> " & rsCheckUser)
        Try
            If rsCheckUser <> "0" Then
                'MsgBox("2222")
                Label2.Text = rsCheckUser
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                For Each item As Object In dict2
                    staffid = item("ss_id").ToString
                    staffname = item("ss_emp_name").ToString
                    staffcode = item("ss_emp_code").ToString
                    userpermi(0) = item("spg_id").ToString

                    Dim activelogin = md.insert_active_login(staffid)
                Next
                Module1.set_data_login(staffname)
                Module1.set_date_user1(Label1.Text)

                Module1.userpack(1)
                num_user(0) = tbLoginUser.Text
                Module1.qgate_date_user1 = Label1.Text
                'MsgBox("Module1.qgate_date_user1=-==> " & Module1.qgate_date_user1)
                qgateSelectMenu.lbstaffno1.Text = staffname
                qgateSelectMenu.lbuseremp1.Text = staffcode
                Module1.ctUser = ctUser + 1
                status = True
                'MsgBox("status==> " & status)
            Else
                status = False
            End If

        Catch ex As Exception
        End Try

        Return status
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

        Dim rs1 = md.get_TypeByPosition(SelectPhase, SelectZone, cbSelectStation)


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
    End Function

    Private Sub tbLoginUser_TextChanged(sender As Object, e As EventArgs) Handles tbLoginUser.TextChanged

    End Sub
End Class
