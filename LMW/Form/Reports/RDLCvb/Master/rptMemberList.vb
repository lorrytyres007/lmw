Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptMemberList

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub rptMemberList_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub rptMemberList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbStatus.SelectedIndex = 0
        cmbCategory.SelectedIndex = 0
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        objSqlCommand = New SqlCommand("sp_Member_GetAll", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        Select Case cmbCategory.SelectedIndex
            Case 1
                objSqlCommand.Parameters.AddWithValue("@ConfirmMember", "Y")
            Case 2
                objSqlCommand.Parameters.AddWithValue("@ConfirmMember", "N")
        End Select
        objSqlCommand.Parameters.AddWithValue("@CompanyCode", int_CompanyCode)
        If chkStaff.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@STAFF", 1)
        End If
        If chkWorker.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@WORKER", 1)
        End If
        If chkOther.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@OTHER", 1)
        End If
        Select Case cmbStatus.SelectedIndex
            Case 1
                objSqlCommand.Parameters.AddWithValue("@Status", 1)
            Case 2
                objSqlCommand.Parameters.AddWithValue("@Status", 0)
        End Select
        If dtpAsonDate.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@Asondate", SD(dtpAsonDate.Value))
        End If

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Member_GetAll"
        objRDS.Value = objDT(objSqlCommand)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS1.Value = objDT("sp_Company_GetAll @Companycode=" & int_CompanyCode)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptMemberList.rdlc"

        Dim params(0) As ReportParameter
        params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        rptViewer.LocalReport.SetParameters(params)

        rptViewer.RefreshReport()


    End Sub
End Class