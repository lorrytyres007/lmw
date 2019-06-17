Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptDemandList
    Dim objDemandList As New DBLayer.clsGledger

    Private Sub rptDemandList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Bind_Data()
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

        objDT("sp_CashBalance @CompanyCode=" & int_CompanyCode & ",@FyCode=" & int_FYearCode & ",@ToDate='" & SD(dtpTo.Value) & "'")
        objDT("sp_LEDGERDB @FromDate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "',@CompanyCode=" & int_CompanyCode)

        objSqlCommand = New SqlCommand("sp_DemandList", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        objSqlCommand.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
        objSqlCommand.Parameters.AddWithValue("@ToDate", dtpTo.Value)
        objSqlCommand.Parameters.AddWithValue("@Companycode", int_CompanyCode)
        objSqlCommand.Parameters.AddWithValue("@Fycode", int_FYearCode)
        If cmbEmpNo.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@HeadCode", cmbEmpNo.ColData("headCode"))
        End If

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_DemandList"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptDemandList.rdlc"

        Dim params(1) As ReportParameter
        params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        params(1) = New ReportParameter("Balanceshow", False, False)
        rptViewer.LocalReport.SetParameters(params)

        rptViewer.RefreshReport()

    End Sub

    Private Sub rptDemandList_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub Bind_Data()
        Try
            Dim fyear As DataTable = objDT("select * from tbl_fyear where fycode=" & int_FYearCode)
            dtpFrom.Value = fyear.Rows(0)("fystart")
            dtpTo.Value = fyear.Rows(0)("FyEnd")
            objDemandList.CompanyCode = int_CompanyCode
            cmbEmpNo.RecordSet(objDemandList.BindRecords.Tables(2), "strEmpNo", "MemberCode")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtpFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFrom.Validated
        If CheckDate(dtpFrom.Value) = False Then
            MsgBox("The Given Date is not Correct for the Selected Year of commence", MsgBoxStyle.Information, Mssg)
            dtpFrom.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub dtpTo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTo.Validated
        If dtpTo.Value < dtpFrom.Value Then
            MsgBox("Date To value is Less than Value From ...  Check it", MsgBoxStyle.Information, Mssg)
            dtpTo.Focus()
        End If
    End Sub
End Class