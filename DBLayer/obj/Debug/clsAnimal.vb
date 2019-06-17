Imports System.Data.SqlClient

Public Class clsAnimal
#Region "Property"
    ' Dim AnimalName As String
    Dim intAnimalCode As Integer

    Public Property AnimalCode() As Integer
        Get
            Return intAnimalCode
        End Get
        Set(ByVal value As Integer)
            intAnimalCode = value
        End Set
    End Property

    Dim strAnimalName As String
    Public Property AnimalName() As String
        Get
            Return strAnimalName
        End Get
        Set(ByVal value As String)
            strAnimalName = value
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
        Try
            Return objDT("sp_Animal_GetAll")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DeleteRecords() As DataTable
        Try
            Return objDT("sp_Animal_Delete @AnimalCode=" & AnimalCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SaveRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Animal_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.AddWithValue("@C_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@C_Node", int_NodeCode)

            objCommand.Parameters.AddWithValue("@AnimalName", AnimalName)
            objCommand.Parameters.AddWithValue("@Status", Status)

            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UpdateRecords() As DataTable
        Try
            Initialise_Connection()
            Dim objCommand As New SqlCommand("sp_Animal_AddEdit", objConnection)
            objCommand.CommandType = CommandType.StoredProcedure

            objCommand.Parameters.AddWithValue("@E_User", int_UserCode)
            objCommand.Parameters.AddWithValue("@E_Node", int_NodeCode)
            objCommand.Parameters.AddWithValue("@AnimalCode", AnimalCode)
            objCommand.Parameters.AddWithValue("@AnimalName", AnimalName)
            objCommand.Parameters.AddWithValue("@Status", Status)

            Return objDT(objCommand)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FindRecords() As Boolean
        Try
            Initialise_Connection()
            Return CBool(objDScal("sp_Animal_FindRecord @Name='" & AnimalName & "'"))
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
