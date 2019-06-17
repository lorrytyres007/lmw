<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTDInterest
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
        Me.btnAutoUpdate = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.pnlLeft = New System.Windows.Forms.Panel
        Me.lblProcessing = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbYear = New sControls.ComboBoxvb
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpDateFrom = New sControls.DateTimeMaskvb(Me.components)
        Me.txtInsurance = New sControls.TextBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpDateTo = New sControls.DateTimeMaskvb(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtROI = New sControls.TextBoxvb
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMemberName = New sControls.TextBoxvb
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMemberNo = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmpNo = New sControls.TextBoxvb
        Me.pnlRight = New System.Windows.Forms.Panel
        Me.txtNettTotal = New sControls.TextBoxvb
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtInsurance1 = New sControls.TextBoxvb
        Me.txtMemberCode = New sControls.TextBoxvb
        Me.txtTDInterestCode = New sControls.TextBoxvb
        Me.txtTotal = New sControls.TextBoxvb
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
        Me.Panel1.SuspendLayout()
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
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Thrift Deposit (Interest Posting)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBottom
        '
        Me.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBottom.Controls.Add(Me.btnExit)
        Me.pnlBottom.Controls.Add(Me.btnClear)
        Me.pnlBottom.Controls.Add(Me.btnAutoUpdate)
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
        'btnAutoUpdate
        '
        Me.btnAutoUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoUpdate.Location = New System.Drawing.Point(26, 14)
        Me.btnAutoUpdate.Name = "btnAutoUpdate"
        Me.btnAutoUpdate.Size = New System.Drawing.Size(125, 26)
        Me.btnAutoUpdate.TabIndex = 3
        Me.btnAutoUpdate.Text = "&Auto Update"
        Me.btnAutoUpdate.UseVisualStyleBackColor = True
        Me.btnAutoUpdate.Visible = False
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
        Me.pnlLeft.Controls.Add(Me.lblProcessing)
        Me.pnlLeft.Controls.Add(Me.Panel1)
        Me.pnlLeft.Controls.Add(Me.Label4)
        Me.pnlLeft.Controls.Add(Me.txtMemberName)
        Me.pnlLeft.Controls.Add(Me.Label3)
        Me.pnlLeft.Controls.Add(Me.txtMemberNo)
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Controls.Add(Me.txtEmpNo)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 50)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(400, 319)
        Me.pnlLeft.TabIndex = 0
        '
        'lblProcessing
        '
        Me.lblProcessing.AutoSize = True
        Me.lblProcessing.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessing.ForeColor = System.Drawing.Color.Blue
        Me.lblProcessing.Location = New System.Drawing.Point(233, 196)
        Me.lblProcessing.Name = "lblProcessing"
        Me.lblProcessing.Size = New System.Drawing.Size(151, 15)
        Me.lblProcessing.TabIndex = 13
        Me.lblProcessing.Text = "Wait Process is going . . . ,"
        Me.lblProcessing.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.dtpDateFrom)
        Me.Panel1.Controls.Add(Me.txtInsurance)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.dtpDateTo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtROI)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 181)
        Me.Panel1.TabIndex = 0
        '
        'cmbYear
        '
        Me.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYear.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbYear.DefaultText = "--SELECT--"
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.EnterKey = True
        Me.cmbYear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(118, 9)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.ShiftKey = True
        Me.cmbYear.Size = New System.Drawing.Size(109, 26)
        Me.cmbYear.TabIndex = 0
        Me.cmbYear.Validation = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 19)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Year"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(10, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 19)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Insurance"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpDateFrom.Enabled = False
        Me.dtpDateFrom.EnterKey = True
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Location = New System.Drawing.Point(120, 39)
        Me.dtpDateFrom.Mask = "99/99/9999"
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.ShiftKey = True
        Me.dtpDateFrom.Size = New System.Drawing.Size(107, 26)
        Me.dtpDateFrom.TabIndex = 1
        Me.dtpDateFrom.Value = New Date(CType(0, Long))
        '
        'txtInsurance
        '
        Me.txtInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsurance.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtInsurance.DecimalScale = 2
        Me.txtInsurance.DefaultTextBox = False
        Me.txtInsurance.EnterKey = True
        Me.txtInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsurance.Location = New System.Drawing.Point(120, 129)
        Me.txtInsurance.MaxLength = 10
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.ShiftKey = True
        Me.txtInsurance.Size = New System.Drawing.Size(107, 26)
        Me.txtInsurance.TabIndex = 4
        Me.txtInsurance.Text = "0.00"
        Me.txtInsurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtInsurance.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date To"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 19)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Date From"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(228, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 19)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "%"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpDateTo.Enabled = False
        Me.dtpDateTo.EnterKey = True
        Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Location = New System.Drawing.Point(120, 69)
        Me.dtpDateTo.Mask = "99/99/9999"
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.ShiftKey = True
        Me.dtpDateTo.Size = New System.Drawing.Size(107, 26)
        Me.dtpDateTo.TabIndex = 2
        Me.dtpDateTo.Value = New Date(CType(0, Long))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(10, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ROI"
        '
        'txtROI
        '
        Me.txtROI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtROI.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtROI.DecimalScale = 2
        Me.txtROI.DefaultTextBox = False
        Me.txtROI.EnterKey = True
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.Location = New System.Drawing.Point(120, 99)
        Me.txtROI.MaxLength = 10
        Me.txtROI.Name = "txtROI"
        Me.txtROI.ShiftKey = True
        Me.txtROI.Size = New System.Drawing.Size(107, 26)
        Me.txtROI.TabIndex = 3
        Me.txtROI.Text = "8.50"
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtROI.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Name"
        '
        'txtMemberName
        '
        Me.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMemberName.DecimalScale = 0
        Me.txtMemberName.DefaultTextBox = False
        Me.txtMemberName.EnterKey = True
        Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(120, 263)
        Me.txtMemberName.MaxLength = 10
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.ReadOnly = True
        Me.txtMemberName.ShiftKey = True
        Me.txtMemberName.Size = New System.Drawing.Size(264, 26)
        Me.txtMemberName.TabIndex = 2
        Me.txtMemberName.TabStop = False
        Me.txtMemberName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Member No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMemberNo
        '
        Me.txtMemberNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMemberNo.DecimalScale = 0
        Me.txtMemberNo.DefaultTextBox = False
        Me.txtMemberNo.EnterKey = True
        Me.txtMemberNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberNo.Location = New System.Drawing.Point(120, 231)
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.ReadOnly = True
        Me.txtMemberNo.ShiftKey = True
        Me.txtMemberNo.Size = New System.Drawing.Size(107, 26)
        Me.txtMemberNo.TabIndex = 1
        Me.txtMemberNo.TabStop = False
        Me.txtMemberNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMemberNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Token No"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtEmpNo.DecimalScale = 0
        Me.txtEmpNo.DefaultTextBox = False
        Me.txtEmpNo.EnterKey = True
        Me.txtEmpNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpNo.Location = New System.Drawing.Point(120, 190)
        Me.txtEmpNo.MaxLength = 10
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.ShiftKey = True
        Me.txtEmpNo.Size = New System.Drawing.Size(107, 26)
        Me.txtEmpNo.TabIndex = 0
        Me.txtEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmpNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'pnlRight
        '
        Me.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRight.Controls.Add(Me.txtNettTotal)
        Me.pnlRight.Controls.Add(Me.ProgressBar1)
        Me.pnlRight.Controls.Add(Me.Label16)
        Me.pnlRight.Controls.Add(Me.Label15)
        Me.pnlRight.Controls.Add(Me.txtInsurance1)
        Me.pnlRight.Controls.Add(Me.txtMemberCode)
        Me.pnlRight.Controls.Add(Me.txtTDInterestCode)
        Me.pnlRight.Controls.Add(Me.txtTotal)
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
        Me.pnlRight.Location = New System.Drawing.Point(404, 50)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(400, 319)
        Me.pnlRight.TabIndex = 2
        '
        'txtNettTotal
        '
        Me.txtNettTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNettTotal.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtNettTotal.DecimalScale = 2
        Me.txtNettTotal.DefaultTextBox = False
        Me.txtNettTotal.EnterKey = True
        Me.txtNettTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNettTotal.Location = New System.Drawing.Point(215, 262)
        Me.txtNettTotal.MaxLength = 10
        Me.txtNettTotal.Name = "txtNettTotal"
        Me.txtNettTotal.ReadOnly = True
        Me.txtNettTotal.ShiftKey = True
        Me.txtNettTotal.Size = New System.Drawing.Size(141, 26)
        Me.txtNettTotal.TabIndex = 32
        Me.txtNettTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNettTotal.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(391, 26)
        Me.ProgressBar1.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(77, 266)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 19)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Nett. Total ..."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(77, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 16)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "(Less) Insurance"
        '
        'txtInsurance1
        '
        Me.txtInsurance1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsurance1.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtInsurance1.DecimalScale = 2
        Me.txtInsurance1.DefaultTextBox = False
        Me.txtInsurance1.EnterKey = True
        Me.txtInsurance1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsurance1.Location = New System.Drawing.Point(215, 230)
        Me.txtInsurance1.MaxLength = 10
        Me.txtInsurance1.Name = "txtInsurance1"
        Me.txtInsurance1.ShiftKey = True
        Me.txtInsurance1.Size = New System.Drawing.Size(141, 26)
        Me.txtInsurance1.TabIndex = 29
        Me.txtInsurance1.Text = "0.00"
        Me.txtInsurance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtInsurance1.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtMemberCode
        '
        Me.txtMemberCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMemberCode.DecimalScale = 0
        Me.txtMemberCode.DefaultTextBox = False
        Me.txtMemberCode.EnterKey = True
        Me.txtMemberCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberCode.Location = New System.Drawing.Point(95, 9)
        Me.txtMemberCode.MaxLength = 10
        Me.txtMemberCode.Name = "txtMemberCode"
        Me.txtMemberCode.ShiftKey = True
        Me.txtMemberCode.Size = New System.Drawing.Size(107, 26)
        Me.txtMemberCode.TabIndex = 28
        Me.txtMemberCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMemberCode.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        Me.txtMemberCode.Visible = False
        '
        'txtTDInterestCode
        '
        Me.txtTDInterestCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtTDInterestCode.DecimalScale = 0
        Me.txtTDInterestCode.DefaultTextBox = False
        Me.txtTDInterestCode.EnterKey = True
        Me.txtTDInterestCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDInterestCode.Location = New System.Drawing.Point(230, 9)
        Me.txtTDInterestCode.MaxLength = 10
        Me.txtTDInterestCode.Name = "txtTDInterestCode"
        Me.txtTDInterestCode.ShiftKey = True
        Me.txtTDInterestCode.Size = New System.Drawing.Size(107, 26)
        Me.txtTDInterestCode.TabIndex = 27
        Me.txtTDInterestCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTDInterestCode.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        Me.txtTDInterestCode.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtTotal.DecimalScale = 2
        Me.txtTotal.DefaultTextBox = False
        Me.txtTotal.EnterKey = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(215, 198)
        Me.txtTotal.MaxLength = 10
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.ShiftKey = True
        Me.txtTotal.Size = New System.Drawing.Size(141, 26)
        Me.txtTotal.TabIndex = 26
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Total ..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 159)
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
        Me.txtintonCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtintonCollection.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtintonCollection.DecimalScale = 2
        Me.txtintonCollection.DefaultTextBox = False
        Me.txtintonCollection.EnterKey = True
        Me.txtintonCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtintonCollection.Location = New System.Drawing.Point(215, 155)
        Me.txtintonCollection.MaxLength = 10
        Me.txtintonCollection.Name = "txtintonCollection"
        Me.txtintonCollection.ReadOnly = True
        Me.txtintonCollection.ShiftKey = True
        Me.txtintonCollection.Size = New System.Drawing.Size(141, 26)
        Me.txtintonCollection.TabIndex = 21
        Me.txtintonCollection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtintonCollection.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtOpening
        '
        Me.txtOpening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpening.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtOpening.DecimalScale = 2
        Me.txtOpening.DefaultTextBox = False
        Me.txtOpening.EnterKey = True
        Me.txtOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpening.Location = New System.Drawing.Point(215, 45)
        Me.txtOpening.MaxLength = 10
        Me.txtOpening.Name = "txtOpening"
        Me.txtOpening.ReadOnly = True
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
        Me.Label8.Location = New System.Drawing.Point(77, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Int. on Opn"
        '
        'txtCollection
        '
        Me.txtCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollection.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCollection.DecimalScale = 2
        Me.txtCollection.DefaultTextBox = False
        Me.txtCollection.EnterKey = True
        Me.txtCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollection.Location = New System.Drawing.Point(215, 77)
        Me.txtCollection.MaxLength = 10
        Me.txtCollection.Name = "txtCollection"
        Me.txtCollection.ReadOnly = True
        Me.txtCollection.ShiftKey = True
        Me.txtCollection.Size = New System.Drawing.Size(141, 26)
        Me.txtCollection.TabIndex = 17
        Me.txtCollection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCollection.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtIntonOpening
        '
        Me.txtIntonOpening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntonOpening.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtIntonOpening.DecimalScale = 2
        Me.txtIntonOpening.DefaultTextBox = False
        Me.txtIntonOpening.EnterKey = True
        Me.txtIntonOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntonOpening.Location = New System.Drawing.Point(215, 123)
        Me.txtIntonOpening.MaxLength = 10
        Me.txtIntonOpening.Name = "txtIntonOpening"
        Me.txtIntonOpening.ReadOnly = True
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
        'frmTDInterest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "frmTDInterest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTDInterestvb"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents dtpDateTo As sControls.DateTimeMaskvb
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
    Friend WithEvents txtTDInterestCode As sControls.TextBoxvb
    Friend WithEvents txtMemberCode As sControls.TextBoxvb
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpDateFrom As sControls.DateTimeMaskvb
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtInsurance As sControls.TextBoxvb
    Friend WithEvents lblProcessing As System.Windows.Forms.Label
    Friend WithEvents txtNettTotal As sControls.TextBoxvb
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtInsurance1 As sControls.TextBoxvb
    Friend WithEvents btnAutoUpdate As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbYear As sControls.ComboBoxvb
End Class
