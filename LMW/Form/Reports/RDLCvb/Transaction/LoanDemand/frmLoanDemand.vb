Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Public Class frmLoanDemand

    Dim objMonthlyRD As New DBLayer.clsGledger
    Dim fystarting As DateTime
    Dim FYSTART As DateTime
    Dim FYEND As DateTime
    Private Sub Bind_Data()
        Try
            Dim fyear As DataTable = objDT("select * from tbl_fyear where fycode=" & int_FYearCode)
            dtpFrom.Value = fyear.Rows(0)("fystart")
            dtpTo.Value = fyear.Rows(0)("FyEnd")
            FYSTART = fyear.Rows(0)("fystart")
            FYEND = fyear.Rows(0)("FyEnd")
            objMonthlyRD.CompanyCode = int_CompanyCode
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
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

        If cmbMemberType.SelectedIndex = 0 Then
            MsgBox("Please Select Member Type...", MsgBoxStyle.Information, Mssg)
            cmbMemberType.Focus()
            Exit Sub
        End If

        If cmbMonth.SelectedIndex = 0 Then
            MsgBox("Please Select Month of Report Generation....", MsgBoxStyle.Information, Mssg)
            cmbMonth.Focus()
            Exit Sub
        End If
        Dim objcommand As New SqlCommand("sp_LoanDemand", objSqlConnection)
        objcommand.CommandType = CommandType.StoredProcedure

        objcommand.Parameters.AddWithValue("@FromDate", SD(dtpFrom.Value))
        objcommand.Parameters.AddWithValue("@ToDate", SD(dtpTo.Value))
        If cmbMemberType.SelectedIndex = 1 Then
            objcommand.Parameters.AddWithValue("@StaffLoan", 1)
        Else
            objcommand.Parameters.AddWithValue("@StaffLoan", 0)
        End If
        objcommand.Parameters.AddWithValue("@MonthNo", Month(dtpFrom.Value))
        objcommand.Parameters.AddWithValue("@YearNo", Year(dtpFrom.Value))

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_LoanDemand"
        objRDS1.Value = objDT(objcommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.DataSources.Add(objRDS)
        If optCompany.Checked = True Then
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptLoanDemand_Short.rdlc"
        ElseIf optDemandType.Checked = True Then
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptLoanDemand.rdlc"
        ElseIf optLoanName.Checked = True Then
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptLoanDemand_LoanName.rdlc"
        Else

        End If

        'Dim params(2) As ReportParameter
        'params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        'params(1) = New ReportParameter("MonthName", cmbMonth.Text, False)
        'params(2) = New ReportParameter("YR", Str(Year(dtpFrom.Value)), False)
        'rptViewer.LocalReport.SetParameters(params)
        rptViewer.RefreshReport()
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        If cmbMonth.SelectedIndex > 0 Then
            fystarting = SD(objDScal("select Dateadd(Day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
            Dim yr As Integer = Year(fystarting)
            Dim mn As Integer = cmbMonth.SelectedIndex + 3
            Dim FD As Integer = 1
            Dim LD As Integer = 28
            If mn > 12 Then
                mn = mn - 12
                yr = yr + 1
            End If
            If mn = 1 Or mn = 3 Or mn = 5 Or mn = 7 Or mn = 8 Or mn = 10 Or mn = 12 Then
                LD = 31
            ElseIf mn = 4 Or mn = 6 Or mn = 9 Or mn = 11 Then
                LD = 30
            Else
                Dim a As Integer = (yr / 4)
                Dim r As Integer = yr - (a * 4)
                If r = 0 Then
                    LD = 29
                Else
                    LD = 28
                End If
            End If
            dtpFrom.Value = CD(Str(FD) + "/" + Str(mn) + "/" + Str(yr))
            dtpTo.Value = CD(Str(LD) + "/" + Str(mn) + "/" + Str(yr))
        End If
    End Sub

    Private Sub frmLoanDemand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bind_Data()
        cmbMemberType.SelectedIndex = 0
        cmbDemandType.SelectedIndex = 0
        cmbMonth.SelectedIndex = 0
    End Sub

    Private Sub frmLoanDemand_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class