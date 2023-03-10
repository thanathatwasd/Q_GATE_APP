Imports Nancy.Json

Public Class qgateSettingPosition
    Dim md As New ModelVB
    Dim status As Boolean
    Dim SelectPhase As String
    Dim SelectZone As String
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles pbConfirm.Click
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim phaseandstation = md.get_Phase_Zone(cbSelectPhase.SelectedItem, cbSelectZone.SelectedItem, cbSelectStation.SelectedItem)
            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(phaseandstation)
            For Each item As Object In dict2
                phaseid = item("mpa_id").ToString
                zoneid = item("mza_id").ToString
                station = item("msa_id").ToString
            Next
            If cbSelectPhase.Text = "" Or cbSelectZone.Text = "" Or cbSelectStation.Text = "" Then
                MsgBox("Please Select Position")
            Else
                qgateMenuAdmin.Show()
                Me.Close()
            End If
            cbSelectStation.Items.Clear()
            md.update_delete_macadd_old(Module1.getMacAddress())
            md.update_config_macaddress(phaseid, zoneid, station, Module1.getMacAddress(), adminconfig, "0")
        Else
            MsgBox("Waiting Internet")
        End If
    End Sub
    Private Sub qgateSettingPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPhase()
        cbSelectPhase.SelectedIndex = 0
        cbSelectZone.SelectedIndex = 0
        cbSelectStation.SelectedIndex = 0
    End Sub
    Public Function getPhase()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim rs = md.get_DataPhase()
            status = False
            If rs <> "0" Then
                status = True
                Dim phasename
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                Dim checkagain As String
                For Each item As Object In dict2
                    phasename = item("mpa_name").ToString
                    Label1.Text = rs
                    cbSelectPhase.Items.Add(phasename)
                Next
            Else
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Public Function getZone(SelectPhase)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            cbSelectZone.Items.Clear()
            cbSelectStation.Items.Clear()
            Dim rs1 = md.get_DataZone(SelectPhase)
            status = False
            If rs1 <> "0" Then
                status = True
                Dim zone
                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs1)
                For Each item As Object In dict2
                    zone = item("mza_name").ToString
                    cbSelectZone.Items.Add(zone)
                Next
            Else
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function


    Public Function getStation(SelectPhase, SelectZone)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            cbSelectStation.Items.Clear()
            Dim rs1 = md.get_DataPosition(SelectPhase, SelectZone)
            status = False
            If rs1 <> "0" Then
                status = True
                Dim dict5 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs1)
                For Each item As Object In dict5
                    station = item("msa_id").ToString
                    cbSelectStation.Items.Add(station)
                Next
            Else
                status = False
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Private Sub cbSelectPhase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSelectPhase.SelectedIndexChanged
        getZone(cbSelectPhase.SelectedItem)
        cbSelectZone.SelectedIndex = 0
        cbSelectStation.SelectedIndex = 0
    End Sub
    Private Sub cbSelectZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSelectZone.SelectedIndexChanged
        getStation(cbSelectPhase.SelectedItem, cbSelectZone.SelectedItem)
        cbSelectStation.SelectedIndex = 0

    End Sub

    Private Sub pbBackToMenu_Click(sender As Object, e As EventArgs) Handles pbBackToMenu.Click
        qgateMenuAdmin.Show()
        Me.Close()
    End Sub
End Class