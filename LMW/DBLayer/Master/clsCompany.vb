Imports System.Data.SqlClient

Public Class clsCompany
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

    Dim strsigningAuthority As String
    Public Property SigningAuthority() As String
        Get
            Return strsigningAuthority
        End Get
        Set(ByVal value As String)
            strsigningAuthority = value
        End Set
    End Property

    Dim strCompanyName As String
    Public Property CompanyName() As String
        Get
            Return strCompanyName
        End Get
        Set(ByVal value As String)
            strCompanyName = value
        End Set
    End Property

    Dim strShortName As String
    Public Property ShortName() As String
        Get
            Return strShortName
        End Get
        Set(ByVal value As String)
            strShortName = value
        End Set
    End Property

    Dim strAddress1 As String
    Public Property Address1() As String
        Get
            Return strAddress1
        End Get
        Set(ByVal value As String)
            strAddress1 = value
        End Set
    End Property

    Dim strAddress2 As String
    Public Property Address2() As String
        Get
            Return strAddress2
        End Get
        Set(ByVal value As String)
            strAddress2 = value
        End Set
    End Property


    Dim strCity As String
    Public Property City() As String
        Get
            Return strCity
        End Get
        Set(ByVal value As String)
            strCity = value
        End Set
    End Property

    Dim strDistrict As String
    Public Property District() As String
        Get
            Return strDistrict
        End Get
        Set(ByVal value As String)
            strDistrict = value
        End Set
    End Property

    Dim intStateCode As Integer
    Public Property StateCode() As Integer
        Get
            Return intStateCode
        End Get
        Set(ByVal value As Integer)
            intStateCode = value
        End Set
    End Property

    Dim strPinCode As String
    Public Property PinCode() As String
        Get
            Return strPinCode
        End Get
        Set(ByVal value As String)
            strPinCode = value
        End Set
    End Property

    Dim strPhoneNo As String
    Public Property PhoneNo() As String
        Get
            Return strPhoneNo
        End Get
        Set(ByVal value As String)
            strPhoneNo = value
        End Set
    End Property

    Dim strMobileNo As String
    Public Property MobileNo() As String
        Get
            Return strMobileNo
        End Get
        Set(ByVal value As String)
            strMobileNo = value
        End Set
    End Property
    Dim strWebsite As String
    Public Property Website() As String
        Get
            Return strWebsite
        End Get
        Set(ByVal value As String)
            strWebsite = value
        End Set
    End Property
    Dim strEmail As String
    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

    Dim strInsuranceFlag As String
    Public Property InsuranceFlag() As String
        Get
            Return strInsuranceFlag
        End Get
        Set(ByVal value As String)
            strInsuranceFlag = value
        End Set
    End Property

    Dim strTypingFont As String
    Public Property TypingFont() As String
        Get
            Return strTypingFont
        End Get
        Set(ByVal value As String)
            strTypingFont = value
        End Set
    End Property

    Dim strTINNo As String
    Public Property TINNo() As String
        Get
            Return strTINNo
        End Get
        Set(ByVal value As String)
            strTINNo = value
        End Set
    End Property

    Dim strCSTNo As String
    Public Property CSTNo() As String
        Get
            Return strCSTNo
        End Get
        Set(ByVal value As String)
            strCSTNo = value
        End Set
    End Property
    'Dim imgLogo As image
    'Public Property CSTNo() As String
    '    Get
    '        Return strCSTNo
    '    End Get
    '    Set(ByVal value As String)
    '        strCSTNo = value
    '    End Set
    'End Property

    Dim intSubcentreCode As Integer
    Public Property SubCentreCode() As Integer
        Get
            Return intSubcentreCode
        End Get
        Set(ByVal value As Integer)
            intSubcentreCode = value
        End Set
    End Property

    Dim strsubcentreName As String
    Public Property subcentreName() As String
        Get
            Return strsubcentreName
        End Get
        Set(ByVal value As String)
            strsubcentreName = value
        End Set
    End Property

    Dim boolstatus As Boolean
    Public Property Status() As Boolean
        Get
            Return boolstatus
        End Get
        Set(ByVal value As Boolean)
            boolstatus = value
        End Set
    End Property
