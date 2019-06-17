<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffLoanDemand
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim CBlendItems1 As sControls.cBlendItems = New sControls.cBlendItems
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Grid = New sControls.ViewGrid
        Me.Auto_SNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DemandCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YearNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DemandDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FyCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MemberCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TokenNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaturityDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanROI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanOutStanding = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanInterest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanODPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanODInterest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrInterest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrODPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrODInterest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CollDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CollPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CollInterest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CollODPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CollODInterest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalInterest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalODPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalODInterest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CollOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanOSforInt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StaffLoan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WorkerLoan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnCalculation = New System.Windows.Forms.Button
        Me.cmbMonth = New sControls.ComboBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.GLabel27 = New sControls.gLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTo = New sControls.DateTimeMaskvb(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFrom = New sControls.DateTimeMaskvb(Me.components)
        Me.pnlMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.Panel3)
        Me.pnlMain.Controls.Add(Me.Panel2)
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1257, 527)
        Me.pnlMain.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Grid)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1257, 386)
        Me.Panel3.TabIndex = 2
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
        Me.Grid.ColumnHeadersHeight = 32
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auto_SNo, Me.DemandCode, Me.DateFrom, Me.DateTo, Me.MonthNo, Me.YearNo, Me.DemandDate, Me.FyCode, Me.MemberCode, Me.LoanCode, Me.TokenNumber, Me.LoanNo, Me.LoanDate, Me.MaturityDate, Me.LoanROI, Me.LoanOutStanding, Me.LoanPrincipal, Me.LoanInterest, Me.LoanODPrincipal, Me.LoanODInterest, Me.CurrPrincipal, Me.CurrInterest, Me.CurrODPrincipal, Me.CurrODInterest, Me.CollDate, Me.CollPrincipal, Me.CollInterest, Me.CollODPrincipal, Me.CollODInterest, Me.BalPrincipal, Me.BalInterest, Me.BalODPrincipal, Me.BalODInterest, Me.CollOS, Me.LoanOS, Me.LoanOSforInt, Me.StaffLoan, Me.WorkerLoan})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Grouping = False
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Grid.RowHeadersVisible = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.ShowCellErrors = False
        Me.Grid.ShowRowErrors = False
        Me.Grid.Size = New System.Drawing.Size(1255, 384)
        Me.Grid.TabIndex = 98
        '
        'Auto_SNo
        '
        Me.Auto_SNo.HeaderText = "S.No"
        Me.Auto_SNo.Name = "Auto_SNo"
        Me.Auto_SNo.ReadOnly = True
        Me.Auto_SNo.Width = 45
        '
        'DemandCode
        '
        Me.DemandCode.HeaderText = "DemandCode"
        Me.DemandCode.Name = "DemandCode"
        Me.DemandCode.ReadOnly = True
        Me.DemandCode.Visible = False
        Me.DemandCode.Width = 106
        '
        'DateFrom
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DateFrom.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateFrom.HeaderText = "DateFrom"
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.ReadOnly = True
        Me.DateFrom.Width = 85
        '
        'DateTo
        '
        DataGridViewCellStyle4.Format = "d"
        Me.DateTo.DefaultCellStyle = DataGridViewCellStyle4
        Me.DateTo.HeaderText = "DateTo"
        Me.DateTo.Name = "DateTo"
        Me.DateTo.ReadOnly = True
        Me.DateTo.Width = 73
        '
        'MonthNo
        '
        Me.MonthNo.HeaderText = "MonthNo"
        Me.MonthNo.Name = "MonthNo"
        Me.MonthNo.ReadOnly = True
        Me.MonthNo.Width = 82
        '
        'YearNo
        '
        Me.YearNo.HeaderText = "YearNo"
        Me.YearNo.Name = "YearNo"
        Me.YearNo.ReadOnly = True
        Me.YearNo.Width = 73
        '
        'DemandDate
        '
        DataGridViewCellStyle5.Format = "d"
        Me.DemandDate.DefaultCellStyle = DataGridViewCellStyle5
        Me.DemandDate.HeaderText = "DemandDate"
        Me.DemandDate.Name = "DemandDate"
        Me.DemandDate.ReadOnly = True
        Me.DemandDate.Width = 104
        '
        'FyCode
        '
        Me.FyCode.HeaderText = "FyCode"
        Me.FyCode.Name = "FyCode"
        Me.FyCode.ReadOnly = True
        Me.FyCode.Visible = False
        Me.FyCode.Width = 73
        '
        'MemberCode
        '
        Me.MemberCode.HeaderText = "MemberCode"
        Me.MemberCode.Name = "MemberCode"
        Me.MemberCode.ReadOnly = True
        Me.MemberCode.Visible = False
        Me.MemberCode.Width = 104
        '
        'LoanCode
        '
        Me.LoanCode.HeaderText = "LoanCode"
        Me.LoanCode.Name = "LoanCode"
        Me.LoanCode.ReadOnly = True
        Me.LoanCode.Visible = False
        Me.LoanCode.Width = 88
        '
        'TokenNumber
        '
        Me.TokenNumber.HeaderText = "TokenNumber"
        Me.TokenNumber.Name = "TokenNumber"
        Me.TokenNumber.ReadOnly = True
        Me.TokenNumber.Width = 118
        '
        'LoanNo
        '
        Me.LoanNo.HeaderText = "LoanNumber"
        Me.LoanNo.Name = "LoanNo"
        Me.LoanNo.ReadOnly = True
        Me.LoanNo.Width = 102
        '
        'LoanDate
        '
        Me.LoanDate.HeaderText = "LoanDate"
        Me.LoanDate.Name = "LoanDate"
        Me.LoanDate.ReadOnly = True
        Me.LoanDate.Width = 86
        '
        'MaturityDate
        '
        Me.MaturityDate.HeaderText = "MaturityDate"
        Me.MaturityDate.Name = "MaturityDate"
        Me.MaturityDate.ReadOnly = True
        Me.MaturityDate.Width = 103
        '
        'LoanROI
        '
        Me.LoanROI.HeaderText = "ROI"
        Me.LoanROI.Name = "LoanROI"
        Me.LoanROI.ReadOnly = True
        Me.LoanROI.Width = 53
        '
        'LoanOutStanding
        '
        Me.LoanOutStanding.HeaderText = "LoanOutStanding"
        Me.LoanOutStanding.Name = "LoanOutStanding"
        Me.LoanOutStanding.ReadOnly = True
        Me.LoanOutStanding.Width = 129
        '
        'LoanPrincipal
        '
        Me.LoanPrincipal.HeaderText = "LoanPrincipal"
        Me.LoanPrincipal.Name = "LoanPrincipal"
        Me.LoanPrincipal.ReadOnly = True
        Me.LoanPrincipal.Width = 108
        '
        'LoanInterest
        '
        Me.LoanInterest.HeaderText = "LoanInterest"
        Me.LoanInterest.Name = "LoanInterest"
        Me.LoanInterest.ReadOnly = True
        Me.LoanInterest.Width = 102
        '
        'LoanODPrincipal
        '
        Me.LoanODPrincipal.HeaderText = "LoanODPrincipal"
        Me.LoanODPrincipal.Name = "LoanODPrincipal"
        Me.LoanODPrincipal.ReadOnly = True
        Me.LoanODPrincipal.Width = 126
        '
        'LoanODInterest
        '
        Me.LoanODInterest.HeaderText = "LoanODInterest"
        Me.LoanODInterest.Name = "LoanODInterest"
        Me.LoanODInterest.ReadOnly = True
        Me.LoanODInterest.Width = 120
        '
        'CurrPrincipal
        '
        Me.CurrPrincipal.HeaderText = "Curr. Principal"
        Me.CurrPrincipal.Name = "CurrPrincipal"
        Me.CurrPrincipal.ReadOnly = True
        '
        'CurrInterest
        '
        Me.CurrInterest.HeaderText = "Curr. Interest"
        Me.CurrInterest.Name = "CurrInterest"
        Me.CurrInterest.ReadOnly = True
        '
        'CurrODPrincipal
        '
        Me.CurrODPrincipal.HeaderText = "Curr. OD Principal"
        Me.CurrODPrincipal.Name = "CurrODPrincipal"
        Me.CurrODPrincipal.ReadOnly = True
        '
        'CurrODInterest
        '
        Me.CurrODInterest.HeaderText = "Curr. OD Interest"
        Me.CurrODInterest.Name = "CurrODInterest"
        Me.CurrODInterest.ReadOnly = True
        '
        'CollDate
        '
        Me.CollDate.HeaderText = "CollDate"
        Me.CollDate.Name = "CollDate"
        Me.CollDate.ReadOnly = True
        Me.CollDate.Width = 79
        '
        'CollPrincipal
        '
        Me.CollPrincipal.HeaderText = "CollPrincipal"
        Me.CollPrincipal.Name = "CollPrincipal"
        Me.CollPrincipal.ReadOnly = True
        Me.CollPrincipal.Width = 101
        '
        'CollInterest
        '
        Me.CollInterest.HeaderText = "CollInterest"
        Me.CollInterest.Name = "CollInterest"
        Me.CollInterest.ReadOnly = True
        Me.CollInterest.Width = 95
        '
        'CollODPrincipal
        '
        Me.CollODPrincipal.HeaderText = "CollODPrincipal"
        Me.CollODPrincipal.Name = "CollODPrincipal"
        Me.CollODPrincipal.ReadOnly = True
        Me.CollODPrincipal.Width = 119
        '
        'CollODInterest
        '
        Me.CollODInterest.HeaderText = "CollODInterest"
        Me.CollODInterest.Name = "CollODInterest"
        Me.CollODInterest.ReadOnly = True
        Me.CollODInterest.Width = 113
        '
        'BalPrincipal
        '
        Me.BalPrincipal.HeaderText = "BalPrincipal"
        Me.BalPrincipal.Name = "BalPrincipal"
        Me.BalPrincipal.ReadOnly = True
        '
        'BalInterest
        '
        Me.BalInterest.HeaderText = "BalInterest"
        Me.BalInterest.Name = "BalInterest"
        Me.BalInterest.ReadOnly = True
        '
        'BalODPrincipal
        '
        Me.BalODPrincipal.HeaderText = "BalODPrincipal"
        Me.BalODPrincipal.Name = "BalODPrincipal"
        Me.BalODPrincipal.ReadOnly = True
        '
        'BalODInterest
        '
        Me.BalODInterest.HeaderText = "BalODInterest"
        Me.BalODInterest.Name = "BalODInterest"
        Me.BalODInterest.ReadOnly = True
        '
        'CollOS
        '
        Me.CollOS.HeaderText = "CollOS"
        Me.CollOS.Name = "CollOS"
        Me.CollOS.ReadOnly = True
        Me.CollOS.Width = 69
        '
        'LoanOS
        '
        Me.LoanOS.HeaderText = "LoanOS"
        Me.LoanOS.Name = "LoanOS"
        Me.LoanOS.ReadOnly = True
        Me.LoanOS.Width = 76
        '
        'LoanOSforInt
        '
        Me.LoanOSforInt.HeaderText = "LoanOSforInt"
        Me.LoanOSforInt.Name = "LoanOSforInt"
        Me.LoanOSforInt.ReadOnly = True
        Me.LoanOSforInt.Width = 106
        '
        'StaffLoan
        '
        Me.StaffLoan.HeaderText = "StaffLoan"
        Me.StaffLoan.Name = "StaffLoan"
        Me.StaffLoan.ReadOnly = True
        Me.StaffLoan.Visible = False
        Me.StaffLoan.Width = 86
        '
        'WorkerLoan
        '
        Me.WorkerLoan.HeaderText = "WorkerLoan"
        Me.WorkerLoan.Name = "WorkerLoan"
        Me.WorkerLoan.ReadOnly = True
        Me.WorkerLoan.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 472)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1257, 55)
        Me.Panel2.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(699, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(487, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 39)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(593, 8)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 39)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.cmbMonth)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GLabel27)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpTo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpFrom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1257, 86)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.btnCalculation)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(972, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(283, 84)
        Me.Panel4.TabIndex = 147
        '
        'btnCalculation
        '
        Me.btnCalculation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculation.Location = New System.Drawing.Point(69, 19)
        Me.btnCalculation.Name = "btnCalculation"
        Me.btnCalculation.Size = New System.Drawing.Size(160, 47)
        Me.btnCalculation.TabIndex = 3
        Me.btnCalculation.Text = "&Calculate"
        Me.btnCalculation.UseVisualStyleBackColor = True
        '
        'cmbMonth
        '
        Me.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMonth.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbMonth.DefaultText = "--SELECT--"
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.EnterKey = True
        Me.cmbMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"--SELECT--", "MARCH -LAST A/c YEAR", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER", "JANUARY", "FEBRUARY", "MARCH"})
        Me.cmbMonth.Location = New System.Drawing.Point(126, 51)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.ShiftKey = True
        Me.cmbMonth.Size = New System.Drawing.Size(152, 26)
        Me.cmbMonth.TabIndex = 141
        Me.cmbMonth.Validation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "MONTH"
        '
        'GLabel27
        '
        Me.GLabel27.BackColor = System.Drawing.Color.Transparent
        Me.GLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Azure, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.GLabel27.ForeColorBlend = CBlendItems1
        Me.GLabel27.GlowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GLabel27.Location = New System.Drawing.Point(0, 3)
        Me.GLabel27.Name = "GLabel27"
        Me.GLabel27.ShadowColor = System.Drawing.Color.Gold
        Me.GLabel27.Size = New System.Drawing.Size(372, 33)
        Me.GLabel27.TabIndex = 146
        Me.GLabel27.Text = "Staff Loan Demands"
        Me.GLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(643, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Date To"
        '
        'dtpTo
        '
        Me.dtpTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpTo.Enabled = False
        Me.dtpTo.EnterKey = False
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpTo.Location = New System.Drawing.Point(753, 53)
        Me.dtpTo.Mask = "99/99/9999"
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ReadOnly = True
        Me.dtpTo.ShiftKey = True
        Me.dtpTo.Size = New System.Drawing.Size(87, 23)
        Me.dtpTo.TabIndex = 143
        Me.dtpTo.TabStop = False
        Me.dtpTo.Value = New Date(CType(0, Long))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(396, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Date From"
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFrom.Enabled = False
        Me.dtpFrom.EnterKey = False
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFrom.Location = New System.Drawing.Point(506, 53)
        Me.dtpFrom.Mask = "99/99/9999"
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ReadOnly = True
        Me.dtpFrom.ShiftKey = True
        Me.dtpFrom.Size = New System.Drawing.Size(87, 23)
        Me.dtpFrom.TabIndex = 140
        Me.dtpFrom.TabStop = False
        Me.dtpFrom.Value = New Date(CType(0, Long))
        '
        'frmStaffLoanDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmStaffLoanDemand"
        Me.pnlMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbMonth As sControls.ComboBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GLabel27 As sControls.gLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As sControls.DateTimeMaskvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As sControls.DateTimeMaskvb
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCalculation As System.Windows.Forms.Button
    Friend WithEvents Grid As sControls.ViewGrid
    Friend WithEvents Auto_SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DemandCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DemandDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FyCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TokenNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaturityDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanROI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanOutStanding As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanInterest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanODPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanODInterest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrInterest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrODPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrODInterest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollInterest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollODPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollODInterest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalInterest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalODPrincipal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalODInterest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanOSforInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffLoan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkerLoan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
