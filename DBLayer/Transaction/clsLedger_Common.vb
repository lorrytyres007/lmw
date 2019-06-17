Imports System.Data.SqlClient

Public Class clsLedger_Common
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

    Dim dtpVoucherDate As DateTime
    Public Property VoucherDate() As DateTime
        Get
            Return dtpVoucherDate
        End Get
        Set(ByVal value As DateTime)
            dtpVoucherDate = value
        End Set
    End Property

    Dim dblMMLtr As Double
    Public Property MMLtr() As Double
        Get
            Return dblMMLtr
        End Get
        Set(ByVal value As Double)
            dblMMLtr = value
        End Set
    End Property

    Dim dblMELtr As Double
    Public Property MELtr() As Double
        Get
            Return dblMELtr
        End Get
        Set(ByVal value As Double)
            dblMELtr = value
        End Set
    End Property

    Dim dblMMAdj As Double
    Public Property MMAdj() As Double
        Get
            Return dblMMAdj
        End Get
        Set(ByVal value As Double)
            dblMMAdj = value
        End Set
    End Property

    Dim dblMEAdj As Double
    Public Property MEAdj() As Double
        Get
            Return dblMEAdj
        End Get
        Set(ByVal value As Double)
            dblMEAdj = value
        End Set
    End Property

    Dim dblLSMBMLtr As Double
    Public Property LSMBMLtr() As Double
        Get
            Return dblLSMBMLtr
        End Get
        Set(ByVal value As Double)
            dblLSMBMLtr = value
        End Set
    End Property

    Dim dblLSMCMLtr As Double
    Public Property LSMCMLtr() As Double
        Get
            Return dblLSMCMLtr
        End Get
        Set(ByVal value As Double)
            dblLSMCMLtr = value
        End Set
    End Property
    Dim dblLSEBMLtr As Double
    Public Property LSEBMLtr() As Double
        Get
            Return dblLSEBMLtr
        End Get
        Set(ByVal value As Double)
            dblLSEBMLtr = value
        End Set
    End Property

    Dim dblLSECMLtr As Double
    Public Property LSECMLtr() As Double
        Get
            Return dblLSECMLtr
        End Get
        Set(ByVal value As Double)
            dblLSECMLtr = value
        End Set
    End Property

    Dim dblLSMBMAmt As Double
    Public Property LSMBMAmt() As Double
        Get
            Return dblLSMBMAmt
        End Get
        Set(ByVal value As Double)
            dblLSMBMAmt = value
        End Set
    End Property

    Dim dblLSMCMAmt As Double
    Public Property LSMCMAmt() As Double
        Get
            Return dblLSMCMAmt
        End Get
        Set(ByVal value As Double)
            dblLSMCMAmt = value
        End Set
    End Property

    Dim dblLSEBMAmt As Double
    Public Property LSEBMAmt() As Double
        Get
            Return dblLSEBMAmt
        End Get
        Set(ByVal value As Double)
            dblLSEBMAmt = value
        End Set
    End Property
    Dim dblLSECMAmt As Double
    Public Property LSECMAmt() As Double
        Get
            Return dblLSECMAmt
        End Get
        Set(ByVal value As Double)
            dblLSECMAmt = value
        End Set
    End Property

    Dim dblLSMAAmt As Double
    Public Property LSMAAmt() As Double
        Get
            Return dblLSMAAmt
        End Get
        Set(ByVal value As Double)
            dblLSMAAmt = value
        End Set
    End Property

    Dim dblLSEAAmt As Double
    Public Property LSEAAmt() As Double
        Get
            Return dblLSEAAmt
        End Get
        Set(ByVal value As Double)
            dblLSEAAmt = value
        End Set
    End Property

    Dim dblSMMLtr As Double
    Public Property SMMLtr() As Double
        Get
            Return dblSMMLtr
        End Get
        Set(ByVal value As Double)
            dblSMMLtr = value
        End Set
    End Property

    Dim dblSMELtr As Double
    Public Property SMELtr() As Double
        Get
            Return dblSMELtr
        End Get
        Set(ByVal value As Double)
            dblSMELtr = value
        End Set
    End Property

    Dim dblSMMAmt As Double
    Public Property SMMAmt() As Double
        Get
            Return dblSMMAmt
        End Get
        Set(ByVal value As Double)
            dblSMMAmt = value
        End Set
    End Property

    Dim dblSMEAmt As Double
    Public Property SMEAmt() As Double
        Get
            Return dblSMEAmt
        End Get
        Set(ByVal value As Double)
            dblSMEAmt = value
        End Set
    End Property
    Dim dblFeedSales As Double
    Public Property FeedSales() As Double
        Get
            Return dblFeedSales
        End Get
        Set(ByVal value As Double)
            dblFeedSales = value
        End Set
    End Property

    Dim dblSemonSales As Double
    Public Property SemonSales() As Double
        Get
            Return dblSemonSales
        End Get
        Set(ByVal value As Double)
            dblSemonSales = value
        End Set
    End Property

    Dim dblMPPQty As Double
    Public Property MPPQty() As Double
        Get
            Return dblMPPQty
        End Get
        Set(ByVal value As Double)
            dblMPPQty = value
        End Set
    End Property
    Dim dblEPPQty As Double
    Public Property EPPQty() As Double
        Get
            Return dblEPPQty
        End Get
        Set(ByVal value As Double)
            dblEPPQty = value
        End Set
    End Property

    Dim dblMAPPAmt As Double
    Public Property MAPPAmt() As Double
        Get
            Return dblMAPPAmt
        End Get
        Set(ByVal value As Double)
            dblMAPPAmt = value
        End Set
    End Property

    Dim dblEAPPAmt As Double
    Public Property EAPPAmt() As Double
        Get
            Return dblEAPPAmt
        End Get
        Set(ByVal value As Double)
            dblEAPPAmt = value
        End Set
    End Property

    Dim dblAFreeMilk As Double
    Public Property AFreeMilk() As Double
        Get
            Return dblAFreeMilk
        End Get
        Set(ByVal value As Double)
            dblAFreeMilk = value
        End Set
    End Property

    Dim dblUser As Double
    Public Property User() As Double
        Get
            Return dblUser
        End Get
        Set(ByVal value As Double)
            dblUser = value
        End Set
    End Property

    Dim dblNode As Double
    Public Property Node() As Double
        Get
            Return dblNode
        End Get
        Set(ByVal value As Double)
            dblNode = value
        End Set
    End Property

    Dim strFeedEntry As String
    Public Property FeedEntry() As String
        Get
            Return strFeedEntry
        End Get
        Set(ByVal value As String)
            strFeedEntry = value
        End Set
    End Property

    Dim strSemonEntry As String
    Public Property SemonEntry() As String
        Get
            Return strSemonEntry
        End Get
        Set(ByVal value As String)
            strSemonEntry = value
        End Set
    End Property
