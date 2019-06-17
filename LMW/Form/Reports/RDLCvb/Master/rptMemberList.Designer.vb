<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptMemberList
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
        Me.chkOther = New System.Windows.Forms.CheckBox
        Me.chkWorker = New System.Windows.Forms.CheckBox
        Me.chkStaff = New System.Windows.Forms.CheckBox
        Me.cmbCategory = New sControls.ComboBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbStatus = New sControls.ComboBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.rptViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpAsonDate = New sControls.DateTimePickervb
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpAsonDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chkOther)
        Me.Panel1.Controls.Add(Me.chkWorker)
        Me.Panel1.Controls.Add(Me.chkStaff)
        Me.Panel1.Controls.Add(Me.cmbCategory)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbStatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 414)
        Me.Panel1.TabIndex = 0
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOther.Location = New System.Drawing.Point(95, 152)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(108, 24)
        Me.chkOther.TabIndex = 11
        Me.chkOther.Text = "          Other"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'chkWorker
        '
        Me.chkWorker.AutoSize = True
        Me.chkWorker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWorker.Location = New System.Drawing.Point(95, 116)
        Me.chkWorker.Name = "chkWorker"
        Me.chkWorker.Size = New System.Drawing.Size(119, 24)
        Me.chkWorker.TabIndex = 10
        Me.chkWorker.Text = "          Worker"
        Me.chkWorker.UseVisualStyleBackColor = True
        '
        'chkStaff
        '
        Me.chkStaff.AutoSize = True
        Me.chkStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStaff.Location = New System.Drawing.Point(95, 80)
        Me.chkStaff.Name = "chkStaff"
        Me.chkStaff.Size = New System.Drawing.Size(103, 24)
        Me.chkStaff.TabIndex = 9
        Me.chkStaff.Text = "          Staff"
        Me.chkStaff.UseVisualStyleBackColor = True
        '
        'cmbCategory
        '
        Me.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCategory.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbCategory.DefaultText = "--ALL--"
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.EnterKey = True
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"--ALL--", "Member", "Non Member"})
        Me.cmbCategory.Location = New System.Drawing.Point(95, 32)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.ShiftKey = True
        Me.cmbCategory.Size = New System.Drawing.Size(155, 28)
        Me.cmbCategory.TabIndex = 0
        Me.cmbCategory.Validation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Category"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStatus.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbStatus.DefaultText = "--ALL--"
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.EnterKey = True
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"--ALL--", "ACTIVE", "INACTIVE"})
        Me.cmbStatus.Location = New System.Drawing.Point(95, 199)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShiftKey = True
        Me.cmbStatus.Size = New System.Drawing.Size(155, 28)
        Me.cmbStatus.TabIndex = 1
        Me.cmbStatus.Validation = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Status"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Location = New System.Drawing.Point(73, 310)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 28)
        Me.Panel2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(81, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 24)
        Me.btnClose.TabIndex = 1
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
        Me.btnView.Location = New System.Drawing.Point(3, 2)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 24)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'rptViewer
        '
        Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "rptDataSet_sp_MemberList_GetAll"
        ReportDataSource1.Value = Nothing
        Me.rptViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptViewer.LocalReport.ReportEmbeddedResource = "sTapes.rptMemberList.rdlc"
        Me.rptViewer.Location = New System.Drawing.Point(283, 0)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ShowDocumentMapButton = False
        Me.rptViewer.Size = New System.Drawing.Size(476, 414)
        Me.rptViewer.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "as On Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpAsonDate
        '
        Me.dtpAsonDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpAsonDate.EnterKey = True
        Me.dtpAsonDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpAsonDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAsonDate.Location = New System.Drawing.Point(95, 249)
        Me.dtpAsonDate.MaxDate = New Date(2116, 9, 18, 0, 0, 0, 0)
        Me.dtpAsonDate.MinDate = New Date(1916, 9, 18, 0, 0, 0, 0)
        Me.dtpAsonDate.Name = "dtpAsonDate"
        Me.dtpAsonDate.ShiftKey = True
        Me.dtpAsonDate.ShowCheckBox = True
        Me.dtpAsonDate.Size = New System.Drawing.Size(154, 23)
        Me.dtpAsonDate.TabIndex = 13
        '
        'rptMemberList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(759, 414)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "rptMemberList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Member Name List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents cmbStatus As sControls.ComboBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As sControls.ComboBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkOther As System.Windows.Forms.CheckBox
    Friend WithEvents chkWorker As System.Windows.Forms.CheckBox
    Friend WithEvents chkStaff As System.Windows.Forms.CheckBox
    Friend WithEvents dtpAsonDate As sControls.DateTimePickervb
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
