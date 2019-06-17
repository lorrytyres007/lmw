Public Class frmEMI_ChangeDetails

    Private Sub frmEMI_ChangeDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid.RecordSet(objDT("sp_EMIChange_GetAll"), "MemberCode,LoanCode")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmCompanyDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmEmiChange.show_Add()
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If e.ColumnIndex = Grid.Columns("Edit").Index Then
                Dim MaxCode As Integer = objDScal("Select isnull(max(EMIChangeCode),0) from tbl_EMIChange where LoanCode=" & Grid.CurrentRow.Cells("LoanCode").Value)
                If MaxCode > Grid.CurrentRow.Cells("EMIChangeCode").Value Then
                    MsgBox("Sorry!... selected row of Loan No is old...", MsgBoxStyle.Information, Mssg)
                    Exit Sub
                End If
                frmEmiChange.show_Edit(Grid.CurrentRow)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub
End Class