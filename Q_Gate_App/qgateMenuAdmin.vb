Imports Nancy.Json
Public Class qgateMenuAdmin
    Dim md As New ModelVB
    Dim datetime As String
    Dim adminid
    Dim staffid

    Private Sub qgateMenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetime = qgateLoginAdmin.Label2.Text
    End Sub

    Private Sub pbLogout_Click(sender As Object, e As EventArgs) Handles pbLogout.Click
        checkLogin()
        updateactive(staffid, datetime)
        qgateLoginAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub pbSetStation_Click(sender As Object, e As EventArgs) Handles pbSetStation.Click
        qgateSettingPosition.Show()
        Me.Hide()
    End Sub

    Public Function updateactive(staff As String, datetime1 As String)
        Dim md As New ModelVB
        Dim rsCheckUser = md.update_active_logout(staff, datetime1)
        Dim status As Boolean = False

        If rsCheckUser <> "0" Then
            status = True
        Else
            status = False
        End If
        Return status

    End Function
    Public Function checkLogin()

        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Label1.Text)
        For Each item As Object In dict2
            staffid = item("ss_id").ToString

        Next
    End Function


End Class