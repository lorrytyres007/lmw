Imports System.Data.SqlClient

Public Class frmMemberLoan

    Dim Bool_Edit As Boolean = False

    Private Sub frmMemberLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bool_Edit = False Then
            BindData()
            dtpLoanDate.Value = CurDate
            'Else
            ' btnSave_Click(sender, e)
        End If
    End Sub
    Private Sub BindData()
        cmbEmpNo.RecordSet(objDT("sp_Member_GetAll"), "strEmpno", "MemberCode")
        cmbLoanName.RecordSet(objDT("sp_LoanName_GetAll"), "LoanName", "LoanNameCode")
        cmbPaymode.SelectedIndex = 0
        dtpLastPaiddate.CustomFormat = "dd/MM/yyyy"
        dtpLoanDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            bool_Edit = True
            BindData()
            txtLoanCode.Text = DataRow.Cells("LoanCode").Value
            cmbEmpNo.SelectedValue = DataRow.Cells("Membercode").Value
            txtLoanNo.Text = DataRow.Cells("LoanNumber").Value
            txtEmpNumber.Text = DataRow.Cells("membercode").Value
            cmbLoanName.SelectedValue = DataRow.Cells("loanNamecode").Value
            txtROI.Text = DataRow.Cells("ROI").Value
            dtpLoanDate.Value = DataRow.Cells("LoanDate").Value
            dtpLoanDate.CustomFormat = "dd/MM/yyyy"
            dtpLastPaiddate.Value = DataRow.Cells("LastPaidDate").Value
            dtpLastPaiddate.CustomFormat = "dd/MM/yyyy"
            txtEmiAmt.Text = DataRow.Cells("EMI_Amount").Value
            txtLoanAmt.Text = DataRow.Cells("LoanAmount").Value
            txtLoanPeriod.Text = DataRow.Cells("LoanPeriod").Value
            cmbPaymode.SelectedIndex = DataRow.Cells("paymode").Value
            txtLoanOutStanding.Text = DataRow.Cells("LoanOutStanding").Value
            txtPrincipal.Text = DataRow.Cells("Principal").Value
            txtODPrincipal.Text = DataRow.Cells("ODPrincipal").Value
            txtODInterest.Text = DataRow.Cells("ODInterest").Value
            txtInterest.Text = DataRow.Cells("Interest").Value

            Me.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Show_Add()
        bool_Edit = False
        Me.ShowDialog()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cmbEmpNo.SelectedIndex = 0 Then
            MsgBox("Select Employee No", MsgBoxStyle.Information, Mssg)
            cmbEmpNo.Focus()
            Exit Sub
        End If
        'If SD(dtpLoanDate.Value) <= SD(LastUpDate) Then
        '    MsgBox("Entry Date is with in the Updation Completed Date... Cant able to Save Now?", MsgBoxStyle.Information, Mssg)
        '    dtpLoanDate.Focus()
        '    Exit Sub
        'End If
        If cmbLoanName.SelectedIndex = 0 Then
            MsgBox("Loan Name ", MsgBoxStyle.Information, Mssg)
            cmbLoanName.Focus()
            Exit Sub
        End If
        If Val(txtLoanNo.Text) = 0 Then
            MsgBox("Type Loan Number...", MsgBoxStyle.Information, Mssg)
            txtLoanNo.Focus()
            Exit Sub
        End If
        If Val(txtLoanAmt.Text) = 0 Then
            MsgBox("Type Loan Amount...", MsgBoxStyle.Information, Mssg)
            txtLoanAmt.Focus()
            Exit Sub
        End If
        If Val(txtLoanPeriod.Text) = 0 Then
            MsgBox("Type Loan Period...", MsgBoxStyle.Information, Mssg)
            txtLoanPeriod.Focus()
            Exit Sub
        End If
        If Val(txtROI.Text) = 0 Then
            MsgBox("Type  ROI...", MsgBoxStyle.Information, Mssg)
            txtROI.Focus()
            Exit Sub
        End If
        If Bool_Edit = True Then
            Dim objloandemand As DataTable = objDT("select * from tbl_Loandemand where NewDemand=0 and loancode=" & Val(txtLoanCode.Text))
            If objloandemand.Rows.Count > 0 Then
                MsgBox("Loan Demand was finalized. can't able to change Loan Details", MsgBoxStyle.Information, Mssg)
                Exit Sub
            End If
        End If
        Dim LastDemandDate As DateTime = objDScal("select ISNULL(max(DemandDate),'2016-03-31') from tbl_Loandemand")

        If IsNothing(LastDemandDate) = False Then
            If SD(dtpLoanDate.Value) <= SD(LastDemandDate) And SD(LastDemandDate) <> SD("2016-03-31") Then
                MsgBox("Sorry! Demand Already Rised. Can't able to add or Edit the Given Loan...", MsgBoxStyle.Information, Mssg)
                Exit Sub
            End If
        End If
        Dim DDateFrom As DateTime
        Dim DDateTo As DateTime
        If dtpLoanDate.Value < objDScal("Select fystart from tbl_Fyear where fycode=" & int_FYearCode) Then
            Dim txtdate As String
            If cmbEmpNo.ColData("membertype").Contains("STAFF") Then
                txtdate = "20/03/" + Str(Year(objDScal("Select fystart from tbl_Fyear where fycode=" & int_FYearCode))).Trim
            Else
                txtdate = "31/03/" + Str(Year(objDScal("Select fystart from tbl_Fyear where fycode=" & int_FYearCode))).Trim
            End If
            DDateFrom = Date.Parse(txtdate)
            DDateTo = Date.Parse(txtdate) ' CD(txtdate)
        Else
            DDateFrom = IIf(PanelOD.Enabled = True, SD(dtpLastPaiddate.Value), SD(dtpLoanDate.Value))
            DDateTo = IIf(PanelOD.Enabled = True, SD(dtpLastPaiddate.Value), SD(dtpLoanDate.Value))
        End If
        Dim objTrans As SqlTransaction
        objTrans = objSqlConnection.BeginTransaction
        Try
            Dim objsqlcommand As New SqlCommand("sp_MemberLoan_Addedit", objSqlConnection, objTrans)
            objsqlcommand.CommandType = CommandType.StoredProcedure

            If Bool_Edit = True Then
                objsqlcommand.Parameters.AddWithValue("@LoanCode", Val(txtLoanCode.Text))
            End If
            objsqlcommand.Parameters.AddWithValue("@MemberCode", cmbEmpNo.ColData("MemberCode"))
            objsqlcommand.Parameters.AddWithValue("@LoanNameCode", cmbLoanName.ColData("LoanNameCOde"))
            objsqlcommand.Parameters.AddWithValue("@LoanDate", SD(dtpLoanDate.Value))
            objsqlcommand.Parameters.AddWithValue("@LoanAmount", Val(txtLoanAmt.Text))
            objsqlcommand.Parameters.AddWithValue("@ROI", Val(txtROI.Text))
            objsqlcommand.Parameters.AddWithValue("@LoanNumber", Val(txtLoanNo.Text))
            objsqlcommand.Parameters.AddWithValue("@LoanPeriod", Val(txtLoanPeriod.Text))
            objsqlcommand.Parameters.AddWithValue("@Paymode", cmbPaymode.SelectedIndex)
            objsqlcommand.Parameters.AddWithValue("@LastPaidDate", SD(dtpLastPaiddate.Value))
            objsqlcommand.Parameters.AddWithValue("@Emi_Amount", Val(txtEmiAmt.Text))
            objsqlcommand.Parameters.AddWithValue("@LoanOutStanding", IIf(Val(txtLoanOutStanding.Text) = 0, Val(txtLoanAmt.Text), Val(txtLoanOutStanding.Text)))
            objsqlcommand.Parameters.AddWithValue("@Principal", Val(txtPrincipal.Text))
            objsqlcommand.Parameters.AddWithValue("@ODPrincipal", Val(txtODPrincipal.Text))
            objsqlcommand.Parameters.AddWithValue("@ODInterest", Val(txtODInterest.Text))
            objsqlcommand.Parameters.AddWithValue("@Interest", Val(txtInterest.Text))
            objsqlcommand.Parameters.AddWithValue("@maturitydate", SD(DateAdd(DateInterval.Month, Val(txtLoanPeriod.Text), dtpLoanDate.Value)))
            objsqlcommand.Parameters.AddWithValue("@LoanClossedStatus", 0)
            objsqlcommand.Parameters.AddWithValue("@User", int_UserCode)
            objsqlcommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Dim MLCode As Integer = objsqlcommand.ExecuteScalar()
            'If Val(txtLoanOutStanding.Text) > 0 And SD(dtpLastPaiddate.Value) <> SD(dtpLoanDate.Value) Then
            '    If Bool_Edit = True Then
            '        Dim objCom As New SqlCommand("sp_LoanDemand_Delete", objSqlConnection, objTrans)
            '        objCom.CommandType = CommandType.StoredProcedure
            '        objCom.Parameters.AddWithValue("@LoanCode", MLCode)
            '        objCom.ExecuteNonQuery()
            '    End If

            '    Dim objcommand As New SqlCommand("sp_LoanDemand_Insert", objSqlConnection, objTrans)
            '    objcommand.CommandType = CommandType.StoredProcedure

            '    objcommand.Parameters.AddWithValue("@DemandCode", Nothing)
            '    objcommand.Parameters.AddWithValue("@DateFrom", SD(DDateFrom))
            '    objcommand.Parameters.AddWithValue("@DateTo", SD(DDateTo))
            '    objcommand.Parameters.AddWithValue("@MonthNo", Month(DDateFrom))
            '    objcommand.Parameters.AddWithValue("@YearNo", Year(DDateFrom))
            '    objcommand.Parameters.AddWithValue("@DemandDate", SD(DDateFrom))
            '    objcommand.Parameters.AddWithValue("@Fycode", int_FYearCode)
            '    objcommand.Parameters.AddWithValue("@MemberCode", cmbEmpNo.ColData("MemberCode"))
            '    objcommand.Parameters.AddWithValue("@LoanCode", MLCode)
            '    objcommand.Parameters.AddWithValue("@LoanOutStanding", IIf(PanelOD.Enabled = True, Val(txtLoanOutStanding.Text), Val(txtLoanAmt.Text)))
            '    objcommand.Parameters.AddWithValue("@Principal", Val(txtPrincipal.Text))
            '    objcommand.Parameters.AddWithValue("@Interest", Val(txtInterest.Text))
            '    objcommand.Parameters.AddWithValue("@ODPrincipal", Val(txtODPrincipal.Text))
            '    objcommand.Parameters.AddWithValue("@ODInterest", Val(txtODInterest.Text))
            '    objcommand.Parameters.AddWithValue("@CollPrincipal", 0)
            '    objcommand.Parameters.AddWithValue("@CollInterest", 0)
            '    objcommand.Parameters.AddWithValue("@NewDemand", 1)
            '    objcommand.Parameters.AddWithValue("@CollODPrincipal", 0)
            '    objcommand.Parameters.AddWithValue("@CollODInterest", 0)
            '    objcommand.Parameters.AddWithValue("@CollOS", Val(txtPrincipal.Text) + Val(txtInterest.Text) + Val(txtODPrincipal.Text) + Val(txtODInterest.Text))
            '    objcommand.Parameters.AddWithValue("@LoanOS", IIf(PanelOD.Enabled = True, Val(txtLoanOutStanding.Text), Val(txtLoanAmt.Text)))
            '    objcommand.Parameters.AddWithValue("@LoanOSforInt", IIf(PanelOD.Enabled = True, Val(txtLoanOutStanding.Text), Val(txtLoanAmt.Text)))
            '    objcommand.Parameters.AddWithValue("@StaffLoan", IIf(cmbEmpNo.ColData("MemberTYpe").Contains("STAFF"), 1, 0))
            '    objcommand.Parameters.AddWithValue("@WorkerLoan", IIf(cmbEmpNo.ColData("MemberTYpe").Contains("STAFF"), 0, 1))

            '    objcommand.ExecuteNonQuery()
            'End If
            objTrans.Commit()

            objTrans.Dispose()
        Catch ex As Exception
            objTrans.Rollback()
            objTrans.Dispose()
            If ex.Message.Contains("UK_tbl_MemberLoan") Then
                MsgBox(" The Loan Number Already Typed...", MsgBoxStyle.Information, Mssg)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
            End If
        Finally
            frmMemberLoanDetails.Grid.RecordSet(objDT("Sp_MemberLoan_GetAll"), "MemberCode,LoanCode,number,membername_Tamil,LoanNameCode,StrLoanNumber,LoanClossedStatus,Demand")
            frmMemberLoanDetails.Grid.RowTemplate.Height = 32
            'Dim Rowindex As Integer = frmMemberLoanDetails.Grid.CurrentRow.Index + 1
            ' CODE FOR EDIT NEXT
            'If frmMemberLoanDetails.Grid.Rows.Count > 0 Then
            '    If Rowindex < frmMemberLoanDetails.Grid.Rows.Count Then
            '        frmMemberLoanDetails.Grid.Rows(Rowindex).Selected = True
            '        frmMemberLoanDetails.Grid.FirstDisplayedScrollingRowIndex = Rowindex
            '    End If
            'End If
            If Bool_Edit = False Then
                MsgBox("Record saved ...", MsgBoxStyle.Information, Mssg)
                btnClear_Click(sender, e)
            Else
                'MsgBox("Record Updated ...", MsgBoxStyle.Information, Mssg)
                btnExit_Click(sender, e)
            End If
        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PanelClear(Panel4)
        PanelClear(PanelOD)
        txtLoanCode.Text = ""
        dtpLoanDate.Value = CurDate
        dtpLastPaiddate.Value = CurDate
        cmbEmpNo.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()

    End Sub

    Private Sub cmbEmpNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpNo.SelectedIndexChanged
        If cmbEmpNo.SelectedIndex > 0 Then
            txtEmpNumber.Text = cmbEmpNo.ColData("Number")
            txtEmpName.Text = cmbEmpNo.ColData("MemberName")
        Else
            txtEmpName.Text = ""
            txtEmpNumber.Text = ""
        End If
    End Sub

    Private Sub dtpLoanDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpLoanDate.Validated
        'If SD(dtpLoanDate.Value) > objDScal("select fyend  from tbl_FYear where fycode=" & int_FYearCode) Then
        '    PanelOD.Enabled = False
        '    MsgBox("Beyond current year date is not accepted...", MsgBoxStyle.Information, Mssg)
        '    dtpLoanDate.Focus()
        '    Exit Sub
        'End If
        If int_FYearCode = objDScal("Select max(fycode) from tbl_FYear") Then
            If SD(dtpLoanDate.Value) > SD(CurDate) Then
                PanelOD.Enabled = False
                MsgBox("Future date is not accepted...", MsgBoxStyle.Information, Mssg)
                dtpLoanDate.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub dtpLoanDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpLoanDate.Validating
       
    End Sub

    Private Sub dtpLoanDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpLoanDate.ValueChanged
        PanelOD.Enabled = IIf(CheckDate(dtpLoanDate.Value) = True, False, True)
        
        'PanelOD.Enabled = CheckDate(dtpLoanDate.Value)
    End Sub
End Class