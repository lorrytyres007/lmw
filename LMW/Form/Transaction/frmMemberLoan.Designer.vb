<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberLoan
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
        Me.txtLoanNo = New sControls.TextBoxvb
        Me.txtLoanAmt = New sControls.TextBoxvb
        Me.txtLoanPeriod = New sControls.TextBoxvb
        Me.txtROI = New sControls.TextBoxvb
        Me.cmbEmpNo = New sControls.ComboBoxvb
        Me.cmbLoanName = New sControls.ComboBoxvb
        Me.cmbPaymode = New sControls.ComboBoxvb
        Me.dtpLoanDate = New sControls.DateTimePickervb
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtLoanCode = New sControls.TextBoxvb
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelOD = New System.Windows.Forms.Panel
        Me.txtPrincipal = New sControls.TextBoxvb
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtLoanOutStanding = New sControls.TextBoxvb
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtInterest = New sControls.TextBoxvb
        Me.txtODInterest = New sControls.TextBoxvb
        Me.txtODPrincipal = New sControls.TextBoxvb
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEmiAmt = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpLastPaiddate = New sControls.DateTimePickervb
        Me.txtEmpName = New sControls.TextBoxvb
        Me.txtEmpNumber = New sControls.TextBoxvb
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelOD.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLoanNo
        '
        Me.txtLoanNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanNo.DecimalScale = 0
        Me.txtLoanNo.DefaultTextBox = False
        Me.txtLoanNo.EnterKey = True
        Me.txtLoanNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanNo.Location = New System.Drawing.Point(137, 80)
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.ShiftKey = True
        Me.txtLoanNo.Size = New System.Drawing.Size(98, 23)
        Me.txtLoanNo.TabIndex = 2
        Me.txtLoanNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLoanNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'txtLoanAmt
        '
        Me.txtLoanAmt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanAmt.DecimalScale = 2
        Me.txtLoanAmt.DefaultTextBox = False
        Me.txtLoanAmt.EnterKey = True
        Me.txtLoanAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanAmt.Location = New System.Drawing.Point(137, 114)
        Me.txtLoanAmt.Name = "txtLoanAmt"
        Me.txtLoanAmt.ShiftKey = True
        Me.txtLoanAmt.Size = New System.Drawing.Size(98, 23)
        Me.txtLoanAmt.TabIndex = 4
        Me.txtLoanAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanAmt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtLoanPeriod
        '
        Me.txtLoanPeriod.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanPeriod.DecimalScale = 0
        Me.txtLoanPeriod.DefaultTextBox = False
        Me.txtLoanPeriod.EnterKey = True
        Me.txtLoanPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanPeriod.Location = New System.Drawing.Point(387, 114)
        Me.txtLoanPeriod.Name = "txtLoanPeriod"
        Me.txtLoanPeriod.ShiftKey = True
        Me.txtLoanPeriod.Size = New System.Drawing.Size(113, 23)
        Me.txtLoanPeriod.TabIndex = 5
        Me.txtLoanPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanPeriod.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'txtROI
        '
        Me.txtROI.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtROI.DecimalScale = 2
        Me.txtROI.DefaultTextBox = False
        Me.txtROI.EnterKey = True
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtROI.Location = New System.Drawing.Point(137, 145)
        Me.txtROI.Name = "txtROI"
        Me.txtROI.ShiftKey = True
        Me.txtROI.Size = New System.Drawing.Size(98, 23)
        Me.txtROI.TabIndex = 6
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtROI.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'cmbEmpNo
        '
        Me.cmbEmpNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpNo.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbEmpNo.DefaultText = "--SELECT--"
        Me.cmbEmpNo.EnterKey = True
        Me.cmbEmpNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpNo.FormattingEnabled = True
        Me.cmbEmpNo.Location = New System.Drawing.Point(137, 11)
        Me.cmbEmpNo.Name = "cmbEmpNo"
        Me.cmbEmpNo.ShiftKey = True
        Me.cmbEmpNo.Size = New System.Drawing.Size(98, 24)
        Me.cmbEmpNo.TabIndex = 0
        Me.cmbEmpNo.Validation = True
        '
        'cmbLoanName
        '
        Me.cmbLoanName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLoanName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLoanName.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbLoanName.DefaultText = "--SELECT--"
        Me.cmbLoanName.EnterKey = True
        Me.cmbLoanName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoanName.FormattingEnabled = True
        Me.cmbLoanName.Location = New System.Drawing.Point(137, 46)
        Me.cmbLoanName.Name = "cmbLoanName"
        Me.cmbLoanName.ShiftKey = True
        Me.cmbLoanName.Size = New System.Drawing.Size(235, 24)
        Me.cmbLoanName.TabIndex = 1
        Me.cmbLoanName.Validation = True
        '
        'cmbPaymode
        '
        Me.cmbPaymode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPaymode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPaymode.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbPaymode.DefaultText = "--SELECT--"
        Me.cmbPaymode.Enabled = False
        Me.cmbPaymode.EnterKey = True
        Me.cmbPaymode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymode.FormattingEnabled = True
        Me.cmbPaymode.Items.AddRange(New Object() {"BY CASH", "BY CHEQUE"})
        Me.cmbPaymode.Location = New System.Drawing.Point(387, 144)
        Me.cmbPaymode.Name = "cmbPaymode"
        Me.cmbPaymode.ShiftKey = True
        Me.cmbPaymode.Size = New System.Drawing.Size(113, 24)
        Me.cmbPaymode.TabIndex = 7
        Me.cmbPaymode.Validation = True
        '
        'dtpLoanDate
        '
        Me.dtpLoanDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpLoanDate.EnterKey = True
        Me.dtpLoanDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLoanDate.Location = New System.Drawing.Point(387, 80)
        Me.dtpLoanDate.MaxDate = New Date(2116, 3, 20, 0, 0, 0, 0)
        Me.dtpLoanDate.MinDate = New Date(1916, 3, 20, 0, 0, 0, 0)
        Me.dtpLoanDate.Name = "dtpLoanDate"
        Me.dtpLoanDate.ShiftKey = True
        Me.dtpLoanDate.Size = New System.Drawing.Size(113, 23)
        Me.dtpLoanDate.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtLoanCode)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 338)
        Me.Panel1.TabIndex = 0
        '
        'txtLoanCode
        '
        Me.txtLoanCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanCode.DecimalScale = 2
        Me.txtLoanCode.DefaultTextBox = False
        Me.txtLoanCode.EnterKey = True
        Me.txtLoanCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanCode.Location = New System.Drawing.Point(136, 298)
        Me.txtLoanCode.Name = "txtLoanCode"
        Me.txtLoanCode.ShiftKey = True
        Me.txtLoanCode.Size = New System.Drawing.Size(98, 23)
        Me.txtLoanCode.TabIndex = 150
        Me.txtLoanCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanCode.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        Me.txtLoanCode.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(501, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 28)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(412, 294)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 28)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(323, 294)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 28)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.PanelOD)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtEmiAmt)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.dtpLastPaiddate)
        Me.Panel4.Controls.Add(Me.txtEmpName)
        Me.Panel4.Controls.Add(Me.txtEmpNumber)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.dtpLoanDate)
        Me.Panel4.Controls.Add(Me.cmbPaymode)
        Me.Panel4.Controls.Add(Me.cmbLoanName)
        Me.Panel4.Controls.Add(Me.cmbEmpNo)
        Me.Panel4.Controls.Add(Me.txtLoanNo)
        Me.Panel4.Controls.Add(Me.txtLoanAmt)
        Me.Panel4.Controls.Add(Me.txtLoanPeriod)
        Me.Panel4.Controls.Add(Me.txtROI)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(906, 279)
        Me.Panel4.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(387, 50)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 17)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Member Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(387, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Member Number"
        '
        'PanelOD
        '
        Me.PanelOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOD.Controls.Add(Me.txtPrincipal)
        Me.PanelOD.Controls.Add(Me.Label11)
        Me.PanelOD.Controls.Add(Me.txtLoanOutStanding)
        Me.PanelOD.Controls.Add(Me.Label10)
        Me.PanelOD.Controls.Add(Me.txtInterest)
        Me.PanelOD.Controls.Add(Me.txtODInterest)
        Me.PanelOD.Controls.Add(Me.txtODPrincipal)
        Me.PanelOD.Controls.Add(Me.Label7)
        Me.PanelOD.Controls.Add(Me.Label5)
        Me.PanelOD.Controls.Add(Me.Label6)
        Me.PanelOD.Controls.Add(Me.Label4)
        Me.PanelOD.Location = New System.Drawing.Point(593, 80)
        Me.PanelOD.Name = "PanelOD"
        Me.PanelOD.Size = New System.Drawing.Size(296, 186)
        Me.PanelOD.TabIndex = 10
        '
        'txtPrincipal
        '
        Me.txtPrincipal.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtPrincipal.DecimalScale = 2
        Me.txtPrincipal.DefaultTextBox = False
        Me.txtPrincipal.EnterKey = True
        Me.txtPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPrincipal.Location = New System.Drawing.Point(158, 91)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.ShiftKey = True
        Me.txtPrincipal.Size = New System.Drawing.Size(115, 23)
        Me.txtPrincipal.TabIndex = 2
        Me.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrincipal.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(22, 94)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 17)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "Principle"
        '
        'txtLoanOutStanding
        '
        Me.txtLoanOutStanding.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanOutStanding.DecimalScale = 2
        Me.txtLoanOutStanding.DefaultTextBox = False
        Me.txtLoanOutStanding.EnterKey = True
        Me.txtLoanOutStanding.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanOutStanding.Location = New System.Drawing.Point(158, 37)
        Me.txtLoanOutStanding.Name = "txtLoanOutStanding"
        Me.txtLoanOutStanding.ShiftKey = True
        Me.txtLoanOutStanding.Size = New System.Drawing.Size(115, 23)
        Me.txtLoanOutStanding.TabIndex = 0
        Me.txtLoanOutStanding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanOutStanding.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(22, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "Loan OutStanding"
        '
        'txtInterest
        '
        Me.txtInterest.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtInterest.DecimalScale = 2
        Me.txtInterest.DefaultTextBox = False
        Me.txtInterest.EnterKey = True
        Me.txtInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInterest.Location = New System.Drawing.Point(158, 118)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.ShiftKey = True
        Me.txtInterest.Size = New System.Drawing.Size(115, 23)
        Me.txtInterest.TabIndex = 3
        Me.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtInterest.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtODInterest
        '
        Me.txtODInterest.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtODInterest.DecimalScale = 2
        Me.txtODInterest.DefaultTextBox = False
        Me.txtODInterest.EnterKey = True
        Me.txtODInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtODInterest.Location = New System.Drawing.Point(158, 146)
        Me.txtODInterest.Name = "txtODInterest"
        Me.txtODInterest.ShiftKey = True
        Me.txtODInterest.Size = New System.Drawing.Size(115, 23)
        Me.txtODInterest.TabIndex = 4
        Me.txtODInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtODInterest.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtODPrincipal
        '
        Me.txtODPrincipal.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtODPrincipal.DecimalScale = 2
        Me.txtODPrincipal.DefaultTextBox = False
        Me.txtODPrincipal.EnterKey = True
        Me.txtODPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtODPrincipal.Location = New System.Drawing.Point(158, 65)
        Me.txtODPrincipal.Name = "txtODPrincipal"
        Me.txtODPrincipal.ShiftKey = True
        Me.txtODPrincipal.Size = New System.Drawing.Size(115, 23)
        Me.txtODPrincipal.TabIndex = 1
        Me.txtODPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtODPrincipal.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(22, 121)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "Interest"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "OD Principle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 149)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "OD Interest"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(294, 34)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Demand Balance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(507, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "(in Months)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(34, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "EMI Amt"
        '
        'txtEmiAmt
        '
        Me.txtEmiAmt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtEmiAmt.DecimalScale = 2
        Me.txtEmiAmt.DefaultTextBox = False
        Me.txtEmiAmt.EnterKey = True
        Me.txtEmiAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmiAmt.Location = New System.Drawing.Point(137, 209)
        Me.txtEmiAmt.Name = "txtEmiAmt"
        Me.txtEmiAmt.ShiftKey = True
        Me.txtEmiAmt.Size = New System.Drawing.Size(98, 23)
        Me.txtEmiAmt.TabIndex = 9
        Me.txtEmiAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmiAmt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Last Paid Dt"
        '
        'dtpLastPaiddate
        '
        Me.dtpLastPaiddate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpLastPaiddate.EnterKey = True
        Me.dtpLastPaiddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpLastPaiddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastPaiddate.Location = New System.Drawing.Point(137, 177)
        Me.dtpLastPaiddate.MaxDate = New Date(2116, 3, 20, 0, 0, 0, 0)
        Me.dtpLastPaiddate.MinDate = New Date(1916, 3, 20, 0, 0, 0, 0)
        Me.dtpLastPaiddate.Name = "dtpLastPaiddate"
        Me.dtpLastPaiddate.ShiftKey = True
        Me.dtpLastPaiddate.Size = New System.Drawing.Size(98, 23)
        Me.dtpLastPaiddate.TabIndex = 8
        '
        'txtEmpName
        '
        Me.txtEmpName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtEmpName.DecimalScale = 0
        Me.txtEmpName.DefaultTextBox = False
        Me.txtEmpName.EnterKey = True
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmpName.Location = New System.Drawing.Point(593, 47)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.ReadOnly = True
        Me.txtEmpName.ShiftKey = True
        Me.txtEmpName.Size = New System.Drawing.Size(278, 23)
        Me.txtEmpName.TabIndex = 145
        Me.txtEmpName.TabStop = False
        Me.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEmpName.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'txtEmpNumber
        '
        Me.txtEmpNumber.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtEmpNumber.DecimalScale = 0
        Me.txtEmpNumber.DefaultTextBox = False
        Me.txtEmpNumber.EnterKey = True
        Me.txtEmpNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmpNumber.Location = New System.Drawing.Point(594, 12)
        Me.txtEmpNumber.Name = "txtEmpNumber"
        Me.txtEmpNumber.ReadOnly = True
        Me.txtEmpNumber.ShiftKey = True
        Me.txtEmpNumber.Size = New System.Drawing.Size(113, 23)
        Me.txtEmpNumber.TabIndex = 144
        Me.txtEmpNumber.TabStop = False
        Me.txtEmpNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEmpNumber.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(267, 148)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 17)
        Me.Label16.TabIndex = 143
        Me.Label16.Text = "Payment Mode"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(31, 148)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 17)
        Me.Label17.TabIndex = 142
        Me.Label17.Text = "Roi"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(267, 117)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 17)
        Me.Label18.TabIndex = 141
        Me.Label18.Text = "Loan Period"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(33, 117)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 17)
        Me.Label19.TabIndex = 140
        Me.Label19.Text = "Loan Amt"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(267, 83)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 17)
        Me.Label12.TabIndex = 139
        Me.Label12.Text = "Loan Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(31, 83)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 17)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Loan No."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(31, 48)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 20)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "Loan Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(31, 13)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 20)
        Me.Label15.TabIndex = 136
        Me.Label15.Text = "Emp.No."
        '
        'frmMemberLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMemberLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMemberLoan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelOD.ResumeLayout(False)
        Me.PanelOD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtLoanNo As sControls.TextBoxvb
    Friend WithEvents txtLoanAmt As sControls.TextBoxvb
    Friend WithEvents txtLoanPeriod As sControls.TextBoxvb
    Friend WithEvents txtROI As sControls.TextBoxvb
    Friend WithEvents cmbEmpNo As sControls.ComboBoxvb
    Friend WithEvents cmbLoanName As sControls.ComboBoxvb
    Friend WithEvents cmbPaymode As sControls.ComboBoxvb
    Friend WithEvents dtpLoanDate As sControls.DateTimePickervb
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEmpName As sControls.TextBoxvb
    Friend WithEvents txtEmpNumber As sControls.TextBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpLastPaiddate As sControls.DateTimePickervb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmiAmt As sControls.TextBoxvb
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtLoanCode As sControls.TextBoxvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelOD As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInterest As sControls.TextBoxvb
    Friend WithEvents txtODInterest As sControls.TextBoxvb
    Friend WithEvents txtODPrincipal As sControls.TextBoxvb
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLoanOutStanding As sControls.TextBoxvb
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As sControls.TextBoxvb
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
