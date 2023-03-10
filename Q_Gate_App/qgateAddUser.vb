Imports Nancy.Json
Public Class qgateAddUser
    Dim status As Boolean = False
    Dim staffname
    Dim staffcode
    Dim datetime1 As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If tbAddUser.Text = "" Then
            MsgBox("กรุณาเพิ่มชื่อพนักงาน")
        Else
            qgateSelectMenu.Show()
            Me.Close()
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        qgateSelectMenu.Show()
        Me.Close()
    End Sub
    Private Sub qgateAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          Timer1.Enabled = True
        datetime1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
    End Sub
    Public Function checkuser(empcode As String)
        Dim md As New ModelVB
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim rsCheckUser = md.get_DataUser((empcode))
            Try
                If rsCheckUser <> "0" Then
                    If Trim(qgateSelectMenu.lbstaffno2.Text) = "" Then
                        For i = 0 To 4 Step 1
                            If Module1.num_user(i) = tbAddUser.Text Then
                                MsgBox("ซ้ำ")
                                tbAddUser.Text = ""
                                Exit Try
                            End If
                        Next
                        If Trim(empcode) <> "" Then
                            Module1.num_user(1) = tbAddUser.Text
                            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                            For Each item As Object In dict2
                                Module1.staffid2 = item("ss_id").ToString
                                staffname = item("ss_emp_name").ToString
                                staffcode = item("ss_emp_code").ToString
                                Module1.userpermi(1) = item("spg_id").ToString
                                Module1.qgate_date_user2 = datetime1
                                Dim activelogin = md.insert_active_login(Module1.staffid2)
                            Next
                            Module1.addUser()
                            Module1.ctUser = Module1.ctUser + 1
                            Module1.userpack(2)
                            Module1.num_user_code(1) = staffcode
                            qgateSelectMenu.lbuseremp2.Text = Module1.num_user_code(1)
                            qgateSelectMenu.lbstaffno2.Text = staffname
                            qgateSelectMenu.lbstaffno2.Show()
                            qgateSelectMenu.lbuseremp2.Show()
                            qgateSelectMenu.pnuser2.Show()
                            status = True
                            Me.Close()
                        End If
                    ElseIf Trim(qgateSelectMenu.lbstaffno3.Text) = "" Then
                        For i = 0 To 4 Step 1
                            If Module1.num_user(i) = tbAddUser.Text Then
                                MsgBox("ซ้ำ")
                                tbAddUser.Text = ""
                                Exit Try
                            End If
                        Next
                        If Trim(empcode) <> "" Then
                            Module1.num_user(2) = tbAddUser.Text
                            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                            For Each item As Object In dict2
                                Module1.staffid3 = item("ss_id").ToString
                                staffname = item("ss_emp_name").ToString
                                staffcode = item("ss_emp_code").ToString
                                Module1.userpermi(2) = item("spg_id").ToString
                                Module1.qgate_date_user3 = datetime1
                                Dim activelogin = md.insert_active_login(Module1.staffid3)
                            Next
                            Module1.ctUser = Module1.ctUser + 1
                            Module1.addUser()
                            Module1.userpack(3)
                            Module1.num_user_code(2) = staffcode
                            qgateSelectMenu.lbuseremp3.Text = Module1.num_user_code(2)
                            qgateSelectMenu.lbstaffno3.Text = staffname
                            qgateSelectMenu.lbuseremp3.Show()
                            qgateSelectMenu.lbstaffno3.Show()
                            qgateSelectMenu.pnuser3.Show()
                            status = True
                            Me.Close()
                        End If
                    ElseIf Trim(qgateSelectMenu.lbstaffno4.Text) = "" Then
                        For i = 0 To 4 Step 1
                            If Module1.num_user(i) = tbAddUser.Text Then
                                MsgBox("ซ้ำ")
                                tbAddUser.Text = ""
                                Exit Try
                            End If
                        Next
                        If Trim(empcode) <> "" Then
                            Module1.num_user(3) = tbAddUser.Text
                            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                            For Each item As Object In dict2
                                Module1.staffid4 = item("ss_id").ToString
                                staffname = item("ss_emp_name").ToString
                                staffcode = item("ss_emp_code").ToString
                                Module1.userpermi(3) = item("spg_id").ToString
                                Module1.qgate_date_user4 = datetime1
                                Dim activelogin = md.insert_active_login(Module1.staffid4)
                            Next
                            Module1.addUser()
                            Module1.ctUser = Module1.ctUser + 1
                            Module1.userpack(4)
                            Module1.num_user_code(3) = staffcode
                            qgateSelectMenu.lbuseremp4.Text = Module1.num_user_code(3)
                            qgateSelectMenu.lbstaffno4.Text = staffname
                            qgateSelectMenu.lbuseremp4.Show()
                            qgateSelectMenu.lbstaffno4.Show()
                            qgateSelectMenu.pnuser4.Show()
                            status = True
                            Me.Close()
                        End If

                    ElseIf Trim(qgateSelectMenu.lbstaffno5.Text) = "" Then
                        For i = 0 To 4 Step 1
                            If Module1.num_user(i) = tbAddUser.Text Then
                                MsgBox("ซ้ำ")
                                tbAddUser.Text = ""
                                Exit Try
                            End If
                        Next
                        If Trim(empcode) <> "" Then
                            Module1.num_user(4) = tbAddUser.Text


                            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                            For Each item As Object In dict2
                                Module1.staffid5 = item("ss_id").ToString
                                staffname = item("ss_emp_name").ToString
                                staffcode = item("ss_emp_code").ToString
                                Module1.userpermi(4) = item("spg_id").ToString
                                Module1.qgate_date_user5 = datetime1
                                Dim activelogin = md.insert_active_login(Module1.staffid5)

                            Next
                            Module1.addUser()
                            Module1.ctUser = Module1.ctUser + 1
                            Module1.userpack(5)
                            Module1.num_user_code(4) = staffcode
                            qgateSelectMenu.lbuseremp5.Text = Module1.num_user_code(4)
                            qgateSelectMenu.lbstaffno5.Text = staffname
                            qgateSelectMenu.lbuseremp4.Show()
                            qgateSelectMenu.lbstaffno5.Show()
                            qgateSelectMenu.pnuser5.Show()
                            status = True
                            Me.Close()
                        End If
                    Else
                        MsgBox("User ในระบบเต็มแล้ว")
                        tbAddUser.Text = ""
                    End If
                Else
                    MsgBox("Login Fail")
                    tbAddUser.Text = ""
                    status = False
                End If
                Return status
            Catch ex As Exception
                MsgBox("Login Fail")
                tbAddUser.Text = ""
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub tbAddUser_KeyDown(sender As Object, e As KeyEventArgs) Handles tbAddUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkuser(tbAddUser.Text) Then
            End If
        End If
    End Sub
    Public Function checkdata(empcode As String)
        Dim md As New ModelVB
        Dim rsCheckUser = md.get_DataUser((empcode))
        Try
            If rsCheckUser <> "0" Then
                status = True
            Else
                status = False
            End If
            Return status
        Catch ex As Exception

        End Try

    End Function


End Class