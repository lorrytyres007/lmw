Imports System.Data.SqlClient

Public Class clsMember
#Region "Property"

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
            objCommand.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber)
            objCommand.Parameters.AddWithValue("@TdOpening", TDOpening)
            objCommand.Parameters.AddWithValue("@status", status)
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
            objCommand.Parameters.AddWithValue("@status", status)
            objCommand.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber)
            objCommand.Parameters.AddWithValue("@TdOpening", TDOpening)
            objCommand.Parameters.AddWithValue("@User", int_UserCode)
            objCommand.Parameters.AddWithValue("@Node", int_NodeCode)
            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class


