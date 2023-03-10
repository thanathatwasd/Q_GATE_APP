Imports Nancy.Json
Public Class qgateLoginAdmin
    Dim md As New ModelVB
    Dim status As Boolean = False
    Dim staffid
    Dim permissionid
    Dim rsCheckUser

    Private Sub tbLoginAdmin1_KeyDown(sender As Object, e As KeyEventArgs) Handles tbLoginAdmin1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If checkLoginAdmin(tbLoginAdmin1.Text) Then
                qgateMenuAdmin.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBackToLogin1_Click(sender As Object, e As EventArgs) Handles pbBackToLogin1.Click
        qgateLogin.Show()
        Me.Close()
    End Sub
    Public Function checkLoginAdmin(empCard As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            rsCheckUser = md.get_DataUser((empCard))
            Try
                If rsCheckUser <> "0" Then
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                    For Each item As Object In dict2
                        staffid = item("ss_id").ToString
                        permissionid = item("spg_id").ToString
                        If permissionid = 1 Then
                            adminconfig = empCard
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
            MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
    End Sub

    Private Sub qgateLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
    End Sub
    Private Sub tbLoginAdmin1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbLoginAdmin1.KeyPress
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