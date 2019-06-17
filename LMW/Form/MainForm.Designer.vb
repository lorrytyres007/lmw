<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslUserName = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslDescription = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslBranchname = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslFY = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslDate = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslSocietyCode = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslUserRights = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusBar = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslFontName = New System.Windows.Forms.ToolStripStatusLabel
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.pnlHeader1 = New System.Windows.Forms.Panel
        Me.lblCompanyName = New sControls.gLabel
        Me.pnlHeader2 = New System.Windows.Forms.Panel
        Me.pnlMenu = New System.Windows.Forms.Panel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuMaster = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMember = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuGroupDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLedgerDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuLoanDetails = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuNewUser = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUserRights = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTransaction = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuVoucherEntry = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuThriftDeposit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuThriftDepositInterestPosting = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuClossingthriftdeposit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuShareDeposit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuShareDividentPosting = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuClossingRefundShareDeposit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuMemberLoan = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLoanEMIChange = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLoanDemand = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuStaffLoanDemand = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuWorkersLoanDemand = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.mnuCollStaff = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCollWorkers = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.mnuStaffCorrections = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuWorkersCorrections = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRptMaster = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuGroupEntries = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHeadEntries = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMemberEntries = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDAYBOOK = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLedgerBook = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLedgerAbstract = New System.Windows.Forms.ToolStripMenuItem
        Me.rptmnuMonthlyRD = New System.Windows.Forms.ToolStripMenuItem
        Me.rptThriftDepositCollection = New System.Windows.Forms.ToolStripMenuItem
        Me.rptThriftDepositClossing = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuThriftDepositRefund = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuShareCollection = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuShareClossing = New System.Windows.Forms.ToolStripMenuItem
        Me.mnurptShareRefund = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuTrailBalance = New System.Windows.Forms.ToolStripMenuItem
        Me.mnurptMemberloanList = New System.Windows.Forms.ToolStripMenuItem
        Me.mnurptShareDivident = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.LoanDemandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.rptLoanCollectionReport = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLoanPassBook = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTDPassBook = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSHAREPassBook = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuYearEndProcess = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBackup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUpdationLock = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.pnlIcon = New System.Windows.Forms.Panel
        Me.pnlLeft = New System.Windows.Forms.Panel
        Me.StatusStrip1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlHeader1.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslUserName, Me.tslDescription, Me.tslBranchname, Me.tslFY, Me.tslDate, Me.tslSocietyCode, Me.tslUserRights, Me.StatusBar, Me.tslFontName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 556)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel1.Text = "User :"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tslUserName
        '
        Me.tslUserName.AutoToolTip = True
        Me.tslUserName.BackColor = System.Drawing.Color.White
        Me.tslUserName.BackgroundImage = Global.LMW.My.Resources.Resources.Caption
        Me.tslUserName.Name = "tslUserName"
        Me.tslUserName.Size = New System.Drawing.Size(0, 17)
        Me.tslUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tslDescription
        '
        Me.tslDescription.AutoSize = False
        Me.tslDescription.BackColor = System.Drawing.Color.White
        Me.tslDescription.Name = "tslDescription"
        Me.tslDescription.Size = New System.Drawing.Size(0, 17)
        '
        'tslBranchname
        '
        Me.tslBranchname.BackColor = System.Drawing.Color.White
        Me.tslBranchname.Name = "tslBranchname"
        Me.tslBranchname.Size = New System.Drawing.Size(0, 17)
        '
        'tslFY
        '
        Me.tslFY.BackColor = System.Drawing.Color.White
        Me.tslFY.Name = "tslFY"
        Me.tslFY.Size = New System.Drawing.Size(0, 17)
        '
        'tslDate
        '
        Me.tslDate.BackColor = System.Drawing.Color.White
        Me.tslDate.Name = "tslDate"
        Me.tslDate.Size = New System.Drawing.Size(0, 17)
        '
        'tslSocietyCode
        '
        Me.tslSocietyCode.BackColor = System.Drawing.Color.White
        Me.tslSocietyCode.Name = "tslSocietyCode"
        Me.tslSocietyCode.Size = New System.Drawing.Size(0, 17)
        '
        'tslUserRights
        '
        Me.tslUserRights.BackColor = System.Drawing.Color.White
        Me.tslUserRights.BackgroundImage = Global.LMW.My.Resources.Resources.menu
        Me.tslUserRights.Name = "tslUserRights"
        Me.tslUserRights.Size = New System.Drawing.Size(0, 17)
        Me.tslUserRights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.Color.White
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(0, 17)
        '
        'tslFontName
        '
        Me.tslFontName.Name = "tslFontName"
        Me.tslFontName.Size = New System.Drawing.Size(133, 17)
        Me.tslFontName.Text = "ToolStripStatusLabel2"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.pnlHeader1)
        Me.pnlTop.Controls.Add(Me.pnlHeader2)
        Me.pnlTop.Controls.Add(Me.pnlMenu)
        Me.pnlTop.Controls.Add(Me.pnlIcon)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1028, 104)
        Me.pnlTop.TabIndex = 34
        '
        'pnlHeader1
        '
        Me.pnlHeader1.BackgroundImage = Global.LMW.My.Resources.Resources.h1
        Me.pnlHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHeader1.Controls.Add(Me.lblCompanyName)
        Me.pnlHeader1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader1.Location = New System.Drawing.Point(109, 0)
        Me.pnlHeader1.Name = "pnlHeader1"
        Me.pnlHeader1.Size = New System.Drawing.Size(823, 76)
        Me.pnlHeader1.TabIndex = 2
        '
        'lblCompanyName
        '
        Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyName.BorderColor = System.Drawing.Color.Transparent
        Me.lblCompanyName.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.Color.White
        Me.lblCompanyName.GlowColor = System.Drawing.Color.Yellow
        Me.lblCompanyName.Location = New System.Drawing.Point(6, 15)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(833, 46)
        Me.lblCompanyName.TabIndex = 18
        Me.lblCompanyName.Text = "SWAS TECHNOLOGIES"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlHeader2
        '
        Me.pnlHeader2.BackgroundImage = Global.LMW.My.Resources.Resources.h2
        Me.pnlHeader2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHeader2.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlHeader2.Location = New System.Drawing.Point(932, 0)
        Me.pnlHeader2.Name = "pnlHeader2"
        Me.pnlHeader2.Size = New System.Drawing.Size(96, 76)
        Me.pnlHeader2.TabIndex = 1
        '
        'pnlMenu
        '
        Me.pnlMenu.BackgroundImage = Global.LMW.My.Resources.Resources.menu
        Me.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMenu.Controls.Add(Me.MenuStrip1)
        Me.pnlMenu.Controls.Add(Me.MenuStrip2)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlMenu.Location = New System.Drawing.Point(109, 76)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(919, 28)
        Me.pnlMenu.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMaster, Me.mnuTransaction, Me.mnuLoanDemand, Me.mnuReports, Me.mnuHelp, Me.mnuLogout, Me.mnuExit})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(2, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMaster
        '
        Me.mnuMaster.BackColor = System.Drawing.Color.Transparent
        Me.mnuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMember, Me.ToolStripSeparator1, Me.mnuGroupDetails, Me.mnuLedgerDetails, Me.ToolStripSeparator2, Me.mnuLoanDetails, Me.ToolStripSeparator7, Me.mnuNewUser, Me.mnuUserRights})
        Me.mnuMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMaster.ForeColor = System.Drawing.Color.Black
        Me.mnuMaster.Name = "mnuMaster"
        Me.mnuMaster.Size = New System.Drawing.Size(67, 20)
        Me.mnuMaster.Text = "Master"
        '
        'mnuMember
        '
        Me.mnuMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMember.ForeColor = System.Drawing.Color.Black
        Me.mnuMember.Name = "mnuMember"
        Me.mnuMember.Size = New System.Drawing.Size(171, 22)
        Me.mnuMember.Text = "Member Details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'mnuGroupDetails
        '
        Me.mnuGroupDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuGroupDetails.ForeColor = System.Drawing.Color.Black
        Me.mnuGroupDetails.Name = "mnuGroupDetails"
        Me.mnuGroupDetails.Size = New System.Drawing.Size(171, 22)
        Me.mnuGroupDetails.Text = "Group Details"
        '
        'mnuLedgerDetails
        '
        Me.mnuLedgerDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLedgerDetails.ForeColor = System.Drawing.Color.Black
        Me.mnuLedgerDetails.Name = "mnuLedgerDetails"
        Me.mnuLedgerDetails.Size = New System.Drawing.Size(171, 22)
        Me.mnuLedgerDetails.Text = "Head Details"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(168, 6)
        '
        'mnuLoanDetails
        '
        Me.mnuLoanDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLoanDetails.Name = "mnuLoanDetails"
        Me.mnuLoanDetails.Size = New System.Drawing.Size(171, 22)
        Me.mnuLoanDetails.Text = "Loan Details"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(168, 6)
        '
        'mnuNewUser
        '
        Me.mnuNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuNewUser.ForeColor = System.Drawing.Color.Black
        Me.mnuNewUser.Name = "mnuNewUser"
        Me.mnuNewUser.Size = New System.Drawing.Size(171, 22)
        Me.mnuNewUser.Text = "User Details"
        '
        'mnuUserRights
        '
        Me.mnuUserRights.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUserRights.Name = "mnuUserRights"
        Me.mnuUserRights.Size = New System.Drawing.Size(171, 22)
        Me.mnuUserRights.Text = "User Rights"
        '
        'mnuTransaction
        '
        Me.mnuTransaction.BackColor = System.Drawing.Color.Transparent
        Me.mnuTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVoucherEntry, Me.mnuThriftDeposit, Me.mnuThriftDepositInterestPosting, Me.mnuClossingthriftdeposit, Me.ToolStripSeparator3, Me.mnuShareDeposit, Me.mnuShareDividentPosting, Me.mnuClossingRefundShareDeposit, Me.ToolStripSeparator6, Me.mnuMemberLoan, Me.mnuLoanEMIChange})
        Me.mnuTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTransaction.ForeColor = System.Drawing.Color.Black
        Me.mnuTransaction.Name = "mnuTransaction"
        Me.mnuTransaction.Size = New System.Drawing.Size(102, 20)
        Me.mnuTransaction.Text = "Transaction"
        '
        'mnuVoucherEntry
        '
        Me.mnuVoucherEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuVoucherEntry.ForeColor = System.Drawing.Color.Black
        Me.mnuVoucherEntry.Name = "mnuVoucherEntry"
        Me.mnuVoucherEntry.Size = New System.Drawing.Size(293, 22)
        Me.mnuVoucherEntry.Text = "Voucher Entry"
        '
        'mnuThriftDeposit
        '
        Me.mnuThriftDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuThriftDeposit.Name = "mnuThriftDeposit"
        Me.mnuThriftDeposit.Size = New System.Drawing.Size(293, 22)
        Me.mnuThriftDeposit.Text = "Thrift Deposit individual Receipt"
        '
        'mnuThriftDepositInterestPosting
        '
        Me.mnuThriftDepositInterestPosting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuThriftDepositInterestPosting.Name = "mnuThriftDepositInterestPosting"
        Me.mnuThriftDepositInterestPosting.Size = New System.Drawing.Size(293, 22)
        Me.mnuThriftDepositInterestPosting.Text = "Thrift Deposit Interest Posting"
        '
        'mnuClossingthriftdeposit
        '
        Me.mnuClossingthriftdeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuClossingthriftdeposit.Name = "mnuClossingthriftdeposit"
        Me.mnuClossingthriftdeposit.Size = New System.Drawing.Size(293, 22)
        Me.mnuClossingthriftdeposit.Text = "Clossing/Refund Thrift Deposit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(290, 6)
        '
        'mnuShareDeposit
        '
        Me.mnuShareDeposit.Name = "mnuShareDeposit"
        Me.mnuShareDeposit.Size = New System.Drawing.Size(293, 22)
        Me.mnuShareDeposit.Text = "Share Deposit"
        '
        'mnuShareDividentPosting
        '
        Me.mnuShareDividentPosting.Name = "mnuShareDividentPosting"
        Me.mnuShareDividentPosting.Size = New System.Drawing.Size(293, 22)
        Me.mnuShareDividentPosting.Text = "Share Divident Posting"
        '
        'mnuClossingRefundShareDeposit
        '
        Me.mnuClossingRefundShareDeposit.Name = "mnuClossingRefundShareDeposit"
        Me.mnuClossingRefundShareDeposit.Size = New System.Drawing.Size(293, 22)
        Me.mnuClossingRefundShareDeposit.Text = "Clossing/Refund Share Deposit"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(290, 6)
        '
        'mnuMemberLoan
        '
        Me.mnuMemberLoan.Name = "mnuMemberLoan"
        Me.mnuMemberLoan.Size = New System.Drawing.Size(293, 22)
        Me.mnuMemberLoan.Text = "Member Loan"
        '
        'mnuLoanEMIChange
        '
        Me.mnuLoanEMIChange.Name = "mnuLoanEMIChange"
        Me.mnuLoanEMIChange.Size = New System.Drawing.Size(293, 22)
        Me.mnuLoanEMIChange.Text = "Loan  EMI Change"
        '
        'mnuLoanDemand
        '
        Me.mnuLoanDemand.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStaffLoanDemand, Me.mnuWorkersLoanDemand, Me.ToolStripTextBox1, Me.mnuCollStaff, Me.mnuCollWorkers, Me.ToolStripTextBox2, Me.mnuStaffCorrections, Me.mnuWorkersCorrections})
        Me.mnuLoanDemand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.mnuLoanDemand.Name = "mnuLoanDemand"
        Me.mnuLoanDemand.Size = New System.Drawing.Size(116, 20)
        Me.mnuLoanDemand.Text = "Loan Demand"
        '
        'mnuStaffLoanDemand
        '
        Me.mnuStaffLoanDemand.Name = "mnuStaffLoanDemand"
        Me.mnuStaffLoanDemand.Size = New System.Drawing.Size(160, 22)
        Me.mnuStaffLoanDemand.Text = "Staff"
        '
        'mnuWorkersLoanDemand
        '
        Me.mnuWorkersLoanDemand.Name = "mnuWorkersLoanDemand"
        Me.mnuWorkersLoanDemand.Size = New System.Drawing.Size(160, 22)
        Me.mnuWorkersLoanDemand.Text = "Workers"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.Black
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripTextBox1.ForeColor = System.Drawing.Color.White
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "COLLECTION"
        '
        'mnuCollStaff
        '
        Me.mnuCollStaff.Name = "mnuCollStaff"
        Me.mnuCollStaff.Size = New System.Drawing.Size(160, 22)
        Me.mnuCollStaff.Text = "Staff"
        '
        'mnuCollWorkers
        '
        Me.mnuCollWorkers.Name = "mnuCollWorkers"
        Me.mnuCollWorkers.Size = New System.Drawing.Size(160, 22)
        Me.mnuCollWorkers.Text = "Workers"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BackColor = System.Drawing.Color.Black
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripTextBox2.ForeColor = System.Drawing.Color.White
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 27)
        Me.ToolStripTextBox2.Text = "Checking"
        '
        'mnuStaffCorrections
        '
        Me.mnuStaffCorrections.Name = "mnuStaffCorrections"
        Me.mnuStaffCorrections.Size = New System.Drawing.Size(160, 22)
        Me.mnuStaffCorrections.Text = "Staff"
        '
        'mnuWorkersCorrections
        '
        Me.mnuWorkersCorrections.Name = "mnuWorkersCorrections"
        Me.mnuWorkersCorrections.Size = New System.Drawing.Size(160, 22)
        Me.mnuWorkersCorrections.Text = "Workers"
        '
        'mnuReports
        '
        Me.mnuReports.BackColor = System.Drawing.Color.Transparent
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRptMaster, Me.mnuDAYBOOK, Me.mnuLedgerBook, Me.mnuLedgerAbstract, Me.rptmnuMonthlyRD, Me.rptThriftDepositCollection, Me.rptThriftDepositClossing, Me.mnuThriftDepositRefund, Me.ToolStripSeparator4, Me.mnuShareCollection, Me.mnuShareClossing, Me.mnurptShareRefund, Me.ToolStripSeparator5, Me.mnuTrailBalance, Me.mnurptMemberloanList, Me.mnurptShareDivident, Me.ToolStripSeparator8, Me.LoanDemandToolStripMenuItem, Me.rptLoanCollectionReport, Me.mnuLoanPassBook, Me.mnuTDPassBook, Me.mnuSHAREPassBook})
        Me.mnuReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuReports.ForeColor = System.Drawing.Color.Black
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(75, 20)
        Me.mnuReports.Text = "Reports"
        '
        'mnuRptMaster
        '
        Me.mnuRptMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGroupEntries, Me.mnuHeadEntries, Me.mnuMemberEntries})
        Me.mnuRptMaster.Name = "mnuRptMaster"
        Me.mnuRptMaster.Size = New System.Drawing.Size(242, 22)
        Me.mnuRptMaster.Text = "Master"
        '
        'mnuGroupEntries
        '
        Me.mnuGroupEntries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuGroupEntries.Name = "mnuGroupEntries"
        Me.mnuGroupEntries.Size = New System.Drawing.Size(170, 22)
        Me.mnuGroupEntries.Text = "Group Entries"
        '
        'mnuHeadEntries
        '
        Me.mnuHeadEntries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHeadEntries.Name = "mnuHeadEntries"
        Me.mnuHeadEntries.Size = New System.Drawing.Size(170, 22)
        Me.mnuHeadEntries.Text = "Head Entries"
        '
        'mnuMemberEntries
        '
        Me.mnuMemberEntries.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMemberEntries.Name = "mnuMemberEntries"
        Me.mnuMemberEntries.Size = New System.Drawing.Size(170, 22)
        Me.mnuMemberEntries.Text = "Member Entries"
        '
        'mnuDAYBOOK
        '
        Me.mnuDAYBOOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDAYBOOK.ForeColor = System.Drawing.Color.Black
        Me.mnuDAYBOOK.Name = "mnuDAYBOOK"
        Me.mnuDAYBOOK.Size = New System.Drawing.Size(242, 22)
        Me.mnuDAYBOOK.Text = "DayBook(Cash Book)"
        '
        'mnuLedgerBook
        '
        Me.mnuLedgerBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLedgerBook.ForeColor = System.Drawing.Color.Black
        Me.mnuLedgerBook.Name = "mnuLedgerBook"
        Me.mnuLedgerBook.Size = New System.Drawing.Size(242, 22)
        Me.mnuLedgerBook.Text = "LedgerBook (GL)"
        '
        'mnuLedgerAbstract
        '
        Me.mnuLedgerAbstract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLedgerAbstract.Name = "mnuLedgerAbstract"
        Me.mnuLedgerAbstract.Size = New System.Drawing.Size(242, 22)
        Me.mnuLedgerAbstract.Text = "Ledger Abstract"
        '
        'rptmnuMonthlyRD
        '
        Me.rptmnuMonthlyRD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rptmnuMonthlyRD.ForeColor = System.Drawing.Color.Black
        Me.rptmnuMonthlyRD.Name = "rptmnuMonthlyRD"
        Me.rptmnuMonthlyRD.Size = New System.Drawing.Size(242, 22)
        Me.rptmnuMonthlyRD.Text = "Monthly R&&D"
        '
        'rptThriftDepositCollection
        '
        Me.rptThriftDepositCollection.Name = "rptThriftDepositCollection"
        Me.rptThriftDepositCollection.Size = New System.Drawing.Size(242, 22)
        Me.rptThriftDepositCollection.Text = "Thrift Deposit Collection"
        '
        'rptThriftDepositClossing
        '
        Me.rptThriftDepositClossing.Name = "rptThriftDepositClossing"
        Me.rptThriftDepositClossing.Size = New System.Drawing.Size(242, 22)
        Me.rptThriftDepositClossing.Text = "Thrift Deposit Clossing"
        '
        'mnuThriftDepositRefund
        '
        Me.mnuThriftDepositRefund.Name = "mnuThriftDepositRefund"
        Me.mnuThriftDepositRefund.Size = New System.Drawing.Size(242, 22)
        Me.mnuThriftDepositRefund.Text = "Thrift Deposit Refund"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(239, 6)
        '
        'mnuShareCollection
        '
        Me.mnuShareCollection.Name = "mnuShareCollection"
        Me.mnuShareCollection.Size = New System.Drawing.Size(242, 22)
        Me.mnuShareCollection.Text = "Share Collection"
        '
        'mnuShareClossing
        '
        Me.mnuShareClossing.Name = "mnuShareClossing"
        Me.mnuShareClossing.Size = New System.Drawing.Size(242, 22)
        Me.mnuShareClossing.Text = "Share Clossing"
        '
        'mnurptShareRefund
        '
        Me.mnurptShareRefund.Name = "mnurptShareRefund"
        Me.mnurptShareRefund.Size = New System.Drawing.Size(242, 22)
        Me.mnurptShareRefund.Text = "Share Refund"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(239, 6)
        '
        'mnuTrailBalance
        '
        Me.mnuTrailBalance.Name = "mnuTrailBalance"
        Me.mnuTrailBalance.Size = New System.Drawing.Size(242, 22)
        Me.mnuTrailBalance.Text = "Trail Balance"
        '
        'mnurptMemberloanList
        '
        Me.mnurptMemberloanList.Name = "mnurptMemberloanList"
        Me.mnurptMemberloanList.Size = New System.Drawing.Size(242, 22)
        Me.mnurptMemberloanList.Text = "Member Loan List"
        '
        'mnurptShareDivident
        '
        Me.mnurptShareDivident.Name = "mnurptShareDivident"
        Me.mnurptShareDivident.Size = New System.Drawing.Size(242, 22)
        Me.mnurptShareDivident.Text = "Share Divident"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(239, 6)
        '
        'LoanDemandToolStripMenuItem
        '
        Me.LoanDemandToolStripMenuItem.Name = "LoanDemandToolStripMenuItem"
        Me.LoanDemandToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.LoanDemandToolStripMenuItem.Text = "Loan Demand Report"
        '
        'rptLoanCollectionReport
        '
        Me.rptLoanCollectionReport.Name = "rptLoanCollectionReport"
        Me.rptLoanCollectionReport.Size = New System.Drawing.Size(242, 22)
        Me.rptLoanCollectionReport.Text = "Loan Collection Report"
        '
        'mnuLoanPassBook
        '
        Me.mnuLoanPassBook.Name = "mnuLoanPassBook"
        Me.mnuLoanPassBook.Size = New System.Drawing.Size(242, 22)
        Me.mnuLoanPassBook.Text = "Loan Pass Book"
        '
        'mnuTDPassBook
        '
        Me.mnuTDPassBook.Name = "mnuTDPassBook"
        Me.mnuTDPassBook.Size = New System.Drawing.Size(242, 22)
        Me.mnuTDPassBook.Text = "TD Pass Book"
        '
        'mnuSHAREPassBook
        '
        Me.mnuSHAREPassBook.Name = "mnuSHAREPassBook"
        Me.mnuSHAREPassBook.Size = New System.Drawing.Size(242, 22)
        Me.mnuSHAREPassBook.Text = "SHARE Pass Book"
        '
        'mnuHelp
        '
        Me.mnuHelp.BackColor = System.Drawing.Color.Transparent
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuYearEndProcess, Me.mnuBackup, Me.mnuUpdationLock})
        Me.mnuHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHelp.ForeColor = System.Drawing.Color.Black
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(76, 20)
        Me.mnuHelp.Text = "Settings"
        '
        'mnuYearEndProcess
        '
        Me.mnuYearEndProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuYearEndProcess.ForeColor = System.Drawing.Color.Black
        Me.mnuYearEndProcess.Name = "mnuYearEndProcess"
        Me.mnuYearEndProcess.Size = New System.Drawing.Size(185, 22)
        Me.mnuYearEndProcess.Text = "Year End Process"
        '
        'mnuBackup
        '
        Me.mnuBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBackup.ForeColor = System.Drawing.Color.Black
        Me.mnuBackup.Name = "mnuBackup"
        Me.mnuBackup.Size = New System.Drawing.Size(185, 22)
        Me.mnuBackup.Text = "Backup"
        '
        'mnuUpdationLock
        '
        Me.mnuUpdationLock.Name = "mnuUpdationLock"
        Me.mnuUpdationLock.Size = New System.Drawing.Size(185, 22)
        Me.mnuUpdationLock.Text = "Updation Lock"
        '
        'mnuLogout
        '
        Me.mnuLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLogout.ForeColor = System.Drawing.Color.Black
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(67, 20)
        Me.mnuLogout.Text = "Logout"
        '
        'mnuExit
        '
        Me.mnuExit.BackColor = System.Drawing.Color.Transparent
        Me.mnuExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuExit.ForeColor = System.Drawing.Color.Black
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(45, 20)
        Me.mnuExit.Text = "Exit"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuStrip2.Location = New System.Drawing.Point(889, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip2.Size = New System.Drawing.Size(30, 28)
        Me.MenuStrip2.TabIndex = 19
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'pnlIcon
        '
        Me.pnlIcon.BackgroundImage = Global.LMW.My.Resources.Resources.logo
        Me.pnlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIcon.Location = New System.Drawing.Point(0, 0)
        Me.pnlIcon.Name = "pnlIcon"
        Me.pnlIcon.Size = New System.Drawing.Size(109, 104)
        Me.pnlIcon.TabIndex = 0
        '
        'pnlLeft
        '
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 104)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(0, 452)
        Me.pnlLeft.TabIndex = 35
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.LMW.My.Resources.Resources.white
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 578)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pnlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "MainForm"
        Me.Text = "LMW Project V1.1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlHeader1.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslUserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslDescription As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlIcon As System.Windows.Forms.Panel
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader2 As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents mnuMember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuYearEndProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tslBranchname As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslFY As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlHeader1 As System.Windows.Forms.Panel
    Friend WithEvents tslSocietyCode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGroupDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLedgerDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tslUserRights As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslFontName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuVoucherEntry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDAYBOOK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLedgerBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rptmnuMonthlyRD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuThriftDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCompanyName As sControls.gLabel
    Friend WithEvents mnuRptMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGroupEntries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHeadEntries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMemberEntries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLedgerAbstract As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rptThriftDepositCollection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClossingthriftdeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rptThriftDepositClossing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuThriftDepositInterestPosting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuThriftDepositRefund As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuShareDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShareDividentPosting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClossingRefundShareDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTrailBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShareCollection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShareClossing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuLoanDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuMemberLoan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnurptShareRefund As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuUserRights As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLoanDemand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStaffLoanDemand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWorkersLoanDemand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnurptMemberloanList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents mnuCollStaff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCollWorkers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnurptShareDivident As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LoanDemandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUpdationLock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLoanPassBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLoanEMIChange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTDPassBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSHAREPassBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rptLoanCollectionReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents mnuStaffCorrections As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWorkersCorrections As System.Windows.Forms.ToolStripMenuItem
End Class
