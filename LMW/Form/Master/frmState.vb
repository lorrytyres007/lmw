
Public Class frmState
    Dim bool_Edit As Boolean
    Dim objState As New DBLayer.clsState

    Private Sub frmState_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "State Details")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtStateName.Text.Trim = "" Then
                MsgBox("State Name should not be empty", MsgBoxStyle.Information, Mssg)
                txtStateName.Focus()
                Return
            End If
            objState.StateCode = Val(txtStateCode.Text)
            objState.StateName = txtStateName.Text.Trim()
            objState.Status = IIf(cmbStatus.SelectedIndex = 0, 1, 0)
            If bool_Edit = False Then
                frmStateDetails.Grid.RecordSet(objState.SaveRecords(), "StateCode")
                MessageBox.Show("The record is saved", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnClear_Click(sender, e)
            Else
                frmStateDetails.Grid.RecordSet(objState.UpdateRecords(), "StateCode")
                MessageBox.Show("The record is updated", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnExit_Click(sender, e)
            End If
        Catch ex As Exception
            If ex.Message.Contains("UK_tbl_State_StateName") Then
                MessageBox.Show("Already exist the State Name", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtStateName.Focus()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End If
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim Code As Integer = Val(txtStateCode.Text)
        FormClear(Me)
        txtStateCode.Text = Code
        txtStateName.Focus()
    End Sub

    Public Sub Show_Add()
        bool_Edit = False
        Me.ShowDialog()
    End Sub

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            bool_Edit = True
            txtStateCode.Text = DataRow.Cells("StateCode").Value
            txtStateName.Text = DataRow.Cells("StateName").Value
            cmbStatus.SelectedIndex = IIf(DataRow.Cells("Status").Value = True, 0, 1)
            Me.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class