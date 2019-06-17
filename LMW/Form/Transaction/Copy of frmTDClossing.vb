Imports System.Data.SqlClient
Public Class frmTDClossing
    Dim sTime As Integer = 0
    Dim Bool_Edit As Boolean
    Private Sub frmTDClossingvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            Bool_Edit = True
            dtpDepositClossingDate.Value = DataRow.Cells("TDClossingDate").Value
            txtEmpNo.Text = DataRow.Cells("EmployeeNumber").Value
            txtMemberCode.Text = DataRow.Cells("MemberCode").Value
            txtMemberNo.Text = DataRow.Cells("number").Value
            txtMemberName.Text = DataRow.Cells("MemberName").Value
            txtOpening.Text = DataRow.Cells("OpeningAmt").Value
            txtCollection.Text = DataRow.Cells("TDCollection").Value
            txtIntonOpening.Text = DataRow.Cells("IntonOpening").Value
            txtintonCollection.Text = DataRow.Cells("IntonCollection").Value
            txtTotal.Text = DataRow.Cells("TotalPayment").Value
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

                For rID As Integer = month1 To month2 - 1
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
                txtIntonOpening.Text = Format(Math.Round((Val(txtOpening.Text) * Val(txtROI.Text) * (month2 - month1)) / 1200, 0), "#0.00")
                txtintonCollection.Text = Format(Math.Round(Int1, 0), "#0.00")
                txtTotal.Text = Format(Val(txtOpening.Text) + Val(txtCollection.Text) + Val(txtIntonOpening.Text) + Val(txtintonCollection.Text), "#0.00")
            Else
                MsgBox(" The Employee has null in his account...", MsgBoxStyle.Information, Mssg)
                txtEmpNo.Text = ""
                txtEmpNo.Focus()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim r As Double = Val(txtROI.Text)
        PanelClear(pnlLeft)
        PanelClear(pnlRight)
        txtROI.Text = Format(r, "#0.00")
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
        If Val(txtEmpNo.Text) = 0 Then
            MsgBox("Please Type Employee Number / Token Number...", MsgBoxStyle.Information, Mssg)
            txtEmpNo.Focus()
            Exit Sub
        End If
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
        objCommand.Parameters.AddWithValue("@ROI", Val(txtROI.Text))
        objCommand.Parameters.AddWithValue("@User", int_UserCode)
        objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
        objCommand.ExecuteNonQuery()
        frmTDClossingDetails.Grid.RecordSet(objDT("sp_TDClossing_GetAll"), "TDClossingCode,MemberCode")
        MsgBox("Record Saved Successfully....", MsgBoxStyle.Information, Mssg)
        btnClear_Click(sender, e)
    End Sub


    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged

    End Sub
End Class