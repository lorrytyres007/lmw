Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class rptTDPassBook

    Private Sub rptTDPassBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bind_Data()
    End Sub

    Private Sub Bind_Data()
        cmbEmployeeNumber.RecordSet(objDT("sp_Member_GetAll"), "strEmpNo", "MemberCode")
    End Sub

    Private Sub cmbEmployeeNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmployeeNumber.SelectedIndexChanged
        If cmbEmployeeNumber.SelectedIndex > 0 Then
            lblEmpName.Text = cmbEmployeeNumber.ColData("MEMBERNAME")
        Else
            lblEmpName.Text = "Employee Name"
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Initialise_Connection()
        If cmbEmployeeNumber.SelectedIndex = 0 Then
            MsgBox("Please Select Employee Number...", MsgBoxStyle.Information, Mssg)
            cmbEmployeeNumber.Focus()
            Exit Sub
        End If
        pnlBar.Visible = True
        If chkDate.Checked = True Then
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
            Dim objDcom As New SqlCommand("delete from tbl_TD_Passbook where membercode=" & cmbEmployeeNumber.ColData("MemberCode"), objSqlConnection)
            objDcom.CommandType = CommandType.Text
            objDcom.ExecuteNonQuery()

            lblBarStatus.Text = "Reset Printed Option ...."
            PBar1.Value = 20
            Application.DoEvents()
            Dim objcommand As New SqlCommand("Update tbl_TD_PassBook set printed=0 where  MemberCode=" & cmbEmployeeNumber.ColData("MemberCode") & " and TDDepositdate >='" & SD(dtpFrom.Value) & "' and TDDepositDate <='" & SD(dtpTo.Value) & "'", objSqlConnection)
            objcommand.CommandType = CommandType.Text
            objcommand.ExecuteNonQuery()
            PBar1.Value = 100
            Application.DoEvents()
        End If
        Dim FDate As DateTime = objDScal("Select FYStart from tbl_Fyear where Fycode=" & int_FYearCode)
        Dim TDate As DateTime = objDScal("Select FYEnd from tbl_Fyear where Fycode=" & int_FYearCode)

        lblBarStatus.Text = "Updating Pass Book Entries ...."
        PBar1.Value = 25
        Application.DoEvents()
        Dim objCom As New SqlCommand("sp_Update_TDPassBook", objSqlConnection)
        objCom.CommandType = CommandType.StoredProcedure
        If chkDate.Checked = True Then
            objCom.Parameters.AddWithValue("@FromDate", SD(dtpFrom.Value))
            objCom.Parameters.AddWithValue("@ToDate", SD(dtpTo.Value))
        Else
            objCom.Parameters.AddWithValue("@FromDate", SD(FDate))
            objCom.Parameters.AddWithValue("@ToDate", SD(TDate))
        End If
        objCom.Parameters.AddWithValue("@MemberCode", cmbEmployeeNumber.ColData("MemberCode"))
        objCom.ExecuteNonQuery()

        lblBarStatus.Text = "Updating Line & Page Numbers ...."
        PBar1.Value = 60
        Application.DoEvents()
        Dim objCom1 As New SqlCommand("sp_TDPassBook_Linenumber_Page_Balance", objSqlConnection)
        objCom1.CommandType = CommandType.StoredProcedure
        objCom1.Parameters.AddWithValue("@MemberCode", Val(cmbEmployeeNumber.ColData("MemberCode")))
        objCom1.ExecuteNonQuery()


        lblBarStatus.Text = "Prparing Report ...."
        PBar1.Value = 80
        Application.DoEvents()

        objSqlCommand = New SqlCommand("sp_TD_PassBook", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        If chkDate.Checked = True Then
            objSqlCommand.Parameters.AddWithValue("@FromDate", SD(dtpFrom.Value))
            objSqlCommand.Parameters.AddWithValue("@ToDate", SD(dtpTo.Value))
        End If

        If cmbEmployeeNumber.SelectedIndex > 0 Then
            objSqlCommand.Parameters.AddWithValue("@MemberCode", cmbEmployeeNumber.ColData("MemberCode"))
        End If
        PBar1.Value = 100
        Application.DoEvents()


        Dim objRDS As ReportDataSource = New ReportDataSource
        objRDS.Name = "LMWDataSet_sp_Company_GetAll"
        objRDS.Value = objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode)

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_TD_PassBook"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS)
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptTD_PassBook.rdlc"
        pnlBar.Visible = False
        'Dim params(1) As ReportParameter
        'params(0) = New ReportParameter("Tamil_Font", str_TamilFont, False)
        'params(1) = New ReportParameter("Balanceshow", False, False)
        'rptViewer.LocalReport.SetParameters(params)

        rptViewer.RefreshReport()


    End Sub
    Private Sub fastreport1()
        ' ''Dim objCom As New SqlCommand("sp_PassBook", objSqlConnection)
        ' ''objCom.CommandType = CommandType.StoredProcedure
        ' ''objCom.CommandTimeout = 600
        ' ''If chkDate.Checked = True Then
        ' ''    objCom.Parameters.AddWithValue("@FromDate", dtpFrom.Value)
        ' ''    objCom.Parameters.AddWithValue("@ToDate", dtpTo.Value)
        ' ''End If
        ' ''If cmbEmployeeNumber.SelectedIndex > 0 Then
        ' ''    objCom.Parameters.AddWithValue("@MemberCode", cmbEmployeeNumber.ColData("MemberCode"))
        ' ''End If
        ' ''If cmbLoanNumber.SelectedIndex > 0 Then
        ' ''    objCom.Parameters.AddWithValue("@LoanCode", cmbLoanNumber.ColData("LoanCode"))
        ' ''End If


        ' ''Dim ds As DataSet = objDS(objCom)
        ' ''ds.Tables(0).TableName = "sp_PassBook"

        ' ''Dim bb As FastReport.Report = New FastReport.Report()

        ' ''bb.Load("FReport\rptPassBook.frx")

        ' ''bb.RegisterData(ds)

        ' ''bb.GetDataSource("sp_PassBook").Enabled = True
        ' ''bb.Preview = rptViewer.Viewer
        ' ''bb.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub rptTDPassBook_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        pnlDate.Enabled = chkDate.Checked
        If chkDate.Checked = True Then
            chkDate.Text = "Date Disable"
        Else
            chkDate.Text = "Date Enable"
        End If
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MsgBox("Is it Printed?... ", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Mssg) = MsgBoxResult.Ok Then
            Initialise_Connection()
            Dim SQLQuery As String = "Update tbl_TD_PassBook set printed=1 where "
            Initialise_Connection()
            If chkDate.Checked = True Then
                SQLQuery = SQLQuery + "  MemberCode=" & cmbEmployeeNumber.ColData("MemberCode") + " and TDDepositDate >='" + SD(dtpFrom.Value) + "' and TDDepositDate <='" + SD(dtpTo.Value) + "'"
            Else
                SQLQuery = SQLQuery + "  MemberCode=" & cmbEmployeeNumber.ColData("MemberCode")
            End If
            Dim objcommand As New SqlCommand(SQLQuery, objSqlConnection)
            objcommand.CommandType = CommandType.Text
            objcommand.ExecuteNonQuery()
        End If
        Panel4.Enabled = True
    End Sub

    Private Sub btnFRView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFRView.Click

        If cmbEmployeeNumber.SelectedIndex = 0 Then
            MsgBox("Select Token No", MsgBoxStyle.Information, Mssg)
            cmbEmployeeNumber.Focus()
            Exit Sub
        End If
        Panel4.Enabled = False
        Initialise_Connection()
        objSqlCommand = New SqlCommand("sp_Member_GetAll", objSqlConnection)
        objSqlCommand.CommandType = CommandType.StoredProcedure

        objSqlCommand.Parameters.AddWithValue("@MemberCode", cmbEmployeeNumber.ColData("MemberCode"))

        Dim objRDS1 As ReportDataSource = New ReportDataSource
        objRDS1.Name = "LMWDataSet_sp_Member_GetAll"
        objRDS1.Value = objDT(objSqlCommand)

        rptViewer.Reset()
        rptViewer.LocalReport.DataSources.Clear()
        rptViewer.LocalReport.DataSources.Add(objRDS1)
        rptViewer.LocalReport.ReportEmbeddedResource = "LMW.rptFRSharePassBook.rdlc"

        rptViewer.RefreshReport()
    End Sub
End Class