Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptLoanDetails

    Private Sub rptLoanDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bind_Data()
    End Sub

    Private Sub Bind_Data()
        cmbMemberType.SelectedIndex = 0
        cmbLoanName.RecordSet(objDT("sp_LoanName_GetAll"), "LoanName", "LoanNameCode")
        cmbEmployeeNumber.RecordSet(objDT("sp_Member_GetAll"), "strEmpNo", "MemberCode")
        cmbLoanNumber.RecordSet(objDT("select * from vw_MemberLoan where loancode=0"), "strLoanNumber", "LoanCode")
    End Sub

    Private Sub cmbLoanName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoanName.SelectedIndexChanged
        If cmbLoanName.SelectedIndex > 0 Then
            Dim optStaff As Integer = 1
            Dim optWorker As Integer = 1
            Dim optOther As Integer = 1
            If cmbMemberType.SelectedIndex = 0 Then
                optStaff = 1
                optWorker = 1
                optOther = 1
            ElseIf cmbMemberType.SelectedIndex = 1 Then
                optStaff = 1
                optWorker = 0
                optOther = 0
            ElseIf cmbMemberType.SelectedIndex = 2 Then
                optStaff = 0
                optWorker = 1
                optOther = 0
            Else
                optStaff = 0
                optWorker = 0
                optOther = 1
            End If
            objDT("SP_MEMBER_GETALL @STAFF=" & optStaff & ",@WORKER=" & optWorker & ",@OTHER=" & optOther)
            cmbEmployeeNumber.RecordSet(objDT("select CONVERT(varchar, EmployeeNumber) AS strEmpNo,* from tbl_MemberReport where membercode in (select memberCode from vw_MemberLoan where loannamecode=" & cmbLoanName.ColData("LoanNameCode") & ")"), "strEmpNO", "MemberCode")
            cmbLoanNumber.RecordSet(objDT("select * from vw_MemberLoan where LoanNameCode =" & cmbLoanName.ColData("LoanNameCode")), "strLoanNumber", "LoanCode")
        Else
            cmbEmployeeNumber.RecordSet(objDT("sp_Member_GetAll"), "strEmpNo", "MemberCode")
            cmbLoanNumber.RecordSet(objDT("select * from vw_MemberLoan where loancode=0"), "strLoanNumber", "LoanCode")
        End If
    End Sub

    Private Sub cmbEmployeeNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmployeeNumber.SelectedIndexChanged
        If cmbEmployeeNumber.SelectedIndex > 0 Then
            cmbLoanNumber.RecordSet(objDT("select * from vw_MemberLoan where MemberCode =" & cmbEmployeeNumber.ColData("MemberCode")), "strLoanNumber", "LoanCode")
            lblEmpName.Text = cmbEmployeeNumber.ColData("MEMBERNAME")
        Else
            cmbLoanNumber.RecordSet(objDT("select * from vw_MemberLoan where loancode=0"), "strLoanNumber", "LoanCode")
            lblEmpName.Text = "Employee Name"
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
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
        End If

        objSqlCommand = New SqlCommand("sp_MemberLoan_RptGetall", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        If chkDate.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
            objSqlCommand.Parameters.AddWithValue("@ToDate", dtpTo.Value)
        End If
        If cmbMemberType.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@MemberType", cmbMemberType.SelectedIndex)
        End If
        If cmbLoanName.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@LoanNameCode", cmbLoanName.ColData("LoanNameCode"))
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
        objRDS1.Name = "LMWDataSet_sp_MemberLoan_RptGetall"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptMemberLoanList.rdlc"

        'Dim params(1) As ReportParameter
        'params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        'params(1) = New ReportParameter("Balanceshow", False, False)
        'rptViewer.LocalReport.SetParameters(params)

        rptViewer.RefreshReport()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rptLoanDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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

    
End Class