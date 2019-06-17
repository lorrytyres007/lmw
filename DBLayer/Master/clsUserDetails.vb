Public Class clsUserDetails
#Region "Property"
    Dim intUserCode As Integer
    Public Property UserCode() As Integer
        Get
            Return intUserCode
        End Get
        Set(ByVal value As Integer)
            intUserCode = value
        End Set
    End Property

    Dim strUserName As String
    Public Property UserName() As String
        Get
            Return strUserName
        End Get
        Set(ByVal value As String)
            strUserName = value
        End Set
    End Property

    Dim strPassword As String
    Public Property Password() As String
        Get
            Return strPassword
        End Get
        Set(ByVal value As String)
            strPassword = value
        End Set
    End Property

    Dim intUserLevel As Integer
    Public Property UserLevel() As Integer
        Get
            Return intUserLevel
        End Get
        Set(ByVal value As Integer)
            intUserLevel = value
        End Set
    End Property

    Dim strStatus As String
    Public Property Status() As String
        Get
            Return strStatus
        End Get
        Set(ByVal value As String)
            strStatus = value
        End Set
    End Property
#End Region
    Public Function GetRecords() As DataTable
        Return objDT("sp_User_GetAll")
    End Function

    Public Function SaveRecords() As DataTable
        Return objDT("sp_User_GetAll")
    End Function
End Class
