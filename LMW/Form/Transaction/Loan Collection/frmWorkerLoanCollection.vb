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
        Grid.Enabled = False
    End Sub

    Private Sub frmWorkerLoanCollection_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub frmWorkerLoanCollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbMonth.SelectedIndex = 0
        cmbDemandType.SelectedIndex = 0
        cmbTokenNo.RecordSet(objDT("sp_Loanmember_getall @Worker=1"), "strEmpno", "MemberCode")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        'If cmbDemandType.SelectedIndex = 0 Then
        '    MsgBox("Select Demand Type", MsgBoxStyle.Information, Mssg)
        '    cmbDemandType.Focus()
        '    Exit Sub
        'End If
        'If cmbTokenNo.SelectedIndex > 0 Then
        '    If IsDate(dtpUpdationDate.Value) = False Then
        '        MsgBox("Updation Date is Wrong...", MsgBoxStyle.Information, Mssg)
        '        dtpUpdationDate.Focus()
        '        Exit Sub
        '    End If
        'End If
        'If IsDate(dtpCollectionDate.Value) = False Then
        '    MsgBox("Collection Date is Wrong...", MsgBoxStyle.Information, Mssg)
        '    dtpCollectionDate.Focus()
        '    Exit Sub
        'End If
        'If cmbTokenNo.SelectedIndex = 0 Then
        '    Try
        '        Dim objColl As DataTable
        '        If cmbTokenNo.SelectedIndex = 0 Then
        '            objColl = objDT("sp_Collection @StaffLoan=0 ,@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")
        '        Else
        '            objColl = objDT("sp_Collection @StaffLoan=0 ,@MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")
        '        End If

        '        Grid.Rows.Clear()
        '        If objColl.Rows.Count > 0 Then
        '            For RowID As Integer = 0 To objColl.Rows.Count - 1

        '                'If Val(objColl.Rows.Item(RowID)("Total")) > 0 Then
        '                Dim currInt As Double = objColl.Rows.Item(RowID)("Total")
        '                If pnlUpDate.Visible = True Then

        '                    'currInt=currInt+ SI_EmiDay(
        '                End If
        '                Grid.Rows.Add(1)
        '                If cmbTokenNo.SelectedIndex > 0 Then
        '                    Grid.Item("DemandCode", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("DemandCode")
        '                End If
        '                Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberCode")
        '                Grid.Item("EmployeeNumber", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("EmployeeNumber")
        '                Grid.Item("EmployeeName", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberName")
        '                Grid.Item("TokenNo", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Number")

        '                Grid.Item("FixedDemand", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FixedDemand")
        '                Grid.Item("JLDemand", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLDemand")
        '                Grid.Item("LoanDemand", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanDemand")
        '                If cmbDemandType.SelectedIndex = 0 Then
        '                    Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
        '                    Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
        '                    'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("TotalOs")
        '                ElseIf cmbDemandType.SelectedIndex = 1 Then  'Fixed
        '                    Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FixedDemand")
        '                    Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FixedDemand")
        '                    'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("FDLoanOs")

        '                ElseIf cmbDemandType.SelectedIndex = 2 Then  'JL
        '                    Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLDemand")
        '                    Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLDemand")
        '                    'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("JLLoanOs")
        '                ElseIf cmbDemandType.SelectedIndex = 3 Then  'Loan Demand
        '                    Grid.Item("Total", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanDemand")
        '                    Grid.Item("Collection", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanDemand")
        '                    'Grid.Item("OutStanding", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Total")
        '                End If

        '                'End If
        '            Next
        '            Call CalsiTotal()
        '            Grid.Columns("Collection").DataGridView.BackColor = Color.YellowGreen
        '            If Grid.Rows.Count > 0 Then
        '                Grid.Rows(0).Selected = True
        '                Grid.FirstDisplayedScrollingRowIndex = 0
        '            End If
        '            Grid.Enabled = True
        '        Else
        '            MsgBox("No Entry on this Demand...", MsgBoxStyle.Information, Mssg)
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        '    End Try
        'Else
        '    Try
        '        Dim objColl As DataTable
        '        objColl = objDT("sp_Collection @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@StaffLoan=0,@DemandType=" & cmbDemandType.SelectedIndex & ",@MaxDemandCode=1,@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpTo.Value))


        '        If objColl.Rows.Count = 0 Then
        '            objColl = objDT("sp_Collection @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@StaffLoan=0,@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "',@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpTo.Value))
        '        End If
        '        If objColl.Rows.Count = 0 Then
        '            objColl = objDT("sp_Collection @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@StaffLoan=0,@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "',@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpTo.Value))
        '        End If
        '        dtpUpdationDate.Value = objColl.Rows(0)("DateTo")


        '        Grid1.Rows.Clear()
        '        If objColl.Rows.Count > 0 Then
        '            For RowID As Integer = 0 To objColl.Rows.Count - 1

        '                'If Val(objColl.Rows.Item(RowID)("Total")) > 0 Then
        '                Dim currInt As Double = objColl.Rows.Item(RowID)("Total")
        '                If pnlUpDate.Visible = True Then

        '                    'currInt=currInt+ SI_EmiDay(
        '                End If
        '                Grid1.Rows.Add(1)
        '                If cmbTokenNo.SelectedIndex > 0 Then
        '                    Grid1.Item("DemandCode1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("DemandCode")
        '                End If
        '                Grid1.Item("MemberCode1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberCode")
        '                Grid1.Item("TokenNo1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("EmployeeNumber")
        '                Grid1.Item("EmpName1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberName")
        '                Grid1.Item("MNo1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Number")
        '                Grid1.Item("OutStanding1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanOS")
        '                Grid1.Item("UDate", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("DateTo")

        '                Grid1.Item("LoanCode", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Loancode")
        '                Grid1.Item("LoanNo", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanNumber")
        '                Grid1.Item("LoanName", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanName")
        '                Grid1.Item("Principle", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Principal")
        '                Grid1.Item("Int", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Interest")
        '                ' Grid1.Item("Total1", Grid1.Rows.Count - 1).Value = Val(objColl.Rows.Item(RowID)("Total"))
        '                Grid1.Item("Total1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Principal") + objColl.Rows.Item(RowID)("Interest")
        '            Next
        '            Call CalsiTotal()
        '            Grid1.Columns("Collection1").DataGridView.BackColor = Color.YellowGreen
        '            If Grid1.Rows.Count > 0 Then
        '                Grid1.Rows(0).Selected = True
        '                Grid1.FirstDisplayedScrollingRowIndex = 0
        '            End If
        '            Grid1.Enabled = True
        '        Else
        '            MsgBox("No Entry on this Demand...", MsgBoxStyle.Information, Mssg)
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        '    End Try


        'End If

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
        Dim MaxDemandCode As Integer = 0
        If cmbTokenNo.SelectedIndex = 0 Then
            Try
                Dim objColl As DataTable
                If cmbTokenNo.SelectedIndex = 0 Then
                    objColl = objDT("sp_Collection @StaffLoan=0 ,@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")
                Else
                    objColl = objDT("sp_Collection @StaffLoan=0 ,@MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")
                End If

                If objColl.Rows.Count = 0 Then
                    objColl = objDT("sp_Collection @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@DemandType=" & cmbDemandType.SelectedIndex & ",@MaxDemandCode=1,@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpFrom.Value))
                End If
                If objColl.Rows.Count = 0 Then
                    'objColl = objDT("sp_Collection @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "',@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpFrom.Value))
                    objColl = objDT("sp_Collection @DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "'")

                End If
                If objColl.Rows.Count = 0 Then
                    objColl = objDT("sp_Collection @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "',@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpFrom.Value))
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
                            'DemandCode = objColl.Rows.Item(RowID)("DemandCode")
                        End If
                        If objColl.Rows.Item(RowID)("membercode") = 109 Then
                            MsgBox("wait", MsgBoxStyle.Information, Mssg)
                        End If
                        Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberCode")
                        Grid.Item("EmployeeNumber", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("EmployeeNumber")
                        Grid.Item("EmployeeName", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("MemberName")
                        Grid.Item("TokenNo", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Number")
                        'Grid.Item("DemandCode", Grid.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("DemandCode")
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
                objColl = objDT("sp_Collection @StaffLoan=0,@MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@DemandType=" & cmbDemandType.SelectedIndex & ",@MaxDemandCode=1,@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpTo.Value))
                If objColl.Rows.Count = 0 Then
                    objColl = objDT("sp_Collection @StaffLoan=0, @MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "',@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpTo.Value))
                End If
                If objColl.Rows.Count = 0 Then
                    objColl = objDT("sp_Collection @StaffLoan=0,@MemberCode=" & cmbTokenNo.ColData("MemberCode") & ",@DemandType=" & cmbDemandType.SelectedIndex & ",@Fromdate='" & SD(dtpFrom.Value) & "',@Todate='" & SD(dtpTo.Value) & "',@MonthNo=" & Month(dtpTo.Value) & ",@YearNo=" & Year(dtpTo.Value))
                End If

                dtpUpdationDate.Value = objColl.Rows(0)("DateTo")

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
                        Grid1.Item("UDate", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("DateTo")

                        Grid1.Item("LoanCode", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Loancode")
                        Grid1.Item("LoanNo", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanNumber")
                        Grid1.Item("LoanName", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("LoanName")
                        Grid1.Item("Principle", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Principal")
                        Grid1.Item("Int", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Interest")
                        'Grid1.Item("Total1", Grid1.Rows.Count - 1).Value = Val(objColl.Rows.Item(RowID)("Total"))
                        Grid1.Item("Total1", Grid1.Rows.Count - 1).Value = objColl.Rows.Item(RowID)("Principal") + objColl.Rows.Item(RowID)("Interest")
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
        If cmbTokenNo.SelectedIndex = 0 Then
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
        Else
            Dim DAmt As Double = 0
            Dim CAmt As Double = 0
            For rowindex As Integer = 0 To Grid1.Rows.Count - 1
                DAmt += Val(Grid1.Item("Total1", rowindex).Value)
                CAmt += Val(Grid1.Item("Collection1", rowindex).Value)
            Next
            txtDemandAmt.Text = Format(DAmt, "#0.00")
            txtCollectionAmt.Text = Format(CAmt, "#0.00")
            txtBalAmt.Text = Format(DAmt - CAmt, "#0.00")
            If Val(txtDemandAmt.Text) = 0 Then
                MsgBox("Collection Entry Already Finished...", MsgBoxStyle.Information, Mssg)
            End If
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

    Private Sub Grid1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid1.CellMouseClick
        Dim CurrInt As Double = 0
        If e.ColumnIndex = Grid1.Columns("Demand").Index Then
            'DGrid.Visible = True
            Dim objdemand As New DataTable
            Dim opnDemand As DataTable = objDT("Select * from tbl_LoanDemand where  staffLoan=0 and DateFrom >='" & SD(dtpTo.Value) & "' ") 'having MAX(yearno)>0 and max(MonthNo)>0") 'NewDemand=0 and 
            'objdemand = objDT("sp_LoanDemand_GetAll @StaffLoan=1,@DateFrom='" & SD(dtpFrom.Value) & "',@DateTo='" & SD(dtpTo.Value) & "', @DemandCode= " & Val(Grid1.CurrentRow.Cells("DemandCode1").Value))
            If objdemand.Rows.Count > 0 Then
                MsgBox("Already Demand Saved...", MsgBoxStyle.Information, Mssg)
                Exit Sub
            End If
            DGrid.Rows.Clear()
            Dim MNO As Integer = Month(dtpFrom.Value)
            Dim YNO As Integer = Year(dtpFrom.Value)
            Dim DFrom As DateTime = DateAdd(DateInterval.Day, 1, dtpTo.Value)
            Dim DTo As DateTime = dtpUpdationDate.Value
            Dim FC As Integer = int_FYearCode
            Dim Days As Integer = 0
            Dim Mons As Integer = 0

            Dim objLoan As DataTable = objDT("sp_MemberLoan_GetAll  @MemberTYpe='WORKERS',@LoanCode=" & Val(Grid1.CurrentRow.Cells("LoanCode").Value))
            If objLoan.Rows.Count > 0 Then
                For Rowid As Integer = 0 To objLoan.Rows.Count - 1
                    'If objLoan.Rows.Item(Rowid)("LoanNumber") = 1113 Then
                    '    MsgBox("WAIT", MsgBoxStyle.Information, Mssg)
                    'End If
                    If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(DFrom) Or objLoan.Rows.Item(Rowid)("LoanClossedStatus") = False Then
                        If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(DFrom) And SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(DTo) Then
                            DTo = objLoan.Rows.Item(Rowid)("MaturityDate")
                            Days = DateDiff(DateInterval.Day, dtpFrom.Value, DTo)
                            Mons = 0
                        Else
                            Days = 0
                            Mons = 1
                        End If

                        Dim DPFrom As DateTime = SD(DateAdd(DateInterval.Month, -1, dtpFrom.Value))
                        Dim DPTo As DateTime = SD(DateAdd(DateInterval.Month, -1, dtpTo.Value))
                        Dim SQuery As String = "sp_LoanDemand_GetAll @StaffLoan=0,@LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode")  '--& ", @DateTo='" & SD(DPTo) & "',@DateFrom='" & SD(DPFrom) & "'"
                        objdemand = objDT(SQuery)

                        Dim LOS As Double = 0
                        Dim LPrn As Double = 0
                        Dim LInt As Double = 0
                        Dim LODP As Double = 0
                        Dim LODI As Double = 0
                        Dim LDAmtIntCalsi As Double = 0

                        Dim Currprin As Double = 0
                        CurrInt = 0
                        Dim currODP As Double = 0
                        Dim currODi As Double = 0


                        Dim EMI As Double = objLoan.Rows.Item(Rowid)("EMI_Amount")
                        Dim LDAmount As Double = objLoan.Rows.Item(Rowid)("LoanAmount")
                        Dim ROI As Double = objLoan.Rows.Item(Rowid)("ROI")
                        Dim PostPrincipal As Double = 0
                        If objdemand.Rows.Count > 0 Then
                            LPrn = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalPrincipal")
                            LInt = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalInterest")
                            LODP = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalODPrincipal")
                            LODI = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalODInterest")
                            If objdemand.Rows.Item(objdemand.Rows.Count - 1)("CollPrincipal") >= objdemand.Rows.Item(objdemand.Rows.Count - 1)("Principal") Then
                                PostPrincipal = 0
                            ElseIf objdemand.Rows.Item(objdemand.Rows.Count - 1)("CollPrincipal") < objdemand.Rows.Item(objdemand.Rows.Count - 1)("Principal") Then
                                PostPrincipal = objdemand.Rows.Item(objdemand.Rows.Count - 1)("Principal") - objdemand.Rows.Item(objdemand.Rows.Count - 1)("collPrincipal")
                            Else
                                PostPrincipal = objdemand.Rows.Item(objdemand.Rows.Count - 1)("Principal")
                            End If
                            LDAmtIntCalsi = objdemand.Rows.Item(objdemand.Rows.Count - 1)("LoanOS") '- LPrn
                            LOS = objdemand.Rows.Item(objdemand.Rows.Count - 1)("LoanOS")
                            Dim LastDemandDate As DateTime = objdemand.Rows.Item(objdemand.Rows.Count - 1)("DateTo")
                            DFrom = DateAdd(DateInterval.Day, 1, LastDemandDate)
                            Dim BalPrin As Double = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalPrinciPal")
                            If objLoan.Rows.Item(Rowid)("DemandType") <> 2 Then
                                If BalPrin >= (EMI * 3) Then
                                    If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(dtpFrom.Value) And SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(dtpTo.Value) Then
                                        LODI = LODI + Math.Round(SI_EmiDay(BalPrin, DateDiff(DateInterval.Day, DTo, dtpTo.Value), 2), 1)
                                        LODP = BalPrin
                                    ElseIf SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(dtpTo.Value) Then
                                        LODI = LODI + Math.Round(SI_Emi(BalPrin, 1, 2), 1)
                                        LODP = BalPrin
                                    End If
                                End If
                            End If

                            If objLoan.Rows.Item(Rowid)("DemandType") = 1 Then
                                If SD(dtpFrom.Value) = SD(DFrom) Then
                                    CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                Else
                                    CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI) + 1, "#0.00")
                                End If
                                'Currprin = Format(EMI - CurrInt - PostPrincipal, "#0.00")
                                Currprin = PostPrincipal
                            ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 2 Then
                                If SD(dtpFrom.Value) = SD(DFrom) Then
                                    CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                Else
                                    CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI) + 1, "#0.00")
                                End If
                                'Currprin = Format(EMI, "#0.00")
                                Currprin = PostPrincipal

                            ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 3 Then
                                If SD(dtpFrom.Value) = SD(DFrom) And SD(dtpTo.Value) = SD(DTo) Then
                                    CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                Else
                                    CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI) + 1, "#0.00")
                                End If
                                Currprin = PostPrincipal
                                'Currprin = Format(Val(objLoan.Rows.Item(Rowid)("LoanAmount")) / Val(objLoan.Rows.Item(Rowid)("LoanPeriod")) - PostPrincipal, "#0.00")
                            End If
                            If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(dtpFrom.Value) And SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(dtpTo.Value) Then
                                CurrInt = Format(CurrInt + SI_EmiDay(IIf(LDAmtIntCalsi <= 0, LOS, LDAmtIntCalsi), DateDiff(DateInterval.Day, DTo, dtpTo.Value) + 1, ROI + 2), "#0.00")
                                Currprin = LOS
                            ElseIf SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(dtpTo.Value) Then
                                CurrInt = Format(SI_Emi(LOS, 1, ROI + 2), "#0.00")
                                LODI = LODI + CurrInt
                                CurrInt = 0
                                Currprin = LOS
                                LODP = LOS
                            End If
                            ' Currprin = 0
                            If SD(dtpUpdationDate.Value) = SD(dtpTo.Value) Then CurrInt = 0

                            DGrid.Rows.Add(1)
                            DGrid.Item("DateFrom", DGrid.Rows.Count - 1).Value = SD(DFrom)
                            DGrid.Item("DateTo", DGrid.Rows.Count - 1).Value = SD(DTo)
                            DGrid.Item("MonthNo", DGrid.Rows.Count - 1).Value = Month(dtpTo.Value)
                            DGrid.Item("YearNo", DGrid.Rows.Count - 1).Value = Year(dtpTo.Value)
                            DGrid.Item("DemandDate", DGrid.Rows.Count - 1).Value = SD(dtpFrom.Value)
                            DGrid.Item("FYCode", DGrid.Rows.Count - 1).Value = FC
                            DGrid.Item("MCode", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MemberCode")
                            DGrid.Item("LCode", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanCode")
                            DGrid.Item("LNumber", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanNumber")
                            DGrid.Item("MaturityDate", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MaturityDate")
                            DGrid.Item("LoanDate", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("Loandate")
                            DGrid.Item("LoanROI", DGrid.Rows.Count - 1).Value = ROI
                            DGrid.Item("LoanOutStanding", DGrid.Rows.Count - 1).Value = LOS
                            DGrid.Item("TokenNumber", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("EmployeeNumber")
                            DGrid.Item("LoanPrincipal", DGrid.Rows.Count - 1).Value = LPrn
                            DGrid.Item("LoanInterest", DGrid.Rows.Count - 1).Value = LInt
                            DGrid.Item("LoanODPrincipal", DGrid.Rows.Count - 1).Value = LODP
                            DGrid.Item("LoanODInterest", DGrid.Rows.Count - 1).Value = LODI
                            DGrid.Item("CurrPrincipal", DGrid.Rows.Count - 1).Value = Currprin
                            DGrid.Item("CurrInterest", DGrid.Rows.Count - 1).Value = CurrInt
                            DGrid.Item("CurrODPrincipal", DGrid.Rows.Count - 1).Value = currODP
                            DGrid.Item("CurrODInterest", DGrid.Rows.Count - 1).Value = currODi
                            DGrid.Item("BalPrincipal", DGrid.Rows.Count - 1).Value = Currprin
                            DGrid.Item("BalInterest", DGrid.Rows.Count - 1).Value = LInt + CurrInt
                            DGrid.Item("BalODPrincipal", DGrid.Rows.Count - 1).Value = LODP + currODP
                            DGrid.Item("BalODInterest", DGrid.Rows.Count - 1).Value = LODI + currODi
                            DGrid.Item("LoanOutstanding", DGrid.Rows.Count - 1).Value = LOS
                            DGrid.Item("CollOS", DGrid.Rows.Count - 1).Value = LOS
                            DGrid.Item("LoanOS", DGrid.Rows.Count - 1).Value = LOS
                            DGrid.Item("Loanosforint", DGrid.Rows.Count - 1).Value = LDAmtIntCalsi - LPrn
                            DGrid.Item("StaffLoan", DGrid.Rows.Count - 1).Value = 0
                            DGrid.Item("WorkerLoan", DGrid.Rows.Count - 1).Value = 1

                        Else

                            SQuery = "sp_MemberLoan_GetAll @MemberType='WORKERS',@LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode") & ",@MemberCode=" & objLoan.Rows.Item(Rowid)("MemberCode") & ",@FromDate='" & SD(dtpFrom.Value) & "',@ToDate='" & SD(dtpTo.Value) & "'"
                            objdemand = objDT(SQuery)
                            Dim SQuery1 As String = "select max(DemandCode)DemandCode from tbl_loandemand where LoanCode =" & objLoan.Rows.Item(Rowid)("LoanCode") & " and  membercode=" & objLoan.Rows.Item(Rowid)("MemberCode")
                            Dim objMAXDemand As DataTable = objDT(SQuery1)
                            Dim MaxLoanDemand As Integer = objMAXDemand.Rows.Item(0)("DemandCode")
                            Dim SQuery2 As String = "select * from tbl_loandemand where DemandCode = " & MaxLoanDemand
                            Dim objLoanDemand As DataTable = objDT(SQuery2)
                            If objdemand.Rows.Count > 0 Then
                                LOS = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("LoanOS")
                                LPrn = 0
                                Dim CalsiInt As Double = objdemand.Rows.Item(objdemand.Rows.Count - 1)("ROI")
                                LInt = 0
                                LODP = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("ODPrincipal") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollODPrincipal")
                                LODI = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("ODInterest") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollODInterest")
                                LDAmtIntCalsi = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("LoanOutStanding") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollPrincipal")

                                Dim LastDemandDate As DateTime = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("DateTo")
                                DFrom = LastDemandDate



                                If objLoan.Rows.Item(Rowid)("DemandType") = 1 Then
                                    If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
                                        CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                    Else
                                        CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo), ROI) + 1, "#0.00")
                                    End If
                                    Currprin = Format(EMI - CurrInt, "#0.00")
                                ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 2 Then
                                    If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
                                        CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                    Else
                                        CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo), ROI) + 1, "#0.00")
                                    End If
                                    Currprin = Format(EMI, "#0.00")

                                ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 3 Then
                                    If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
                                        CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                    Else
                                        CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo), ROI) + 1, "#0.00")
                                    End If
                                    Currprin = Format(Math.Round(Val(objLoan.Rows.Item(Rowid)("LoanAmount")) / Val(objLoan.Rows.Item(Rowid)("LoanPeriod")), 0), "#0.00")
                                End If
                                DGrid.Rows.Add(1)
                                DGrid.Item("DateFrom", DGrid.Rows.Count - 1).Value = SD(dtpFrom.Value)
                                DGrid.Item("DateTo", DGrid.Rows.Count - 1).Value = SD(dtpTo.Value)
                                DGrid.Item("MonthNo", DGrid.Rows.Count - 1).Value = Month(dtpTo.Value)
                                DGrid.Item("YearNo", DGrid.Rows.Count - 1).Value = Year(dtpTo.Value)
                                DGrid.Item("DemandDate", DGrid.Rows.Count - 1).Value = SD(dtpFrom.Value)
                                DGrid.Item("FYCode", DGrid.Rows.Count - 1).Value = FC
                                DGrid.Item("MCode", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MemberCode")
                                DGrid.Item("LCode", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanCode")
                                DGrid.Item("LNumber", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanNumber")
                                DGrid.Item("MaturityDate", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MaturityDate")
                                DGrid.Item("LoanDate", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("Loandate")
                                DGrid.Item("LoanROI", DGrid.Rows.Count - 1).Value = ROI
                                DGrid.Item("LoanOutStanding", DGrid.Rows.Count - 1).Value = LOS
                                DGrid.Item("TokenNumber", DGrid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("EmployeeNumber")
                                DGrid.Item("LoanPrincipal", DGrid.Rows.Count - 1).Value = LPrn
                                DGrid.Item("LoanInterest", DGrid.Rows.Count - 1).Value = LInt
                                DGrid.Item("LoanODPrincipal", DGrid.Rows.Count - 1).Value = LODP
                                DGrid.Item("LoanODInterest", DGrid.Rows.Count - 1).Value = LODI
                                DGrid.Item("CurrPrincipal", DGrid.Rows.Count - 1).Value = Currprin
                                DGrid.Item("CurrInterest", DGrid.Rows.Count - 1).Value = CurrInt
                                DGrid.Item("CurrODPrincipal", DGrid.Rows.Count - 1).Value = currODP
                                DGrid.Item("CurrODInterest", DGrid.Rows.Count - 1).Value = currODi
                                DGrid.Item("BalPrincipal", DGrid.Rows.Count - 1).Value = LPrn + Currprin
                                DGrid.Item("BalInterest", DGrid.Rows.Count - 1).Value = LInt + CurrInt
                                DGrid.Item("BalODPrincipal", DGrid.Rows.Count - 1).Value = LODP + currODP
                                DGrid.Item("BalODInterest", DGrid.Rows.Count - 1).Value = LODI + currODi
                                DGrid.Item("LoanOutstanding", DGrid.Rows.Count - 1).Value = LOS
                                DGrid.Item("CollOS", DGrid.Rows.Count - 1).Value = LOS
                                DGrid.Item("LoanOS", DGrid.Rows.Count - 1).Value = LOS
                                DGrid.Item("Loanosforint", DGrid.Rows.Count - 1).Value = LDAmtIntCalsi
                                DGrid.Item("StaffLoan", DGrid.Rows.Count - 1).Value = 0
                                DGrid.Item("WorkerLoan", DGrid.Rows.Count - 1).Value = 1
                            End If
                        End If
                    End If
                Next
            Else
                MsgBox("SORRY! No Loan Data is Found...", MsgBoxStyle.Information, Mssg)
            End If
        Else
            Exit Sub
        End If

        If CurrInt > 0 Then
            Dim ObjTrans As SqlTransaction
            ObjTrans = objSqlConnection.BeginTransaction
            Try
                For Rowindex As Integer = 0 To DGrid.Rows.Count - 1
                    Dim objcommand As New SqlCommand("sp_LoanDemand_Insert", objSqlConnection, ObjTrans)
                    objcommand.CommandType = CommandType.StoredProcedure
                    'objcommand.Parameters.AddWithValue("@DemandCode", dGrid.Item("demandCode", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@DateFrom ", DGrid.Item("DateFrom", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@DateTo ", DGrid.Item("DateTo", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@MonthNo", DGrid.Item("MonthNo", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@YearNo", DGrid.Item("YearNo", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@DemandDate ", DGrid.Item("DemandDate", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@Fycode", DGrid.Item("Fycode", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@MemberCode", DGrid.Item("MCode", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@LoanCode", DGrid.Item("LCode", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@LoanOutStanding", DGrid.Item("LoanOs", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@Principal", DGrid.Item("BalPrincipal", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@Interest", DGrid.Item("BalInterest", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@ODPrincipal", DGrid.Item("BalODPrincipal", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@ODInterest", DGrid.Item("BalODInterest", Rowindex).Value)
                    'objcommand.Parameters.AddWithValue("@CollDate", dGrid.Item("demandCode", Rowindex).Value)
                    'objcommand.Parameters.AddWithValue("@CollPrincipal", dGrid.Item("demandCode", Rowindex).Value)
                    'objcommand.Parameters.AddWithValue("@CollInterest", dGrid.Item("demandCode", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@NewDemand", 0)
                    'objcommand.Parameters.AddWithValue("@CollODInterest", dGrid.Item("demandCode", Rowindex).Value)
                    'objcommand.Parameters.AddWithValue("@CollODPrincipal", dGrid.Item("demandCode", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@CollOS", DGrid.Item("CollOS", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@LoanOs", DGrid.Item("LoanOs", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@LoanOSforInt", DGrid.Item("LoanOSforInt", Rowindex).Value)
                    objcommand.Parameters.AddWithValue("@StaffLoan", 0)
                    objcommand.Parameters.AddWithValue("@WorkerLoan ", 1)
                    objcommand.ExecuteNonQuery()
                Next
                ObjTrans.Commit()
                ObjTrans.Dispose()
            Catch ex As Exception
                ObjTrans.Rollback()
                ObjTrans.Dispose()
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End Try
        End If
        Call btnView_Click_1(sender, e)
    End Sub

    Private Sub Grid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Leave, Grid1.Leave
        Call CalsiTotal()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
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
        Dim LDemandCode As Integer = 0

        If IsDate(dtpCollectionDate.Value) = False Or dtpCollectionDate.Text = "  /  /" Then
            MsgBox("Type Collection Date...", MsgBoxStyle.Information, Mssg)
            dtpCollectionDate.Focus()
            Exit Sub
        End If
        If cmbTokenNo.SelectedIndex = 0 Then
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
                        objCommand.Parameters.AddWithValue("@DemandCode", Val(Grid.Item("DemandCode", Rowindex).Value))
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
                                    objCommand1.Parameters.AddWithValue("@Particulars", txtParticulars.Text.Trim)
                                    objCommand1.Parameters.AddWithValue("@ModeofReceipt", lblModeofReceipt.Text.Trim)
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
                                    objCommand1.Parameters.AddWithValue("@Particulars", txtParticulars.Text.Trim)
                                    objCommand1.Parameters.AddWithValue("@ModeofReceipt", lblModeofReceipt.Text.Trim)
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
                                    objCommand1.Parameters.AddWithValue("@Particulars", txtParticulars.Text.Trim)
                                    objCommand1.Parameters.AddWithValue("@ModeofReceipt", lblModeofReceipt.Text.Trim)
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
                                objCommand1.Parameters.AddWithValue("@Particulars", txtParticulars.Text.Trim)
                                objCommand1.Parameters.AddWithValue("@ModeofReceipt", lblModeofReceipt.Text.Trim)
                                objCommand1.ExecuteNonQuery()
                            Next
                        End If
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
        Else
            If Grid1.Rows.Count = 0 Then
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
            If cmbDemandType.SelectedIndex = 1 Then   '--Fixed Demand
                DType = 1
            ElseIf cmbDemandType.SelectedIndex = 2 Then '--JLDemand
                DType = 2
            ElseIf cmbDemandType.SelectedIndex = 3 Then '--LoanDemand
                DType = 3
            End If
            Dim objLoan As DataTable
            Dim objTrans As SqlTransaction
            objTrans = objSqlConnection.BeginTransaction
            Try
                For Rowindex As Integer = 0 To Grid1.Rows.Count - 1
                    If Val(Grid1.Item("collection1", Rowindex).Value) > 0 Then

                        Dim objCommand As New SqlCommand("sp_DemandCollection_AddEdit", objSqlConnection, objTrans)
                        objCommand.CommandType = CommandType.StoredProcedure

                        objCommand.Parameters.AddWithValue("@Membercode", Val(Grid1.Item("MemberCode1", Rowindex).Value))
                        objCommand.Parameters.AddWithValue("@DemandCode", Val(Grid1.Item("DemandCode1", Rowindex).Value))
                        If DType = 1 Then
                            objCommand.Parameters.AddWithValue("@FixedDemand", Val(Grid1.Item("collection1", Rowindex).Value))
                            objCommand.Parameters.AddWithValue("@JLDemand", 0)
                            objCommand.Parameters.AddWithValue("@LoanDemand", 0)
                        End If
                        If DType = 2 Then
                            objCommand.Parameters.AddWithValue("@JLDemand", Val(Grid1.Item("collection1", Rowindex).Value))
                            objCommand.Parameters.AddWithValue("@FixedDemand", 0)
                            objCommand.Parameters.AddWithValue("@LoanDemand", 0)
                        End If
                        If DType = 3 Then
                            objCommand.Parameters.AddWithValue("@LoanDemand", Val(Grid1.Item("collection1", Rowindex).Value))
                            objCommand.Parameters.AddWithValue("@FixedDemand", 0)
                            objCommand.Parameters.AddWithValue("@JLDemand", 0)
                        End If
                        objCommand.Parameters.AddWithValue("@Total", Val(Grid1.Item("Total1", Rowindex).Value))
                        objCommand.Parameters.AddWithValue("@Collection", Val(Grid1.Item("Collection1", Rowindex).Value))
                        objCommand.Parameters.AddWithValue("@Datefrom", SD(dtpFrom.Value))
                        objCommand.Parameters.AddWithValue("@Dateto", SD(dtpTo.Value))
                        objCommand.Parameters.AddWithValue("@DemandMonth", Month(dtpFrom.Value))
                        objCommand.Parameters.AddWithValue("@DemandYear", Year(dtpFrom.Value))
                        objCommand.Parameters.AddWithValue("@User", int_UserCode)
                        objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
                        objCommand.ExecuteNonQuery()

                        LDemandCode = Val(Grid1.Item("DemandCode1", Rowindex).Value)
                        Dim objChkDemand As DataTable
                        Dim objSqlCmd As New SqlCommand("select * from tbl_LoanDemand where DemandCode=" & LDemandCode, objSqlConnection, objTrans)
                        objSqlCmd.CommandType = CommandType.Text
                        objChkDemand = objDT(objSqlCmd)

                        If IsDBNull(objChkDemand.Rows.Item(0)("CollDate")) = False Then

                            Dim LDateFrom As DateTime = objChkDemand.Rows.Item(0)("DateFrom")
                            Dim LDateTo As DateTime = objChkDemand.Rows.Item(0)("DateTo")
                            Dim LMonthNo As Integer = objChkDemand.Rows.Item(0)("MonthNo")
                            Dim LYearno As Integer = objChkDemand.Rows.Item(0)("YearNo")
                            Dim LDemandDate As DateTime = objChkDemand.Rows.Item(0)("DemandDate")
                            Dim LFYCode As Integer = objChkDemand.Rows.Item(0)("FyCode")
                            Dim LLoanCode As Integer = objChkDemand.Rows.Item(0)("LoanCode")
                            Dim LLoanOutStanding As Double = objChkDemand.Rows.Item(0)("LoanOutStanding")
                            Dim LPrincipal As Double = objChkDemand.Rows.Item(0)("Principal") - objChkDemand.Rows.Item(0)("CollPrincipal")
                            Dim LInterest As Double = objChkDemand.Rows.Item(0)("Interest") - objChkDemand.Rows.Item(0)("CollInterest")
                            Dim LODPrincipal As Double = objChkDemand.Rows.Item(0)("ODPrincipal") - objChkDemand.Rows.Item(0)("CollODPrincipal")
                            Dim LODInterest As Double = objChkDemand.Rows.Item(0)("ODInterest") - objChkDemand.Rows.Item(0)("CollODInterest")
                            Dim LCollPrincipal As Double = Nothing
                            Dim LCollInterest As Double = Nothing
                            Dim LNewDemand As Integer = Nothing
                            Dim LCollDate As DateTime = Nothing
                            Dim LMemberCode As Integer = objChkDemand.Rows.Item(0)("MemberCode")
                            Dim LCollODPrincipal As Double = Nothing
                            Dim LCollODInterest As Double = Nothing
                            Dim LCollOS As Double = objChkDemand.Rows.Item(0)("CollOS")
                            Dim LLoanOS As Double = objChkDemand.Rows.Item(0)("LoanOS")
                            Dim LLoanOSforInt As Double = objChkDemand.Rows.Item(0)("LoanOSforInt")
                            Dim LStaffLoan As Integer = objChkDemand.Rows.Item(0)("StaffLoan")
                            Dim LWorkerLoan As Integer = objChkDemand.Rows.Item(0)("WorkerLoan")

                            Dim objcommandL As New SqlCommand("sp_LoanDemand_Insert", objSqlConnection, objTrans)
                            objcommandL.CommandType = CommandType.StoredProcedure
                            'objcommand.Parameters.AddWithValue("@DemandCode", Grid.Item("demandCode", Rowindex).Value)
                            objcommandL.Parameters.AddWithValue("@DateFrom ", SD(LDateFrom))
                            objcommandL.Parameters.AddWithValue("@DateTo ", SD(LDateTo))
                            objcommandL.Parameters.AddWithValue("@MonthNo", LMonthNo)
                            objcommandL.Parameters.AddWithValue("@YearNo", LYearno)
                            objcommandL.Parameters.AddWithValue("@DemandDate ", SD(LDemandDate))
                            objcommandL.Parameters.AddWithValue("@Fycode", LFYCode)
                            objcommandL.Parameters.AddWithValue("@MemberCode", LMemberCode)
                            objcommandL.Parameters.AddWithValue("@LoanCode", LLoanCode)
                            objcommandL.Parameters.AddWithValue("@LoanOutStanding", LLoanOutStanding)
                            objcommandL.Parameters.AddWithValue("@Principal", LPrincipal)
                            objcommandL.Parameters.AddWithValue("@Interest", LInterest)
                            objcommandL.Parameters.AddWithValue("@ODPrincipal", LODPrincipal)
                            objcommandL.Parameters.AddWithValue("@ODInterest", LODInterest)
                            objcommandL.Parameters.AddWithValue("@NewDemand", 0)
                            objcommandL.Parameters.AddWithValue("@CollOS", LCollOS)
                            objcommandL.Parameters.AddWithValue("@LoanOs", LLoanOS)
                            objcommandL.Parameters.AddWithValue("@LoanOSforInt", LLoanOSforInt)
                            objcommandL.Parameters.AddWithValue("@StaffLoan", LStaffLoan)
                            objcommandL.Parameters.AddWithValue("@WorkerLoan ", LWorkerLoan)
                            LDemandCode = objcommandL.ExecuteScalar()
                        End If

                        Dim objcmd As New SqlCommand("sp_DC", objSqlConnection, objTrans)
                        objcmd.CommandType = CommandType.StoredProcedure
                        If cmbTokenNo.SelectedIndex = 0 Then  '--And SD(dtpTo.Value) = SD(dtpUpdationDate.Value)
                            objcmd.Parameters.AddWithValue("@Fromdate", SD(dtpFrom.Value))
                            objcmd.Parameters.AddWithValue("@Todate", SD(dtpTo.Value))
                        End If
                        objcmd.Parameters.AddWithValue("@DemandCode", LDemandCode)
                        objcmd.Parameters.AddWithValue("@DType", DType)
                        objcmd.Parameters.AddWithValue("@Demand", 1)
                        objcmd.Parameters.AddWithValue("@MemberCode", Val(Grid1.Item("MemberCode1", Rowindex).Value))
                        objLoan = objDT(objcmd)


                        Amt = Grid1.Item("Collection1", Rowindex).Value
                        If Amt > 0 Then
                            For RowID As Integer = 0 To objLoan.Rows.Count - 1
                                Dim CollDate As DateTime = SD(dtpCollectionDate.Value)
                                Dim ODInt As Double = 0
                                Dim ODPrn As Double = 0
                                Dim CollInt As Double = 0
                                Dim CollPrn As Double = 0
                                If Val(objLoan.Rows.Item(RowID)("ODInterest")) - Val(objLoan.Rows.Item(RowID)("CollODInterest")) > 0 Then
                                    If Amt >= Val(objLoan.Rows.Item(RowID)("ODInterest")) Then
                                        ODInt = Val(objLoan.Rows.Item(RowID)("ODInterest"))
                                        Amt = Amt - Val(objLoan.Rows.Item(RowID)("ODInterest"))
                                    Else
                                        ODInt = Amt
                                        Amt = 0
                                    End If
                                    Dim objCommand1 As New SqlCommand("sp_LoanDemand_Collection_Update", objSqlConnection, objTrans)
                                    objCommand1.CommandType = CommandType.StoredProcedure
                                    objCommand1.Parameters.AddWithValue("@DemandCode", LDemandCode)

                                    objCommand1.Parameters.AddWithValue("@CollectionDate", SD(CollDate))
                                    objCommand1.Parameters.AddWithValue("@ODPrincipal", ODPrn)
                                    objCommand1.Parameters.AddWithValue("@ODInterest", ODInt)
                                    objCommand1.Parameters.AddWithValue("@Principal", CollPrn)
                                    objCommand1.Parameters.AddWithValue("@Interest", CollInt)
                                    objCommand1.Parameters.AddWithValue("@Particulars", txtParticulars.Text.Trim)
                                    objCommand1.Parameters.AddWithValue("@ModeofReceipt", lblModeofReceipt.Text.Trim)
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
                                If Val(objLoan.Rows.Item(RowID)("ODPrincipal")) - Val(objLoan.Rows.Item(RowID)("CollODPrincipal")) > 0 Then
                                    If Amt >= Val(objLoan.Rows.Item(RowID)("ODPrincipal")) Then
                                        ODPrn = Val(objLoan.Rows.Item(RowID)("ODPrincipal"))
                                        Amt = Amt - Val(objLoan.Rows.Item(RowID)("ODPrincipal"))
                                    Else
                                        ODPrn = Amt
                                        Amt = 0
                                    End If
                                    Dim objCommand1 As New SqlCommand("sp_LoanDemand_Collection_Update", objSqlConnection, objTrans)
                                    objCommand1.CommandType = CommandType.StoredProcedure
                                    objCommand1.Parameters.AddWithValue("@DemandCode", LDemandCode)

                                    objCommand1.Parameters.AddWithValue("@CollectionDate", SD(CollDate))
                                    objCommand1.Parameters.AddWithValue("@ODPrincipal", ODPrn)
                                    objCommand1.Parameters.AddWithValue("@ODInterest", ODInt)
                                    objCommand1.Parameters.AddWithValue("@Principal", CollPrn)
                                    objCommand1.Parameters.AddWithValue("@Interest", CollInt)
                                    objCommand1.Parameters.AddWithValue("@Particulars", txtParticulars.Text.Trim)
                                    objCommand1.Parameters.AddWithValue("@ModeofReceipt", lblModeofReceipt.Text.Trim)
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

                                If Val(objLoan.Rows.Item(RowID)("Interest")) - Val(objLoan.Rows.Item(RowID)("CollInterest")) > 0 Then
                                    If Amt >= Val(objLoan.Rows.Item(RowID)("Interest")) Then
                                        CollInt = Val(objLoan.Rows.Item(RowID)("Interest"))
                                        Amt = Amt - Val(objLoan.Rows.Item(RowID)("Interest"))
                                    Else
                                        CollInt = Amt
                                        Amt = 0
                                    End If
                                    Dim objCommand1 As New SqlCommand("sp_LoanDemand_Collection_Update", objSqlConnection, objTrans)
                                    objCommand1.CommandType = CommandType.StoredProcedure
                                    objCommand1.Parameters.AddWithValue("@DemandCode", LDemandCode)

                                    objCommand1.Parameters.AddWithValue("@CollectionDate", SD(CollDate))
                                    objCommand1.Parameters.AddWithValue("@ODPrincipal", ODPrn)
                                    objCommand1.Parameters.AddWithValue("@ODInterest", ODInt)
                                    objCommand1.Parameters.AddWithValue("@Principal", CollPrn)
                                    objCommand1.Parameters.AddWithValue("@Interest", CollInt)
                                    objCommand1.Parameters.AddWithValue("@Particulars", txtParticulars.Text.Trim)
                                    objCommand1.Parameters.AddWithValue("@ModeofReceipt", lblModeofReceipt.Text.Trim)
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

                                If Amt > 0 Then 'Val(objLoan.Rows.Item(RowID)("Principal"))
                                    '    CollPrn = Val(objLoan.Rows.Item(RowID)("Principal"))
                                    '    Amt = Amt - Val(objLoan.Rows.Item(RowID)("Principal"))
                                    'Else
                                    CollPrn = Amt
                                    Amt = 0

                                    Dim objCommand1 As New SqlCommand("sp_LoanDemand_Collection_Update", objSqlConnection, objTrans)
                                    objCommand1.CommandType = CommandType.StoredProcedure
                                    objCommand1.Parameters.AddWithValue("@DemandCode", LDemandCode)

                                    objCommand1.Parameters.AddWithValue("@CollectionDate", SD(CollDate))
                                    objCommand1.Parameters.AddWithValue("@ODPrincipal", ODPrn)
                                    objCommand1.Parameters.AddWithValue("@ODInterest", ODInt)
                                    objCommand1.Parameters.AddWithValue("@Principal", CollPrn)
                                    objCommand1.Parameters.AddWithValue("@Interest", CollInt)
                                    objCommand1.Parameters.AddWithValue("@Particulars", txtParticulars.Text.Trim)
                                    objCommand1.Parameters.AddWithValue("@ModeofReceipt", lblModeofReceipt.Text.Trim)
                                    objCommand1.ExecuteNonQuery()
                                End If
                            Next
                        End If
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
        End If
    End Sub

    Private Sub txtChequeAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMillColection.Leave
        txtMillColection.Text = Format(Val(txtMillColection.Text), "#0.00")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PanelClear(Panel1)
        PanelClear(Panel6)
        Grid.Rows.Clear()
        Grid1.Rows.Clear()
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
        Grid.Enabled = False
    End Sub

    Private Sub cmbTokenNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTokenNo.SelectedIndexChanged
        If cmbTokenNo.SelectedIndex > 0 Then
            pnlUpDate.Visible = True
            dtpUpdationDate.Value = dtpTo.Value
            Grid1.Rows.Clear()
            Grid1.Visible = True
            Grid.Visible = False
            lblModeofReceipt.Text = "I"
        Else
            pnlUpDate.Visible = False
            Grid.Rows.Clear()
            Grid1.Visible = False
            Grid.Visible = True
            lblModeofReceipt.Text = "C"
        End If
        'Grid.Enabled = False
    End Sub

    Private Sub dtpCollectionDate_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles dtpCollectionDate.MaskInputRejected
        If pnlUpDate.Visible = True Then
            dtpUpdationDate.Text = dtpCollectionDate.Text
        End If
        Grid.Enabled = False
    End Sub

    Private Sub dtpUpdationDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpUpdationDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If SD(dtpUpdationDate.Value) > SD(dtpTo.Value) Then
                Grid1.Columns("Demand").Visible = True
                Grid1.Columns("UDate").Visible = True
                dtpCollectionDate.Value = dtpUpdationDate.Value
                btnView.Focus()
            ElseIf SD(dtpUpdationDate.Value) = SD(dtpTo.Value) Then
                Grid1.Columns("Demand").Visible = True
                Grid1.Columns("UDate").Visible = True
                dtpCollectionDate.Value = dtpUpdationDate.Value
                btnView.Focus()
            Else
                MsgBox("Updation Date is Consider as Wrong...Please Check...", MsgBoxStyle.Information, Mssg)
                dtpUpdationDate.Value = dtpTo.Value
                dtpUpdationDate.Focus()
            End If
        End If
    End Sub

    Private Sub dtpUpdationDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpUpdationDate.Leave
        If SD(dtpUpdationDate.Value) > SD(DateAdd(DateInterval.Month, 1, dtpTo.Value)) Then
            MsgBox("Updationdate is invalid...", MsgBoxStyle.Information, Mssg)
            dtpUpdationDate.Focus()
        ElseIf SD(dtpUpdationDate.Value) > SD(dtpTo.Value) Then
            Grid1.Columns("Demand").Visible = True
            Grid1.Columns("UDate").Visible = True
            dtpCollectionDate.Value = dtpUpdationDate.Value
            btnView.Focus()
        ElseIf SD(dtpUpdationDate.Value) = SD(dtpTo.Value) Then
            Grid1.Columns("Demand").Visible = True
            Grid1.Columns("UDate").Visible = True
            dtpCollectionDate.Value = dtpUpdationDate.Value
            btnView.Focus()
        Else
            MsgBox("Updation Date is Consider as Wrong...Please Check...", MsgBoxStyle.Information, Mssg)
            dtpUpdationDate.Value = dtpTo.Value
            dtpUpdationDate.Focus()
        End If
    End Sub

    Private Sub dtpUpdationDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpUpdationDate.LostFocus
        If SD(dtpUpdationDate.Value) > SD(dtpTo.Value) Then
            Grid1.Columns("Demand").Visible = True
        ElseIf SD(dtpUpdationDate.Value) = SD(dtpTo.Value) Then
            Grid1.Columns("Demand").Visible = True
        Else
            MsgBox("Updation Date is Consider as Wrong...Please Check...", MsgBoxStyle.Information, Mssg)
            dtpUpdationDate.Value = dtpTo.Value
        End If
    End Sub

    Private Sub dtpUpdationDate_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles dtpUpdationDate.MaskInputRejected
        Grid.Rows.Clear()
        Grid.Enabled = False
    End Sub

    Private Sub Grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid1.CellContentClick

    End Sub
End Class