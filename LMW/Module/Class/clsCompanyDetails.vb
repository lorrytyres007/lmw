
Public Class clsCompanyDetails
    Private _CompanyCode As Integer = 0
    Private _CompanyName As String = "SWAS TECHNOLOGIES"
    Private _ShortName As String = "SWAS"
    Private _Address1 As String = "#6, SS COMPLEX, OPP. SUBHA FURNITURE"
    Private _Address2 As String = "78, YAHOOP STREET"
    Private _City As String = "GOBICHETTIPALAYAM"
    Private _District As String = "ERODE DISTRICT"
    Private _PinCode As String = "638452"
    Private _PhoneNo As String = "9942307995"
    Private _MobileNo As String = "9965699356"
    Private _Website As String = "www.swastech.com"
    Private _EMail As String = "info@swastech.com"
    Private _TINNo As String = ""
    Private _CSTNo As String = ""
    Private _SighningAuthority As String = ""


#Region "Property"

    Public Property CompanyCode() As Integer
        Get
            Return _CompanyCode
        End Get
        Set(ByVal value As Integer)
            _CompanyCode = value
        End Set
    End Property

    Public Property CompanyName() As String
        Get
            Return _CompanyName
        End Get
        Set(ByVal value As String)
            _CompanyName = value
        End Set
    End Property

    Public Property ShortName() As String
        Get
            Return _ShortName
        End Get
        Set(ByVal value As String)
            _ShortName = value
        End Set
    End Property

    Public Property Address1() As String
        Get
            Return _Address1
        End Get
        Set(ByVal value As String)
            _Address1 = value
        End Set
    End Property

    Public Property Address2() As String
        Get
            Return _Address2
        End Get
        Set(ByVal value As String)
            _Address2 = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
        End Set
    End Property

    Public Property District() As String
        Get
            Return _District
        End Get
        Set(ByVal value As String)
            _District = value
        End Set
    End Property

    Public Property PinCode() As String
        Get
            Return _PinCode
        End Get
        Set(ByVal value As String)
            _PinCode = value
        End Set
    End Property

    Public Property PhoneNo() As String
        Get
            Return _PhoneNo
        End Get
        Set(ByVal value As String)
            _PhoneNo = value
        End Set
    End Property

    Public Property MobileNo() As String
        Get
            Return _MobileNo
        End Get
        Set(ByVal value As String)
            _MobileNo = value
        End Set
    End Property

    Public Property Website() As String
        Get
            Return _Website
        End Get
        Set(ByVal value As String)
            _Website = value
        End Set
    End Property

    Public Property EMail() As String
        Get
            Return _EMail
        End Get
        Set(ByVal value As String)
            _EMail = value
        End Set
    End Property

    Public Property TINNo() As String
        Get
            Return _TINNo
        End Get
        Set(ByVal value As String)
            _TINNo = value
        End Set
    End Property

    Public Property CSTNo() As String
        Get
            Return _CSTNo
        End Get
        Set(ByVal value As String)
            _CSTNo = value
        End Set
    End Property

    Public Property SighningAuthority() As String
        Get
            Return _SighningAuthority
        End Get
        Set(ByVal value As String)
            _SighningAuthority = value
        End Set
    End Property
#End Region

End Class
