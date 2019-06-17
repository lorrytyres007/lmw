<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptLoanDetails
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
        Me.cmbMemberType = New sControls.ComboBoxvb
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblEmpName = New System.Windows.Forms.Label
        Me.cmbLoanNumber = New sControls.ComboBoxvb
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbEmployeeNumber = New sControls.ComboBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLoanName = New sControls.ComboBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.dtpTo = New sControls.DateTimePickervb
        Me.btnView = New System.Windows.Forms.Button
        Me.dtpFrom = New sControls.DateTimePickervb
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.chkDate = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel3.Location = New System.Drawing.Point(288, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(740, 508)
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
        Me.rptViewer.Size = New System.Drawing.Size(738, 506)
        Me.rptViewer.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.chkDate)
        Me.Panel2.Controls.Add(Me.pnlDate)
        Me.Panel2.Controls.Add(Me.cmbMemberType)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblEmpName)
        Me.Panel2.Controls.Add(Me.cmbLoanNumber)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmbEmployeeNumber)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmbLoanName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(288, 508)
        Me.Panel2.TabIndex = 0
        '
        'cmbMemberType
        '
        Me.cmbMemberType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMemberType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMemberType.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbMemberType.DefaultText = "-- SELECT --"
        Me.cmbMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMemberType.EnterKey = True
        Me.cmbMemberType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMemberType.FormattingEnabled = True
        Me.cmbMemberType.Items.AddRange(New Object() {"--ALL--", "STAFF", "WORKER", "OTHERS"})
        Me.cmbMemberType.Location = New System.Drawing.Point(36, 134)
        Me.cmbMemberType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMemberType.Name = "cmbMemberType"
        Me.cmbMemberType.ShiftKey = True
        Me.cmbMemberType.Size = New System.Drawing.Size(244, 26)
        Me.cmbMemberType.TabIndex = 2
        Me.cmbMemberType.Validation = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Member Type"
        '
        'lblEmpName
        '
        Me.lblEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpName.Location = New System.Drawing.Point(36, 280)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(244, 31)
        Me.lblEmpName.TabIndex = 20
        Me.lblEmpName.Text = "Employee Name"
        '
        'cmbLoanNumber
        '
        Me.cmbLoanNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLoanNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLoanNumber.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbLoanNumber.DefaultText = "-- SELECT --"
        Me.cmbLoanNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoanNumber.EnterKey = True
        Me.cmbLoanNumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoanNumber.FormattingEnabled = True
        Me.cmbLoanNumber.Location = New System.Drawing.Point(36, 334)
        Me.cmbLoanNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLoanNumber.Name = "cmbLoanNumber"
        Me.cmbLoanNumber.ShiftKey = True
        Me.cmbLoanNumber.Size = New System.Drawing.Size(244, 26)
        Me.cmbLoanNumber.TabIndex = 5
        Me.cmbLoanNumber.Validation = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Loan Number"
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
        Me.cmbEmployeeNumber.Location = New System.Drawing.Point(36, 250)
        Me.cmbEmployeeNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEmployeeNumber.Name = "cmbEmployeeNumber"
        Me.cmbEmployeeNumber.ShiftKey = True
        Me.cmbEmployeeNumber.Size = New System.Drawing.Size(244, 26)
        Me.cmbEmployeeNumber.TabIndex = 4
        Me.cmbEmployeeNumber.Validation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Employee Number"
        '
        'cmbLoanName
        '
        Me.cmbLoanName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLoanName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLoanName.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbLoanName.DefaultText = "-- SELECT --"
        Me.cmbLoanName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoanName.EnterKey = True
        Me.cmbLoanName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoanName.FormattingEnabled = True
        Me.cmbLoanName.Location = New System.Drawing.Point(36, 191)
        Me.cmbLoanName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLoanName.Name = "cmbLoanName"
        Me.cmbLoanName.ShiftKey = True
        Me.cmbLoanName.Size = New System.Drawing.Size(244, 26)
        Me.cmbLoanName.TabIndex = 3
        Me.cmbLoanName.Validation = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Loan Name"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(143, 396)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd/MMM/yyyy"
        Me.dtpTo.EnterKey = True
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(123, 48)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTo.MaxDate = New Date(2110, 5, 11, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1910, 5, 11, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShiftKey = True
        Me.dtpTo.Size = New System.Drawing.Size(124, 23)
        Me.dtpTo.TabIndex = 1
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(65, 396)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 24)
        Me.btnView.TabIndex = 6
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFrom.EnterKey = True
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(123, 17)
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
        Me.pnlDate.Size = New System.Drawing.Size(286, 89)
        Me.pnlDate.TabIndex = 23
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(199, 95)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(87, 17)
        Me.chkDate.TabIndex = 24
        Me.chkDate.Text = "Date Disable"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'rptLoanDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "rptLoanDetails"
        Me.Text = "rptLoanDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtpTo As sControls.DateTimePickervb
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents dtpFrom As sControls.DateTimePickervb
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbEmployeeNumber As sControls.ComboBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLoanName As sControls.ComboBoxvb
    Friend WithEvents cmbLoanNumber As sControls.ComboBoxvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents cmbMemberType As sControls.ComboBoxvb
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
End Class
