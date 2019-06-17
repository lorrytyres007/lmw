Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptHeadList

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub rptHeadList_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub rptHeadList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbStatus.SelectedIndex = 0
        btnView_Click(sender, e)
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        objSqlCommand = New SqlCommand("sp_Head_GetAll", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        objSqlCommand.Parameters.AddWithValue("@CompanyCode", int_CompanyCode)
        Select Case cmbStatus.SelectedIndex
            Case 1
                objSqlCommand.Parameters.AddWithValue("@Status", 1)
            Case 2
                objSqlCommand.Parameters.AddWithValue("@Status", 0)
        End Select

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Head_GetAll"
        objRDS.Value = objDT(objSqlCommand)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS1.Value = objDT("sp_Company_GetAll @Companycode=" & int_CompanyCode)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptHeadList.rdlc"

        Dim params(0) As ReportParameter
        params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        rptViewer.LocalReport.SetParameters(params)

        rptViewer.RefreshReport()
    End Sub
End Class