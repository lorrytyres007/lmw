<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffDemandAlter
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtDemandCode = New sControls.TextBoxvb
        Me.txtODInt = New sControls.TextBoxvb
        Me.txtODPrn = New sControls.TextBoxvb
        Me.txtInt = New sControls.TextBoxvb
        Me.txtPrn = New sControls.TextBoxvb
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCODInt = New sControls.TextBoxvb
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtCODPrn = New sControls.TextBoxvb
        Me.txtCInt = New sControls.TextBoxvb
        Me.txtLoanOS = New sControls.TextBoxvb
        Me.txtCPrn = New sControls.TextBoxvb
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtROI = New sControls.TextBoxvb
        Me.txtLoanAmt = New sControls.TextBoxvb
        Me.txtTokenNo = New sControls.TextBoxvb
        Me.txtMemberName = New sControls.TextBoxvb
        Me.txtLoanName = New sControls.TextBoxvb
        Me.txtLoanNo = New sControls.TextBoxvb
        Me.dtpLoanDate = New sControls.DateTimeMaskvb(Me.components)
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Grid1 = New sControls.ViewGrid
        Me.Auto_SNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDemandCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CFyCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMemberCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLoanCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTokenNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLoanNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLoanOSforInt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnView = New System.Windows.Forms.Button
        Me.dtpTo = New sControls.DateTimeMaskvb(Me.components)
        Me.dtpFrom = New sControls.DateTimeMaskvb(Me.components)
        Me.cmbMonth = New sControls.ComboBoxvb
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.TextBoxvb1 = New sControls.TextBoxvb
        Me.TextBoxvb2 = New sControls.TextBoxvb
        Me.TextBoxvb3 = New sControls.TextBoxvb
        Me.TextBoxvb4 = New sControls.TextBoxvb
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBoxvb5 = New sControls.TextBoxvb
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBoxvb6 = New sControls.TextBoxvb
        Me.TextBoxvb7 = New sControls.TextBoxvb
        Me.TextBoxvb8 = New sControls.TextBoxvb
        Me.TextBoxvb9 = New sControls.TextBoxvb
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 494)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(385, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(578, 439)
        Me.Panel4.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TextBoxvb6)
        Me.Panel7.Controls.Add(Me.TextBoxvb7)
        Me.Panel7.Controls.Add(Me.TextBoxvb8)
        Me.Panel7.Controls.Add(Me.TextBoxvb9)
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.TextBoxvb5)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.TextBoxvb1)
        Me.Panel7.Controls.Add(Me.TextBoxvb2)
        Me.Panel7.Controls.Add(Me.TextBoxvb3)
        Me.Panel7.Controls.Add(Me.TextBoxvb4)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.txtDemandCode)
        Me.Panel7.Controls.Add(Me.txtODInt)
        Me.Panel7.Controls.Add(Me.txtODPrn)
        Me.Panel7.Controls.Add(Me.txtInt)
        Me.Panel7.Controls.Add(Me.txtPrn)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.txtCODInt)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Controls.Add(Me.Label22)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.btnSave)
        Me.Panel7.Controls.Add(Me.txtCODPrn)
        Me.Panel7.Controls.Add(Me.txtCInt)
        Me.Panel7.Controls.Add(Me.txtLoanOS)
        Me.Panel7.Controls.Add(Me.txtCPrn)
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 142)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(576, 295)
        Me.Panel7.TabIndex = 179
        '
        'txtDemandCode
        '
        Me.txtDemandCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDemandCode.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtDemandCode.DecimalScale = 2
        Me.txtDemandCode.DefaultTextBox = False
        Me.txtDemandCode.EnterKey = True
        Me.txtDemandCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDemandCode.Location = New System.Drawing.Point(451, 262)
        Me.txtDemandCode.Name = "txtDemandCode"
        Me.txtDemandCode.ReadOnly = True
        Me.txtDemandCode.ShiftKey = True
        Me.txtDemandCode.Size = New System.Drawing.Size(98, 23)
        Me.txtDemandCode.TabIndex = 190
        Me.txtDemandCode.TabStop = False
        Me.txtDemandCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDemandCode.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        Me.txtDemandCode.Visible = False
        '
        'txtODInt
        '
        Me.txtODInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtODInt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtODInt.DecimalScale = 2
        Me.txtODInt.DefaultTextBox = False
        Me.txtODInt.Enabled = False
        Me.txtODInt.EnterKey = True
        Me.txtODInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtODInt.Location = New System.Drawing.Point(421, 94)
        Me.txtODInt.Name = "txtODInt"
        Me.txtODInt.ReadOnly = True
        Me.txtODInt.ShiftKey = True
        Me.txtODInt.Size = New System.Drawing.Size(87, 23)
        Me.txtODInt.TabIndex = 189
        Me.txtODInt.TabStop = False
        Me.txtODInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtODInt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtODPrn
        '
        Me.txtODPrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtODPrn.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtODPrn.DecimalScale = 2
        Me.txtODPrn.DefaultTextBox = False
        Me.txtODPrn.Enabled = False
        Me.txtODPrn.EnterKey = True
        Me.txtODPrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtODPrn.Location = New System.Drawing.Point(328, 94)
        Me.txtODPrn.Name = "txtODPrn"
        Me.txtODPrn.ReadOnly = True
        Me.txtODPrn.ShiftKey = True
        Me.txtODPrn.Size = New System.Drawing.Size(87, 23)
        Me.txtODPrn.TabIndex = 188
        Me.txtODPrn.TabStop = False
        Me.txtODPrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtODPrn.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtInt
        '
        Me.txtInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtInt.DecimalScale = 2
        Me.txtInt.DefaultTextBox = False
        Me.txtInt.Enabled = False
        Me.txtInt.EnterKey = True
        Me.txtInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInt.Location = New System.Drawing.Point(235, 94)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.ReadOnly = True
        Me.txtInt.ShiftKey = True
        Me.txtInt.Size = New System.Drawing.Size(87, 23)
        Me.txtInt.TabIndex = 187
        Me.txtInt.TabStop = False
        Me.txtInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtInt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtPrn
        '
        Me.txtPrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrn.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtPrn.DecimalScale = 2
        Me.txtPrn.DefaultTextBox = False
        Me.txtPrn.Enabled = False
        Me.txtPrn.EnterKey = True
        Me.txtPrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPrn.Location = New System.Drawing.Point(131, 94)
        Me.txtPrn.Name = "txtPrn"
        Me.txtPrn.ReadOnly = True
        Me.txtPrn.ShiftKey = True
        Me.txtPrn.Size = New System.Drawing.Size(98, 23)
        Me.txtPrn.TabIndex = 186
        Me.txtPrn.TabStop = False
        Me.txtPrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrn.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 23)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "Collection"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(421, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 24)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "OD Interest"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCODInt
        '
        Me.txtCODInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODInt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCODInt.DecimalScale = 2
        Me.txtCODInt.DefaultTextBox = False
        Me.txtCODInt.EnterKey = True
        Me.txtCODInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCODInt.Location = New System.Drawing.Point(421, 64)
        Me.txtCODInt.Name = "txtCODInt"
        Me.txtCODInt.ShiftKey = True
        Me.txtCODInt.Size = New System.Drawing.Size(87, 23)
        Me.txtCODInt.TabIndex = 182
        Me.txtCODInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCODInt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.LightGray
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(328, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 24)
        Me.Label21.TabIndex = 180
        Me.Label21.Text = "OD Prin."
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.LightGray
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(235, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 24)
        Me.Label22.TabIndex = 179
        Me.Label22.Text = "Interest"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.LightGray
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(131, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(98, 24)
        Me.Label23.TabIndex = 178
        Me.Label23.Text = "Principal"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(221, 252)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 39)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Update"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCODPrn
        '
        Me.txtCODPrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODPrn.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCODPrn.DecimalScale = 2
        Me.txtCODPrn.DefaultTextBox = False
        Me.txtCODPrn.EnterKey = True
        Me.txtCODPrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCODPrn.Location = New System.Drawing.Point(328, 64)
        Me.txtCODPrn.Name = "txtCODPrn"
        Me.txtCODPrn.ShiftKey = True
        Me.txtCODPrn.Size = New System.Drawing.Size(87, 23)
        Me.txtCODPrn.TabIndex = 176
        Me.txtCODPrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCODPrn.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtCInt
        '
        Me.txtCInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCInt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCInt.DecimalScale = 2
        Me.txtCInt.DefaultTextBox = False
        Me.txtCInt.EnterKey = True
        Me.txtCInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCInt.Location = New System.Drawing.Point(235, 64)
        Me.txtCInt.Name = "txtCInt"
        Me.txtCInt.ShiftKey = True
        Me.txtCInt.Size = New System.Drawing.Size(87, 23)
        Me.txtCInt.TabIndex = 173
        Me.txtCInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCInt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtLoanOS
        '
        Me.txtLoanOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanOS.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanOS.DecimalScale = 2
        Me.txtLoanOS.DefaultTextBox = False
        Me.txtLoanOS.EnterKey = True
        Me.txtLoanOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanOS.Location = New System.Drawing.Point(408, 196)
        Me.txtLoanOS.Name = "txtLoanOS"
        Me.txtLoanOS.ShiftKey = True
        Me.txtLoanOS.Size = New System.Drawing.Size(98, 23)
        Me.txtLoanOS.TabIndex = 171
        Me.txtLoanOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanOS.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtCPrn
        '
        Me.txtCPrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPrn.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtCPrn.DecimalScale = 2
        Me.txtCPrn.DefaultTextBox = False
        Me.txtCPrn.EnterKey = True
        Me.txtCPrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCPrn.Location = New System.Drawing.Point(131, 64)
        Me.txtCPrn.Name = "txtCPrn"
        Me.txtCPrn.ShiftKey = True
        Me.txtCPrn.Size = New System.Drawing.Size(98, 23)
        Me.txtCPrn.TabIndex = 169
        Me.txtCPrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCPrn.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(332, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 16)
        Me.Label20.TabIndex = 161
        Me.Label20.Text = "Loan OS"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightGray
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 23)
        Me.Label16.TabIndex = 155
        Me.Label16.Text = "Current Demand"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtROI)
        Me.Panel6.Controls.Add(Me.txtLoanAmt)
        Me.Panel6.Controls.Add(Me.txtTokenNo)
        Me.Panel6.Controls.Add(Me.txtMemberName)
        Me.Panel6.Controls.Add(Me.txtLoanName)
        Me.Panel6.Controls.Add(Me.txtLoanNo)
        Me.Panel6.Controls.Add(Me.dtpLoanDate)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 34)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(576, 108)
        Me.Panel6.TabIndex = 178
        '
        'txtROI
        '
        Me.txtROI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtROI.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtROI.DecimalScale = 2
        Me.txtROI.DefaultTextBox = False
        Me.txtROI.EnterKey = True
        Me.txtROI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtROI.Location = New System.Drawing.Point(462, 63)
        Me.txtROI.Name = "txtROI"
        Me.txtROI.ReadOnly = True
        Me.txtROI.ShiftKey = True
        Me.txtROI.Size = New System.Drawing.Size(87, 23)
        Me.txtROI.TabIndex = 167
        Me.txtROI.TabStop = False
        Me.txtROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtROI.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtLoanAmt
        '
        Me.txtLoanAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanAmt.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanAmt.DecimalScale = 2
        Me.txtLoanAmt.DefaultTextBox = False
        Me.txtLoanAmt.EnterKey = True
        Me.txtLoanAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanAmt.Location = New System.Drawing.Point(104, 63)
        Me.txtLoanAmt.Name = "txtLoanAmt"
        Me.txtLoanAmt.ReadOnly = True
        Me.txtLoanAmt.ShiftKey = True
        Me.txtLoanAmt.Size = New System.Drawing.Size(98, 23)
        Me.txtLoanAmt.TabIndex = 166
        Me.txtLoanAmt.TabStop = False
        Me.txtLoanAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanAmt.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'txtTokenNo
        '
        Me.txtTokenNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTokenNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtTokenNo.DecimalScale = 0
        Me.txtTokenNo.DefaultTextBox = False
        Me.txtTokenNo.EnterKey = True
        Me.txtTokenNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTokenNo.Location = New System.Drawing.Point(104, 7)
        Me.txtTokenNo.Name = "txtTokenNo"
        Me.txtTokenNo.ReadOnly = True
        Me.txtTokenNo.ShiftKey = True
        Me.txtTokenNo.Size = New System.Drawing.Size(98, 23)
        Me.txtTokenNo.TabIndex = 165
        Me.txtTokenNo.TabStop = False
        Me.txtTokenNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTokenNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'txtMemberName
        '
        Me.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtMemberName.DecimalScale = 0
        Me.txtMemberName.DefaultTextBox = False
        Me.txtMemberName.EnterKey = True
        Me.txtMemberName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMemberName.Location = New System.Drawing.Point(303, 7)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.ReadOnly = True
        Me.txtMemberName.ShiftKey = True
        Me.txtMemberName.Size = New System.Drawing.Size(245, 23)
        Me.txtMemberName.TabIndex = 164
        Me.txtMemberName.TabStop = False
        Me.txtMemberName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMemberName.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'txtLoanName
        '
        Me.txtLoanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanName.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanName.DecimalScale = 0
        Me.txtLoanName.DefaultTextBox = False
        Me.txtLoanName.EnterKey = True
        Me.txtLoanName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanName.Location = New System.Drawing.Point(304, 35)
        Me.txtLoanName.Name = "txtLoanName"
        Me.txtLoanName.ReadOnly = True
        Me.txtLoanName.ShiftKey = True
        Me.txtLoanName.Size = New System.Drawing.Size(245, 23)
        Me.txtLoanName.TabIndex = 163
        Me.txtLoanName.TabStop = False
        Me.txtLoanName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLoanName.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'txtLoanNo
        '
        Me.txtLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanNo.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.txtLoanNo.DecimalScale = 0
        Me.txtLoanNo.DefaultTextBox = False
        Me.txtLoanNo.EnterKey = True
        Me.txtLoanNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLoanNo.Location = New System.Drawing.Point(104, 35)
        Me.txtLoanNo.Name = "txtLoanNo"
        Me.txtLoanNo.ReadOnly = True
        Me.txtLoanNo.ShiftKey = True
        Me.txtLoanNo.Size = New System.Drawing.Size(98, 23)
        Me.txtLoanNo.TabIndex = 162
        Me.txtLoanNo.TabStop = False
        Me.txtLoanNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLoanNo.TextFormat = sControls.TextBoxvb.FormatText.NumericOnly
        '
        'dtpLoanDate
        '
        Me.dtpLoanDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpLoanDate.Enabled = False
        Me.dtpLoanDate.EnterKey = False
        Me.dtpLoanDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpLoanDate.Location = New System.Drawing.Point(304, 63)
        Me.dtpLoanDate.Mask = "99/99/9999"
        Me.dtpLoanDate.Name = "dtpLoanDate"
        Me.dtpLoanDate.ReadOnly = True
        Me.dtpLoanDate.ShiftKey = True
        Me.dtpLoanDate.Size = New System.Drawing.Size(87, 23)
        Me.dtpLoanDate.TabIndex = 151
        Me.dtpLoanDate.TabStop = False
        Me.dtpLoanDate.Value = New Date(CType(0, Long))
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(397, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 16)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "ROI"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(208, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 16)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "Loan Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "Loan Amt"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(208, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "Loan Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Loan Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(208, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "MemberName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Token Number"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(576, 34)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Demand Check list"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Grid1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 439)
        Me.Panel3.TabIndex = 1
        '
        'Grid1
        '
        Me.Grid1.AllowUserToAddRows = False
        Me.Grid1.AllowUserToDeleteRows = False
        Me.Grid1.AllowUserToOrderColumns = True
        Me.Grid1.AllowUserToResizeColumns = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Grid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Grid1.Auto_SNo = True
        Me.Grid1.BackgroundColor = System.Drawing.Color.White
        Me.Grid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Grid1.ColumnHeadersHeight = 32
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auto_SNo1, Me.CDemandCode, Me.CFyCode, Me.CMemberCode, Me.CLoanCode, Me.CTokenNo, Me.CLoanNo, Me.CLoanOSforInt})
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Grid1.EnableHeadersVisualStyles = False
        Me.Grid1.GridColor = System.Drawing.Color.WhiteSmoke
        Me.Grid1.Grouping = False
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MultiSelect = False
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Grid1.RowHeadersVisible = False
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.Grid1.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.Grid1.RowTemplate.Height = 32
        Me.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid1.ShowCellErrors = False
        Me.Grid1.ShowRowErrors = False
        Me.Grid1.Size = New System.Drawing.Size(383, 437)
        Me.Grid1.TabIndex = 99
        '
        'Auto_SNo1
        '
        Me.Auto_SNo1.HeaderText = "S.No"
        Me.Auto_SNo1.Name = "Auto_SNo1"
        Me.Auto_SNo1.ReadOnly = True
        Me.Auto_SNo1.Width = 45
        '
        'CDemandCode
        '
        Me.CDemandCode.HeaderText = "DemandCode"
        Me.CDemandCode.Name = "CDemandCode"
        Me.CDemandCode.ReadOnly = True
        Me.CDemandCode.Visible = False
        Me.CDemandCode.Width = 106
        '
        'CFyCode
        '
        Me.CFyCode.HeaderText = "FyCode"
        Me.CFyCode.Name = "CFyCode"
        Me.CFyCode.ReadOnly = True
        Me.CFyCode.Visible = False
        Me.CFyCode.Width = 73
        '
        'CMemberCode
        '
        Me.CMemberCode.HeaderText = "MemberCode"
        Me.CMemberCode.Name = "CMemberCode"
        Me.CMemberCode.ReadOnly = True
        Me.CMemberCode.Visible = False
        Me.CMemberCode.Width = 104
        '
        'CLoanCode
        '
        Me.CLoanCode.HeaderText = "LoanCode"
        Me.CLoanCode.Name = "CLoanCode"
        Me.CLoanCode.ReadOnly = True
        Me.CLoanCode.Visible = False
        Me.CLoanCode.Width = 88
        '
        'CTokenNo
        '
        Me.CTokenNo.HeaderText = "Tkn. No"
        Me.CTokenNo.Name = "CTokenNo"
        Me.CTokenNo.ReadOnly = True
        '
        'CLoanNo
        '
        Me.CLoanNo.HeaderText = "LoanNumber"
        Me.CLoanNo.Name = "CLoanNo"
        Me.CLoanNo.ReadOnly = True
        Me.CLoanNo.Width = 102
        '
        'CLoanOSforInt
        '
        Me.CLoanOSforInt.HeaderText = "LoanOSforInt"
        Me.CLoanOSforInt.Name = "CLoanOSforInt"
        Me.CLoanOSforInt.ReadOnly = True
        Me.CLoanOSforInt.Width = 106
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Controls.Add(Me.dtpTo)
        Me.Panel2.Controls.Add(Me.dtpFrom)
        Me.Panel2.Controls.Add(Me.cmbMonth)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(963, 53)
        Me.Panel2.TabIndex = 0
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnView.Location = New System.Drawing.Point(489, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(63, 26)
        Me.btnView.TabIndex = 151
        Me.btnView.Text = "&View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpTo.Enabled = False
        Me.dtpTo.EnterKey = False
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpTo.Location = New System.Drawing.Point(831, 16)
        Me.dtpTo.Mask = "99/99/9999"
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ReadOnly = True
        Me.dtpTo.ShiftKey = True
        Me.dtpTo.Size = New System.Drawing.Size(87, 23)
        Me.dtpTo.TabIndex = 150
        Me.dtpTo.TabStop = False
        Me.dtpTo.Value = New Date(CType(0, Long))
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFrom.Enabled = False
        Me.dtpFrom.EnterKey = False
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpFrom.Location = New System.Drawing.Point(738, 16)
        Me.dtpFrom.Mask = "99/99/9999"
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ReadOnly = True
        Me.dtpFrom.ShiftKey = True
        Me.dtpFrom.Size = New System.Drawing.Size(87, 23)
        Me.dtpFrom.TabIndex = 148
        Me.dtpFrom.TabStop = False
        Me.dtpFrom.Value = New Date(CType(0, Long))
        '
        'cmbMonth
        '
        Me.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMonth.CharFormat = sControls.ComboBoxvb.FormatChar.UpperCase
        Me.cmbMonth.DefaultText = "--SELECT--"
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.EnterKey = True
        Me.cmbMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"--SELECT--", "MARCH -LAST A/c YEAR", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER", "JANUARY", "FEBRUARY", "MARCH"})
        Me.cmbMonth.Location = New System.Drawing.Point(319, 12)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.ShiftKey = True
        Me.cmbMonth.Size = New System.Drawing.Size(152, 26)
        Me.cmbMonth.TabIndex = 146
        Me.cmbMonth.Validation = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(235, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "MONTH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 19)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Demand Check list"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnExit)
        Me.Panel5.Controls.Add(Me.btnClear)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 494)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(965, 53)
        Me.Panel5.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(509, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(357, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 39)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'TextBoxvb1
        '
        Me.TextBoxvb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb1.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb1.DecimalScale = 2
        Me.TextBoxvb1.DefaultTextBox = False
        Me.TextBoxvb1.Enabled = False
        Me.TextBoxvb1.EnterKey = True
        Me.TextBoxvb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb1.Location = New System.Drawing.Point(422, 124)
        Me.TextBoxvb1.Name = "TextBoxvb1"
        Me.TextBoxvb1.ReadOnly = True
        Me.TextBoxvb1.ShiftKey = True
        Me.TextBoxvb1.Size = New System.Drawing.Size(87, 23)
        Me.TextBoxvb1.TabIndex = 195
        Me.TextBoxvb1.TabStop = False
        Me.TextBoxvb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb1.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'TextBoxvb2
        '
        Me.TextBoxvb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb2.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb2.DecimalScale = 2
        Me.TextBoxvb2.DefaultTextBox = False
        Me.TextBoxvb2.Enabled = False
        Me.TextBoxvb2.EnterKey = True
        Me.TextBoxvb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb2.Location = New System.Drawing.Point(329, 124)
        Me.TextBoxvb2.Name = "TextBoxvb2"
        Me.TextBoxvb2.ReadOnly = True
        Me.TextBoxvb2.ShiftKey = True
        Me.TextBoxvb2.Size = New System.Drawing.Size(87, 23)
        Me.TextBoxvb2.TabIndex = 194
        Me.TextBoxvb2.TabStop = False
        Me.TextBoxvb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb2.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'TextBoxvb3
        '
        Me.TextBoxvb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb3.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb3.DecimalScale = 2
        Me.TextBoxvb3.DefaultTextBox = False
        Me.TextBoxvb3.Enabled = False
        Me.TextBoxvb3.EnterKey = True
        Me.TextBoxvb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb3.Location = New System.Drawing.Point(236, 124)
        Me.TextBoxvb3.Name = "TextBoxvb3"
        Me.TextBoxvb3.ReadOnly = True
        Me.TextBoxvb3.ShiftKey = True
        Me.TextBoxvb3.Size = New System.Drawing.Size(87, 23)
        Me.TextBoxvb3.TabIndex = 193
        Me.TextBoxvb3.TabStop = False
        Me.TextBoxvb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb3.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'TextBoxvb4
        '
        Me.TextBoxvb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb4.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb4.DecimalScale = 2
        Me.TextBoxvb4.DefaultTextBox = False
        Me.TextBoxvb4.Enabled = False
        Me.TextBoxvb4.EnterKey = True
        Me.TextBoxvb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb4.Location = New System.Drawing.Point(132, 124)
        Me.TextBoxvb4.Name = "TextBoxvb4"
        Me.TextBoxvb4.ReadOnly = True
        Me.TextBoxvb4.ShiftKey = True
        Me.TextBoxvb4.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxvb4.TabIndex = 192
        Me.TextBoxvb4.TabStop = False
        Me.TextBoxvb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb4.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 23)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Balance"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxvb5
        '
        Me.TextBoxvb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb5.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb5.DecimalScale = 2
        Me.TextBoxvb5.DefaultTextBox = False
        Me.TextBoxvb5.EnterKey = True
        Me.TextBoxvb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb5.Location = New System.Drawing.Point(131, 198)
        Me.TextBoxvb5.Name = "TextBoxvb5"
        Me.TextBoxvb5.ShiftKey = True
        Me.TextBoxvb5.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxvb5.TabIndex = 197
        Me.TextBoxvb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb5.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 16)
        Me.Label14.TabIndex = 196
        Me.Label14.Text = "Loan OS for Int"
        '
        'TextBoxvb6
        '
        Me.TextBoxvb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb6.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb6.DecimalScale = 2
        Me.TextBoxvb6.DefaultTextBox = False
        Me.TextBoxvb6.Enabled = False
        Me.TextBoxvb6.EnterKey = True
        Me.TextBoxvb6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb6.Location = New System.Drawing.Point(421, 34)
        Me.TextBoxvb6.Name = "TextBoxvb6"
        Me.TextBoxvb6.ReadOnly = True
        Me.TextBoxvb6.ShiftKey = True
        Me.TextBoxvb6.Size = New System.Drawing.Size(87, 23)
        Me.TextBoxvb6.TabIndex = 202
        Me.TextBoxvb6.TabStop = False
        Me.TextBoxvb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb6.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'TextBoxvb7
        '
        Me.TextBoxvb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb7.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb7.DecimalScale = 2
        Me.TextBoxvb7.DefaultTextBox = False
        Me.TextBoxvb7.Enabled = False
        Me.TextBoxvb7.EnterKey = True
        Me.TextBoxvb7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb7.Location = New System.Drawing.Point(328, 34)
        Me.TextBoxvb7.Name = "TextBoxvb7"
        Me.TextBoxvb7.ReadOnly = True
        Me.TextBoxvb7.ShiftKey = True
        Me.TextBoxvb7.Size = New System.Drawing.Size(87, 23)
        Me.TextBoxvb7.TabIndex = 201
        Me.TextBoxvb7.TabStop = False
        Me.TextBoxvb7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb7.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'TextBoxvb8
        '
        Me.TextBoxvb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb8.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb8.DecimalScale = 2
        Me.TextBoxvb8.DefaultTextBox = False
        Me.TextBoxvb8.Enabled = False
        Me.TextBoxvb8.EnterKey = True
        Me.TextBoxvb8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb8.Location = New System.Drawing.Point(235, 34)
        Me.TextBoxvb8.Name = "TextBoxvb8"
        Me.TextBoxvb8.ReadOnly = True
        Me.TextBoxvb8.ShiftKey = True
        Me.TextBoxvb8.Size = New System.Drawing.Size(87, 23)
        Me.TextBoxvb8.TabIndex = 200
        Me.TextBoxvb8.TabStop = False
        Me.TextBoxvb8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb8.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'TextBoxvb9
        '
        Me.TextBoxvb9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxvb9.CharFormat = sControls.TextBoxvb.FormatChar.UpperCase
        Me.TextBoxvb9.DecimalScale = 2
        Me.TextBoxvb9.DefaultTextBox = False
        Me.TextBoxvb9.Enabled = False
        Me.TextBoxvb9.EnterKey = True
        Me.TextBoxvb9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxvb9.Location = New System.Drawing.Point(131, 34)
        Me.TextBoxvb9.Name = "TextBoxvb9"
        Me.TextBoxvb9.ReadOnly = True
        Me.TextBoxvb9.ShiftKey = True
        Me.TextBoxvb9.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxvb9.TabIndex = 199
        Me.TextBoxvb9.TabStop = False
        Me.TextBoxvb9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxvb9.TextFormat = sControls.TextBoxvb.FormatText.DecimalNum
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.LightGray
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 23)
        Me.Label15.TabIndex = 198
        Me.Label15.Text = "Arrear"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmStaffDemandAlter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "frmStaffDemandAlter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demand Check List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Grid1 As sControls.ViewGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As sControls.ComboBoxvb
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As sControls.DateTimeMaskvb
    Friend WithEvents dtpFrom As sControls.DateTimeMaskvb
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Auto_SNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDemandCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFyCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMemberCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLoanCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTokenNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLoanNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLoanOSforInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpLoanDate As sControls.DateTimeMaskvb
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCODPrn As sControls.TextBoxvb
    Friend WithEvents txtCInt As sControls.TextBoxvb
    Friend WithEvents txtLoanOS As sControls.TextBoxvb
    Friend WithEvents txtCPrn As sControls.TextBoxvb
    Friend WithEvents txtROI As sControls.TextBoxvb
    Friend WithEvents txtLoanAmt As sControls.TextBoxvb
    Friend WithEvents txtTokenNo As sControls.TextBoxvb
    Friend WithEvents txtMemberName As sControls.TextBoxvb
    Friend WithEvents txtLoanName As sControls.TextBoxvb
    Friend WithEvents txtLoanNo As sControls.TextBoxvb
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCODInt As sControls.TextBoxvb
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtODInt As sControls.TextBoxvb
    Friend WithEvents txtODPrn As sControls.TextBoxvb
    Friend WithEvents txtInt As sControls.TextBoxvb
    Friend WithEvents txtPrn As sControls.TextBoxvb
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDemandCode As sControls.TextBoxvb
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents TextBoxvb5 As sControls.TextBoxvb
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBoxvb1 As sControls.TextBoxvb
    Friend WithEvents TextBoxvb2 As sControls.TextBoxvb
    Friend WithEvents TextBoxvb3 As sControls.TextBoxvb
    Friend WithEvents TextBoxvb4 As sControls.TextBoxvb
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxvb6 As sControls.TextBoxvb
    Friend WithEvents TextBoxvb7 As sControls.TextBoxvb
    Friend WithEvents TextBoxvb8 As sControls.TextBoxvb
    Friend WithEvents TextBoxvb9 As sControls.TextBoxvb
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
