Imports System.Data.SqlClient
Imports System.Data
Public Class frmUserRights
    Private Sub cmbUserName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUserName.SelectedIndexChanged
        UnCheckAll()
        If cmbUserName.SelectedIndex > 0 Then
            Dim objDTUser As DataTable = objDT("sp_UserRights_GetByUserCode @UserCode=" & cmbUserName.ColData("UserCode"))
            For TableRow As Integer = 0 To objDTUser.Rows.Count - 1
                For RowIndex1 As Integer = 0 To tvUser.Nodes.Count - 1
                    If Val(tvUser.Nodes(RowIndex1).Tag) = Val(objDTUser.Rows(TableRow)("TableCode")) Then tvUser.Nodes(RowIndex1).Checked = True
                    For RowIndex2 As Integer = 0 To tvUser.Nodes(RowIndex1).Nodes.Count - 1
                        If Val(tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Tag) = Val(objDTUser.Rows(TableRow)("TableCode")) Then tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Checked = True
                        For RowIndex3 As Integer = 0 To tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes.Count - 1
                            If Val(tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes(RowIndex3).Tag) = Val(objDTUser.Rows(TableRow)("TableCode")) Then tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes(RowIndex3).Checked = True
                        Next
                    Next
                Next
            Next
        End If
    End Sub

    Private Sub frmUserRights_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ''frmDashBoard.hide()
    End Sub

    Private Sub frmUserRights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bind_Data()
    End Sub

    Private Sub Bind_Data()
        cmbUserName.RecordSet(DecodeUser(objDT("sp_User_GetAll @UserLevel='" & Encode(2) & "'")), "UserName", "UserCode")
        Dim objMenu1 As DataTable = objDT("sp_Menu_Level1")
        For RowIndex1 As Integer = 0 To objMenu1.Rows.Count - 1
            tvUser.Nodes.Add(objMenu1.Rows(RowIndex1)("FormName"))
            tvUser.Nodes(RowIndex1).Tag = objMenu1.Rows(RowIndex1)("TableCode")
            Dim objMenu2 As DataTable = objDT("sp_Menu_Level2 @TableCode=" & objMenu1.Rows(RowIndex1)("TableCode"))
            For RowIndex2 As Integer = 0 To objMenu2.Rows.Count - 1
                tvUser.Nodes(RowIndex1).Nodes.Add(objMenu2.Rows(RowIndex2)("FormName"))
                tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Tag = objMenu2.Rows(RowIndex2)("TableCode")
                Dim objMenu3 As DataTable = objDT("sp_Menu_Level3 @TableCode=" & objMenu2.Rows(RowIndex2)("TableCode"))
                For RowIndex3 As Integer = 0 To objMenu3.Rows.Count - 1
                    tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes.Add(objMenu3.Rows(RowIndex3)("FormName"))
                    tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes(RowIndex3).Tag = objMenu3.Rows(RowIndex3)("TableCode")
                Next
            Next
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub UnCheckAll()
        For RowIndex1 As Integer = 0 To tvUser.Nodes.Count - 1
            tvUser.Nodes(RowIndex1).Checked = False
            For RowIndex2 As Integer = 0 To tvUser.Nodes(RowIndex1).Nodes.Count - 1
                tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Checked = False
                For RowIndex3 As Integer = 0 To tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes.Count - 1
                    tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes(RowIndex3).Checked = False
                Next
            Next
        Next
    End Sub

    Private Sub CheckAll()
        For RowIndex1 As Integer = 0 To tvUser.Nodes.Count - 1
            tvUser.Nodes(RowIndex1).Checked = True
            For RowIndex2 As Integer = 0 To tvUser.Nodes(RowIndex1).Nodes.Count - 1
                tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Checked = True
                For RowIndex3 As Integer = 0 To tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes.Count - 1
                    tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes(RowIndex3).Checked = True
                Next
            Next
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cmbUserName.SelectedIndex = 0 Then
            MsgBox("Select the User", MsgBoxStyle.Information, Mssg)
            cmbUserName.Focus()
            Exit Sub
        End If
        If MsgBox("Are you confirm to save the records?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Mssg) = MsgBoxResult.Yes Then
            Dim objTrans As SqlTransaction
            objTrans = objSqlConnection.BeginTransaction

            Try

                objSqlCommand = New SqlCommand("sp_UserRights_Delete", objSqlConnection, objTrans)
                objSqlCommand.CommandType = CommandType.StoredProcedure
                objSqlCommand.Parameters.AddWithValue("@UserCode", Val(cmbUserName.ColData("UserCode")))
                objSqlCommand.ExecuteNonQuery()

                objSqlCommand = New SqlCommand("sp_UserRights_Insert", objSqlConnection, objTrans)
                objSqlCommand.CommandType = CommandType.StoredProcedure

                For RowIndex1 As Integer = 0 To tvUser.Nodes.Count - 1
                    If tvUser.Nodes(RowIndex1).Checked = True Then
                        objSqlCommand = New SqlCommand("sp_UserRights_Insert", objSqlConnection, objTrans)
                        objSqlCommand.CommandType = CommandType.StoredProcedure
                        objSqlCommand.Parameters.AddWithValue("@UserCode", Val(cmbUserName.ColData("UserCode")))
                        objSqlCommand.Parameters.AddWithValue("@TableCode", Val(tvUser.Nodes(RowIndex1).Tag))
                        objSqlCommand.ExecuteNonQuery()
                        'objSqlCommand.Dispose()
                        For RowIndex2 As Integer = 0 To tvUser.Nodes(RowIndex1).Nodes.Count - 1
                            If tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Checked = True Then
                                objSqlCommand = New SqlCommand("sp_UserRights_Insert", objSqlConnection, objTrans)
                                objSqlCommand.CommandType = CommandType.StoredProcedure
                                objSqlCommand.Parameters.AddWithValue("@UserCode", Val(cmbUserName.ColData("UserCode")))
                                objSqlCommand.Parameters.AddWithValue("@TableCode", Val(tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Tag))
                                objSqlCommand.ExecuteNonQuery()
                                'objSqlCommand.Dispose()
                                For RowIndex3 As Integer = 0 To tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes.Count - 1
                                    If tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes(RowIndex3).Checked = True Then
                                        objSqlCommand = New SqlCommand("sp_UserRights_Insert", objSqlConnection, objTrans)
                                        objSqlCommand.CommandType = CommandType.StoredProcedure
                                        objSqlCommand.Parameters.AddWithValue("@UserCode", Val(cmbUserName.ColData("UserCode")))
                                        objSqlCommand.Parameters.AddWithValue("@TableCode", Val(tvUser.Nodes(RowIndex1).Nodes(RowIndex2).Nodes(RowIndex3).Tag))
                                        objSqlCommand.ExecuteNonQuery()
                                        'objSqlCommand.Dispose()
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next

                objTrans.Commit()
                objTrans.Dispose()
                MessageBox.Show("The record(s) are saved", Mssg, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbUserName.SelectedIndex = 0
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Mssg)
                objTrans.Rollback()
                objTrans.Dispose()
            End Try
        End If
    End Sub

    Private Sub tvUser_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvUser.AfterCheck
        'If e.Node.Checked = True Then
        '    'If e.Node.Level > 0 Then If e.Node.Parent.Checked = False Then e.Node.Parent.Checked=true
        '    For RowIndex As Integer = 0 To e.Node.GetNodeCount(True) - 1
        '        e.Node.Nodes(RowIndex).Checked = True
        '    Next
        'Else
        '    For RowIndex As Integer = 0 To e.Node.GetNodeCount(True) - 1
        '        e.Node.Nodes(RowIndex).Checked = False
        '    Next
        'End If
    End Sub
End Class