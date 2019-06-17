Imports System.Data.SqlClient

Public Class frmWorkerLoanCollection
    Dim fystarting As DateTime

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        If cmbMonth.SelectedIndex > 0 Then
            dtpCollectionDate.Enabled = True
            dtpFrom.Visible = True
            dtpTo.Visible = True
            fystarting = SD(objDScal("select Dateadd(Day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
            Dim yr As Integer = Year(fystarting)
            Dim mn As Integer = cmbMonth.SelectedIndex + 2
            Dim FD As Integer = 1
            Dim LD As Integer = 20
            If mn > 12 Then
                mn = mn - 12
                yr = yr + 1
            End If
            LD = MaxDays(mn, yr)
            dtpFrom.Value = CD(Str(FD) + "/" + Str(mn) + "/" + Str(yr))
            dtpTo.Value = CD(Str(LD) + "/" + Str(mn) + "/" + Str(yr))
        Else
            dtpCollectionDate.Enabled = False
            dtpFrom.Value = Nothing
            dtpTo.Value = Nothing
            dtpFrom.Text = ""
            dtpTo.Text = ""
            dtpFrom.Visible = False
            dtpTo.Visible = False
        End If
    End Sub

    Private Sub frmWorkerLoanCollection_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub frmWorkerLoanCollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbMonth.SelectedIndex = 0
        cmbDemandType.SelectedIndex = 0
        cmbTokenNo.RecordSet(objDT("sp_member_getall @Worker=1"), "strEmpno", "MemberCode")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnview_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        If cmbDemandType.SelectedIndex = 0 Then
            MsgBox("Select Demand Type", MsgBoxStyle.Information, Mssg)
            cmbDemandType.Focus()
            Exit Sub
        End If
        If cmbTokenNo.SelectedIndex > 0 Then
            If IsDate(dtpUpdationDate.Value) = False Then
                MsgBox("Updation Date is Wrong...", MsgBoxStyle.Information, Mssg)
                dtpUpdationDate.Focus()
                Exit Sub
            End If
        End If
        If IsDate(dtpCollectionDate.Value) = False Then
            MsgBox("Collection Date is Wrong...", MsgBoxStyle.Information, Mssg)
            dtpCollectionDate.Focus()
            Exit Sub
        End If
        If cmbTokenNo.SelectedIndex = 0 Then
            Try
                Dim objColl As DataTable
                If cmbTokenNo.SelectedIndex = 0 Then
                    objColl = objDT("sp_Collection @DemandType=" & cmbDemandType.SelectedIndex & ",@StaffLoan=0,@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")
                Else
                    objColl = objDT("sp_Collection @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@StaffLoan=0,@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")
                End If

                Grid.Rows.Clear()
                If objColl.Rows.Count > 0 Then
                    For RowID As Integer = 0 To objColl.Rows.Count - 1

                        'If Val(objColl.Rows.Item(RowID)("Total")) > 0 Then
                        Dim currInt As Double = objColl.Rows.Item(RowID)("Total")
                        If pnlUpDate.Visible = True Then

                            'currInt=currInt+ SI_EmiDay(
                        End If
                        Grid.Rows.Add(1)
                        If cmbTokenNo.SelectedIndex > 0 Then
                            Grid.Item("DemandCode", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("DemandCode")
                        End If
                        Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberCode")
                        Grid.Item("EmployeeNumber", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("EmployeeNumber")
                        Grid.Item("EmployeeName", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberName")
                        Grid.Item("TokenNo", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Number")

                        Grid.Item("FixedDemand", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FixedDemand")
                        Grid.Item("JLDemand", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLDemand")
                        Grid.Item("LoanDemand", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanDemand")
                        If cmbDemandType.SelectedIndex = 0 Then
                            Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
                            Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
                            'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("TotalOs")
                        ElseIf cmbDemandType.SelectedIndex = 1 Then  'Fixed
                            Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FixedDemand")
                            Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FixedDemand")
                            'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FDLoanOs")

                        ElseIf cmbDemandType.SelectedIndex = 2 Then  'JL
                            Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLDemand")
                            Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLDemand")
                            'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLLoanOs")
                        ElseIf cmbDemandType.SelectedIndex = 3 Then  'Loan Demand
                            Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanDemand")
                            Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanDemand")
                            'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
                        End If

                        'End If
                    Next
                    Call CalsiTotal()
                    Grid.Columns("Collection").DataGridView.BackColor = Color.YellowGreen
                    If Grid.Rows.Count > 0 Then
                        Grid.Rows(0).Selected = True
                        Grid.FirstDisplayedScrollingRowIndex = 0
                    End If
                    Grid.Enabled = True
                Else
                    MsgBox("No Entry on this Demand...", MsgBoxStyle.Information, Mssg)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End Try
        Else
            Try
                Dim objColl As DataTable
                objColl = objDT("sp_Collection @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@StaffLoan=0,@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")

                Grid1.Rows.Clear()
                If objColl.Rows.Count > 0 Then
                    For RowID As Integer = 0 To objColl.Rows.Count - 1

                        'If Val(objColl.Rows.Item(RowID)("Total")) > 0 Then
                        Dim currInt As Double = objColl.Rows.Item(RowID)("Total")
                        If pnlUpDate.Visible = True Then

                            'currInt=currInt+ SI_EmiDay(
                        End If
                        Grid1.Rows.Add(1)
                        If cmbTokenNo.SelectedIndex > 0 Then
                            Grid1.Item("DemandCode1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("DemandCode")
                        End If
                        Grid1.Item("MemberCode1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberCode")
                        Grid1.Item("TokenNo1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("EmployeeNumber")
                        Grid1.Item("EmpName1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberName")
                        Grid1.Item("MNo1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Number")
                        Grid1.Item("OutStanding1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanOS")

                        Grid1.Item("LoanCode", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Loancode")
                        Grid1.Item("LoanNo", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanNumber")
                        Grid1.Item("LoanName", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanName")
                        Grid1.Item("Principle", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Principal")
                        Grid1.Item("Int", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Interest")
                        Grid1.Item("Total1", Grid1.Rows.Count - 1).Value = Val(objColl.Rows.Item(RowID)("Total"))
                        'If cmbDemandType.SelectedIndex = 0 Then
                        '    Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
                        '    Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
                        '    'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("TotalOs")
                        'ElseIf cmbDemandType.SelectedIndex = 1 Then  'Fixed
                        '    Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FixedDemand")
                        '    Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FixedDemand")
                        '    'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FDLoanOs")

                        'ElseIf cmbDemandType.SelectedIndex = 2 Then  'JL
                        '    Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLDemand")
                        '    Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLDemand")
                        '    'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLLoanOs")
                        'ElseIf cmbDemandType.SelectedIndex = 3 Then  'Loan Demand
                        '    Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanDemand")
                        '    Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanDemand")
                        '    'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
                        'End If

                        'End If
                    Next
                    Call CalsiTotal()
                    Grid1.Columns("Collection1").DataGridView.BackColor = Color.YellowGreen
                    If Grid1.Rows.Count > 0 Then
                        Grid1.Rows(0).Selected = True
                        Grid1.FirstDisplayedScrollingRowIndex = 0
                    End If
                    Grid1.Enabled = True
                Else
                    MsgBox("No Entry on this Demand...", MsgBoxStyle.Information, Mssg)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End Try


        End If
    End Sub
    Private Sub CalsiTotal()
        Dim DAmt As Double = 0
        Dim CAmt As Double = 0
        For rowindex As Integer = 0 To Grid.Rows.Count - 1
            DAmt += Val(Grid.Item("Total", rowindex).Value)
            CAmt += Val(Grid.Item("Collection", rowindex).Value)
        Next
        txtDemandAmt.Text = Format(DAmt, "#0.00")
        txtCollectionAmt.Text = Format(CAmt, "#0.00")
        txtBalAmt.Text = Format(DAmt - CAmt, "#0.00")
        If Val(txtDemandAmt.Text) = 0 Then
            MsgBox("Collection Entry Already Finished...", MsgBoxStyle.Information, Mssg)
        End If
    End Sub

    Private Sub dtpCollectionDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpCollectionDate.Validated
        If IsDate(dtpCollectionDate.Value) = True Then
            If dtpCollectionDate.Value <= dtpTo.Value Then
                MsgBox("Given Collection Date is Wrong... Please Check it...", MsgBoxStyle.Information, Mssg)
                dtpCollectionDate.Focus()
            Else
                btnView.Focus()
            End If
        End If
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Leave
        Call CalsiTotal()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If Val(txtCollectionAmt.Text) <> Val(txtMillColection.Text) Then
        '    MsgBox("Collection Amount is not Tally with Mill side Collection ....", MsgBoxStyle.Information, Mssg)
        '    If Val(txtMillColection.Text) > 0 Then
        '        Grid.Focus()
        '        Exit Sub
        '    Else
        '        txtMillColection.Focus()
        '        Exit Sub
        '    End If
        'End If

        'If Grid.Rows.Count = 0 Then
        '    MsgBox("No Records to Save ...Sorry!...", MsgBoxStyle.Information, Mssg)
        '    If cmbMonth.SelectedIndex = 0 Then
        '        cmbMonth.Focus()
        '        Exit Sub
        '    End If
        '    If IsDate(dtpCollectionDate.Value) = True Then
        '        If dtpCollectionDate.Value <= dtpTo.Value Then
        '            dtpCollectionDate.Focus()
        '            Exit Sub
        '        Else
        '            btnView.Focus()
        '            Exit Sub
        '        End If
        '    End If
        'End If

        'Initialise_Connection()
        'Dim objDemand As DataTable
        ''= objDT("sp_Collection @Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")
        ''
        'Dim objTrans As SqlTransaction
        'objTrans = objSqlConnection.BeginTransaction
        'Try
        '    For Rowindex As Integer = 0 To Grid.Rows.Count - 1
        '        If Grid.Item("collection", Rowindex).Value > 0 Then
        '            Dim objCommand As New SqlCommand("sp_DemandCollection_AddEdit", objSqlConnection, objTrans)
        '            objCommand.CommandType = CommandType.StoredProcedure

        '            objCommand.Parameters.AddWithValue("@Membercode", Val(Grid.Item("MemberCode", Rowindex).Value))
        '            objCommand.Parameters.AddWithValue("@FixedDemand", Val(Grid.Item("FixedDemand", Rowindex).Value))
        '            objCommand.Parameters.AddWithValue("@JLDemand", Val(Grid.Item("JLDemand", Rowindex).Value))
        '            objCommand.Parameters.AddWithValue("@LoanDemand", Val(Grid.Item("LoanDemand", Rowindex).Value))
        '            objCommand.Parameters.AddWithValue("@Total", Val(Grid.Item("Total", Rowindex).Value))
        '            objCommand.Parameters.AddWithValue("@Collection", Val(Grid.Item("Collection", Rowindex).Value))
        '            objCommand.Parameters.AddWithValue("@Datefrom", SD(dtpFrom.Value))
        '            objCommand.Parameters.AddWithValue("@Dateto", SD(dtpTo.Value))
        '            objCommand.Parameters.AddWithValue("@DemandMonth", Month(dtpFrom.Value))
        '            objCommand.Parameters.AddWithValue("@User", int_UserCode)
        '            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
        '            objCommand.ExecuteNonQuery()
        '        End If
        '    Next
        '    objTrans.Commit()
        '    objTrans.Dispose()
        'Catch ex As Exception
        '    objTrans.Rollback()
        '    objTrans.Dispose()
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        'End Try
        'Try
        '    For rowindex As Integer = 0 To Grid.Rows.Count - 1
        '        Dim DType As Integer = 0
        '        Dim Amt As Double = 0
        '        If Grid.Columns("FixedDemand").Visible = True Then
        '            DType = 1
        '        ElseIf Grid.Columns("JLDemand").Visible = True Then
        '            DType = 2
        '        ElseIf Grid.Columns("LoanDemand").Visible = True Then
        '            DType = 3
        '        End If
        '        objDemand = objDT("select * from vw_LoanDemand where DemandType=" & DType & " and membercode=" & Val(Grid.Item("MemberCode", rowindex).Value) & " and DateFrom>='" & SD(dtpFrom.Value) & "' and DateTo<='" & SD(dtpTo.Value) & "' and WorkerLoan=1")

        '        If Grid.Item("collection", rowindex).Value > 0 Then
        '            If Grid.Columns("FixedDemand").Visible = True Then
        '                If Grid.Item("FixedDemand", rowindex).Value > 0 Then
        '                    Amt = Grid.Item("FixedDemand", rowindex).Value
        '                    DType = 1
        '                End If
        '            ElseIf Grid.Columns("JLDemand").Visible = True Then
        '                If Grid.Item("JLDemand", rowindex).Value > 0 Then
        '                    Amt = Grid.Item("JLDemand", rowindex).Value
        '                    DType = 2
        '                End If
        '            ElseIf Grid.Columns("LoanDemand").Visible = True Then
        '                If Grid.Item("LoanDemand", rowindex).Value > 0 Then
        '                    Amt = Grid.Item("LoanDemand", rowindex).Value
        '                    DType = 3
        '                End If
        '            End If

        '            For Rowid As Integer = 0 To objDemand.Rows.Count - 1
        '                If Amt > 0 Then
        '                    objDT("update tbl_LoanDemand set CollDate='" & SD(dtpCollectionDate.Value) & "' where demandCode=" & objDemand.Rows.Item(Rowid)("DemandCode"))
        '                End If
        '                If Amt >= Val(objDemand.Rows.Item(Rowid)("ODInterest")) Then
        '                    objDT("update tbl_LoanDemand set CollODInterest= OdInterest  where demandCode=" & objDemand.Rows.Item(Rowid)("DemandCode"))
        '                    Amt = Amt - Val(objDemand.Rows.Item(Rowid)("ODInterest"))
        '                Else
        '                    objDT("update tbl_LoanDemand set CollODInterest= " & Amt & "  where demandCode=" & objDemand.Rows.Item(Rowid)("DemandCode"))
        '                    Amt = 0
        '                End If
        '                If Amt >= Val(objDemand.Rows.Item(Rowid)("ODPrincipal")) Then
        '                    objDT("update tbl_LoanDemand set CollODPrincipal= ODPrincipal  where demandCode=" & objDemand.Rows.Item(Rowid)("DemandCode"))
        '                    Amt = Amt - Val(objDemand.Rows.Item(Rowid)("ODPrincipal"))
        '                Else
        '                    objDT("update tbl_LoanDemand set CollODPrincipal= " & Amt & "  where demandCode=" & objDemand.Rows.Item(Rowid)("DemandCode"))
        '                    Amt = Amt - 0
        '                End If
        '                If Amt >= Val(objDemand.Rows.Item(Rowid)("Interest")) Then
        '                    objDT("update tbl_LoanDemand set CollInterest= Interest  where demandCode=" & objDemand.Rows.Item(Rowid)("DemandCode"))
        '                    Amt = Amt - Val(objDemand.Rows.Item(Rowid)("Interest"))
        '                Else
        '                    objDT("update tbl_LoanDemand set CollInterest= " & Amt & "  where demandCode=" & objDemand.Rows.Item(Rowid)("DemandCode"))
        '                    Amt = 0
        '                End If
        '                If Amt > 0 Then 'Val(objDemand.Rows.Item(Rowid)("Principal")) Then
        '                    objDT("update tbl_LoanDemand set Collos= collos -" & Amt & ",CollPrincipal= " & Amt & ",LoanOS=LoanOS-" & Amt & ",LoanOSforInt=LoanOSforInt-" & Amt & "  where demandCode=" & objDemand.Rows.Item(Rowid)("DemandCode"))
        '                    Amt = 0
        '                End If
        '            Next
        '        End If
        '    Next
        '    MsgBox("Collection Updated Successfully...", MsgBoxStyle.Information, Mssg)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        'End Try

        If Val(txtCollectionAmt.Text) <> Val(txtMillColection.Text) Then
            MsgBox("Collection Amount is not Tally with Mill side Collection ....", MsgBoxStyle.Information, Mssg)
            If Val(txtMillColection.Text) > 0 Then
                Grid.Focus()
                Exit Sub
            Else
                txtMillColection.Focus()
                Exit Sub
            End If
        End If
        If IsDate(dtpCollectionDate.Value) = False Or dtpCollectionDate.Text = "  /  /" Then
            MsgBox("Type Collection Date...", MsgBoxStyle.Information, Mssg)
            dtpCollectionDate.Focus()
            Exit Sub
        End If

        If Grid.Rows.Count = 0 Then
            MsgBox("No Records to Save ...Sorry!...", MsgBoxStyle.Information, Mssg)
            If cmbMonth.SelectedIndex = 0 Then
                cmbMonth.Focus()
                Exit Sub
            End If
            If IsDate(dtpCollectionDate.Value) = True Then
                If dtpCollectionDate.Value <= dtpTo.Value Then
                    dtpCollectionDate.Focus()
                    Exit Sub
                Else
                    btnView.Focus()
                    Exit Sub
                End If
            End If
        End If

        Initialise_Connection()
        Dim objDemand As DataTable = Nothing
        '= objDT("sp_Collection @Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")
        '
        Dim DType As Integer = 0
        Dim Amt As Double = 0
        If Grid.Columns("FixedDemand").Visible = True Then
            DType = 1
        ElseIf Grid.Columns("JLDemand").Visible = True Then
            DType = 2
        ElseIf Grid.Columns("LoanDemand").Visible = True Then
            DType = 3
        End If
        Dim objLoan As DataTable
        Dim objTrans As SqlTransaction
        objTrans = objSqlConnection.BeginTransaction
        Try
            For Rowindex As Integer = 0 To Grid.Rows.Count - 1
                If Val(Grid.Item("collection", Rowindex).Value) > 0 Then

                    Dim objCommand As New SqlCommand("sp_DemandCollection_AddEdit", objSqlConnection, objTrans)
                    objCommand.CommandType = CommandType.StoredProcedure

                    objCommand.Parameters.AddWithValue("@Membercode", Val(Grid.Item("MemberCode", Rowindex).Value))
                    If DType = 1 Then
                        objCommand.Parameters.AddWithValue("@FixedDemand", Val(Grid.Item("FixedDemand", Rowindex).Value))
                        objCommand.Parameters.AddWithValue("@JLDemand", 0)
                        objCommand.Parameters.AddWithValue("@LoanDemand", 0)
                    End If
                    If DType = 2 Then
                        objCommand.Parameters.AddWithValue("@JLDemand", Val(Grid.Item("JLDemand", Rowindex).Value))
                        objCommand.Parameters.AddWithValue("@FixedDemand", 0)
                        objCommand.Parameters.AddWithValue("@LoanDemand", 0)
                    End If
                    If DType = 3 Then
                        objCommand.Parameters.AddWithValue("@LoanDemand", Val(Grid.Item("LoanDemand", Rowindex).Value))
                        objCommand.Parameters.AddWithValue("@FixedDemand", 0)
                        objCommand.Parameters.AddWithValue("@JLDemand", 0)
                    End If
                    objCommand.Parameters.AddWithValue("@Total", Val(Grid.Item("Total", Rowindex).Value))
                    objCommand.Parameters.AddWithValue("@Collection", Val(Grid.Item("Collection", Rowindex).Value))
                    objCommand.Parameters.AddWithValue("@Datefrom", SD(dtpFrom.Value))
                    objCommand.Parameters.AddWithValue("@Dateto", SD(dtpTo.Value))
                    objCommand.Parameters.AddWithValue("@DemandMonth", Month(dtpFrom.Value))
                    objCommand.Parameters.AddWithValue("@DemandYear", Year(dtpFrom.Value))
                    objCommand.Parameters.AddWithValue("@User", int_UserCode)
                    objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
                    objCommand.ExecuteNonQuery()


                    Dim objcmd As New SqlCommand("sp_DC", objSqlConnection, objTrans)
                    objcmd.CommandType = CommandType.StoredProcedure
                    objcmd.Parameters.AddWithValue("@Fromdate", SD(dtpFrom.Value))
                    objcmd.Parameters.AddWithValue("@Todate", SD(dtpTo.Value))
                    objcmd.Parameters.AddWithValue("@DType", DType)
                    objcmd.Parameters.AddWithValue("@Demand", 1)
                    objcmd.Parameters.AddWithValue("@MemberCode", Val(Grid.Item("MemberCode", Rowindex).Value))
                    objLoan = objDT(objcmd)


                    Amt = Grid.Item("Collection", Rowindex).Value
                    If Amt > 0 Then
                        For RowID As Integer = 0 To objLoan.Rows.Count - 1
                            Dim CollDate As DateTime = SD(dtpCollectionDate.Value)
                            Dim ODInt As Double = 0
                            Dim ODPrn As Double = 0
                            Dim CollInt As Double = 0
                            Dim CollPrn As Double = 0
                            If Val(objLoan.Rows.Item(RowID)("ODInterest")) > 0 Then
                                If Amt >= Val(objLoan.Rows.Item(RowID)("ODInterest")) Then
                                    ODInt = Val(objLoan.Rows.Item(RowID)("ODInterest"))
                                    Amt = Amt - Val(objLoan.Rows.Item(RowID)("ODInterest"))
                                Else
                                    ODInt = Amt
                                    Amt = 0
                                End If
                                Dim objCommand1 As New SqlCommand("sp_LoanDemand_Collection_Update", objSqlConnection, objTrans)
                                objCommand1.CommandType = CommandType.StoredProcedure
                                objCommand1.Parameters.AddWithValue("@DemandCode", Val(objLoan.Rows.Item(RowID)("DemandCode")))

                                objCommand1.Parameters.AddWithValue("@CollectionDate", SD(CollDate))
                                objCommand1.Parameters.AddWithValue("@ODPrincipal", ODPrn)
                                objCommand1.Parameters.AddWithValue("@ODInterest", ODInt)
                                objCommand1.Parameters.AddWithValue("@Principal", CollPrn)
                                objCommand1.Parameters.AddWithValue("@Interest", CollInt)
                                objCommand1.ExecuteNonQuery()
                            End If
                        Next
                    End If

                    If Amt > 0 Then
                        For RowID As Integer = 0 To objLoan.Rows.Count - 1
                            Dim CollDate As DateTime = SD(dtpCollectionDate.Value)
                            Dim ODInt As Double = 0
                            Dim ODPrn As Double = 0
                            Dim CollInt As Double = 0
                            Dim CollPrn As Double = 0
                            If Val(objLoan.Rows.Item(RowID)("ODPrincipal")) > 0 Then
                                If Amt >= Val(objLoan.Rows.Item(RowID)("ODPrincipal")) Then
                                    ODPrn = Val(objLoan.Rows.Item(RowID)("ODPrincipal"))
                                    Amt = Amt - Val(objLoan.Rows.Item(RowID)("ODPrincipal"))
                                Else
                                    ODPrn = Amt
                                    Amt = 0
                                End If
                                Dim objCommand1 As New SqlCommand("sp_LoanDemand_Collection_Update", objSqlConnection, objTrans)
                                objCommand1.CommandType = CommandType.StoredProcedure
                                objCommand1.Parameters.AddWithValue("@DemandCode", Val(objLoan.Rows.Item(RowID)("DemandCode")))

                                objCommand1.Parameters.AddWithValue("@CollectionDate", SD(CollDate))
                                objCommand1.Parameters.AddWithValue("@ODPrincipal", ODPrn)
                                objCommand1.Parameters.AddWithValue("@ODInterest", ODInt)
                                objCommand1.Parameters.AddWithValue("@Principal", CollPrn)
                                objCommand1.Parameters.AddWithValue("@Interest", CollInt)
                                objCommand1.ExecuteNonQuery()
                            End If
                        Next
                    End If

                    If Amt > 0 Then
                        For RowID As Integer = 0 To objLoan.Rows.Count - 1
                            Dim CollDate As DateTime = SD(dtpCollectionDate.Value)
                            Dim ODInt As Double = 0
                            Dim ODPrn As Double = 0
                            Dim CollInt As Double = 0
                            Dim CollPrn As Double = 0

                            If Val(objLoan.Rows.Item(RowID)("Interest")) > 0 Then
                                If Amt >= Val(objLoan.Rows.Item(RowID)("Interest")) Then
                                    CollInt = Val(objLoan.Rows.Item(RowID)("Interest"))
                                    Amt = Amt - Val(objLoan.Rows.Item(RowID)("Interest"))
                                Else
                                    CollInt = Amt
                                    Amt = 0
                                End If
                                Dim objCommand1 As New SqlCommand("sp_LoanDemand_Collection_Update", objSqlConnection, objTrans)
                                objCommand1.CommandType = CommandType.StoredProcedure
                                objCommand1.Parameters.AddWithValue("@DemandCode", Val(objLoan.Rows.Item(RowID)("DemandCode")))

                                objCommand1.Parameters.AddWithValue("@CollectionDate", SD(CollDate))
                                objCommand1.Parameters.AddWithValue("@ODPrincipal", ODPrn)
                                objCommand1.Parameters.AddWithValue("@ODInterest", ODInt)
                                objCommand1.Parameters.AddWithValue("@Principal", CollPrn)
                                objCommand1.Parameters.AddWithValue("@Interest", CollInt)
                                objCommand1.ExecuteNonQuery()
                            End If
                        Next
                    End If

                    If Amt > 0 Then
                        For RowID As Integer = 0 To objLoan.Rows.Count - 1
                            Dim CollDate As DateTime = SD(dtpCollectionDate.Value)
                            Dim ODInt As Double = 0
                            Dim ODPrn As Double = 0
                            Dim CollInt As Double = 0
                            Dim CollPrn As Double = 0

                            If Amt > Val(objLoan.Rows.Item(RowID)("Principal")) Then
                                CollPrn = Val(objLoan.Rows.Item(RowID)("Principal"))
                                Amt = Amt - Val(objLoan.Rows.Item(RowID)("Principal"))
                            Else
                                CollPrn = Amt
                                Amt = 0
                            End If
                            Dim objCommand1 As New SqlCommand("sp_LoanDemand_Collection_Update", objSqlConnection, objTrans)
                            objCommand1.CommandType = CommandType.StoredProcedure
                            objCommand1.Parameters.AddWithValue("@DemandCode", Val(objLoan.Rows.Item(RowID)("DemandCode")))

                            objCommand1.Parameters.AddWithValue("@CollectionDate", SD(CollDate))
                            objCommand1.Parameters.AddWithValue("@ODPrincipal", ODPrn)
                            objCommand1.Parameters.AddWithValue("@ODInterest", ODInt)
                            objCommand1.Parameters.AddWithValue("@Principal", CollPrn)
                            objCommand1.Parameters.AddWithValue("@Interest", CollInt)
                            objCommand1.ExecuteNonQuery()
                        Next
                    End If
                    'If Val(Grid.Item("Total", Rowindex).Value) = Val(Grid.Item("Collection", Rowindex).Value) Then
                    '    For RowID As Integer = 0 To objLoan.Rows.Count - 1
                    '        Dim objCommand2 As New SqlCommand("sp_Collection_Insert", objSqlConnection, objTrans)
                    '        objCommand2.CommandType = CommandType.StoredProcedure
                    '        objCommand2.Parameters.AddWithValue("@DemandCode", Val(objLoan.Rows.Item(RowID)("DemandCode")))
                    '        objCommand2.Parameters.AddWithValue("@CollectionDate", SD(dtpCollectionDate.Value))
                    '        objCommand2.Parameters.AddWithValue("@MemberCode", Val(Grid.Item("MemberCode", Rowindex).Value))
                    '        objCommand2.Parameters.AddWithValue("@LoanNamecode", Val(objLoan.Rows.Item(RowID)("LoanNameCode")))
                    '        objCommand2.Parameters.AddWithValue("@LoanCode", Val(objLoan.Rows.Item(RowID)("LoanCode")))
                    '        objCommand2.Parameters.AddWithValue("@mno", Val(objLoan.Rows.Item(RowID)("MonthNo")))
                    '        objCommand2.Parameters.AddWithValue("@YNo", Val(objLoan.Rows.Item(RowID)("YearNo")))
                    '        objCommand2.Parameters.AddWithValue("@TokenNo", Val(Grid.Item("TokenNo", Rowindex).Value))
                    '        objCommand2.Parameters.AddWithValue("@ROI", Val(objLoan.Rows.Item(RowID)("ROI")))
                    '        objCommand2.Parameters.AddWithValue("@Principal", Val(Grid.Item("Principle", Rowindex).Value))
                    '        objCommand2.Parameters.AddWithValue("@Interest", Val(Grid.Item("Int", Rowindex).Value))
                    '        objCommand2.Parameters.AddWithValue("@Bal_OS", Val(Grid.Item("Bal_OS", Rowindex).Value))
                    '        objCommand2.ExecuteNonQuery()
                    '    Next
                    'End If

                End If
            Next
            objTrans.Commit()
            objTrans.Dispose()
            MsgBox("Collection Updated Successfully...", MsgBoxStyle.Information, Mssg)
            btnClear_Click(sender, e)
        Catch ex As Exception
            objTrans.Rollback()
            objTrans.Dispose()
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            Exit Sub
        End Try
    End Sub

    Private Sub txtChequeAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMillColection.Leave
        txtMillColection.Text = Format(Val(txtMillColection.Text), "#0.00")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PanelClear(Panel1)
        PanelClear(Panel6)
        Grid.Rows.Clear()
        cmbMonth.SelectedIndex = 0
        cmbDemandType.SelectedIndex = 0
        cmbMonth.Focus()
    End Sub

    Private Sub txtFindEmpno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindEmpno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtFindEmpno.Text) > 0 Then
                For Rowindex As Integer = 0 To Grid.Rows.Count - 1
                    Grid.Rows(Rowindex).Selected = True
                    Grid.FirstDisplayedScrollingRowIndex = Rowindex
                    'Application.DoEvents()
                    If Val(txtFindEmpno.Text) = Grid.Item("EmployeeNumber", Rowindex).Value Then
                        Exit For
                    End If
                Next
            Else
                Grid.Rows(0).Selected = True
                Grid.FirstDisplayedScrollingRowIndex = 0
            End If
        End If
    End Sub

    Private Sub TextBoxvb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFindEmpno.TextChanged

    End Sub

    Private Sub txtFindTokNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindTokNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtFindTokNo.Text) > 0 Then
                For Rowindex As Integer = 0 To Grid.Rows.Count - 1
                    Grid.Rows(Rowindex).Selected = True
                    Grid.FirstDisplayedScrollingRowIndex = Rowindex
                    'Application.DoEvents()
                    If Val(txtFindTokNo.Text) = Grid.Item("TokenNo", Rowindex).Value Then
                        Exit For
                    End If
                Next
            Else
                Grid.Rows(0).Selected = True
                Grid.FirstDisplayedScrollingRowIndex = 0
            End If
        End If
    End Sub

    Private Sub txtFindTokNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFindTokNo.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub cmbDemandType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDemandType.SelectedIndexChanged
        If cmbDemandType.SelectedIndex = 0 Then
            Grid.Columns("FixedDemand").Visible = True
            Grid.Columns("JLDemand").Visible = True
            Grid.Columns("LoanDemand").Visible = True
        ElseIf cmbDemandType.SelectedIndex = 1 Then
            Grid.Columns("FixedDemand").Visible = True
            Grid.Columns("JLDemand").Visible = False
            Grid.Columns("LoanDemand").Visible = False
        ElseIf cmbDemandType.SelectedIndex = 2 Then
            Grid.Columns("FixedDemand").Visible = False
            Grid.Columns("JLDemand").Visible = True
            Grid.Columns("LoanDemand").Visible = False
        ElseIf cmbDemandType.SelectedIndex = 3 Then
            Grid.Columns("FixedDemand").Visible = False
            Grid.Columns("JLDemand").Visible = False
            Grid.Columns("LoanDemand").Visible = True
        End If
    End Sub

    Private Sub cmbTokenNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTokenNo.SelectedIndexChanged
        If cmbTokenNo.SelectedIndex > 0 Then
            pnlUpDate.Visible = True
            dtpUpdationDate.Value = dtpTo.Value
            Grid1.Rows.Clear()
            Grid1.Visible = True
            Grid.Visible = False
        Else
            pnlUpDate.Visible = False
            Grid.Rows.Clear()
            Grid1.Visible = False
            Grid.Visible = True
        End If
    End Sub
End Class