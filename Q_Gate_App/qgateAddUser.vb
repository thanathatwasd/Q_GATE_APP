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
    Public Function checkuser1(empcode As String)
        Dim md As New ModelVB
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
                        num_user(1) = tbAddUser.Text

                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                        For Each item As Object In dict2
                            staffid2 = item("ss_id").ToString
                            staffname = item("ss_emp_name").ToString
                            staffcode = item("ss_emp_code").ToString
                            userpermi(1) = item("spg_id").ToString
                            Module1.qgate_date_user2 = datetime1
                            Dim activelogin = md.insert_active_login(staffid2)
                        Next
                        Module1.addUser()
                        Module1.ctUser = ctUser + 1
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
                        num_user(2) = tbAddUser.Text
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                        For Each item As Object In dict2
                            staffid3 = item("ss_id").ToString
                            staffname = item("ss_emp_name").ToString
                            staffcode = item("ss_emp_code").ToString
                            userpermi(2) = item("spg_id").ToString
                            Module1.qgate_date_user3 = datetime1
                            Dim activelogin = md.insert_active_login(staffid3)

                        Next
                        Module1.ctUser = ctUser + 1
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
                        num_user(3) = tbAddUser.Text
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                        For Each item As Object In dict2
                            staffid4 = item("ss_id").ToString
                            staffname = item("ss_emp_name").ToString
                            staffcode = item("ss_emp_code").ToString
                            userpermi(3) = item("spg_id").ToString
                            Module1.qgate_date_user4 = datetime1
                            Dim activelogin = md.insert_active_login(staffid4)
                        Next
                        Module1.addUser()
                        Module1.ctUser = ctUser + 1
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
                        num_user(4) = tbAddUser.Text


                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                        For Each item As Object In dict2
                            staffid5 = item("ss_id").ToString
                            staffname = item("ss_emp_name").ToString
                            staffcode = item("ss_emp_code").ToString
                            userpermi(4) = item("spg_id").ToString
                            Module1.qgate_date_user5 = datetime1
                            Dim activelogin = md.insert_active_login(staffid5)

                        Next
                        Module1.addUser()
                        Module1.ctUser = ctUser + 1
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
        End Try
    End Function

    Private Sub tbAddUser_KeyDown(sender As Object, e As KeyEventArgs) Handles tbAddUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkuser1(tbAddUser.Text) Then
            End If
        End If
    End Sub





























    'Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles tbAddUser.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If checkdata(tbAddUser.Text) Then
    '            If Module1.ctUser = 1 Then
    '                If checkuser1(tbAddUser.Text) Then
    '                    Module1.set_data_login_date2(tbAddUser.Text)
    '                    qgateSelectMenu.Show()
    '                    tbAddUser.Text = ""
    '                    qgateSelectMenu.pbuser2.Show()
    '                    qgateSelectMenu.lbstaffno2.Show()
    '                    Module1.ctUser = ctUser + 1
    '                    MsgBox(Module1.ctUser)
    '                End If
    '            ElseIf Module1.ctUser = 2 Then
    '                If checkuser2(tbAddUser.Text) Then
    '                    Module1.set_data_login_date3(tbAddUser.Text)
    '                    qgateSelectMenu.Show()
    '                    tbAddUser.Text = ""
    '                    qgateSelectMenu.pbuser3.Show()
    '                    qgateSelectMenu.lbstaffno3.Show()
    '                    Module1.ctUser = ctUser + 1
    '                    MsgBox(Module1.ctUser)
    '                End If
    '            ElseIf Module1.ctUser = 3 Then
    '                If checkuser3(tbAddUser.Text) Then
    '                    Module1.set_data_login_date4(tbAddUser.Text)
    '                    qgateSelectMenu.Show()
    '                    tbAddUser.Text = ""
    '                    qgateSelectMenu.pbuser4.Show()
    '                    qgateSelectMenu.lbstaffno4.Show()
    '                    Module1.ctUser = ctUser + 1
    '                    MsgBox(Module1.ctUser)
    '                End If
    '            ElseIf Module1.ctUser = 4 Then
    '                If checkuser4(tbAddUser.Text) Then
    '                    Module1.set_data_login_date5(tbAddUser.Text)
    '                    qgateSelectMenu.Show()
    '                    tbAddUser.Text = ""
    '                    qgateSelectMenu.pbuser5.Show()
    '                    qgateSelectMenu.lbstaffno5.Show()
    '                    Module1.ctUser = ctUser + 1
    '                    MsgBox(Module1.ctUser)
    '                End If

    '            Else
    '                MsgBox("User is Maximum")
    '                tbAddUser.Text = ""
    '            End If
    '        Else
    '            MsgBox("Login Fail")
    '            tbAddUser.Text = ""
    '        End If

    '    End If
    'End Sub



    'Public Function checkuser1(empcode As String)
    '    Dim md As New ModelVB
    '    Dim rsCheckUser = md.get_DataUser((empcode))
    '    Try
    '        If rsCheckUser <> "0" Then
    '            status = True
    '            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
    '            For Each item As Object In dict2
    '                staffid = item("ss_id").ToString
    '                staffname = item("ss_emp_name").ToString
    '                Dim activelogin = md.insert_active_login(staffid)
    '            Next

    '            Module1.set_data_login_user2(staffname)
    '            qgateSelectMenu.lbstaffno2.Text = Module1.get_data_login_user2

    '        Else
    '            MsgBox("Login Fail")
    '            tbAddUser.Text = ""
    '            status = False

    '        End If
    '        Return status
    '    Catch ex As Exception

    '    End Try

    'End Function

    'Public Function checkuser2(empcode As String)
    '    Dim md As New ModelVB
    '    Dim rsCheckUser = md.get_DataUser((empcode))
    '    Try
    '        If rsCheckUser <> "0" Then
    '            status = True
    '            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
    '            For Each item As Object In dict2
    '                staffid = item("ss_id").ToString
    '                staffname = item("ss_emp_name").ToString
    '                Dim activelogin = md.insert_active_login(staffid)
    '            Next

    '            Module1.set_data_login_user3(staffname)
    '            qgateSelectMenu.lbstaffno3.Text = Module1.get_data_login_user3

    '        Else
    '            MsgBox("Login Fail")
    '            tbAddUser.Text = ""
    '            status = False
    '        End If
    '        Return status
    '    Catch ex As Exception

    '    End Try

    'End Function

    'Public Function checkuser3(empcode As String)
    '    Dim md As New ModelVB
    '    Dim rsCheckUser = md.get_DataUser((empcode))

    '    Try
    '        If rsCheckUser <> "0" Then
    '            status = True
    '            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
    '            For Each item As Object In dict2
    '                staffid = item("ss_id").ToString
    '                staffname = item("ss_emp_name").ToString
    '                Dim activelogin = md.insert_active_login(staffid)
    '            Next

    '            Module1.set_data_login_user4(staffname)
    '            qgateSelectMenu.lbstaffno4.Text = Module1.get_data_login_user4




    '        Else
    '            MsgBox("Login Fail")
    '            tbAddUser.Text = ""
    '            status = False
    '        End If
    '        Return status
    '    Catch ex As Exception

    '    End Try

    'End Function
    'Public Function checkuser4(empcode As String)
    '    Dim md As New ModelVB
    '    Dim rsCheckUser = md.get_DataUser((empcode))

    '    Try
    '        If rsCheckUser <> "0" Then
    '            status = True
    '            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
    '            For Each item As Object In dict2
    '                staffid = item("ss_id").ToString
    '                staffname = item("ss_emp_name").ToString
    '                Dim activelogin = md.insert_active_login(staffid)
    '            Next


    '            Module1.set_data_login_user5(staffname)
    '            qgateSelectMenu.lbstaffno5.Text = Module1.get_data_login_user5
    '        Else
    '            MsgBox("Login Fail")
    '            tbAddUser.Text = ""
    '            status = False
    '        End If
    '        Return status
    '    Catch ex As Exception

    '    End Try

    'End Function

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