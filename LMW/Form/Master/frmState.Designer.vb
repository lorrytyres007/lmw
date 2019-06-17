<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmState
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
        Me.txtStateCode = New sControls.TextBoxvb
        Me.cmbStatus = New sControls.ComboBoxvb
        Me.txtStateName = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(302, 89)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(226, 89)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(150, 89)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(18, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 8)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'txtStateCode
        '
        Me.txtStateCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtStateCode.DecimalScale = 1
        Me.txtStateCode.DefaultTextBox = False
        Me.txtStateCode.EnterKey = True
        Me.txtStateCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtStateCode.Location = New System.Drawing.Point(254, 46)
        Me.txtStateCode.MaxLength = 5
        Me.txtStateCode.Name = "txtStateCode"
        Me.txtStateCode.ShiftKey = True
        Me.txtStateCode.Size = New System.Drawing.Size(56, 23)
        Me.txtStateCode.TabIndex = 5
        Me.txtStateCode.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        Me.txtStateCode.Visible = False
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
        '
        'txtStateName
        '
        Me.txtStateName.CharFormat = sControls.TextBoxvb.FormatChar.All
        Me.txtStateName.DecimalScale = 0
        Me.txtStateName.DefaultTextBox = False
        Me.txtStateName.EnterKey = True
        Me.txtStateName.Font = New System.Drawing.Font("Bamini", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateName.Location = New System.Drawing.Point(104, 13)
        Me.txtStateName.MaxLength = 50
        Me.txtStateName.Name = "txtStateName"
        Me.txtStateName.ShiftKey = True
        Me.txtStateName.Size = New System.Drawing.Size(273, 22)
        Me.txtStateName.TabIndex = 0
        Me.txtStateName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "State Name"
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
        'frmState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(390, 120)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtStateCode)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtStateName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmState"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "State Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStateCode As sControls.TextBoxvb
    Friend WithEvents cmbStatus As sControls.ComboBoxvb
    Friend WithEvents txtStateName As sControls.TextBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
