Imports System.Data.SqlClient

Public Class clsGroup
#Region "Property"

    Dim intGroupCode As Integer
    Public Property GroupCode() As Integer
        Get
            Return intGroupCode
        End Get
        Set(ByVal value As Integer)
            intGroupCode = value
        End Set
    End Property

    Dim strGroupName As String
    Public Property GroupName() As String
        Get
            Return strGroupName
        End Get
        Set(ByVal value As String)
            strGroupName = value
        End Set
    End Property

    Dim boolOnBalanceSheet As Boolean
    Public Property OnBalanceSheet() As Boolean
        Get
            Return boolOnBalanceSheet
        End Get
        Set(ByVal value As Boolean)
            boolOnBalanceSheet = value
        End Set
    End Property

    Dim boolOnTrading As Boolean
    Public Property OnTrading() As Boolean
        Get
            Return boolOnTrading
        End Get
        Set(ByVal value As Boolean)
            boolOnTrading = value
        End Set
    End Property

    Dim boolOnProfitLoss As Boolean
    Public Property OnProfitLoss() As Boolean
        Get
            Return boolOnProfitLoss
        End Get
        Set(ByVal value As Boolean)
            boolOnProfitLoss = value
        End Set
    End Property

    Dim boolOnReport As Boolean
    Public Property OnReport() As Boolean
        Get
            Return boolOnReport
        End Get
        Set(ByVal value As Boolean)
            boolOnReport = value
        End Set
    End Property

    Dim intCompanyCode As Integer
    Public Property CompanyCode() As Integer
        Get
            Return intCompanyCode
        End Get
        Set(ByVal value As Integer)
            intCompanyCode = value
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
    Dim intAccountTypeCode As Integer
    Public Property AccountTypeCode() As Integer
        Get
            Return intAccountTypeCode
        End Get
        Set(ByVal value As Integer)
            intAccountTypeCode = value
        End Set
    End Property
#End Region

    Public Function GetRecords() As DataTable
        Try
            Return objDT("sp_Group_GetAll")
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function BindData() As DataSet
        Try
            Return objDS("sp_Group_Binddata ")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteRecords() As DataTable
        Try
            Return objDT("sp_Group_Delete @GroupCode=" & GroupCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SaveRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Group_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@GroupName", GroupName)
            objCommand.Parameters.AddWithValue("@OnBalanceSheet", OnBalanceSheet)
            objCommand.Parameters.AddWithValue("@OnProfitLoss", OnProfitLoss)
            objCommand.Parameters.AddWithValue("@OnTrading", OnTrading)
            objCommand.Parameters.AddWithValue("@OnReport", OnReport)
            objCommand.Parameters.AddWithValue("@Status", Status)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@AccountTypeCode", AccountTypeCode)
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
            Dim objCommand As New SqlCommand("sp_Group_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.AddWithValue("@GroupCode", GroupCode)
            objCommand.Parameters.AddWithValue("@GroupName", GroupName)
            objCommand.Parameters.AddWithValue("@OnBalanceSheet", OnBalanceSheet)
            objCommand.Parameters.AddWithValue("@OnProfitLoss", OnProfitLoss)
            objCommand.Parameters.AddWithValue("@OnTrading", OnTrading)
            objCommand.Parameters.AddWithValue("@OnReport", OnReport)
            objCommand.Parameters.AddWithValue("@Status", Status)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@AccountTypeCode", AccountTypeCode)
            objCommand.Parameters.AddWithValue("@E_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@E_Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BindRecords() As DataSet
        Try
            Return objDS("sp_Group_BindData ")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
