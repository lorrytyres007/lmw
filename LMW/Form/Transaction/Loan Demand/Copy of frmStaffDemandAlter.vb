Public Class frmStaffDemandAlter
    Dim fystarting As DateTime

    Private Sub cmbMonth_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMonth.Leave
        If cmbMonth.SelectedIndex > 0 Then
            Grid.Rows.Clear()
            Grid1.Rows.Clear()
            Dim objtable As DataTable = objDT("sp_LoanDemandChange @MonthNo=" & Month(dtpFrom.Value) & ",@Yearno=" & Year(dtpTo.Value))
            For Rowindex As Integer = 0 To objtable.Rows.Count - 1

            Next
        End If
    End Sub
    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        If cmbMonth.SelectedIndex > 0 Then
            'dtpCollectionDate.Enabled = True
            dtpFrom.Visible = True
            dtpTo.Visible = True
            fystarting = SD(objDScal("select Dateadd(Day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
            Dim yr As Integer = Year(fystarting)
            Dim mn As Integer = cmbMonth.SelectedIndex + 1
            Dim FD As Integer = 21
            Dim LD As Integer = 20
            If mn > 12 Then
                mn = mn - 12
                yr = yr + 1
            End If
            Dim NM As Integer = mn + 1
            Dim Yr1 As Integer = yr
            If NM > 12 Then
                NM = NM - 12
                Yr1 = Yr1 + 1
            End If
            'LD = MaxDays(mn, yr)
            dtpFrom.Value = CD(Str(FD) + "/" + Str(mn) + "/" + Str(yr))
            dtpTo.Value = CD(Str(LD) + "/" + Str(NM) + "/" + Str(Yr1))

        Else
            'dtpCollectionDate.Enabled = False
            dtpFrom.Value = Nothing
            dtpTo.Value = Nothing
            dtpFrom.Text = ""
            dtpTo.Text = ""
            dtpFrom.Visible = False
            dtpTo.Visible = False
        End If
    End Sub
End Class