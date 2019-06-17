Imports System.Data.SqlClient
Public Class frmTDClossing
    Dim sTime As Integer = 0
    Dim Bool_Edit As Boolean
    Dim empno As Integer = 0

    Private Sub frmTDClossing_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dtpDepositClossingDate.Focus()
    End Sub
    Private Sub frmTDClossingvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Bool_Edit = False Then
            optTDClossing.Enabled = True
            optRefund.Enabled = True
            optTDClossing.Checked = True
            Bind_Data()
        End If
        If int_FYearCode < 5 Then
            optRefund.Visible = True
            'txtRefundAmt.Visible = True
        Else
            optRefund.Visible = False
            'txtRefundAmt.Visible = False
        End If
        dtpDepositClossingDate.Value = CurDate
        dtpDepositClossingDate.Focus()
    End Sub

    Private Sub Bind_Data()
        cmbEmployeeno.RecordSet(objDT("sp_MemberNotinTDClossing_GetAll"), "strEmpNo", "MemberCOde")

    End Sub

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try

            Bool_Edit = True
            Bind_Data()
            optTDClossing.Enabled = False
            optRefund.Enabled = False
            If optTDClossing.Checked = True Then
                dtpDepositClossingDate.Value = DataRow.Cells("TDClossingDate").Value
                txtEmpNo.Text = DataRow.Cells("EmployeeNumber").Value
                txtMemberCode.Text = DataRow.Cells("MemberCode").Value
                cmbEmployeeno.SelectedValue = DataRow.Cells("MemberCode").Value
                txtMemberNo.Text = DataRow.Cells("number").Value
                txtMemberName.Text = DataRow.Cells("MemberName").Value
                txtOpening.Text = DataRow.Cells("OpeningAmt").Value
                txtCollection.Text = DataRow.Cells("TDCollection").Value
                txtIntonOpening.Text = DataRow.Cells("IntonOpening").Value
                txtintonCollection.Text = DataRow.Cells("IntonCollection").Value
                txtTotal.Text = DataRow.Cells("TotalPayment").Value
                txtROI.Text = DataRow.Cells("ROI").Value
                txtOtherR.Text = DataRow.Cells("OtherReceipt").Value
                txtOtherReceipt.Text = DataRow.Cells("OtherReceipt").Value
            End If
            If optRefund.Checked = True Then
                dtpDepositClossingDate.Value = DataRow.Cells("RefundDate").Value
                txtEmpNo.Text = DataRow.Cells("EmployeeNumber").Value
                txtMemberCode.Text = DataRow.Cells("MemberCode").Value
                txtMemberNo.Text = DataRow.Cells("number").Value
                txtMemberName.Text = DataRow.Cells("MemberName").Value
                txtOpening.Text = DataRow.Cells("OpeningAmt").Value
                txtCollection.Text = DataRow.Cells("TDCollection").Value
                txtRefundAmt.Text = DataRow.Cells("RefundAmount").Value
            End If
            Me.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Show_Add()
        Bool_Edit = False
        Me.ShowDialog()
    End Sub

    Private Sub txtEmpNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpNo.Validated
        If IsDate(dtpDepositClossingDate.Text) = False Then
            MsgBox("Please Check Date ...", MsgBoxStyle.Information, Mssg)
            dtpDepositClossingDate.Focus()
            Exit Sub
        End If
        If empno > 0 Then

            Dim sEmpNo As DataTable = objDT("sp_Member_GetAll @EmployeeNumber=" & empno)
            If sEmpNo.Rows.Count = 0 Then
                MsgBox("No Employee Number Like this OR Member Number in Clossed List", MsgBoxStyle.Information, Mssg)
                txtEmpNo.Focus()
                Exit Sub
            End If
            Dim CEmpNo As DataTable = objDT("sp_MemberNotinTDClossing_GetAll @EmployeeNumber=" & empno)
            If CEmpNo.Rows.Count = 0 Then
                MsgBox("Member Number is in Clossed List", MsgBoxStyle.Information, Mssg)
                txtEmpNo.Focus()
                Exit Sub
            End If
            cmbEmployeeno.SelectedValue = Val(CEmpNo.Rows.Item(0)("Membercode"))
            txtMemberCode.Text = sEmpNo.Rows.Item(0)("MemberCode")
            txtMemberNo.Text = sEmpNo.Rows.Item(0)("Number")
            txtMemberName.Text = sEmpNo.Rows.Item(0)("MemberName")
            Dim Year1 As Integer = objDScal("select year(FyStart) from tbl_Fyear where fycode=" & int_FYearCode)
            Dim year2 As Integer = Year(dtpDepositClossingDate.Value)
            Dim month1 As Integer = 4
            Dim month2 As Integer = Month(dtpDepositClossingDate.Value)
            If month1 > month2 Then
                month2 = month2 + 12
            End If
            Dim datefrom As DateTime = objDScal("Select max(FYstart) from tbl_Fyear where Fystart<='" & SD(dtpDepositClossingDate.Value) & "'")
            Dim Int1 As Double = 0
            Dim int2 As Double = 0

            Dim objTDC As DataTable = objDT("sp_TDCollection @FromDate='" & SD(datefrom) & "',@YearNumber=" & Year1 & ",@YearNumber1=" & year2 & ",@MonthFrom=" & month1 & ",@MonthTO=" & month2 & ",@EmpNo=" & Val(txtEmpNo.Text))
            If objTDC.Rows.Count > 0 Then
                txtOpening.Text = objTDC.Rows.Item(0)("TDOpening")
                txtCollection.Text = objTDC.Rows.Item(0)("TotalCollection")
                Dim countrow As Integer = 0
                If month2 = 15 Then countrow = month2 - 1 Else countrow = month2 - 2
                For rID As Integer = month1 To countrow
                    If IsDBNull(objTDC.Rows.Item(0)("April")) = False And rID >= month1 Then
                        Int1 += objTDC.Rows.Item(0)("April") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("May")) = False And rID >= month1 + 1 Then
                        Int1 += objTDC.Rows.Item(0)("May") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("June")) = False And rID >= month1 + 2 Then
                        Int1 += objTDC.Rows.Item(0)("June") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("July")) = False And rID >= month1 + 3 Then
                        Int1 += objTDC.Rows.Item(0)("July") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("August")) = False And rID >= month1 + 4 Then
                        Int1 += objTDC.Rows.Item(0)("August") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("September")) = False And rID >= month1 + 5 Then
                        Int1 += objTDC.Rows.Item(0)("September") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("October")) = False And rID >= month1 + 6 Then
                        Int1 += objTDC.Rows.Item(0)("October") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("November")) = False And rID >= month1 + 7 Then
                        Int1 += objTDC.Rows.Item(0)("November") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("December")) = False And rID >= month1 + 8 Then
                        Int1 += objTDC.Rows.Item(0)("December") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("January")) = False And rID >= month1 + 9 Then
                        Int1 += objTDC.Rows.Item(0)("January") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("February")) = False And rID >= month1 + 10 Then
                        Int1 += objTDC.Rows.Item(0)("February") * Val(txtROI.Text) / 1200
                    End If
                    If IsDBNull(objTDC.Rows.Item(0)("March")) = False And rID >= month1 + 11 Then
                        Int1 += objTDC.Rows.Item(0)("March") * Val(txtROI.Text) / 1200
                    End If
                    countrow = 0
                Next
                txtIntonOpening.Text = Format(Math.Round((Val(txtOpening.Text) * Val(txtROI.Text) * (month2 - month1)) / 1200, 0), "#0.00")
                txtintonCollection.Text = Format(Math.Round(Int1, 0), "#0.00")
                txtTotal.Text = Format(Val(txtOpening.Text) + Val(txtCollection.Text) + Val(txtIntonOpening.Text) + Val(txtintonCollection.Text) - Val(txtOtherReceipt.Text), "#0.00")


                'Dim a As Integer =objDScal("select Count(Membercode) from tbl_TDClosing where 
                'If  then


                'End If

            Else
                MsgBox(" The Employee has null in his account...", MsgBoxStyle.Information, Mssg)
                txtEmpNo.Text = ""
                cmbEmployeeno.Focus()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim r As Double = Val(txtROI.Text)
        Dim dt As DateTime = dtpDepositClossingDate.Value
        PanelClear(pnlLeft)
        PanelClear(pnlRight)
        txtROI.Text = Format(r, "#0.00")
        optTDClossing.Enabled = True
        optRefund.Enabled = True
        dtpDepositClossingDate.Value = dt
        dtpDepositClossingDate.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If CheckDate(dtpDepositClossingDate.Value) = False Then
            MsgBox("Invalid Date is Given... Please Check Finantial Year as Entered...", MsgBoxStyle.Information, Mssg)
            dtpDepositClossingDate.Focus()
            Exit Sub
        End If
        If SD(dtpDepositClossingDate.Value) <= SD(LastUpDate) Then
            MsgBox("Entry Date is with in the Updation Completed Date... Cant able to Save Now?", MsgBoxStyle.Information, Mssg)
            dtpDepositClossingDate.Focus()
            Exit Sub
        End If
        If Val(txtEmpNo.Text) = 0 Then
            MsgBox("Please Type Employee Number / Token Number...", MsgBoxStyle.Information, Mssg)
            cmbEmployeeno.Focus()
            Exit Sub
        End If
        If optTDClossing.Checked = True Then
            Dim objCommand As New SqlCommand("sp_TDClossing_AddEdit", objSqlConnection)
            objCommand.CommandType = CommandType.StoredProcedure


            If Bool_Edit = True Then
                objCommand.Parameters.AddWithValue("@TDClossingCode", Val(txtTDClossingCode.Text))
            End If

            objCommand.Parameters.AddWithValue("@TDClossingDate", SD(dtpDepositClossingDate.Value))
            objCommand.Parameters.AddWithValue("@MemberCode", Val(txtMemberCode.Text))
            objCommand.Parameters.AddWithValue("@OpeningAmt", Val(txtOpening.Text))
            objCommand.Parameters.AddWithValue("@TDCollection", Val(txtCollection.Text))
            objCommand.Parameters.AddWithValue("@intonOpening", Val(txtIntonOpening.Text))
            objCommand.Parameters.AddWithValue("@intonCollection", Val(txtintonCollection.Text))
            objCommand.Parameters.AddWithValue("@TotalPayment", Val(txtTotal.Text))
            objCommand.Parameters.AddWithValue("@OtherReceipt", Val(txtOtherReceipt.Text))
            objCommand.Parameters.AddWithValue("@ROI", Val(txtROI.Text))
            objCommand.Parameters.AddWithValue("@User", int_UserCode)
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            objCommand.ExecuteNonQuery()
            frmTDClossingDetails.Grid.RecordSet(objDT("sp_TDClossing_GetAll"), "TDClossingCode,MemberCode")
            MsgBox("Record Saved Successfully....", MsgBoxStyle.Information, Mssg)
            btnClear_Click(sender, e)
        End If
        If optRefund.Checked = True Then

            Dim objCommand As New SqlCommand("sp_TDRefund_AddEdit", objSqlConnection)
            objCommand.CommandType = CommandType.StoredProcedure


            If Bool_Edit = True Then
                objCommand.Parameters.AddWithValue("@RefundCode", Val(txtRefundCode.Text))
            End If

            objCommand.Parameters.AddWithValue("@RefundDate", SD(dtpDepositClossingDate.Value))
            objCommand.Parameters.AddWithValue("@MemberCode", Val(txtMemberCode.Text))
            objCommand.Parameters.AddWithValue("@OpeningAmt", Val(txtOpening.Text))
            objCommand.Parameters.AddWithValue("@TDCollection", Val(txtCollection.Text))

            objCommand.Parameters.AddWithValue("@RefundAmount", Val(txtRefundAmt.Text))
            objCommand.Parameters.AddWithValue("@User", int_UserCode)
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            objCommand.ExecuteNonQuery()
            frmTDClossingDetails.Grid1.RecordSet(objDT("sp_TDRefund_GetAll"), "RefundCode,MemberCode")
            MsgBox("Record Saved Successfully....", MsgBoxStyle.Information, Mssg)
            btnClear_Click(sender, e)


        End If
    End Sub


    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged
        empno = Val(txtEmpNo.Text)
    End Sub

    Private Sub optRefund_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRefund.CheckedChanged
        txtRefundAmt.Enabled = True
        txtROI.Enabled = False
        txtROI.Text = 0
    End Sub

    Private Sub optTDClossing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTDClossing.CheckedChanged
        txtRefundAmt.Enabled = False
        txtROI.Enabled = True
        txtROI.Text = 8.5
    End Sub

    Private Sub txtRefundAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefundAmt.TextChanged

    End Sub

    Private Sub txtRefundAmt_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefundAmt.Validated
        If Val(txtRefundAmt.Text) > 0 Then
            Dim tot As Double = Val(txtOpening.Text) + Val(txtCollection.Text)
            If Val(txtRefundAmt.Text) > tot Then
                MsgBox("Refund Amount is Over than Opening + Collection", MsgBoxStyle.Information, Mssg)
                txtRefundAmt.Focus()
            End If
        End If
    End Sub

   
    Private Sub txtOtherR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOtherR.TextChanged
        txtOtherReceipt.Text = txtOtherR.Text
        txtTotal.Text = Format(Val(txtOpening.Text) + Val(txtCollection.Text) + Val(txtIntonOpening.Text) + Val(txtintonCollection.Text) - Val(txtOtherReceipt.Text), "#0.00")
    End Sub

    Private Sub cmbEmployeeno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles cmbEmployeeno.Leave
        If cmbEmployeeno.SelectedIndex > 0 Then
            If IsDate(dtpDepositClossingDate.Text) = False Then
                MsgBox("Please Check Date ...", MsgBoxStyle.Information, Mssg)
                dtpDepositClossingDate.Focus()
                Exit Sub
            End If
            If empno > 0 Then
                Dim sEmpNo As DataTable = objDT("sp_Member_GetAll @MemberCOde=" & cmbEmployeeno.ColData("MemberCOde"))
                If sEmpNo.Rows.Count = 0 Then
                    MsgBox("No Employee Number Like this OR Member Number in Clossed List", MsgBoxStyle.Information, Mssg)
                    cmbEmployeeno.Focus()
                    Exit Sub
                End If
                txtMemberCode.Text = sEmpNo.Rows.Item(0)("MemberCode")
                txtMemberNo.Text = sEmpNo.Rows.Item(0)("Number")
                txtMemberName.Text = sEmpNo.Rows.Item(0)("MemberName")
                Dim Year1 As Integer = objDScal("select year(FyStart) from tbl_Fyear where fycode=" & int_FYearCode)
                Dim year2 As Integer = Year(dtpDepositClossingDate.Value)
                Dim month1 As Integer = 4
                Dim month2 As Integer = Month(dtpDepositClossingDate.Value)
                If month1 > month2 Then
                    month2 = month2 + 12
                End If
                Dim datefrom As DateTime = objDScal("Select max(FYstart) from tbl_Fyear where Fystart<='" & SD(dtpDepositClossingDate.Value) & "'")
                Dim Int1 As Double = 0
                Dim int2 As Double = 0

                Dim objTDC As DataTable = objDT("sp_TDCollection @FromDate='" & SD(datefrom) & "',@YearNumber=" & Year1 & ",@YearNumber1=" & year2 & ",@MonthFrom=" & month1 & ",@MonthTO=" & month2 & ",@EmpNo=" & Val(txtEmpNo.Text))
                If objTDC.Rows.Count > 0 Then
                    txtOpening.Text = objTDC.Rows.Item(0)("TDOpening")
                    txtCollection.Text = objTDC.Rows.Item(0)("TotalCollection")
                    Dim countrow As Integer = 0
                    If month2 = 15 Then countrow = month2 - 1 Else countrow = month2 - 2
                    For rID As Integer = month1 To countrow
                        If IsDBNull(objTDC.Rows.Item(0)("April")) = False And rID >= month1 Then
                            Int1 += objTDC.Rows.Item(0)("April") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("May")) = False And rID >= month1 + 1 Then
                            Int1 += objTDC.Rows.Item(0)("May") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("June")) = False And rID >= month1 + 2 Then
                            Int1 += objTDC.Rows.Item(0)("June") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("July")) = False And rID >= month1 + 3 Then
                            Int1 += objTDC.Rows.Item(0)("July") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("August")) = False And rID >= month1 + 4 Then
                            Int1 += objTDC.Rows.Item(0)("August") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("September")) = False And rID >= month1 + 5 Then
                            Int1 += objTDC.Rows.Item(0)("September") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("October")) = False And rID >= month1 + 6 Then
                            Int1 += objTDC.Rows.Item(0)("October") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("November")) = False And rID >= month1 + 7 Then
                            Int1 += objTDC.Rows.Item(0)("November") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("December")) = False And rID >= month1 + 8 Then
                            Int1 += objTDC.Rows.Item(0)("December") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("January")) = False And rID >= month1 + 9 Then
                            Int1 += objTDC.Rows.Item(0)("January") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("February")) = False And rID >= month1 + 10 Then
                            Int1 += objTDC.Rows.Item(0)("February") * Val(txtROI.Text) / 1200
                        End If
                        If IsDBNull(objTDC.Rows.Item(0)("March")) = False And rID >= month1 + 11 Then
                            Int1 += objTDC.Rows.Item(0)("March") * Val(txtROI.Text) / 1200
                        End If
                        countrow = 0
                    Next
                    txtIntonOpening.Text = Format(Math.Round((Val(txtOpening.Text) * Val(txtROI.Text) * (month2 - month1)) / 1200, 0), "#0.00")
                    txtintonCollection.Text = Format(Math.Round(Int1, 0), "#0.00")
                    txtTotal.Text = Format(Val(txtOpening.Text) + Val(txtCollection.Text) + Val(txtIntonOpening.Text) + Val(txtintonCollection.Text) - Val(txtOtherReceipt.Text), "#0.00")


                    'Dim a As Integer =objDScal("select Count(Membercode) from tbl_TDClosing where 
                    'If  then


                    'End If

                Else
                    MsgBox(" The Employee has null in his account...", MsgBoxStyle.Information, Mssg)
                    txtEmpNo.Text = ""
                    cmbEmployeeno.Focus()
                End If
            End If
        End If
    End Sub


    Private Sub cmbEmployeeno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmployeeno.SelectedIndexChanged
        If cmbEmployeeno.SelectedIndex > 0 Then
            empno = cmbEmployeeno.ColData("Employeenumber")
            txtEmpNo.Text = empno
            txtEmpNo_Validated(sender, e)
            txtOtherR.Focus()
        End If
    End Sub
End Class