Imports System.Data.SqlClient
Public Class frmTDClossingDetails

    Private Sub frmTDClossingDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Grid.RecordSet(objDT("sp_TDClossing_Getall"), "TDClossingCode,MemberCode")
        If int_FYearCode < 5 Then
            Panel5.Visible = True
            Grid1.RecordSet(objDT("sp_TDRefund_Getall"), "RefundCode,MemberCode")
        Else
            Panel5.Visible = False
        End If
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If e.ColumnIndex = Grid.Columns("Edit").Index Then
                frmTDClossing.optTDClossing.Checked = True
                frmTDClossing.Show_Edit(Grid.CurrentRow)
            ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                If Grid.Rows.Count > 0 Then
                    If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim objcommand As New SqlCommand("sp_TDClossing_Delete", objSqlConnection)
                        objcommand.CommandType = CommandType.StoredProcedure

                        objcommand.Parameters.AddWithValue("@TDClossingCode", Grid.ValueByCol("TDClossingCode"))
                        objcommand.ExecuteNonQuery()
                        Grid.RecordSet(objDT("sp_TDClossing_Getall"), "TDClossingCode,MemberCode")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmTDClossing.Show_Add()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmTDClossingDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid1.CellContentClick

    End Sub

    Private Sub Grid1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid1.CellMouseClick
        Try
            If e.ColumnIndex = Grid1.Columns("Edit1").Index Then
                frmTDClossing.optRefund.Checked = True
                frmTDClossing.Show_Edit(Grid1.CurrentRow)
            ElseIf e.ColumnIndex = Grid1.Columns("Delete1").Index Then
                If Grid1.Rows.Count > 0 Then
                    If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim objcommand As New SqlCommand("sp_TDREfund_Delete", objSqlConnection)
                        objcommand.CommandType = CommandType.StoredProcedure

                        objcommand.Parameters.AddWithValue("@RefundCode", Grid1.ValueByCol("RefundCode"))
                        objcommand.ExecuteNonQuery()
                        Grid1.RecordSet(objDT("sp_TDRefund_Getall"), "RefundCode,MemberCode")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub
End Class