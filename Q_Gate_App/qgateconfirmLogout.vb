Public Class qgateconfirmLogout
    Dim md As New ModelVB

    Dim chooseuserdelete1 As String = ""
    Private Sub confirmLogout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnConfirm.Select()
        getusertocombobox()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If ComboBox1.Text = "" Then
            MsgBox("Please Select User for Delete")
        Else
            'MsgBox("ComboBox1.SelectedIndex===> " & ComboBox1.SelectedIndex)
            chooseuserdelete1 = ComboBox1.SelectedIndex

            logoutUser(chooseuserdelete1)


            Me.Close()

        End If

    End Sub

    Public Function getusertocombobox()
        If Module1.num_user(0) <> "" Then
            ComboBox1.Items.Add(num_user(0))
        End If
        If Module1.num_user(1) <> "" Then
            ComboBox1.Items.Add(num_user(1))
        End If
        If Module1.num_user(2) <> "" Then
            ComboBox1.Items.Add(num_user(2))
        End If
        If Module1.num_user(3) <> "" Then
            ComboBox1.Items.Add(num_user(3))
        End If
        If Module1.num_user(4) <> "" Then
            ComboBox1.Items.Add(num_user(4))
        End If
    End Function

    Public Function logoutUser(chooseuserdelete As String)

        If chooseuserdelete = 0 Then
            'MsgBox(qgateSelectMenu.lbstaffno1.Text)
            ' MsgBox("staffid1" & staffid)
            ' MsgBox("user1" & qgate_date_user1)
            Dim upatelogout = md.update_active_logout(staffid, qgate_date_user1)

            Module1.num_user(0) = ""
            Module1.num_user_code(0) = ""
            Module1.user1 = ""
            Module1.ctUser = ctUser - 1
            Module1.userpermi(0) = ""
        ElseIf chooseuserdelete = 1 Then
            'MsgBox(qgateSelectMenu.lbstaffno2.Text)

            'MsgBox("staffid2" & staffid2)
            'MsgBox("user2" & qgate_date_user2)
            Dim upatelogout = md.update_active_logout(staffid2, qgate_date_user2)
            Module1.num_user(1) = ""
            Module1.num_user_code(1) = ""
            Module1.user2 = ""
            Module1.ctUser = ctUser - 1
            Module1.userpermi(1) = ""
        ElseIf chooseuserdelete = 2 Then

            'MsgBox(qgateSelectMenu.lbstaffno3.Text)

            'MsgBox("staffid3" & staffid3)
            'MsgBox("user3" & qgate_date_user3)
            Dim upatelogout = md.update_active_logout(staffid3, qgate_date_user3)
            Module1.num_user(2) = ""

            Module1.num_user_code(2) = ""
            Module1.user3 = ""
            Module1.ctUser = ctUser - 1
            Module1.userpermi(2) = ""
        ElseIf chooseuserdelete = 3 Then
            'MsgBox(qgateSelectMenu.lbstaffno4.Text)

            'MsgBox("staffid4" & staffid4)
            'MsgBox("user4" & qgate_date_user4)
            Dim upatelogout = md.update_active_logout(staffid4, qgate_date_user4)
            Module1.num_user(3) = ""
            Module1.num_user_code(3) = ""
            Module1.user4 = ""
            Module1.ctUser = ctUser - 1

            Module1.userpermi(3) = ""
        ElseIf chooseuserdelete = 4 Then
            'MsgBox(qgateSelectMenu.lbstaffno5.Text)

            'MsgBox("staffid5" & staffid5)
            'MsgBox("user5" & qgate_date_user5)
            Dim upatelogout = md.update_active_logout(staffid5, qgate_date_user5)
            Module1.num_user(4) = ""
            Module1.num_user_code(4) = ""
            Module1.user5 = ""
            Module1.ctUser = ctUser - 1
            Module1.userpermi(4) = ""
        Else
            MsgBox("Please Select User ")
        End If
        Module1.MoveUser()
        Me.Close()
    End Function


End Class