<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHead
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtHeadName = New sControls.TextBoxvb
        Me.cmbGroupName = New sControls.ComboBoxvb
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtHeadCode = New sControls.TextBoxvb
        Me.txtOpnBalance = New sControls.TextBoxvb
        Me.cmbRP = New sControls.ComboBoxvb
        Me.Label5 = New System.Windows.Forms.Label
        Me.Linevb1 = New sControls.Linevb(Me.components)
        Me.txtHeadOpeningCode = New sControls.TextBoxvb
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Linevb2 = New sControls.Linevb(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblDifference = New System.Windows.Forms.Label
        Me.lblPayment = New System.Windows.Forms.Label
        Me.lblReceipt = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbYesNo = New sControls.ComboBoxvb
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Head Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Group Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Opening Balance"
        '
        'txtHeadName
        '
        Me.txtHeadName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtHeadName.DecimalScale = 0
        Me.txtHeadName.DefaultTextBox = False
        Me.txtHeadName.EnterKey = True
        Me.txtHeadName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeadName.Location = New System.Drawing.Point(186, 60)
        Me.txtHeadName.MaxLength = 50
        Me.txtHeadName.Name = "txtHeadName"
        Me.txtHeadName.ShiftKey = True
        Me.txtHeadName.Size = New System.Drawing.Size(389, 26)
        Me.txtHeadName.TabIndex = 1
        Me.txtHeadName.TextFormat = sControls.TextBoxvb.FormatText.All
        '
        'cmbGroupName
        '
        Me.cmbGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGroupName.CharFormat = sControls.ComboBoxvb.FormatChar.All
        Me.cmbGroupName.DefaultText = "--------"
        Me.cmbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupName.EnterKey = True
        Me.cmbGroupName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupName.FormattingEnabled = True
        Me.cmbGroupName.Location = New System.Drawing.Point(186, 24)
        Me.cmbGroupName.Name = "cmbGroupName"
        Me.cmbGroupName.ShiftKey = True
        Me.cmbGroupName.Size = New System.Drawing.Size(389, 26)
        Me.cmbGroupName.TabIndex = 0
        Me.cmbGroupName.Validation = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(354, 198)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(429, 198)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(504, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtHeadCode
        '
        Me.txtHeadCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtHeadCode.DecimalScale = 0
        Me.txtHeadCode.DefaultTextBox = False
        Me.txtHeadCode.EnterKey = True
        Me.txtHeadCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtHeadCode.Location = New System.Drawing.Point(24, 202)
        Me.txtHeadCode.Name = "txtHeadCode"
        Me.txtHeadCode.ShiftKey = True
        Me.txtHeadCode.Size = New System.Drawing.Size(76, 23)
        Me.txtHeadCode.TabIndex = 10
        Me.txtHeadCode.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtHeadCode.Visible = False
        '
        'txtOpnBalance
        '
        Me.txtOpnBalance.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtOpnBalance.DecimalScale = 2
        Me.txtOpnBalance.DefaultTextBox = False
        Me.txtOpnBalance.EnterKey = True
        Me.txtOpnBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpnBalance.Location = New System.Drawing.Point(186, 95)
        Me.txtOpnBalance.MaxLength = 12
        Me.txtOpnBalance.Name = "txtOpnBalance"
        Me.txtOpnBalance.ShiftKey = True
        Me.txtOpnBalance.Size = New System.Drawing.Size(149, 26)
        Me.txtOpnBalance.TabIndex = 2
        Me.txtOpnBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOpnBalance.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'cmbRP
        '
        Me.cmbRP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbRP.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbRP.DefaultText = "----------"
        Me.cmbRP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRP.EnterKey = True
        Me.cmbRP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRP.FormattingEnabled = True
        Me.cmbRP.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.cmbRP.Location = New System.Drawing.Point(426, 97)
        Me.cmbRP.Name = "cmbRP"
        Me.cmbRP.ShiftKey = True
        Me.cmbRP.Size = New System.Drawing.Size(149, 26)
        Me.cmbRP.TabIndex = 3
        Me.cmbRP.Validation = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(350, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dt / Cr"
        '
        'Linevb1
        '
        Me.Linevb1.Enabled = False
        Me.Linevb1.FirstColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Linevb1.Location = New System.Drawing.Point(4, 182)
        Me.Linevb1.Name = "Linevb1"
        Me.Linevb1.SecondColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Linevb1.Size = New System.Drawing.Size(575, 2)
        Me.Linevb1.TabIndex = 40
        Me.Linevb1.Text = "Linevb1"
        '
        'txtHeadOpeningCode
        '
        Me.txtHeadOpeningCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtHeadOpeningCode.DecimalScale = 0
        Me.txtHeadOpeningCode.DefaultTextBox = False
        Me.txtHeadOpeningCode.EnterKey = True
        Me.txtHeadOpeningCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtHeadOpeningCode.Location = New System.Drawing.Point(141, 199)
        Me.txtHeadOpeningCode.Name = "txtHeadOpeningCode"
        Me.txtHeadOpeningCode.ShiftKey = True
        Me.txtHeadOpeningCode.Size = New System.Drawing.Size(76, 23)
        Me.txtHeadOpeningCode.TabIndex = 41
        Me.txtHeadOpeningCode.TextFormat = sControls.TextBoxvb.FormatText.All
        Me.txtHeadOpeningCode.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Linevb2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblDifference)
        Me.Panel1.Controls.Add(Me.lblPayment)
        Me.Panel1.Controls.Add(Me.lblReceipt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(601, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 211)
        Me.Panel1.TabIndex = 42
        '
        'Linevb2
        '
        Me.Linevb2.Enabled = False
        Me.Linevb2.FirstColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Linevb2.Location = New System.Drawing.Point(4, 122)
        Me.Linevb2.Name = "Linevb2"
        Me.Linevb2.SecondColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Linevb2.Size = New System.Drawing.Size(410, 2)
        Me.Linevb2.TabIndex = 41
        Me.Linevb2.Text = "Linevb2"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Blue
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(417, 33)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "OPEINGIN TRIAL BALANCE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDifference
        '
        Me.lblDifference.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifference.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDifference.Location = New System.Drawing.Point(87, 156)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(243, 34)
        Me.lblDifference.TabIndex = 23
        Me.lblDifference.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPayment
        '
        Me.lblPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPayment.Location = New System.Drawing.Point(259, 69)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(143, 34)
        Me.lblPayment.TabIndex = 22
        Me.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReceipt
        '
        Me.lblReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReceipt.Location = New System.Drawing.Point(21, 69)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(143, 34)
        Me.lblReceipt.TabIndex = 21
        Me.lblReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(162, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Difference"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(291, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(57, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Receipt"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(12, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 19)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Need Vouchering?..."
        '
        'cmbYesNo
        '
        Me.cmbYesNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbYesNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYesNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbYesNo.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbYesNo.DefaultText = "----------"
        Me.cmbYesNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYesNo.EnterKey = True
        Me.cmbYesNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYesNo.ForeColor = System.Drawing.Color.Red
        Me.cmbYesNo.FormattingEnabled = True
        Me.cmbYesNo.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbYesNo.Location = New System.Drawing.Point(186, 138)
        Me.cmbYesNo.Name = "cmbYesNo"
        Me.cmbYesNo.ShiftKey = True
        Me.cmbYesNo.Size = New System.Drawing.Size(149, 27)
        Me.cmbYesNo.TabIndex = 4
        Me.cmbYesNo.Validation = True
        '
        'frmHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1033, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbYesNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtHeadOpeningCode)
        Me.Controls.Add(Me.Linevb1)
        Me.Controls.Add(Me.txtOpnBalance)
        Me.Controls.Add(Me.txtHeadCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbRP)
        Me.Controls.Add(Me.cmbGroupName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtHeadName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmHead"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Head Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHeadName As sControls.TextBoxvb
    Friend WithEvents cmbGroupName As sControls.ComboBoxvb
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtHeadCode As sControls.TextBoxvb
    Friend WithEvents txtOpnBalance As sControls.TextBoxvb
    Friend WithEvents cmbRP As sControls.ComboBoxvb
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Linevb1 As sControls.Linevb
    Friend WithEvents txtHeadOpeningCode As sControls.TextBoxvb
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDifference As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblReceipt As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbYesNo As sControls.ComboBoxvb
    Friend WithEvents Linevb2 As sControls.Linevb
End Class
