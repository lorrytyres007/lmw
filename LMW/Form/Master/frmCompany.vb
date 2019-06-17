Imports System
Imports System.Drawing.Text
Imports System.Drawing

Public Class frmCompany



    Dim bool_Edit As Boolean
    Dim objCompany As New DBLayer.clsCompany
    Dim FONTNAME As String

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            bool_Edit = True
            Bind_Data()
            cmbTypingFont.SelectedIndex = IIf(DataRow.Cells("TypingFont").Value = "ARIAL", 1, IIf(DataRow.Cells("TypingFont").Value = "RATam", 2, IIf(DataRow.Cells("TypingFont").Value = "THAMARAI", 4, IIf(DataRow.Cells("TypingFont").Value = "TSCU_PARANAR", 3, 0))))

            txtCompanyCode.Text = DataRow.Cells("CompanyCode").Value
            txtCompanyName.Text = DataRow.Cells("CompanyName").Value
            txtShortName.Text = DataRow.Cells("ShortName").Value
            txtAddress1.Text = Convert.ToString(DataRow.Cells("Address1").Value)
            txtAddress2.Text = Convert.ToString(DataRow.Cells("Address2").Value)
            txtCity.Text = Convert.ToString(DataRow.Cells("City").Value)
            txtDistrict.Text = Convert.ToString(DataRow.Cells("District").Value)
            cmbStateName.SelectedIndex = DataRow.Cells("StateCode").Value
            txtPinCode.Text = Convert.ToString(DataRow.Cells("PinCode").Value)
            txtPhoneNo.Text = Convert.ToString(DataRow.Cells("PhoneNo").Value)
            txtMobileNo.Text = Convert.ToString(DataRow.Cells("MobileNo").Value)
            txtWebsite.Text = Convert.ToString(DataRow.Cells("Website").Value)
            txtEmail.Text = Convert.ToString(DataRow.Cells("Email").Value)
            txtTINNo.Text = Convert.ToString(DataRow.Cells("TINNo").Value)
            txtCSTNo.Text = Convert.ToString(DataRow.Cells("CSTNo").Value)
            cmbInsurance.SelectedIndex = IIf(DataRow.Cells("InsuranceFlag").Value = "Y", 1, 2)
            txtSigningAuthority.Text = IIf(IsDBNull(DataRow.Cells("SighningAuthority").Value) = True, "", DataRow.Cells("SighningAuthority").Value)

            cmbTypingFont.Enabled = False
            Me.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Show_Add()
        bool_Edit = False
        Me.ShowDialog()
    End Sub

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "Company Details", False)
        If bool_Edit = False Then
            Bind_Data()
        End If
        If cmbTypingFont.Enabled = True Then
            cmbTypingFont.SelectedIndex = 1
            cmbStateName.SelectedIndex = 0
            cmbInsurance.SelectedIndex = 0

            ' Need to have System.Drawing reference

            ' Create a obejct of InstalledFontCollection 
            Dim InstalledFonts As New InstalledFontCollection
            ' Gets the array of FontFamily objects associated with this FontCollection.
            Dim fontfamilies() As FontFamily = InstalledFonts.Families()

            '   Populates font combobox with the font name

            For Each fontFamily As FontFamily In fontfamilies
                Combo1.Items.Add(fontFamily.Name)
            Next


        End If
    End Sub

    Private Sub Bind_Data()
        cmbStateName.RecordSet(objCompany.BindRecords.Tables(0), "StateName", "StateCode")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtCompanyName.Text.Trim = "" Then
                MsgBox("Company should not be empty", MsgBoxStyle.Information, Mssg)
                txtCompanyName.Focus()
                Return
            End If

            If txtShortName.Text.Trim = "" Then
                MsgBox("Company should not be empty", MsgBoxStyle.Information, Mssg)
                txtShortName.Focus()
                Return
            End If

            objCompany.CompanyCode = IIf(txtCompanyCode.Text.Trim() = String.Empty, 0, txtCompanyCode.Text)
            objCompany.ShortName = txtShortName.Text.Trim()
            objCompany.CompanyName = txtCompanyName.Text.Trim()
            objCompany.Address1 = txtAddress1.Text.Trim()
            objCompany.Address2 = txtAddress2.Text.Trim()
            objCompany.City = txtCity.Text.Trim()
            objCompany.District = txtDistrict.Text.Trim()
            objCompany.StateCode = cmbStateName.ColData("StateCode")
            objCompany.PinCode = txtPinCode.Text.Trim()
            objCompany.PhoneNo = txtPhoneNo.Text.Trim()
            objCompany.MobileNo = txtMobileNo.Text.Trim()
            objCompany.Website = txtWebsite.Text.Trim()
            objCompany.Email = txtEmail.Text.Trim()
            objCompany.TINNo = txtTINNo.Text.Trim()
            objCompany.CSTNo = txtCSTNo.Text.Trim()
            objCompany.signingAuthority = txtSigningAuthority.Text
            objCompany.InsuranceFlag = IIf(cmbInsurance.SelectedIndex = 1, "Y", "N")
            objCompany.TypingFont = IIf(cmbTypingFont.SelectedIndex = 1, "ARIAL", IIf(cmbTypingFont.SelectedIndex = 2, "RATam", IIf(cmbTypingFont.SelectedIndex = 3, "TSCU_PARANAR", "THAMARAI")))
            If bool_Edit = False Then
                objCompany.SaveRecords()
                MessageBox.Show("The record is saved", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                objCompany.UpdateRecords()
                MessageBox.Show("The record is updated", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            btnExit_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
        If cmbTypingFont.Enabled = True Then
            CompanySelection.ShowDialog()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim Code As Integer = Val(txtCompanyCode.Text)
        FormClear(Me)
        txtCompanyCode.Text = Code
        txtShortName.Focus()
    End Sub


    Private Sub cmbTypingFont_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTypingFont.SelectedIndexChanged
        If cmbTypingFont.SelectedIndex > 0 Then
            FONTNAME = IIf(cmbTypingFont.Text = "Tamil TypeWritter", "Bamini", IIf(cmbTypingFont.Text = "English", "Arial", IIf(cmbTypingFont.Text = "Tamil UniCode", "TSCu_Paranar", "LT-TM-Thamarai")))
            lblFontName.Font = New Font(FONTNAME, 12)
            txtCompanyName.Font = New Font(FONTNAME, 12)
            txtShortName.Font = New Font(FONTNAME, 12)
            txtAddress1.Font = New Font(FONTNAME, 12)
            txtAddress2.Font = New Font(FONTNAME, 12)
            txtCity.Font = New Font(FONTNAME, 12)
            txtDistrict.Font = New Font(FONTNAME, 12)
            txtSigningAuthority.Font = New Font(FONTNAME, 12)
            If FONTNAME = "Arial" Then
                lblFontName.Text = "ARIAL"
            End If
        End If
    End Sub
End Class