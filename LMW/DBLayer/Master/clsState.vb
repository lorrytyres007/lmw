Imports System.Data.SqlClient

Public Class clsState
#Region "Property"

    Dim intStateCode As Integer

    Public Property StateCode() As Integer
        Get
            Return intStateCode
        End Get
        Set(ByVal value As Integer)
            intStateCode = value
        End Set
    End Property

    Dim strStateName As String
    Public Property StateName() As String
        Get
            Return strStateName
        End Get
        Set(ByVal value As String)
            strStateName = value
        End Set
    End Property

    Dim boolStatus As Boolean
    Public Property Status() As Boolean
        Get
            Return boolStatus
        End Get
        Set(ByVal value As Boolean)
            boolStatus = value
        End Set
    End Property
#End Region

    Public Function GetRecords() As DataTable
        Try
            Return objDT("sp_State_GetAll")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteRecords() As DataTable
        Try
            Return objDT("sp_State_Delete @StateCode=" & StateCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SaveRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_State_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@StateName", StateName)
            objCommand.Parameters.AddWithValue("@Status", Status)
            objCommand.Parameters.AddWithValue("@C_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@C_Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UpdateRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_State_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@StateCode", StateCode)
            objCommand.Parameters.AddWithValue("@StateName", StateName)
            objCommand.Parameters.AddWithValue("@Status", Status)
            objCommand.Parameters.AddWithValue("@E_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@E_Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
