Public Class CompanySelection

    Private Sub CompanySelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objDSet As DataSet = objDS("sp_SelectCompany_BindData")
        cmbCompany.RecordSet(objDSet.Tables(0), "ShortName", "CompanyCode")
        cmbFYear.RecordSet(objDSet.Tables(1), "FYear", "FYCode")


        Dim intComp As Integer = objDSet.Tables(0).Rows.Count

        If objDSet.Tables(0).Rows.Count > 0 Then
            cmbCompany.SelectedIndex = 1
            cmbFYear.SelectedIndex = cmbFYear.Items.Count - 1
            int_CompanyCode = cmbCompany.ColData("CompanyCode")
        Else
            ShowForm(frmCompany)
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cmbCompany.SelectedIndex = 0 Then
            MsgBox("Select  the company", MsgBoxStyle.Information, Mssg)
            cmbCompany.Focus()
            Exit Sub
        End If
        If cmbFYear.SelectedIndex = 0 Then
            MsgBox("Select  the Financial Year", MsgBoxStyle.Information, Mssg)
            cmbFYear.Focus()
            Exit Sub
        End If
        int_CompanyCode = cmbCompany.ColData("CompanyCode")
        int_FYearCode = cmbFYear.ColData("FYCode")
        str_TamilFont = cmbCompany.ColData("TypingFont")

        str_SighningAuthority = cmbCompany.ColData("SighningAuthority")

        MainForm.tslSocietyCode.Text = cmbCompany.ColData("CompanyCode")
        MainForm.tslBranchname.Text = str_Branchname
        MainForm.tslDate.Text = Format(CurDate, "dd/MM/yyyy")
        MainForm.tslFY.Text = objDScal("sp_FYear_GetByFYCode " & int_FYearCode)
        'MsgBox(str_TamilFont)
        MainForm.tslFontName.Text = str_TamilFont
        If Len(AFONT) > 0 Then
            str_TamilFont = IIf(str_TamilFont = "RATam", "Bamini", IIf(str_TamilFont = "THAMARAI", "LT-TM-THAMARAI", str_TamilFont))
        End If
        'MainForm.lblCompanyName.Font = New Font(str_TamilFont, 18)
        MainForm.lblCompanyName.Text = cmbCompany.ColData("CompanyName")

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        'Me.Hide()
        'ShowForm(frmCompany)
        'Dim objDSet As DataSet = objDS("sp_SelectCompany_BindData")
        'cmbCompany.RecordSet(objDSet.Tables(0), "ShortName", "CompanyCode")
        'cmbFYear.RecordSet(objDSet.Tables(1), "FYear", "FYCode")
        'cmbCompany.SelectedIndex = 1
        'cmbFYear.SelectedIndex = cmbFYear.Items.Count - 1
        'int_CompanyCode = cmbCompany.ColData("CompanyCode")

    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompany.SelectedIndexChanged
        If cmbCompany.SelectedIndex >= 0 Then
            Dim FontName As String = IIf(cmbCompany.ColData("TypingFont") = "RATam", "Bamini", IIf(cmbCompany.ColData("TypingFont") = "THAMARAI", "LT-TM-THAMARAI", cmbCompany.ColData("TypingFont")))
            'lblCompanyName.Font = New Font(FontName, 12)
            lblCompanyName.Text = cmbCompany.ColData("CompanyName")
            int_CompanyCode = cmbCompany.ColData("CompanyCode")
            str_TamilFont = cmbCompany.ColData("TypingFont")
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If cmbCompany.SelectedIndex > 0 Then
            Dim FontName As String = IIf(cmbCompany.ColData("TypingFont") = "RATam", "Bamini", IIf(cmbCompany.ColData("TypingFont") = "THAMARAI", "LT-TM-THAMARAI", cmbCompany.ColData("TypingFont")))
            'lblCompanyName.Font = New Font(FontName, 12)
            lblCompanyName.Text = cmbCompany.ColData("CompanyName")
            int_CompanyCode = cmbCompany.ColData("CompanyCode")
            str_TamilFont = cmbCompany.ColData("TypingFont")
            Grid.RecordSet(objDT("sp_Company_GetAll @CompanyCode=" & int_CompanyCode))
            frmCompany.Show_Edit(Grid.CurrentRow)
        End If
            
    End Sub
End Class