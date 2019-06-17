Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptTDCollection
    Dim objTDCollection As New DBLayer.clsGledger
    Dim fystarting As DateTime
    Dim FYSTART As DateTime
    Dim FYEND As DateTime
    Private Sub rptTDCollection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Bind_Data()
            cmbMonthFrom.SelectedIndex = 0
            cmbMonthTO.SelectedIndex = 0
            cmbYear.RecordSet(objDT("sp_FYear_GetAll @Fycode=" & int_FYearCode), "fyear", "Fycode")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
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
        '************************************************
        'fystarting = DateAdd("D", -1, fystarting)
        '************************************************


        objSqlCommand = New SqlCommand("sp_TDCollection", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure
        Dim mfrom As Integer = 0
        Dim yearnumber As Integer = 0
        Dim yearnumber1 As Integer = 0
        If cmbMonthFrom.SelectedIndex = 0 Then
            mfrom = 4
            yearnumber = Year(dtpFrom.Value)
        Else
            mfrom = cmbMonthFrom.SelectedIndex + 3
            yearnumber = Year(dtpFrom.Value)
        End If
        Dim mto As Integer = 0
        If cmbMonthTO.SelectedIndex = 0 Then
            mto = 15
            yearnumber1 = Year(dtpTo.Value)
        Else
            mto = cmbMonthTO.SelectedIndex + 3
            yearnumber1 = Year(dtpTo.Value)
        End If


        objSqlCommand.Parameters.AddWithValue("@Fromdate", SD(dtpFrom.Value))
        objSqlCommand.Parameters.AddWithValue("@Todate", SD(dtpTo.Value))
        objSqlCommand.Parameters.AddWithValue("@MonthFrom", mfrom)
        objSqlCommand.Parameters.AddWithValue("@MonthTo", mto)
        objSqlCommand.Parameters.AddWithValue("@YearNumber", yearnumber)
        objSqlCommand.Parameters.AddWithValue("@YearNumber1", yearnumber1)
        If cmbEmpNo.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@EmpNo", cmbEmpNo.ColData("EmployeeNumber"))
        End If

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_TDCollection"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptTDCollection.rdlc"

        Dim stryear As String = objDScal("select Fyear from tbl_Fyear where fycode=" & int_FYearCode)

        Dim params(1) As ReportParameter
        params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        params(1) = New ReportParameter("YR", stryear, False)
        rptViewer.LocalReport.SetParameters(params)

        rptViewer.RefreshReport()

    End Sub

    Private Sub rptTDCollection_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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

            objTDCollection.CompanyCode = int_CompanyCode
            cmbEmpNo.RecordSet(objTDCollection.BindRecords.Tables(2), "strEmpNo", "MemberCode")
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

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonthFrom.SelectedIndexChanged
        If cmbMonthFrom.SelectedIndex > 0 Then
            cmbYear.Enabled = False
            fystarting = SD(objDScal("select Dateadd(Day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
            Dim yr As Integer = Year(fystarting)
            Dim mn As Integer = cmbMonthFrom.SelectedIndex + 3
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
            cmbMonthFrom.Enabled = False
            cmbMonthTO.Enabled = False
            fystarting = SD(objDScal("select Dateadd(Day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
            dtpFrom.Value = CD(cmbYear.ColData("fystart"))
            dtpTo.Value = CD(cmbYear.ColData("Fyend"))
        Else
            cmbMonthFrom.Enabled = True
            cmbMonthTO.Enabled = True
        End If
    End Sub


    Private Sub cmbMonthTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonthTO.SelectedIndexChanged
        If cmbMonthFrom.SelectedIndex > 0 Then
            cmbYear.Enabled = False
            fystarting = SD(objDScal("select Dateadd(Day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
            Dim yr As Integer = Year(fystarting)
            Dim mn As Integer = cmbMonthTO.SelectedIndex + 3
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

            If cmbMonthFrom.SelectedIndex = 0 Then dtpFrom.Value = CD(Str(FD) + "/" + Str(mn) + "/" + Str(yr))
            dtpTo.Value = CD(Str(LD) + "/" + Str(mn) + "/" + Str(yr))
        Else
            cmbYear.Enabled = True
        End If
    End Sub

    Private Sub cmbMonthTO_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMonthTO.Validated
        If cmbMonthFrom.SelectedIndex > cmbMonthTO.SelectedIndex Then
            MsgBox("Month From is Grater than Month To. Check it", MsgBoxStyle.Information, Mssg)
            cmbMonthFrom.Focus()
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class