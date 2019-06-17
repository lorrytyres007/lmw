
Public Class frmStateDetails
    Dim objState As New DBLayer.clsState

    Private Sub frmStateDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Grid.RecordSet(objState.GetRecords, "StateCode")
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If e.ColumnIndex = Grid.Columns("Edit").Index Then
                'frmSettings.Show_Edit(Grid.CurrentRow)
            ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                If Grid.Rows.Count > 0 Then
                    If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        objState.StateCode = Grid.ValueByCol("StateCode")
                        Grid.RecordSet(objState.DeleteRecords(), "StateCode")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'frmSettings.Show_Add()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmStateDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class