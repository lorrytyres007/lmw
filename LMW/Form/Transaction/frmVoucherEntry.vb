
Public Class frmVoucherEntry
    Dim bool_Edit As Boolean
    Dim companycode As Integer
    Dim Flag As String
    Dim objvoucher As DataSet
    Dim objVoucherEntry As New DBLayer.clsVoucherEntry


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If CheckDate(dtpVoucherDate.Value) = False Then
            MsgBox("Invalid Date is Given", MsgBoxStyle.Information, Mssg)
            dtpVoucherDate.Focus()
            Exit Sub
        End If
        If SD(dtpVoucherDate.Value) <= SD(LastUpDate) Then
            MsgBox("Entry Date is with in the Updation Completed Date... Cant able to Save Now?", MsgBoxStyle.Information, Mssg)
            dtpVoucherDate.Focus()
            Exit Sub
        End If
        If cmbRP.SelectedIndex = -1 Then
            MsgBox("select Receipt - Payment", MsgBoxStyle.Information, Mssg)
            cmbRP.Focus()
            Exit Sub
        End If
        If cmbHeadName.SelectedIndex = 0 Then
            MsgBox("select Head Name", MsgBoxStyle.Information, Mssg)
            cmbHeadName.Focus()
            Exit Sub
        End If
        If Val(txtAmount.Text) + Val(txtAdjustment.Text) = 0 Then
            MsgBox("Enter Amount", MsgBoxStyle.Information, Mssg)
            txtAmount.Focus()
            Exit Sub
        End If
        Try
            objVoucherEntry.VoucherCode = Val(txtVoucherCode.Text)
            If cmbHeadName.ColData("OnVoucherNumber_YesNo") = True Then
                objVoucherEntry.VoucherNumber = IIf(Val(txtVoucherNumber.Text) > 0, Val(txtVoucherNumber.Text), Nothing)
            Else
                objVoucherEntry.VoucherNumber = Nothing
            End If
            objVoucherEntry.Voucherdate = SD(dtpVoucherDate.Value)
            objVoucherEntry.VoucherType = IIf(Val(txtAmount.Text) > 0, "C", "A")
            objVoucherEntry.HeadCode = cmbHeadName.ColData("HeadCode")
            objVoucherEntry.Amount = Val(txtAmount.Text)
            objVoucherEntry.Adjustment = Val(txtAdjustment.Text)
            objVoucherEntry.RP = IIf(cmbRP.SelectedIndex = 0, "R", "P")
            objVoucherEntry.Remarks = txtRemarks.Text.Trim
            objVoucherEntry.AcNo = Val(txtAcNo.Text)
            If bool_Edit = False Then
                objVoucherEntry.SaveRecords()
                MsgBox(" Records are Save Successfully", MsgBoxStyle.Information, Mssg)

            Else
                objVoucherEntry.UpdateRecords()
                MsgBox(" Records are Updated Successfully", MsgBoxStyle.Information, Mssg)
            End If
            btnClear_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim strRemarks As String = txtRemarks.Text.Trim
        PanelClear(Panel1)
        bool_Edit = False
        txtVoucherNumber.Text = "" ' objVoucherEntry.BindNumber
        changeGrid()
        'binddata()
        If chkOption.Checked = True Then
            txtRemarks.Text = strRemarks
        End If
        txtVoucherNumber.Focus()
    End Sub

    Private Sub frmVoucherEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, bool_Edit, "VoucherEntry Details", False)
        cmbRP.SelectedIndex = 0
        cmbCashAdj.SelectedIndex = 0
        binddata()
        'cmbHeadName.SelectedIndex = 0

    End Sub

    Private Sub dtpVoucherDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVoucherDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dtpVoucherDate.Text = "  /  /" Then
                Exit Sub
            End If
            If Len(dtpVoucherDate.Text) > 9 Then
                If CheckDate(dtpVoucherDate.Text) = False Then
                    MsgBox("Invalid Date is Given", MsgBoxStyle.Information, Mssg)
                    dtpVoucherDate.Focus()
                    Exit Sub
                End If
            Else
                dtpVoucherDate.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dtpVoucherDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpVoucherDate.Leave
        Try
            If dtpVoucherDate.Text = "  /  /" Then
                dtpVoucherDate.Focus()
                Exit Sub
            End If
            If bool_Edit = False Then Call changeGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
    End Sub
    Private Sub changeGrid()
        Try

            '------------HERE FIRST GENERATE DUMMY DAYBOOK FOR TRANSFER ENTRY IN DAYBOOK THEN RUN DAYBOOK TO VIEW THE ORG STATUS -------'
            If dtpVoucherDate.Text <> "  /  /" Then
                Dim vdate As DateTime = SD(dtpVoucherDate.Text)
                objDT("sp_CashBalance @CompanyCode=" & int_CompanyCode & ",@FYCode='" & int_FYearCode & "',@ToDate='" & SD(vdate) & "'")
                objDT("sp_DummyDayBook @CompanyCode=" & int_CompanyCode & ",@FromDate='" & SD(vdate) & "',@ToDate='" & SD(vdate) & "'")
                Dim objtable As DataTable = objDT("sp_DayBook @FromDate='" & SD(vdate) & "',@ToDate='" & SD(vdate) & "'")

                Grid.Rows.Clear()
                Dim Rcas As Double = 0
                Dim Pcas As Double = 0
                Dim Radj As Double = 0
                Dim Padj As Double = 0
                Dim Rtot As Double = 0
                Dim Ptot As Double = 0
                Dim OB As Double = objDScal("select isnull(OpeningBalance,0) from tbl_CashBalance where BalanceDate='" & SD(vdate) & "'")
                Dim CB As Double = objDScal("select isnull(ClossingBalance,0) from tbl_CashBalance where BalanceDate='" & SD(vdate) & "'")

                For Rowindex As Integer = 0 To objtable.Rows.Count - 1
                    Grid.Rows.Add(1)
                    Grid.Item("Particulars", Rowindex).Value = objtable.Rows.Item(Rowindex)("HeadName")
                    Grid.Item("Cash", Rowindex).Value = objtable.Rows.Item(Rowindex)("Cash")
                    Grid.Item("Adjustment", Rowindex).Value = objtable.Rows.Item(Rowindex)("Adjustment")
                    Grid.Item("Total", Rowindex).Value = IIf(IsDBNull(objtable.Rows.Item(Rowindex)("Cash")) = True, 0, objtable.Rows.Item(Rowindex)("Cash")) + IIf(IsDBNull(objtable.Rows.Item(Rowindex)("Adjustment")) = True, 0, objtable.Rows.Item(Rowindex)("Adjustment"))
                    Grid.Item("RP", Rowindex).Value = objtable.Rows.Item(Rowindex)("RP")
                    Grid.Item("VoucherCode", Rowindex).Value = objtable.Rows.Item(Rowindex)("VoucherCode")
                    Grid.Item("Remarks", Rowindex).Value = objtable.Rows.Item(Rowindex)("Remarks")
                    Grid.Item("EntryFrom", Rowindex).Value = objtable.Rows.Item(Rowindex)("EntryFrom")
                    Grid.Item("HeadCode", Rowindex).Value = objtable.Rows.Item(Rowindex)("HeadCode")
                    If objtable.Rows.Item(Rowindex)("RP") = "R" Then
                        Rcas = Rcas + IIf(IsDBNull(objtable.Rows.Item(Rowindex)("Cash")) = True, 0, objtable.Rows.Item(Rowindex)("cASH"))
                        Radj += IIf(IsDBNull(objtable.Rows.Item(Rowindex)("Adjustment")) = True, 0, objtable.Rows.Item(Rowindex)("Adjustment"))
                        Rtot += IIf(IsDBNull(objtable.Rows.Item(Rowindex)("Total")) = True, 0, objtable.Rows.Item(Rowindex)("Total"))
                    Else
                        Pcas += IIf(IsDBNull(objtable.Rows.Item(Rowindex)("Cash")) = True, 0, objtable.Rows.Item(Rowindex)("cASH"))
                        Padj += IIf(IsDBNull(objtable.Rows.Item(Rowindex)("Adjustment")) = True, 0, objtable.Rows.Item(Rowindex)("Adjustment"))
                        Ptot += IIf(IsDBNull(objtable.Rows.Item(Rowindex)("Total")) = True, 0, objtable.Rows.Item(Rowindex)("Total"))
                    End If

                    'If IsDBNull(objtable.Rows.Item(Rowindex)("OpeningBalance")) = True Then
                    '    OB = 0
                    'Else
                    '    OB = objtable.Rows.Item(Rowindex)("OpeningBalance")
                    'End If
                    'If IsDBNull(objtable.Rows.Item(Rowindex)("ClossingBalance")) = True Then
                    '    CB = 0
                    'Else
                    '    CB = objtable.Rows.Item(Rowindex)("ClossingBalance")
                    'End If
                Next

                txtRCash.Text = Rcas
                txtRAdj.Text = Radj
                txtRtot.Text = Rtot
                txtPCash.Text = Pcas
                txtPAdj.Text = Padj
                txtPTot.Text = Ptot
                txtOB.Text = OB
                txtCB.Text = Rcas + OB - Pcas
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbRP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRP.SelectedIndexChanged
        If bool_Edit = False Then
            objVoucherEntry.CompanyCode = int_CompanyCode
            objVoucherEntry.RP = IIf(cmbRP.SelectedIndex = 0, "R", "P")
            txtVoucherNumber.Text = "" 'objVoucherEntry.BindNumber
        End If
        objvoucher = objDS("sp_VoucherEntry_Binddata @CompanyCode=" & int_CompanyCode)

    End Sub
    Private Sub binddata()
        companycode = int_CompanyCode
        cmbGroupName.RecordSet(objVoucherEntry.BindRecords.Tables(0), "GroupName", "groupCode")
        'cmbHeadName.RecordSet(objvoucher.Tables(1), "HeadName", "HeadCode")
        cmbEmpNo.RecordSet(objVoucherEntry.BindRecords.Tables(2), "strEmpNo", "MemberCode")
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If Grid.Rows.Count > 0 Then

                If e.ColumnIndex = Grid.Columns("Edit").Index Then
                    If Grid.CurrentRow.Cells("EntryFrom").Value = "V" Then
                        bool_Edit = True
                        txtVoucherCode.Text = IIf(IsDBNull(Grid.CurrentRow.Cells("VoucherCode").Value) = True, Nothing, Grid.CurrentRow.Cells("VoucherCode").Value)
                        cmbRP.SelectedIndex = IIf(Grid.CurrentRow.Cells("RP").Value = "R", 0, 1)
                        cmbHeadName.SelectedValue = Grid.CurrentRow.Cells("Headcode").Value
                        txtRemarks.Text = IIf(IsDBNull(Grid.CurrentRow.Cells("Remarks").Value) = True, "", Grid.CurrentRow.Cells("Remarks").Value)
                        txtAmount.Text = IIf(IsDBNull(Grid.CurrentRow.Cells("Cash").Value) = True, 0, Grid.CurrentRow.Cells("Cash").Value)
                        txtAdjustment.Text = IIf(IsDBNull(Grid.CurrentRow.Cells("Adjustment").Value) = True, 0, Grid.CurrentRow.Cells("Adjustment").Value)
                        cmbCashAdj.SelectedIndex = IIf(IsDBNull(Grid.CurrentRow.Cells("Cash").Value) = False, 0, 1)
                        txtAcNo.Text = objDScal("Select ACNO from tbl_VOucherEntry where vouchercode=" & Grid.CurrentRow.Cells("VoucherCode").Value)
                    Else
                        MsgBox(" Not to be Edit at here ", MsgBoxStyle.Information, Mssg)
                        cmbHeadName.Focus()
                    End If
                ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                    If Grid.CurrentRow.Cells("EntryFrom").Value = "V" Then
                        objVoucherEntry.VoucherCode = Grid.CurrentRow.Cells("VoucherCode").Value
                        objVoucherEntry.CompanyCode = int_CompanyCode
                        If MsgBox("Confirm Please ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Mssg) = MsgBoxResult.Yes Then
                            objVoucherEntry.DeleteRecords()
                            Grid.Rows.RemoveAt(Grid.CurrentRow.Index)
                        End If
                    Else
                        MsgBox(" Not to be Delete at here ", MsgBoxStyle.Information, Mssg)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try

    End Sub

    Private Sub cmbGroupName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroupName.SelectedIndexChanged
        If cmbGroupName.SelectedIndex > 0 Then
            cmbHeadName.RecordSet(objDT("select * from tbl_Head where CompanyCode=" & int_CompanyCode & " and GroupCode=" & cmbGroupName.ColData("GroupCode")), "HeadName", "HeadCode")
        Else
            cmbHeadName.RecordSet(objVoucherEntry.BindRecords.Tables(1), "HeadName", "HeadCode")
        End If
    End Sub

    Private Sub btnGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroup.Click
        frmGroup.Show_Add()
        cmbGroupName.RecordSet(objVoucherEntry.BindRecords.Tables(0), "GroupName", "groupCode")
        cmbGroupName.Focus()
    End Sub

    Private Sub btnHead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHead.Click
        frmHead.Show_Add()
        If cmbGroupName.SelectedIndex > 0 Then
            cmbHeadName.RecordSet(objDT("select * from tbl_Head where CompanyCode=" & int_CompanyCode & " and GroupCode=" & cmbGroupName.ColData("GroupCode")), "HeadName", "HeadCode")
        Else
            cmbHeadName.RecordSet(objVoucherEntry.BindRecords.Tables(1), "HeadName", "HeadCode")
        End If
        cmbHeadName.Focus()
    End Sub

    Private Sub cmbEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpNo.SelectedIndexChanged
        If cmbEmpNo.SelectedIndex > 0 Then
            txtMembername.Text = cmbEmpNo.ColData("MemberName")
        Else
            txtMembername.Text = ""
        End If

    End Sub

    Private Sub cmbEmpNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEmpNo.Validated
        If cmbEmpNo.SelectedIndex > 0 Then
            txtRemarks.Text = cmbEmpNo.Text.Trim & "  " & txtMembername.Text.Trim
        End If
    End Sub

    Private Sub btnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMember.Click
        frmMember.Show_Add()
        cmbEmpNo.RecordSet(objVoucherEntry.BindRecords.Tables(2), "strEmpNo", "MemberCode")
        cmbEmpNo.Focus()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub dtpVoucherDate_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles dtpVoucherDate.MaskInputRejected

    End Sub
End Class