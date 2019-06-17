Imports System.Data.SqlClient

Public Class clsHead
#Region "Property"

    Dim intHeadCode As Integer
    Public Property HeadCode() As Integer
        Get
            Return intHeadCode
        End Get
        Set(ByVal value As Integer)
            intHeadCode = value
        End Set
    End Property


    Dim intCompany As Integer
    Public Property Company() As Integer
        Get
            Return intCompany
        End Get
        Set(ByVal value As Integer)
            intCompany = value
        End Set
    End Property

    Dim intFycode As Integer
    Public Property Fycode() As Integer
        Get
            Return intFycode
        End Get
        Set(ByVal value As Integer)
            intFycode = value
        End Set
    End Property

    Dim intHeadOpeningCode As Integer
    Public Property HeadOpeningCode() As Integer
        Get
            Return intHeadOpeningCode
        End Get
        Set(ByVal value As Integer)
            intHeadOpeningCode = value
        End Set
    End Property

    Dim strHeadName As String
    Public Property HeadName() As String
        Get
            Return strHeadName
        End Get
        Set(ByVal value As String)
            strHeadName = value
        End Set
    End Property

    Dim intGroupCode As Integer
    Public Property GroupCode() As Integer
        Get
            Return intGroupCode
        End Get
        Set(ByVal value As Integer)
            intGroupCode = value
        End Set
    End Property

    Dim dblOpnBalance As Double
    Public Property OpnBalance() As Double
        Get
            Return dblOpnBalance
        End Get
        Set(ByVal value As Double)
            dblOpnBalance = value
        End Set
    End Property


    Dim boolOnVoucherNumber_YesNo As Boolean
    Public Property OnVoucherNumber_YesNo() As Boolean
        Get
            Return boolOnVoucherNumber_YesNo
        End Get
        Set(ByVal value As Boolean)
            boolOnVoucherNumber_YesNo = value
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

    Dim strrp As String
    Public Property rp() As String
        Get
            Return strrp
        End Get
        Set(ByVal value As String)
            strrp = value
        End Set
    End Property
#End Region

    Public Function GetRecords() As DataTable
        Try
            Return objDT("sp_Head_GetAll @CompanyCode=" & CompanyCode & ",@Fycode=" & Fycode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteRecords() As DataTable
        Try
            Return objDT("sp_Head_Delete @HeadCode=" & HeadCode & ",@CompanyCode=" & CompanyCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SaveRecords() As DataTable
        Dim objTrans As SqlTransaction
        objTrans = objConnection.BeginTransaction
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Head_AddEdit", objConnection, objTrans)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@HeadName", HeadName)
            objCommand.Parameters.AddWithValue("@GroupCode", GroupCode)
            objCommand.Parameters.AddWithValue("@VoucherNumber_YesNo", OnVoucherNumber_YesNo)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@C_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@C_Node", int_NodeCode)
            Dim HCode As Integer = objCommand.ExecuteScalar()

            objCommand = New SqlCommand("sp_HeadOpening_Insert", objConnection, objTrans)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@HeadOpeningCode", HeadOpeningCode)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@HeadCode", HeadCode)
            objCommand.Parameters.AddWithValue("@OpeningBalance", OpnBalance)
            objCommand.Parameters.AddWithValue("@Rp", rp)
            objCommand.Parameters.AddWithValue("@Fycode", Fycode)
            objCommand.ExecuteNonQuery()
            objTrans.Commit()
            objTrans.Dispose()
            Return Nothing
        Catch ex As Exception
            objTrans.Rollback()
            objTrans.Dispose()
            Throw ex
        End Try
    End Function

    Public Function UpdateRecords() As DataTable
        Dim objtrans As SqlTransaction
        objtrans = objConnection.BeginTransaction
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Head_AddEdit", objConnection, objtrans)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@HeadCode", HeadCode)
            objCommand.Parameters.AddWithValue("@HeadName", HeadName)
            objCommand.Parameters.AddWithValue("@GroupCode", GroupCode)
            objCommand.Parameters.AddWithValue("@VoucherNumber_YesNo", OnVoucherNumber_YesNo)
            objCommand.Parameters.AddWithValue("@CompanyCode", int_CompanyCode)
            objCommand.Parameters.AddWithValue("@E_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@E_Node", int_NodeCode)

            Dim HCode As Integer = objCommand.ExecuteScalar()

            objCommand = New SqlCommand("sp_HeadOpening_Insert", objConnection, objtrans)
            objCommand.CommandType = CommandType.StoredProcedure
            If Val(HeadOpeningCode) > 0 Then
                objCommand.Parameters.AddWithValue("@HeadOpeningCode", HeadOpeningCode)
            End If
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@HeadCode", HeadCode)
            objCommand.Parameters.AddWithValue("@OpeningBalance", OpnBalance)
            objCommand.Parameters.AddWithValue("@Rp", rp)
            objCommand.Parameters.AddWithValue("@Fycode", Fycode)
            objCommand.ExecuteNonQuery()
            objtrans.Commit()
            objtrans.Dispose()
            Return Nothing
        Catch ex As Exception
            objtrans.Rollback()
            objtrans.Dispose()
            Throw ex
        End Try
    End Function
    Public Function UpdateOpening() As DataTable
        Dim objCommand As New SqlCommand("sp_HeadOpening_Insert", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure
        If Val(HeadOpeningCode) > 0 Then
            objCommand.Parameters.AddWithValue("@HeadOpeningCode", HeadOpeningCode)
        End If
        objCommand.Parameters.AddWithValue("@CompanyCode", Company)
        objCommand.Parameters.AddWithValue("@HeadCode", HeadCode)
        objCommand.Parameters.AddWithValue("@OpeningBalance", OpnBalance)
        objCommand.Parameters.AddWithValue("@Rp", rp)
        objCommand.Parameters.AddWithValue("@Fycode", Fycode)
        objCommand.ExecuteNonQuery()
        Return Nothing
    End Function
    Public Function BindRecords() As DataSet
        Try

            Return objDS("sp_Head_BindData @CompanyCode=" & CompanyCode & ",@Fycode=" & Fycode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
