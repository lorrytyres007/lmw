﻿Public Class frmThriftDepositGroup
    Dim Bool_Edit As Boolean
    Dim ObjThriftDeposit As New DBLayer.clsThriftDeposit
    Dim GrandTotal As Double = 0

    Private Sub dtpDepositDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDepositDate.Validated
        If CheckDate(dtpDepositDate.Value) = False Then
            MsgBox("Check the Given Date ", MsgBoxStyle.Information, Mssg)
            dtpDepositDate.Focus()
            Exit Sub
        Else
            Dim chkdate As DateTime = "2014-10-01"


            If dtpDepositDate.Value < chkdate Then
                txtAmount.Text = "500.00"
            Else
                txtAmount.Text = "1000.00"
            End If


            Dim objTable As DataTable = objDT("sp_ThriftDeposit_GetAll @ThriftDepositDate='" & CD(dtpDepositDate.Value) & "'")
            GrandTotal = 0
            Grid.Rows.Clear()
            For Rowindex As Integer = 0 To objTable.Rows.Count - 1
                Grid.Rows.Add(1)
                If Val(objTable.Rows.Item(Rowindex)("ThriftDepositCode")) > 0 Then
                    Grid.Item("ThriftDepositCode", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("ThriftDepositCode")
                Else
                    Grid.Item("ThriftDepositCode", Grid.Rows.Count - 1).Value = Nothing
                End If

                Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("MemberCode")
                Grid.Item("MemberName", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("membername")
                Grid.Item("Amount", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("Amount")
                Grid.Item("EmpNo", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("EmployeeNumber")
                GrandTotal += objTable.Rows.Item(Rowindex)("Amount")
            Next
            lblGrandTotal.Text = Format(GrandTotal, "#0.00")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Bool_Edit = False
        Dim memamt As Double = Val(txtAmount.Text)
        FormClear(Me)
        txtAmount.Text = memamt
        dtpDepositDate.Focus()
    End Sub

    Private Sub txtEmpNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtEmpNo.Text) > 0 Then
                For rowindex As Integer = 0 To Grid.Rows.Count - 1
                    If Val(txtEmpNo.Text) = Val(Grid.Item("EmpNo", rowindex).Value) Then
                        Grid.Rows(rowindex).Selected = True
                        Grid.FirstDisplayedScrollingRowIndex = rowindex
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub txtEmpNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpNo.Validated

    End Sub
    Private Sub Calculation()
        GrandTotal = 0
        For Rowindex As Integer = 0 To Grid.Rows.Count - 1
            GrandTotal += Grid.Item("Amount", Rowindex).Value
        Next
        lblGrandTotal.Text = Format(GrandTotal, "#0.00")
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If CheckDate(dtpDepositDate.Value) = False Then
        '    MsgBox("Invalid Date is Given... Enter Date...", MsgBoxStyle.Information, Mssg)
        '    dtpDepositDate.Focus()
        '    Exit Sub
        'End If
        'If Val(txtAmount.Text) = 0 Then
        '    MsgBox("Amount is Zero", MsgBoxStyle.Information, Mssg)
        '    txtAmount.Focus()
        '    Exit Sub
        'End If
        'If Grid.Rows.Count = 0 Then
        '    MsgBox("No Entry", MsgBoxStyle.Information, Mssg)
        '    txtEmpNo.Focus()
        '    Exit Sub
        'End If
        'Try
        '    ObjThriftDeposit.ObjInput = objDT("select  ThriftDepositCode,CompanyCode, ThriftDepositDate, MemberCode, Amount from tbl_ThriftDeposit where ThriftDepositCode=0")
        '    ObjThriftDeposit.ObjInput.Rows.Clear()
        '    For rowindex As Integer = 0 To Grid.Rows.Count - 1
        '        ObjThriftDeposit.ObjInput.Rows.Add(1)
        '        If Val(Grid.Item("ThriftDepositCode", rowindex).Value) > 0 Then
        '            ObjThriftDeposit.ObjInput.Rows.Item(ObjThriftDeposit.ObjInput.Rows.Count - 1)("ThriftDepositCode") = Grid.Item("ThriftDepositCode", rowindex).Value
        '        Else
        '            ObjThriftDeposit.ObjInput.Rows.Item(ObjThriftDeposit.ObjInput.Rows.Count - 1)("ThriftDepositCode") = 0
        '        End If
        '        ObjThriftDeposit.ObjInput.Rows.Item(ObjThriftDeposit.ObjInput.Rows.Count - 1)("Companycode") = int_CompanyCode
        '        ObjThriftDeposit.ObjInput.Rows.Item(ObjThriftDeposit.ObjInput.Rows.Count - 1)("thriftdepositDate") = SD(dtpDepositDate.Value)
        '        ObjThriftDeposit.ObjInput.Rows.Item(ObjThriftDeposit.ObjInput.Rows.Count - 1)("MemberCode") = Grid.Item("MemberCode", rowindex).Value
        '        ObjThriftDeposit.ObjInput.Rows.Item(ObjThriftDeposit.ObjInput.Rows.Count - 1)("Amount") = Grid.Item("Amount", rowindex).Value
        '    Next
        '    ObjThriftDeposit.user = int_UserCode
        '    ObjThriftDeposit.node = int_NodeCode
        '    ObjThriftDeposit.SaveRecords()
        '    Dim datevalue As DateTime = dtpDepositDate.Value
        '    btnClear_Click(sender, e)
        '    dtpDepositDate.Value = DateAdd(DateInterval.Day, 1, datevalue)
        '    dtpDepositDate.Focus()
        'Catch ex As Exception
        '    If ex.Message.Contains("UK_tbl_ThriftDeposit") Then
        '        MsgBox("Already paid for this month", MsgBoxStyle.Information, Mssg)
        '    Else
        '        MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        '    End If
        'End Try
    End Sub

    Private Sub frmThriftDepositGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad(Me, Bool_Edit, "Thrift Deposit Entry Details", False)

    End Sub

    Private Sub txtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEmpNo.Focus()
        End If
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        If e.ColumnIndex = Grid.Columns("Delete").Index Then
            If MsgBox("Are You Sure?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Mssg) = MsgBoxResult.Yes Then
                If Grid.ValueByCol("ThriftDepositCode") > 0 Then
                    objDT("sp_ThriftDeposit_Delete @ThriftDepositCode=" & Grid.ValueByCol("ThriftDepositCode"))
                    Grid.Rows.Remove(Grid.CurrentRow)
                Else
                    Grid.Rows.Remove(Grid.CurrentRow)
                End If
                Call Calculation()
                MsgBox("Deleted Successfully...", MsgBoxStyle.Information, Mssg)
                txtEmpNo.Text = ""
                txtEmpNo.Focus()
            End If
        End If
    End Sub

    Private Sub btnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMember.Click
        frmMember.Show_Add()
        txtEmpNo.Focus()
    End Sub

    Private Sub dtpDepositDate_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles dtpDepositDate.MaskInputRejected

    End Sub

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub txtAmount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Validated
        If Val(txtAmount.Text) > 0 Then
            If CheckDate(dtpDepositDate.Value) = False Then
                MsgBox("Enter Date Correct Format", MsgBoxStyle.Information, Mssg)
                dtpDepositDate.Focus()
                Exit Sub
            End If
            Dim objEmpno As DataTable = objDT("Select * from tbl_Member where status=1")
            For Rowindex As Integer = 0 To objEmpno.Rows.Count - 1
                Grid.Rows.Add(1)
                Grid.Item("ThriftDepositCode", Grid.Rows.Count - 1).Value = Nothing
                Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objEmpno.Rows.Item(Rowindex)("MemberCode")
                Grid.Item("MemberName", Grid.Rows.Count - 1).Value = objEmpno.Rows.Item(Rowindex)("membername")
                Grid.Item("Amount", Grid.Rows.Count - 1).Value = Val(txtAmount.Text)
                Grid.Item("EmpNo", Grid.Rows.Count - 1).Value = Val(objEmpno.Rows.Item(Rowindex)("EmployeeNumber"))
                Call Calculation()
            Next
        End If
    End Sub
End Class