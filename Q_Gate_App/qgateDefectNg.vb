Imports Nancy.Json
Public Class qgateDefectNg
    Dim md As New ModelVB

    Dim defectcode As String
    Dim defectDetail As String
    Dim defect As String
    Dim Defectid As String
    Dim productid As String
    Dim NG = "0"
    Dim tagid
    Dim flg_product
    Dim iddefectcount
    Private Sub qgateDefectNg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbUserName.Text = user
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Dim defect = md.get_DataDefect()
            Try
                Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(defect)
                For Each item As Object In dict3
                    defectcode = item("md_defect_code").ToString
                    defectDetail = item("md_defect_en_name").ToString
                    Dim list = New ListViewItem(defectcode)
                    list.SubItems.Add(defectDetail)
                    list.SubItems.Add(Defectid)
                    ListView1.Items.Add(list)
                Next
                Dim tagfaid = md.get_IdTagfa(Module1.tagfa)
                Dim dict5 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(tagfaid)
                For Each item As Object In dict5
                    tagid = item("ifts_id").ToString
                Next
                productid = md.get_ProductID(tagid)
                Dim dict6 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(productid)
                For Each item As Object In dict6
                    productid = item("iodc_id").ToString
                    flg_product = item("iodc_flg").ToString
                    If flg_product = "1" Then
                        CbNumProduct.Items.Add(item("iodc_count_item").ToString)
                    End If
                Next
                If type = "1" Then
                    tbPartNo.Visible = True
                    CbNumProduct.Visible = False
                    tbPartNo.Select()
                ElseIf Module1.dmcornondmc = "dmc" And type = "3" Then
                    tbPartNo.Select()
                    tbPartNo.Visible = True
                    CbNumProduct.Visible = False
                ElseIf Module1.dmcornondmc = "nondmc" And type = "3" Then
                    tbPartNo.Visible = False
                    CbNumProduct.Visible = True
                ElseIf type = "2" Then
                    tbPartNo.Visible = False
                    CbNumProduct.Visible = True
                Else
                    MsgBox("ติดต่อแอดมิน")
                End If
                ListView1.Items(0).Selected = True
            Catch ex As Exception
                MsgBox("กรุณากรอก qr Product")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        backtooperation()
    End Sub
    Public Function dmc()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            If tbPartNo.Text <> "" Then
                Dim rs As String = ""
                For Each lvItem As ListViewItem In ListView1.SelectedItems
                    rs = ListView1.Items(lvItem.Index).SubItems(0).Text
                Next
                defect = md.get_DataDefectID(rs)
                Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(defect)
                For Each item As Object In dict3
                    Defectid = item("md_id").ToString
                Next
                Dim qrproductid = md.get_QrProduct(tbPartNo.Text)
                If qrproductid <> "0" Then
                    Dim dict5 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(qrproductid)
                    For Each item As Object In dict5
                        productid = item("iodc_id").ToString
                    Next
                    Dim getDefect = md.get_DataDefectGroup(configposition, Defectid)

                    Dim dict4 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getDefect)
                    For Each item As Object In dict4
                        Defectgroupid = item("mdg_id").ToString
                    Next
                    Dim getdefectcount = md.get_DataDefectCount(configposition, NG)
                    serialnc = tbPartNo.Text
                    qgateOperation.lbQrSerialNumNg.Text = serialnc
                    If getdefectcount = "0" Then
                        md.insert_info_part_count(configposition, NG, "1", num_user(0))
                        Dim getdefectcountid = md.get_DataDefectCount(configposition, NG)
                        Dim dict10 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getdefectcountid)
                        For Each item As Object In dict10
                            iddefectcount = item("idc_id").ToString
                        Next
                        Dim insertng = md.insert_Info_Defect(Defectgroupid, productid, NG, num_user(0), iddefectcount)
                        Module1.numng = 1
                    Else
                        Dim defectcount
                        Dim dict10 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getdefectcount)
                        For Each item As Object In dict10
                            defectcount = item("idc_count").ToString
                        Next
                        defectcount += 1
                        Module1.numng = defectcount
                        md.update_Defect_Count(configposition, defectcount, num_user(0), Module1.timenow, NG)
                        Dim getdefectcountid = md.get_DataDefectCount(configposition, NG)
                        Dim dict11 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getdefectcountid)
                        For Each item As Object In dict11
                            iddefectcount = item("idc_id").ToString
                        Next
                        Dim insertng = md.insert_Info_Defect(Defectgroupid, productid, NG, num_user(0), iddefectcount)
                    End If
                    qgateOperation.tbQrSerial.Enabled = True
                    qrproduct = ""
                    productcount = productcount - 1
                    productcountNG = qgateOperation.tbCounterNg.Text
                    productcountNG = productcountNG + 1
                    md.update_flg_product(productid)
                    qgateOperation.Show()
                    qgateOperation.tbCounterNg.Text = productcountNG
                    qgateOperation.tbcounter.Text = productcount
                    Me.Close()
                Else
                    MsgBox("ไม่พบชิ้นงาน")
                End If
            Else
                MsgBox("กรุณากรอก qr Product")
            End If
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Public Function nondmc()
        If My.Computer.Network.Ping(md.get_DatabaseServer()) Then
            Try
                Dim rs As String = ""
                If CbNumProduct.Text <> "" Then
                    For Each lvItem As ListViewItem In ListView1.SelectedItems
                        rs = ListView1.Items(lvItem.Index).SubItems(0).Text
                    Next
                    defect = md.get_DataDefectID(rs)
                    Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(defect)
                    For Each item As Object In dict3
                        Defectid = item("md_id").ToString
                    Next
                    Dim getDefect = md.get_DataDefectGroup(configposition, Defectid)
                    Dim dict4 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getDefect)
                    For Each item As Object In dict4
                        Defectgroupid = item("mdg_id").ToString
                    Next
                    Dim getdefectcount = md.get_DataDefectCount(configposition, NG)
                    If getdefectcount = "0" Then
                        md.insert_info_part_count(configposition, NG, "1", num_user(0))
                        Dim getdefectcountid = md.get_DataDefectCount(configposition, NG)
                        Dim dict10 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getdefectcountid)
                        For Each item As Object In dict10
                            iddefectcount = item("idc_id").ToString
                        Next
                        Module1.numnc = 1
                        Dim insertng = md.insert_Info_Defect(Defectgroupid, productid, NG, num_user(0), iddefectcount)
                    Else
                        Dim defectcount
                        Dim dict10 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getdefectcount)
                        For Each item As Object In dict10
                            defectcount = item("idc_count").ToString
                        Next
                        defectcount += 1
                        Module1.numnc = defectcount
                        md.update_Defect_Count(configposition, defectcount, num_user(0), Module1.timenow, NG)
                        Dim getdefectcountid = md.get_DataDefectCount(configposition, NG)
                        Dim dict11 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getdefectcountid)
                        For Each item As Object In dict11
                            iddefectcount = item("idc_id").ToString
                        Next
                        Dim insertng = md.insert_Info_Defect(Defectgroupid, productid, NG, num_user(0), iddefectcount)
                    End If
                    productcount = productcount - 1
                    productcountNG = qgateOperationManual.tbCounterNg.Text
                    productcountNG = productcountNG + 1
                    md.update_flg_product_Manual(tagid, CbNumProduct.SelectedItem)
                    qgateOperationManual.Show()
                    qgateOperationManual.tbCounterNg.Text = productcountNG
                    qgateOperationManual.tbCounter.Text = productcount
                    Me.Close()
                Else
                    MsgBox("เลือกตัวที่ต้องการกด NG")
                End If
            Catch ex As Exception
                MsgBox("เลือกตัวที่ต้องการกด NG")
            End Try
        Else
            MsgBox("Waiting Internet")
        End If
    End Function
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        gotooperation()
    End Sub
    Public Function gotooperation()
        If type = "1" Then
            dmc()
            If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                qgateOperation.btnFinish.Show()
            Else
                qgateOperation.btnFinish.Hide()

            End If
        ElseIf Module1.dmcornondmc = "dmc" And type = "3" Then
            dmc()
            If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                qgateOperation.btnFinish.Show()
            Else
                qgateOperation.btnFinish.Hide()
            End If

        ElseIf Module1.dmcornondmc = "nondmc" And type = "3" Then
            nondmc()
            If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                qgateOperationManual.btnFinish.Show()
            Else
                qgateOperationManual.btnFinish.Hide()
            End If
        ElseIf type = "2" Then
            nondmc()
            If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                qgateOperationManual.btnFinish.Show()
            Else
                qgateOperationManual.btnFinish.Hide()
            End If
        Else
            MsgBox("ติดต่อแอดมิน")
        End If
    End Function
    Public Function backtooperation()
        If Type = "1" Then
            qgateOperation.Show()
            Me.Close()
        ElseIf Module1.dmcornondmc = "dmc" And Type = "3" Then
            qgateOperation.Show()
            Me.Close()
        ElseIf Module1.dmcornondmc = "nondmc" And Type = "3" Then
            qgateOperationManual.Show()
            Me.Close()
        ElseIf Type = "2" Then
            qgateOperationManual.Show()
            Me.Close()
        Else
            MsgBox("ติดต่อแอดมิน")
        End If
    End Function

End Class