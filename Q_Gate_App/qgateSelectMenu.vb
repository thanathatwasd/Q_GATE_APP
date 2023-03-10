Imports Nancy.Json
Imports System.IO
Imports System.Net
Imports System.Threading
Public Class qgateSelectMenu
    Dim md As New ModelVB
    Dim tclient As New WebClient
    Dim datetime1 As String
    Dim menuname
    Dim menupic
    Dim staffname
    Dim staffpic
    Dim picIconMenu
    Dim staffper
    Dim i As Integer = 0
    Dim locationX = 439
    Dim locationY = 150
    Dim hightpanel As Integer = 0
    Dim selectpicbox As Integer
    Dim locationUserX = 39
    Dim locationUserY = 3
    Dim num As Integer = 1
    Dim menustart = ""
    Dim menureprint = ""
    Dim menusorting = ""
    Dim round As Integer = 1
    Dim lotdate As String
    Sub Main()
        Dim trd As New Thread(AddressOf ThreadTask)
        trd.IsBackground = False
        trd.Start()
    End Sub
    Sub ThreadTask()
        Console.WriteLine("This message from a thread")
    End Sub
    Public Sub loadMenu(picIconMenu, pathPicName, picName)
        Dim url As String = "http://192.168.161.77/" & pathPicName & "/" & picName
        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tclient.DownloadData(url)))
        Dim picture = New PictureBox With {
        .Name = picIconMenu,
        .Size = New Size(351, 112),
        .BackColor = Color.Transparent,
        .Location = New Point(locationX, locationY),
        .Image = tImage
   }
        If picIconMenu = "start" Then
            locationY += 120
            AddHandler picture.Click, AddressOf PictureBox1_Click
            Me.Controls.Add(picture)
        ElseIf picIconMenu = "reprint" Then
            locationY += 120
            AddHandler picture.Click, AddressOf PictureBox2_Click
            Me.Controls.Add(picture)
        ElseIf picIconMenu = "sorting" Then
            locationY += 120
            AddHandler picture.Click, AddressOf PictureBox3_Click
            Me.Controls.Add(picture)
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        user = ""
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            shift = md.get_WorkShoftTime(DateTime.Now.ToString("HH:mm:ss"))
            Dim dict8 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(shift)
            For Each item As Object In dict8
                workshift = item("mws_shift").ToString
            Next
            workdate = DateTime.Now.ToString("yyyy-MM-dd")
            Dim checkDuringtime = md.get_During_Time(Trim(configposition), Trim(workdate), Trim(workshift))
            user &= Module1.num_user(0)
            If Module1.num_user(1) <> "" Then
                user &= "," & Module1.num_user(1)
            End If
            If Module1.num_user(2) <> "" Then
                user &= "," & Module1.num_user(2)
            End If
            If Module1.num_user(3) <> "" Then
                user &= "," & Module1.num_user(3)
            End If
            If Module1.num_user(4) <> "" Then
                user &= "," & Module1.num_user(4)
            End If
            If type = "1" Then
                If checkDuringtime = "0" Then
                    md.insert_during_time(configposition, workshift, workdate, Module1.num_user(0))
                    insertWorkerDuringTime()
                    updateDuringTime(lotdate, Module1.num_user(0), Trim(configposition), Trim(workdate), Trim(workshift))
                    qgateScanTag.Show()
                    Me.Hide()
                End If
            ElseIf type = "2" Then
                If checkDuringtime = "0" Then
                    md.insert_during_time(configposition, workshift, workdate, Module1.num_user(0))
                    insertWorkerDuringTime()
                    updateDuringTime(lotdate, Module1.num_user(0), Trim(configposition), Trim(workdate), Trim(workshift))
                    qgateScanTag.Show()
                    Me.Hide()
                End If
            ElseIf type = "3" Then
                If checkDuringtime = "0" Then
                    md.insert_during_time(configposition, workshift, workdate, Module1.num_user(0))
                    insertWorkerDuringTime()
                    updateDuringTime(lotdate, Module1.num_user(0), Trim(configposition), Trim(workdate), Trim(workshift))
                    qgateMenuStart.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Please Select Position")
            End If
        Else
            MsgBox("Waiting Internet")
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        user = ""
        qgateprintTag.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        MsgBox("Page not found")
    End Sub
    Public Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            lotdate = md.get_Lotcur(DateTime.Now.ToString("yyyy-MM-dd"))
            Timer1.Enabled = True
            lbZone.Text = zoneset
            lbStation.Text = setstationid
            hidepicandname()
            lbZone.Select()
            datetime1 = qgateLogin.Label1.Text
            Label1.Text = qgateLogin.Label2.Text
            checkLogin(Label1.Text)
            getmenu(staffname)
        Else
            MsgBox("Waiting Internet")
        End If
    End Sub
    Private Sub pblogout_Click(sender As Object, e As EventArgs) Handles pblogout.Click
        logoutUser()
    End Sub
    Public Function logoutUser()
        If Module1.ctUser >= 1 Then
            Dim a As String = Module1.qgate_date_user1
            updateactive(Module1.staffid, Module1.qgate_date_user1)
            updateactive(Module1.staffid2, Module1.qgate_date_user2)
            updateactive(Module1.staffid3, Module1.qgate_date_user3)
            updateactive(Module1.staffid4, Module1.qgate_date_user4)
            updateactive(Module1.staffid5, Module1.qgate_date_user5)
            Module1.ctUser = 0
            Module1.num_user(0) = ""
            Module1.num_user(1) = ""
            Module1.num_user(2) = ""
            Module1.num_user(3) = ""
            Module1.num_user(4) = ""
            qgateLogin.Show()
            Me.Close()
        End If
    End Function
    Private Sub pbreprint_Click(sender As Object, e As EventArgs)
        qgateprintTag.Show()
        Me.Hide()
    End Sub
    Public Function updateactive(staff As String, datetime1 As String)
        Dim md As New ModelVB
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim rsCheckUser = md.update_active_logout(staff, datetime1)
            Dim status As Boolean = False
            If rsCheckUser <> "0" Then
                status = True
            Else
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function getmenu(name As String)
        Dim md As New ModelVB
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim rsCheckUser = md.get_DataMenu(name)
            Dim status As Boolean = False
            If rsCheckUser <> "0" Then
                status = True
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsCheckUser)
                i = 0
                For Each item As Object In dict2
                    loadMenu(item("sm_menu").ToString, item("sm_path").ToString, item("sm_pic").ToString)
                    i += 1
                Next
            Else
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If

    End Function
    Public Function checkLogin(infostaff As String)
        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(infostaff)
        For Each item As Object In dict2
            Module1.staffid = item("ss_id").ToString
            staffname = item("ss_emp_code").ToString
            staffper = item("ss_emp_name").ToString
        Next
    End Function
    Private Sub pbAddUser_Click(sender As Object, e As EventArgs) Handles pbAddUser.Click
        qgateAddUser.Show()
    End Sub
    Private Sub pbDeleteUser_Click(sender As Object, e As EventArgs) Handles pbDeleteUser.Click
        If Module1.ctUser = 1 Then
            MsgBox("Can't Delete")
        Else
            qgateconfirmLogout.Show()
        End If
    End Sub

    Public Function updateDuringTime(lotdate As String, staffname As String, stationid As String, workdate As String, workshift As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim updateduring = md.update_during_time(lotdate, staffname, stationid, workdate, workshift)
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function insertWorkerDuringTime()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim getDuringtime = md.get_During_Time(Trim(configposition), Trim(workdate), Trim(workshift))
            If getDuringtime <> "0" Then
                Dim dict11 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getDuringtime)
                For Each item As Object In dict11
                    duringtimeid = item("isdt_id").ToString
                Next
                If Module1.num_user(0) <> "" Then
                    md.insert_staff_worker(duringtimeid, Module1.num_user(0))
                End If
                If Module1.num_user(1) <> "" Then
                    md.insert_staff_worker(duringtimeid, Module1.num_user(1))
                End If
                If Module1.num_user(2) <> "" Then
                    md.insert_staff_worker(duringtimeid, Module1.num_user(2))
                End If
                If Module1.num_user(3) <> "" Then
                    md.insert_staff_worker(duringtimeid, Module1.num_user(3))
                End If
                If Module1.num_user(4) <> "" Then
                    md.insert_staff_worker(duringtimeid, Module1.num_user(4))
                End If
            Else
                MsgBox("Error")
            End If
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
End Class