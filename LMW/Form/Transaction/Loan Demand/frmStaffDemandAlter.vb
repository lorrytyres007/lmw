Imports System.Data.SqlClient

Public Class frmStaffDemandAlter
    Dim fystarting As DateTime

    Private Sub cmbMonth_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMonth.Leave

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

    Private Sub Grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid1.CellContentClick

    End Sub

    Private Sub Grid1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid1.CellMouseClick
        If Grid1.Rows.Count > 0 Then
            txtDemandCode.Text = Grid1.CurrentRow.Cells("CDemandCode").Value
            Dim objTable As DataTable = objDT("select * from vw_LoanDemand where demandcode=" & Val(txtDemandCode.Text))
            If objTable.Rows.Count > 0 Then
                txtTokenNo.Text = objTable.Rows.Item(0)("Employeenumber")
                txtMemberName.Text = objTable.Rows.Item(0)("MemberName")
                txtLoanNo.Text = objTable.Rows.Item(0)("LoanNumber")
                txtLoanName.Text = objTable.Rows.Item(0)("LoanName")
                txtLoanAmt.Text = objTable.Rows.Item(0)("LoanAmount")
                dtpLoanDate.Value = objTable.Rows.Item(0)("Loandate")
                txtROI.Text = objTable.Rows.Item(0)("ROI")
                txtLoanOS.Text = objTable.Rows.Item(0)("LoanOS")
                txtCPrn.Text = objTable.Rows.Item(0)("Principal")
                txtCInt.Text = objTable.Rows.Item(0)("Interest")
                txtCODPrn.Text = objTable.Rows.Item(0)("ODPrincipal")
                txtCODInt.Text = objTable.Rows.Item(0)("ODInterest")
                txtPrn.Text = objTable.Rows.Item(0)("CollPrincipal")
                txtInt.Text = objTable.Rows.Item(0)("CollInterest")
                txtODPrn.Text = objTable.Rows.Item(0)("CollODPrincipal")
                txtODInt.Text = objTable.Rows.Item(0)("CollODInterest")
            End If
        End If
    End Sub

    Private Sub frmStaffDemandAlter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbMonth.SelectedIndex = 1
    End Sub

    Private Sub frmStaffDemandAlter_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'FormShown(Me)
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If cmbMonth.SelectedIndex > 0 Then
            Grid1.Rows.Clear()
            Dim objtable As DataTable = objDT("sp_LoanDemandChange @Staff=1 , @MonthNo=" & Month(dtpTo.Value) & ",@Yearno=" & Year(dtpTo.Value))
            For Rowindex As Integer = 0 To objtable.Rows.Count - 1
                Grid1.Rows.Add(1)
                Grid1.Item("CDemandCode", Grid1.Rows.Count - 1).Value = objtable.Rows.Item(Rowindex)("DemandCode")
                Grid1.Item("CFYCode", Grid1.Rows.Count - 1).Value = objtable.Rows.Item(Rowindex)("Fycode")
                Grid1.Item("CMemberCode", Grid1.Rows.Count - 1).Value = objtable.Rows.Item(Rowindex)("MemberCode")
                Grid1.Item("CLoanCode", Grid1.Rows.Count - 1).Value = objtable.Rows.Item(Rowindex)("LoanCode")
                Grid1.Item("CTokenNo", Grid1.Rows.Count - 1).Value = objtable.Rows.Item(Rowindex)("EmployeeNumber")
                Grid1.Item("CLoanNo", Grid1.Rows.Count - 1).Value = objtable.Rows.Item(Rowindex)("LoanNumber")
                Grid1.Item("CLoanosforInt", Grid1.Rows.Count - 1).Value = objtable.Rows.Item(Rowindex)("LoanOsforInt")
            Next
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Grid1.Rows.Clear()
        PanelClear(Panel6)
        PanelClear(Panel7)
        cmbMonth.SelectedIndex = 1
        cmbMonth.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            Dim objcommand As New SqlCommand("sp_LoanDemand_Update", objSqlConnection)
            objcommand.CommandType = CommandType.StoredProcedure

            objcommand.Parameters.AddWithValue("@DemandCode", Val(txtDemandCode.Text))
            objcommand.Parameters.AddWithValue("@Principal", Val(txtCPrn.Text))
            objcommand.Parameters.AddWithValue("@Interest", Val(txtCInt.Text))
            objcommand.Parameters.AddWithValue("@ODPrincipal", Val(txtCODPrn.Text))
            objcommand.Parameters.AddWithValue("@ODInterest", Val(txtCODInt.Text))
            objcommand.Parameters.AddWithValue("@LoanOs", Val(txtLoanOS.Text))
            objcommand.ExecuteNonQuery()
            MsgBox("Updated Sucessful...", MsgBoxStyle.Information, Mssg)
            btnClear_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
    End Sub
End Class