Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptTrailBalance
    Dim objTrailBalance As New DBLayer.clsGledger
    Dim fystarting As DateTime
    Dim FYSTART As DateTime
    Dim FYEND As DateTime
    Private Sub rptTrailBalance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        '************************************************
        'fystarting = DateAdd("D", -1, fystarting)
        '************************************************


        objSqlCommand = New SqlCommand("sp_TrailBalance", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        objSqlCommand.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
        objSqlCommand.Parameters.AddWithValue("@ToDate", dtpTo.Value)
        objSqlCommand.Parameters.AddWithValue("@FyCode", int_FYearCode)

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_TrailBalance"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        If chkGroup.Checked = False Then
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptTrialBalance.rdlc"
        Else
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptTrialBalanceGroup.rdlc"
        End If

        rptViewer.RefreshReport()



    End Sub

    Private Sub rptTrailBalance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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
            FYSTART = fyear.Rows(0)("fystart")
            FYEND = fyear.Rows(0)("FyEnd")

            objTrailBalance.CompanyCode = int_CompanyCode

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
        Else
            MsgBox("Invalid Date", MsgBoxStyle.Information, Mssg)
            dtpFrom.Focus()
            Exit Sub
        End If
    End Sub

  
End Class