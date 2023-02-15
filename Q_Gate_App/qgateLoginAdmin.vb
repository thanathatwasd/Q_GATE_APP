Imports Nancy.Json
Public Class qgateLoginAdmin
    Dim md As New ModelVB
    Dim status As Boolean = False
    Dim staffid
    Dim permissionid
    Dim rsCheckUser

    Private Sub tbLoginAdmin_KeyDown(sender As Object, e As KeyEventArgs) Handles tbLoginAdmin.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkLoginAdmin(tbLoginAdmin.Text) Then
                qgateMenuAdmin.Show()
                Me.Close()


            End If
        End If
    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles pbBackToLogin.Click
        qgateLogin.Show()
        Me.Close()
    End Sub
    Public Function checkLoginAdmin(empCard As String)
        rsCheckUser = md.get_DataUser((empCard))
        Try
            If rsCheckUser <> "0" Then

                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                For Each item As Object In dict2
                    staffid = item("ss_id").ToString
                    permissionid = item("spg_id").ToString
                    If permissionid = 1 Then

                        qgateMenuAdmin.Label1.Text = rsCheckUser
                        Dim activelogin = md.insert_active_login(empCard)
                        status = True
                    Else
                        MsgBox("Your Permission is not Allow")
                        tbLoginAdmin.Text = ""
                        status = False
                    End If
                Next
            Else
                MsgBox("Login Fail")
                tbLoginAdmin.Text = ""
                status = False
            End If

        Catch ex As Exception
            status = False
            MsgBox("LOGIN FAIL")
            tbLoginAdmin.Text = ""
        End Try
        Return status
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
    End Sub

    Private Sub qgateLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class