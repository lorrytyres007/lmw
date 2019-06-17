
Public Class frmGroup
    Dim bool_Edit As Boolean
    Dim objGroup As New DBLayer.clsGroup
    Dim companycode As Integer

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            bool_Edit = True
            bindata()
            companycode = DataRow.Cells("CompanyCode").Value
            txtGroupCode.Text = DataRow.Cells("GroupCode").Value
            txtGroupName.Text = DataRow.Cells("GroupName").Value
            cmbonBalanceSheet.SelectedIndex = IIf(DataRow.Cells("Onbalancesheet").Value = True, 0, 1)
            cmbOnProfitLoss.SelectedIndex = IIf(DataRow.Cells("onProfitloss").Value = True, 0, 1)
            cmbOnTrading.SelectedIndex = IIf(DataRow.Cells("OnTrading").Value = True, 0, 1)
            cmbYesNo.SelectedIndex = IIf(DataRow.Cells("OnReport").Value = True, 0, 1)
            cmbStatus.SelectedIndex = IIf(DataRow.Cells("Status").Value = "ACTIVE", 0, 1)
            cmbAccountType.SelectedValue = DataRow.Cells("AccountTypeCode").Value
            'If DataRow.Cells("DELFLAG").Value = False Then
            '    txtGroupName.Enabled = False
            'Else
            '    txtGroupName.Enabled = True
            'End If
            Me.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Show_Add()
        bool_Edit = False
        Me.ShowDialog()
    End Sub

    Private Sub frmGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "Group Details")
        If bool_Edit = False Then
            bindata()
            cmbStatus.SelectedIndex = 0
            cmbonBalanceSheet.SelectedIndex = 0
            cmbOnProfitLoss.SelectedIndex = 0
            cmbOnTrading.SelectedIndex = 0
            companycode = int_CompanyCode
            cmbAccountType.SelectedIndex = 0
            cmbYesNo.SelectedIndex = 0
            txtGroupName.Enabled = True
        End If
    End Sub
    Private Sub bindata()
        cmbAccountType.RecordSet(objGroup.BindData.Tables(0), "AccountTypeName", "AccountTypeCode")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtGroupName.Text.Trim = "" Then
                MsgBox("Group should not be empty", MsgBoxStyle.Information, Mssg)
                txtGroupName.Focus()
                Return
            End If
            objGroup.GroupCode = IIf(txtGroupCode.Text.Trim() = String.Empty, 0, txtGroupCode.Text)
            objGroup.GroupName = txtGroupName.Text.Trim()
            objGroup.OnBalanceSheet = IIf(cmbonBalanceSheet.SelectedIndex = 0, 1, 0)
            objGroup.OnProfitLoss = IIf(cmbOnProfitLoss.SelectedIndex = 0, 1, 0)
            objGroup.OnTrading = IIf(cmbOnTrading.SelectedIndex = 0, 1, 0)
            objGroup.Status = IIf(cmbStatus.SelectedIndex = 0, 1, 0)
            objGroup.OnReport = IIf(cmbYesNo.SelectedIndex = 0, 1, 0)
            objGroup.CompanyCode = int_CompanyCode
            objGroup.AccountTypeCode = cmbAccountType.ColData("AccountTypeCode")
            If bool_Edit = False Then
                objGroup.SaveRecords()
                objGroup.CompanyCode = int_CompanyCode
                frmGroupDetails.Grid.RecordSet(objGroup.GetRecords(), "GroupCode,Status,Companycode")
                MessageBox.Show("The record is saved", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnClear_Click(sender, e)
            Else
                'objGroup.GroupCode = Val(txtGroupCode.Text)
                objGroup.UpdateRecords()
                objGroup.CompanyCode = int_CompanyCode
                frmGroupDetails.Grid.RecordSet(objGroup.GetRecords(), "GroupCode,Status,CompanyCode,AccounttypeCode")
                MessageBox.Show("The record is updated", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnExit_Click(sender, e)
            End If
        Catch ex As Exception
            If ex.Message.Contains("UK_tbl_Group_GroupName") Then
                MsgBox("Already exist the Group", MsgBoxStyle.Information, Mssg)
                txtGroupName.Focus()
            ElseIf ex.Message.Contains("UK_tbl_Group_GroupID") Then
                MsgBox("Already exist the Group ID", MsgBoxStyle.Information, Mssg)
                txtGroupName.Focus()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End If
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim Code As Integer = Val(txtGroupCode.Text)
        FormClear(Me)
        txtGroupCode.Text = Code
        cmbStatus.Enabled = True
        txtGroupName.Enabled = True
        txtGroupName.Focus()
    End Sub
End Class