Imports System.Data.SqlClient

Public Class frmEmiChange
    Dim LP As Integer = 0
    Dim Bool_Edit As Boolean = False
    Private Sub chkLPeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLPeriod.CheckedChanged
        If chkLPeriod.Checked = True Then
            txtLoanPeriod.Enabled = True
            txtLoanPeriod.Focus()
        Else
            txtLoanPeriod.Enabled = False
            txtLoanPeriod.Text = cmbLoanNo.ColData("LoanPeriod")
        End If
    End Sub

    Private Sub frmEmiChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bool_Edit = False Then
            cmbMember.Enabled = True
            cmbLoanNo.Enabled = True
            BindData()
        End If
    End Sub
    Private Sub BindData()
        cmbMember.RecordSet(objDT("Select convert(varchar,EmployeeNumber)as strEmpNo,* from tbl_Member where membercode in (select Membercode from tbl_MemberLoan) Order by MemberCode"), "strEmpNo", "MemberCode")
    End Sub
    Private Sub cmbMember_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMember.SelectedIndexChanged
        If cmbMember.SelectedIndex > 0 Then
            cmbLoanNo.RecordSet(objDT("sp_MemberLoan_GetAll @MemberCode=" & cmbMember.ColData("MemberCode")), "strLoanNumber", "LoanCode")
        Else
            cmbLoanNo.RecordSet(objDT("sp_MemberLoan_GetAll @MemberCode=0"), "strLoanNumber", "LoanCode")
        End If
    End Sub

    Private Sub cmbLoanNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoanNo.SelectedIndexChanged
        If cmbLoanNo.SelectedIndex > 0 Then
            txtLoanAmount.Text = cmbLoanNo.ColData("LoanAmount")
            txtLoanPeriod.Text = cmbLoanNo.ColData("LoanPeriod")
            txtROI.Text = cmbLoanNo.ColData("ROI")
            LP = cmbLoanNo.ColData("LoanPeriod")
            txtCurrentEMI.Text = cmbLoanNo.ColData("EMI_Amount")
        End If
    End Sub
    Public Sub show_Add()
        Bool_Edit = False
        Me.ShowDialog()
    End Sub
    Public Sub show_Edit(ByVal Datarow As DataGridViewRow)
        Bool_Edit = True
        BindData()
        txtEmiChangeCode.Text = Datarow.Cells("EMIChangeCode").Value
        cmbMember.SelectedValue = Datarow.Cells("MemberCode").Value
        cmbLoanNo.SelectedValue = Datarow.Cells("LoanCode").Value
        LP = Datarow.Cells("LastLoanPeriod").Value
        txtCurrentEMI.Text = Datarow.Cells("LastEMI").Value
        txtChangeEMI.Text = Datarow.Cells("ChangeEMI").Value
        txtLoanPeriod.Text = Datarow.Cells("changeLoanPeriod").Value
        cmbMember.Enabled = False
        cmbLoanNo.Enabled = False
        Me.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cmbMember.SelectedIndex = 0 Then
            MsgBox("Select Employee Number ...", MsgBoxStyle.Information, Mssg)
            cmbMember.Focus()
            Exit Sub
        End If
        If cmbLoanNo.SelectedIndex = 0 Then
            MsgBox("Select Loan Number ...", MsgBoxStyle.Information, Mssg)
            cmbLoanNo.Focus()
            Exit Sub
        End If
        If Val(txtChangeEMI.Text) = 0 Then
            MsgBox("Change EMI Amount is Zero...", MsgBoxStyle.Information, Mssg)
            txtChangeEMI.Focus()
            Exit Sub
        End If
        If cmbLoanNo.ColData("LoanClossedStatus") = True Then
            MsgBox("Sorry!... This Loan was Clossed...", MsgBoxStyle.Information, Mssg)
            Exit Sub
        End If
        Initialise_Connection()
        Dim objcommand As New SqlCommand("sp_EMIChange_AddEdit", objSqlConnection)
        objcommand.CommandType = CommandType.StoredProcedure
        If Bool_Edit = True Then
            objcommand.Parameters.AddWithValue("EmiChangecode", Val(txtEmiChangeCode.Text))
        End If
        objcommand.Parameters.AddWithValue("@memberCode", Val(cmbMember.ColData("memberCode")))
        objcommand.Parameters.AddWithValue("@LoanCode", Val(cmbLoanNo.ColData("loancode")))
        objcommand.Parameters.AddWithValue("@LastEMI", Val(txtCurrentEMI.Text))
        objcommand.Parameters.AddWithValue("@ChangeEMI", Val(txtChangeEMI.Text))
        objcommand.Parameters.AddWithValue("@LastLoanPeriod", LP)
        objcommand.Parameters.AddWithValue("@ChangeLoanPeriod", Val(txtLoanPeriod.Text))
        objcommand.Parameters.AddWithValue("@User", int_UserCode)
        objcommand.Parameters.AddWithValue("@Node", int_NodeCode)

        objcommand.ExecuteNonQuery()
        frmEMI_ChangeDetails.Grid.RecordSet(objDT("sp_EMIChange_GetAll"), "MemberCode,LoanCode")
        If Bool_Edit = False Then
            MsgBox("Record Saved Successfully...", MsgBoxStyle.Information, Mssg)
            btnClear_Click(sender, e)
        Else
            MsgBox("Record Updated Successfully...", MsgBoxStyle.Information, Mssg)
            btnExit_Click(sender, e)
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PanelClear(pnlTop)
        cmbMember.Enabled = True
        cmbLoanNo.Enabled = True
        BindData()
        Bool_Edit = False
        cmbMember.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Dispose()
    End Sub
End Class