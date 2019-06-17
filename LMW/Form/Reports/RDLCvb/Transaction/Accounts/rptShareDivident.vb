Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptShareDivident
    Dim objTDCollection As New DBLayer.clsGledger
    Dim fystarting As DateTime
    Dim FYSTART As DateTime
    Dim FYEND As DateTime
    Private Sub rptShareDivident_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Bind_Data()
           
            cmbYear.RecordSet(objDT("sp_FYear_GetAll"), "fyear", "Fycode")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        
        '************************************************
        'fystarting = DateAdd("D", -1, fystarting)
        '************************************************
        If cmbYear.SelectedIndex = 0 Then
            MsgBox("select Year", MsgBoxStyle.Information, Mssg)
            cmbYear.Focus()
            Exit Sub
        End If
        objSqlCommand = New SqlCommand("sp_sharedivident_GetAll", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure
        Dim mfrom As Integer = 0
        Dim yearnumber As Integer = 0
        Dim yearnumber1 As Integer = 0
        Dim Totalvalue As Double = 0
        objSqlCommand.Parameters.AddWithValue("@FyCode", cmbYear.ColData("fycode"))
        If cmbEmpNo.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@EmpNo", cmbEmpNo.ColData("EmployeeNumber"))
        End If

        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_ShareDivident_GetAll"
        objRDS1.Value = objDT(objSqlCommand)
        Dim objtable As DataTable = objDT(objSqlCommand)
        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        Dim stryear As String = cmbYear.ColData("Fyear") 'objDScal("select Fyear from tbl_Fyear where fycode=" & int_FYearCode)
        'IntOnOpening.Value+Fields!IntonCollection.Value
        Totalvalue = objtable.Rows.Item(0)("IntOnOpening") + objtable.Rows.Item(0)("IntonCollection")
        Dim Num As New NumWord.NumWords
        Dim Numword As String = Num.Findword(Totalvalue).ToUpper
        If chkVoucherPrint.Checked = False Then
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptShareDivident.rdlc"
            Dim params(1) As ReportParameter
            params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
            params(1) = New ReportParameter("YR", stryear, False)
            rptViewer.LocalReport.SetParameters(params)
        Else
            rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptShareDivident_IndividualPrint.rdlc"
            Dim params(2) As ReportParameter
            params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
            params(1) = New ReportParameter("YR", stryear, False)
            params(2) = New ReportParameter("NumWord", Numword, False)
            rptViewer.LocalReport.SetParameters(params)
        End If

       
        rptViewer.RefreshReport()

    End Sub

    Private Sub rptShareDivident_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub Bind_Data()
        Try
            Dim fyear As DataTable = objDT("select * from tbl_fyear where fycode=" & int_FYearCode)
            FYSTART = fyear.Rows(0)("fystart")
            FYEND = fyear.Rows(0)("FyEnd")

            objTDCollection.CompanyCode = int_CompanyCode
            cmbEmpNo.RecordSet(objDT("sp_member_Getall"), "strEmpNo", "MemberCode")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        'If cmbYear.SelectedIndex > 0 Then
        fystarting = SD(objDScal("select Dateadd(Day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
        'End If
    End Sub


    Private Sub cmbEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpNo.SelectedIndexChanged
        If cmbEmpNo.SelectedIndex = 0 Then
            chkVoucherPrint.Visible = False
        Else
            chkVoucherPrint.Visible = True
        End If
    End Sub
End Class