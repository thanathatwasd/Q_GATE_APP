Public Class ModelVB
    Public rsDatabaseServer
    Public rsLocalhost As String = ""
    Public Function mGetData()
        Dim Api As New api()
        Dim rs = Api.Load_data(" http://192.168.161.77/apiShopfloor/getDatadefect/getDefectcode")
        MsgBox(rs)
    End Function


    ''' GETDATA
    Public Function get_DatabaseServer()
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        rsDatabaseServer = Api.Load_data("http://192.168.161.77/apiQgate/getdata/getDatabaseServerName")
        'MsgBox(rs)
        Return rsDatabaseServer
    End Function
    Public Function get_LocalHost()
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        rsLocalhost = Api.Load_data("http://192.168.161.77/apiQgate/getdata/getLocalHost")
        'MsgBox("LOCALHOST ===> " & rsLocalhost)
        'MsgBox("rsLocalhost===> " & rsLocalhost)
        Return rsLocalhost
    End Function

    Public Function get_DataUser(name As String)
        'MsgBox("name===> " & name)
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getUser?name=" & name
        ' MsgBox("hhh->" & URL)
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function
    Public Function get_DataAdmin(name As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getAdmin?name=" & name
        ' MsgBox(URL)
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function


    Public Function get_DataPhase()
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getPhase"
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs
    End Function

    Public Function get_DataZone(phase As String)
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getZone?phase=" & phase
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs
    End Function


    Public Function get_WorkShoftTime(timeshift As String)
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getWorkShift?timeshift=" & timeshift
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs
    End Function

    Public Function get_DataPosition(phase As String, zone As String)
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getPosition?phase=" & phase & "&zone=" & zone
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs
    End Function

    Public Function get_TypeByPosition(phase As String, zone As String, station As String)
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getTypeByPosition?phase=" & phase & "&zone=" & zone & "&station=" & station
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs
    End Function
    Public Function get_DataPart()

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getSelectPart"
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function

    Public Function get_DataPartName(name As String)


        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getSelectPartName?name=" & name
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs


    End Function

    Public Function get_PartTagFA(partno As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getPartTagFA?partno=" & partno
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function


    Public Function get_OldTagFa(oldtag As String)


        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getOldTag?oldtag=" & oldtag
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs


    End Function

    Public Function get_PartSubString(partno As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getSubString?partno=" & partno
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function


    Public Function get_IdWorkShift(workshift As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getIdWorkShift?workshift=" & workshift
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function

    Public Function get_IdTagfa(tagfa As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getIdTagfa?tagfa=" & tagfa
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function


    Public Function get_IdDigit(namedigit As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getIddigit?namedigit=" & namedigit
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function

    Public Function get_DataMenu(staffname As String)
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getMenu?staffname=" & staffname
        'MsgBox("get_DataMenu--->" & URL)
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs
    End Function

    Public Function get_Info_part(partname As String, dodate As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getPartInfo?partname=" & partname & "&dodate=" & dodate
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_Code_master(codemaster As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost & "/apiQgate/getdata/getPartCodeMaster?codemaster=" & codemaster
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_ID_Tag_fa(tagfa As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getIdTagfa?tagfa=" & tagfa
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_id_Digitname(namedigit As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getIddigit?namedigit=" & namedigit
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function



    Public Function get_QrProduct(qrproduct As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getQrProduct?qrproduct=" & qrproduct
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function


    Public Function get_ProductID(productid As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getQProductId?productid=" & productid
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function

    Public Function get_During_Time(stationid As String, workdate As String, workshift As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getDuringTime?stationid=" & stationid & "&workdate=" & workdate & "&workshift=" & workshift
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function



    'Public Function get_During_Time_Worker(stationid As String, workdate As String, workshift As String)

    '    Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
    '    Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getDuringTimeInsertWorker?stationid=" & stationid & "&workdate=" & workdate & "&workshift=" & workshift
    '    Dim rs = Api.Load_data(URL)
    '    'MsgBox("RS===>" & rs)
    '    Return rs


    'End Function

    Public Function get_DataDefect()

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getDefect"
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function

    Public Function get_DataDefect(defectcode As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getdefectID?defectcode=" & defectcode
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function
    Public Function get_DataDefectGroup(stationid As String, defectid As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getDefectGroup?stationid=" & stationid & "&defectid=" & defectid
        Dim rs = Api.Load_data(URL)

        Return rs


    End Function










    ''INSERT DATA
    Public Function insert_active_login(idstaff As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertloglogin?idstaff=" & idstaff
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function
    Public Function insert_log_part(part As String, name As String)



        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertlogpart?part=" & part & "&name=" & name
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function
    Public Function insert_info_part(partid As String, partcount As String, staffname As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertPartInfo?partid=" & partid & "&partcount=" & partcount & "&staffname=" & staffname
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function




    Public Function insert_tag_fa(codemaster As String, tagfa As String, linecd As String, plandate As String, seqplan As String, partno As String, actualdate1 As String, snp As String, lotno As String, actualdate2 As String, seqactual As String, plant As String, box As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertTAGFA?codemaster=" & codemaster & "&tagfa=" & tagfa &
                               "&linecd=" & linecd & "&plandate=" & plandate & "&seqplan=" & seqplan &
                               "&partno=" & partno & "&actualdate1=" & actualdate1 & "&snp=" & snp &
                               "&lotno=" & lotno & "&actualdate2=" & actualdate2 & "&seqactual=" & seqactual &
                               "&plant=" & plant & "&box=" & box
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function


    Public Function insert_qr_product(oldtagfaid As String, stationid As String, partdigit As String, workshift As String, productcount As String, productrank As String, productcheckcount As String, productqr As String, staffcode As String, counttime As String)
        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertQRProduct?oldtagfaid=" & oldtagfaid & "&stationid=" & stationid &
                               "&partdigit=" & partdigit & "&workshift=" & workshift &
                               "&productcount=" & productcount & "&productrank=" & productrank &
                               "&productcheckcount=" & productcheckcount &
                               "&productqr=" & productqr & "&staffcode=" & staffcode & "&counttime=" & counttime
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function

    Public Function insert_during_time(stationid As String, workshift As String, workdate As String, staffname As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertDuringTime?stationid=" & stationid & "&workshift=" & workshift & "&workdate=" & workdate & "&staffname=" & staffname
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function



    Public Function insert_staff_worker(duringtimeid As String, staffname As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertStaffWorker?duringtimeid=" & duringtimeid & "&staffname=" & staffname
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function

    Public Function insert_Info_Defect(defectid As String, qrid As String, numng As String, staffname As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertInfoDefect?defectid=" & defectid & "&qrid=" & qrid & "&numng=" & numng & "&staffname=" & staffname
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function insert_Defect_Count(stationid As String, defectcodeid As String, numdefect As String, staffname As String, ngornc As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertDefectcount?stationid=" & stationid & "&defectcodeid=" & defectcodeid & "&numdefect=" & numdefect & "&staffname=" & staffname & "&ngornc=" & ngornc
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function













    ''UPDATE DATA
    Public Function update_active_logout(id As String, datetime As String)

        Dim Api As New api()
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/updatedata/updateactive?id=" & id & "&datetime=" & datetime
        Dim rs = Api.Load_data(URL)
        Return rs
    End Function

    Public Function update_info_part(partid As String, partcount As String, staffname As String, dodate As String)

        Dim Api As New api()
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/updatedata/updateInfoPart?partid=" & partid & "&partcount=" & partcount & "&staffname=" & staffname & "&dodate=" & dodate
        Dim rs = Api.Load_data(URL)
        Return rs
    End Function


    Public Function update_info_part(oldtagfaid As String, stationid As String, workshift As String, productcount As String, productcheckcount As String, staffcode As String, productqr As String, timecheck As String)

        Dim Api As New api()
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/updatedata/updateQRProduct?oldtagfaid=" & oldtagfaid & "&stationid=" & stationid & "&workshift=" & workshift &
            "&productcount=" & productcount & "&productcheckcount=" & productcheckcount & "&staffcode=" & staffcode & "&productqr=" & productqr & "&timecheck=" & timecheck
        Dim rs = Api.Load_data(URL)
        Return rs
    End Function


    Public Function update_during_time(lotdate As String, staffname As String, stationid As String, workdate As String, workshift As String)

        Dim Api As New api()
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/updatedata/updateDuringTime?lotdate=" & lotdate & "&staffname=" & staffname & "&stationid=" & stationid & "&workdate=" & workdate & "&workshift=" & workshift
        Dim rs = Api.Load_data(URL)
        Return rs
    End Function


    Public Function update_flg_product(productid As String)

        Dim Api As New api()
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/updatedata/updateFlgProduct?productid=" & productid
        Dim rs = Api.Load_data(URL)
        Return rs
    End Function


    Public Function update_flg_product_Manual(tagfa As String, productcount As String)

        Dim Api As New api()
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/updatedata/updateFlgProductManual?tagfa=" & tagfa & "&productcount=" & productcount
        Dim rs = Api.Load_data(URL)
        Return rs
    End Function










    ''เครื่องใหม่



    Public Function get_Phase_Zone(phase As String, zone As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getIdPhaseAndZone?phase=" & phase & "&zone=" & zone
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function
    Public Function get_PartNoTo_Reprint(phase As String, zone As String, dateselect As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getPartNOToReprintTag?phase=" & phase & "&zone=" & zone & "&dateselect=" & dateselect
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function


    Public Function get_PartNoTo_Reprint_Defect(dateselect As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getPartNOToReprintDefect?dateselect=" & dateselect
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_LotNoTo_Reprint(phase As String, zone As String, dateselect As String, parno As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getLotNoToReprintTag?phase=" & phase & "&zone=" & zone & "&dateselect=" & dateselect & "&parno=" & parno
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_LotNoTo_Reprint_Defect(dateselect As String, partno As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getLotNoToReprintDefect?dateselect=" & dateselect & "&partno=" & partno
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_BoxNoTo_Reprint(phase As String, zone As String, dateselect As String, parno As String, lotno As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getBoxNoToReprintTag?phase=" & phase & "&zone=" & zone & "&dateselect=" & dateselect & "&parno=" & parno & "&lotno=" & lotno
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_BoxNoTo_Reprint_Defect(dateselect As String, parno As String, lotno As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getBoxNoToReprintDefect?dateselect=" & dateselect & "&parno=" & parno & "&lotno=" & lotno
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function




    Public Function get_Data_Scan_Print(tagqgate As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getDataScanPrint?tagqgate=" & tagqgate
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function


    Public Function get_Data_Scan_Print_Defect(tagdefect As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getDataScanPrintDefectByTag?tagdefect=" & tagdefect
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_Mac_Address(macaddress As String)

        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getMacAddress?macaddress=" & macaddress
        Dim rs = Api.Load_data(URL)
        'MsgBox("RS===>" & rs)
        Return rs


    End Function

    Public Function get_Zone_Set_menu(zone As String)


        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getZoneSetMenu?zone=" & zone
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs


    End Function

    Public Function get_Tag_By_Qrproduct(qrproduct As String)


        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/getdata/getTagByQrProduct?qrproduct=" & qrproduct
        Dim rs = Api.Load_data(URL)
        'MsgBox(rs)
        Return rs


    End Function



    Public Function insert_log_reprint(tagconpleteid As String, empcode As String)



        Dim Api As New api() 'สร้าง ฟังก์ชั่นมา ด้านนหลังคือชื่อคลาส *ชื่อ class กับ func ต้องเหมือนกันเสมอ
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/insertdata/insertlogreprint?tagconpleteid=" & tagconpleteid & "&empcode=" & empcode
        Dim rs = Api.Load_data(URL)

        Return rs
    End Function


    Public Function update_config_macaddress(phase As String, zone As String, station As String, macaddress As String, empcode As String)

        Dim Api As New api()
        Dim URL = "http://" & get_LocalHost() & "/apiQgate/updatedata/updateConfigMacAddress?phase=" & phase & "&zone=" & zone & "&station=" & station & "&macaddress=" & macaddress & "&empcode=" & empcode
        Dim rs = Api.Load_data(URL)
        Return rs
    End Function
End Class
