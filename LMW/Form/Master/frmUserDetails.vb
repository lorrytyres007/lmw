Imports System.Data.SqlClient

Public Class frmUserDetails
    Private Sub frmUserDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GridFill(objDT("sp_User_GetAll"))
        Delete.Visible = False
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        If e.ColumnIndex = Grid.Columns("Edit").Index Then
            frmUser.Show_Edit(Grid.CurrentRow)
        ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
            Try
                If Grid.Rows.Count > 0 Then
                    If MsgBox("Are you confirm to delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Mssg) = MsgBoxResult.Yes Then
                        objSqlCommand = New SqlCommand("sp_User_Delete", objSqlConnection)
                        objSqlCommand.CommandType = CommandType.StoredProcedure
                        objSqlCommand.Parameters.AddWithValue("@UserCode", Grid.ValueByCol("UserCode"))
                        Dim objDataTable As New DataTable
                        objSqlDataAdapter = New SqlDataAdapter(objSqlCommand)
                        objSqlDataAdapter.Fill(objDataTable)
                        objSqlDataAdapter.Dispose()
                        Call GridFill(objDataTable)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
            End Try
        End If
    End Sub

    Public Sub GridFill(ByVal objDTable As DataTable)
        For RowIndex As Integer = 0 To objDTable.Rows.Count - 1
            objDTable.Rows(RowIndex)("UserName") = Decode(objDTable.Rows(RowIndex)("UserName"))
            objDTable.Rows(RowIndex)("Password") = Decode(objDTable.Rows(RowIndex)("Password"))
            objDTable.Rows(RowIndex)("UserLevel") = IIf(Decode(objDTable.Rows(RowIndex)("UserLevel")) = "1", "ADMINISTRATOR", "LIMITED")
        Next
        Grid.DataSource = objDTable
        Grid.Columns("Password").Visible = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmUser.Show_Add()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmUserDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub
End Class