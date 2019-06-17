Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptDayBook
    Dim objDayBook As New DBLayer.clsLedger_Common

    Private Sub rptDayBook_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Bind_Data()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If CheckDate(dtpFrom.Text) = False Then
            MsgBox("Invalid To Date", MsgBoxStyle.Information, Mssg)
            dtpFrom.Focus()
            Exit Sub
        End If

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

        objDT("sp_CashBalance @CompanyCode=" & int_CompanyCode & ",@FyCode=" & int_FYearCode & ",@ToDate='" & SD(dtpTo.Value) & "'")
        objDT("sp_DummyDaybook @FromDate='" & SD(dtpFrom.Value) & "' , @Todate='" & SD(dtpTo.Value) & "' , @CompanyCode=" & int_CompanyCode)
        Dim RP As String = ""
        objSqlCommand = New SqlCommand("sp_DayBook", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        objSqlCommand.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
        objSqlCommand.Parameters.AddWithValue("@ToDate", dtpTo.Value)
        If chkRpt.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@Rp", "R")
            RP = "R"
        End If
        If chkPyt.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@Rp", "P")
            RP = "P"
        End If

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_DayBook"
        objRDS1.Value = objDT(objSqlCommand)
        Dim objRDS2 As ReportDataSource = New ReportDataSource
        Dim objRDS3 As ReportDataSource = New ReportDataSource

        If chkRpt.Checked = False And chkPyt.Checked = False Then
            objRDS2.Name = "LMWDataSet_sp_DayBook_Rpt"
            objRDS2.Value = objDT("sp_Daybook_Rpt")

            objRDS3.Name = "LMWDataSet_sp_DayBook_Pyt"
            objRDS3.Value = objDT("sp_Daybook_Pyt")
        End If

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        If chkRpt.Checked = False And chkPyt.Checked = False Then

            rptViewer.LocalReport.DataSources.Add(objRDS2)
            rptViewer.LocalReport.DataSources.Add(objRDS3)
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptDayBook.rdlc"

            Dim params(4) As ReportParameter
            params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
            params(1) = New ReportParameter("Receipt", "R", False)
            params(2) = New ReportParameter("Payment", "P", False)
            params(3) = New ReportParameter("SighningAuthority", str_SighningAuthority, False)
            params(4) = New ReportParameter("CompanyName", MainForm.lblCompanyName.Text, False)
            rptViewer.LocalReport.SetParameters(params)
        Else

            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.DBReceipt.rdlc"

            Dim params(0) As ReportParameter
            params(0) = New ReportParameter("RP", RP, False)

            rptViewer.LocalReport.SetParameters(params)

        End If

            rptViewer.RefreshReport()

    End Sub

    Private Sub rptDayBook_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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
            objDayBook.CompanyCode = int_CompanyCode
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub chkRpt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRpt.CheckedChanged
        If chkRpt.Checked = True Then
            chkPyt.Checked = False
        End If
    End Sub

    Private Sub chkPyt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPyt.CheckedChanged
        If chkPyt.Checked = True Then
            chkRpt.Checked = False
        End If
    End Sub
End Class