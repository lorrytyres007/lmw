Imports System
Imports System.Collections
Imports System.Management
Public Class MainForm
    Dim View_Form As Form
    Public Add_Form As Form

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End
    End Sub
    Public Function fileExists(ByVal sFILENAME As String) As Boolean
        fileExists = CBool(Len(Dir$(sFILENAME))) And CBool(Len(sFILENAME))
    End Function
    Public Function findserial()
        ' Get Harddisk Serial Number  
        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
        For Each wmi_HD As ManagementObject In searcher.Get()
            MessageBox.Show(wmi_HD("SerialNumber"))
        Next
        Return Nothing
    End Function

    'Private Function checkHd()
    '    Try
    '        'Dim hdCollection As New ArrayList()
    '        'Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
    '        'Dim wmi_HD As New ManagementObject()
    '        'For Each wmi_HD In searcher.Get

    '        '    Dim hd As New Class1.HardDrive()

    '        '    hd.Model = wmi_HD("Model").ToString()
    '        '    hd.Type = wmi_HD("InterfaceType").ToString()
    '        '    hdCollection.Add(hd)
    '        'Next
    '        'Dim searcher1 As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")


    '        'Dim i As Integer = 0
    '        'For Each wmi_HD In searcher1.Get()

    '        '    '// get the hard drive from collection
    '        '    '// using index

    '        '    Dim hd As Class1.HardDrive
    '        '    hd = hdCollection(i)


    '        '    '// get the hardware serial no.
    '        '    If wmi_HD("SerialNumber") = "" Then
    '        '        hd.serialNo = ""
    '        '    Else
    '        '        hd.serialNo = wmi_HD("SerialNumber").ToString()
    '        '        i += 1
    '        '    End If
    '        'Next

    '        'Dim hd1 As Class1.HardDrive
    '        'Dim ii As Integer = 0

    '        'For Each hd1 In hdCollection
    '        '    ii += 1
    '        '    NodeSerial = Trim(NodeSerial + hd1.serialNo)
    '        'Next
    '        'If Len(NodeSerial) > 16 Then
    '        '    Serial = Encode(Mid$(NodeSerial, 1, 16))
    '        '    serial2 = Encode(Serial)
    '        'Else
    '        '    Serial = Encode(NodeSerial)
    '        '    serial2 = Encode(Serial)
    '        'End If

    '        Dim abc As String = ""

    '        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
    '        For Each wmi_HD As ManagementObject In searcher.Get()
    '            abc = wmi_HD("SerialNumber")
    '            If Len(abc) > 0 Then
    '                Exit For
    '            End If
    '        Next
    '        If Len(abc) > 16 Then
    '            Serial = Encode(Mid$(abc, 1, 16))
    '            serial2 = Encode(Serial)
    '        Else
    '            Serial = Encode(abc)
    '            serial2 = Encode(Serial)
    '        End If

    '        abc = ""
    '        For ai As Integer = 1 To Len(serial2) Step 4
    '            abc += Mid(serial2, ai, 4)
    '            If (ai < 10) Then
    '                abc += "-"
    '            End If

    '        Next
    '        serial2 = abc

    '        Dim sssuser As String = objDScal("select Information from tbl_Srichu where information='" & Encode(serial2) & "'")

    '        If sssuser = Nothing Then
    '            RegistrationForm.ShowDialog()
    '        End If

    '        If Encode(serial2) <> sssuser Then
    '            RegistrationForm.ShowDialog()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
    '    End Try

    'End Function

    Private Function checkHd()
        Try

            Dim hdCollection As New ArrayList()
            Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
            Dim wmi_HD As New ManagementObject()

            For Each wmi_HD In searcher.Get
                Dim hd As New Class1.HardDrive()
                hd.Model = wmi_HD("Model").ToString()
                hd.Type = wmi_HD("InterfaceType").ToString()
                hdCollection.Add(hd)
            Next

            Dim searcher1 As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
            Dim i As Integer = 0
            For Each wmi_HD In searcher1.Get()

                Dim hd As Class1.HardDrive
                hd = hdCollection(i)

                If wmi_HD("SerialNumber") = "" Then
                    hd.serialNo = ""
                Else
                    hd.serialNo = wmi_HD("SerialNumber").ToString()
                    i += 1
                End If
            Next

            Dim hd1 As Class1.HardDrive
            Dim ii As Integer = 0

            Dim abc As String = ""

            For Each hd1 In hdCollection
                ii += 1
                abc = Trim(abc + hd1.serialNo)
                NodeSerial = Trim(NodeSerial + hd1.serialNo)
            Next


            If Len(abc) > 16 Then
                Serial = Encode(Mid$(Trim(abc), 1, 16))
                serial2 = Encode(Serial)
            Else
                Serial = Encode(Trim(abc))
                serial2 = Encode(Trim(Serial))
            End If
            abc = ""
            For ai As Integer = 1 To Len(serial2) Step 4
                abc += Mid(serial2, ai, 4)
                If (ai < 10) Then
                    abc += "-"
                End If

            Next
            serial2 = abc
            Enc2 = Encode(Trim(serial2))
            Dim sssuser As String = objDScal("select Information from tbl_Srichu where information='" & Trim(enc2) & "'")

            If sssuser = Nothing Then
                RegistrationForm.ShowDialog()
            End If
            If sssuser <> Encode(serial2) Then
                RegistrationForm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
        Return Nothing
    End Function
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'lblCompanyName.Font = New Font("Bamini", 20)
        lblCompanyName.Text = "SWAS TECHNOLOGIES"        '_Company.CompanyName("")


        'If fileExists("C:\Windows\SWASRESCUE.dll") = False Then
        '    MsgBox("CALL YOUR PROGRAM VENDOR...Need Service Compulsory...Error (&F0007854)", MsgBoxStyle.Information, Mssg)
        '    End
        'End If
        int_UserCode = 0
        int_CompanyCode = 0
        tslSocietyCode.Text = int_CompanyCode
        tslFontName.Text = str_TamilFont
        If int_UserCode = 0 Then LoginForm.ShowDialog()
        MenuVisible(True)
        If int_UserLevel = 1001 Then
            mnuYearEndProcess.Visible = True
        Else
            mnuYearEndProcess.Visible = False
        End If




        'checkHd()
        '--------Rights Block------------
        If int_UserLevel = 2 Then
            'int_CompanyCode = IIf(str_Company = "H", 1, 2)
            'int_FYCode = objDScal("sp_Get_CurrentFYear")
            '--------------SET User Rights----------------
            MenuVisible(False)

            Dim objUserTable As DataTable = objDT("sp_UserRights_GetByUserCode @UserCode=" & int_UserCode)
            For RowIndex As Integer = 0 To objUserTable.Rows.Count - 1
                SetMenu(objUserTable.Rows(RowIndex)("MenuName"))
            Next
            mnuReports.Visible = True
            mnuRptMaster.Visible = True
            mnuGroupEntries.Visible = True
            mnuHeadEntries.Visible = True
            mnuMemberEntries.Visible = True

            mnuHelp.Visible = True
            mnuBackup.Visible = True
            mnuLogout.Visible = True
            mnuExit.Visible = True
        Else
            MenuVisible(True)
        End If
        FindUpdates()
        If int_CompanyCode = 0 Then CompanySelection.ShowDialog()
        fun_CompanyDetails(int_CompanyCode)
        'lblCompanyName.Font = New Font(str_TamilFont, 24)
        Mssg = "LMW Ver 3.1"
    End Sub

    Public Sub fun_CompanyDetails(ByVal CompanyCode As Integer)
        Try
            Dim objDTable As DataTable = objDT("sp_Company_GetAll @CompanyCode=" & CompanyCode)
            If objDTable.Rows.Count > 0 Then
                _Company.CompanyName = objDTable.Rows(0)("CompanyName").ToString
                _Company.ShortName = objDTable.Rows(0)("ShortName").ToString
                _Company.Address1 = objDTable.Rows(0)("Address1").ToString
                _Company.Address2 = objDTable.Rows(0)("Address2").ToString
                _Company.City = objDTable.Rows(0)("City").ToString
                _Company.District = objDTable.Rows(0)("District").ToString
                _Company.PinCode = objDTable.Rows(0)("PinCode").ToString
                _Company.PhoneNo = objDTable.Rows(0)("PhoneNo").ToString
                _Company.MobileNo = objDTable.Rows(0)("MobileNo").ToString
                _Company.Website = objDTable.Rows(0)("Website").ToString
                _Company.EMail = objDTable.Rows(0)("EMail").ToString
                _Company.TINNo = objDTable.Rows(0)("TINNo").ToString
                _Company.CSTNo = objDTable.Rows(0)("CSTNo").ToString
                _Company.SighningAuthority = objDTable.Rows(0)("SighningAuthority").ToString
            End If
            tslBranchname.Text = str_Branchname
            tslDate.Text = Format(CurDate, "dd/MM/yyyy")
            lblCompanyName.Text = _Company.CompanyName
            tslFY.Text = objDScal("sp_FYear_GetByFYCode " & int_FYearCode)
            objDTable.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MenuVisible(ByVal Visible As Boolean)
        Dim t As ToolStripMenuItem
        Dim OpnMenu As Integer = 0
        For Each c As ToolStripItem In MenuStrip1.Items
            OpnMenu += 1
            c.Visible = Visible
            If c.GetType Is GetType(ToolStripMenuItem) Then
                t = c
                MenuVisible(t.DropDownItems, Visible)
            End If
        Next
    End Sub

    Private Sub MenuVisible(ByRef menus As ToolStripItemCollection, ByVal Visible As Boolean)
        Dim c As ToolStripItem
        Dim t As ToolStripMenuItem
        For Each c In menus
            c.Visible = Visible
            If c.GetType Is GetType(ToolStripMenuItem) Then
                t = c
                MenuVisible(t.DropDownItems, Visible)
            End If
        Next
    End Sub

    Private Sub SetMenu(ByVal MenuName As String)
        Dim t As ToolStripMenuItem
        For Each c As ToolStripItem In MenuStrip1.Items
            If c.Name = MenuName Then c.Visible = True : Exit For
            If c.GetType Is GetType(ToolStripMenuItem) Then
                t = c
                SetMenu(t.DropDownItems, MenuName)
            End If
        Next
    End Sub

    Private Sub SetMenu(ByRef menus As ToolStripItemCollection, ByVal MenuName As String)
        Dim c As ToolStripItem
        Dim t As ToolStripMenuItem
        For Each c In menus
            If c.Name = MenuName Then c.Visible = True : Exit For
            If c.GetType Is GetType(ToolStripMenuItem) Then
                t = c
                SetMenu(t.DropDownItems, MenuName)
            End If
        Next
    End Sub

    Private Sub mnuLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogout.Click
        int_UserLevel = 0
        int_UserCode = 0
        tslUserName.Text = ""
        Main_Load(sender, e)
    End Sub

    Private Sub mnuMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMember.Click
        ShowForm(frmMemberDetails)
    End Sub

    Private Sub mnuChangeSociety_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CompanySelection.btnCreate.Enabled = False
        CompanySelection.ShowDialog()
    End Sub

    Private Sub mnuGroupDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGroupDetails.Click
        ShowForm(frmGroupDetails)
    End Sub

    Private Sub mnuLedgerDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLedgerDetails.Click
        ShowForm(frmHeadDetails)
    End Sub

    Private Sub mnuNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewUser.Click
        ShowForm(frmUserDetails)
    End Sub

    Private Sub mnuSocietyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(frmCompanyDetails)
    End Sub

    Private Sub mnuDAYBOOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDAYBOOK.Click
        ShowForm(rptDayBook)
    End Sub
    Private Sub mnuOtherEntries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(frmVoucherEntry)
    End Sub

    Private Sub mnuLedgerBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLedgerBook.Click
        ShowForm(rptLedgerAbstract)
    End Sub

    Private Sub rptmnuMonthlyRD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptmnuMonthlyRD.Click
        ShowForm(rptMonthlyRD)
    End Sub

    Private Sub mnuYearEndProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYearEndProcess.Click
        ShowForm(frmYearEndProcess)
    End Sub

    Private Sub mnuBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBackup.Click
        Initialise_Connection()
        Dim str_FileName = "LMWBackup" + Str(Now.Day) + "-" + Str(Now.Month) + "-" + Str(Now.Year) + "_" + Str(Now.Hour) + "." + Str(Now.Minute) + "." + Str(Now.Second)
        objDT("BACKUP DATABASE [LMW] TO  DISK = N'D:\backups\" & str_FileName & "' WITH  EXPIREDATE = N'" & SD(Now) & "', NOFORMAT, NOINIT,  NAME = N'LMW-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
        MsgBox("Backup Data Successfully...", MsgBoxStyle.Information, Mssg)
    End Sub

    Private Sub mnuVoucherEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVoucherEntry.Click
        ShowForm(frmVoucherEntry)
    End Sub

    Private Sub mnuThriftDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThriftDeposit.Click
        ShowForm(frmThriftDeposit)
    End Sub

    Private Sub mnuGroupEntries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGroupEntries.Click
        ShowForm(rptGroupList)
    End Sub

    Private Sub mnuHeadEntries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHeadEntries.Click
        ShowForm(rptHeadList)
    End Sub

    Private Sub mnuMemberEntries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMemberEntries.Click
        ShowForm(rptMemberList)
    End Sub

    Private Sub mnuLedgerAbstract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLedgerAbstract.Click
        ShowForm(rptLedgerBook)
    End Sub

    Private Sub rptThriftDepositCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptThriftDepositCollection.Click
        ShowForm(rptTDCollection)
    End Sub

    Private Sub mnuThriftDepositGroupReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowForm(frmThriftDepositGroup)
    End Sub

    Private Sub mnuClossingthriftdeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClossingthriftdeposit.Click
        ShowForm(frmTDClossingDetails)
    End Sub

    Private Sub rptThriftDepositClossing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptThriftDepositClossing.Click
        ShowForm(rptTDClossing)
    End Sub

    Private Sub mnuThriftDepositInterestPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThriftDepositInterestPosting.Click
        ShowForm(frmTDInterestDetails)
    End Sub

    Private Sub mnuThriftDepositRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThriftDepositRefund.Click
        ShowForm(rptTDRefund)
    End Sub

    Private Sub mnuShareDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShareDeposit.Click
        ShowForm(frmShareDeposit)
    End Sub

    Private Sub mnuShareDividentPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShareDividentPosting.Click
        ShowForm(frmShareDivident)
    End Sub

    Private Sub mnuClossingRefundShareDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClossingRefundShareDeposit.Click
        ShowForm(frmShareClossingDetails)
    End Sub

    Private Sub mnuTrailBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrailBalance.Click
        ShowForm(rptTrailBalance)
    End Sub

    Private Sub mnuLoanDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLoanDetails.Click
        ShowForm(frmLoanDetails)
    End Sub

    Private Sub mnuMemberLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMemberLoan.Click
        ShowForm(frmMemberLoanDetails)
    End Sub

    Private Sub mnuShareCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShareCollection.Click
        ShowForm(rptShareCollection)
    End Sub

    Private Sub mnuShareClossing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShareClossing.Click
        ShowForm(rptShareClossing)
    End Sub

    Private Sub rptShareRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptShareRefund.Click
        ShowForm(rptShareRefund)
    End Sub

    Private Sub UserRightsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserRights.Click
        ShowForm(frmUserRights)
    End Sub

    Private Sub mnuStaffLoanDemand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStaffLoanDemand.Click
        ShowForm(frmStaffLoanDemand)
    End Sub

    Private Sub mnurptMemberloanList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptMemberloanList.Click
        ShowForm(rptLoanDetails)
    End Sub

    Private Sub mnuWorkersLoanDemand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWorkersLoanDemand.Click
        ShowForm(frmWorkersLoanDemand)
    End Sub

    Private Sub mnuCollStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCollStaff.Click
        ShowForm(frmStaffLoanCollection)
    End Sub

    Private Sub mnuCollWorkers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCollWorkers.Click
        ShowForm(frmWorkerLoanCollection)
    End Sub

    Private Sub mnurptShareDivident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnurptShareDivident.Click
        ShowForm(rptShareDivident)
    End Sub

    Private Sub mnuUpdationLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdationLock.Click
        ShowForm(frmUpdationLock)
    End Sub

    Private Sub mnuLoanPassBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLoanPassBook.Click
        ShowForm(rptLoanPassBook)
    End Sub

    Private Sub LoanDemandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanDemandToolStripMenuItem.Click
        ShowForm(frmLoanDemand)
    End Sub

    Private Sub mnuLoanEMIChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLoanEMIChange.Click
        ShowForm(frmEMI_ChangeDetails)
    End Sub

    Private Sub mnuTDPassBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTDPassBook.Click
        ShowForm(rptTDPassBook)
    End Sub

    Private Sub mnuSHAREPassBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSHAREPassBook.Click
        ShowForm(rptSharePassBook)
    End Sub

    Private Sub rptLoanCollectionReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptLoanCollectionReport.Click
        ShowForm(frmLoanCollection)
    End Sub

    Private Sub mnuStaffCorrections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStaffCorrections.Click
        ShowForm(frmStaffDemandAlter)
    End Sub

    Private Sub mnuWorkersCorrections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWorkersCorrections.Click
        ShowForm(frmWorkerDemandAlter)
    End Sub
End Class