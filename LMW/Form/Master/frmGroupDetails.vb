
Public Class frmGroupDetails
    Dim objGroup As New DBLayer.clsGroup

    Private Sub frmGroupDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objGroup.CompanyCode = int_CompanyCode
        Grid.RecordSet(objGroup.GetRecords(), "GroupCode,Status,CompanyCode,AccountTypeCode")
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If Grid.Rows.Count > 0 Then
                If e.ColumnIndex = Grid.Columns("Edit").Index Then
                    frmGroup.Show_Edit(Grid.CurrentRow)
                ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                    If Grid.ValueByCol("DELFLAG") = True Then
                        If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            If Grid.ValueByCol("CompanyCode") = 0 Then
                                MsgBox("Common Group Name cannot be deleted...", MsgBoxStyle.Information, Mssg)
                                Exit Sub
                            Else
                                objGroup.CompanyCode = int_CompanyCode
                                objGroup.GroupCode = Grid.ValueByCol("GroupCode")
                                Grid.RecordSet(objGroup.DeleteRecords(), "GroupCode,CompanyCode,Status,AccountTypeCode")
                            End If
                        End If
                    Else
                        MsgBox("COMMMON ENTRY CREATE BY COMPUTER CANT BE DELETE", MsgBoxStyle.Information, Mssg)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmGroup.Show_Add()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmGroupDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class