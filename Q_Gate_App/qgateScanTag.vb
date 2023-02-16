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

        qgateSelectPart.Show()
        Me.Close()
    End Sub

    Private Sub pbBackToMenu_Click(sender As Object, e As EventArgs) Handles pbBackToMenu.Click
        If type = "1" Or type = "2" Then
            qgateSelectMenu.Show()
            Me.Close()
        Else
            qgateMenuStart.Show()
            Me.Close()
        End If
    End Sub

    Private Sub qgateScanTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        lbpart.Text = Module1.qgate_part_no
        lbUserName.Text = Module1.num_user(0)
        'MsgBox("Type ====>  " & type)
        If type = "1" Then
            pbSelectModel.Visible = True
        ElseIf type = "3" And Module1.dmcornondmc = "dmc" Then
            pbSelectModel.Visible = True
        ElseIf type = "3" And Module1.dmcornondmc = "nondmc" Then
            pbSelectModel.Visible = False
        Else
            pbSelectModel.Visible = False
        End If

    End Sub
    Private Sub tbScanTag_KeyDown(sender As Object, e As KeyEventArgs) Handles tbScanTag.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim timenow = (DateTime.Now.ToString("yyyy-MM-dd"))
            'MsgBox("timenow==> " & timenow)
            lotcur = md.get_Lotcur(timenow)
            'MsgBox("lotcur==> " & lotcur)
            If type = "1" Then
                If lbpart.Text = "NO_DATA" Then
                    tbScanTag.Text = ""
                    MsgBox("Please Select Part Model")
                Else
                    scanTagSubString(tbScanTag.Text, Module1.qgate_part_no)

                End If

            ElseIf Module1.dmcornondmc = "dmc" And type = "3" Then
                'MsgBox("both===>both")
                scanTagSubString(tbScanTag.Text, Module1.qgate_part_no)
            ElseIf Module1.dmcornondmc = "nondmc" And type = "3" Then
                'MsgBox("nondmc===>nondmc")
                scanTagSubStringManual(tbScanTag.Text)
            ElseIf type = "2" Then
                scanTagSubStringManual(tbScanTag.Text)
            Else
                MsgBox("PLASE Config By admin")
                tbScanTag.Text = ""

            End If
        End If


    End Sub







    Public Function scanTagSubString(scantag As String, partno As String)
        If scantag.Length = 103 Then
            Dim oldtag = md.get_OldTagFa(scantag)
            If oldtag <> "0" Then
                MsgBox("กรุณาแสกน TAG อันใหม่ TAG ซ้ำ")
                tbScanTag.Text = ""
            Else
                partnotagfa = scantag.Substring(19, 25)
                ' MsgBox("tbScanTag.Tex====>" & scantag)
                'MsgBox("partnotagfa==>" & partnotagfa)
                'MsgBox("partnotagfa===> " & partnotagfa)

                'MsgBox(" Module1.phaseplant===> " & Module1.phaseplant)
                partplant = scantag.Substring(98, 2)
                If partplant = Module1.phaseplant Then

                    'ถ้าทำ unittest ให้ฟิกค่าตรง Module1.qgate_part_no ให้เปลี่ยนเป็น ชื่อ part no
                    If Trim(partnotagfa) = partno Then

                        'MsgBox(scantag)
                        partcodemaster = scantag.Substring(0, 2)
                        'MsgBox("partcodemaster==>" & partcodemaster)
                        Dim rsgetcodemaster = md.get_Code_master((partcodemaster))
                        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsgetcodemaster)
                        For Each item As Object In dict3
                            codemaster = item("mfcm_id").ToString
                        Next
                        'MsgBox("codemaster===>" & codemaster)
                        partline = scantag.Substring(2, 6)
                        'MsgBox("partline==>" & partline)
                        partplandate = scantag.Substring(8, 8)
                        'MsgBox("partplandate==>" & partplandate)
                        partseqplan = scantag.Substring(16, 3)
                        'MsgBox("partseqplan==>" & partseqplan)

                        partactualdate1 = scantag.Substring(44, 8)
                        'MsgBox("partactualdate1==>" & partactualdate1)
                        partasnp = scantag.Substring(52, 6)
                        'MsgBox("partasnp==>" & partasnp)
                        partlotno = scantag.Substring(58, 4)
                        'MsgBox("partlotno==>" & partlotno)
                        partactualdate2 = scantag.Substring(87, 8)
                        'MsgBox("partactualdate2==>" & partactualdate2)
                        partseqactual = scantag.Substring(95, 3)
                        'MsgBox("partseqactual==>" & partseqactual)
                        partplant = scantag.Substring(98, 2)
                        'MsgBox("partplant==>" & partplant)
                        partbox = scantag.Substring(100, 3)
                        'MsgBox("partbox==>" & partbox)
                        Dim rsinserttagfa = md.insert_tag_fa(codemaster, scantag, partline, partplandate, partseqplan, partnotagfa, partactualdate1, partasnp,
                                                       partlotno, partactualdate2, partseqactual, partplant, partbox, lotcur)
                        tbScanTag.Text = ""
                        Module1.tagfa = scantag
                        'MsgBox("dmc===>dmc")
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
    End Function




    Public Function scanTagSubStringManual(scantag As String)
        If scantag.Length = 103 Then
            Dim oldtag = md.get_OldTagFa(scantag)
            If oldtag <> "0" Then
                MsgBox("กรุณาแสกน TAG อันใหม่ TAG ซ้ำ")
                tbScanTag.Text = ""
            Else
                partnotagfa = scantag.Substring(19, 25)
                partnofornondmc = partnotagfa
                ' MsgBox("tbScanTag.Tex====>" & scantag)
                'MsgBox("partnotagfa==>" & partnotagfa)
                'MsgBox("partnotagfa===> " & partnotagfa)
                'MsgBox(" Module1.phaseplant===> " & Module1.phaseplant)
                partplant = scantag.Substring(98, 2)
                If partplant = Module1.phaseplant Then
                    'ถ้าทำ unittest ให้ฟิกค่าตรง Module1.qgate_part_no ให้เปลี่ยนเป็น ชื่อ part no
                    'MsgBox(scantag)
                    partcodemaster = scantag.Substring(0, 2)
                    'MsgBox("partcodemaster==>" & partcodemaster)
                    Dim rsgetcodemaster = md.get_Code_master((partcodemaster))
                    Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rsgetcodemaster)
                    For Each item As Object In dict3
                        codemaster = item("mfcm_id").ToString
                    Next
                    'MsgBox("codemaster===>" & codemaster)
                    partline = scantag.Substring(2, 6)
                    'MsgBox("partline==>" & partline)
                    partplandate = scantag.Substring(8, 8)
                    'MsgBox("partplandate==>" & partplandate)
                    partseqplan = scantag.Substring(16, 3)
                    'MsgBox("partseqplan==>" & partseqplan)
                    partactualdate1 = scantag.Substring(44, 8)
                    'MsgBox("partactualdate1==>" & partactualdate1)
                    partasnp = scantag.Substring(52, 6)
                    'MsgBox("partasnp==>" & partasnp)
                    partlotno = scantag.Substring(58, 4)
                    'MsgBox("partlotno==>" & partlotno)
                    partactualdate2 = scantag.Substring(87, 8)
                    'MsgBox("partactualdate2==>" & partactualdate2)
                    partseqactual = scantag.Substring(95, 3)
                    'MsgBox("partseqactual==>" & partseqactual)

                    'MsgBox("partplant==>" & partplant)
                    partbox = scantag.Substring(100, 3)
                    'MsgBox("partbox==>" & partbox)
                    Dim rsinserttagfa = md.insert_tag_fa(codemaster, scantag, partline, partplandate, partseqplan, partnotagfa, partactualdate1, partasnp,
                                                       partlotno, partactualdate2, partseqactual, partplant, partbox, lotcur)

                    tbScanTag.Text = ""

                    Module1.tagfa = scantag


                    status = True
                    qgateOperationManual.Show()
                    Me.Close()

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
    End Function


End Class