<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherEntry
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtVoucherCode = New sControls.TextBoxvb
        Me.txtAmount = New sControls.TextBoxvb
        Me.cmbRP = New sControls.ComboBoxvb
        Me.Label5 = New System.Windows.Forms.Label
        Me.Linevb1 = New sControls.Linevb(Me.components)
        Me.txtRemarks = New sControls.TextBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpVoucherDate = New sControls.DateTimeMaskvb(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtAcNo = New sControls.TextBoxvb
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnMember = New sControls.Buttonvb(Me.components)
        Me.txtMembername = New sControls.TextBoxvb
        Me.cmbEmpNo = New sControls.ComboBoxvb
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnHead = New sControls.Buttonvb(Me.components)
        Me.btnGroup = New sControls.Buttonvb(Me.components)
        Me.chkOption = New System.Windows.Forms.CheckBox
        Me.txtAdjustment = New sControls.TextBoxvb
        Me.cmbGroupName = New sControls.ComboBoxvb
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbCashAdj = New sControls.ComboBoxvb
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbHeadName = New sControls.ComboBoxvb
        Me.txtVoucherNumber = New sControls.TextBoxvb
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtCB = New sControls.TextBoxvb
        Me.txtOB = New sControls.TextBoxvb
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPTot = New sControls.TextBoxvb
        Me.txtPAdj = New sControls.TextBoxvb
        Me.txtPCash = New sControls.TextBoxvb
        Me.txtRtot = New sControls.TextBoxvb
        Me.txtRAdj = New sControls.TextBoxvb
        Me.txtRCash = New sControls.TextBoxvb
        Me.Grid = New sControls.ViewGrid
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Edit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Delete = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Particulars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cash = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Adjustment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VoucherCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntryFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HeadCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ACNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Head Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CASH"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(218, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 25)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(292, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 25)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(366, 280)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 25)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtVoucherCode
        '
        Me.txtVoucherCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtVoucherCode.DecimalScale = 0
        Me.txtVoucherCode.DefaultTextBox = False
        Me.txtVoucherCode.EnterKey = True
        Me.txtVoucherCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtVoucherCode.Location = New System.Drawing.Point(8, 278)
        Me.txtVoucherCode.Name = "txtVoucherCode"
        Me.txtVoucherCode.ShiftKey = True
        Me.txtVoucherCode.Size = New System.Drawing.Size(76, 23)
        Me.txtVoucherCode.TabIndex = 10
        Me.txtVoucherCode.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtVoucherCode.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAmount.DecimalScale = 2
        Me.txtAmount.DefaultTextBox = False
        Me.txtAmount.EnterKey = True
        Me.txtAmount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(273, 181)
        Me.txtAmount.MaxLength = 12
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ShiftKey = True
        Me.txtAmount.Size = New System.Drawing.Size(165, 26)
        Me.txtAmount.TabIndex = 6
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAmount.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'cmbRP
        '
        Me.cmbRP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRP.BackColor = System.Drawing.Color.White
        Me.cmbRP.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbRP.DefaultText = "----------"
        Me.cmbRP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRP.EnterKey = True
        Me.cmbRP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRP.FormattingEnabled = True
        Me.cmbRP.Items.AddRange(New Object() {"Receipt", "Payment"})
        Me.cmbRP.Location = New System.Drawing.Point(507, 18)
        Me.cmbRP.Name = "cmbRP"
        Me.cmbRP.ShiftKey = True
        Me.cmbRP.Size = New System.Drawing.Size(109, 26)
        Me.cmbRP.TabIndex = 1
        Me.cmbRP.Validation = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Rpt / Pyt"
        '
        'Linevb1
        '
        Me.Linevb1.Enabled = False
        Me.Linevb1.FirstColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Linevb1.Location = New System.Drawing.Point(15, 263)
        Me.Linevb1.Name = "Linevb1"
        Me.Linevb1.SecondColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Linevb1.Size = New System.Drawing.Size(506, 2)
        Me.Linevb1.TabIndex = 40
        Me.Linevb1.Text = "Linevb1"
        '
        'txtRemarks
        '
        Me.txtRemarks.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtRemarks.DecimalScale = 2
        Me.txtRemarks.DefaultTextBox = False
        Me.txtRemarks.EnterKey = True
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(121, 115)
        Me.txtRemarks.MaxLength = 50
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ShiftKey = True
        Me.txtRemarks.Size = New System.Drawing.Size(315, 26)
        Me.txtRemarks.TabIndex = 4
        Me.txtRemarks.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Remarks"
        '
        'dtpVoucherDate
        '
        Me.dtpVoucherDate.EnterKey = True
        Me.dtpVoucherDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpVoucherDate.Location = New System.Drawing.Point(147, 18)
        Me.dtpVoucherDate.Mask = "99/99/9999"
        Me.dtpVoucherDate.Name = "dtpVoucherDate"
        Me.dtpVoucherDate.ShiftKey = True
        Me.dtpVoucherDate.Size = New System.Drawing.Size(87, 23)
        Me.dtpVoucherDate.TabIndex = 0
        Me.dtpVoucherDate.Value = New Date(CType(0, Long))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Voucher Date"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtAcNo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnMember)
        Me.Panel1.Controls.Add(Me.txtMembername)
        Me.Panel1.Controls.Add(Me.cmbEmpNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btnHead)
        Me.Panel1.Controls.Add(Me.btnGroup)
        Me.Panel1.Controls.Add(Me.chkOption)
        Me.Panel1.Controls.Add(Me.txtAdjustment)
        Me.Panel1.Controls.Add(Me.cmbGroupName)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cmbCashAdj)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Linevb1)
        Me.Panel1.Controls.Add(Me.cmbHeadName)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.txtVoucherCode)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 322)
        Me.Panel1.TabIndex = 1
        '
        'txtAcNo
        '
        Me.txtAcNo.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtAcNo.DecimalScale = 0
        Me.txtAcNo.DefaultTextBox = False
        Me.txtAcNo.EnterKey = True
        Me.txtAcNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcNo.Location = New System.Drawing.Point(121, 147)
        Me.txtAcNo.MaxLength = 50
        Me.txtAcNo.Name = "txtAcNo"
        Me.txtAcNo.ShiftKey = True
        Me.txtAcNo.Size = New System.Drawing.Size(163, 26)
        Me.txtAcNo.TabIndex = 5
        Me.txtAcNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 19)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "A/c No"
        '
        'btnMember
        '
        Me.btnMember.BackColor = System.Drawing.Color.Transparent
        Me.btnMember.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMember.FlatAppearance.BorderSize = 0
        Me.btnMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMember.Location = New System.Drawing.Point(443, 81)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(18, 23)
        Me.btnMember.TabIndex = 53
        Me.btnMember.Text = "#"
        Me.btnMember.UseVisualStyleBackColor = False
        '
        'txtMembername
        '
        Me.txtMembername.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtMembername.DecimalScale = 2
        Me.txtMembername.DefaultTextBox = False
        Me.txtMembername.Enabled = False
        Me.txtMembername.EnterKey = True
        Me.txtMembername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMembername.Location = New System.Drawing.Point(240, 81)
        Me.txtMembername.MaxLength = 150
        Me.txtMembername.Name = "txtMembername"
        Me.txtMembername.ShiftKey = True
        Me.txtMembername.Size = New System.Drawing.Size(197, 26)
        Me.txtMembername.TabIndex = 3
        Me.txtMembername.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'cmbEmpNo
        '
        Me.cmbEmpNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpNo.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbEmpNo.DefaultText = "--------"
        Me.cmbEmpNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpNo.EnterKey = True
        Me.cmbEmpNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpNo.FormattingEnabled = True
        Me.cmbEmpNo.Location = New System.Drawing.Point(121, 81)
        Me.cmbEmpNo.Name = "cmbEmpNo"
        Me.cmbEmpNo.ShiftKey = True
        Me.cmbEmpNo.Size = New System.Drawing.Size(111, 26)
        Me.cmbEmpNo.TabIndex = 2
        Me.cmbEmpNo.Validation = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 19)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Emp.No"
        '
        'btnHead
        '
        Me.btnHead.BackColor = System.Drawing.Color.Transparent
        Me.btnHead.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHead.FlatAppearance.BorderSize = 0
        Me.btnHead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHead.Location = New System.Drawing.Point(443, 47)
        Me.btnHead.Name = "btnHead"
        Me.btnHead.Size = New System.Drawing.Size(18, 23)
        Me.btnHead.TabIndex = 49
        Me.btnHead.Text = "#"
        Me.btnHead.UseVisualStyleBackColor = False
        '
        'btnGroup
        '
        Me.btnGroup.BackColor = System.Drawing.Color.Transparent
        Me.btnGroup.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGroup.FlatAppearance.BorderSize = 0
        Me.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGroup.Location = New System.Drawing.Point(443, 13)
        Me.btnGroup.Name = "btnGroup"
        Me.btnGroup.Size = New System.Drawing.Size(18, 23)
        Me.btnGroup.TabIndex = 48
        Me.btnGroup.Text = "#"
        Me.btnGroup.UseVisualStyleBackColor = False
        '
        'chkOption
        '
        Me.chkOption.AutoSize = True
        Me.chkOption.Location = New System.Drawing.Point(415, 153)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Size = New System.Drawing.Size(15, 14)
        Me.chkOption.TabIndex = 47
        Me.chkOption.UseVisualStyleBackColor = True
        '
        'txtAdjustment
        '
        Me.txtAdjustment.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAdjustment.DecimalScale = 2
        Me.txtAdjustment.DefaultTextBox = False
        Me.txtAdjustment.EnterKey = True
        Me.txtAdjustment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustment.ForeColor = System.Drawing.Color.Red
        Me.txtAdjustment.Location = New System.Drawing.Point(272, 218)
        Me.txtAdjustment.MaxLength = 12
        Me.txtAdjustment.Name = "txtAdjustment"
        Me.txtAdjustment.ShiftKey = True
        Me.txtAdjustment.Size = New System.Drawing.Size(165, 26)
        Me.txtAdjustment.TabIndex = 7
        Me.txtAdjustment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAdjustment.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'cmbGroupName
        '
        Me.cmbGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGroupName.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbGroupName.DefaultText = "--Select--"
        Me.cmbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupName.EnterKey = True
        Me.cmbGroupName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupName.FormattingEnabled = True
        Me.cmbGroupName.Location = New System.Drawing.Point(121, 13)
        Me.cmbGroupName.Name = "cmbGroupName"
        Me.cmbGroupName.ShiftKey = True
        Me.cmbGroupName.Size = New System.Drawing.Size(315, 26)
        Me.cmbGroupName.TabIndex = 0
        Me.cmbGroupName.Validation = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 19)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Group Name"
        '
        'cmbCashAdj
        '
        Me.cmbCashAdj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCashAdj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCashAdj.BackColor = System.Drawing.Color.White
        Me.cmbCashAdj.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbCashAdj.DefaultText = "----------"
        Me.cmbCashAdj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashAdj.EnterKey = True
        Me.cmbCashAdj.Font = New System.Drawing.Font("Bamini", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCashAdj.FormattingEnabled = True
        Me.cmbCashAdj.Items.AddRange(New Object() {"nuhf;fk;", "rhpfl;ly;"})
        Me.cmbCashAdj.Location = New System.Drawing.Point(76, 277)
        Me.cmbCashAdj.Name = "cmbCashAdj"
        Me.cmbCashAdj.ShiftKey = True
        Me.cmbCashAdj.Size = New System.Drawing.Size(53, 24)
        Me.cmbCashAdj.TabIndex = 4
        Me.cmbCashAdj.Validation = True
        Me.cmbCashAdj.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(13, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 19)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "If ADJUSTMENT"
        '
        'cmbHeadName
        '
        Me.cmbHeadName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbHeadName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbHeadName.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbHeadName.DefaultText = "--Select--"
        Me.cmbHeadName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeadName.EnterKey = True
        Me.cmbHeadName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHeadName.FormattingEnabled = True
        Me.cmbHeadName.Location = New System.Drawing.Point(121, 47)
        Me.cmbHeadName.Name = "cmbHeadName"
        Me.cmbHeadName.ShiftKey = True
        Me.cmbHeadName.Size = New System.Drawing.Size(315, 26)
        Me.cmbHeadName.TabIndex = 1
        Me.cmbHeadName.Validation = True
        '
        'txtVoucherNumber
        '
        Me.txtVoucherNumber.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtVoucherNumber.DecimalScale = 2
        Me.txtVoucherNumber.DefaultTextBox = False
        Me.txtVoucherNumber.EnterKey = True
        Me.txtVoucherNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherNumber.Location = New System.Drawing.Point(879, 16)
        Me.txtVoucherNumber.MaxLength = 9
        Me.txtVoucherNumber.Name = "txtVoucherNumber"
        Me.txtVoucherNumber.ShiftKey = True
        Me.txtVoucherNumber.Size = New System.Drawing.Size(85, 26)
        Me.txtVoucherNumber.TabIndex = 2
        Me.txtVoucherNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVoucherNumber.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(735, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 19)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Voucher Number"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Grid)
        Me.Panel2.Location = New System.Drawing.Point(488, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 321)
        Me.Panel2.TabIndex = 46
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtCB)
        Me.Panel4.Controls.Add(Me.txtOB)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtPTot)
        Me.Panel4.Controls.Add(Me.txtPAdj)
        Me.Panel4.Controls.Add(Me.txtPCash)
        Me.Panel4.Controls.Add(Me.txtRtot)
        Me.Panel4.Controls.Add(Me.txtRAdj)
        Me.Panel4.Controls.Add(Me.txtRCash)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 252)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(498, 67)
        Me.Panel4.TabIndex = 1
        '
        'txtCB
        '
        Me.txtCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCB.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtCB.DecimalScale = 2
        Me.txtCB.DefaultTextBox = False
        Me.txtCB.EnterKey = True
        Me.txtCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCB.ForeColor = System.Drawing.Color.Black
        Me.txtCB.Location = New System.Drawing.Point(389, 38)
        Me.txtCB.MaxLength = 18
        Me.txtCB.Name = "txtCB"
        Me.txtCB.ReadOnly = True
        Me.txtCB.ShiftKey = True
        Me.txtCB.Size = New System.Drawing.Size(107, 26)
        Me.txtCB.TabIndex = 42
        Me.txtCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCB.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtOB
        '
        Me.txtOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOB.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtOB.DecimalScale = 2
        Me.txtOB.DefaultTextBox = False
        Me.txtOB.EnterKey = True
        Me.txtOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOB.ForeColor = System.Drawing.Color.Black
        Me.txtOB.Location = New System.Drawing.Point(389, 9)
        Me.txtOB.MaxLength = 18
        Me.txtOB.Name = "txtOB"
        Me.txtOB.ReadOnly = True
        Me.txtOB.ShiftKey = True
        Me.txtOB.Size = New System.Drawing.Size(107, 26)
        Me.txtOB.TabIndex = 41
        Me.txtOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOB.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(356, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "CB"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(356, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "OB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bamini", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 12)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "nryT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bamini", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "tuT"
        '
        'txtPTot
        '
        Me.txtPTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPTot.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtPTot.DecimalScale = 2
        Me.txtPTot.DefaultTextBox = False
        Me.txtPTot.EnterKey = True
        Me.txtPTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPTot.ForeColor = System.Drawing.Color.Black
        Me.txtPTot.Location = New System.Drawing.Point(246, 38)
        Me.txtPTot.MaxLength = 18
        Me.txtPTot.Name = "txtPTot"
        Me.txtPTot.ReadOnly = True
        Me.txtPTot.ShiftKey = True
        Me.txtPTot.Size = New System.Drawing.Size(93, 26)
        Me.txtPTot.TabIndex = 8
        Me.txtPTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPTot.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtPAdj
        '
        Me.txtPAdj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPAdj.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtPAdj.DecimalScale = 2
        Me.txtPAdj.DefaultTextBox = False
        Me.txtPAdj.EnterKey = True
        Me.txtPAdj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAdj.ForeColor = System.Drawing.Color.Black
        Me.txtPAdj.Location = New System.Drawing.Point(149, 38)
        Me.txtPAdj.MaxLength = 18
        Me.txtPAdj.Name = "txtPAdj"
        Me.txtPAdj.ReadOnly = True
        Me.txtPAdj.ShiftKey = True
        Me.txtPAdj.Size = New System.Drawing.Size(93, 26)
        Me.txtPAdj.TabIndex = 7
        Me.txtPAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPAdj.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtPCash
        '
        Me.txtPCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPCash.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtPCash.DecimalScale = 2
        Me.txtPCash.DefaultTextBox = False
        Me.txtPCash.EnterKey = True
        Me.txtPCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPCash.ForeColor = System.Drawing.Color.Black
        Me.txtPCash.Location = New System.Drawing.Point(52, 38)
        Me.txtPCash.MaxLength = 18
        Me.txtPCash.Name = "txtPCash"
        Me.txtPCash.ReadOnly = True
        Me.txtPCash.ShiftKey = True
        Me.txtPCash.Size = New System.Drawing.Size(93, 26)
        Me.txtPCash.TabIndex = 6
        Me.txtPCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPCash.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtRtot
        '
        Me.txtRtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRtot.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtRtot.DecimalScale = 2
        Me.txtRtot.DefaultTextBox = False
        Me.txtRtot.EnterKey = True
        Me.txtRtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRtot.ForeColor = System.Drawing.Color.Black
        Me.txtRtot.Location = New System.Drawing.Point(246, 9)
        Me.txtRtot.MaxLength = 18
        Me.txtRtot.Name = "txtRtot"
        Me.txtRtot.ReadOnly = True
        Me.txtRtot.ShiftKey = True
        Me.txtRtot.Size = New System.Drawing.Size(93, 26)
        Me.txtRtot.TabIndex = 5
        Me.txtRtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRtot.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtRAdj
        '
        Me.txtRAdj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRAdj.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtRAdj.DecimalScale = 2
        Me.txtRAdj.DefaultTextBox = False
        Me.txtRAdj.EnterKey = True
        Me.txtRAdj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRAdj.ForeColor = System.Drawing.Color.Black
        Me.txtRAdj.Location = New System.Drawing.Point(149, 9)
        Me.txtRAdj.MaxLength = 18
        Me.txtRAdj.Name = "txtRAdj"
        Me.txtRAdj.ReadOnly = True
        Me.txtRAdj.ShiftKey = True
        Me.txtRAdj.Size = New System.Drawing.Size(93, 26)
        Me.txtRAdj.TabIndex = 4
        Me.txtRAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRAdj.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtRCash
        '
        Me.txtRCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRCash.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtRCash.DecimalScale = 2
        Me.txtRCash.DefaultTextBox = False
        Me.txtRCash.EnterKey = True
        Me.txtRCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRCash.ForeColor = System.Drawing.Color.Black
        Me.txtRCash.Location = New System.Drawing.Point(52, 9)
        Me.txtRCash.MaxLength = 18
        Me.txtRCash.Name = "txtRCash"
        Me.txtRCash.ReadOnly = True
        Me.txtRCash.ShiftKey = True
        Me.txtRCash.Size = New System.Drawing.Size(93, 26)
        Me.txtRCash.TabIndex = 3
        Me.txtRCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRCash.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.Auto_SNo = False
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Edit, Me.Delete, Me.Particulars, Me.Cash, Me.Adjustment, Me.Total, Me.RP, Me.VoucherCode, Me.Remarks, Me.EntryFrom, Me.HeadCode, Me.ACNO})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Grouping = False
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Grid.RowHeadersVisible = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.ShowCellErrors = False
        Me.Grid.ShowRowErrors = False
        Me.Grid.Size = New System.Drawing.Size(498, 246)
        Me.Grid.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtVoucherNumber)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.dtpVoucherDate)
        Me.Panel3.Controls.Add(Me.cmbRP)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(991, 66)
        Me.Panel3.TabIndex = 0
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Width = 35
        '
        'Delete
        '
        Me.Delete.HeaderText = "Del"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Width = 35
        '
        'Particulars
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Particulars.DefaultCellStyle = DataGridViewCellStyle2
        Me.Particulars.HeaderText = "Partculars"
        Me.Particulars.Name = "Particulars"
        Me.Particulars.ReadOnly = True
        Me.Particulars.Width = 120
        '
        'Cash
        '
        Me.Cash.HeaderText = "Cash"
        Me.Cash.Name = "Cash"
        Me.Cash.ReadOnly = True
        Me.Cash.Width = 80
        '
        'Adjustment
        '
        Me.Adjustment.HeaderText = "Adjustment"
        Me.Adjustment.Name = "Adjustment"
        Me.Adjustment.ReadOnly = True
        Me.Adjustment.Width = 80
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 80
        '
        'RP
        '
        Me.RP.HeaderText = "RP"
        Me.RP.Name = "RP"
        Me.RP.ReadOnly = True
        Me.RP.Width = 50
        '
        'VoucherCode
        '
        Me.VoucherCode.HeaderText = "VoucherCode"
        Me.VoucherCode.Name = "VoucherCode"
        Me.VoucherCode.ReadOnly = True
        Me.VoucherCode.Visible = False
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        Me.Remarks.Visible = False
        '
        'EntryFrom
        '
        Me.EntryFrom.HeaderText = "EntryFrom"
        Me.EntryFrom.Name = "EntryFrom"
        Me.EntryFrom.ReadOnly = True
        Me.EntryFrom.Visible = False
        '
        'HeadCode
        '
        Me.HeadCode.HeaderText = "HeadCode"
        Me.HeadCode.Name = "HeadCode"
        Me.HeadCode.ReadOnly = True
        Me.HeadCode.Visible = False
        '
        'ACNO
        '
        Me.ACNO.HeaderText = "ACNO"
        Me.ACNO.Name = "ACNO"
        Me.ACNO.ReadOnly = True
        Me.ACNO.Visible = False
        '
        'frmVoucherEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(991, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmVoucherEntry"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VoucherEntry Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtVoucherCode As sControls.TextBoxvb
    Friend WithEvents txtAmount As sControls.TextBoxvb
    Friend WithEvents cmbRP As sControls.ComboBoxvb
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Linevb1 As sControls.Linevb
    Friend WithEvents txtRemarks As sControls.TextBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpVoucherDate As sControls.DateTimeMaskvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbHeadName As sControls.ComboBoxvb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Grid As sControls.ViewGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtRAdj As sControls.TextBoxvb
    Friend WithEvents txtRCash As sControls.TextBoxvb
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPTot As sControls.TextBoxvb
    Friend WithEvents txtPAdj As sControls.TextBoxvb
    Friend WithEvents txtPCash As sControls.TextBoxvb
    Friend WithEvents txtRtot As sControls.TextBoxvb
    Friend WithEvents txtCB As sControls.TextBoxvb
    Friend WithEvents txtOB As sControls.TextBoxvb
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtVoucherNumber As sControls.TextBoxvb
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupName As sControls.ComboBoxvb
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustment As sControls.TextBoxvb
    Friend WithEvents cmbCashAdj As sControls.ComboBoxvb
    Friend WithEvents chkOption As System.Windows.Forms.CheckBox
    Friend WithEvents btnHead As sControls.Buttonvb
    Friend WithEvents btnGroup As sControls.Buttonvb
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMembername As sControls.TextBoxvb
    Friend WithEvents cmbEmpNo As sControls.ComboBoxvb
    Friend WithEvents btnMember As sControls.Buttonvb
    Friend WithEvents txtAcNo As sControls.TextBoxvb
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Particulars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cash As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adjustment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoucherCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntryFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeadCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACNO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
