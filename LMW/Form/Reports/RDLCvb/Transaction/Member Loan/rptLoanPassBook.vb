Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptLoanPassBook

    Private Sub rptLoanPassBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bind_Data()
    End Sub

    Private Sub Bind_Data()
        'cmbMemberType.SelectedIndex = 0
        'cmbLoanName.RecordSet(objDT("sp_LoanName_GetAll"), "LoanName", "LoanNameCode")
        cmbEmployeeNumber.RecordSet(objDT("sp_LoanMember_GetAll"), "strEmpNo", "MemberCode")
        cmbLoanNumber.RecordSet(objDT("sp_MemberLoan_GetAll"), "strLoanNumber", "LoanCode")
    End Sub

    Private Sub cmbLoanName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cmbLoanName.SelectedIndex > 0 Then
        '    Dim optStaff As Integer = 1
        '    Dim optWorker As Integer = 1
        '    Dim optOther As Integer = 1
        '    If cmbMemberType.SelectedIndex = 0 Then
        '        optStaff = 1
        '        optWorker = 1
        '        optOther = 1
        '    ElseIf cmbMemberType.SelectedIndex = 1 Then
        '        optStaff = 1
        '        optWorker = 0
        '        optOther = 0
        '    ElseIf cmbMemberType.SelectedIndex = 2 Then
        '        optStaff = 0
        '        optWorker = 1
        '        optOther = 0
        '    Else
        '        optStaff = 0
        '        optWorker = 0
        '        optOther = 1
        '    End If
        'objDT("SP_MEMBER_GETALL @STAFF=" & optStaff & ",@WORKER=" & optWorker & ",@OTHER=" & optOther)
        'cmbEmployeeNumber.RecordSet(objDT("select CONVERT(varchar, EmployeeNumber) AS strEmpNo,* from tbl_MemberReport where membercode in (select memberCode from vw_MemberLoan where loannamecode=" & cmbLoanName.ColData("LoanNameCode") & ")"), "strEmpNO", "MemberCode")
        'cmbLoanNumber.RecordSet(objDT("select * from vw_MemberLoan where LoanNameCode =" & cmbLoanName.ColData("LoanNameCode")), "strLoanNumber", "LoanCode")
        'Else
        'cmbEmployeeNumber.RecordSet(objDT("sp_Member_GetAll"), "strEmpNo", "MemberCode")
        'cmbLoanNumber.RecordSet(objDT("select * from vw_MemberLoan where loancode=0"), "strLoanNumber", "LoanCode")
        'End If
    End Sub

    Private Sub cmbEmployeeNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmployeeNumber.SelectedIndexChanged
        If cmbEmployeeNumber.SelectedIndex > 0 Then
            cmbLoanNumber.RecordSet(objDT("sp_MemberLoan_GetAll @MemberCode =" & cmbEmployeeNumber.ColData("MemberCode")), "strLoanNumber", "LoanCode")
            lblEmpName.Text = cmbEmployeeNumber.ColData("MEMBERNAME")
        Else
            cmbLoanNumber.RecordSet(objDT("sp_MemberLoan_GetAll"), "strLoanNumber", "LoanCode")
            lblEmpName.Text = "Employee Name"
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Initialise_Connection()
        If cmbEmployeeNumber.SelectedIndex = 0 Then
            MsgBox("Please Select Employee Number...", MsgBoxStyle.Information, Mssg)
            cmbEmployeeNumber.Focus()
            Exit Sub
        End If
        If cmbLoanNumber.SelectedIndex = 0 Then
            MsgBox("Please Select Loan Number...", MsgBoxStyle.Information, Mssg)
            cmbLoanNumber.Focus()
            Exit Sub
        End If
        If chkDate.Checked = True Then
            If IsDate(dtpTo.Text) = False Then
                MsgBox("Invalid To Date", MsgBoxStyle.Information, Mssg)
                dtpTo.Focus()
                Exit Sub
            End If

            If CDate(dtpTo.Text) < CDate(dtpFrom.Text) Then
                MsgBox("From Date should not be greater than To Date", MsgBoxStyle.Information, Mssg)
                dtpTo.Focus()
                Exit Sub
            End If
            Dim objcommand As New SqlCommand("Update tbl_Collection set printed=0 where loanCode=" & cmbLoanNumber.ColData("LoanCode") & " and MemberCode=" & cmbEmployeeNumber.ColData("MemberCode"), objSqlConnection)
            objcommand.CommandType = CommandType.Text
            objcommand.ExecuteNonQuery()
        End If

        objSqlCommand = New SqlCommand("sp_PassBook", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        If chkDate.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@FromDate", SD(dtpFrom.Value))
            objSqlCommand.Parameters.AddWithValue("@ToDate", SD(dtpTo.Value))
        End If

        If cmbEmployeeNumber.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@MemberCode", cmbEmployeeNumber.ColData("MemberCode"))
        End If

        If cmbLoanNumber.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@LoanCode", cmbLoanNumber.ColData("LoanCode"))
        End If

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_PassBook"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptLoanPassBook.rdlc"

        'Dim params(1) As ReportParameter
        'params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        'params(1) = New ReportParameter("Balanceshow", False, False)
        'rptViewer.LocalReport.SetParameters(params)

        rptViewer.RefreshReport()


    End Sub
    Private Sub fastreport1()
        ' ''Dim objCom As New SqlCommand("sp_PassBook", objSqlConnection)
        ' ''objCom.CommandType = CommandType.StoredProcedure
        ' ''objCom.CommandTimeout = 600
        ' ''If chkDate.Checked = True Then
        ' ''    objCom.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
        ' ''    objCom.Parameters.AddWithValue("@ToDate", dtpTo.Value)
        ' ''End If
        ' ''If cmbEmployeeNumber.SelectedIndex > 0 Then
        ' ''    objCom.Parameters.AddWithValue("@MemberCode", cmbEmployeeNumber.ColData("MemberCode"))
        ' ''End If
        ' ''If cmbLoanNumber.SelectedIndex > 0 Then
        ' ''    objCom.Parameters.AddWithValue("@LoanCode", cmbLoanNumber.ColData("LoanCode"))
        ' ''End If


        ' ''Dim ds As DataSet = objDS(objCom)
        ' ''ds.Tables(0).TableName = "sp_PassBook"

        ' ''Dim bb As FastReport.Report = New FastReport.Report()

        ' ''bb.Load("FReport\rptPassBook.frx")

        ' ''bb.RegisterData(ds)

        ' ''bb.GetDataSource("sp_PassBook").Enabled = True
        ' ''bb.Preview = rptViewer.Viewer
        ' ''bb.Show()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub rptLoanPassBook_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        pnlDate.Enabled = chkDate.Checked
        If chkDate.Checked = True Then
            chkDate.Text = "Date Disable"
        Else
            chkDate.Text = "Date Enable"
        End If
    End Sub


    Private Sub btnFRView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFRView.Click
        Panel4.Enabled = False
        If cmbEmployeeNumber.SelectedIndex = 0 Then
            MsgBox("Select Token No", MsgBoxStyle.Information, Mssg)
            cmbEmployeeNumber.Focus()
            Exit Sub
        End If
        If cmbLoanNumber.SelectedIndex = 0 Then
            MsgBox("Select Loan No", MsgBoxStyle.Information, Mssg)
            cmbLoanNumber.Focus()
            Exit Sub
        End If

        objSqlCommand = New SqlCommand("sp_MemberLoan_GetAll", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        objSqlCommand.Parameters.AddWithValue("@MemberCode", cmbEmployeeNumber.ColData("MemberCode"))
        objSqlCommand.Parameters.AddWithValue("@LoanCode", cmbLoanNumber.ColData("LoanCode"))

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_MemberLoan_GetAll"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptFRLoanPassBook.rdlc"

        rptViewer.RefreshReport()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MsgBox("Is it Printed?... ", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Mssg) = MsgBoxResult.Ok Then
            'objDT("Update tbl_Collection set printed=1 where loanCode=" & cmbLoanNumber.ColData("LoanCode") & " and MemberCode=" & cmbEmployeeNumber.ColData("MemberCode"))
            Initialise_Connection()
            Dim objcommand As New SqlCommand("Update tbl_Collection set printed=1 where loanCode=" & cmbLoanNumber.ColData("LoanCode") & " and MemberCode=" & cmbEmployeeNumber.ColData("MemberCode"), objSqlConnection)
            objcommand.CommandType = CommandType.Text
            objcommand.ExecuteNonQuery()
        End If
        Panel4.Enabled = True
    End Sub
End Class