#End Region

    Public Function GetRecords() As DataTable
        Try
            Return objDT("sp_Company_GetAll")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteRecords() As DataTable
        Try
            Return objDT("sp_Company_Delete @CompanyCode=" & CompanyCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteSubRecords() As DataTable
        Try
            Return objDT("sp_SubCentre_Delete @SubCentreCode=" & SubCentreCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SaveSubRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objcommand As New SqlCommand("sp_SubCentre_AddEdit", objConnection)
            objcommand.CommandType = CommandType.StoredProcedure
            objcommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objcommand.Parameters.AddWithValue("@SubCentrename", subcentreName)
            objcommand.Parameters.AddWithValue("@Status", Status)
            objcommand.Parameters.AddWithValue("@User", int_UserCode)
            objcommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Return objDT(objcommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpdateSubRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objcommand As New SqlCommand("sp_SubCentre_AddEdit", objConnection)
            objcommand.CommandType = CommandType.StoredProcedure
            objcommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objcommand.Parameters.AddWithValue("@SubcentreCode", SubCentreCode)
            objcommand.Parameters.AddWithValue("@SubCentrename", subcentreName)
            objcommand.Parameters.AddWithValue("@Status", Status)
            objcommand.Parameters.AddWithValue("@User", int_UserCode)
            objcommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Return objDT(objcommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SaveRecords() As DataTable
        Dim objTrans As SqlTransaction
        objTrans = objConnection.BeginTransaction
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Company_AddEdit", objConnection, objTrans)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.AddWithValue("@CompanyName", CompanyName)
            objCommand.Parameters.AddWithValue("@ShortName", ShortName)
            objCommand.Parameters.AddWithValue("@Address1", Address1)
            objCommand.Parameters.AddWithValue("@Address2", Address2)
            objCommand.Parameters.AddWithValue("@City", City)
            objCommand.Parameters.AddWithValue("@District", District)
            objCommand.Parameters.AddWithValue("@StateCode", StateCode)
            objCommand.Parameters.AddWithValue("@PinCode", PinCode)
            objCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo)
            objCommand.Parameters.AddWithValue("@MobileNo", MobileNo)
            objCommand.Parameters.AddWithValue("@Website", Website)
            objCommand.Parameters.AddWithValue("@EMail", Email)
            objCommand.Parameters.AddWithValue("@TINNo", TINNo)
            objCommand.Parameters.AddWithValue("@InsuranceFlag", InsuranceFlag)
            objCommand.Parameters.AddWithValue("@TypingFont", TypingFont)
            objCommand.Parameters.AddWithValue("@SighningAuthority", SigningAuthority)
            objCommand.Parameters.AddWithValue("@CSTNo", CSTNo)
            objCommand.Parameters.AddWithValue("@C_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@C_Node", int_NodeCode)
            Dim CCode As Integer = objCommand.ExecuteScalar()

            objCommand = New SqlCommand("sp_Settings_Update", objConnection, objTrans)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@EnterKey", 0)
            objCommand.Parameters.AddWithValue("@SampleMilk", 0)
            objCommand.Parameters.AddWithValue("@SMonDairy", "CM")
            objCommand.Parameters.AddWithValue("@EntryWith", 2)
            objCommand.Parameters.AddWithValue("@RateinIndividual", 0)
            objCommand.Parameters.AddWithValue("@PourToCan", 0)
            objCommand.Parameters.AddWithValue("@LastTestLr", 0)
            objCommand.Parameters.AddWithValue("@PurchaseinLSUS", 0)
            objCommand.Parameters.AddWithValue("@CompanyCode", CCode)

            objCommand.ExecuteNonQuery()

            'objCommand = New SqlCommand("sp_Head_GeneralUpdate", objConnection, objTrans)
            'objCommand.CommandType = CommandType.StoredProcedure
            'objCommand.Parameters.AddWithValue("@CompanyCode", CCode)
            'objCommand.ExecuteNonQuery()
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
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Company_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.Parameters.AddWithValue("@E_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@E_Node", int_NodeCode)
            objCommand.Parameters.AddWithValue("@CompanyCode", CompanyCode)
            objCommand.Parameters.AddWithValue("@CompanyName", CompanyName)
            objCommand.Parameters.AddWithValue("@ShortName", ShortName)
            objCommand.Parameters.AddWithValue("@Address1", Address1)
            objCommand.Parameters.AddWithValue("@Address2", Address2)
            objCommand.Parameters.AddWithValue("@City", City)
            objCommand.Parameters.AddWithValue("@District", District)
            objCommand.Parameters.AddWithValue("@StateCode", StateCode)
            objCommand.Parameters.AddWithValue("@PinCode", PinCode)
            objCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo)
            objCommand.Parameters.AddWithValue("@MobileNo", MobileNo)
            objCommand.Parameters.AddWithValue("@Website", Website)
            objCommand.Parameters.AddWithValue("@EMail", Email)
            objCommand.Parameters.AddWithValue("@TINNo", TINNo)
            objCommand.Parameters.AddWithValue("@TypingFont", TypingFont)
            objCommand.Parameters.AddWithValue("@InsuranceFlag", InsuranceFlag)
            objCommand.Parameters.AddWithValue("@SighningAuthority", SigningAuthority)
            objCommand.Parameters.AddWithValue("@CSTNo", CSTNo)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FindRecords() As Boolean
        Try
            Return CBool(objDScal("sp_Company_FindRecord @CompanyName='" & CompanyName & "'"))
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BindRecords() As DataSet
        Try
            Return objDS("sp_Company_BindData")
        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class


