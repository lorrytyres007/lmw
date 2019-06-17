<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.gbPassword = New System.Windows.Forms.GroupBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtConfirmPassword = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmbUserLevel = New sControls.ComboBoxvb
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbStatus = New sControls.ComboBoxvb
        Me.txtUserCode = New sControls.TextBoxvb
        Me.Status = New System.Windows.Forms.Label
        Me.txtUserName = New sControls.TextBoxvb
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRetypePassword = New sControls.TextBoxvb
        Me.txtPassword = New sControls.TextBoxvb
        Me.gbPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPassword
        '
        Me.gbPassword.Controls.Add(Me.btnOK)
        Me.gbPassword.Controls.Add(Me.txtConfirmPassword)
        Me.gbPassword.Controls.Add(Me.Label1)
        Me.gbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPassword.Location = New System.Drawing.Point(8, 3)
        Me.gbPassword.Name = "gbPassword"
        Me.gbPassword.Size = New System.Drawing.Size(395, 194)
        Me.gbPassword.TabIndex = 0
        Me.gbPassword.TabStop = False
        Me.gbPassword.Text = "Password Required"
        Me.gbPassword.Visible = False
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(297, 123)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(73, 25)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtConfirmPassword.DecimalScale = 0
        Me.txtConfirmPassword.DefaultTextBox = False
        Me.txtConfirmPassword.EnterKey = False
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(116, 81)
        Me.txtConfirmPassword.MaxLength = 10
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.ShiftKey = False
        Me.txtConfirmPassword.Size = New System.Drawing.Size(254, 23)
        Me.txtConfirmPassword.TabIndex = 0
        Me.txtConfirmPassword.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Password"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(317, 170)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 27)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmbUserLevel
        '
        Me.cmbUserLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUserLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUserLevel.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbUserLevel.DefaultText = "--SELECT--"
        Me.cmbUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserLevel.EnterKey = True
        Me.cmbUserLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbUserLevel.FormattingEnabled = True
        Me.cmbUserLevel.Items.AddRange(New Object() {"--SELECT--", "ADMINISTRATOR", "LIMITED"})
        Me.cmbUserLevel.Location = New System.Drawing.Point(133, 97)
        Me.cmbUserLevel.Name = "cmbUserLevel"
        Me.cmbUserLevel.ShiftKey = True
        Me.cmbUserLevel.Size = New System.Drawing.Size(156, 24)
        Me.cmbUserLevel.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "User Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "User Level"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(236, 170)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 27)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Password"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(155, 170)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 27)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Retype Password"
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
        Me.cmbStatus.Location = New System.Drawing.Point(133, 126)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ShiftKey = True
        Me.cmbStatus.Size = New System.Drawing.Size(156, 24)
        Me.cmbStatus.TabIndex = 19
        '
        'txtUserCode
        '
        Me.txtUserCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtUserCode.DecimalScale = 0
        Me.txtUserCode.DefaultTextBox = False
        Me.txtUserCode.EnterKey = True
        Me.txtUserCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtUserCode.Location = New System.Drawing.Point(277, 130)
        Me.txtUserCode.Name = "txtUserCode"
        Me.txtUserCode.ShiftKey = True
        Me.txtUserCode.Size = New System.Drawing.Size(57, 23)
        Me.txtUserCode.TabIndex = 23
        Me.txtUserCode.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtUserCode.Visible = False
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(12, 130)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(45, 16)
        Me.Status.TabIndex = 29
        Me.Status.Text = "Status"
        '
        'txtUserName
        '
        Me.txtUserName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtUserName.DecimalScale = 0
        Me.txtUserName.DefaultTextBox = False
        Me.txtUserName.EnterKey = True
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtUserName.Location = New System.Drawing.Point(133, 13)
        Me.txtUserName.MaxLength = 50
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ShiftKey = True
        Me.txtUserName.Size = New System.Drawing.Size(264, 23)
        Me.txtUserName.TabIndex = 15
        Me.txtUserName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(14, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 8)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'txtRetypePassword
        '
        Me.txtRetypePassword.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtRetypePassword.DecimalScale = 0
        Me.txtRetypePassword.DefaultTextBox = False
        Me.txtRetypePassword.EnterKey = True
        Me.txtRetypePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRetypePassword.Location = New System.Drawing.Point(133, 69)
        Me.txtRetypePassword.MaxLength = 10
        Me.txtRetypePassword.Name = "txtRetypePassword"
        Me.txtRetypePassword.ShiftKey = True
        Me.txtRetypePassword.Size = New System.Drawing.Size(156, 23)
        Me.txtRetypePassword.TabIndex = 17
        Me.txtRetypePassword.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtRetypePassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtPassword.DecimalScale = 0
        Me.txtPassword.DefaultTextBox = False
        Me.txtPassword.EnterKey = True
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(133, 41)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ShiftKey = True
        Me.txtPassword.Size = New System.Drawing.Size(156, 23)
        Me.txtPassword.TabIndex = 16
        Me.txtPassword.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(412, 204)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbPassword)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbUserLevel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtRetypePassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtUserCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmUser"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Details"
        Me.gbPassword.ResumeLayout(False)
        Me.gbPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbPassword As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmPassword As sControls.TextBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmbUserLevel As sControls.ComboBoxvb
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As sControls.ComboBoxvb
    Friend WithEvents txtUserCode As sControls.TextBoxvb
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents txtUserName As sControls.TextBoxvb
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRetypePassword As sControls.TextBoxvb
    Friend WithEvents txtPassword As sControls.TextBoxvb
End Class
