<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroup
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
        Me.txtGroupName = New sControls.TextBoxvb
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtGroupCode = New sControls.TextBoxvb
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbStatus = New sControls.ComboBoxvb
        Me.cmbonBalanceSheet = New sControls.ComboBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbOnProfitLoss = New sControls.ComboBoxvb
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbOnTrading = New sControls.ComboBoxvb
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbYesNo = New sControls.ComboBoxvb
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbAccountType = New sControls.ComboBoxvb
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Group Name"
        '
        'txtGroupName
        '
        Me.txtGroupName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtGroupName.DecimalScale = 0
        Me.txtGroupName.DefaultTextBox = False
        Me.txtGroupName.EnterKey = True
        Me.txtGroupName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupName.Location = New System.Drawing.Point(135, 20)
        Me.txtGroupName.MaxLength = 50
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.ShiftKey = True
        Me.txtGroupName.Size = New System.Drawing.Size(319, 26)
        Me.txtGroupName.TabIndex = 0
        Me.txtGroupName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(229, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(304, 293)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(379, 293)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtGroupCode
        '
        Me.txtGroupCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtGroupCode.DecimalScale = 0
        Me.txtGroupCode.DefaultTextBox = False
        Me.txtGroupCode.EnterKey = True
        Me.txtGroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtGroupCode.Location = New System.Drawing.Point(12, 287)
        Me.txtGroupCode.Name = "txtGroupCode"
        Me.txtGroupCode.ShiftKey = True
        Me.txtGroupCode.Size = New System.Drawing.Size(76, 23)
        Me.txtGroupCode.TabIndex = 14
        Me.txtGroupCode.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtGroupCode.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 7)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Status"
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
        Me.cmbStatus.Location = New System.Drawing.Point(325, 235)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShiftKey = True
        Me.cmbStatus.Size = New System.Drawing.Size(129, 24)
        Me.cmbStatus.TabIndex = 6
        Me.cmbStatus.Validation = True
        '
        'cmbonBalanceSheet
        '
        Me.cmbonBalanceSheet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbonBalanceSheet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbonBalanceSheet.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbonBalanceSheet.DefaultText = "--SELECT--"
        Me.cmbonBalanceSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbonBalanceSheet.EnterKey = True
        Me.cmbonBalanceSheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbonBalanceSheet.FormattingEnabled = True
        Me.cmbonBalanceSheet.Items.AddRange(New Object() {"ASSET", "LIABILITY"})
        Me.cmbonBalanceSheet.Location = New System.Drawing.Point(325, 91)
        Me.cmbonBalanceSheet.Name = "cmbonBalanceSheet"
        Me.cmbonBalanceSheet.ShiftKey = True
        Me.cmbonBalanceSheet.Size = New System.Drawing.Size(129, 24)
        Me.cmbonBalanceSheet.TabIndex = 2
        Me.cmbonBalanceSheet.Validation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "On Bal. Sheet"
        '
        'cmbOnProfitLoss
        '
        Me.cmbOnProfitLoss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOnProfitLoss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOnProfitLoss.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbOnProfitLoss.DefaultText = "--SELECT--"
        Me.cmbOnProfitLoss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOnProfitLoss.EnterKey = True
        Me.cmbOnProfitLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbOnProfitLoss.FormattingEnabled = True
        Me.cmbOnProfitLoss.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbOnProfitLoss.Location = New System.Drawing.Point(325, 127)
        Me.cmbOnProfitLoss.Name = "cmbOnProfitLoss"
        Me.cmbOnProfitLoss.ShiftKey = True
        Me.cmbOnProfitLoss.Size = New System.Drawing.Size(129, 24)
        Me.cmbOnProfitLoss.TabIndex = 3
        Me.cmbOnProfitLoss.Validation = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Affect Profit && Loss"
        '
        'cmbOnTrading
        '
        Me.cmbOnTrading.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOnTrading.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOnTrading.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbOnTrading.DefaultText = "--SELECT--"
        Me.cmbOnTrading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOnTrading.EnterKey = True
        Me.cmbOnTrading.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbOnTrading.FormattingEnabled = True
        Me.cmbOnTrading.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbOnTrading.Location = New System.Drawing.Point(325, 163)
        Me.cmbOnTrading.Name = "cmbOnTrading"
        Me.cmbOnTrading.ShiftKey = True
        Me.cmbOnTrading.Size = New System.Drawing.Size(129, 24)
        Me.cmbOnTrading.TabIndex = 4
        Me.cmbOnTrading.Validation = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "On Trading"
        '
        'cmbYesNo
        '
        Me.cmbYesNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbYesNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYesNo.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbYesNo.DefaultText = "--SELECT--"
        Me.cmbYesNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYesNo.EnterKey = True
        Me.cmbYesNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbYesNo.FormattingEnabled = True
        Me.cmbYesNo.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbYesNo.Location = New System.Drawing.Point(325, 199)
        Me.cmbYesNo.Name = "cmbYesNo"
        Me.cmbYesNo.ShiftKey = True
        Me.cmbYesNo.Size = New System.Drawing.Size(129, 24)
        Me.cmbYesNo.TabIndex = 5
        Me.cmbYesNo.Validation = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(274, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "On Report Need cumulative Total"
        '
        'cmbAccountType
        '
        Me.cmbAccountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAccountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAccountType.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbAccountType.DefaultText = "--SELECT--"
        Me.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccountType.EnterKey = True
        Me.cmbAccountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbAccountType.FormattingEnabled = True
        Me.cmbAccountType.Items.AddRange(New Object() {"ASSET", "LIABILITY"})
        Me.cmbAccountType.Location = New System.Drawing.Point(325, 55)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.ShiftKey = True
        Me.cmbAccountType.Size = New System.Drawing.Size(129, 24)
        Me.cmbAccountType.TabIndex = 1
        Me.cmbAccountType.Validation = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Account Type"
        '
        'frmGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(475, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbAccountType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbYesNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbOnTrading)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbOnProfitLoss)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbonBalanceSheet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtGroupCode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGroup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGroupName As sControls.TextBoxvb
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtGroupCode As sControls.TextBoxvb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As sControls.ComboBoxvb
    Friend WithEvents cmbonBalanceSheet As sControls.ComboBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOnProfitLoss As sControls.ComboBoxvb
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbOnTrading As sControls.ComboBoxvb
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbYesNo As sControls.ComboBoxvb
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbAccountType As sControls.ComboBoxvb
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
