Imports System.Data.SqlClient

Public Class frmUser
    Dim bool_Edit As Boolean

    Private Sub frmUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If gbPassword.Visible = True Then btnExit_Click(sender, e)
        End If
    End Sub

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "User Details")
        If bool_Edit = True Then
            gbPassword.BringToFront()
            gbPassword.Visible = True
        Else
            gbPassword.SendToBack()
            gbPassword.Visible = False
            cmbUserLevel.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtUserName.Text.Trim = "" Then
                MsgBox("User Name should not be empty", MsgBoxStyle.Information, Mssg)
                txtUserName.Focus()
                Exit Sub
            End If

            If txtPassword.Text.Trim = "" Then
                MsgBox("Password should not be empty", MsgBoxStyle.Information, Mssg)
                txtPassword.Focus()
                Exit Sub
            End If

            If txtPassword.Text.Trim <> txtRetypePassword.Text.Trim Then
                MsgBox("Check your password", MsgBoxStyle.Information, Mssg)
                txtPassword.Focus()
                Exit Sub
            End If

            If cmbUserLevel.SelectedIndex = 0 Then
                MsgBox("Select the User Level", MsgBoxStyle.Information, Mssg)
                cmbUserLevel.Focus()
                Exit Sub
            End If

            objSqlCommand = New SqlCommand("sp_User_AddEdit", objSqlConnection)
            objSqlCommand.CommandType = CommandType.StoredProcedure
            If bool_Edit = False Then
                objSqlCommand.Parameters.AddWithValue("@C_User", int_UserCode)
                objSqlCommand.Parameters.AddWithValue("@C_Node", int_NodeCode)
            Else
                objSqlCommand.Parameters.AddWithValue("@E_User", int_UserCode)
                objSqlCommand.Parameters.AddWithValue("@E_Node", int_NodeCode)
                objSqlCommand.Parameters.AddWithValue("@UserCode", Val(txtUserCode.Text))
            End If
            objSqlCommand.Parameters.AddWithValue("@UserName", Encode(txtUserName.Text.Trim()))
            objSqlCommand.Parameters.AddWithValue("@Password", Encode(txtPassword.Text.Trim()))
            objSqlCommand.Parameters.AddWithValue("@UserLevel", Encode(cmbUserLevel.SelectedIndex))
            If cmbStatus.SelectedIndex = 0 Then
                objSqlCommand.Parameters.AddWithValue("@Status", 1)
            Else
                objSqlCommand.Parameters.AddWithValue("@Status", 0)
            End If
            frmUserDetails.GridFill(objDT(objSqlCommand))
            If bool_Edit = False Then
                MessageBox.Show("The record is saved", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnClear_Click(sender, e)
            Else
                MessageBox.Show("The record is updated", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnExit_Click(sender, e)
            End If
        Catch ex As Exception
            If ex.Message.Contains("UK_UserName_tblUser") Then
                MsgBox("Already exist the User Name", MsgBoxStyle.Critical, Mssg)
                txtUserName.Focus()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
            End If
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim Code As Integer = Val(txtUserCode.Text)
        FormClear(Me)
        txtUserCode.Text = Code
        If bool_Edit = True Then
            txtConfirmPassword.Focus()
        Else
            txtUserName.Focus()
        End If
    End Sub

    Public Sub Show_Add()
        bool_Edit = False
        txtUserName.Focus()
        Me.ShowDialog()
    End Sub

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        bool_Edit = True
        txtUserCode.Text = DataRow.Cells("UserCode").Value
        txtUserName.Text = DataRow.Cells("UserName").Value
        txtPassword.Text = DataRow.Cells("Password").Value
        txtRetypePassword.Text = DataRow.Cells("Password").Value
        cmbUserLevel.SelectedItem = DataRow.Cells("UserLevel").Value
        cmbStatus.SelectedIndex = IIf(DataRow.Cells("Status").Value, 0, 1)
        Me.ShowDialog()
    End Sub

    Private Sub txtConfirmPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConfirmPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnOK_Click(sender, e) : txtConfirmPassword.SelectAll()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtPassword.Text.Trim = txtConfirmPassword.Text.Trim Then
            gbPassword.Visible = False
            txtUserName.Focus()
        Else
            MsgBox("Invalid Password", MsgBoxStyle.Information, Mssg)
            txtConfirmPassword.Focus()
        End If
    End Sub

    Private Sub btnOK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOK.KeyDown
        If e.KeyCode = Keys.Escape Then btnExit_Click(sender, e)
    End Sub

    Private Sub frmUser_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If bool_Edit = True Then
            txtConfirmPassword.Focus()
        Else
            txtUserName.Focus()
        End If
    End Sub
End Class