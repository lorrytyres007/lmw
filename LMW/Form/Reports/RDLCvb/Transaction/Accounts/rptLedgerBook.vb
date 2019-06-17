Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptLedgerBook
    Dim objLedgerBook As New DBLayer.clsGledger

    Private Sub rptLedgerBook_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        objSqlCommand = New SqlCommand("sp_LedgerBook", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        objSqlCommand.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
        objSqlCommand.Parameters.AddWithValue("@ToDate", dtpTo.Value)
        objSqlCommand.Parameters.AddWithValue("@Companycode", int_CompanyCode)
        objSqlCommand.Parameters.AddWithValue("@Fycode", int_FYearCode)
        If cmbLedger.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@HeadCode", cmbLedger.ColData("headCode"))
        Else
            If cmbGroupName.SelectedIndex > 0 Then
                objSqlCommand.Parameters.AddWithValue("@GroupCode", cmbGroupName.ColData("GroupCode"))
            End If
        End If

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_LedgerBook"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptLedgerBook.rdlc"

        Dim StrYear As String = objDScal("Select Fyear from tbl_Fyear where Fycode=" & int_FYearCode)

        Dim params(2) As ReportParameter
        params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        params(1) = New ReportParameter("Balanceshow", False, False)
        params(2) = New ReportParameter("strYear", StrYear, False)
        rptViewer.LocalReport.SetParameters(params)

        rptViewer.RefreshReport()

    End Sub

    Private Sub rptLedgerBook_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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
            objLedgerBook.CompanyCode = int_CompanyCode
            cmbGroupName.RecordSet(objLedgerBook.BindRecords.Tables(1), "Groupname", "Groupcode")
            cmbLedger.RecordSet(objLedgerBook.BindRecords.Tables(0), "HeadName", "HeadCode")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtpFrom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFrom.Validated
        If IsDate(dtpFrom.Value) Then
            If CheckDate(dtpFrom.Value) = False Then
                MsgBox("The Given Date is not Correct for the Selected Year of commence", MsgBoxStyle.Information, Mssg)
                dtpFrom.Focus()
                Exit Sub
            End If
            'dtpTo.Value = DateAdd(DateInterval.Day, 6, dtpFrom.Value)
        Else
            MsgBox("Invalid Date", MsgBoxStyle.Information, Mssg)
            dtpFrom.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged

    End Sub

    Private Sub cmbGroupName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroupName.SelectedIndexChanged
        If cmbGroupName.SelectedIndex > 0 Then
            cmbLedger.RecordSet(objDT("select * from tbl_Head where CompanyCode=" & int_CompanyCode & "  AND GroupCode=" & cmbGroupName.ColData("GroupCode")), "HeadName", "HeadCode")
        Else
            cmbLedger.RecordSet(objLedgerBook.BindRecords.Tables(0), "HeadName", "HeadCode")
        End If
    End Sub
End Class