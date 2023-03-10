Imports System.Globalization
Imports Nancy.Json
Public Class qgateScanTag
    Dim md As New ModelVB
    Dim a As String
    Dim b As String

    Dim status As Boolean = False

    Dim partno As String
    Dim dmccheck As String
    Dim Locationpart As String
    Dim partname As String


    Dim codemaster As String
    Private Sub pbSelectModel_Click(sender As Object, e As EventArgs) Handles pbSelectModel.Click
        If serialnc = "" And serialng = "" Then
            qgateSelectPart.Show()
            Me.Close()
        Else
            MsgBox("กรุณากดปริ้น TAG NC NG ก่อน")
        End If
    End Sub

    Private Sub pbBackToMenu_Click(sender As Object, e As EventArgs) Handles pbBackToMenu.Click
        If serialnc = "" And serialng = "" Then
            If type = "1" Or type = "2" Then
                qgateSelectMenu.Show()
                Me.Close()
            Else
                qgateMenuStart.Show()
                Me.Close()
            End If
        Else
            MsgBox("กรุณากดปริ้น TAG NC NG ก่อน")
        End If
    End Sub
    Private Sub qgateScanTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        lbpart.Text = Module1.qgate_part_no
        lbUserName.Text = user
        If type = "1" Then
            pbSelectModel.Visible = True
        ElseIf type = "3" And Module1.dmcornondmc = "dmc" Then
            pbSelectModel.Visible = True
        ElseIf type = "3" And Module1.dmcornondmc = "nondmc" Then
            pbSelectModel.Visible = True
        Else
            pbSelectModel.Visible = True
        End If
    End Sub
    Private Sub tbScanTag_KeyDown(sender As Object, e As KeyEventArgs) Handles tbScanTag.KeyDown
        If e.KeyCode = Keys.Enter Then
            If type = "1" Then
                If lbpart.Text = "NO_DATA" Then
                    tbScanTag.Text = ""
                    MsgBox("Please Select Part Model")
                Else
                    scanTagSubString(tbScanTag.Text, Module1.qgate_part_no)
                End If
            ElseIf Module1.dmcornondmc = "dmc" And type = "3" Then
                scanTagSubString(tbScanTag.Text, Module1.qgate_part_no)
            ElseIf Module1.dmcornondmc = "nondmc" And type = "3" Then
                scanTagSubStringManual(tbScanTag.Text, Module1.qgate_part_no)
            ElseIf type = "2" Then
                scanTagSubStringManual(tbScanTag.Text, Module1.qgate_part_no)
            Else
                MsgBox("PLASE Config By admin")
                tbScanTag.Text = ""
            End If
        End If
    End Sub

    Public Function getboxandlot(partnotagfa As String)
        Dim dt As Date = Date.Today
        Dim a = dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim b = dt.AddDays(-1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim o = md.get_BoxNo_Lotcurrent(a, partnotagfa)
            Dim l = md.get_BoxNo_Lotcurrent(b, partnotagfa)
            Dim boxcurrent
            Try
                If o <> "0" Then
                    If TimeOfDay.ToString("HH:mm:ss") >= "08:00:00" Then
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(o)
                        For Each item As Object In dict3
                            lotcu = item("ifts_lot_current").ToString
                            boxcurrent = item("iotc_count_box").ToString
                        Next
                        BoxNum = boxcurrent
                        lotcur = lotcu
                    Else
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(l)
                        For Each item As Object In dict3
                            lotcu = item("ifts_lot_current").ToString
                            boxcurrent = item("iotc_count_box").ToString
                        Next
                        BoxNum = boxcurrent
                        lotcur = lotcu
                    End If
                Else
                    If TimeOfDay.ToString("HH:mm:ss") >= "08:00:00" Then
                        BoxNum = 0
                        genlot(Module1.timenow)
                    Else
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(l)
                        For Each item As Object In dict3
                            lotcu = item("ifts_lot_current").ToString
                            boxcurrent = item("iotc_count_box").ToString
                        Next
                        BoxNum = boxcurrent
                        lotcur = lotcu
                    End If
                End If
            Catch ex As Exception
                BoxNum = 0
                genlot(Module1.timenow)

            End Try
            Module1.BoxNum += 1
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Public Function genlot(timenow As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            lotcur = md.get_Lotcur(timenow)
            status = True
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Public Function scanTagSubString(scantag As String, partno As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            If scantag.Length = 103 Then
                Dim oldtag = md.get_OldTagFa(scantag)
                If oldtag <> "0" Then
                    MsgBox("กรุณาแสกน TAG อันใหม่ TAG ซ้ำ")
                    tbScanTag.Text = ""
                Else
                    partnotagfa = scantag.Substring(19, 25)
                    partplant = scantag.Substring(98, 2)
                    If partplant = Module1.phaseplant Then
                        If Trim(partnotagfa) = partno Then
                            partcodemaster = scantag.Substring(0, 2)
                            Dim rsgetcodemaster = md.get_Code_master((partcodemaster))
                            Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsgetcodemaster)
                            For Each item As Object In dict3
                                codemaster = item("mfcm_id").ToString
                            Next
                            partline = scantag.Substring(2, 6)
                            partplandate = scantag.Substring(8, 8)
                            partseqplan = scantag.Substring(16, 3)
                            partactualdate1 = scantag.Substring(44, 8)
                            partasnp = scantag.Substring(52, 6)
                            partlotno = scantag.Substring(58, 4)
                            partactualdate2 = scantag.Substring(87, 8)
                            partseqactual = scantag.Substring(95, 3)
                            partplant = scantag.Substring(98, 2)
                            partbox = scantag.Substring(100, 3)
                            getboxandlot(partnotagfa)
                            Dim rsinserttagfa = md.insert_tag_fa(codemaster, scantag, partline, partplandate, partseqplan, partnotagfa, partactualdate1, partasnp,
                                                           partlotno, partactualdate2, partseqactual, partplant, partbox, lotcur)
                            If BoxNum <= 9 Then
                                Box_seq = "00" & BoxNum
                            ElseIf BoxNum <= 99 Then
                                Box_seq = "0" & BoxNum
                            Else
                                Box_seq = BoxNum
                            End If
                            tbScanTag.Text = ""
                            Module1.tagfa = scantag
                            status = True
                            qgateOperation.Show()
                            Me.Close()
                        Else
                            status = False
                            MsgBox("กรุณาสแกน ตามที่เลือกในหน้า Select Part")
                            tbScanTag.Text = ""
                        End If
                    Else
                        status = False
                        MsgBox("PhaseTAG กับ CONFIG ไม่ตรงกัน")
                        tbScanTag.Text = ""
                    End If
                End If
            Else
                status = False
                MsgBox("จำนวนไม่เท่ากับ 103")
                tbScanTag.Text = ""
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function scanTagSubStringManual(scantag As String, partno As String)
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            If scantag.Length = 103 Then
                Dim oldtag = md.get_OldTagFa(scantag)
                If oldtag <> "0" Then
                    MsgBox("กรุณาแสกน TAG อันใหม่ TAG ซ้ำ")
                    tbScanTag.Text = ""
                Else
                    partnotagfa = scantag.Substring(19, 25)
                    partnofornondmc = partnotagfa
                    partplant = scantag.Substring(98, 2)
                    If partplant = Module1.phaseplant Then
                        If Trim(partnotagfa) = partno Then
                            partcodemaster = scantag.Substring(0, 2)
                            Dim rsgetcodemaster = md.get_Code_master((partcodemaster))
                            Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsgetcodemaster)
                            For Each item As Object In dict3
                                codemaster = item("mfcm_id").ToString
                            Next
                            partline = scantag.Substring(2, 6)
                            partplandate = scantag.Substring(8, 8)
                            partseqplan = scantag.Substring(16, 3)
                            partactualdate1 = scantag.Substring(44, 8)
                            partasnp = scantag.Substring(52, 6)
                            partlotno = scantag.Substring(58, 4)
                            partactualdate2 = scantag.Substring(87, 8)
                            partseqactual = scantag.Substring(95, 3)
                            partbox = scantag.Substring(100, 3)
                            getboxandlot(partnotagfa)
                            Dim rsinserttagfa = md.insert_tag_fa(codemaster, scantag, partline, partplandate, partseqplan, partnotagfa, partactualdate1, partasnp,
                                                       partlotno, partactualdate2, partseqactual, partplant, partbox, lotcur)
                            If BoxNum <= 9 Then
                                Box_seq = "00" & BoxNum
                            ElseIf BoxNum <= 99 Then
                                Box_seq = "0" & BoxNum
                            Else
                                Box_seq = BoxNum
                            End If
                            tbScanTag.Text = ""
                            Module1.tagfa = scantag
                            status = True
                            qgateOperationManual.Show()
                            Me.Close()
                        Else
                            status = False
                            MsgBox("กรุณาสแกน ตามที่เลือกในหน้า Select Part")
                            tbScanTag.Text = ""
                        End If
                    Else
                        status = False
                        MsgBox("PhaseTAG กับ CONFIG ไม่ตรงกัน")
                        tbScanTag.Text = ""
                    End If
                End If
            Else
                status = False
                MsgBox("จำนวนไม่เท่ากับ 103")
                tbScanTag.Text = ""
            End If
            Return status
        Else
            MsgBox("Waiting Internet")
        End If
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        printdefecttag()
    End Sub
    Public Function printdefecttag()
        serialnc = ""
        serialng = ""
        Dim countng
        Dim tagdefectNC
        Dim tagdefectNG
        Dim boxng
        Dim countnc
        Dim boxnc
        Dim defectcountid
        Dim defecttype
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Try
                If Module1.countng > "0" Or Module1.countnc > "0" Then
                    Dim idcount = md.Get_IDDefectCount(configposition)
                    Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(idcount)
                    For Each item As Object In dict6
                        defecttype = item("idc_type").ToString
                        If defecttype = "0" Then
                            defectcountid = item("idc_id").ToString
                            defectcountidng = defectcountid
                        Else
                            defectcountid = item("idc_id").ToString
                            defectcountidnc = defectcountid
                        End If
                    Next
                    If Module1.countng > 0 Then
                        If Module1.countng <= 9 Then
                            countng = "0000" & Module1.countng
                        ElseIf Module1.countng <= 99 Then
                            countng = "000" & Module1.countng
                        ElseIf Module1.countng <= 99 Then
                            countng = "00" & Module1.countng
                        ElseIf Module1.countng <= 99 Then
                            countng = "0" & Module1.countng
                        Else
                            countng = Module1.countng
                        End If
                        If Module1.countboxng <= 9 Then
                            boxng = "00" & Module1.countboxng
                        ElseIf Module1.countboxng <= 99 Then
                            boxng = "0" & Module1.countboxng
                        Else
                            boxng = Module1.countboxng

                        End If
                        tagdefectNG = ("DF NG" & " " & partline & "               " & lotcur & " " & partplant & " " & boxng & " " & countng & " " & partnotagfa)
                        md.insert_info_tagdefect(defectcountidng, "1", num_user(0), tagdefectNG, boxng)
                        Module1.countng = 0
                        printtagdefect(tagdefectNG)
                        Module1.numng = 0
                    End If
                    If Module1.countnc > 0 Then

                        If Module1.countnc <= 9 Then
                            countnc = "0000" & Module1.countnc
                        ElseIf Module1.countnc <= 99 Then
                            countnc = "000" & Module1.countnc
                        ElseIf Module1.countnc <= 99 Then
                            countnc = "00" & Module1.countnc
                        ElseIf Module1.countnc <= 99 Then
                            countnc = "0" & Module1.countnc
                        Else
                            countnc = Module1.countnc
                        End If
                        If Module1.countboxnc <= 9 Then
                            boxnc = "00" & Module1.countboxnc
                        ElseIf Module1.countboxnc <= 99 Then
                            boxnc = "0" & Module1.countboxnc
                        Else
                            boxnc = Module1.countboxnc
                        End If
                        tagdefectNC = ("DF NC" & " " & partline & "               " & lotcur & " " & partplant & " " & boxnc & " " & countnc & " " & partnotagfa)
                        md.insert_info_tagdefect(defectcountidnc, "1", num_user(0), tagdefectNC, boxng)
                        Module1.countnc = 0
                        printtagdefect(tagdefectNC)
                        Module1.numnc = 0
                    End If
                Else
                    MsgBox("ยังไม่มีของเสีย")
                End If
                md.update_Status_Defect_count(configposition, num_user(0))
            Catch ex As Exception
                MsgBox("กรุณาตรวจสินค้าก่อน")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function printtagdefect(tagdefect As String)
        Dim reprintpartno As String
        Dim reprintpartname As String
        Dim reprintsnp As String
        Dim reprintcountbox As String
        Dim reprintcheckdate As String
        Dim reprintlotcurrent As String
        Dim reprintlotproduct As String
        Dim reprintshift As String
        Dim reprintlinecd As String
        Dim reprintphasename As String
        Dim reprintlocation As String
        Dim reprinttagqgate As String
        Dim tagfaid As String
        Dim qrproduct As String
        Dim tagdefectid As String
        Dim status As Boolean = False
        Dim defectcode
        Dim Producttype
        Dim defecttogenqr As String
        Dim defectcountid As String
        Module1.qrpro = ""
        qrproduct = ""
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Try
                Dim tag = md.get_Data_Scan_Print_Defect(tagdefect)
                If tag <> "0" Then
                    Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(tag)
                    For Each item As Object In dict2
                        reprintpartno = item("ifts_part_no").ToString
                        reprintpartname = item("msp_part_name").ToString
                        reprintsnp = item("idc_count").ToString
                        reprintcountbox = item("iptd_count_box").ToString
                        reprintcheckdate = item("date_tag").ToString
                        reprintlotcurrent = item("ifts_lot_current").ToString
                        reprintshift = item("iodc_shift").ToString
                        reprintlinecd = item("ifts_line_cd").ToString
                        reprintphasename = item("mpa_name").ToString
                        reprintlocation = item("mpn_location").ToString
                        reprinttagqgate = item("iptd_tagdefect").ToString
                        tagfaid = item("ifts_id").ToString
                        tagdefectid = item("iptd_id").ToString
                        status = True
                        Producttype = item("idc_type").ToString
                        defectcountid = item("idc_id").ToString
                    Next
                    Dim count
                    defecttogenqr = ""
                    count = 1
                    Dim countdefect As Integer
                    Dim alldefect = md.Get_AllDefect(defectcountid)
                    Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(alldefect)
                    For Each item1 As Object In dict6
                        If count > 1 Then
                            defecttogenqr &= " | "
                        End If
                        defectcode = item1("md_defect_code").ToString
                        countdefect = item1("total_qty").ToString
                        defecttogenqr &= defectcode & " = " & countdefect
                        count += 1
                    Next
                End If
                PrintDefect.Set_parameter_print(reprintpartno, reprintpartname, "1", reprintlotcurrent, reprintcountbox, reprintsnp, "1", "999", defecttogenqr, "001", "001", reprintshift, "01000", reprintlocation, reprintcheckdate, "1", reprintlotproduct, reprintlinecd, reprinttagqgate, defecttogenqr, Producttype)
            Catch ex As Exception
                MsgBox("ไม่สามารถพิมพ์แท็ก Defect ได้")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
End Class