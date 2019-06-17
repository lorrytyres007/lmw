<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptSharePassBook
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rptViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnFRView = New System.Windows.Forms.Button
        Me.pnlBar = New System.Windows.Forms.Panel
        Me.lblBarStatus = New System.Windows.Forms.Label
        Me.PBar1 = New System.Windows.Forms.ProgressBar
        Me.btnClear = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.chkDate = New System.Windows.Forms.CheckBox
        Me.lblEmpName = New System.Windows.Forms.Label
        Me.cmbEmployeeNumber = New sControls.ComboBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.dtpTo = New sControls.DateTimePickervb
        Me.dtpFrom = New sControls.DateTimePickervb
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlBar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 508)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.rptViewer)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(334, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(694, 508)
        Me.Panel3.TabIndex = 1
        '
        'rptViewer
        '
        Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "sTapesDataSet_sp_Customer_GetAll"
        ReportDataSource1.Value = Nothing
        Me.rptViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptViewer.LocalReport.ReportEmbeddedResource = "sTapes.rptCustomer.rdlc"
        Me.rptViewer.Location = New System.Drawing.Point(0, 0)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.Size = New System.Drawing.Size(692, 506)
        Me.rptViewer.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnFRView)
        Me.Panel2.Controls.Add(Me.pnlBar)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.pnlDate)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 508)
        Me.Panel2.TabIndex = 0
        '
        'btnFRView
        '
        Me.btnFRView.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnFRView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnFRView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFRView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFRView.ForeColor = System.Drawing.Color.White
        Me.btnFRView.Location = New System.Drawing.Point(172, 214)
        Me.btnFRView.Name = "btnFRView"
        Me.btnFRView.Size = New System.Drawing.Size(75, 24)
        Me.btnFRView.TabIndex = 28
        Me.btnFRView.Text = "&FR-View"
        Me.btnFRView.UseVisualStyleBackColor = False
        '
        'pnlBar
        '
        Me.pnlBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBar.Controls.Add(Me.lblBarStatus)
        Me.pnlBar.Controls.Add(Me.PBar1)
        Me.pnlBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBar.Location = New System.Drawing.Point(0, 372)
        Me.pnlBar.Name = "pnlBar"
        Me.pnlBar.Size = New System.Drawing.Size(332, 134)
        Me.pnlBar.TabIndex = 5
        Me.pnlBar.Visible = False
        '
        'lblBarStatus
        '
        Me.lblBarStatus.AutoSize = True
        Me.lblBarStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarStatus.Location = New System.Drawing.Point(31, 35)
        Me.lblBarStatus.Name = "lblBarStatus"
        Me.lblBarStatus.Size = New System.Drawing.Size(80, 16)
        Me.lblBarStatus.TabIndex = 18
        Me.lblBarStatus.Text = "lblBarStatus"
        '
        'PBar1
        '
        Me.PBar1.Location = New System.Drawing.Point(31, 54)
        Me.PBar1.Name = "PBar1"
        Me.PBar1.Size = New System.Drawing.Size(271, 32)
        Me.PBar1.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(92, 214)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 24)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.chkDate)
        Me.Panel4.Controls.Add(Me.lblEmpName)
        Me.Panel4.Controls.Add(Me.cmbEmployeeNumber)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 84)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(332, 124)
        Me.Panel4.TabIndex = 1
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(236, 3)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(87, 17)
        Me.chkDate.TabIndex = 24
        Me.chkDate.TabStop = False
        Me.chkDate.Text = "Date Disable"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'lblEmpName
        '
        Me.lblEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpName.Location = New System.Drawing.Point(31, 77)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(244, 31)
        Me.lblEmpName.TabIndex = 20
        Me.lblEmpName.Text = "Employee Name"
        '
        'cmbEmployeeNumber
        '
        Me.cmbEmployeeNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmployeeNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmployeeNumber.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbEmployeeNumber.DefaultText = "-- SELECT --"
        Me.cmbEmployeeNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmployeeNumber.EnterKey = True
        Me.cmbEmployeeNumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmployeeNumber.FormattingEnabled = True
        Me.cmbEmployeeNumber.Location = New System.Drawing.Point(31, 47)
        Me.cmbEmployeeNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEmployeeNumber.Name = "cmbEmployeeNumber"
        Me.cmbEmployeeNumber.ShiftKey = True
        Me.cmbEmployeeNumber.Size = New System.Drawing.Size(292, 26)
        Me.cmbEmployeeNumber.TabIndex = 0
        Me.cmbEmployeeNumber.Validation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Employee Number"
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Controls.Add(Me.Label5)
        Me.pnlDate.Controls.Add(Me.Label4)
        Me.pnlDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDate.Enabled = False
        Me.pnlDate.Location = New System.Drawing.Point(0, 0)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(332, 84)
        Me.pnlDate.TabIndex = 0
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd/MMM/yyyy"
        Me.dtpTo.EnterKey = True
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(151, 45)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTo.MaxDate = New Date(2110, 5, 11, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1910, 5, 11, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShiftKey = True
        Me.dtpTo.Size = New System.Drawing.Size(124, 23)
        Me.dtpTo.TabIndex = 1
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFrom.EnterKey = True
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(151, 17)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFrom.MaxDate = New Date(2110, 5, 11, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1910, 5, 11, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShiftKey = True
        Me.dtpFrom.Size = New System.Drawing.Size(124, 23)
        Me.dtpFrom.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "To"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(253, 214)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 24)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(11, 214)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 24)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'rptSharePassBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "rptSharePassBook"
        Me.Text = "SHARE  - PASS BOOK PRINTING"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlBar.ResumeLayout(False)
        Me.pnlBar.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtpTo As sControls.DateTimePickervb
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents dtpFrom As sControls.DateTimePickervb
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbEmployeeNumber As sControls.ComboBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents pnlBar As System.Windows.Forms.Panel
    Friend WithEvents lblBarStatus As System.Windows.Forms.Label
    Friend WithEvents PBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnFRView As System.Windows.Forms.Button
End Class
