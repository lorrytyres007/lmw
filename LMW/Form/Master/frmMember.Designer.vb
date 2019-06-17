<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
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
        Me.txtMemberCode = New sControls.TextBoxvb
        Me.txtNumber = New sControls.TextBoxvb
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEmployeeNumber = New sControls.TextBoxvb
        Me.txtName = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbStatus = New sControls.ComboBoxvb
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTDOpening = New sControls.TextBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAddress1 = New sControls.TextBoxvb
        Me.txtAddress2 = New sControls.TextBoxvb
        Me.txtAddress3 = New sControls.TextBoxvb
        Me.txtAddress4 = New sControls.TextBoxvb
        Me.txtMobileNo = New sControls.TextBoxvb
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CmbMemberType = New sControls.ComboBoxvb
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtShareOpening = New sControls.TextBoxvb
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtMemberName_Tamil = New sControls.TextBoxvb
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtAddress_Tamil1 = New sControls.TextBoxvb
        Me.txtAddress_Tamil2 = New sControls.TextBoxvb
        Me.txtAddress_Tamil3 = New sControls.TextBoxvb
        Me.txtAddress_Tamil4 = New sControls.TextBoxvb
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lstDevices = New System.Windows.Forms.ListBox
        Me.txtImagepath = New sControls.TextBoxvb
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnTakePhoto = New System.Windows.Forms.Button
        Me.llblClearImage = New System.Windows.Forms.Label
        Me.llbSelectlImage = New System.Windows.Forms.Label
        Me.PnlImage = New System.Windows.Forms.Panel
        Me.pbImage = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PnlImage.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(490, 7)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 34)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(375, 7)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 34)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(260, 7)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 34)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtMemberCode
        '
        Me.txtMemberCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMemberCode.DecimalScale = 1
        Me.txtMemberCode.DefaultTextBox = False
        Me.txtMemberCode.EnterKey = True
        Me.txtMemberCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMemberCode.Location = New System.Drawing.Point(18, 7)
        Me.txtMemberCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMemberCode.MaxLength = 5
        Me.txtMemberCode.Name = "txtMemberCode"
        Me.txtMemberCode.ShiftKey = True
        Me.txtMemberCode.Size = New System.Drawing.Size(47, 23)
        Me.txtMemberCode.TabIndex = 5
        Me.txtMemberCode.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        Me.txtMemberCode.Visible = False
        '
        'txtNumber
        '
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtNumber.DecimalScale = 0
        Me.txtNumber.DefaultTextBox = False
        Me.txtNumber.EnterKey = True
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(163, 22)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNumber.MaxLength = 50
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.ShiftKey = True
        Me.txtNumber.Size = New System.Drawing.Size(94, 26)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumber.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Token Number"
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeNumber.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtEmployeeNumber.DecimalScale = 0
        Me.txtEmployeeNumber.DefaultTextBox = False
        Me.txtEmployeeNumber.EnterKey = True
        Me.txtEmployeeNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(163, 55)
        Me.txtEmployeeNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmployeeNumber.MaxLength = 100
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.ShiftKey = True
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(94, 26)
        Me.txtEmployeeNumber.TabIndex = 1
        Me.txtEmployeeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmployeeNumber.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtName.DecimalScale = 0
        Me.txtName.DefaultTextBox = False
        Me.txtName.EnterKey = True
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(163, 88)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ShiftKey = True
        Me.txtName.Size = New System.Drawing.Size(346, 26)
        Me.txtName.TabIndex = 2
        Me.txtName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Member Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Member Name"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStatus.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbStatus.DefaultText = "--SELECT--"
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.EnterKey = True
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"ACTIVE", "INACTIVE"})
        Me.cmbStatus.Location = New System.Drawing.Point(163, 188)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShiftKey = True
        Me.cmbStatus.Size = New System.Drawing.Size(109, 28)
        Me.cmbStatus.TabIndex = 6
        Me.cmbStatus.Validation = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Status"
        '
        'txtTDOpening
        '
        Me.txtTDOpening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTDOpening.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtTDOpening.DecimalScale = 2
        Me.txtTDOpening.DefaultTextBox = False
        Me.txtTDOpening.EnterKey = True
        Me.txtTDOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDOpening.Location = New System.Drawing.Point(164, 155)
        Me.txtTDOpening.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTDOpening.MaxLength = 100
        Me.txtTDOpening.Name = "txtTDOpening"
        Me.txtTDOpening.ShiftKey = True
        Me.txtTDOpening.Size = New System.Drawing.Size(94, 26)
        Me.txtTDOpening.TabIndex = 4
        Me.txtTDOpening.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTDOpening.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "TD Opening"
        '
        'txtAddress1
        '
        Me.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress1.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAddress1.DecimalScale = 0
        Me.txtAddress1.DefaultTextBox = False
        Me.txtAddress1.EnterKey = True
        Me.txtAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(163, 270)
        Me.txtAddress1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress1.MaxLength = 50
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ShiftKey = True
        Me.txtAddress1.Size = New System.Drawing.Size(346, 26)
        Me.txtAddress1.TabIndex = 8
        Me.txtAddress1.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtAddress2
        '
        Me.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress2.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAddress2.DecimalScale = 0
        Me.txtAddress2.DefaultTextBox = False
        Me.txtAddress2.EnterKey = True
        Me.txtAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(163, 304)
        Me.txtAddress2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress2.MaxLength = 50
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ShiftKey = True
        Me.txtAddress2.Size = New System.Drawing.Size(346, 26)
        Me.txtAddress2.TabIndex = 9
        Me.txtAddress2.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtAddress3
        '
        Me.txtAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress3.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAddress3.DecimalScale = 0
        Me.txtAddress3.DefaultTextBox = False
        Me.txtAddress3.EnterKey = True
        Me.txtAddress3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress3.Location = New System.Drawing.Point(163, 338)
        Me.txtAddress3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress3.MaxLength = 50
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.ShiftKey = True
        Me.txtAddress3.Size = New System.Drawing.Size(346, 26)
        Me.txtAddress3.TabIndex = 10
        Me.txtAddress3.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtAddress4
        '
        Me.txtAddress4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress4.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAddress4.DecimalScale = 0
        Me.txtAddress4.DefaultTextBox = False
        Me.txtAddress4.EnterKey = True
        Me.txtAddress4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress4.Location = New System.Drawing.Point(163, 372)
        Me.txtAddress4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress4.MaxLength = 50
        Me.txtAddress4.Name = "txtAddress4"
        Me.txtAddress4.ShiftKey = True
        Me.txtAddress4.Size = New System.Drawing.Size(346, 26)
        Me.txtAddress4.TabIndex = 11
        Me.txtAddress4.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtMobileNo
        '
        Me.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMobileNo.DecimalScale = 0
        Me.txtMobileNo.DefaultTextBox = False
        Me.txtMobileNo.EnterKey = True
        Me.txtMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(163, 406)
        Me.txtMobileNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMobileNo.MaxLength = 50
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.ShiftKey = True
        Me.txtMobileNo.Size = New System.Drawing.Size(235, 26)
        Me.txtMobileNo.TabIndex = 12
        Me.txtMobileNo.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Address1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Address2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Address3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Address4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 409)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Mobile Number"
        '
        'CmbMemberType
        '
        Me.CmbMemberType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbMemberType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMemberType.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.CmbMemberType.DefaultText = "--SELECT--"
        Me.CmbMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMemberType.EnterKey = True
        Me.CmbMemberType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMemberType.FormattingEnabled = True
        Me.CmbMemberType.Items.AddRange(New Object() {"STAFF", "WORKERS", "OTHERS"})
        Me.CmbMemberType.Location = New System.Drawing.Point(164, 236)
        Me.CmbMemberType.Name = "CmbMemberType"
        Me.CmbMemberType.ShiftKey = True
        Me.CmbMemberType.Size = New System.Drawing.Size(204, 28)
        Me.CmbMemberType.TabIndex = 7
        Me.CmbMemberType.Validation = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 20)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Member Type"
        '
        'txtShareOpening
        '
        Me.txtShareOpening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShareOpening.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtShareOpening.DecimalScale = 2
        Me.txtShareOpening.DefaultTextBox = False
        Me.txtShareOpening.EnterKey = True
        Me.txtShareOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareOpening.Location = New System.Drawing.Point(415, 155)
        Me.txtShareOpening.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtShareOpening.MaxLength = 100
        Me.txtShareOpening.Name = "txtShareOpening"
        Me.txtShareOpening.ShiftKey = True
        Me.txtShareOpening.Size = New System.Drawing.Size(94, 26)
        Me.txtShareOpening.TabIndex = 5
        Me.txtShareOpening.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtShareOpening.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(271, 159)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 18)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Share Opening"
        '
        'txtMemberName_Tamil
        '
        Me.txtMemberName_Tamil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberName_Tamil.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtMemberName_Tamil.DecimalScale = 0
        Me.txtMemberName_Tamil.DefaultTextBox = False
        Me.txtMemberName_Tamil.EnterKey = True
        Me.txtMemberName_Tamil.Font = New System.Drawing.Font("VANAVIL-Avvaiyar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName_Tamil.Location = New System.Drawing.Point(163, 121)
        Me.txtMemberName_Tamil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMemberName_Tamil.MaxLength = 50
        Me.txtMemberName_Tamil.Name = "txtMemberName_Tamil"
        Me.txtMemberName_Tamil.ShiftKey = True
        Me.txtMemberName_Tamil.Size = New System.Drawing.Size(346, 27)
        Me.txtMemberName_Tamil.TabIndex = 3
        Me.txtMemberName_Tamil.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 125)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 18)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Name (Tamil)"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtAddress_Tamil1)
        Me.Panel1.Controls.Add(Me.txtAddress_Tamil2)
        Me.Panel1.Controls.Add(Me.txtAddress_Tamil3)
        Me.Panel1.Controls.Add(Me.txtAddress_Tamil4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtMemberName_Tamil)
        Me.Panel1.Controls.Add(Me.txtNumber)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtShareOpening)
        Me.Panel1.Controls.Add(Me.txtEmployeeNumber)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CmbMemberType)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmbStatus)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtTDOpening)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAddress1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtAddress2)
        Me.Panel1.Controls.Add(Me.txtMobileNo)
        Me.Panel1.Controls.Add(Me.txtAddress3)
        Me.Panel1.Controls.Add(Me.txtAddress4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 445)
        Me.Panel1.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(526, 244)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 20)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Tamil"
        '
        'txtAddress_Tamil1
        '
        Me.txtAddress_Tamil1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress_Tamil1.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAddress_Tamil1.DecimalScale = 0
        Me.txtAddress_Tamil1.DefaultTextBox = False
        Me.txtAddress_Tamil1.EnterKey = True
        Me.txtAddress_Tamil1.Font = New System.Drawing.Font("VANAVIL-Avvaiyar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress_Tamil1.Location = New System.Drawing.Point(530, 270)
        Me.txtAddress_Tamil1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress_Tamil1.MaxLength = 50
        Me.txtAddress_Tamil1.Name = "txtAddress_Tamil1"
        Me.txtAddress_Tamil1.ShiftKey = True
        Me.txtAddress_Tamil1.Size = New System.Drawing.Size(346, 27)
        Me.txtAddress_Tamil1.TabIndex = 41
        Me.txtAddress_Tamil1.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtAddress_Tamil2
        '
        Me.txtAddress_Tamil2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress_Tamil2.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAddress_Tamil2.DecimalScale = 0
        Me.txtAddress_Tamil2.DefaultTextBox = False
        Me.txtAddress_Tamil2.EnterKey = True
        Me.txtAddress_Tamil2.Font = New System.Drawing.Font("VANAVIL-Avvaiyar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress_Tamil2.Location = New System.Drawing.Point(530, 304)
        Me.txtAddress_Tamil2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress_Tamil2.MaxLength = 50
        Me.txtAddress_Tamil2.Name = "txtAddress_Tamil2"
        Me.txtAddress_Tamil2.ShiftKey = True
        Me.txtAddress_Tamil2.Size = New System.Drawing.Size(346, 27)
        Me.txtAddress_Tamil2.TabIndex = 42
        Me.txtAddress_Tamil2.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtAddress_Tamil3
        '
        Me.txtAddress_Tamil3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress_Tamil3.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAddress_Tamil3.DecimalScale = 0
        Me.txtAddress_Tamil3.DefaultTextBox = False
        Me.txtAddress_Tamil3.EnterKey = True
        Me.txtAddress_Tamil3.Font = New System.Drawing.Font("VANAVIL-Avvaiyar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress_Tamil3.Location = New System.Drawing.Point(530, 338)
        Me.txtAddress_Tamil3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress_Tamil3.MaxLength = 50
        Me.txtAddress_Tamil3.Name = "txtAddress_Tamil3"
        Me.txtAddress_Tamil3.ShiftKey = True
        Me.txtAddress_Tamil3.Size = New System.Drawing.Size(346, 27)
        Me.txtAddress_Tamil3.TabIndex = 43
        Me.txtAddress_Tamil3.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'txtAddress_Tamil4
        '
        Me.txtAddress_Tamil4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress_Tamil4.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAddress_Tamil4.DecimalScale = 0
        Me.txtAddress_Tamil4.DefaultTextBox = False
        Me.txtAddress_Tamil4.EnterKey = True
        Me.txtAddress_Tamil4.Font = New System.Drawing.Font("VANAVIL-Avvaiyar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress_Tamil4.Location = New System.Drawing.Point(530, 372)
        Me.txtAddress_Tamil4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress_Tamil4.MaxLength = 50
        Me.txtAddress_Tamil4.Name = "txtAddress_Tamil4"
        Me.txtAddress_Tamil4.ShiftKey = True
        Me.txtAddress_Tamil4.Size = New System.Drawing.Size(346, 27)
        Me.txtAddress_Tamil4.TabIndex = 44
        Me.txtAddress_Tamil4.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lstDevices)
        Me.Panel2.Controls.Add(Me.txtMemberCode)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.txtImagepath)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1211, 49)
        Me.Panel2.TabIndex = 42
        '
        'lstDevices
        '
        Me.lstDevices.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lstDevices.ItemHeight = 16
        Me.lstDevices.Location = New System.Drawing.Point(82, 7)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(89, 20)
        Me.lstDevices.TabIndex = 68
        Me.lstDevices.Visible = False
        '
        'txtImagepath
        '
        Me.txtImagepath.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtImagepath.DecimalScale = 0
        Me.txtImagepath.DefaultTextBox = False
        Me.txtImagepath.EnterKey = True
        Me.txtImagepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtImagepath.Location = New System.Drawing.Point(642, 10)
        Me.txtImagepath.Name = "txtImagepath"
        Me.txtImagepath.ShiftKey = True
        Me.txtImagepath.Size = New System.Drawing.Size(160, 23)
        Me.txtImagepath.TabIndex = 91
        Me.txtImagepath.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtImagepath.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnStart)
        Me.Panel3.Controls.Add(Me.btnTakePhoto)
        Me.Panel3.Controls.Add(Me.llblClearImage)
        Me.Panel3.Controls.Add(Me.llbSelectlImage)
        Me.Panel3.Controls.Add(Me.PnlImage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(888, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 445)
        Me.Panel3.TabIndex = 43
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(36, 400)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(95, 34)
        Me.btnStart.TabIndex = 15
        Me.btnStart.Text = "&Start Camera"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnTakePhoto
        '
        Me.btnTakePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakePhoto.Location = New System.Drawing.Point(188, 400)
        Me.btnTakePhoto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTakePhoto.Name = "btnTakePhoto"
        Me.btnTakePhoto.Size = New System.Drawing.Size(95, 34)
        Me.btnTakePhoto.TabIndex = 16
        Me.btnTakePhoto.Text = "&Take Photo"
        Me.btnTakePhoto.UseVisualStyleBackColor = True
        '
        'llblClearImage
        '
        Me.llblClearImage.AutoSize = True
        Me.llblClearImage.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblClearImage.ForeColor = System.Drawing.Color.Blue
        Me.llblClearImage.Location = New System.Drawing.Point(195, 363)
        Me.llblClearImage.Name = "llblClearImage"
        Me.llblClearImage.Size = New System.Drawing.Size(81, 20)
        Me.llblClearImage.TabIndex = 2
        Me.llblClearImage.Text = "Clear Image"
        '
        'llbSelectlImage
        '
        Me.llbSelectlImage.AutoSize = True
        Me.llbSelectlImage.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbSelectlImage.ForeColor = System.Drawing.Color.Blue
        Me.llbSelectlImage.Location = New System.Drawing.Point(60, 363)
        Me.llbSelectlImage.Name = "llbSelectlImage"
        Me.llbSelectlImage.Size = New System.Drawing.Size(47, 20)
        Me.llbSelectlImage.TabIndex = 1
        Me.llbSelectlImage.Text = "Select"
        '
        'PnlImage
        '
        Me.PnlImage.BackColor = System.Drawing.Color.Gray
        Me.PnlImage.Controls.Add(Me.pbImage)
        Me.PnlImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlImage.Location = New System.Drawing.Point(0, 0)
        Me.PnlImage.Name = "PnlImage"
        Me.PnlImage.Size = New System.Drawing.Size(321, 347)
        Me.PnlImage.TabIndex = 0
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.Color.White
        Me.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Location = New System.Drawing.Point(6, 6)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(307, 335)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 67
        Me.pbImage.TabStop = False
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1211, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Bamini", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMember"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PnlImage.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtMemberCode As sControls.TextBoxvb
    Friend WithEvents txtNumber As sControls.TextBoxvb
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeNumber As sControls.TextBoxvb
    Friend WithEvents txtName As sControls.TextBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As sControls.ComboBoxvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTDOpening As sControls.TextBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As sControls.TextBoxvb
    Friend WithEvents txtAddress2 As sControls.TextBoxvb
    Friend WithEvents txtAddress3 As sControls.TextBoxvb
    Friend WithEvents txtAddress4 As sControls.TextBoxvb
    Friend WithEvents txtMobileNo As sControls.TextBoxvb
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CmbMemberType As sControls.ComboBoxvb
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtShareOpening As sControls.TextBoxvb
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMemberName_Tamil As sControls.TextBoxvb
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PnlImage As System.Windows.Forms.Panel
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnTakePhoto As System.Windows.Forms.Button
    Friend WithEvents llblClearImage As System.Windows.Forms.Label
    Friend WithEvents llbSelectlImage As System.Windows.Forms.Label
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Friend WithEvents txtImagepath As sControls.TextBoxvb
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAddress_Tamil1 As sControls.TextBoxvb
    Friend WithEvents txtAddress_Tamil2 As sControls.TextBoxvb
    Friend WithEvents txtAddress_Tamil3 As sControls.TextBoxvb
    Friend WithEvents txtAddress_Tamil4 As sControls.TextBoxvb
End Class
