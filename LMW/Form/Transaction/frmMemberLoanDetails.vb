Imports System.Data.SqlClient

Public Class frmMemberLoanDetails
    'Dim objMemberLoan As New DBLayer.clsMemberLoan

    Private Sub frmMemberLoanDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Grid.RecordSet(objDT("Sp_MemberLoan_GetAll"), "MemberCode,LoanCode,number,membername_Tamil,LoanNameCode,StrLoanNumber,LoanClossedStatus,Demand")
        Grid.RowTemplate.Height = 41
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If Grid.Rows.Count > 0 Then
                Dim objFind As DataTable = objDT("select * from tbl_LoanDemand where LoanCode=" & Grid.ValueByCol("LoanCode"))
                If e.ColumnIndex = Grid.Columns("Edit").Index Then
                    If objFind.Rows.Count = 0 Then
                        frmMemberLoan.Show_Edit(Grid.CurrentRow)
                    Else
                        MsgBox("Demand Rised for " & objFind.Rows.Count & " Months. Sorry! Can't able to Edit...", MsgBoxStyle.Information, Mssg)
                        Exit Sub
                    End If

                ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                    objFind = objDT("select * from tbl_LoanDemand where LoanCode=" & Grid.ValueByCol("LoanCode"))
                    If objFind.Rows.Count = 0 Then
                        If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            objDT("sp_MemberLoan_Delete @LoanCode=" & Grid.ValueByCol("LoanCode"))
                            Grid.RecordSet(objDT("sp_MemberLoan_Getall"), "MemberCode,LoanCode,number,membername_Tamil,LoanNameCode,StrLoanNumber,LoanClossedStatus,Demand")
                            Grid.RowTemplate.Height = 32
                        End If
                    Else
                        MsgBox("Demand Rised for " & objFind.Rows.Count & " Months. Sorry! Can't able to Delete...", MsgBoxStyle.Information, Mssg)
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmMemberLoan.Show_Add()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmMemberLoanDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub txtFindEmpno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindEmpno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtFindEmpno.Text) > 0 Then
                For Rowindex As Integer = 0 To Grid.Rows.Count - 1
                    Grid.Rows(Rowindex).Selected = True
                    Grid.FirstDisplayedScrollingRowIndex = Rowindex
                    'Application.DoEvents()
                    If Val(txtFindEmpno.Text) = Grid.Item("EmployeeNumber", Rowindex).Value Then
                        Exit For
                    End If
                Next
            Else
                Grid.Rows(0).Selected = True
                Grid.FirstDisplayedScrollingRowIndex = 0
            End If
        End If
    End Sub

    Private Sub txtFindEmpno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFindEmpno.TextChanged

    End Sub

    Private Sub txtFindTokNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindTokNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtFindTokNo.Text) > 0 Then
                For Rowindex As Integer = 0 To Grid.Rows.Count - 1
                    Grid.Rows(Rowindex).Selected = True
                    Grid.FirstDisplayedScrollingRowIndex = Rowindex
                    'Application.DoEvents()
                    If Val(txtFindTokNo.Text) = Grid.Item("LoanNumber", Rowindex).Value Then
                        Exit For
                    End If
                Next
            Else
                Grid.Rows(0).Selected = True
                Grid.FirstDisplayedScrollingRowIndex = 0
            End If
        End If
    End Sub

    Private Sub txtFindTokNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFindTokNo.TextChanged

    End Sub
End Class