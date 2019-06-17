<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptShareCollection
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
        Me.rptViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbEmpNo = New sControls.ComboBoxvb
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbMonthTO = New sControls.ComboBoxvb
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbYear = New sControls.ComboBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbMonthFrom = New sControls.ComboBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTo = New sControls.DateTimePickervb
        Me.dtpFrom = New sControls.DateTimePickervb
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rptViewer
        '
        Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "sTapesDataSet_sp_Customer_GetAll"
        ReportDataSource1.Value = Nothing
        Me.rptViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptViewer.LocalReport.ReportEmbeddedResource = "sTapes.rptCustomer.rdlc"
        Me.rptViewer.Location = New System.Drawing.Point(266, 28)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.Size = New System.Drawing.Size(569, 472)
        Me.rptViewer.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(140, 315)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 24)
        Me.btnClose.TabIndex = 7
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
        Me.btnView.Location = New System.Drawing.Point(62, 315)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 24)
        Me.btnView.TabIndex = 6
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(62, 315)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(153, 24)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbEmpNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbMonthTO)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbMonthFrom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.dtpTo)
        Me.Panel1.Controls.Add(Me.btnView)
        Me.Panel1.Controls.Add(Me.dtpFrom)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 472)
        Me.Panel1.TabIndex = 0
        '
        'cmbEmpNo
        '
        Me.cmbEmpNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpNo.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbEmpNo.DefaultText = "-- SELECT --"
        Me.cmbEmpNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpNo.EnterKey = True
        Me.cmbEmpNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpNo.FormattingEnabled = True
        Me.cmbEmpNo.Location = New System.Drawing.Point(104, 237)
        Me.cmbEmpNo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEmpNo.Name = "cmbEmpNo"
        Me.cmbEmpNo.ShiftKey = True
        Me.cmbEmpNo.Size = New System.Drawing.Size(102, 26)
        Me.cmbEmpNo.TabIndex = 5
        Me.cmbEmpNo.Validation = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Emp.No"
        '
        'cmbMonthTO
        '
        Me.cmbMonthTO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMonthTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMonthTO.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbMonthTO.DefaultText = "--SELECT--"
        Me.cmbMonthTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonthTO.EnterKey = True
        Me.cmbMonthTO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonthTO.FormattingEnabled = True
        Me.cmbMonthTO.Items.AddRange(New Object() {"--SELECT--", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER", "JANUARY", "FEBRUARY", "MARCH"})
        Me.cmbMonthTO.Location = New System.Drawing.Point(104, 133)
        Me.cmbMonthTO.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMonthTO.Name = "cmbMonthTO"
        Me.cmbMonthTO.ShiftKey = True
        Me.cmbMonthTO.Size = New System.Drawing.Size(152, 26)
        Me.cmbMonthTO.TabIndex = 3
        Me.cmbMonthTO.Validation = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Month To"
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
        Me.cmbYear.Location = New System.Drawing.Point(104, 203)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.ShiftKey = True
        Me.cmbYear.Size = New System.Drawing.Size(152, 26)
        Me.cmbYear.TabIndex = 4
        Me.cmbYear.Validation = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 206)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "YEAR"
        '
        'cmbMonthFrom
        '
        Me.cmbMonthFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMonthFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMonthFrom.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbMonthFrom.DefaultText = "--SELECT--"
        Me.cmbMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonthFrom.EnterKey = True
        Me.cmbMonthFrom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonthFrom.FormattingEnabled = True
        Me.cmbMonthFrom.Items.AddRange(New Object() {"--SELECT--", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER", "JANUARY", "FEBRUARY", "MARCH"})
        Me.cmbMonthFrom.Location = New System.Drawing.Point(104, 101)
        Me.cmbMonthFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMonthFrom.Name = "cmbMonthFrom"
        Me.cmbMonthFrom.ShiftKey = True
        Me.cmbMonthFrom.Size = New System.Drawing.Size(152, 26)
        Me.cmbMonthFrom.TabIndex = 2
        Me.cmbMonthFrom.Validation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Month From"
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd/MMM/yyyy"
        Me.dtpTo.Enabled = False
        Me.dtpTo.EnterKey = True
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(104, 47)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTo.MaxDate = New Date(2110, 5, 11, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1910, 5, 11, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShiftKey = True
        Me.dtpTo.Size = New System.Drawing.Size(129, 23)
        Me.dtpTo.TabIndex = 1
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFrom.Enabled = False
        Me.dtpFrom.EnterKey = True
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(104, 16)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFrom.MaxDate = New Date(2110, 5, 11, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1910, 5, 11, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShiftKey = True
        Me.dtpFrom.Size = New System.Drawing.Size(129, 23)
        Me.dtpFrom.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.LMW.My.Resources.Resources.Caption
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Controls.Add(Me.lblTitle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(835, 28)
        Me.Panel3.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(5, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(200, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Share Collection Details"
        '
        'rptShareCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(835, 500)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rptShareCollection"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Stock Add"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_Customer_GetAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As sControls.DateTimePickervb
    Friend WithEvents dtpFrom As sControls.DateTimePickervb
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbMonthFrom As sControls.ComboBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbYear As sControls.ComboBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMonthTO As sControls.ComboBoxvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEmpNo As sControls.ComboBoxvb
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
