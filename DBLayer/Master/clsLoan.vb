Imports System.Data.SqlClient

Public Class clsLoan
#Region "Property"

    Dim intLoanCode As Integer

    Public Property LoanCode() As Integer
        Get
            Return intLoanCode
        End Get
        Set(ByVal value As Integer)
            intLoanCode = value
        End Set
    End Property

    Dim strLoanName As String
    Public Property LoanName() As String
        Get
            Return strLoanName
        End Get
        Set(ByVal value As String)
            strLoanName = value
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
    Dim boolDemand As Boolean
    Public Property Demand() As Boolean
        Get
            Return boolDemand
        End Get
        Set(ByVal value As Boolean)
            boolDemand = value
        End Set
    End Property

    Dim intDemandType As Integer
    Public Property DemandType() As Integer
        Get
            Return intDemandType
        End Get
        Set(ByVal value As Integer)
            intDemandType = value
        End Set
    End Property


#End Region

    Public Function GetRecords() As DataTable
        Try
            Return objDT("sp_LoanName_GetAll")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteRecords() As DataTable
        Try
            Return objDT("sp_LoanName_Delete @LoannameCode=" & LoanCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SaveRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_LoanName_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@LoanName", LoanName)
            objCommand.Parameters.AddWithValue("@Status", Status)
            objCommand.Parameters.AddWithValue("@Demand", Demand)
            objCommand.Parameters.AddWithValue("@DemandType", DemandType)
            objCommand.Parameters.AddWithValue("@User", int_UserCode)
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UpdateRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_LoanName_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@LoanNameCode", LoanCode)
            objCommand.Parameters.AddWithValue("@LoanName", LoanName)
            objCommand.Parameters.AddWithValue("@Status", Status)
            objCommand.Parameters.AddWithValue("@Demand", Demand)
            objCommand.Parameters.AddWithValue("@DemandType", DemandType)
            objCommand.Parameters.AddWithValue("@User", int_UserCode)
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
