<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCompanyCode = New sControls.TextBoxvb
        Me.txtCompanyName = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShortName = New sControls.TextBoxvb
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAddress1 = New sControls.TextBoxvb
        Me.txtAddress2 = New sControls.TextBoxvb
        Me.txtCity = New sControls.TextBoxvb
        Me.txtDistrict = New sControls.TextBoxvb
        Me.cmbStateName = New sControls.ComboBoxvb
        Me.txtPinCode = New sControls.TextBoxvb
        Me.txtPhoneNo = New sControls.TextBoxvb
        Me.txtWebsite = New sControls.TextBoxvb
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEmail = New sControls.TextBoxvb
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTINNo = New sControls.TextBoxvb
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCSTNo = New sControls.TextBoxvb
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtMobileNo = New sControls.TextBoxvb
        Me.cmbInsurance = New sControls.ComboBoxvb
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbTypingFont = New sControls.ComboBoxvb
        Me.lblFontName = New System.Windows.Forms.Label
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtSigningAuthority = New sControls.TextBoxvb
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(381, 514)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(305, 514)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(229, 514)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(14, 502)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 7)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCompanyCode.DecimalScale = 1
        Me.txtCompanyCode.DefaultTextBox = False
        Me.txtCompanyCode.EnterKey = True
        Me.txtCompanyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCompanyCode.Location = New System.Drawing.Point(390, 295)
        Me.txtCompanyCode.MaxLength = 5
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.ShiftKey = True
        Me.txtCompanyCode.Size = New System.Drawing.Size(48, 23)
        Me.txtCompanyCode.TabIndex = 5
        Me.txtCompanyCode.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        Me.txtCompanyCode.Visible = False
        '
        'txtCompanyName
        '
        Me.txtCompanyName.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtCompanyName.DecimalScale = 0
        Me.txtCompanyName.DefaultTextBox = False
        Me.txtCompanyName.EnterKey = True
        Me.txtCompanyName.Font = New System.Drawing.Font("Bamini", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(126, 49)
        Me.txtCompanyName.MaxLength = 100
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.ShiftKey = True
        Me.txtCompanyName.Size = New System.Drawing.Size(327, 23)
        Me.txtCompanyName.TabIndex = 1
        Me.txtCompanyName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Society Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Society Code"
        '
        'txtShortName
        '
        Me.txtShortName.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtShortName.DecimalScale = 0
        Me.txtShortName.DefaultTextBox = False
        Me.txtShortName.EnterKey = True
        Me.txtShortName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShortName.Location = New System.Drawing.Point(126, 77)
        Me.txtShortName.MaxLength = 4
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.ShiftKey = True
        Me.txtShortName.Size = New System.Drawing.Size(91, 26)
        Me.txtShortName.TabIndex = 2
        Me.txtShortName.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "District"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Pin Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Phone No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Website"
        '
        'txtAddress1
        '
        Me.txtAddress1.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtAddress1.DecimalScale = 0
        Me.txtAddress1.DefaultTextBox = False
        Me.txtAddress1.EnterKey = True
        Me.txtAddress1.Font = New System.Drawing.Font("Bamini", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(126, 105)
        Me.txtAddress1.MaxLength = 100
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ShiftKey = True
        Me.txtAddress1.Size = New System.Drawing.Size(327, 23)
        Me.txtAddress1.TabIndex = 3
        Me.txtAddress1.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtAddress2
        '
        Me.txtAddress2.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtAddress2.DecimalScale = 0
        Me.txtAddress2.DefaultTextBox = False
        Me.txtAddress2.EnterKey = True
        Me.txtAddress2.Font = New System.Drawing.Font("Bamini", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(126, 133)
        Me.txtAddress2.MaxLength = 100
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ShiftKey = True
        Me.txtAddress2.Size = New System.Drawing.Size(327, 23)
        Me.txtAddress2.TabIndex = 4
        Me.txtAddress2.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtCity
        '
        Me.txtCity.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtCity.DecimalScale = 0
        Me.txtCity.DefaultTextBox = False
        Me.txtCity.EnterKey = True
        Me.txtCity.Font = New System.Drawing.Font("Bamini", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(126, 161)
        Me.txtCity.MaxLength = 50
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ShiftKey = True
        Me.txtCity.Size = New System.Drawing.Size(232, 23)
        Me.txtCity.TabIndex = 5
        Me.txtCity.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtDistrict
        '
        Me.txtDistrict.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtDistrict.DecimalScale = 0
        Me.txtDistrict.DefaultTextBox = False
        Me.txtDistrict.EnterKey = True
        Me.txtDistrict.Font = New System.Drawing.Font("Bamini", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrict.Location = New System.Drawing.Point(126, 189)
        Me.txtDistrict.MaxLength = 50
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.ShiftKey = True
        Me.txtDistrict.Size = New System.Drawing.Size(232, 23)
        Me.txtDistrict.TabIndex = 6
        Me.txtDistrict.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'cmbStateName
        '
        Me.cmbStateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStateName.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbStateName.DefaultText = "--SELECT--"
        Me.cmbStateName.EnterKey = True
        Me.cmbStateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbStateName.FormattingEnabled = True
        Me.cmbStateName.Location = New System.Drawing.Point(126, 217)
        Me.cmbStateName.Name = "cmbStateName"
        Me.cmbStateName.ShiftKey = True
        Me.cmbStateName.Size = New System.Drawing.Size(232, 24)
        Me.cmbStateName.TabIndex = 7
        Me.cmbStateName.Validation = True
        '
        'txtPinCode
        '
        Me.txtPinCode.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtPinCode.DecimalScale = 0
        Me.txtPinCode.DefaultTextBox = False
        Me.txtPinCode.EnterKey = True
        Me.txtPinCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPinCode.Location = New System.Drawing.Point(126, 246)
        Me.txtPinCode.MaxLength = 6
        Me.txtPinCode.Name = "txtPinCode"
        Me.txtPinCode.ShiftKey = True
        Me.txtPinCode.Size = New System.Drawing.Size(91, 23)
        Me.txtPinCode.TabIndex = 8
        Me.txtPinCode.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtPhoneNo.DecimalScale = 0
        Me.txtPhoneNo.DefaultTextBox = False
        Me.txtPhoneNo.EnterKey = True
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPhoneNo.Location = New System.Drawing.Point(126, 274)
        Me.txtPhoneNo.MaxLength = 30
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.ShiftKey = True
        Me.txtPhoneNo.Size = New System.Drawing.Size(232, 23)
        Me.txtPhoneNo.TabIndex = 9
        Me.txtPhoneNo.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtWebsite
        '
        Me.txtWebsite.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtWebsite.DecimalScale = 0
        Me.txtWebsite.DefaultTextBox = False
        Me.txtWebsite.EnterKey = True
        Me.txtWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtWebsite.Location = New System.Drawing.Point(126, 330)
        Me.txtWebsite.MaxLength = 30
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.ShiftKey = True
        Me.txtWebsite.Size = New System.Drawing.Size(232, 23)
        Me.txtWebsite.TabIndex = 11
        Me.txtWebsite.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtEmail.DecimalScale = 0
        Me.txtEmail.DefaultTextBox = False
        Me.txtEmail.EnterKey = True
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(126, 358)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ShiftKey = True
        Me.txtEmail.Size = New System.Drawing.Size(232, 22)
        Me.txtEmail.TabIndex = 12
        Me.txtEmail.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 389)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "TIN"
        '
        'txtTINNo
        '
        Me.txtTINNo.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtTINNo.DecimalScale = 0
        Me.txtTINNo.DefaultTextBox = False
        Me.txtTINNo.EnterKey = True
        Me.txtTINNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTINNo.Location = New System.Drawing.Point(126, 386)
        Me.txtTINNo.MaxLength = 30
        Me.txtTINNo.Name = "txtTINNo"
        Me.txtTINNo.ShiftKey = True
        Me.txtTINNo.Size = New System.Drawing.Size(232, 23)
        Me.txtTINNo.TabIndex = 13
        Me.txtTINNo.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 417)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "CSTNo"
        '
        'txtCSTNo
        '
        Me.txtCSTNo.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtCSTNo.DecimalScale = 0
        Me.txtCSTNo.DefaultTextBox = False
        Me.txtCSTNo.EnterKey = True
        Me.txtCSTNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCSTNo.Location = New System.Drawing.Point(126, 414)
        Me.txtCSTNo.MaxLength = 30
        Me.txtCSTNo.Name = "txtCSTNo"
        Me.txtCSTNo.ShiftKey = True
        Me.txtCSTNo.Size = New System.Drawing.Size(232, 23)
        Me.txtCSTNo.TabIndex = 14
        Me.txtCSTNo.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 445)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 16)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Mobile No"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtMobileNo.DecimalScale = 0
        Me.txtMobileNo.DefaultTextBox = False
        Me.txtMobileNo.EnterKey = True
        Me.txtMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMobileNo.Location = New System.Drawing.Point(126, 302)
        Me.txtMobileNo.MaxLength = 30
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.ShiftKey = True
        Me.txtMobileNo.Size = New System.Drawing.Size(232, 23)
        Me.txtMobileNo.TabIndex = 10
        Me.txtMobileNo.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'cmbInsurance
        '
        Me.cmbInsurance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbInsurance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbInsurance.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbInsurance.DefaultText = "--SELECT--"
        Me.cmbInsurance.Enabled = False
        Me.cmbInsurance.EnterKey = True
        Me.cmbInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbInsurance.FormattingEnabled = True
        Me.cmbInsurance.Items.AddRange(New Object() {"--SELECT--", "Yes", "No"})
        Me.cmbInsurance.Location = New System.Drawing.Point(126, 442)
        Me.cmbInsurance.Name = "cmbInsurance"
        Me.cmbInsurance.ShiftKey = True
        Me.cmbInsurance.Size = New System.Drawing.Size(91, 24)
        Me.cmbInsurance.TabIndex = 15
        Me.cmbInsurance.Validation = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Typing Font Name"
        '
        'cmbTypingFont
        '
        Me.cmbTypingFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTypingFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTypingFont.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbTypingFont.DefaultText = "--SELECT--"
        Me.cmbTypingFont.EnterKey = True
        Me.cmbTypingFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypingFont.FormattingEnabled = True
        Me.cmbTypingFont.Items.AddRange(New Object() {"--SELECT--", "English"})
        Me.cmbTypingFont.Location = New System.Drawing.Point(126, 14)
        Me.cmbTypingFont.Name = "cmbTypingFont"
        Me.cmbTypingFont.ShiftKey = True
        Me.cmbTypingFont.Size = New System.Drawing.Size(206, 28)
        Me.cmbTypingFont.TabIndex = 0
        Me.cmbTypingFont.Validation = True
        '
        'lblFontName
        '
        Me.lblFontName.AutoSize = True
        Me.lblFontName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFontName.ForeColor = System.Drawing.Color.Blue
        Me.lblFontName.Location = New System.Drawing.Point(342, 16)
        Me.lblFontName.Name = "lblFontName"
        Me.lblFontName.Size = New System.Drawing.Size(16, 24)
        Me.lblFontName.TabIndex = 25
        Me.lblFontName.Text = "."
        '
        'Combo1
        '
        Me.Combo1.FormattingEnabled = True
        Me.Combo1.Location = New System.Drawing.Point(14, 521)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(124, 21)
        Me.Combo1.TabIndex = 26
        Me.Combo1.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 477)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Signing Authority"
        '
        'txtSigningAuthority
        '
        Me.txtSigningAuthority.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtSigningAuthority.DecimalScale = 0
        Me.txtSigningAuthority.DefaultTextBox = False
        Me.txtSigningAuthority.EnterKey = True
        Me.txtSigningAuthority.Font = New System.Drawing.Font("Bamini", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigningAuthority.Location = New System.Drawing.Point(124, 472)
        Me.txtSigningAuthority.MaxLength = 50
        Me.txtSigningAuthority.Name = "txtSigningAuthority"
        Me.txtSigningAuthority.ShiftKey = True
        Me.txtSigningAuthority.Size = New System.Drawing.Size(234, 23)
        Me.txtSigningAuthority.TabIndex = 16
        Me.txtSigningAuthority.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(463, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSigningAuthority)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me.lblFontName)
        Me.Controls.Add(Me.cmbTypingFont)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbInsurance)
        Me.Controls.Add(Me.txtCSTNo)
        Me.Controls.Add(Me.txtTINNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtWebsite)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtPinCode)
        Me.Controls.Add(Me.cmbStateName)
        Me.Controls.Add(Me.txtDistrict)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtShortName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompanyCode)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCompany"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCompanyCode As sControls.TextBoxvb
    Friend WithEvents txtCompanyName As sControls.TextBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShortName As sControls.TextBoxvb
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As sControls.TextBoxvb
    Friend WithEvents txtAddress2 As sControls.TextBoxvb
    Friend WithEvents txtCity As sControls.TextBoxvb
    Friend WithEvents txtDistrict As sControls.TextBoxvb
    Friend WithEvents cmbStateName As sControls.ComboBoxvb
    Friend WithEvents txtPinCode As sControls.TextBoxvb
    Friend WithEvents txtPhoneNo As sControls.TextBoxvb
    Friend WithEvents txtWebsite As sControls.TextBoxvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As sControls.TextBoxvb
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTINNo As sControls.TextBoxvb
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCSTNo As sControls.TextBoxvb
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As sControls.TextBoxvb
    Friend WithEvents cmbInsurance As sControls.ComboBoxvb
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTypingFont As sControls.ComboBoxvb
    Friend WithEvents lblFontName As System.Windows.Forms.Label
    Friend WithEvents Combo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSigningAuthority As sControls.TextBoxvb
End Class
