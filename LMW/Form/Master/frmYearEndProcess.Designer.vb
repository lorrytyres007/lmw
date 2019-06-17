<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearEndProcess
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblContent = New System.Windows.Forms.Label
        Me.btnEmpty = New System.Windows.Forms.Button
        Me.btnYearEnd = New System.Windows.Forms.Button
        Me.btnBackup = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(158, 125)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(18, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 8)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContent.Location = New System.Drawing.Point(33, 83)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(0, 16)
        Me.lblContent.TabIndex = 9
        '
        'btnEmpty
        '
        Me.btnEmpty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpty.Location = New System.Drawing.Point(158, 24)
        Me.btnEmpty.Name = "btnEmpty"
        Me.btnEmpty.Size = New System.Drawing.Size(75, 25)
        Me.btnEmpty.TabIndex = 10
        Me.btnEmpty.Text = "&Empty"
        Me.btnEmpty.UseVisualStyleBackColor = True
        '
        'btnYearEnd
        '
        Me.btnYearEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYearEnd.Location = New System.Drawing.Point(280, 24)
        Me.btnYearEnd.Name = "btnYearEnd"
        Me.btnYearEnd.Size = New System.Drawing.Size(75, 25)
        Me.btnYearEnd.TabIndex = 10
        Me.btnYearEnd.Text = "&Year End"
        Me.btnYearEnd.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(36, 24)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 25)
        Me.btnBackup.TabIndex = 11
        Me.btnBackup.Text = "&Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'frmYearEndProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(390, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnYearEnd)
        Me.Controls.Add(Me.btnEmpty)
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmYearEndProcess"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YearEndProcess Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents lblContent As System.Windows.Forms.Label
    Friend WithEvents btnEmpty As System.Windows.Forms.Button
    Friend WithEvents btnYearEnd As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
End Class