#End Region

    Public Function SaveRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Ledger_Common_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@VoucherDate", VoucherDate)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@MMLtr", MMLtr)
            objCommand.Parameters.AddWithValue("@MELtr", MELtr)
            objCommand.Parameters.AddWithValue("@MMAdj", MMAdj)
            objCommand.Parameters.AddWithValue("@MEAdj", MEAdj)
            objCommand.Parameters.AddWithValue("@LSMBMLtr", LSMBMLtr)
            objCommand.Parameters.AddWithValue("@LSMCMLtr", LSMCMLtr)
            objCommand.Parameters.AddWithValue("@LSEBMLtr", LSEBMLtr)
            objCommand.Parameters.AddWithValue("@LSECMLtr", LSECMLtr)
            objCommand.Parameters.AddWithValue("@LSMBMAmt", LSMBMAmt)
            objCommand.Parameters.AddWithValue("@LSMCMAmt", LSMCMAmt)
            objCommand.Parameters.AddWithValue("@LSEBMAmt", LSEBMAmt)
            objCommand.Parameters.AddWithValue("@LSECMAmt", LSECMAmt)
            objCommand.Parameters.AddWithValue("@LSMAAmt", LSMAAmt)
            objCommand.Parameters.AddWithValue("@LSEAAmt", LSEAAmt)
            objCommand.Parameters.AddWithValue("@SMMLtr", SMMLtr)
            objCommand.Parameters.AddWithValue("@SMELtr", SMELtr)
            objCommand.Parameters.AddWithValue("@SMMAmt", SMMAmt)
            objCommand.Parameters.AddWithValue("@SMEAmt", SMEAmt)
            objCommand.Parameters.AddWithValue("@FeedSales", FeedSales)
            objCommand.Parameters.AddWithValue("@SemonSales", SemonSales)
            objCommand.Parameters.AddWithValue("@MPPQty", MPPQty)
            objCommand.Parameters.AddWithValue("@EPPQty", EPPQty)
            objCommand.Parameters.AddWithValue("@MAPPAmt", MAPPAmt)
            objCommand.Parameters.AddWithValue("@EAPPAmt", EAPPAmt)
            objCommand.Parameters.AddWithValue("@AFreeMilk", AFreeMilk)
            objCommand.Parameters.AddWithValue("@FeedEntry", FeedEntry)
            objCommand.Parameters.AddWithValue("@SemonEntry", SemonEntry)
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
            Dim objCommand As New SqlCommand("sp_Ledger_Common_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode)
            objCommand.Parameters.AddWithValue("@VoucherDate", VoucherDate)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@MMLtr", MMLtr)
            objCommand.Parameters.AddWithValue("@MELtr", MELtr)
            objCommand.Parameters.AddWithValue("@MMAdj", MMAdj)
            objCommand.Parameters.AddWithValue("@MEAdj", MEAdj)
            objCommand.Parameters.AddWithValue("@LSMBMLtr", LSMBMLtr)
            objCommand.Parameters.AddWithValue("@LSMCMLtr", LSMCMLtr)
            objCommand.Parameters.AddWithValue("@LSEBMLtr", LSEBMLtr)
            objCommand.Parameters.AddWithValue("@LSECMLtr", LSECMLtr)
            objCommand.Parameters.AddWithValue("@LSMBMAmt", LSMBMAmt)
            objCommand.Parameters.AddWithValue("@LSMCMAmt", LSMCMAmt)
            objCommand.Parameters.AddWithValue("@LSEBMAmt", LSEBMAmt)
            objCommand.Parameters.AddWithValue("@LSECMAmt", LSECMAmt)
            objCommand.Parameters.AddWithValue("@LSMAAmt", LSMAAmt)
            objCommand.Parameters.AddWithValue("@LSEAAmt", LSEAAmt)
            objCommand.Parameters.AddWithValue("@SMMLtr", SMMLtr)
            objCommand.Parameters.AddWithValue("@SMELtr", SMELtr)
            objCommand.Parameters.AddWithValue("@SMMAmt", SMMAmt)
            objCommand.Parameters.AddWithValue("@SMEAmt", SMEAmt)
            objCommand.Parameters.AddWithValue("@FeedSales", FeedSales)
            objCommand.Parameters.AddWithValue("@SemonSales", SemonSales)
            objCommand.Parameters.AddWithValue("@MPPQty", MPPQty)
            objCommand.Parameters.AddWithValue("@EPPQty", EPPQty)
            objCommand.Parameters.AddWithValue("@MAPPAmt", MAPPAmt)
            objCommand.Parameters.AddWithValue("@EAPPAmt", EAPPAmt)
            objCommand.Parameters.AddWithValue("@AFreeMilk", AFreeMilk)
            objCommand.Parameters.AddWithValue("@FeedEntry", FeedEntry)
            objCommand.Parameters.AddWithValue("@SemonEntry", SemonEntry)
            objCommand.Parameters.AddWithValue("@User", int_UserCode)
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BindRecords() As DataSet
        Try
            Return objDS("sp_Ledger_Common_BindData @CompanyCode=" & CompanyCode & ",@Date='" & VoucherDate & "'")
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
