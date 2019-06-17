Imports System.Data.SqlClient

Public Class frmShareDeposit
    Dim Bool_Edit As Boolean
    Dim GrandTotal As Double = 0

    Private Sub dtpDepositDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDepositDate.Validated
        If dtpDepositDate.Text.Contains("  /  /") = False Then
            If CheckDate(dtpDepositDate.Value) = False Then
                MsgBox("Check the Given Date ", MsgBoxStyle.Information, Mssg)
                dtpDepositDate.Focus()
                Exit Sub
            Else

                Dim objTable As DataTable = objDT("sp_ShareDeposit_GetAll @ShareDepositDate='" & CD(dtpDepositDate.Value) & "'")
                GrandTotal = 0
                Grid.Rows.Clear()
                For Rowindex As Integer = 0 To objTable.Rows.Count - 1
                    Grid.Rows.Add(1)
                    If Val(objTable.Rows.Item(Rowindex)("ShareDepositCode")) > 0 Then
                        Grid.Item("ShareDepositCode", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("ShareDepositCode")
                    Else
                        Grid.Item("ShareDepositCode", Grid.Rows.Count - 1).Value = Nothing
                    End If

                    Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("MemberCode")
                    Grid.Item("MemberName", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("membername")
                    Grid.Item("Amount", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("Amount")
                    Grid.Item("EmpNo", Grid.Rows.Count - 1).Value = objTable.Rows.Item(Rowindex)("EmployeeNumber")
                    GrandTotal += objTable.Rows.Item(Rowindex)("Amount")
                Next
                lblGrandTotal.Text = Format(GrandTotal, "#0.00")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Bool_Edit = False
        FormClear(Me)
        dtpDepositDate.Focus()
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
        If CheckDate(dtpDepositDate.Value) = False Then
            MsgBox("Invalid Date is Given... Enter Date...", MsgBoxStyle.Information, Mssg)
            dtpDepositDate.Focus()
            Exit Sub
        End If
        If SD(dtpDepositDate.Value) <= SD(LastUpDate) Then
            MsgBox("Entry Date is with in the Updation Completed Date... Cant able to Save Now?", MsgBoxStyle.Information, Mssg)
            dtpDepositDate.Focus()
            Exit Sub
        End If
        If Val(txtAmount.Text) = 0 Then
            MsgBox("Amount is Zero", MsgBoxStyle.Information, Mssg)
            txtAmount.Focus()
            Exit Sub
        End If
        If Grid.Rows.Count = 0 Then
            MsgBox("No Entry", MsgBoxStyle.Information, Mssg)
            txtEmpNo.Focus()
            Exit Sub
        End If
        Initialise_Connection()
        Dim objTrans As SqlTransaction
        objTrans = objSqlConnection.BeginTransaction
        Try
            For rowindex As Integer = 0 To Grid.Rows.Count - 1
                Dim objCommand As New SqlCommand("sp_ShareDeposit_AddEdit", objSqlConnection, objTrans)
                objCommand.CommandType = CommandType.StoredProcedure
                If Val(Grid.Item("ShareDepositCode", rowindex).Value) > 0 Then
                    objCommand.Parameters.AddWithValue("@ShareDepositCode", Grid.Item("ShareDepositCode", rowindex).Value)
                End If
                objCommand.Parameters.AddWithValue("@Companycode", int_CompanyCode)
                objCommand.Parameters.AddWithValue("@ShareDepositDate", SD(dtpDepositDate.Value))
                objCommand.Parameters.AddWithValue("@MemberCode", Val(Grid.Item("MemberCode", rowindex).Value))
                objCommand.Parameters.AddWithValue("@Amount", Val(Grid.Item("Amount", rowindex).Value))
                objCommand.Parameters.AddWithValue("@User", int_UserCode)
                objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
                objCommand.ExecuteNonQuery()
            Next
            objTrans.Commit()
            objTrans.Dispose()

            Dim datevalue As DateTime = dtpDepositDate.Value
            btnClear_Click(sender, e)
            dtpDepositDate.Value = DateAdd(DateInterval.Day, 1, datevalue)
            dtpDepositDate.Focus()
        Catch ex As Exception
            objTrans.Rollback()
            objTrans.Dispose()
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
    End Sub

    Private Sub frmShareDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                If Grid.ValueByCol("ShareDepositCode") > 0 Then
                    objDT("sp_ShareDeposit_Delete @ShareDepositCode=" & Grid.ValueByCol("ShareDepositCode"))
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

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub txtAmount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Validated
        If Val(txtAmount.Text) > 0 Then
            If dtpDepositDate.Text.Contains("  /  /") = True Then
                MsgBox("No Date is Given Here...", MsgBoxStyle.Information, Mssg)
                dtpDepositDate.Focus()
                Exit Sub
            End If
            If CheckDate(dtpDepositDate.Value) = False Then
                MsgBox("Enter Date Correct Format", MsgBoxStyle.Information, Mssg)
                dtpDepositDate.Focus()
                Exit Sub
            End If
            If Val(txtAmount.Text) = 0 Then
                MsgBox("Enter Amount", MsgBoxStyle.Information, Mssg)
                txtAmount.Focus()
                Exit Sub
            End If
            If Val(txtEmpNo.Text) > 0 Then
                Dim sEmpNo As DataTable = objDT("sp_Member_GetAll @EmployeeNumber=" & Val(txtEmpNo.Text))
                For Rowindex As Integer = 0 To Grid.Rows.Count - 1
                    If Val(txtEmpNo.Text) = Grid.Item("EmpNo", Rowindex).Value Then
                        Grid.Rows(Rowindex).Selected = True
                        Grid.FirstDisplayedScrollingRowIndex = Rowindex
                        MsgBox("Deposit Collected Already", MsgBoxStyle.Information, Mssg)
                        txtEmpNo.Text = ""
                        txtEmpNo.Focus()
                        Exit Sub
                    End If
                Next
                If sEmpNo.Rows.Count > 0 Then
                    Grid.Rows.Add(1)
                    Grid.Item("ShareDepositCode", Grid.Rows.Count - 1).Value = Nothing
                    Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = sEmpNo.Rows.Item(0)("MemberCode")
                    Grid.Item("MemberName", Grid.Rows.Count - 1).Value = sEmpNo.Rows.Item(0)("membername")
                    Grid.Item("Amount", Grid.Rows.Count - 1).Value = Val(txtAmount.Text)
                    Grid.Item("EmpNo", Grid.Rows.Count - 1).Value = Val(txtEmpNo.Text)
                Else
                    MsgBox("No Employee Number Like this OR The Employee May Clossed TD Account...", MsgBoxStyle.Information, Mssg)
                End If
                Call Calculation()
                If Grid.Rows.Count > 0 Then Grid.Rows(Grid.Rows.Count - 1).Selected = True
                If Grid.Rows.Count > 0 Then Grid.FirstDisplayedScrollingRowIndex = Grid.Rows.Count - 1
                txtEmpNo.Text = ""
                txtEmpNo.Focus()
            End If
        End If

    End Sub
End Class