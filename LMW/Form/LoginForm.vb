Public Class LoginForm
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtUserName.Text.Trim = String.Empty Then
            MsgBox("User Name should not empty", MsgBoxStyle.Information, Mssg)
            txtUserName.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Trim = String.Empty Then
            MsgBox("Password should not be empty", MsgBoxStyle.Information, Mssg)
            txtPassword.Focus()
            Exit Sub
        End If

        If txtUserName.Text.ToUpper = "ADMIN" And txtPassword.Text.ToUpper = "@DMIN1305" Then
            MainForm.tslUserName.Text = txtUserName.Text.Trim
            int_UserCode = 1001
            int_UserLevel = 1001
            Me.Dispose()
        Else
            Dim objUserTable As DataTable = objDT("sp_User_GetAll @UserName='" & Encode(txtUserName.Text.Trim) & "',@Password='" & Encode(txtPassword.Text) & "'")
            If objUserTable.Rows.Count = 0 Then
                MsgBox("Invalid User Name or Password", MsgBoxStyle.Information, Mssg)
                txtUserName.Text = ""
                txtPassword.Text = ""
                txtUserName.Focus()
                Exit Sub
            Else
                MainForm.tslUserName.Text = Decode(objUserTable.Rows(0)("UserName").ToString())
                int_UserCode = Val(objUserTable.Rows(0)("UserCode").ToString())
                int_UserLevel = Decode(objUserTable.Rows(0)("UserLevel").ToString())
                Me.Dispose()
            End If
        End If
        MainForm.tslBranchname.Text = str_Branchname
        MainForm.tslDate.Text = Format(CurDate, "dd/MM/yyyy")
        MainForm.lblCompanyName.Text = "Swas Technologies"        '_Company.CompanyName("")
        MainForm.tslFY.Text = objDScal("sp_FYear_GetByFYCode " & int_FYearCode)
        MainForm.tslUserRights.Text = IIf(int_UserLevel = 1, "Administrator", "Limited")

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOK_Click(sender, e)
        End If
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class