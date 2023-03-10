Imports System.Net.NetworkInformation
Module Module1
    Public qgate_phase As String = "NO_DATA"
    Public qgate_zone As String = "NO_DATA"
    Public qgate_station As String = "NO_DATA"
    Public qgate_data_login As String = "NO_DATA"
    Public qgate_part As String = "NO_DATA"
    Public qgate_part_name As String = "NO_DATA"
    Public qgate_part_no As String = ""
    Public qgate_type As String = "NO_DATA"
    Public qgate_ctUser As String = "NO_DATA"
    Public qgate_part_select As String = ""
    Public qgate_date_user1 As String = "NO_DATA"
    Public qgate_date_user2 As String = "NO_DATA"
    Public qgate_date_user3 As String = "NO_DATA"
    Public qgate_date_user4 As String = "NO_DATA"
    Public qgate_date_user5 As String = "NO_DATA"
    Public ctUser As Integer = 0
    Public num_user(4) As String
    Public num_user_code(4) As String

    Public user1 As String = ""
    Public user2 As String = ""
    Public user3 As String = ""
    Public user4 As String = ""
    Public user5 As String = ""
    Public dmcqrscan As String = ""
    Public j = 0
    Public userpermi(4) As String
    Public Locationpart As String = ""
    Public phaseplant As String = ""
    Public timenow
    Public staffid As Integer = 0
    Public staffid2 As Integer = 0
    Public staffid3 As Integer = 0
    Public staffid4 As Integer = 0
    Public staffid5 As Integer = 0
    Public substringname(5) As String
    Public partsubstart(5) As String
    Public partsubend(5) As String
    Public qrpro As String
    Public BoxNum As String = 0
    Public Box_seq As String
    Public lotcur As String = ""
    Public partcodemaster As String = ""
    Public lotcu
    Public partline As String = ""
    Public user As String = ""
    Public serialnc As String = ""
    Public serialng As String = ""
    Public boxnumdefect As String = ""
    Public partplandate As String = ""
    Public partseqplan As String = ""
    Public partnotagfa As String = ""
    Public partactualdate1 As String = ""
    Public partasnp As String = ""
    Public partlotno As String = ""
    Public partactualdate2 As String = ""
    Public partseqactual As String = ""
    Public partplant As String = ""
    Public partbox As String = ""
    Public configposition As String = ""
    Public tagfa As String = ""
    Public partnamedigit As String
    Public shift As String
    Public lotcurrent As String = ""
    Public lotproduct As String = ""
    Public Macaddress
    Public dmcornondmc As String = ""
    Public productcount = 0
    Public productcountNG
    Public productcountNC
    Public partnofornondmc As String = ""
    Public workshift
    Public workdate
    Public workerid
    Public duringtimeid
    Public timetocheckqr As String = ""
    Public qrproduct As String = ""
    Public getpartname As String = ""
    Public Defectgroupid As String
    Public adminconfig As String = ""
    Public phaseid As String = ""
    Public zoneid As String = ""
    Public station As String = ""
    Public setphaseid As String
    Public countng = 0
    Public countnc = 0
    Public countboxng = 0
    Public countboxnc = 0

    Public setzoneid As String
    Public setstationid As String
    Public zoneset
    Public boxdefect = 999
    Public type As String
    Public defectnc As String
    Public defectng As String
    Public timetomorrow
    Public CountBoxDefect = 0
    Public CountNumDefect = 0
    Public numng = 0
    Public numnc = 0
    Public boxnumng = 0
    Public boxnumnc = 0
    Public defectcountidng = 0
    Public defectcountidnc = 0
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString

    End Function


    ''qgatesettingposition
    Public Sub set_PHASE(phase As String)
        qgate_phase = phase
    End Sub
    Public Function get_PHASE()
        Return qgate_phase
    End Function
    Public Sub set_ZONE(zone As String)
        qgate_zone = zone
    End Sub
    Public Function get_ZONE()
        Return qgate_zone
    End Function
    Public Sub set_STATION(station As String)
        qgate_station = station
    End Sub
    Public Function get_STAION()
        Return qgate_station
    End Function

    Public Sub set_TYPE(type As String)
        qgate_type = type
    End Sub
    Public Function get_TYPE()
        Return qgate_type
    End Function

    ''qgatelogin
    Public Sub set_data_login(staff As String)
        qgate_data_login = staff
    End Sub
    Public Function get_data_login()
        Return qgate_data_login
    End Function

    Public Sub set_date_user1(date1 As String)
        qgate_date_user1 = date1
    End Sub
    Public Function get_date_user1()
        Return qgate_date_user1
    End Function






    Public Sub set_ctUser(ctUser As String)
        qgate_ctUser = ctUser
    End Sub
    Public Function get_ctUser()
        Return qgate_ctUser
    End Function
    ''qgateselectpart


    Public Function userpack(ByVal Log As Integer)
        If Log = 1 Then
            qgateSelectMenu.pnuser1.Location = New Drawing.Point(-1, 3)
            qgateSelectMenu.pnuser2.Hide()
            qgateSelectMenu.pnuser3.Hide()
            qgateSelectMenu.pnuser4.Hide()
            qgateSelectMenu.pnuser5.Hide()
        ElseIf Log = 2 Then
            qgateSelectMenu.pnuser2.Show()
            qgateSelectMenu.pnuser2.Location = New Drawing.Point(-1, 53)
        ElseIf Log = 3 Then
            qgateSelectMenu.pnuser3.Show()
            qgateSelectMenu.pnuser3.Location = New Drawing.Point(-1, 103)
        ElseIf Log = 4 Then
            qgateSelectMenu.pnuser4.Show()
            qgateSelectMenu.pnuser4.Location = New Drawing.Point(-1, 153)
        ElseIf Log = 5 Then
            qgateSelectMenu.pnuser5.Show()
            qgateSelectMenu.pnuser5.Location = New Drawing.Point(-1, 203)
        End If
    End Function


    Public Function hidepicandname()
        If qgateSelectMenu.lbstaffno1.Text = Nothing Then
            qgateSelectMenu.pnuser1.Visible = False
        End If
        If qgateSelectMenu.lbstaffno2.Text = Nothing Then
            qgateSelectMenu.pnuser2.Visible = False
        End If
        If qgateSelectMenu.lbstaffno3.Text = Nothing Then
            qgateSelectMenu.pnuser3.Visible = False
        End If
        If qgateSelectMenu.lbstaffno4.Text = Nothing Then
            qgateSelectMenu.pnuser4.Visible = False
        End If
        If qgateSelectMenu.lbstaffno5.Text = Nothing Then
            qgateSelectMenu.pnuser5.Visible = False
        End If


    End Function

    Public Function addUser()
        If Module1.user1 = "" Then
            Module1.user1 = "1"
        ElseIf Module1.user2 = "" Then
            Module1.user2 = "1"
        ElseIf Module1.user3 = "" Then
            Module1.user3 = "1"
        ElseIf Module1.user4 = "" Then
            Module1.user4 = "1"
        ElseIf Module1.user5 = "" Then
            Module1.user5 = "1"
        End If

    End Function



    Public Function MoveUser()
        Try
            If user1 = "" Then
                setuser1()
                setuser2()
                setuser3()
                setuser4()
                setNullN5()
            ElseIf user2 = "" Then
                setuser2()
                setuser3()
                setuser4()
                setNullN5()
            ElseIf user3 = "" Then
                setuser3()
                setuser4()
                setNullN5()
            ElseIf user4 = "" Then
                setuser4()
                setNullN5()
            ElseIf user5 = "" Then
                setNullN5()
            End If
            hidepicandname()
        Catch ex As Exception
            MsgBox("ERROR ====> " & ex.Message)
        End Try

    End Function

    Public Function setuser1()
        num_user(0) = num_user(1)
        num_user_code(0) = num_user_code(1)
        qgateSelectMenu.lbstaffno1.Text = qgateSelectMenu.lbstaffno2.Text
        qgateSelectMenu.lbuseremp1.Text = qgateSelectMenu.lbuseremp2.Text
        qgate_date_user1 = qgate_date_user2
        staffid = staffid2
        userpermi(0) = userpermi(1)

    End Function
    Public Function setuser2()
        num_user(1) = num_user(2)
        num_user_code(1) = num_user_code(2)
        qgateSelectMenu.lbstaffno2.Text = qgateSelectMenu.lbstaffno3.Text
        qgateSelectMenu.lbuseremp2.Text = qgateSelectMenu.lbuseremp3.Text
        qgate_date_user2 = qgate_date_user3
        staffid2 = staffid3
        userpermi(1) = userpermi(2)
    End Function
    Public Function setuser3()
        num_user(2) = num_user(3)
        num_user_code(2) = num_user_code(3)
        qgateSelectMenu.lbstaffno3.Text = qgateSelectMenu.lbstaffno4.Text
        qgateSelectMenu.lbuseremp3.Text = qgateSelectMenu.lbuseremp4.Text
        qgate_date_user3 = qgate_date_user4
        staffid3 = staffid4
        userpermi(2) = userpermi(3)
    End Function
    Public Function setuser4()
        num_user(3) = num_user(4)
        num_user_code(3) = num_user_code(4)
        qgateSelectMenu.lbstaffno4.Text = qgateSelectMenu.lbstaffno5.Text
        qgateSelectMenu.lbuseremp4.Text = qgateSelectMenu.lbuseremp5.Text
        qgate_date_user4 = qgate_date_user5
        staffid4 = staffid5
        userpermi(3) = userpermi(4)
    End Function


    Public Function setNullN5()
        num_user(4) = Nothing
        num_user_code(4) = Nothing
        qgateSelectMenu.lbstaffno5.Text = Nothing
        qgateSelectMenu.lbuseremp5.Text = Nothing
        qgate_date_user5 = ""
        userpermi(4) = ""
        'qgateSelectMenu.pnuser5.Visible = False


    End Function
    Public Function setNullN4()
        num_user(3) = Nothing
        num_user_code(3) = Nothing
        qgateSelectMenu.lbstaffno4.Text = Nothing
        qgateSelectMenu.lbuseremp4.Text = Nothing
        qgate_date_user4 = ""
        userpermi(3) = ""
    End Function
    Public Function setNullN3()
        num_user(2) = Nothing
        num_user_code(2) = Nothing
        qgateSelectMenu.lbstaffno3.Text = Nothing
        qgateSelectMenu.lbuseremp3.Text = Nothing
        qgate_date_user3 = ""
        userpermi(2) = ""
    End Function
    Public Function setNullN2()
        num_user(1) = Nothing
        num_user_code(1) = Nothing
        qgateSelectMenu.lbstaffno2.Text = Nothing
        qgateSelectMenu.lbuseremp2.Text = Nothing
        qgate_date_user2 = ""
        userpermi(1) = ""
    End Function
    Public Function setNullN1()
        num_user(0) = Nothing
        num_user_code(0) = Nothing
        qgateSelectMenu.lbstaffno1.Text = Nothing
        qgateSelectMenu.lbuseremp1.Text = Nothing
        qgate_date_user1 = ""
        userpermi(0) = ""
    End Function
End Module
