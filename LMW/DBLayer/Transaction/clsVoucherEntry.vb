Imports System.Data.SqlClient

Public Class clsVoucherEntry
#Region "Property"

    Dim intCompanyCode As Integer
    Public Property CompanyCode() As Integer
        Get
            Return intCompanyCode
        End Get
        Set(ByVal value As Integer)
            intCompanyCode = value
        End Set
    End Property

    Dim intVoucherCode As Integer
    Public Property VoucherCode() As Integer
        Get
            Return intVoucherCode
        End Get
        Set(ByVal value As Integer)
            intVoucherCode = value
        End Set
    End Property

    Dim intVoucherNumber As Integer
    Public Property VoucherNumber() As Integer
        Get
            Return intVoucherNumber
        End Get
        Set(ByVal value As Integer)
            intVoucherNumber = value
        End Set
    End Property

    Dim dtpVoucherdate As DateTime
    Public Property Voucherdate() As DateTime
        Get
            Return dtpVoucherdate
        End Get
        Set(ByVal value As DateTime)
            dtpVoucherdate = value
        End Set
    End Property

    Dim strVoucherType As String
    Public Property VoucherType() As String
        Get
            Return strVoucherType
        End Get
        Set(ByVal value As String)
            strVoucherType = value
        End Set
    End Property

    Dim strRP As String
    Public Property RP() As String
        Get
            Return strRP
        End Get
        Set(ByVal value As String)
            strRP = value
        End Set
    End Property

    Dim intHeadCode As Integer
    Public Property HeadCode() As Integer
        Get
            Return intHeadCode
        End Get
        Set(ByVal value As Integer)
            intHeadCode = value
        End Set
    End Property

    Dim strRemarks As String
    Public Property Remarks() As String
        Get
            Return strRemarks
        End Get
        Set(ByVal value As String)
            strRemarks = value
        End Set
    End Property

    Dim dblAmount As Double
    Public Property Amount() As Double
        Get
            Return dblAmount
        End Get
        Set(ByVal value As Double)
            dblAmount = value
        End Set
    End Property

    Dim dblAdjustment As Double
    Public Property Adjustment() As Double
        Get
            Return dblAdjustment
        End Get
        Set(ByVal value As Double)
            dblAdjustment = value
        End Set
    End Property
#End Region

    Public Function GetRecords() As DataTable
        Try
            Return objDT("sp_VoucherEntry_GetAll @CompanyCode=" & CompanyCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteRecords() As DataTable
        Try
            Return objDT("sp_VoucherEntry_Delete @VoucherCode=" & VoucherCode & ",@CompanyCode=" & CompanyCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BindRecords() As DataSet
        Try
            'Return objDS("sp_VoucherEntry_BindData @CompanyCode=" & CompanyCode & ",@RP=" & RP)
            Return objDS("sp_VoucherEntry_BindData @CompanyCode=" & CompanyCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SaveRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_VoucherEntry_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@VoucherNumber", VoucherNumber)
            objCommand.Parameters.AddWithValue("@VoucherDate", Voucherdate)
            objCommand.Parameters.AddWithValue("@VoucherType", VoucherType)
            objCommand.Parameters.AddWithValue("@HeadCode", HeadCode)
            objCommand.Parameters.AddWithValue("@Amount", Amount)
            objCommand.Parameters.AddWithValue("@Adjustment", Adjustment)
            objCommand.Parameters.AddWithValue("@RP", Rp)
            objCommand.Parameters.AddWithValue("@Remarks", Remarks)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
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
            Dim objCommand As New SqlCommand("sp_VoucherEntry_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode)
            objCommand.Parameters.AddWithValue("@VoucherNumber", VoucherNumber)
            objCommand.Parameters.AddWithValue("@VoucherDate", Voucherdate)
            objCommand.Parameters.AddWithValue("@VoucherType", VoucherType)
            objCommand.Parameters.AddWithValue("@HeadCode", HeadCode)
            objCommand.Parameters.AddWithValue("@Amount", Amount)
            objCommand.Parameters.AddWithValue("@Adjustment", Adjustment)
            objCommand.Parameters.AddWithValue("@RP", RP)
            objCommand.Parameters.AddWithValue("@Remarks", Remarks)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@User", int_UserCode)
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BindNumber() As Integer
        Try
            Return objDScal("sp_VoucherEntry_VoucherNumber @Companycode=" & CompanyCode & ",@RP='" & RP & "'")
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
