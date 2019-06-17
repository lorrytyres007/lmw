<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShareDivident
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.pnlLeft = New System.Windows.Forms.Panel
        Me.lblProcessing = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbYear = New sControls.ComboBoxvb
        Me.Label17 = New System.Windows.Forms.Label
        Me.dtpDateFrom = New sControls.DateTimeMaskvb(Me.components)
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
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpShareClosingDate = New sControls.DateTimeMaskvb(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.txtMemberCode = New sControls.TextBoxvb
        Me.txtShareDividentCode = New sControls.TextBoxvb
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Grid = New sControls.ViewGrid
        Me.Auto_SNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label14 = New System.Windows.Forms.Label
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.Label11)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1065, 50)
        Me.pnlTop.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1063, 48)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Share Divident  (Posting)"
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
        Me.pnlBottom.Size = New System.Drawing.Size(1065, 57)
        Me.pnlBottom.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(579, 14)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 26)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(490, 14)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 26)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(401, 14)
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
        Me.Panel1.Controls.Add(Me.dtpDateFrom)
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
        Me.cmbYear.Location = New System.Drawing.Point(186, 32)
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
        Me.Label17.Location = New System.Drawing.Point(78, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 19)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Year"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpDateFrom.Enabled = False
        Me.dtpDateFrom.EnterKey = True
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Location = New System.Drawing.Point(188, 62)
        Me.dtpDateFrom.Mask = "99/99/9999"
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.ShiftKey = True
        Me.dtpDateFrom.Size = New System.Drawing.Size(107, 26)
        Me.dtpDateFrom.TabIndex = 1
        Me.dtpDateFrom.Value = New Date(CType(0, Long))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date To"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(78, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 19)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Date From"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(296, 126)
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
        Me.dtpDateTo.Location = New System.Drawing.Point(188, 92)
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
        Me.Label9.Location = New System.Drawing.Point(78, 126)
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
        Me.txtROI.Location = New System.Drawing.Point(188, 122)
        Me.txtROI.MaxLength = 10
        Me.txtROI.Name = "txtROI"
        Me.txtROI.ShiftKey = True
        Me.txtROI.Size = New System.Drawing.Size(107, 26)
        Me.txtROI.TabIndex = 3
        Me.txtROI.Text = "14.0"
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
        Me.txtMemberName.TabIndex = 3
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
        Me.txtMemberNo.TabIndex = 2
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
        Me.Label1.Size = New System.Drawing.Size(82, 19)
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
        Me.txtEmpNo.TabIndex = 1
        Me.txtEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmpNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'pnlRight
        '
        Me.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRight.Controls.Add(Me.Label15)
        Me.pnlRight.Controls.Add(Me.dtpShareClosingDate)
        Me.pnlRight.Controls.Add(Me.ProgressBar1)
        Me.pnlRight.Controls.Add(Me.txtMemberCode)
        Me.pnlRight.Controls.Add(Me.txtShareDividentCode)
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
        Me.pnlRight.Location = New System.Drawing.Point(698, 50)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(367, 319)
        Me.pnlRight.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(43, 271)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 19)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Share Closing Date"
        '
        'dtpShareClosingDate
        '
        Me.dtpShareClosingDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpShareClosingDate.Enabled = False
        Me.dtpShareClosingDate.EnterKey = True
        Me.dtpShareClosingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpShareClosingDate.Location = New System.Drawing.Point(215, 264)
        Me.dtpShareClosingDate.Mask = "99/99/9999"
        Me.dtpShareClosingDate.Name = "dtpShareClosingDate"
        Me.dtpShareClosingDate.ShiftKey = True
        Me.dtpShareClosingDate.Size = New System.Drawing.Size(107, 26)
        Me.dtpShareClosingDate.TabIndex = 29
        Me.dtpShareClosingDate.Value = New Date(CType(0, Long))
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(353, 26)
        Me.ProgressBar1.TabIndex = 14
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
        'txtShareDividentCode
        '
        Me.txtShareDividentCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtShareDividentCode.DecimalScale = 0
        Me.txtShareDividentCode.DefaultTextBox = False
        Me.txtShareDividentCode.EnterKey = True
        Me.txtShareDividentCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShareDividentCode.Location = New System.Drawing.Point(230, 9)
        Me.txtShareDividentCode.MaxLength = 10
        Me.txtShareDividentCode.Name = "txtShareDividentCode"
        Me.txtShareDividentCode.ShiftKey = True
        Me.txtShareDividentCode.Size = New System.Drawing.Size(107, 26)
        Me.txtShareDividentCode.TabIndex = 27
        Me.txtShareDividentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtShareDividentCode.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        Me.txtShareDividentCode.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtTotal.DecimalScale = 2
        Me.txtTotal.DefaultTextBox = False
        Me.txtTotal.EnterKey = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(181, 196)
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
        Me.Label10.Location = New System.Drawing.Point(43, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Total ..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Div. On Coll."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 47)
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
        Me.txtintonCollection.Location = New System.Drawing.Point(181, 153)
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
        Me.txtOpening.Location = New System.Drawing.Point(181, 43)
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
        Me.Label8.Location = New System.Drawing.Point(43, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Div. on Opn"
        '
        'txtCollection
        '
        Me.txtCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollection.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCollection.DecimalScale = 2
        Me.txtCollection.DefaultTextBox = False
        Me.txtCollection.EnterKey = True
        Me.txtCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollection.Location = New System.Drawing.Point(181, 75)
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
        Me.txtIntonOpening.Location = New System.Drawing.Point(181, 121)
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
        Me.Label6.Location = New System.Drawing.Point(43, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Collection"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Grid)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(400, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 319)
        Me.Panel2.TabIndex = 3
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToOrderColumns = True
        Me.Grid.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.Auto_SNo = True
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.ColumnHeadersHeight = 22
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auto_SNo})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Grouping = False
        Me.Grid.Location = New System.Drawing.Point(0, 27)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Grid.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.ShowCellErrors = False
        Me.Grid.ShowRowErrors = False
        Me.Grid.Size = New System.Drawing.Size(298, 292)
        Me.Grid.TabIndex = 98
        '
        'Auto_SNo
        '
        Me.Auto_SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Auto_SNo.HeaderText = "S.No"
        Me.Auto_SNo.Name = "Auto_SNo"
        Me.Auto_SNo.ReadOnly = True
        Me.Auto_SNo.Width = 45
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(298, 27)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Share Collection List"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmShareDivident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "frmShareDivident"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmShareDividentvb"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtShareDividentCode As sControls.TextBoxvb
    Friend WithEvents txtMemberCode As sControls.TextBoxvb
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpDateFrom As sControls.DateTimeMaskvb
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblProcessing As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbYear As sControls.ComboBoxvb
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Grid As sControls.ViewGrid
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Auto_SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpShareClosingDate As sControls.DateTimeMaskvb
End Class
