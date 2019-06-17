
Public Class frmHeadDetails
    Dim objHead As New DBLayer.clsHead

    Private Sub frmHeadDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objHead.CompanyCode = int_CompanyCode
        objHead.Fycode = int_FYearCode
        Grid.RecordSet(objHead.GetRecords(), "HeadCode,GroupCode,CompanyCode,HeadOpeningCode")
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If e.ColumnIndex = Grid.Columns("Edit").Index Then
                frmHead.Show_Edit(Grid.CurrentRow)
            ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                If Grid.Rows.Count > 0 Then
                    If Grid.CurrentRow.Cells("Companycode").Value > 0 Then
                        If Grid.ValueByCol("DELFLAG") = True Then
                            If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                objHead.HeadCode = Grid.ValueByCol("HeadCode")
                                objHead.DeleteRecords()
                                objHead.CompanyCode = int_CompanyCode
                                objHead.Fycode = int_FYearCode
                                MsgBox("Deleted Successfully...", MsgBoxStyle.Information, Mssg)
                                Grid.RecordSet(objHead.GetRecords(), "HeadCode,GroupCode,CompanyCode,HeadOpeningCode")
                            End If
                        Else
                            MsgBox("Common Head Can't be Deleted", MsgBoxStyle.Information, Mssg)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmHead.Show_Add()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmHeadDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class