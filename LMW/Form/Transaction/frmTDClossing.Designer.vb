﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTDClossing
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
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.pnlLeft = New System.Windows.Forms.Panel
        Me.cmbEmployeeno = New sControls.ComboBoxvb
        Me.txtOtherR = New sControls.TextBoxvb
        Me.Label14 = New System.Windows.Forms.Label
        Me.optTDClossing = New System.Windows.Forms.RadioButton
        Me.optRefund = New System.Windows.Forms.RadioButton
        Me.txtRefundAmt = New sControls.TextBoxvb
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtROI = New sControls.TextBoxvb
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpDepositClossingDate = New sControls.DateTimeMaskvb(Me.components)
        Me.txtMemberName = New sControls.TextBoxvb
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMemberNo = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmpNo = New sControls.TextBoxvb
        Me.pnlRight = New System.Windows.Forms.Panel
        Me.txtOtherReceipt = New sControls.TextBoxvb
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtRefundCode = New sControls.TextBoxvb
        Me.txtTDClossingCode = New sControls.TextBoxvb
        Me.txtTotal = New sControls.TextBoxvb
        Me.txtMemberCode = New sControls.TextBoxvb
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtintonCollection = New sControls.TextBoxvb
        Me.txtOpening = New sControls.TextBoxvb
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCollection = New sControls.TextBoxvb
        Me.txtIntonOpening = New sControls.TextBoxvb
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.Label11)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(804, 50)
        Me.pnlTop.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(802, 48)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Thrift Deposit Cossing "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBottom
        '
        Me.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBottom.Controls.Add(Me.btnExit)
        Me.pnlBottom.Controls.Add(Me.btnClear)
        Me.pnlBottom.Controls.Add(Me.btnSave)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 369)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(804, 57)
        Me.pnlBottom.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(449, 14)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 26)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(360, 14)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 26)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(271, 14)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 26)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pnlLeft
        '
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.cmbEmployeeno)
        Me.pnlLeft.Controls.Add(Me.txtOtherR)
        Me.pnlLeft.Controls.Add(Me.Label14)
        Me.pnlLeft.Controls.Add(Me.optTDClossing)
        Me.pnlLeft.Controls.Add(Me.optRefund)
        Me.pnlLeft.Controls.Add(Me.txtRefundAmt)
        Me.pnlLeft.Controls.Add(Me.Label13)
        Me.pnlLeft.Controls.Add(Me.Label12)
        Me.pnlLeft.Controls.Add(Me.Label9)
        Me.pnlLeft.Controls.Add(Me.txtROI)
        Me.pnlLeft.Controls.Add(Me.Label4)
        Me.pnlLeft.Controls.Add(Me.dtpDepositClossingDate)
        Me.pnlLeft.Controls.Add(Me.txtMemberName)
        Me.pnlLeft.Controls.Add(Me.Label3)
        Me.pnlLeft.Controls.Add(Me.Label2)
        Me.pnlLeft.Controls.Add(Me.txtMemberNo)
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Controls.Add(Me.txtEmpNo)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 50)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(400, 319)
        Me.pnlLeft.TabIndex = 0
        '
        'cmbEmployeeno
        '
        Me.cmbEmployeeno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmployeeno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmployeeno.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbEmployeeno.DefaultText = "--SELECT--"
        Me.cmbEmployeeno.EnterKey = True
        Me.cmbEmployeeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmployeeno.FormattingEnabled = True
        Me.cmbEmployeeno.Location = New System.Drawing.Point(264, 106)
        Me.cmbEmployeeno.Name = "cmbEmployeeno"
        Me.cmbEmployeeno.ShiftKey = True
        Me.cmbEmployeeno.Size = New System.Drawing.Size(107, 24)
        Me.cmbEmployeeno.TabIndex = 1
        Me.cmbEmployeeno.TabStop = False
        Me.cmbEmployeeno.Validation = True
        '
        'txtOtherR
        '
        Me.txtOtherR.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtOtherR.DecimalScale = 2
        Me.txtOtherR.DefaultTextBox = False
        Me.txtOtherR.EnterKey = True
        Me.txtOtherR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherR.Location = New System.Drawing.Point(145, 174)
        Me.txtOtherR.MaxLength = 10
        Me.txtOtherR.Name = "txtOtherR"
        Me.txtOtherR.ShiftKey = True
        Me.txtOtherR.Size = New System.Drawing.Size(141, 26)
        Me.txtOtherR.TabIndex = 5
        Me.txtOtherR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOtherR.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 19)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Other Receipts"
        '
        'optTDClossing
        '
        Me.optTDClossing.AutoSize = True
        Me.optTDClossing.Enabled = False
        Me.optTDClossing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTDClossing.ForeColor = System.Drawing.Color.Red
        Me.optTDClossing.Location = New System.Drawing.Point(248, 12)
        Me.optTDClossing.Name = "optTDClossing"
        Me.optTDClossing.Size = New System.Drawing.Size(123, 24)
        Me.optTDClossing.TabIndex = 1
        Me.optTDClossing.Text = "TD Clossing"
        Me.optTDClossing.UseVisualStyleBackColor = True
        '
        'optRefund
        '
        Me.optRefund.AutoSize = True
        Me.optRefund.Enabled = False
        Me.optRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRefund.ForeColor = System.Drawing.Color.Red
        Me.optRefund.Location = New System.Drawing.Point(27, 12)
        Me.optRefund.Name = "optRefund"
        Me.optRefund.Size = New System.Drawing.Size(123, 24)
        Me.optRefund.TabIndex = 0
        Me.optRefund.Text = "Refund Amt"
        Me.optRefund.UseVisualStyleBackColor = True
        '
        'txtRefundAmt
        '
        Me.txtRefundAmt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtRefundAmt.DecimalScale = 2
        Me.txtRefundAmt.DefaultTextBox = False
        Me.txtRefundAmt.EnterKey = True
        Me.txtRefundAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefundAmt.Location = New System.Drawing.Point(144, 142)
        Me.txtRefundAmt.MaxLength = 10
        Me.txtRefundAmt.Name = "txtRefundAmt"
        Me.txtRefundAmt.ShiftKey = True
        Me.txtRefundAmt.Size = New System.Drawing.Size(141, 26)
        Me.txtRefundAmt.TabIndex = 4
        Me.txtRefundAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRefundAmt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 19)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Refund Amt"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(246, 281)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 19)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ROI"
        '
        'txtROI
        '
        Me.txtROI.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtROI.DecimalScale = 2
        Me.txtROI.DefaultTextBox = False
        Me.txtROI.EnterKey = True
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.Location = New System.Drawing.Point(134, 277)
        Me.txtROI.MaxLength = 10
        Me.txtROI.Name = "txtROI"
        Me.txtROI.ShiftKey = True
        Me.txtROI.Size = New System.Drawing.Size(107, 26)
        Me.txtROI.TabIndex = 8
        Me.txtROI.TabStop = False
        Me.txtROI.Text = "8.50"
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtROI.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Name"
        '
        'dtpDepositClossingDate
        '
        Me.dtpDepositClossingDate.EnterKey = True
        Me.dtpDepositClossingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositClossingDate.Location = New System.Drawing.Point(145, 74)
        Me.dtpDepositClossingDate.Mask = "99/99/9999"
        Me.dtpDepositClossingDate.Name = "dtpDepositClossingDate"
        Me.dtpDepositClossingDate.ShiftKey = True
        Me.dtpDepositClossingDate.Size = New System.Drawing.Size(107, 26)
        Me.dtpDepositClossingDate.TabIndex = 2
        Me.dtpDepositClossingDate.Value = New Date(CType(0, Long))
        '
        'txtMemberName
        '
        Me.txtMemberName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMemberName.DecimalScale = 0
        Me.txtMemberName.DefaultTextBox = False
        Me.txtMemberName.EnterKey = True
        Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(134, 240)
        Me.txtMemberName.MaxLength = 10
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.ReadOnly = True
        Me.txtMemberName.ShiftKey = True
        Me.txtMemberName.Size = New System.Drawing.Size(254, 26)
        Me.txtMemberName.TabIndex = 7
        Me.txtMemberName.TabStop = False
        Me.txtMemberName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Member No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date"
        '
        'txtMemberNo
        '
        Me.txtMemberNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMemberNo.DecimalScale = 0
        Me.txtMemberNo.DefaultTextBox = False
        Me.txtMemberNo.EnterKey = True
        Me.txtMemberNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.Location = New System.Drawing.Point(145, 206)
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.ReadOnly = True
        Me.txtMemberNo.ShiftKey = True
        Me.txtMemberNo.Size = New System.Drawing.Size(107, 26)
        Me.txtMemberNo.TabIndex = 6
        Me.txtMemberNo.TabStop = False
        Me.txtMemberNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMemberNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Token No"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtEmpNo.DecimalScale = 0
        Me.txtEmpNo.DefaultTextBox = False
        Me.txtEmpNo.EnterKey = True
        Me.txtEmpNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpNo.Location = New System.Drawing.Point(144, 106)
        Me.txtEmpNo.MaxLength = 10
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.ShiftKey = True
        Me.txtEmpNo.Size = New System.Drawing.Size(107, 26)
        Me.txtEmpNo.TabIndex = 3
        Me.txtEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmpNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'pnlRight
        '
        Me.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRight.Controls.Add(Me.txtOtherReceipt)
        Me.pnlRight.Controls.Add(Me.Label15)
        Me.pnlRight.Controls.Add(Me.txtRefundCode)
        Me.pnlRight.Controls.Add(Me.txtTDClossingCode)
        Me.pnlRight.Controls.Add(Me.txtTotal)
        Me.pnlRight.Controls.Add(Me.txtMemberCode)
        Me.pnlRight.Controls.Add(Me.Label10)
        Me.pnlRight.Controls.Add(Me.Label7)
        Me.pnlRight.Controls.Add(Me.Label5)
        Me.pnlRight.Controls.Add(Me.txtintonCollection)
        Me.pnlRight.Controls.Add(Me.txtOpening)
        Me.pnlRight.Controls.Add(Me.Label8)
        Me.pnlRight.Controls.Add(Me.txtCollection)
        Me.pnlRight.Controls.Add(Me.txtIntonOpening)
        Me.pnlRight.Controls.Add(Me.Label6)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Enabled = False
        Me.pnlRight.Location = New System.Drawing.Point(404, 50)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(400, 319)
        Me.pnlRight.TabIndex = 2
        '
        'txtOtherReceipt
        '
        Me.txtOtherReceipt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtOtherReceipt.DecimalScale = 2
        Me.txtOtherReceipt.DefaultTextBox = False
        Me.txtOtherReceipt.EnterKey = True
        Me.txtOtherReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherReceipt.Location = New System.Drawing.Point(215, 173)
        Me.txtOtherReceipt.MaxLength = 10
        Me.txtOtherReceipt.Name = "txtOtherReceipt"
        Me.txtOtherReceipt.ShiftKey = True
        Me.txtOtherReceipt.Size = New System.Drawing.Size(141, 26)
        Me.txtOtherReceipt.TabIndex = 34
        Me.txtOtherReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOtherReceipt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(79, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 19)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Other Receipts"
        '
        'txtRefundCode
        '
        Me.txtRefundCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtRefundCode.DecimalScale = 0
        Me.txtRefundCode.DefaultTextBox = False
        Me.txtRefundCode.EnterKey = True
        Me.txtRefundCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefundCode.Location = New System.Drawing.Point(286, 3)
        Me.txtRefundCode.MaxLength = 10
        Me.txtRefundCode.Name = "txtRefundCode"
        Me.txtRefundCode.ShiftKey = True
        Me.txtRefundCode.Size = New System.Drawing.Size(107, 26)
        Me.txtRefundCode.TabIndex = 29
        Me.txtRefundCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRefundCode.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        Me.txtRefundCode.Visible = False
        '
        'txtTDClossingCode
        '
        Me.txtTDClossingCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtTDClossingCode.DecimalScale = 0
        Me.txtTDClossingCode.DefaultTextBox = False
        Me.txtTDClossingCode.EnterKey = True
        Me.txtTDClossingCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDClossingCode.Location = New System.Drawing.Point(173, 3)
        Me.txtTDClossingCode.MaxLength = 10
        Me.txtTDClossingCode.Name = "txtTDClossingCode"
        Me.txtTDClossingCode.ShiftKey = True
        Me.txtTDClossingCode.Size = New System.Drawing.Size(107, 26)
        Me.txtTDClossingCode.TabIndex = 27
        Me.txtTDClossingCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTDClossingCode.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        Me.txtTDClossingCode.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtTotal.DecimalScale = 2
        Me.txtTotal.DefaultTextBox = False
        Me.txtTotal.EnterKey = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(215, 205)
        Me.txtTotal.MaxLength = 10
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ShiftKey = True
        Me.txtTotal.Size = New System.Drawing.Size(141, 26)
        Me.txtTotal.TabIndex = 26
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtMemberCode
        '
        Me.txtMemberCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMemberCode.DecimalScale = 0
        Me.txtMemberCode.DefaultTextBox = False
        Me.txtMemberCode.EnterKey = True
        Me.txtMemberCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberCode.Location = New System.Drawing.Point(33, 3)
        Me.txtMemberCode.MaxLength = 10
        Me.txtMemberCode.Name = "txtMemberCode"
        Me.txtMemberCode.ShiftKey = True
        Me.txtMemberCode.Size = New System.Drawing.Size(107, 26)
        Me.txtMemberCode.TabIndex = 28
        Me.txtMemberCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMemberCode.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        Me.txtMemberCode.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Total ..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Int. On Coll."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Opening "
        '
        'txtintonCollection
        '
        Me.txtintonCollection.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtintonCollection.DecimalScale = 2
        Me.txtintonCollection.DefaultTextBox = False
        Me.txtintonCollection.EnterKey = True
        Me.txtintonCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtintonCollection.Location = New System.Drawing.Point(215, 141)
        Me.txtintonCollection.MaxLength = 10
        Me.txtintonCollection.Name = "txtintonCollection"
        Me.txtintonCollection.ShiftKey = True
        Me.txtintonCollection.Size = New System.Drawing.Size(141, 26)
        Me.txtintonCollection.TabIndex = 21
        Me.txtintonCollection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtintonCollection.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtOpening
        '
        Me.txtOpening.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtOpening.DecimalScale = 2
        Me.txtOpening.DefaultTextBox = False
        Me.txtOpening.EnterKey = True
        Me.txtOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpening.Location = New System.Drawing.Point(215, 45)
        Me.txtOpening.MaxLength = 10
        Me.txtOpening.Name = "txtOpening"
        Me.txtOpening.ShiftKey = True
        Me.txtOpening.Size = New System.Drawing.Size(141, 26)
        Me.txtOpening.TabIndex = 15
        Me.txtOpening.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOpening.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(77, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Int. on Opn"
        '
        'txtCollection
        '
        Me.txtCollection.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCollection.DecimalScale = 2
        Me.txtCollection.DefaultTextBox = False
        Me.txtCollection.EnterKey = True
        Me.txtCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollection.Location = New System.Drawing.Point(215, 77)
        Me.txtCollection.MaxLength = 10
        Me.txtCollection.Name = "txtCollection"
        Me.txtCollection.ShiftKey = True
        Me.txtCollection.Size = New System.Drawing.Size(141, 26)
        Me.txtCollection.TabIndex = 17
        Me.txtCollection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCollection.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtIntonOpening
        '
        Me.txtIntonOpening.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtIntonOpening.DecimalScale = 2
        Me.txtIntonOpening.DefaultTextBox = False
        Me.txtIntonOpening.EnterKey = True
        Me.txtIntonOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntonOpening.Location = New System.Drawing.Point(215, 109)
        Me.txtIntonOpening.MaxLength = 10
        Me.txtIntonOpening.Name = "txtIntonOpening"
        Me.txtIntonOpening.ShiftKey = True
        Me.txtIntonOpening.Size = New System.Drawing.Size(141, 26)
        Me.txtIntonOpening.TabIndex = 19
        Me.txtIntonOpening.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIntonOpening.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Collection"
        '
        'frmTDClossing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 426)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "frmTDClossing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTDClossingvb"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents dtpDepositClossingDate As sControls.DateTimeMaskvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpNo As sControls.TextBoxvb
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCollection As sControls.TextBoxvb
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOpening As sControls.TextBoxvb
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMemberName As sControls.TextBoxvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMemberNo As sControls.TextBoxvb
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtintonCollection As sControls.TextBoxvb
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIntonOpening As sControls.TextBoxvb
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtROI As sControls.TextBoxvb
    Friend WithEvents txtTotal As sControls.TextBoxvb
    Friend WithEvents txtTDClossingCode As sControls.TextBoxvb
    Friend WithEvents txtMemberCode As sControls.TextBoxvb
    Friend WithEvents txtRefundAmt As sControls.TextBoxvb
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents optTDClossing As System.Windows.Forms.RadioButton
    Friend WithEvents optRefund As System.Windows.Forms.RadioButton
    Friend WithEvents txtRefundCode As sControls.TextBoxvb
    Friend WithEvents txtOtherR As sControls.TextBoxvb
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOtherReceipt As sControls.TextBoxvb
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbEmployeeno As sControls.ComboBoxvb
End Class
