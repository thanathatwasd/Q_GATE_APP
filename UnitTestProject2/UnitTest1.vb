Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Q_Gate_App
<TestClass()> Public Class UnitTest1
    ''เทสการเข้าสู่ระบบ
    '<TestMethod()> Public Sub TestMethod1()
    '    Dim obj = New qgateLogin
    '    MsgBox("11")
    '    Dim rs As Boolean = obj.checkLogin("X0070")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub
    ''เทสการเข้าสู่ระบบ

    'เทสการแอดพนักงาน
    '<TestMethod()> Public Sub TestMethod2()
    '    Dim obj As New qgateAddUser
    '    Dim rs As Boolean = obj.checkuser1("X0070")
    '    Dim msgBoxResult = MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub



    'เทสการออกจากระบบ เวลาต้องตรงกับเวลาล็อคอินเอามาเช็คเพื่ออัพเดทการล็อคเอ้าท์
    '<TestMethod()> Public Sub TestMethod2()
    '    Dim obj As New qgateSelectMenu
    '    Dim rs As Boolean = obj.updateactive("2", "2023-01-13 09:25")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub


    ''เทสการเข้าสู่ระบบแอดมิน
    '<TestMethod()> Public Sub TestMethod2()
    '    Dim obj As New qgateLoginAdmin
    '    Dim rs As Boolean = obj.checkLoginAdmin("X0070")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub
    ''เทสการเข้าสู่ระบบแอดมิน


    ''เทสการออกจากระบบแอดมิน เวลาต้องตรงกับเวลาล็อคอินเอามาเช็คเพื่ออัพเดทการล็อคเอ้าท์
    '<TestMethod()> Public Sub TestMethod2()
    '    Dim obj As New qgateMenuAdmin
    '    Dim rs As Boolean = obj.updateactive("1", "2023-01-13 09:19")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub

    ''เทสดึงphase
    '<TestMethod()> Public Sub TestMethod3()
    '    Dim obj As New qgateSettingPosition
    '    Dim rs As Boolean = obj.getStation()
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub
    ''เทสดึงphase


    ''เทสดึงโซน
    '<TestMethod()> Public Sub TestMethod4()
    '    Dim obj As New qgateSettingPosition
    '    Dim rs As Boolean = obj.getZone("TBKK Thailand Phase 10")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub
    ''เทสดึงโซน


    ''เทสดึงสเตชั่น
    '<TestMethod()> Public Sub TestMethod5()
    '    Dim obj As New qgateSettingPosition
    '    Dim rs As Boolean = obj.getStation("TBKK Thailand Phase 10", "Bearing")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub
    ''เทสดึงสเตชั่น


    ''เทสดึงเมนู
    '<TestMethod()> Public Sub TestMethod6()
    '    Dim obj As New qgateSelectMenu
    '    Dim rs As Boolean = obj.getmenu("X0071")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub
    ''เทสดึงเมนู


    ''เทสดึงpart_no
    '<TestMethod()> Public Sub TestMethod5()
    '    Dim obj As New qgateSelectPart
    '    Dim rs As Boolean = obj.getpartname("SB025400004-B")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub


    'เทส scan TAG
    '<TestMethod()> Public Sub TestMethod5()
    '    Dim obj As New qgateScanTag
    '    Dim rs As Boolean = obj.scanTagSubString("GBK2M1072023011700249373-20500              20230116    12CA16                         2023011600252019", "49373-20500")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub


    'เทส select Part
    '<TestMethod()> Public Sub TestMethod5()
    '    Dim obj As New qgateSelectPart
    '    Dim rs As Boolean = obj.getpartname("SB025400004-B")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub


    'เทสแสกน qr product

    '<TestMethod()> Public Sub TestMethod5()
    '    Dim obj As New qgateOperation
    '    ถ้าเทส ต้อวใส่ในหน้า module
    'Public dmcqrscan As String = "SB01F40000001"
    '    Public tagfa As String = "GBK1M13720220104002SB025400004-B            20220105     6BA04                         2022010500251028"
    '    Public partnamedigit As String = "Bearing"
    '    Dim rs As Boolean = obj.substringqrproduct("SB01F40000001123121212140", "SB025400004-B")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub


    '<TestMethod()> Public Sub TestMethod6()
    '    Dim obj As New qgateReprintTag
    '    Dim rs As Boolean = obj.loadpartno("1", "2", "2023-02-20")
    '    MsgBox("rs===>" & rs)
    '    Assert.AreNotEqual(False, rs)
    'End Sub
End Class