Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptTDRefund
    Private Sub rptTDRefund_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpFrom.Value = objDScal("Select Fystart from tbl_Fyear where fycode=" & int_FYearCode)
        dtpTo.Value = objDScal("Select FyEnd from tbl_Fyear where fycode=" & int_FYearCode)
        BindData()
    End Sub
    Private Sub BindData()
        cmbEmpNo.RecordSet(objDT("Select *,convert(varchar,EmployeeNumber) as strEmpno From tbl_Member where memberCode in (select MemberCode from tbl_TDRefund)"), "strEmpno", "MemberCode")

    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If CheckDate(dtpTo.Text) = False Then
            MsgBox("Invalid To Date", MsgBoxStyle.Information, Mssg)
            dtpTo.Focus()
            Exit Sub
        End If

        If CDate(dtpTo.Text) < CDate(dtpFrom.Text) Then
            MsgBox("From Date should not be greater than To Date", MsgBoxStyle.Information, Mssg)
            dtpTo.Focus()
            Exit Sub
        End If

        Dim objcommand As New SqlCommand("sp_TDRefund_GetAll", objSqlConnection)
        objcommand.CommandType = CommandType.StoredProcedure
        objcommand.Parameters.AddWithValue("@FromDate", SD(dtpFrom.Value))
        objcommand.Parameters.AddWithValue("@ToDate", SD(dtpTo.Value))
        If cmbEmpNo.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@MemberCode", cmbEmpNo.ColData("MemberCode"))
        End If

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_TDRefund_GetAll"
        objRDS1.Value = objDT(objcommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptTDRefund.rdlc"
        Dim str_YR As String = "Date From " + dtpFrom.Text + " To " + dtpTo.Text

        Dim params(1) As ReportParameter
        params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        params(1) = New ReportParameter("YR", str_YR, False)
        rptViewer.LocalReport.SetParameters(params)
        rptViewer.RefreshReport()

    End Sub

    Private Sub rptTDRefund_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub


    Private Sub dtpFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFrom.Validated
        If IsDate(dtpFrom.Value) Then
            If CheckDate(dtpFrom.Value) = False Then
                MsgBox("The Given Date is not Correct for the Selected Year of commence", MsgBoxStyle.Information, Mssg)
                dtpFrom.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Invalid Date", MsgBoxStyle.Information, Mssg)
            dtpFrom.Focus()
            Exit Sub
        End If
    End Sub


End Class