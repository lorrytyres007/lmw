Imports System.Data.SqlClient

Public Class clsShareDeposit
    Public ObjInput As DataTable
#Region "Property"
    Dim intuser As Integer
    Public Property user() As Integer
        Get
            Return intuser
        End Get
        Set(ByVal value As Integer)
            intuser = value
        End Set
    End Property
    Dim intNode As Integer
    Public Property Node() As Integer
        Get
            Return intNode
        End Get
        Set(ByVal value As Integer)
            intNode = value
        End Set
    End Property

#End Region
    Public Function SaveRecords()
        Initialise_Connection()
        Dim objTrans As SqlTransaction
        objTrans = objConnection.BeginTransaction
        Try
            For Rowindex As Integer = 0 To ObjInput.Rows.Count - 1
                Dim objCommand As New SqlCommand("sp_ShareDeposit_AddEdit", objConnection, objTrans)
                objCommand.CommandType = CommandType.StoredProcedure
                'If Val(Grid.Item("ShareDepositCode", rowindex).Value) > 0 
                If Val(ObjInput.Rows.Item(Rowindex)("ShareDepositCode")) > 0 Then
                    objCommand.Parameters.AddWithValue("@ShareDepositCode", ObjInput.Rows.Item(Rowindex)("ShareDepositCode"))
                End If
                objCommand.Parameters.AddWithValue("@ShareDepositDate", ObjInput.Rows.Item(Rowindex)("ShareDepositDate"))
                objCommand.Parameters.AddWithValue("@membercode", ObjInput.Rows.Item(Rowindex)("memberCode"))
                objCommand.Parameters.AddWithValue("@Amount", ObjInput.Rows.Item(Rowindex)("Amount"))
                objCommand.Parameters.AddWithValue("@CompanyCode", ObjInput.Rows.Item(Rowindex)("CompanyCode"))
                objCommand.Parameters.AddWithValue("@User", user)
                objCommand.Parameters.AddWithValue("@Node", Node)
                objCommand.ExecuteNonQuery()
            Next
            objTrans.Commit()
            objTrans.Dispose()
            Return Nothing
        Catch ex As Exception
            objTrans.Rollback()
            objTrans.Dispose()
            Throw ex
        End Try
    End Function


End Class
