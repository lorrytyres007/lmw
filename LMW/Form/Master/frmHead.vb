
Public Class frmHead
    Dim bool_Edit As Boolean
    Dim companycode As Integer
    Dim Flag As String
    Dim objHead As New DBLayer.clsHead

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            bool_Edit = True
            Bind_Data()
            companycode = DataRow.Cells("CompanyCode").Value
            txtHeadCode.Text = DataRow.Cells("HeadCode").Value
            txtHeadName.Text = DataRow.Cells("HeadName").Value
            txtHeadOpeningCode.Text = DataRow.Cells("HeadOpeningCode").Value.ToString
            If companycode = 0 Then
                cmbGroupName.Enabled = False
            Else
                cmbGroupName.Enabled = True
            End If
            cmbGroupName.SelectedValue = DataRow.Cells("GroupCode").Value
            cmbRP.SelectedIndex = IIf(DataRow.Cells("Rp").Value = True, 1, 0)
            txtOpnBalance.Text = DataRow.Cells("OpeningBalance").Value
            cmbYesNo.SelectedIndex = IIf(DataRow.Cells("OnvoucherNumber_Yesno").Value = False, 1, 0)
            'If companycode = 0 Then
            '    txtOpnBalance.Enabled = False
            'Else
            '    txtOpnBalance.Enabled = True
            'End If
            If DataRow.Cells("DELFLAG").Value = False Then
                txtHeadName.Enabled = False
            Else
                txtHeadName.Enabled = True
            End If
            Me.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Show_Add()
        bool_Edit = False
        txtOpnBalance.Enabled = True
        cmbGroupName.Enabled = True
        txtHeadName.Enabled = True
        Me.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtHeadName.Text.Trim = "" Then
                MsgBox("Head Name is Empty", MsgBoxStyle.Information, Mssg)
                txtHeadName.Focus()
                Exit Sub
            End If
            If cmbGroupName.SelectedIndex = 0 Then
                MsgBox("Select Group Name", MsgBoxStyle.Information, Mssg)
                cmbGroupName.Focus()
                Exit Sub
            End If
            objHead.HeadCode = Val(txtHeadCode.Text)
            objHead.HeadName = txtHeadName.Text
            objHead.GroupCode = cmbGroupName.ColData("GroupCode")
            objHead.OpnBalance = Val(txtOpnBalance.Text)
            objHead.rp = cmbRP.SelectedIndex
            objHead.CompanyCode = int_CompanyCode
            objHead.Company = 0
            objHead.HeadOpeningCode = Val(txtHeadOpeningCode.Text)
            objHead.OnVoucherNumber_YesNo = IIf(cmbYesNo.SelectedIndex = 0, 1, 0)
            objHead.Fycode = int_FYearCode

            If bool_Edit = False Then
                objHead.SaveRecords()
                objHead.CompanyCode = int_CompanyCode
                objHead.Fycode = int_FYearCode
                frmHeadDetails.Grid.RecordSet(objHead.GetRecords(), "CompanyCode,HeadCode,GroupCode,HeadOpeningCode")

                MsgBox("Records are Saved", MsgBoxStyle.Information, Mssg)
                btnClear_Click(sender, e)
            Else
                objHead.UpdateRecords()
                objHead.CompanyCode = int_CompanyCode
                objHead.Fycode = int_FYearCode
                frmHeadDetails.Grid.RecordSet(objHead.GetRecords(), "CompanyCode,HeadCode,GroupCode,HeadOpeningCode")
                MsgBox("Records are Updated", MsgBoxStyle.Information, Mssg)
                btnExit_Click(sender, e)
            End If
        Catch ex As Exception
            If ex.Message.Contains("UK_tbl_HeadName") Then
                MsgBox("Unique Name. found Already", MsgBoxStyle.Information, Mssg)
                txtHeadName.Focus()
            ElseIf ex.Message.Contains("UK_tbl_HeadOpening") Then
                MsgBox("Unique Name. found Already", MsgBoxStyle.Information, Mssg)
                txtHeadName.Focus()
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End If
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim groupindex As Integer = cmbGroupName.ColData("GroupCode")
        FormClear(Me)
        cmbGroupName.SelectedValue = groupindex
        CheckOne()
        txtHeadName.Enabled = True
        txtHeadName.Focus()
    End Sub
    Private Sub CheckOne()
        lblReceipt.Text = objDScal("SELECT isnull(sum(OpeningBalance),0) FROM tbl_HeadOpening where Rp=0 and Companycode=" & int_CompanyCode)
        lblPayment.Text = objDScal("SELECT isnull(sum(OpeningBalance),0) FROM tbl_HeadOpening where Rp=1 and Companycode=" & int_CompanyCode)
        If Val(lblPayment.Text) > Val(lblReceipt.Text) Then
            lblDifference.Text = Val(lblPayment.Text) - Val(lblReceipt.Text)
        Else
            lblDifference.Text = Format(Val(lblReceipt.Text) - Val(lblPayment.Text), "0.00")
        End If
    End Sub
    Private Sub frmHead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "Ledger Details", False)
        If bool_Edit = False Then
            Bind_Data()
            cmbGroupName.SelectedIndex = 0
            cmbYesNo.SelectedIndex = 0
            cmbRP.SelectedIndex = 0
        End If
        CheckOne()
    End Sub

    Private Sub Bind_Data()
        objHead.CompanyCode = int_CompanyCode
        objHead.Fycode = int_FYearCode
        cmbGroupName.RecordSet(objHead.BindRecords.Tables(0), "GroupName", "GroupCode")
    End Sub

    Private Sub txtOpnBalance_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOpnBalance.Validated
        txtOpnBalance.Text = Format(Val(txtOpnBalance.Text), "#0.00")
    End Sub

End Class