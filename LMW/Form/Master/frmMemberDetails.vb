
Public Class frmMemberDetails
    Dim objMember As New DBLayer.clsMember

    Private Sub frmMemberDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Grid.RecordSet(objMember.GetRecords(), "MemberCode,strEmpno")
        Grid.Refresh()
        If Grid.Rows.Count > 0 Then
            Grid.Columns("Number").ReadOnly = True
            Grid.Columns("MemberName").ReadOnly = False
            Grid.Columns("TDOpening").ReadOnly = True
            Grid.Columns("EmployeeNumber").ReadOnly = True
            Grid.Columns("Address1").ReadOnly = False
            Grid.Columns("Address2").ReadOnly = False
            Grid.Columns("Address3").ReadOnly = False
            Grid.Columns("Address4").ReadOnly = False
            Grid.Columns("MobileNo").ReadOnly = False

            Grid.Columns("MemberName").Width = 150
            Grid.Columns("Address1").Width = 120
            Grid.Columns("Address2").Width = 120
            Grid.Columns("Address3").Width = 120
            Grid.Columns("Address4").Width = 120
            Grid.Columns("MobileNo").Width = 100
        End If
        Grid.DefaultCellStyle.Font = New Font(str_TamilFont, 12)
        Grid.AlternatingRowsDefaultCellStyle.Font = New Font(str_TamilFont, 12)
    End Sub

    Private Sub Grid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseClick
        Try
            If e.ColumnIndex = Grid.Columns("Edit").Index Then
                frmMember.Show_Edit(Grid.CurrentRow)
            ElseIf e.ColumnIndex = Grid.Columns("Delete").Index Then
                If Grid.Rows.Count > 0 Then
                    If MessageBox.Show("Are you confirm to delete?", Mssg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        objMember.memberCode = Grid.ValueByCol("MemberCode")
                        Grid.RecordSet(objMember.DeleteRecords(), "MemberCode,strEmpno")
                        Grid.Columns("MemberName").Width = 200
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmMember.Show_Add()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmMemberDetails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormShown(Me)
    End Sub

  
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            For Rowindex As Integer = 0 To Grid.Rows.Count - 1
                Dim strname As String = IIf(IsDBNull(Grid.Item("MemberName", Rowindex).Value) = True, " ", Grid.Item("MemberName", Rowindex).Value)
                Dim strEmployeeNumber As Integer = IIf(IsDBNull(Grid.Item("Employeenumber", Rowindex).Value) = True, Nothing, Val(Grid.Item("EmployeeNumber", Rowindex).Value))
                Dim A1 As String = IIf(IsDBNull(Grid.Item("Address1", Rowindex).Value) = True, Nothing, Grid.Item("Address1", Rowindex).Value)
                Dim A2 As String = IIf(IsDBNull(Grid.Item("Address2", Rowindex).Value) = True, Nothing, Grid.Item("Address2", Rowindex).Value)
                Dim A3 As String = IIf(IsDBNull(Grid.Item("Address3", Rowindex).Value) = True, Nothing, Grid.Item("Address3", Rowindex).Value)
                Dim A4 As String = IIf(IsDBNull(Grid.Item("Address4", Rowindex).Value) = True, Nothing, Grid.Item("Address4", Rowindex).Value)
                Dim M1 As String = IIf(IsDBNull(Grid.Item("MobileNo", Rowindex).Value) = True, Nothing, Grid.Item("MobileNo", Rowindex).Value)

                objDT("Update tbl_Member set MemberName='" & strname & "',Employeenumber='" & strEmployeeNumber & "', Address1 ='" & A1 & "', Address2 ='" & A2 & "', Address3 ='" & A3 & "', Address4 ='" & A4 & "', MobileNo ='" & M1 & "'  where MemberCode=" & Grid.Item("MemberCode", Rowindex).Value)
            Next
            MsgBox("All Records are Updated SuccessFully", MsgBoxStyle.Information, Mssg)
            Grid.RecordSet(objMember.GetRecords(), "MemberCode,strEmpno")
            Grid.Columns("Address1").ReadOnly = False
            Grid.Columns("Address2").ReadOnly = False
            Grid.Columns("Address3").ReadOnly = False
            Grid.Columns("Address4").ReadOnly = False
            Grid.Columns("MobileNo").ReadOnly = False

            Grid.Columns("MemberName").Width = 150
            Grid.Columns("Address1").Width = 120
            Grid.Columns("Address2").Width = 120
            Grid.Columns("Address3").Width = 120
            Grid.Columns("Address4").Width = 120
            Grid.Columns("MobileNo").Width = 100
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Mssg)
        End Try
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class