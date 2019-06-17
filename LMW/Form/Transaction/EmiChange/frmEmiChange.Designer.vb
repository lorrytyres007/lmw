<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmiChange
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCurrentEMI = New sControls.TextBoxvb
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtChangeEMI = New sControls.TextBoxvb
        Me.cmbLoanNo = New sControls.ComboBoxvb
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLoanAmount = New sControls.TextBoxvb
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtROI = New sControls.TextBoxvb
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtLoanPeriod = New sControls.TextBoxvb
        Me.chkLPeriod = New System.Windows.Forms.CheckBox
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.cmbMember = New sControls.ComboBoxvb
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.txtEmiChangeCode = New sControls.TextBoxvb
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Token No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Loan No"
        '
        'txtCurrentEMI
        '
        Me.txtCurrentEMI.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCurrentEMI.DecimalScale = 2
        Me.txtCurrentEMI.DefaultTextBox = False
        Me.txtCurrentEMI.Enabled = False
        Me.txtCurrentEMI.EnterKey = True
        Me.txtCurrentEMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentEMI.Location = New System.Drawing.Point(165, 168)
        Me.txtCurrentEMI.MaxLength = 10
        Me.txtCurrentEMI.Name = "txtCurrentEMI"
        Me.txtCurrentEMI.ReadOnly = True
        Me.txtCurrentEMI.ShiftKey = True
        Me.txtCurrentEMI.Size = New System.Drawing.Size(107, 26)
        Me.txtCurrentEMI.TabIndex = 5
        Me.txtCurrentEMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrentEMI.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Current EMI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Change EMI"
        '
        'txtChangeEMI
        '
        Me.txtChangeEMI.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtChangeEMI.DecimalScale = 2
        Me.txtChangeEMI.DefaultTextBox = False
        Me.txtChangeEMI.EnterKey = True
        Me.txtChangeEMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeEMI.Location = New System.Drawing.Point(165, 199)
        Me.txtChangeEMI.MaxLength = 10
        Me.txtChangeEMI.Name = "txtChangeEMI"
        Me.txtChangeEMI.ShiftKey = True
        Me.txtChangeEMI.Size = New System.Drawing.Size(107, 26)
        Me.txtChangeEMI.TabIndex = 6
        Me.txtChangeEMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChangeEMI.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'cmbLoanNo
        '
        Me.cmbLoanNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLoanNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLoanNo.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbLoanNo.DefaultText = "--SELECT--"
        Me.cmbLoanNo.EnterKey = True
        Me.cmbLoanNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoanNo.FormattingEnabled = True
        Me.cmbLoanNo.Location = New System.Drawing.Point(165, 46)
        Me.cmbLoanNo.Name = "cmbLoanNo"
        Me.cmbLoanNo.ShiftKey = True
        Me.cmbLoanNo.Size = New System.Drawing.Size(107, 24)
        Me.cmbLoanNo.TabIndex = 1
        Me.cmbLoanNo.Validation = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(205, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 26)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(116, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 26)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(27, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 26)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Loan Amout"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanAmount.DecimalScale = 2
        Me.txtLoanAmount.DefaultTextBox = False
        Me.txtLoanAmount.Enabled = False
        Me.txtLoanAmount.EnterKey = True
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(165, 75)
        Me.txtLoanAmount.MaxLength = 10
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.ReadOnly = True
        Me.txtLoanAmount.ShiftKey = True
        Me.txtLoanAmount.Size = New System.Drawing.Size(107, 26)
        Me.txtLoanAmount.TabIndex = 2
        Me.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanAmount.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "ROI"
        '
        'txtROI
        '
        Me.txtROI.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtROI.DecimalScale = 2
        Me.txtROI.DefaultTextBox = False
        Me.txtROI.Enabled = False
        Me.txtROI.EnterKey = True
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROI.Location = New System.Drawing.Point(165, 106)
        Me.txtROI.MaxLength = 10
        Me.txtROI.Name = "txtROI"
        Me.txtROI.ReadOnly = True
        Me.txtROI.ShiftKey = True
        Me.txtROI.Size = New System.Drawing.Size(107, 26)
        Me.txtROI.TabIndex = 3
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtROI.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Loan Period"
        '
        'txtLoanPeriod
        '
        Me.txtLoanPeriod.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanPeriod.DecimalScale = 0
        Me.txtLoanPeriod.DefaultTextBox = False
        Me.txtLoanPeriod.Enabled = False
        Me.txtLoanPeriod.EnterKey = True
        Me.txtLoanPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanPeriod.Location = New System.Drawing.Point(165, 137)
        Me.txtLoanPeriod.MaxLength = 10
        Me.txtLoanPeriod.Name = "txtLoanPeriod"
        Me.txtLoanPeriod.ShiftKey = True
        Me.txtLoanPeriod.Size = New System.Drawing.Size(107, 26)
        Me.txtLoanPeriod.TabIndex = 4
        Me.txtLoanPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanPeriod.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'chkLPeriod
        '
        Me.chkLPeriod.AutoSize = True
        Me.chkLPeriod.Location = New System.Drawing.Point(275, 143)
        Me.chkLPeriod.Name = "chkLPeriod"
        Me.chkLPeriod.Size = New System.Drawing.Size(15, 14)
        Me.chkLPeriod.TabIndex = 26
        Me.chkLPeriod.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.cmbMember)
        Me.pnlTop.Controls.Add(Me.chkLPeriod)
        Me.pnlTop.Controls.Add(Me.Label7)
        Me.pnlTop.Controls.Add(Me.txtLoanPeriod)
        Me.pnlTop.Controls.Add(Me.Label6)
        Me.pnlTop.Controls.Add(Me.txtROI)
        Me.pnlTop.Controls.Add(Me.Label5)
        Me.pnlTop.Controls.Add(Me.txtLoanAmount)
        Me.pnlTop.Controls.Add(Me.cmbLoanNo)
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Controls.Add(Me.txtChangeEMI)
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.txtCurrentEMI)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(314, 240)
        Me.pnlTop.TabIndex = 0
        '
        'cmbMember
        '
        Me.cmbMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMember.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbMember.DefaultText = "--SELECT--"
        Me.cmbMember.EnterKey = True
        Me.cmbMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMember.FormattingEnabled = True
        Me.cmbMember.Location = New System.Drawing.Point(165, 18)
        Me.cmbMember.Name = "cmbMember"
        Me.cmbMember.ShiftKey = True
        Me.cmbMember.Size = New System.Drawing.Size(107, 24)
        Me.cmbMember.TabIndex = 27
        Me.cmbMember.Validation = True
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.txtEmiChangeCode)
        Me.pnlBottom.Controls.Add(Me.btnExit)
        Me.pnlBottom.Controls.Add(Me.btnClear)
        Me.pnlBottom.Controls.Add(Me.btnSave)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 240)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(314, 53)
        Me.pnlBottom.TabIndex = 1
        '
        'txtEmiChangeCode
        '
        Me.txtEmiChangeCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtEmiChangeCode.DecimalScale = 2
        Me.txtEmiChangeCode.DefaultTextBox = False
        Me.txtEmiChangeCode.Enabled = False
        Me.txtEmiChangeCode.EnterKey = True
        Me.txtEmiChangeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmiChangeCode.Location = New System.Drawing.Point(294, 12)
        Me.txtEmiChangeCode.MaxLength = 10
        Me.txtEmiChangeCode.Name = "txtEmiChangeCode"
        Me.txtEmiChangeCode.ReadOnly = True
        Me.txtEmiChangeCode.ShiftKey = True
        Me.txtEmiChangeCode.Size = New System.Drawing.Size(36, 26)
        Me.txtEmiChangeCode.TabIndex = 28
        Me.txtEmiChangeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmiChangeCode.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        Me.txtEmiChangeCode.Visible = False
        '
        'frmEmiChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Name = "frmEmiChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmiChange"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentEMI As sControls.TextBoxvb
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtChangeEMI As sControls.TextBoxvb
    Friend WithEvents cmbLoanNo As sControls.ComboBoxvb
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLoanAmount As sControls.TextBoxvb
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtROI As sControls.TextBoxvb
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLoanPeriod As sControls.TextBoxvb
    Friend WithEvents chkLPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents cmbMember As sControls.ComboBoxvb
    Friend WithEvents txtEmiChangeCode As sControls.TextBoxvb
End Class
