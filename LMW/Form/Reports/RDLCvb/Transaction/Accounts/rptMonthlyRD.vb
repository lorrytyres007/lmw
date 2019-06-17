Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptMonthlyRD
    Dim objMonthlyRD As New DBLayer.clsGledger
    Dim fystarting As DateTime
    Dim FYSTART As DateTime
    Dim FYEND As DateTime
    Private Sub rptMonthlyRD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Bind_Data()
        cmbMonth.SelectedIndex = 0
        cmbYear.RecordSet(objDT("sp_FYear_GetAll @Fycode=" & int_FYearCode), "fyear", "Fycode")

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

        objDT("sp_CashBalance @CompanyCode=" & int_CompanyCode & ",@FyCode=" & int_FYearCode & ",@ToDate='" & SD(FYEND) & "'")
        objDT("sp_LEDGERDB @FromDate='" & SD(FYSTART) & "',@Todate='" & SD(FYEND) & "',@CompanyCode=" & int_CompanyCode)
        If cmbMonth.SelectedIndex > 0 Then
            objSqlCommand = New SqlCommand("sp_MonthlyRD", objSqlConnection)
            objSqlCommand.CommandType = CommandType.StoredProcedure

            objSqlCommand.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
            objSqlCommand.Parameters.AddWithValue("@ToDate", dtpTo.Value)
            objSqlCommand.Parameters.AddWithValue("@Fystartingdate", fystarting)

            Dim objRDS As ReportDataSource = New ReportDataSource
            objRDS.Name = "LMWDataSet_sp_Company_GetAll"
            objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

            Dim objRDS1 As ReportDataSource = New ReportDataSource
            objRDS1.Name = "LMWDataSet_sp_MonthlyRD"
            objRDS1.Value = objDT(objSqlCommand)

            rptViewer.Reset()
            rptViewer.LocalReport.DataSources.Clear()
            rptViewer.LocalReport.DataSources.Add(objRDS)
            rptViewer.LocalReport.DataSources.Add(objRDS1)
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptMonthlyRD.rdlc"

            Dim params(2) As ReportParameter
            params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
            If cmbMonth.Enabled = True Then
                params(1) = New ReportParameter("MonthName", cmbMonth.Text, False)
            Else
                params(1) = New ReportParameter("MonthName", cmbYear.Text, False)
            End If
            params(2) = New ReportParameter("YR", Str(Year(dtpFrom.Value)), False)
            rptViewer.LocalReport.SetParameters(params)

        End If

        If cmbYear.SelectedIndex > 0 Then
            objSqlCommand = New SqlCommand("sp_YRD", objSqlConnection)
            objSqlCommand.CommandType = CommandType.StoredProcedure

            objSqlCommand.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
            objSqlCommand.Parameters.AddWithValue("@ToDate", dtpTo.Value)
            objSqlCommand.Parameters.AddWithValue("@Fystartingdate", fystarting)

            Dim objRDS As ReportDataSource = New ReportDataSource
            objRDS.Name = "DairyDataSet_sp_Company_GetAll"
            objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

            Dim objRDS1 As ReportDataSource = New ReportDataSource
            objRDS1.Name = "DairyDataSet_sp_YRD"
            objRDS1.Value = objDT(objSqlCommand)

            rptViewer.Reset()
            rptViewer.LocalReport.DataSources.Clear()
            rptViewer.LocalReport.DataSources.Add(objRDS)
            rptViewer.LocalReport.DataSources.Add(objRDS1)
            If chkGroup.Visible = True And chkGroup.Checked = True Then
                rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptYearlyRDGroup.rdlc"
            Else
                rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptYearlyRD.rdlc"
            End If
            Dim datetext As String = dtpFrom.Text + " - " + dtpTo.Text
            Dim params(1) As ReportParameter
            params(0) = New ReportParameter("strTamil_Font", str_TamilFont, False)
            params(1) = New ReportParameter("Year", datetext, False)
            rptViewer.LocalReport.SetParameters(params)

        End If

        rptViewer.RefreshReport()

       

    End Sub

    Private Sub rptMonthlyRD_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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

            objMonthlyRD.CompanyCode = int_CompanyCode

            'cmbMonth.RecordSet(objMonthlyRD.BindRecords.Tables(0), "HeadName", "HeadCode")
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

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        If cmbMonth.SelectedIndex > 0 Then
            cmbYear.Enabled = False
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
        Else
            cmbYear.Enabled = True
        End If
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        If cmbYear.SelectedIndex > 0 Then
            chkGroup.Visible = True
            cmbMonth.Enabled = False
            dtpTo.Enabled = True
            fystarting = SD(objDScal("select Dateadd(Day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
            dtpFrom.Value = CD(cmbYear.ColData("fystart"))
            dtpTo.Value = CD(cmbYear.ColData("Fyend"))
        Else
            dtpTo.Enabled = False
            chkGroup.Visible = False
            cmbMonth.Enabled = True
        End If
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged

    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged

    End Sub
End Class