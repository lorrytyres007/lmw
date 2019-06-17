Public Class frmUpdationLock

  
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If SD(LastUpDate) < SD(dtpUpdationDate.Value) Then
            If MsgBox("Confirm to Lock all Data Entry Forms to this Date", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Mssg) = MsgBoxResult.Yes Then
                objDT("Update tbl_LastUpdate set UpdationDate=" & SD(dtpUpdationDate.Value))
                LastUpDate = SD(dtpUpdationDate.Value)
                btnExit_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub frmUpdationLock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpUpdationDate.Value = LastUpDate
    End Sub
End Class