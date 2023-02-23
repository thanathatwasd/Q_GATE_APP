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

    Private Sub qgateDefectNg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbUserName.Text = Module1.num_user(0)
        lbZone.Text = zoneset
        lbStation.Text = setstationid
        Dim defect = md.get_DataDefect()
        'MsgBox("defect==> " & defect)
        Dim dict3 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(defect)

        For Each item As Object In dict3

            defectcode = item("md_defect_code").ToString

            defectDetail = item("md_defect_en_name").ToString

            Dim list = New ListViewItem(defectcode)
            list.SubItems.Add(defectDetail)
            list.SubItems.Add(Defectid)
            ListView1.Items.Add(list)
        Next
        ''''เหลือ insert ลง จตาราง defect เขียน store เสร็จแล้ว
        Dim tagfaid = md.get_IdTagfa(Module1.tagfa)
        'MsgBox("qrproductid===> " & qrproductid)
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


        If Type = "1" Then
            tbPartNo.Visible = True
            CbNumProduct.Visible = False
            tbPartNo.Select()
        ElseIf Module1.dmcornondmc = "dmc" And Type = "3" Then
            tbPartNo.Select()
            tbPartNo.Visible = True
            CbNumProduct.Visible = False
        ElseIf Module1.dmcornondmc = "nondmc" And Type = "3" Then
            tbPartNo.Visible = False
            CbNumProduct.Visible = True
        ElseIf Type = "2" Then
            tbPartNo.Visible = False
            CbNumProduct.Visible = True
        Else
            MsgBox("ติดต่อแอดมิน")

        End If
        ListView1.Items(0).Selected = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        backtooperation()
    End Sub


    Public Function dmc()
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
            ''''เหลือ insert ลง จตาราง defect เขียน store เสร็จแล้ว
            Dim qrproductid = md.get_QrProduct(tbPartNo.Text)
            If qrproductid <> "0" Then
                'MsgBox("qrproductid===> " & qrproductid)
                Dim dict5 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(qrproductid)
                For Each item As Object In dict5
                    productid = item("iodc_id").ToString
                Next
                Dim getDefect = md.get_DataDefectGroup(configposition, Defectid)
                'MsgBox("getDefect===> " & getDefect)
                Dim dict4 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getDefect)
                For Each item As Object In dict4
                    Defectgroupid = item("mdg_id").ToString
                Next
                'MsgBox("Defectgroupid====> " & Defectgroupid)
                'MsgBox("productid====> " & productid)
                'MsgBox("NG====> " & NG)
                'MsgBox("num_user(0)====> " & num_user(0))
                Dim insertng = md.insert_Info_Defect(Defectgroupid, productid, NG, num_user(0))


                Dim getdefectcount = md.get_DataDefectCount(configposition, timenow, NG)
                'MsgBox("configposition===> " & configposition)
                'MsgBox("timenow===> " & timenow)
                'MsgBox("NG===> " & NG)
                'MsgBox("getdefectcount===> " & getdefectcount)
                If getdefectcount = "0" Then
                    'MsgBox("111111111111111111")
                    md.insert_info_part_count(configposition, NG, "1", num_user(0), Module1.qgate_part_no)


                Else
                    Dim defectcount
                    Dim dict10 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getdefectcount)
                    For Each item As Object In dict10
                        defectcount = item("idc_count").ToString
                    Next
                    defectcount += 1
                    'MsgBox("defectcount===> " & defectcount)
                    md.update_Defect_Count(configposition, defectcount, num_user(0), timenow, NG)
                    ' MsgBox("2222222222222222222")
                End If

                qrproduct = ""
                productcount = productcount - 1
                productcountNG = productcountNG + 1
                md.update_flg_product(productid)
                'j -= 1
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
    End Function

    Public Function nondmc()
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

            Dim insertng = md.insert_Info_Defect(Defectgroupid, productid, NG, num_user(0))
            Dim getdefectcount = md.get_DataDefectCount(Defectgroupid, timenow, NG)
            If getdefectcount = "0" Then
                'MsgBox("111111111111111111")
                md.insert_info_part_count(Defectgroupid, NG, "1", num_user(0), Module1.qgate_part_no)
            Else
                Dim defectcount
                Dim dict10 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(getdefectcount)
                For Each item As Object In dict10
                    defectcount = item("idc_count").ToString
                Next
                defectcount += 1
                md.update_Defect_Count(Defectgroupid, defectcount, num_user(0), timenow, NG)
                ' MsgBox("2222222222222222222")
            End If


            qrproduct = ""
            productcount = productcount - 1
            productcountNG = productcountNG + 1
            md.update_flg_product_Manual(tagid, CbNumProduct.SelectedItem)
            qgateOperationManual.Show()
            qgateOperationManual.tbCounterNg.Text = productcountNG
            qgateOperationManual.tbCounter.Text = productcount
            Me.Close()
        Else
            MsgBox("ตัวที่ต้องการกด NG")
        End If

    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        gotooperation()
    End Sub


    Public Function gotooperation()
        If Type = "1" Then
            dmc()
            If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                qgateOperation.btnFinish.Show()

            Else
                qgateOperation.btnFinish.Hide()

            End If


        ElseIf Module1.dmcornondmc = "dmc" And Type = "3" Then
            dmc()
            If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                qgateOperation.btnFinish.Show()

            Else
                qgateOperation.btnFinish.Hide()

            End If

        ElseIf Module1.dmcornondmc = "nondmc" And Type = "3" Then
            nondmc()
            If CDbl(Val(Trim(productcount))) = CDbl(Val(Trim(partasnp))) Then
                qgateOperationManual.btnFinish.Show()

            Else
                qgateOperationManual.btnFinish.Hide()

            End If

        ElseIf Type = "2" Then
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
            qgateOperation.tbCounterNg.Text = productcountNG
            qgateOperation.tbcounter.Text = productcount
            Me.Close()

        ElseIf Module1.dmcornondmc = "dmc" And Type = "3" Then

            qgateOperation.Show()
            qgateOperation.tbCounterNg.Text = productcountNG
            qgateOperation.tbcounter.Text = productcount
            Me.Close()
        ElseIf Module1.dmcornondmc = "nondmc" And Type = "3" Then

            qgateOperationManual.Show()
            qgateOperationManual.tbCounterNg.Text = productcountNG
            qgateOperationManual.tbCounter.Text = productcount
            Me.Close()
        ElseIf Type = "2" Then

            qgateOperationManual.Show()
            qgateOperationManual.tbCounterNg.Text = productcountNG
            qgateOperationManual.tbCounter.Text = productcount
            Me.Close()
        Else
            MsgBox("ติดต่อแอดมิน")

        End If
    End Function

End Class