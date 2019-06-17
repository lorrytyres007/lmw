Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Image

Public Class clsMember
#Region "Property"
    Public Photo As Byte()
    'Public Photo As SqlDbType.image()
    Dim intEmployeeNumber As Integer

    Public Property EmployeeNumber() As Integer
        Get
            Return intEmployeeNumber
        End Get
        Set(ByVal value As Integer)
            intEmployeeNumber = value
        End Set
    End Property

    Dim intmemberCode As Integer

    Public Property memberCode() As Integer
        Get
            Return intmemberCode
        End Get
        Set(ByVal value As Integer)
            intmemberCode = value
        End Set
    End Property


    Dim intNumber As Integer

    Public Property Number() As Integer
        Get
            Return intNumber
        End Get
        Set(ByVal value As Integer)
            intNumber = value
        End Set
    End Property

    Dim strMemberName As String

    Public Property MemberName() As String
        Get
            Return strMemberName
        End Get
        Set(ByVal value As String)
            strMemberName = value
        End Set
    End Property

    Dim strMemberName_Tamil As String
    Public Property MemberName_Tamil() As String
        Get
            Return strMemberName_Tamil
        End Get
        Set(ByVal value As String)
            strMemberName_Tamil = value
        End Set
    End Property

    Dim strMemberType As String

    Public Property MemberType() As String
        Get
            Return strMemberType
        End Get
        Set(ByVal value As String)
            strMemberType = value
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

    Dim strAddress3 As String

    Public Property Address3() As String
        Get
            Return strAddress3
        End Get
        Set(ByVal value As String)
            strAddress3 = value
        End Set
    End Property

    Dim strAddress4 As String

    Public Property Address4() As String
        Get
            Return strAddress4
        End Get
        Set(ByVal value As String)
            strAddress4 = value
        End Set
    End Property

    Dim strAddress_Tamil1 As String

    Public Property Address_Tamil1() As String
        Get
            Return strAddress_Tamil1
        End Get
        Set(ByVal value As String)
            strAddress_Tamil1 = value
        End Set
    End Property

    Dim strAddress_Tamil2 As String

    Public Property Address_Tamil2() As String
        Get
            Return strAddress_Tamil2
        End Get
        Set(ByVal value As String)
            strAddress_Tamil2 = value
        End Set
    End Property

    Dim strAddress_Tamil3 As String

    Public Property Address_Tamil3() As String
        Get
            Return strAddress_Tamil3
        End Get
        Set(ByVal value As String)
            strAddress_Tamil3 = value
        End Set
    End Property

    Dim strAddress_Tamil4 As String

    Public Property Address_Tamil4() As String
        Get
            Return strAddress_Tamil4
        End Get
        Set(ByVal value As String)
            strAddress_Tamil4 = value
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


    Dim boolstatus As Boolean
    Public Property status() As Boolean
        Get
            Return boolstatus
        End Get
        Set(ByVal value As Boolean)
            boolstatus = value
        End Set
    End Property
    
    Dim dblTDOpening As Double
    Public Property TDOpening() As Double
        Get
            Return dblTDOpening
        End Get
        Set(ByVal value As Double)
            dblTDOpening = value
        End Set
    End Property

    Dim dblShareOpening As Double
    Public Property ShareOpening() As Double
        Get
            Return dblShareOpening
        End Get
        Set(ByVal value As Double)
            dblShareOpening = value
        End Set
    End Property
#End Region

    Public Function GetRecords() As DataTable
        Try
            Return objDT("sp_Member_GetAll")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteRecords() As DataTable
        Try
            Return objDT("sp_Member_Delete @memberCode=" & memberCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetMemberNumber() As DataTable
        Try
            Return objDT("sp_Member_GetbyNumber")
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SaveRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Member_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.AddWithValue("@Number", Number)
            objCommand.Parameters.AddWithValue("@MemberName", MemberName)
            objCommand.Parameters.AddWithValue("@MemberName_Tamil", MemberName_Tamil)
            objCommand.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber)
            objCommand.Parameters.AddWithValue("@TdOpening", TDOpening)
            objCommand.Parameters.AddWithValue("@ShareOpening", ShareOpening)
            objCommand.Parameters.AddWithValue("@status", status)
            objCommand.Parameters.AddWithValue("@MemberType", MemberType)
            objCommand.Parameters.AddWithValue("@Address1", Address1)
            objCommand.Parameters.AddWithValue("@Address2", Address2)
            objCommand.Parameters.AddWithValue("@Address3", Address3)
            objCommand.Parameters.AddWithValue("@Address4", Address4)
            objCommand.Parameters.AddWithValue("@Address_Tamil1", Address_Tamil1)
            objCommand.Parameters.AddWithValue("@Address_Tamil2", Address_Tamil2)
            objCommand.Parameters.AddWithValue("@Address_Tamil3", Address_Tamil3)
            objCommand.Parameters.AddWithValue("@Address_Tamil4", Address_Tamil4)
            objCommand.Parameters.AddWithValue("@MobileNo", MobileNo)
            objCommand.Parameters.AddWithValue("@Photo_Image", SqlDbType.Image).Value = Photo
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            objCommand.Parameters.AddWithValue("@user", int_UserCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UpdateRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Member_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.AddWithValue("@memberCode", memberCode)
            objCommand.Parameters.AddWithValue("@Number", Number)
            objCommand.Parameters.AddWithValue("@MemberName", MemberName)
            objCommand.Parameters.AddWithValue("@MemberName_Tamil", MemberName_Tamil)
            objCommand.Parameters.AddWithValue("@status", status)
            objCommand.Parameters.AddWithValue("@MemberType", MemberType)
            objCommand.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber)
            objCommand.Parameters.AddWithValue("@TdOpening", TDOpening)
            objCommand.Parameters.AddWithValue("@ShareOpening", ShareOpening)
            objCommand.Parameters.AddWithValue("@Address1", Address1)
            objCommand.Parameters.AddWithValue("@Address2", Address2)
            objCommand.Parameters.AddWithValue("@Address3", Address3)
            objCommand.Parameters.AddWithValue("@Address4", Address4)
            objCommand.Parameters.AddWithValue("@Address_Tamil1", Address_Tamil1)
            objCommand.Parameters.AddWithValue("@Address_Tamil2", Address_Tamil2)
            objCommand.Parameters.AddWithValue("@Address_Tamil3", Address_Tamil3)
            objCommand.Parameters.AddWithValue("@Address_Tamil4", Address_Tamil4)
            objCommand.Parameters.AddWithValue("@MobileNo", MobileNo)
            objCommand.Parameters.AddWithValue("@Photo_Image", SqlDbType.Image).Value = Photo
            objCommand.Parameters.AddWithValue("@User", int_UserCode)
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class


