
Public Class frmCompanyDetails
    Dim objCompany As New DBLayer.clsCompany

    Private Sub frmCompanyDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCompany.CompanyCode = int_CompanyCode
        Grid.RecordSet(objCompany.GetRecords, "CompanyCode,SubCentreCode,TypingFont,CompanyName")
        'Grid.DefaultCellStyle.Font = New Font(str_TamilFont, 12)
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If e.ColumnIndex = Grid.Columns("Edit").Index Then
            ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                If Grid.Rows.Count > 0 Then
                    If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'Delete Code should be write here
                        objCompany.DeleteSubRecords()
                        Grid.RecordSet(objCompany.GetRecords, "CompanyCode,SubCentreCode,TypingFont,CompanyName")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmCompanyDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class