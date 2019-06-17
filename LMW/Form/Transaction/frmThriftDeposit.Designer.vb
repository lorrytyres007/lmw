<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThriftDeposit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtEmpNo = New sControls.TextBoxvb
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid = New sControls.ViewGrid
        Me.Delete = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ThriftDepositCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MemberName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MemberCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAmount = New sControls.TextBoxvb
        Me.dtpDepositDate = New sControls.DateTimeMaskvb(Me.components)
        Me.Linevb1 = New sControls.Linevb(Me.components)
        Me.lblGrandTotal = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnMember = New sControls.Buttonvb(Me.components)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmpNo
        '
        Me.txtEmpNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtEmpNo.DecimalScale = 0
        Me.txtEmpNo.DefaultTextBox = False
        Me.txtEmpNo.EnterKey = True
        Me.txtEmpNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpNo.Location = New System.Drawing.Point(292, 59)
        Me.txtEmpNo.MaxLength = 10
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.ShiftKey = True
        Me.txtEmpNo.Size = New System.Drawing.Size(107, 26)
        Me.txtEmpNo.TabIndex = 2
        Me.txtEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmpNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Token No"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.Auto_SNo = False
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.ColumnHeadersHeight = 30
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete, Me.ThriftDepositCode, Me.EmpNo, Me.MemberName, Me.MemberCode, Me.Amount})
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.Grouping = False
        Me.Grid.Location = New System.Drawing.Point(12, 98)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Grid.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.RowTemplate.Height = 25
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.ShowCellErrors = False
        Me.Grid.ShowRowErrors = False
        Me.Grid.Size = New System.Drawing.Size(557, 372)
        Me.Grid.TabIndex = 2
        '
        'Delete
        '
        Me.Delete.HeaderText = "Del"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Width = 45
        '
        'ThriftDepositCode
        '
        Me.ThriftDepositCode.HeaderText = "ThriftDepositCode"
        Me.ThriftDepositCode.Name = "ThriftDepositCode"
        Me.ThriftDepositCode.ReadOnly = True
        Me.ThriftDepositCode.Visible = False
        '
        'EmpNo
        '
        Me.EmpNo.HeaderText = "Tok. No"
        Me.EmpNo.Name = "EmpNo"
        Me.EmpNo.ReadOnly = True
        '
        'MemberName
        '
        Me.MemberName.HeaderText = "Member Name"
        Me.MemberName.Name = "MemberName"
        Me.MemberName.ReadOnly = True
        Me.MemberName.Width = 250
        '
        'MemberCode
        '
        Me.MemberCode.HeaderText = "MemberCode"
        Me.MemberCode.Name = "MemberCode"
        Me.MemberCode.ReadOnly = True
        Me.MemberCode.Visible = False
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(15, 483)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 26)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(104, 483)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 26)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(193, 483)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 26)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtAmount.DecimalScale = 0
        Me.txtAmount.DefaultTextBox = False
        Me.txtAmount.EnterKey = False
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(445, 13)
        Me.txtAmount.MaxLength = 12
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ShiftKey = True
        Me.txtAmount.Size = New System.Drawing.Size(93, 26)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.Text = "500"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAmount.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'dtpDepositDate
        '
        Me.dtpDepositDate.EnterKey = True
        Me.dtpDepositDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepositDate.Location = New System.Drawing.Point(106, 13)
        Me.dtpDepositDate.Mask = "99/99/9999"
        Me.dtpDepositDate.Name = "dtpDepositDate"
        Me.dtpDepositDate.ShiftKey = True
        Me.dtpDepositDate.Size = New System.Drawing.Size(107, 26)
        Me.dtpDepositDate.TabIndex = 0
        Me.dtpDepositDate.Value = New Date(CType(0, Long))
        '
        'Linevb1
        '
        Me.Linevb1.Enabled = False
        Me.Linevb1.FirstColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Linevb1.Location = New System.Drawing.Point(5, 50)
        Me.Linevb1.Name = "Linevb1"
        Me.Linevb1.SecondColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Linevb1.Size = New System.Drawing.Size(575, 2)
        Me.Linevb1.TabIndex = 10
        Me.Linevb1.Text = "Linevb1"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BackColor = System.Drawing.Color.White
        Me.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGrandTotal.Location = New System.Drawing.Point(428, 483)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(141, 26)
        Me.lblGrandTotal.TabIndex = 11
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(339, 486)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total ..."
        '
        'btnMember
        '
        Me.btnMember.BackColor = System.Drawing.Color.Transparent
        Me.btnMember.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMember.FlatAppearance.BorderSize = 0
        Me.btnMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMember.Location = New System.Drawing.Point(405, 59)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(18, 23)
        Me.btnMember.TabIndex = 54
        Me.btnMember.Text = "#"
        Me.btnMember.UseVisualStyleBackColor = False
        '
        'frmThriftDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 532)
        Me.Controls.Add(Me.btnMember)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.Linevb1)
        Me.Controls.Add(Me.dtpDepositDate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmpNo)
        Me.Name = "frmThriftDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThriftDeposit"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmpNo As sControls.TextBoxvb
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grid As sControls.ViewGrid
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As sControls.TextBoxvb
    Friend WithEvents dtpDepositDate As sControls.DateTimeMaskvb
    Friend WithEvents Linevb1 As sControls.Linevb
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThriftDepositCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMember As sControls.Buttonvb
End Class
