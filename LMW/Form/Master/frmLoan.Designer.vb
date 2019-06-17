<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoan
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLoanCode = New sControls.TextBoxvb
        Me.cmbStatus = New sControls.ComboBoxvb
        Me.txtLoanName = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkDemand = New System.Windows.Forms.CheckBox
        Me.optFixed = New System.Windows.Forms.RadioButton
        Me.pnlDemandType = New System.Windows.Forms.Panel
        Me.optNone = New System.Windows.Forms.RadioButton
        Me.optLoanDemand = New System.Windows.Forms.RadioButton
        Me.optJLDemand = New System.Windows.Forms.RadioButton
        Me.pnlDemandType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(302, 132)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(226, 132)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(150, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(18, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 8)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'txtLoanCode
        '
        Me.txtLoanCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanCode.DecimalScale = 1
        Me.txtLoanCode.DefaultTextBox = False
        Me.txtLoanCode.EnterKey = True
        Me.txtLoanCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanCode.Location = New System.Drawing.Point(47, 132)
        Me.txtLoanCode.MaxLength = 5
        Me.txtLoanCode.Name = "txtLoanCode"
        Me.txtLoanCode.ShiftKey = True
        Me.txtLoanCode.Size = New System.Drawing.Size(56, 23)
        Me.txtLoanCode.TabIndex = 5
        Me.txtLoanCode.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        Me.txtLoanCode.Visible = False
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStatus.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbStatus.DefaultText = "--SELECT--"
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.EnterKey = True
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"ACTIVE", "INACTIVE"})
        Me.cmbStatus.Location = New System.Drawing.Point(104, 41)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShiftKey = True
        Me.cmbStatus.Size = New System.Drawing.Size(109, 24)
        Me.cmbStatus.TabIndex = 1
        Me.cmbStatus.Validation = True
        '
        'txtLoanName
        '
        Me.txtLoanName.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtLoanName.DecimalScale = 0
        Me.txtLoanName.DefaultTextBox = False
        Me.txtLoanName.EnterKey = True
        Me.txtLoanName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanName.Location = New System.Drawing.Point(104, 13)
        Me.txtLoanName.MaxLength = 50
        Me.txtLoanName.Name = "txtLoanName"
        Me.txtLoanName.ShiftKey = True
        Me.txtLoanName.Size = New System.Drawing.Size(273, 25)
        Me.txtLoanName.TabIndex = 0
        Me.txtLoanName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Loan Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Status"
        '
        'chkDemand
        '
        Me.chkDemand.AutoSize = True
        Me.chkDemand.Location = New System.Drawing.Point(256, 46)
        Me.chkDemand.Name = "chkDemand"
        Me.chkDemand.Size = New System.Drawing.Size(121, 17)
        Me.chkDemand.TabIndex = 2
        Me.chkDemand.Text = "Demand Calculation"
        Me.chkDemand.UseVisualStyleBackColor = True
        '
        'optFixed
        '
        Me.optFixed.AutoSize = True
        Me.optFixed.Location = New System.Drawing.Point(81, 5)
        Me.optFixed.Name = "optFixed"
        Me.optFixed.Size = New System.Drawing.Size(93, 17)
        Me.optFixed.TabIndex = 1
        Me.optFixed.Text = "Fixed Demand"
        Me.optFixed.UseVisualStyleBackColor = True
        '
        'pnlDemandType
        '
        Me.pnlDemandType.Controls.Add(Me.optNone)
        Me.pnlDemandType.Controls.Add(Me.optLoanDemand)
        Me.pnlDemandType.Controls.Add(Me.optJLDemand)
        Me.pnlDemandType.Controls.Add(Me.optFixed)
        Me.pnlDemandType.Location = New System.Drawing.Point(1, 82)
        Me.pnlDemandType.Name = "pnlDemandType"
        Me.pnlDemandType.Size = New System.Drawing.Size(387, 26)
        Me.pnlDemandType.TabIndex = 3
        Me.pnlDemandType.Visible = False
        '
        'optNone
        '
        Me.optNone.AutoSize = True
        Me.optNone.Checked = True
        Me.optNone.Location = New System.Drawing.Point(15, 5)
        Me.optNone.Name = "optNone"
        Me.optNone.Size = New System.Drawing.Size(51, 17)
        Me.optNone.TabIndex = 0
        Me.optNone.TabStop = True
        Me.optNone.Text = "None"
        Me.optNone.UseVisualStyleBackColor = True
        '
        'optLoanDemand
        '
        Me.optLoanDemand.AutoSize = True
        Me.optLoanDemand.Location = New System.Drawing.Point(283, 5)
        Me.optLoanDemand.Name = "optLoanDemand"
        Me.optLoanDemand.Size = New System.Drawing.Size(92, 17)
        Me.optLoanDemand.TabIndex = 3
        Me.optLoanDemand.Text = "Loan Demand"
        Me.optLoanDemand.UseVisualStyleBackColor = True
        '
        'optJLDemand
        '
        Me.optJLDemand.AutoSize = True
        Me.optJLDemand.Location = New System.Drawing.Point(189, 5)
        Me.optJLDemand.Name = "optJLDemand"
        Me.optJLDemand.Size = New System.Drawing.Size(79, 17)
        Me.optJLDemand.TabIndex = 2
        Me.optJLDemand.Text = "JL Demand"
        Me.optJLDemand.UseVisualStyleBackColor = True
        '
        'frmLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(390, 172)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlDemandType)
        Me.Controls.Add(Me.chkDemand)
        Me.Controls.Add(Me.txtLoanCode)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtLoanName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLoan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Details"
        Me.pnlDemandType.ResumeLayout(False)
        Me.pnlDemandType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLoanCode As sControls.TextBoxvb
    Friend WithEvents cmbStatus As sControls.ComboBoxvb
    Friend WithEvents txtLoanName As sControls.TextBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents chkDemand As System.Windows.Forms.CheckBox
    Friend WithEvents optFixed As System.Windows.Forms.RadioButton
    Friend WithEvents pnlDemandType As System.Windows.Forms.Panel
    Friend WithEvents optLoanDemand As System.Windows.Forms.RadioButton
    Friend WithEvents optJLDemand As System.Windows.Forms.RadioButton
    Friend WithEvents optNone As System.Windows.Forms.RadioButton
End Class
