Imports System.Data.SqlClient
Public Class frmTDInterest
    Dim sTime As Integer = 0
    Dim Bool_Edit As Boolean

    Private Sub frmTDInterest_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtInsurance.Focus()
    End Sub
    Private Sub frmTDInterestvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbYear.RecordSet(objDT("sp_FYear_GetAll @Fycode=" & int_FYearCode), "fyear", "Fycode")
        cmbYear.SelectedValue = int_FYearCode
       
    End Sub

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            Bool_Edit = True
            Dim OBJRCD As DataTable = objDT("SELECT * FROM TBL_MEMBER WHERE MEMBERCODE=" & DataRow.Cells("MEMBERCODE").Value)
            txtTDInterestCode.Text = DataRow.Cells("TdInterestCode").Value
            dtpDateFrom.Value = DataRow.Cells("TDFROMDATE").Value
            dtpDateTo.Value = DataRow.Cells("TDTODATE").Value

            txtEmpNo.Text = OBJRCD.Rows.Item(0)("EMPLOYEENUMBER")
            txtMemberCode.Text = DataRow.Cells("MemberCode").Value
            txtMemberNo.Text = OBJRCD.Rows.Item(0)("number")
            txtMemberName.Text = OBJRCD.Rows.Item(0)("MEMBERNAME")
            txtOpening.Text = DataRow.Cells("OpeningAmount").Value
            txtCollection.Text = DataRow.Cells("TDCollection").Value
            txtIntonOpening.Text = DataRow.Cells("IntonOpening").Value
            txtintonCollection.Text = DataRow.Cells("IntonCollection").Value
            txtTotal.Text = DataRow.Cells("TotalPayment").Value
            txtInsurance.Text = DataRow.Cells("Insurance").Value
            txtNettTotal.Text = DataRow.Cells("NettTotal").Value
            txtROI.Text = DataRow.Cells("ROI").Value
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
        lblProcessing.Visible = True
        Application.DoEvents()
        If Val(txtEmpNo.Text) > 0 Then

            Dim sEmpNo As DataTable = objDT("sp_Member_GetAll @EmployeeNumber=" & Val(txtEmpNo.Text))
            If sEmpNo.Rows.Count = 0 Then
                MsgBox("No Employee Number Like this OR Member Number in Clossed List", MsgBoxStyle.Information, Mssg)
                txtEmpNo.Focus()

                Exit Sub
            End If
            txtMemberCode.Text = sEmpNo.Rows.Item(0)("MemberCode")
            txtMemberNo.Text = sEmpNo.Rows.Item(0)("Number")
            txtMemberName.Text = sEmpNo.Rows.Item(0)("MemberName")

            ' Dim objInt As DataTable = objDT("sp_TDInterest_GetAll @FROMDATE='" & SD(dtpDateFrom.Value) & "',@Todate='" & SD(dtpDateTo.Value) = "',@MemberCode=" & Val(txtMemberCode.Text))
            Dim objInt As DataTable = objDT("sp_TDInterest_GetAll @MemberCode=" & Val(txtMemberCode.Text) & ",@Fromdate='" & SD(dtpDateFrom.Value) & "',@Todate='" & SD(dtpDateTo.Value) & "'")
            If objInt.Rows.Count = 0 Then

                Dim Year1 As Integer = Year(dtpDateFrom.Value)
                Dim year2 As Integer = Year(dtpDateTo.Value)
                Dim month1 As Integer = Month(dtpDateFrom.Value)
                Dim month2 As Integer = Month(dtpDateTo.Value)
                If month1 > month2 Then
                    month2 = month2 + 12
                End If
                Dim datefrom As DateTime = dtpDateFrom.Value
                Dim Int1 As Double = 0
                Dim int2 As Double = 0

                Dim objTDC As DataTable = objDT("sp_TDCollection @FromDate='" & SD(datefrom) & "',@YearNumber=" & Year1 & ",@YearNumber1=" & year2 & ",@MonthFrom=" & month1 & ",@MonthTO=" & month2 & ",@EmpNo=" & Val(txtEmpNo.Text))

                If objTDC.Rows.Count > 0 Then
                    Bool_Edit = False
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
                    Next
                    txtIntonOpening.Text = Format(Math.Round((Val(txtOpening.Text) * Val(txtROI.Text) * (month2 - month1 + 1)) / 1200, 0), "#0.00")
                    txtintonCollection.Text = Format(Math.Round(Int1, 0), "#0.00")
                    txtTotal.Text = Format(Val(txtIntonOpening.Text) + Val(txtintonCollection.Text), "#0.00")
                    txtNettTotal.Text = Format(Val(txtTotal.Text) - Val(txtInsurance.Text), "#0.00")




                Else
                    MsgBox(" The Employee has null in his account...", MsgBoxStyle.Information, Mssg)
                    txtEmpNo.Text = ""
                    txtEmpNo.Focus()
                End If
            Else
                If Bool_Edit = True Then

                    txtTDInterestCode.Text = objInt.Rows.Item(0)("TDInterestCode")
                    txtOpening.Text = Format(objInt.Rows.Item(0)("OpeningAmount"), "#0.00")
                    txtCollection.Text = Format(objInt.Rows.Item(0)("TDCollection"), "#0.00")
                    txtIntonOpening.Text = Format(objInt.Rows.Item(0)("IntonOpening"), "#0.00")
                    txtintonCollection.Text = Format(objInt.Rows.Item(0)("IntonCollection"), "#0.00")
                    txtTotal.Text = Format(objInt.Rows.Item(0)("TotalPayment"), "#0.00")
                    txtInsurance.Text = Format(objInt.Rows.Item(0)("Insurance"), "#0.00")
                    txtNettTotal.Text = Format(objInt.Rows.Item(0)("NettTotal"), "#0.00")
                    Bool_Edit = True
                    txtInsurance.Focus()
                End If
            End If
        End If
            lblProcessing.Visible = False
            Application.DoEvents()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PanelClear(pnlLeft)
        PanelClear(pnlRight)
        txtInsurance.Text = ""
        txtInsurance.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        btnClear_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If CheckDate(dtpDateTo.Value) = False Then
            MsgBox("Invalid Date is Given... Please Check Finantial Year as Entered...", MsgBoxStyle.Information, Mssg)
            dtpDateTo.Focus()
            Exit Sub
        End If
        If SD(dtpDateTo.Value) <= SD(LastUpDate) Then
            MsgBox("Entry Date is with in the Updation Completed Date... Cant able to Save Now?", MsgBoxStyle.Information, Mssg)
            dtpDateTo.Focus()
            Exit Sub
        End If
        If Val(txtEmpNo.Text) = 0 Then
            MsgBox("Please Type Employee Number / Token Number...", MsgBoxStyle.Information, Mssg)
            txtEmpNo.Focus()
            Exit Sub
        End If
        Dim objCommand As New SqlCommand("sp_TDInterest_AddEdit", objSqlConnection)
        objCommand.CommandType = CommandType.StoredProcedure


        If Bool_Edit = True Then
            objCommand.Parameters.AddWithValue("@TDInterestCode", Val(txtTDInterestCode.Text))
        End If

        objCommand.Parameters.AddWithValue("@TDFromDate", SD(dtpDateFrom.Value))
        objCommand.Parameters.AddWithValue("@TDToDate", SD(dtpDateTo.Value))
        objCommand.Parameters.AddWithValue("@MemberCode", Val(txtMemberCode.Text))
        objCommand.Parameters.AddWithValue("@OpeningAmount", Val(txtOpening.Text))
        objCommand.Parameters.AddWithValue("@TDCollection", Val(txtCollection.Text))
        objCommand.Parameters.AddWithValue("@intonOpening", Val(txtIntonOpening.Text))
        objCommand.Parameters.AddWithValue("@intonCollection", Val(txtintonCollection.Text))
        objCommand.Parameters.AddWithValue("@TotalPayment", Val(txtTotal.Text))
        objCommand.Parameters.AddWithValue("@Insurance", Val(txtInsurance.Text))
        objCommand.Parameters.AddWithValue("@NettTotal", Val(txtNettTotal.Text))
        objCommand.Parameters.AddWithValue("@ROI", Val(txtROI.Text))
        objCommand.Parameters.AddWithValue("@User", int_UserCode)
        objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
        objCommand.ExecuteNonQuery()
        frmTDInterestDetails.Grid.RecordSet(objDT("sp_TDInterest_Getall @FROMDATE='" & SD(dtpDateFrom.Value) & "',@TODATE='" & SD(dtpDateTo.Value) & "'"), "TDInterestCode,MemberCode")

        If Bool_Edit = False Then
            MsgBox("Record Saved Successfully....", MsgBoxStyle.Information, Mssg)
            btnClear_Click(sender, e)
        Else
            MsgBox("Record Saved Successfully....", MsgBoxStyle.Information, Mssg)
            btnExit_Click(sender, e)
        End If


    End Sub

    Private Sub txtInsurance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInsurance.TextChanged
        txtInsurance1.Text = txtInsurance.Text
        If Val(txtTotal.Text) > 0 Then
            txtNettTotal.Text = Val(txtTotal.Text) - Val(txtInsurance.Text)
        End If
    End Sub

   
    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        If cmbYear.SelectedIndex > 0 Then
            dtpDateFrom.Value = cmbYear.ColData("FyStart")
            dtpDateTo.Value = cmbYear.ColData("FyEnd")
        Else
        End If
    End Sub

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged

    End Sub
End Class