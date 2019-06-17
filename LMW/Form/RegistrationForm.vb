Public Class RegistrationForm
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Encode(serial2) = txtPassword.Text.Trim Then
            Dim ICode As Integer = objDScal("select isnull(max(informationcode),0)+1 from tbl_Srichu")
            objDT("insert into tbl_Srichu select " & ICode & ",'" & txtPassword.Text.Trim & "'")
            MsgBox("Registration Successful.....  CLOSE AND RESTART YOUR PROGRAM ", MsgBoxStyle.OkOnly, Mssg)
            End
        Else
            MsgBox("Invalid Registration Key.  Contact Your Program Vendor", MsgBoxStyle.OkOnly, Mssg)
            txtPassword.Text = ""
            txtUserName.Text = serial2
            txtPassword.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnOK_Click(sender, e)
        End If
    End Sub

    Private Sub RegistrationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Text = serial2

        If int_UserCode = 1001 Then
            btnGenerate.Visible = True
        Else
            btnGenerate.Visible = False
        End If
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        txtPassword.Text = Encode(txtUserName.Text)
    End Sub
End Class