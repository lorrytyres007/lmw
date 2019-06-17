Imports System.Data.SqlClient
Public Class frmShareDivident
    Dim sTime As Integer = 0
    Dim Bool_Edit As Boolean
    Private Sub frmShareDividentvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbYear.RecordSet(objDT("sp_FYear_GetAll "), "fyear", "Fycode")
        cmbYear.SelectedValue = int_FYearCode

    End Sub

    Public Sub Show_Edit(ByVal DataRow As DataGridViewRow)
        Try
            Bool_Edit = True
            Dim OBJRCD As DataTable = objDT("SELECT * FROM TBL_MEMBER WHERE MEMBERCODE=" & DataRow.Cells("MEMBERCODE").Value)
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

            Dim sEmpNo As DataTable = objDT("select * from tbl_Member where EmployeeNumber=" & Val(txtEmpNo.Text))
            If sEmpNo.Rows.Count = 0 Then
                MsgBox("No Employee Number Like this OR Member Number in Clossed List", MsgBoxStyle.Information, Mssg)
                txtEmpNo.Focus()
                Exit Sub
            End If
            txtMemberCode.Text = sEmpNo.Rows.Item(0)("MemberCode")
            txtMemberNo.Text = sEmpNo.Rows.Item(0)("Number")
            txtMemberName.Text = sEmpNo.Rows.Item(0)("MemberName")
            Dim Fromdate As DateTime = objDScal("SELECT FYSTART FROM TBL_FYEAR WHERE FYCODE= " & int_FYearCode)
            Dim Todate As DateTime = objDScal("SELECT FYEND FROM TBL_FYEAR WHERE FYCODE= " & int_FYearCode)
            Dim ShareClosing As DataTable = objDT("select * from tbl_ShareClossing where membercode=" & Val(txtMemberCode.Text))
            If ShareClosing.Rows.Count > 0 Then
                Todate = ShareClosing.Rows.Item(ShareClosing.Rows.Count - 1)("ShareClossingDate")
                dtpShareClosingDate.Value = Todate
            Else
                dtpShareClosingDate.Text = ""
            End If
          
            Dim OpnShare As Double = 0
            Dim DiffDay As Integer = DateDiff(DateInterval.Day, dtpDateFrom.Value, Todate)
            Dim CollShare As Double = 0
            Dim DivonColl As Double = 0
            Dim OpnDiv As Double = 0
            OpnShare = objDScal("select isnull(shareopening,0) from tbl_Member where membercode=" & Val(txtMemberCode.Text))
            OpnShare += objDScal("select isnull(sum(Amount),0) from tbl_ShareDeposit where sharedepositdate< '" & SD(dtpDateFrom.Value) & "' and membercode=" & Val(txtMemberCode.Text))
            If DiffDay >= 364 Then DiffDay = 365
            If DiffDay < 0 Then DiffDay = 0
            Grid.RecordSet(objDT("sp_ShareCollection @FromDate='" & SD(dtpDateFrom.Value) & "',@ToDate='" & SD(dtpDateTo.Value) & "',@MemberCode=" & Val(txtMemberCode.Text) & ",@Roi=" & Val(txtROI.Text)), "MemberCode,ROI")
            If Grid.Rows.Count > 0 Then
                For Rowindex As Integer = 0 To Grid.Rows.Count - 1
                    CollShare += Grid.Item("Amount", Rowindex).Value
                    DivonColl += Grid.Item("Divident", Rowindex).Value
                Next
            End If
            OpnDiv = Math.Round(((OpnShare * Val(txtROI.Text)) / 36500) * DiffDay, 0)

           
           
            txtOpening.Text = Format(OpnShare, "#0.00")
            txtCollection.Text = Format(CollShare, "#0.00")
            txtIntonOpening.Text = Format(OpnDiv, "#0.00")
            txtintonCollection.Text = Format(Math.Round(DivonColl, 0), "#0.00")
            txtTotal.Text = Format(OpnShare + CollShare + Val(txtIntonOpening.Text) + Val(txtintonCollection.Text), "#0.00")
        End If
        lblProcessing.Visible = False
        Application.DoEvents()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PanelClear(pnlLeft)
        PanelClear(pnlRight)
        Grid.RecordSet(objDT("sp_ShareCollection @FromDate='" & SD(dtpDateFrom.Value) & "',@ToDate='" & SD(dtpDateTo.Value) & "',@MemberCode=0,@Roi=0"), "MemberCode,ROI")

        btnSave.Enabled = True
        txtEmpNo.Focus()
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
        Dim ObjRecordFound As DataTable = objDT("select * from tbl_ShareDivident where MemberCode=" & Val(txtMemberCode.Text))
        If ObjRecordFound.Rows.Count > 0 Then
            If MsgBox("ReEntered Data. Do you want update it?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Mssg) = MsgBoxResult.Yes Then
                txtShareDividentCode.Text = ObjRecordFound.Rows(0)("ShareDividentCode")
            End If
        End If
        Dim objCommand As New SqlCommand("sp_ShareDivident_AddEdit", objSqlConnection)
        objCommand.CommandType = CommandType.StoredProcedure


        If Val(txtShareDividentCode.Text) > 0 Then
            objCommand.Parameters.AddWithValue("@ShareDividentCode", Val(txtShareDividentCode.Text))
        End If
        '(@ShareDividentCode int = null,
        '@TDFromDate datetime,
        '@TDToDate datetime,
        '@MemberCode bigint,
        '@OpeningAmount numeric(12,2),
        '@TDCollection numeric(12,2),
        '@IntOnOpening numeric(12,2),
        '@IntonCollection numeric(12,2),
        '@TotalPayment numeric(12,2),
        '@NettTotal numeric(12,2),
        '@ROI numeric(5,2),
        '@User smallint,
        '@Node smallint)
        objCommand.Parameters.AddWithValue("@TDFromDate", SD(dtpDateFrom.Value))
        objCommand.Parameters.AddWithValue("@TDToDate", SD(dtpDateTo.Value))
        objCommand.Parameters.AddWithValue("@MemberCode", Val(txtMemberCode.Text))
        objCommand.Parameters.AddWithValue("@OpeningAmount", Val(txtOpening.Text))
        objCommand.Parameters.AddWithValue("@TDCollection", Val(txtCollection.Text))
        objCommand.Parameters.AddWithValue("@intonOpening", Val(txtIntonOpening.Text))
        objCommand.Parameters.AddWithValue("@intonCollection", Val(txtintonCollection.Text))
        objCommand.Parameters.AddWithValue("@TotalPayment", 0)
        objCommand.Parameters.AddWithValue("@ROI", Val(txtROI.Text))
        objCommand.Parameters.AddWithValue("@User", int_UserCode)
        objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
        objCommand.Parameters.AddWithValue("@NettTotal", Val(txtTotal.Text))
        objCommand.ExecuteNonQuery()
        'Dim Fromdate As DateTime = objDScal("SELECT FYSTART FROM TBL_FYEAR WHERE FYCODE= " & int_FYearCode)
        'Dim Todate As DateTime = objDScal("SELECT FYEND FROM TBL_FYEAR WHERE FYCODE= " & int_FYearCode)
        'frmShareDividentDetails.Grid.RecordSet(objDT("sp_ShareDivident_Getall @FROMDATE='" & SD(dtpDateFrom.Value) & "',@TODATE='" & SD(dtpDateTo.Value) & "'"), "ShareDividentCode,MemberCode")

        If Bool_Edit = False Then
            MsgBox("Record Saved Successfully....", MsgBoxStyle.Information, Mssg)
            btnClear_Click(sender, e)
        Else
            MsgBox("Record Saved Successfully....", MsgBoxStyle.Information, Mssg)
            btnExit_Click(sender, e)
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