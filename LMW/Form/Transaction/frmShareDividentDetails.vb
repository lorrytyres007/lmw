Imports System.Data.SqlClient
Public Class frmShareDividentDetails
    Dim Fromdate As DateTime = objDScal("SELECT FYSTART FROM TBL_FYEAR WHERE FYCODE= " & int_FYearCode)
    Dim Todate As DateTime = objDScal("SELECT FYEND FROM TBL_FYEAR WHERE FYCODE= " & int_FYearCode)

    Private Sub frmShareDividentDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Grid.RecordSet(objDT("sp_ShareDivident_Getall @FROMDATE='" & SD(Fromdate) & "',@TODATE='" & SD(Todate) & "'"), "ShareDividentCode,MemberCode")
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If e.ColumnIndex = Grid.Columns("Edit").Index Then
                frmShareDivident.Show_Edit(Grid.CurrentRow)
            ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                If Grid.Rows.Count > 0 Then
                    If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim objcommand As New SqlCommand("sp_ShareDivident_Delete", objSqlConnection)
                        objcommand.CommandType = CommandType.StoredProcedure

                        objcommand.Parameters.AddWithValue("@ShareDividentCode", Grid.ValueByCol("ShareDividentCode"))
                        objcommand.ExecuteNonQuery()
                        Grid.RecordSet(objDT("sp_ShareDivident_Getall @FROMDATE='" & SD(Fromdate) & "',@TODATE='" & SD(Todate) & "'"), "ShareDividentCode,MemberCode")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmShareDivident.Show_Add()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmShareDividentDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub
End Class