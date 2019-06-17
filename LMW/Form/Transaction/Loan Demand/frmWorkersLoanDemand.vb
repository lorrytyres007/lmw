Imports System.Data.SqlClient

Public Class frmWorkersLoanDemand
    Dim fystarting As DateTime
    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        If cmbMonth.SelectedIndex > 0 Then
            fystarting = SD(objDScal("select Dateadd(day,-1,FyStart) from tbl_FYear where fycode=" & int_FYearCode))
            Dim yr As Integer = Year(fystarting)
            Dim mn As Integer = cmbMonth.SelectedIndex + 2
            Dim FD As Integer = 1
            Dim LD As Integer = 20
            If mn > 12 Then
                mn = mn - 12
                yr = yr + 1
            End If
            'Dim NM As Integer = mn + 1
            'Dim Yr1 As Integer = yr
            'If NM > 12 Then
            '    NM = NM - 12
            '    Yr1 = Yr1 + 1
            'End If
            LD = MaxDays(mn, yr)
            dtpFrom.Value = CD(Str(FD) + "/" + Str(mn) + "/" + Str(yr))
            dtpTo.Value = CD(Str(LD) + "/" + Str(mn) + "/" + Str(yr))
        Else
            dtpFrom.Text = ""
            dtpTo.Text = ""
        End If
    End Sub

    Private Sub frmWorkersLoanDemand_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

    Private Sub frmWorkersLoanDemand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbMonth.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculation.Click
        'If cmbMonth.SelectedIndex > 0 Then
        '    Dim Opening As Boolean = True

        '    If cmbMonth.SelectedIndex = 1 And Year(dtpFrom.Value) = 2016 Then
        '        Opn_Balance()
        '        Exit Sub

        '    End If
        '    Dim opnDemand As DataTable = objDT("Select * from tbl_LoanDemand where StaffLoan=0 and Yearno=" & Year(dtpFrom.Value) & "and Monthno=" & Month(dtpTo.Value)) ' & "  & " and  DateFrom >='" & SD(dtpFrom.Value) & "' ") 'having MAX(yearno)>0 and max(MonthNo)>0") 'NewDemand=0 and 

        '    If opnDemand.Rows.Count > 0 Then
        '        Opening = False
        '    Else
        '        Opening = True
        '    End If
        '    Dim objdemand As DataTable

        '    If Opening = True Then
        '        objdemand = objDT("sp_LoanDemand_GetAll @StaffLoan=0 , @Yearno=" & Year(dtpTo.Value) & " , @Monthno=" & Month(dtpTo.Value) & " ,@DateFrom ='" & SD(dtpFrom.Value) & "' ") 'having MAX(yearno)>0 and max(MonthNo)>0") 'NewDemand=0 and 
        '        If objdemand.Rows.Count > 0 Then
        '            MsgBox("Already Demand Saved...", MsgBoxStyle.Information, Mssg)
        '            Exit Sub
        '        End If
        '        Grid.Rows.Clear()
        '        Dim MNO As Integer = Month(dtpFrom.Value)
        '        Dim YNO As Integer = Year(dtpFrom.Value)
        '        Dim DFrom As DateTime = dtpFrom.Value
        '        Dim DTo As DateTime = dtpTo.Value
        '        Dim FC As Integer = int_FYearCode
        '        Dim Days As Integer = 0
        '        Dim Mons As Integer = 0
        '        Dim objLoan As DataTable = objDT("sp_MemberLoan_GetAll  @MemberTYpe='WORKERS'") ',@Membercode=1993")
        '        If objLoan.Rows.Count > 0 Then
        '            For Rowid As Integer = 0 To objLoan.Rows.Count - 1
        '                'If objLoan.Rows.Item(Rowid)("LoanNumber") = 1200 Then
        '                '    MsgBox("WAIT", MsgBoxStyle.Information, Mssg)
        '                ''Else
        '                ''    Exit Sub
        '                'End If
        '                If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(DFrom) Or objLoan.Rows.Item(Rowid)("LoanClossedStatus") = False Then
        '                    If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(DFrom) And SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(DTo) Then
        '                        DTo = objLoan.Rows.Item(Rowid)("MaturityDate")
        '                        Days = DateDiff(DateInterval.Day, dtpFrom.Value, DTo)
        '                        Mons = 0
        '                    Else
        '                        Days = 0
        '                        Mons = 1
        '                    End If

        '                    Dim DPFrom As DateTime = SD(DateAdd(DateInterval.Month, -1, dtpFrom.Value))
        '                    Dim DPTo As DateTime = SD(DateAdd(DateInterval.Month, -1, dtpTo.Value))
        '                    'Dim SQuery As String = "sp_LoanDemand_GetAll @StaffLoan=0,@LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode") & ", @DateTo='" & SD(DPTo) & "',@DateFrom='" & SD(DPFrom) & "'"
        '                    Dim SQuery As String = "sp_loanDemand_MaxDemandCode_GetAll @LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode")
        '                    objdemand = objDT(SQuery)
        '                    'If objdemand.Rows.Count > 0 Then
        '                    Dim LOS As Double = 0
        '                    Dim LPrn As Double = 0
        '                    Dim LInt As Double = 0
        '                    Dim LODP As Double = 0
        '                    Dim LODI As Double = 0
        '                    Dim LDAmtIntCalsi As Double = 0

        '                    Dim Currprin As Double = 0
        '                    Dim CurrInt As Double = 0
        '                    Dim currODP As Double = 0
        '                    Dim currODi As Double = 0


        '                    Dim EMI As Double = objLoan.Rows.Item(Rowid)("EMI_Amount")
        '                    Dim LDAmount As Double = objLoan.Rows.Item(Rowid)("LoanAmount")
        '                    Dim ROI As Double = objLoan.Rows.Item(Rowid)("ROI")

        '                    If objdemand.Rows.Count > 0 Then
        '                        LPrn = IIf(objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalPrincipal") < 0, 0, objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalPrincipal"))
        '                        LInt = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalInterest")
        '                        LODP = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalODPrincipal")
        '                        LODI = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalODInterest")
        '                        LDAmtIntCalsi = objdemand.Rows.Item(objdemand.Rows.Count - 1)("LoanOS") '- LPrn
        '                        LOS = objdemand.Rows.Item(objdemand.Rows.Count - 1)("LoanOS")
        '                        Dim LastDemandDate As DateTime = objdemand.Rows.Item(objdemand.Rows.Count - 1)("DateTo")
        '                        DFrom = DateAdd(DateInterval.Day, 1, LastDemandDate)
        '                        DTo = dtpTo.Value
        '                        Dim BalPrin As Double = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalPrinciPal") + objdemand.Rows.Item(objdemand.Rows.Count - 1)("ODPrinciPal")
        '                        If objLoan.Rows.Item(Rowid)("DemandType") <> 2 Then
        '                            If BalPrin >= (EMI * 3) Then
        '                                If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(dtpFrom.Value) And SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(dtpTo.Value) Then
        '                                    LODI = LODI + Math.Round(SI_EmiDay(BalPrin, DateDiff(DateInterval.Day, DTo, dtpTo.Value), 2), 1)
        '                                    LODP = BalPrin
        '                                ElseIf SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(dtpTo.Value) Then
        '                                    LODI = LODI + Math.Round(SI_Emi(BalPrin, 1, 2), 1)
        '                                    LODP = BalPrin
        '                                End If
        '                            End If
        '                        End If

        '                        If objLoan.Rows.Item(Rowid)("DemandType") = 1 Then
        '                            If SD(dtpFrom.Value) = SD(DFrom) Then
        '                                CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
        '                            Else
        '                                CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
        '                            End If
        '                            If LOS > EMI Then
        '                                Currprin = Format(EMI - CurrInt, "#0.00")
        '                            Else
        '                                Currprin = LOS
        '                            End If
        '                        ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 2 Then
        '                            If SD(dtpFrom.Value) = SD(DFrom) Then
        '                                CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
        '                            Else
        '                                CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
        '                            End If
        '                            Currprin = Format(EMI, "#0.00")

        '                        ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 3 Then
        '                            If SD(dtpFrom.Value) = SD(DFrom) And SD(dtpTo.Value) = SD(DTo) Then
        '                                CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
        '                            Else
        '                                CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
        '                            End If
        '                            Currprin = Format(EMI, "#0.00")
        '                        End If
        '                        If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(dtpFrom.Value) And SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(dtpTo.Value) Then
        '                            CurrInt = Format(CurrInt + SI_EmiDay(IIf(LDAmtIntCalsi <= 0, LOS, LDAmtIntCalsi), DateDiff(DateInterval.Day, DTo, dtpTo.Value), ROI + 2), "#0.00")
        '                            Currprin = LOS
        '                        ElseIf SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(dtpTo.Value) Then
        '                            CurrInt = Format(SI_Emi(LOS, 1, ROI + 2), "#0.00")
        '                            LODI = LODI + CurrInt
        '                            CurrInt = 0
        '                            Currprin = LOS
        '                            LODP = LOS
        '                        End If
        '                        If LOS > 0 Then
        '                            Grid.Rows.Add(1)
        '                            Grid.Item("DateFrom", Grid.Rows.Count - 1).Value = SD(DFrom)
        '                            Grid.Item("DateTo", Grid.Rows.Count - 1).Value = SD(DTo)
        '                            Grid.Item("MonthNo", Grid.Rows.Count - 1).Value = Month(dtpTo.Value)
        '                            Grid.Item("YearNo", Grid.Rows.Count - 1).Value = Year(dtpTo.Value)
        '                            Grid.Item("DemandDate", Grid.Rows.Count - 1).Value = SD(dtpFrom.Value)
        '                            Grid.Item("FYCode", Grid.Rows.Count - 1).Value = FC
        '                            Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MemberCode")
        '                            Grid.Item("LoanCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanCode")
        '                            Grid.Item("LoanNo", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanNumber")
        '                            Grid.Item("MaturityDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MaturityDate")
        '                            Grid.Item("LoanDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("Loandate")
        '                            Grid.Item("LoanROI", Grid.Rows.Count - 1).Value = ROI
        '                            Grid.Item("LoanOutStanding", Grid.Rows.Count - 1).Value = LOS
        '                            Grid.Item("TokenNumber", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("EmployeeNumber")
        '                            Grid.Item("LoanPrincipal", Grid.Rows.Count - 1).Value = LPrn
        '                            Grid.Item("LoanInterest", Grid.Rows.Count - 1).Value = LInt
        '                            Grid.Item("LoanODPrincipal", Grid.Rows.Count - 1).Value = LODP
        '                            Grid.Item("LoanODInterest", Grid.Rows.Count - 1).Value = LODI
        '                            Grid.Item("CurrPrincipal", Grid.Rows.Count - 1).Value = Currprin
        '                            Grid.Item("CurrInterest", Grid.Rows.Count - 1).Value = CurrInt
        '                            Grid.Item("CurrODPrincipal", Grid.Rows.Count - 1).Value = currODP
        '                            Grid.Item("CurrODInterest", Grid.Rows.Count - 1).Value = currODi
        '                            Grid.Item("BalPrincipal", Grid.Rows.Count - 1).Value = Currprin + LODP - IIf(LDAmtIntCalsi - LPrn <= 0, LPrn, 0)
        '                            Grid.Item("BalInterest", Grid.Rows.Count - 1).Value = LInt + CurrInt
        '                            Grid.Item("BalODPrincipal", Grid.Rows.Count - 1).Value = currODP
        '                            Grid.Item("BalODInterest", Grid.Rows.Count - 1).Value = LODI + currODi
        '                            Grid.Item("LoanOutstanding", Grid.Rows.Count - 1).Value = LOS
        '                            Grid.Item("CollOS", Grid.Rows.Count - 1).Value = LOS
        '                            Grid.Item("LoanOS", Grid.Rows.Count - 1).Value = LOS
        '                            Grid.Item("Loanosforint", Grid.Rows.Count - 1).Value = LDAmtIntCalsi - LPrn
        '                            Grid.Item("StaffLoan", Grid.Rows.Count - 1).Value = 0
        '                            Grid.Item("WorkerLoan", Grid.Rows.Count - 1).Value = 1
        '                        End If
        '                    Else

        '                        SQuery = "sp_MemberLoan_GetAll @MemberType='WORKERS',@LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode") & ",@MemberCode=" & objLoan.Rows.Item(Rowid)("MemberCode") & ",@FromDate='" & SD(dtpFrom.Value) & "',@ToDate='" & SD(dtpTo.Value) & "'"
        '                        objdemand = objDT(SQuery)
        '                        Dim SQuery1 As String = "select max(DemandCode)DemandCode from tbl_loandemand where LoanCode =" & objLoan.Rows.Item(Rowid)("LoanCode") & " and  membercode=" & objLoan.Rows.Item(Rowid)("MemberCode")
        '                        Dim objMAXDemand As DataTable = objDT(SQuery1)
        '                        Dim MaxLoanDemand As Integer = IIf(IsDBNull(objMAXDemand.Rows.Item(0)("DemandCode")) = False, objMAXDemand.Rows.Item(0)("DemandCode"), 0)
        '                        Dim SQuery2 As String = "select * from tbl_loandemand where DemandCode = " & MaxLoanDemand
        '                        Dim objLoanDemand As DataTable = objDT(SQuery2)
        '                        Dim LastDemandDate As DateTime
        '                        If objdemand.Rows.Count > 0 Then
        '                            If objLoanDemand.Rows.Count > 0 Then
        '                                LOS = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("LoanOS")
        '                                LODP = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("ODPrincipal") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollODPrincipal")
        '                                LODI = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("ODInterest") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollODInterest")
        '                                LDAmtIntCalsi = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("LoanOutStanding") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollPrincipal")
        '                                LastDemandDate = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("DateTo")
        '                            Else
        '                                LOS = objdemand.Rows.Item(0)("LoanOutstanding")
        '                                LODP = objdemand.Rows.Item(0)("ODPrincipal")
        '                                LODI = objdemand.Rows.Item(0)("ODInterest")
        '                                LDAmtIntCalsi = objdemand.Rows.Item(0)("LoanOutStanding")
        '                                LastDemandDate = objdemand.Rows.Item(0)("LoanDate")
        '                            End If
        '                            'LOS = IIf(objLoanDemand.Rows.Count = 0, objdemand.Rows.Item(0)("LoanOutstanding"), objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("LoanOS"))
        '                            LPrn = 0
        '                            Dim CalsiInt As Double = objdemand.Rows.Item(objdemand.Rows.Count - 1)("ROI")
        '                            LInt = 0
        '                            DFrom = LastDemandDate
        '                            If objLoan.Rows.Item(Rowid)("DemandType") = 1 Then
        '                                If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
        '                                    CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
        '                                Else
        '                                    CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
        '                                End If
        '                                If LOS > EMI Then
        '                                    Currprin = Format(EMI - CurrInt, "#0.00")
        '                                Else
        '                                    Currprin = LOS
        '                                End If
        '                            ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 2 Then
        '                                If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
        '                                    CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
        '                                Else
        '                                    CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
        '                                End If
        '                                Currprin = Format(EMI, "#0.00")

        '                            ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 3 Then
        '                                If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
        '                                    CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
        '                                Else
        '                                    CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
        '                                End If
        '                                Currprin = Format(EMI, "#0.00")
        '                            End If
        '                            If LOS > 0 Then
        '                                Grid.Rows.Add(1)
        '                                Grid.Item("DateFrom", Grid.Rows.Count - 1).Value = SD(DFrom)
        '                                Grid.Item("DateTo", Grid.Rows.Count - 1).Value = SD(dtpTo.Value)
        '                                Grid.Item("MonthNo", Grid.Rows.Count - 1).Value = Month(dtpTo.Value)
        '                                Grid.Item("YearNo", Grid.Rows.Count - 1).Value = Year(DFrom)
        '                                Grid.Item("DemandDate", Grid.Rows.Count - 1).Value = SD(dtpFrom.Value)
        '                                Grid.Item("FYCode", Grid.Rows.Count - 1).Value = FC
        '                                Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MemberCode")
        '                                Grid.Item("LoanCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanCode")
        '                                Grid.Item("LoanNo", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanNumber")
        '                                Grid.Item("MaturityDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MaturityDate")
        '                                Grid.Item("LoanDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("Loandate")
        '                                Grid.Item("LoanROI", Grid.Rows.Count - 1).Value = ROI
        '                                Grid.Item("LoanOutStanding", Grid.Rows.Count - 1).Value = LOS
        '                                Grid.Item("TokenNumber", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("EmployeeNumber")
        '                                Grid.Item("LoanPrincipal", Grid.Rows.Count - 1).Value = LPrn
        '                                Grid.Item("LoanInterest", Grid.Rows.Count - 1).Value = LInt
        '                                Grid.Item("LoanODPrincipal", Grid.Rows.Count - 1).Value = LODP
        '                                Grid.Item("LoanODInterest", Grid.Rows.Count - 1).Value = LODI
        '                                Grid.Item("CurrPrincipal", Grid.Rows.Count - 1).Value = Currprin
        '                                Grid.Item("CurrInterest", Grid.Rows.Count - 1).Value = CurrInt
        '                                Grid.Item("CurrODPrincipal", Grid.Rows.Count - 1).Value = currODP
        '                                Grid.Item("CurrODInterest", Grid.Rows.Count - 1).Value = currODi
        '                                Grid.Item("BalPrincipal", Grid.Rows.Count - 1).Value = LPrn + Currprin
        '                                Grid.Item("BalInterest", Grid.Rows.Count - 1).Value = LInt + CurrInt
        '                                Grid.Item("BalODPrincipal", Grid.Rows.Count - 1).Value = LODP + currODP
        '                                Grid.Item("BalODInterest", Grid.Rows.Count - 1).Value = LODI + currODi
        '                                Grid.Item("LoanOutstanding", Grid.Rows.Count - 1).Value = LOS
        '                                Grid.Item("CollOS", Grid.Rows.Count - 1).Value = LOS
        '                                Grid.Item("LoanOS", Grid.Rows.Count - 1).Value = LOS
        '                                Grid.Item("Loanosforint", Grid.Rows.Count - 1).Value = LDAmtIntCalsi
        '                                Grid.Item("StaffLoan", Grid.Rows.Count - 1).Value = 0
        '                                Grid.Item("WorkerLoan", Grid.Rows.Count - 1).Value = 1
        '                            End If
        '                        End If
        '                    End If
        '                End If
        '            Next
        '        Else
        '            MsgBox("SORRY! No Loan Data is Found...", MsgBoxStyle.Information, Mssg)
        '        End If
        '    Else
        '        MsgBox("Already Demand Saved...", MsgBoxStyle.Information, Mssg)
        '        Exit Sub
        '    End If
        'End If
        If cmbMonth.SelectedIndex > 0 Then
            Dim Opening As Boolean = True

            If cmbMonth.SelectedIndex = 1 And Year(dtpFrom.Value) = 2016 Then
                Opn_Balance()
                Exit Sub

            End If
            Dim opnDemand As DataTable = objDT("Select * from tbl_LoanDemand where StaffLoan=0 and Yearno=" & Year(dtpTo.Value) & "and Monthno=" & Month(dtpTo.Value)) ' & "  & " and  DateFrom >='" & SD(dtpFrom.Value) & "' ") 'having MAX(yearno)>0 and max(MonthNo)>0") 'NewDemand=0 and 

            If opnDemand.Rows.Count > 0 Then
                Opening = False
            Else
                Opening = True
            End If
            Dim objdemand As DataTable

            If Opening = True Then
                objdemand = objDT("sp_LoanDemand_GetAll @StaffLoan=0 , @Yearno=" & Year(dtpTo.Value) & " , @Monthno=" & Month(dtpFrom.Value) & " ,@DateFrom ='" & SD(dtpFrom.Value) & "' ") 'having MAX(yearno)>0 and max(MonthNo)>0") 'NewDemand=0 and 
                If objdemand.Rows.Count > 0 Then
                    MsgBox("Already Demand Saved...", MsgBoxStyle.Information, Mssg)
                    Exit Sub
                End If
                Grid.Rows.Clear()
                Dim MNO As Integer = Month(dtpFrom.Value)
                Dim YNO As Integer = Year(dtpFrom.Value)
                Dim DFrom As DateTime = dtpFrom.Value
                Dim DTo As DateTime = dtpTo.Value
                Dim FC As Integer = int_FYearCode
                Dim Days As Integer = 0
                Dim Mons As Integer = 0
                Dim objLoan As DataTable = objDT("sp_MemberLoan_GetAll  @MemberTYpe='WORKERS'") ',@Membercode=1993")
                If objLoan.Rows.Count > 0 Then
                    For Rowid As Integer = 0 To objLoan.Rows.Count - 1
                        'If objLoan.Rows.Item(Rowid)("LoanNumber") = 1329 Then
                        '    MsgBox("WAIT", MsgBoxStyle.Information, Mssg)
                        '    'Else
                        '    '    Exit Sub
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
                            'Dim SQuery As String = "sp_LoanDemand_GetAll @StaffLoan=0,@LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode") & ", @DateTo='" & SD(DPTo) & "',@DateFrom='" & SD(DPFrom) & "'"
                            Dim SQuery As String = "sp_loanDemand_MaxDemandCode_GetAll @LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode")
                            objdemand = objDT(SQuery)
                            'If objdemand.Rows.Count > 0 Then
                            Dim LOS As Double = 0
                            Dim LPrn As Double = 0
                            Dim LInt As Double = 0
                            Dim LODP As Double = 0
                            Dim LODI As Double = 0
                            Dim LDAmtIntCalsi As Double = 0

                            Dim Currprin As Double = 0
                            Dim CurrInt As Double = 0
                            Dim currODP As Double = 0
                            Dim currODi As Double = 0


                            Dim EMI As Double = objLoan.Rows.Item(Rowid)("EMI_Amount")
                            Dim LDAmount As Double = objLoan.Rows.Item(Rowid)("LoanAmount")
                            Dim ROI As Double = objLoan.Rows.Item(Rowid)("ROI")

                            If objdemand.Rows.Count > 0 Then
                                LPrn = IIf(objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalPrincipal") < 0, 0, objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalPrincipal"))
                                LInt = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalInterest")
                                LODP = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalODPrincipal")
                                LODI = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalODInterest")
                                LDAmtIntCalsi = objdemand.Rows.Item(objdemand.Rows.Count - 1)("LoanOS") '- LPrn
                                LOS = objdemand.Rows.Item(objdemand.Rows.Count - 1)("LoanOS")
                                Dim LastDemandDate As DateTime = objdemand.Rows.Item(objdemand.Rows.Count - 1)("DateTo")
                                DFrom = DateAdd(DateInterval.Day, 1, LastDemandDate)
                                DTo = dtpTo.Value
                                Dim BalPrin As Double = objdemand.Rows.Item(objdemand.Rows.Count - 1)("BalPrinciPal") + IIf(IsDBNull(objdemand.Rows.Item(objdemand.Rows.Count - 1)("ODPrinciPal")) = True, 0, objdemand.Rows.Item(objdemand.Rows.Count - 1)("ODPrinciPal"))
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
                                    If LOS > 0 Then
                                        If SD(dtpFrom.Value) = SD(DFrom) Then
                                            CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                        Else
                                            CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
                                        End If
                                        If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(DTo) Then
                                            Currprin = LOS
                                        Else
                                            Currprin = Format(EMI - CurrInt, "#0.00")
                                        End If
                                    Else
                                        CurrInt = 0
                                        Currprin = 0
                                    End If
                                ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 2 Then
                                    If SD(dtpFrom.Value) = SD(DFrom) Then
                                        CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                    Else
                                        CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
                                    End If
                                    If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(DTo) Then
                                        Currprin = LOS
                                    Else
                                        Currprin = Format(EMI, "#0.00")
                                    End If

                                ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 3 Then
                                    If SD(dtpFrom.Value) = SD(DFrom) And SD(dtpTo.Value) = SD(DTo) Then
                                        CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                    Else
                                        CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
                                    End If
                                    If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(DTo) Then
                                        Currprin = LOS
                                    Else
                                        Currprin = Format(EMI, "#0.00")
                                    End If
                                End If
                                If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(dtpFrom.Value) And SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(dtpTo.Value) Then
                                    CurrInt = Format(CurrInt + SI_EmiDay(IIf(LDAmtIntCalsi <= 0, LOS, LDAmtIntCalsi), DateDiff(DateInterval.Day, DTo, dtpTo.Value), ROI + 2), "#0.00")
                                    Currprin = LOS
                                ElseIf SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(dtpTo.Value) Then
                                    CurrInt = Format(SI_Emi(LOS, 1, ROI + 2), "#0.00")
                                    LODI = LODI + CurrInt
                                    CurrInt = 0
                                    Currprin = LOS
                                    LODP = LOS
                                End If
                                If LOS > 0 Then
                                    Grid.Rows.Add(1)
                                    Grid.Item("DateFrom", Grid.Rows.Count - 1).Value = SD(DFrom)
                                    Grid.Item("DateTo", Grid.Rows.Count - 1).Value = SD(DTo)
                                    Grid.Item("MonthNo", Grid.Rows.Count - 1).Value = Month(dtpTo.Value)
                                    Grid.Item("YearNo", Grid.Rows.Count - 1).Value = Year(dtpTo.Value)
                                    Grid.Item("DemandDate", Grid.Rows.Count - 1).Value = SD(dtpFrom.Value)
                                    Grid.Item("FYCode", Grid.Rows.Count - 1).Value = FC
                                    Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MemberCode")
                                    Grid.Item("LoanCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanCode")
                                    Grid.Item("LoanNo", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanNumber")
                                    Grid.Item("MaturityDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MaturityDate")
                                    Grid.Item("LoanDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("Loandate")
                                    Grid.Item("LoanROI", Grid.Rows.Count - 1).Value = ROI
                                    Grid.Item("LoanOutStanding", Grid.Rows.Count - 1).Value = LOS
                                    Grid.Item("TokenNumber", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("EmployeeNumber")
                                    Grid.Item("LoanPrincipal", Grid.Rows.Count - 1).Value = LPrn
                                    Grid.Item("LoanInterest", Grid.Rows.Count - 1).Value = LInt
                                    Grid.Item("LoanODPrincipal", Grid.Rows.Count - 1).Value = LODP
                                    Grid.Item("LoanODInterest", Grid.Rows.Count - 1).Value = LODI
                                    Grid.Item("CurrPrincipal", Grid.Rows.Count - 1).Value = Currprin
                                    Grid.Item("CurrInterest", Grid.Rows.Count - 1).Value = CurrInt
                                    Grid.Item("CurrODPrincipal", Grid.Rows.Count - 1).Value = currODP
                                    Grid.Item("CurrODInterest", Grid.Rows.Count - 1).Value = currODi
                                    Grid.Item("BalPrincipal", Grid.Rows.Count - 1).Value = Currprin + LPrn + LODP - IIf(LDAmtIntCalsi - LPrn <= 0, LPrn, 0)
                                    Grid.Item("BalInterest", Grid.Rows.Count - 1).Value = LInt + CurrInt
                                    Grid.Item("BalODPrincipal", Grid.Rows.Count - 1).Value = currODP
                                    Grid.Item("BalODInterest", Grid.Rows.Count - 1).Value = LODI + currODi
                                    Grid.Item("LoanOutstanding", Grid.Rows.Count - 1).Value = LOS
                                    Grid.Item("CollOS", Grid.Rows.Count - 1).Value = LOS
                                    Grid.Item("LoanOS", Grid.Rows.Count - 1).Value = LOS
                                    Grid.Item("Loanosforint", Grid.Rows.Count - 1).Value = LDAmtIntCalsi - LPrn
                                    Grid.Item("StaffLoan", Grid.Rows.Count - 1).Value = 0
                                    Grid.Item("WorkerLoan", Grid.Rows.Count - 1).Value = 1
                                End If
                            Else

                                SQuery = "sp_MemberLoan_GetAll @MemberType='WORKERS',@LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode") & ",@MemberCode=" & objLoan.Rows.Item(Rowid)("MemberCode") & ",@FromDate='" & SD(dtpFrom.Value) & "',@ToDate='" & SD(dtpTo.Value) & "'"
                                objdemand = objDT(SQuery)
                                Dim SQuery1 As String = "select max(DemandCode)DemandCode from tbl_loandemand where LoanCode =" & objLoan.Rows.Item(Rowid)("LoanCode") & " and  membercode=" & objLoan.Rows.Item(Rowid)("MemberCode")
                                Dim objMAXDemand As DataTable = objDT(SQuery1)
                                Dim MaxLoanDemand As Integer = IIf(IsDBNull(objMAXDemand.Rows.Item(0)("DemandCode")) = False, objMAXDemand.Rows.Item(0)("DemandCode"), 0)
                                Dim SQuery2 As String = "select * from tbl_loandemand where DemandCode = " & MaxLoanDemand
                                Dim objLoanDemand As DataTable = objDT(SQuery2)
                                Dim LastDemandDate As DateTime
                                If objdemand.Rows.Count > 0 Then
                                    If objLoanDemand.Rows.Count > 0 Then
                                        LOS = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("LoanOS")
                                        LODP = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("ODPrincipal") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollODPrincipal")
                                        LODI = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("ODInterest") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollODInterest")
                                        LDAmtIntCalsi = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("LoanOutStanding") - objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("CollPrincipal")
                                        LastDemandDate = objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("DateTo")
                                    Else
                                        LOS = objdemand.Rows.Item(0)("LoanOutstanding")
                                        LODP = objdemand.Rows.Item(0)("ODPrincipal")
                                        LODI = objdemand.Rows.Item(0)("ODInterest")
                                        LDAmtIntCalsi = objdemand.Rows.Item(0)("LoanOutStanding")
                                        LastDemandDate = objdemand.Rows.Item(0)("LoanDate")
                                    End If
                                    'LOS = IIf(objLoanDemand.Rows.Count = 0, objdemand.Rows.Item(0)("LoanOutstanding"), objLoanDemand.Rows.Item(objLoanDemand.Rows.Count - 1)("LoanOS"))
                                    LPrn = 0
                                    Dim CalsiInt As Double = objdemand.Rows.Item(objdemand.Rows.Count - 1)("ROI")
                                    LInt = 0
                                    DFrom = LastDemandDate
                                    If objLoan.Rows.Item(Rowid)("DemandType") = 1 Then
                                        If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
                                            CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                        Else
                                            CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
                                        End If
                                        If LOS > EMI Then
                                            Currprin = Format(EMI - CurrInt, "#0.00")
                                        Else
                                            Currprin = LOS
                                        End If
                                    ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 2 Then
                                        If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
                                            CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                        Else
                                            CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
                                        End If
                                        Currprin = Format(EMI, "#0.00")

                                    ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 3 Then
                                        If DateAdd(DateInterval.Day, -1, dtpFrom.Value) = SD(DFrom) Then
                                            CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                                        Else
                                            CurrInt = Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo) + 1, ROI), "#0.00")
                                        End If
                                        Currprin = Format(EMI, "#0.00")
                                    End If
                                    If LOS > 0 Then
                                        Grid.Rows.Add(1)
                                        Grid.Item("DateFrom", Grid.Rows.Count - 1).Value = SD(DFrom)
                                        Grid.Item("DateTo", Grid.Rows.Count - 1).Value = SD(dtpTo.Value)
                                        Grid.Item("MonthNo", Grid.Rows.Count - 1).Value = Month(dtpTo.Value)
                                        Grid.Item("YearNo", Grid.Rows.Count - 1).Value = Year(DFrom)
                                        Grid.Item("DemandDate", Grid.Rows.Count - 1).Value = SD(dtpFrom.Value)
                                        Grid.Item("FYCode", Grid.Rows.Count - 1).Value = FC
                                        Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MemberCode")
                                        Grid.Item("LoanCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanCode")
                                        Grid.Item("LoanNo", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanNumber")
                                        Grid.Item("MaturityDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MaturityDate")
                                        Grid.Item("LoanDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("Loandate")
                                        Grid.Item("LoanROI", Grid.Rows.Count - 1).Value = ROI
                                        Grid.Item("LoanOutStanding", Grid.Rows.Count - 1).Value = LOS
                                        Grid.Item("TokenNumber", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("EmployeeNumber")
                                        Grid.Item("LoanPrincipal", Grid.Rows.Count - 1).Value = LPrn
                                        Grid.Item("LoanInterest", Grid.Rows.Count - 1).Value = LInt
                                        Grid.Item("LoanODPrincipal", Grid.Rows.Count - 1).Value = LODP
                                        Grid.Item("LoanODInterest", Grid.Rows.Count - 1).Value = LODI
                                        Grid.Item("CurrPrincipal", Grid.Rows.Count - 1).Value = Currprin
                                        Grid.Item("CurrInterest", Grid.Rows.Count - 1).Value = CurrInt
                                        Grid.Item("CurrODPrincipal", Grid.Rows.Count - 1).Value = currODP
                                        Grid.Item("CurrODInterest", Grid.Rows.Count - 1).Value = currODi
                                        Grid.Item("BalPrincipal", Grid.Rows.Count - 1).Value = LPrn + Currprin
                                        Grid.Item("BalInterest", Grid.Rows.Count - 1).Value = LInt + CurrInt
                                        Grid.Item("BalODPrincipal", Grid.Rows.Count - 1).Value = LODP + currODP
                                        Grid.Item("BalODInterest", Grid.Rows.Count - 1).Value = LODI + currODi
                                        Grid.Item("LoanOutstanding", Grid.Rows.Count - 1).Value = LOS
                                        Grid.Item("CollOS", Grid.Rows.Count - 1).Value = LOS
                                        Grid.Item("LoanOS", Grid.Rows.Count - 1).Value = LOS
                                        Grid.Item("Loanosforint", Grid.Rows.Count - 1).Value = LDAmtIntCalsi
                                        Grid.Item("StaffLoan", Grid.Rows.Count - 1).Value = 0
                                        Grid.Item("WorkerLoan", Grid.Rows.Count - 1).Value = 1
                                    End If
                                End If
                            End If
                            'End If
                        End If
                    Next
                Else
                    MsgBox("SORRY! No Loan Data is Found...", MsgBoxStyle.Information, Mssg)
                End If
            Else
                MsgBox("Already Demand Saved...", MsgBoxStyle.Information, Mssg)
                Exit Sub
            End If
        End If
    End Sub
    Private Sub Opn_Balance()
        Dim opnDemand As DataTable = objDT("Select * from tbl_LoanDemand ")
        If opnDemand.Rows.Count > 0 Then
            MsgBox("Sorry ! we done the process earlier", MsgBoxStyle.Information, Mssg)
            Exit Sub
        End If
        Grid.Rows.Clear()
        'Dim objdemand As DataTable

        Dim MNO As Integer = Month(dtpFrom.Value)
        Dim YNO As Integer = Year(dtpFrom.Value)
        Dim DFrom As DateTime = dtpFrom.Value
        Dim DTo As DateTime = dtpTo.Value
        Dim FC As Integer = int_FYearCode
        Dim Days As Integer = 0
        Dim Mons As Integer = 0
        Dim objLoan As DataTable = objDT("sp_MemberLoan_GetAll @MemberTYpe='STAFF'")
        If objLoan.Rows.Count > 0 Then
            For Rowid As Integer = 0 To objLoan.Rows.Count - 1
                'If objLoan.Rows.Item(Rowid)("LoanNumber") = 544 Then
                '    MsgBox("WAIT", MsgBoxStyle.Information, Mssg)
                'End If
                If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(DFrom) Then
                    If SD(objLoan.Rows.Item(Rowid)("MaturityDate")) > SD(DFrom) And SD(objLoan.Rows.Item(Rowid)("MaturityDate")) < SD(DTo) Then
                        DTo = objLoan.Rows.Item(Rowid)("MaturityDate")
                        Days = DateDiff(DateInterval.Day, dtpFrom.Value, DTo)
                        Mons = 0
                    Else
                        Days = 0
                        Mons = 1
                    End If

                    Dim DPFrom As DateTime = SD(dtpFrom.Value)
                    Dim DPTo As DateTime = SD(dtpTo.Value)
                    'Dim SQuery As String = "Select * from tbl_MemberLoan where StaffLoan=1 and LoanCode=" & objLoan.Rows.Item(Rowid)("LoanCode") & ", @DateTo='" & SD(DPTo) & "',@DateFrom='" & SD(DPFrom) & "'"
                    'objdemand = objDT(SQuery)

                    Dim LOS As Double = 0
                    Dim LPrn As Double = 0
                    Dim LInt As Double = 0
                    Dim LODP As Double = 0
                    Dim LODI As Double = 0
                    Dim LDAmtIntCalsi As Double = 0

                    Dim Currprin As Double = 0
                    Dim CurrInt As Double = 0
                    Dim currODP As Double = 0
                    Dim currODi As Double = 0
                    Dim EMI As Double = objLoan.Rows.Item(Rowid)("EMI_Amount")
                    Dim LDAmount As Double = objLoan.Rows.Item(Rowid)("LoanAmount")
                    Dim ROI As Double = objLoan.Rows.Item(Rowid)("ROI")

                    'If objdemand.Rows.Count > 0 Then
                    LPrn = objLoan.Rows.Item(Rowid)("LoanOutStanding")
                    LInt = objLoan.Rows.Item(Rowid)("Interest")
                    LODP = objLoan.Rows.Item(Rowid)("ODPrincipal")
                    LODI = objLoan.Rows.Item(Rowid)("ODInterest")
                    LDAmtIntCalsi = objLoan.Rows.Item(Rowid)("LoanOutStanding") '- LPrn
                    LOS = objLoan.Rows.Item(Rowid)("LoanOutStanding")
                    Dim LastDemandDate As DateTime = objLoan.Rows.Item(Rowid)("LastPaidDate")
                    DFrom = DateAdd(DateInterval.Day, 1, LastDemandDate)

                    If objLoan.Rows.Item(Rowid)("DemandType") = 1 Then
                        If SD(dtpFrom.Value) = SD(DFrom) Then
                            CurrInt = LInt 'Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                        Else
                            CurrInt = LInt 'Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo), ROI), "#0.00")
                        End If
                        Currprin = Format(EMI - CurrInt, "#0.00")
                    ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 2 Then
                        If SD(dtpFrom.Value) = SD(DFrom) Then
                            CurrInt = LInt 'Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                        Else
                            CurrInt = LInt 'Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo), ROI), "#0.00")
                        End If
                        CurrInt = Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                    ElseIf objLoan.Rows.Item(Rowid)("DemandType") = 3 Then
                        If SD(dtpFrom.Value) = SD(DFrom) Then
                            CurrInt = LInt 'Format(SI_Emi(LDAmtIntCalsi, 1, ROI), "#0.00")
                        Else
                            CurrInt = LInt ' Format(SI_EmiDay(LDAmtIntCalsi, DateDiff(DateInterval.Day, DFrom, DTo), ROI), "#0.00")
                        End If
                        Currprin = Format(Val(objLoan.Rows.Item(Rowid)("LoanAmount")) / Val(objLoan.Rows.Item(Rowid)("LoanPeriod")), "#0.00")
                    End If
                    Grid.Rows.Add(1)
                    Grid.Item("DateFrom", Grid.Rows.Count - 1).Value = SD(DFrom)
                    Grid.Item("DateTo", Grid.Rows.Count - 1).Value = SD(DTo)
                    Grid.Item("MonthNo", Grid.Rows.Count - 1).Value = Month(dtpTo.Value)
                    Grid.Item("YearNo", Grid.Rows.Count - 1).Value = Year(dtpTo.Value)
                    Grid.Item("DemandDate", Grid.Rows.Count - 1).Value = SD(dtpFrom.Value)
                    Grid.Item("FYCode", Grid.Rows.Count - 1).Value = FC
                    Grid.Item("MemberCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MemberCode")
                    Grid.Item("LoanCode", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanCode")
                    Grid.Item("LoanNo", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("LoanNumber")
                    Grid.Item("MaturityDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("MaturityDate")
                    Grid.Item("LoanDate", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("Loandate")
                    Grid.Item("LoanROI", Grid.Rows.Count - 1).Value = ROI
                    Grid.Item("LoanOutStanding", Grid.Rows.Count - 1).Value = LOS
                    Grid.Item("TokenNumber", Grid.Rows.Count - 1).Value = objLoan.Rows.Item(Rowid)("EmployeeNumber")
                    Grid.Item("LoanPrincipal", Grid.Rows.Count - 1).Value = LPrn
                    Grid.Item("LoanInterest", Grid.Rows.Count - 1).Value = LInt
                    Grid.Item("LoanODPrincipal", Grid.Rows.Count - 1).Value = LODP
                    Grid.Item("LoanODInterest", Grid.Rows.Count - 1).Value = LODI
                    Grid.Item("CurrPrincipal", Grid.Rows.Count - 1).Value = Currprin
                    Grid.Item("CurrInterest", Grid.Rows.Count - 1).Value = CurrInt
                    Grid.Item("CurrODPrincipal", Grid.Rows.Count - 1).Value = currODP
                    Grid.Item("CurrODInterest", Grid.Rows.Count - 1).Value = currODi
                    Grid.Item("BalPrincipal", Grid.Rows.Count - 1).Value = LPrn '+ Currprin
                    Grid.Item("BalInterest", Grid.Rows.Count - 1).Value = LInt '+ CurrInt
                    Grid.Item("BalODPrincipal", Grid.Rows.Count - 1).Value = LODP '+ currODP
                    Grid.Item("BalODInterest", Grid.Rows.Count - 1).Value = LODI '+ currODi
                    Grid.Item("LoanOutstanding", Grid.Rows.Count - 1).Value = LOS
                    Grid.Item("CollOS", Grid.Rows.Count - 1).Value = LOS
                    Grid.Item("LoanOS", Grid.Rows.Count - 1).Value = LOS
                    Grid.Item("Loanosforint", Grid.Rows.Count - 1).Value = LOS - LPrn
                    Grid.Item("StaffLoan", Grid.Rows.Count - 1).Value = 0
                    Grid.Item("WorkerLoan", Grid.Rows.Count - 1).Value = 1
                    'End If
                End If
            Next
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbMonth.SelectedIndex = 0
        Grid.Rows.Clear()
        cmbMonth.Focus()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ObjTrans As SqlTransaction
        ObjTrans = objSqlConnection.BeginTransaction

        Try
            For Rowindex As Integer = 0 To Grid.Rows.Count - 1

                Dim objcommand As New SqlCommand("sp_LoanDemand_Insert", objSqlConnection, ObjTrans)
                objcommand.CommandType = CommandType.StoredProcedure
                'objcommand.Parameters.AddWithValue("@DemandCode", Grid.Item("demandCode", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@DateFrom ", Grid.Item("DateFrom", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@DateTo ", Grid.Item("DateTo", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@MonthNo", Grid.Item("MonthNo", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@YearNo", Grid.Item("YearNo", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@DemandDate ", Grid.Item("DemandDate", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@Fycode", Grid.Item("Fycode", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@MemberCode", Grid.Item("MemberCode", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@LoanCode", Grid.Item("LoanCode", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@LoanOutStanding", Grid.Item("LoanOs", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@Principal", Grid.Item("BalPrincipal", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@Interest", Grid.Item("BalInterest", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@ODPrincipal", Grid.Item("BalODPrincipal", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@ODInterest", Grid.Item("BalODInterest", Rowindex).Value)
                'objcommand.Parameters.AddWithValue("@CollDate", Grid.Item("demandCode", Rowindex).Value)
                'objcommand.Parameters.AddWithValue("@CollPrincipal", Grid.Item("demandCode", Rowindex).Value)
                'objcommand.Parameters.AddWithValue("@CollInterest", Grid.Item("demandCode", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@NewDemand", 0)
                'objcommand.Parameters.AddWithValue("@CollODInterest", Grid.Item("demandCode", Rowindex).Value)
                'objcommand.Parameters.AddWithValue("@CollODPrincipal", Grid.Item("demandCode", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@CollOS", Grid.Item("CollOS", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@LoanOs", Grid.Item("LoanOs", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@LoanOSforInt", Grid.Item("LoanOSforInt", Rowindex).Value)
                objcommand.Parameters.AddWithValue("@StaffLoan", 0)
                objcommand.Parameters.AddWithValue("@WorkerLoan ", 1)
                objcommand.ExecuteNonQuery()
            Next
            ObjTrans.Commit()
            ObjTrans.Dispose()
            MsgBox("UpDated Successfully....", MsgBoxStyle.Information, Mssg)
            btnClear_Click(sender, e)
        Catch ex As Exception
            ObjTrans.Rollback()
            ObjTrans.Dispose()
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try

    End Sub
End Class