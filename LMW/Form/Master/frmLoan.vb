
Public Class frmLoan
    Dim bool_Edit As Boolean
    Dim objLoan As New DBLayer.clsLoan

    Private Sub frmLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "Loan Name Details")
        If bool_Edit = False Then cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtLoanName.Text.Trim = "" Then
                MsgBox("Loan Name should not be empty", MsgBoxStyle.Information, Mssg)
                txtLoanName.Focus()
                Return
            End If
            If chkDemand.Checked = True Then
                If optNone.Checked = True Then
                    MsgBox("Demand Type must not be None ...", MsgBoxStyle.Information, Mssg)
                    optNone.Focus()
                    Exit Sub
                End If
            End If
            objLoan.LoanCode = Val(txtLoanCode.Text)
            objLoan.LoanName = txtLoanName.Text.Trim()
            objLoan.Status = IIf(cmbStatus.SelectedIndex = 0, 1, 0)
            objLoan.Demand = IIf(chkDemand.Checked = True, 1, 0)
            If optNone.Checked = True Then
                objLoan.DemandType = 0
            ElseIf optFixed.Checked = True Then
                objLoan.DemandType = 1
            ElseIf optJLDemand.Checked = True Then
                objLoan.DemandType = 2
            Else
                objLoan.DemandType = 3
            End If
            If bool_Edit = False Then
                frmLoanDetails.Grid.RecordSet(objLoan.SaveRecords(), "LoanNameCode")
                MessageBox.Show("The record is saved", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnClear_Click(sender, e)
            Else
                frmLoanDetails.Grid.RecordSet(objLoan.UpdateRecords(), "LoanNameCode")
                MessageBox.Show("The record is updated", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnExit_Click(sender, e)
            End If

        Catch ex As Exception
            If ex.Message.Contains("UK_tbl_LoanName") Then
                MessageBox.Show("Already exist the Loan Name", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLoanName.Focus()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End If
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim Code As Integer = Val(txtLoanCode.Text)
        FormClear(Me)
        txtLoanCode.Text = Code
        chkDemand.Checked = False
        txtLoanName.Focus()
    End Sub

    Public Sub Show_Add()
        bool_Edit = False
        Me.ShowDialog()
    End Sub

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            bool_Edit = True
            txtLoanCode.Text = DataRow.Cells("LoanNameCode").Value
            txtLoanName.Text = DataRow.Cells("LoanName").Value
            cmbStatus.SelectedIndex = IIf(DataRow.Cells("Status").Value = True, 0, 1)
            chkDemand.Checked = DataRow.Cells("Demand").Value
            If DataRow.Cells("DemandType").Value = 0 Then
                optNone.Checked = True
            ElseIf DataRow.Cells("DemandType").Value = 1 Then
                optFixed.Checked = True
            ElseIf DataRow.Cells("DemandType").Value = 2 Then
                optJLDemand.Checked = True
            Else
                optLoanDemand.Checked = True
            End If
            Me.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub chkDemand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDemand.CheckedChanged
        pnlDemandType.Visible = chkDemand.Checked
    End Sub
End Class