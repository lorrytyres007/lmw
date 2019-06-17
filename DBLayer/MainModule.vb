Imports System.Data.SqlClient
Imports System.IO

Module MainModule
    '----------Server Variables-------------------------
    Dim objReader As StreamReader = New StreamReader(Environment.CurrentDirectory.ToString() & "\DBConfig.db")
    Dim str_Reader() As String = objReader.ReadToEnd().Split(Chr(13))
    Public str_ServerName As String = str_Reader(0)
    Public str_DBName As String = str_Reader(1)
    Public objConnection As New SqlConnection("Server=" & str_ServerName & ";Initial Catalog=" & str_DBName & ";User ID=sa;password=@dmin1305;Connect TimeOut=300")
    '----------User Variables---------------------------s
    Public int_UserCode As Integer = 1
    Public int_UserLevel As String = 1
    Public int_NodeCode As Integer = 1
    Public int_CompanyCode As Integer
    Public dbl_CostDiffer As Double
    Public str_TamilFont As String
    '----------General Variables------------------------
    Public Mssg As String

    Public CurDate As DateTime = System.DateTime.Today.ToShortDateString()

    Public Enum SQLServer
        ServerStart
        ServerStop
    End Enum

    Public Sub SQLServerStart(ByVal Status As SQLServer)
        Try
            Dim SQL As New System.ServiceProcess.ServiceController("MSSQLSERVER", ".")
            SQL.MachineName = str_ServerName
            SQL.ServiceName = "MSSQLSERVER"
            Dim str_RunningStatus As String = Sql.Status.ToString()

            If Status = SQLServer.ServerStart Then
                If str_RunningStatus = "Stopped" Then Sql.Start()
            End If

            If Status = SQLServer.ServerStop Then
                If str_RunningStatus = "Running" Then Sql.Stop()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function objDScal(ByVal str As String) As Object
        Try
            objConnection = New SqlConnection("Server=" & str_ServerName & ";Initial Catalog=" & str_DBName & ";User ID=sa;password=@dmin1305;Connect TimeOut=300")

            Initialise_Connection()
            Dim scalarCommand As New SqlCommand(str, objConnection)
            Return scalarCommand.ExecuteScalar()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDT(ByVal str As String) As DataTable
        Try
            Initialise_Connection()
            Dim objDataTable As New DataTable
            Dim objSqlDataAdapter As New SqlDataAdapter
            objSqlDataAdapter = New SqlDataAdapter(str, objConnection)
            objSqlDataAdapter.Fill(objDataTable)
            objDT = objDataTable
            objSqlDataAdapter.Dispose()
            objDataTable.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDT(ByVal cmd As SqlCommand) As DataTable
        Try
            Initialise_Connection()
            Dim objDataTable As New DataTable
            cmd.CommandTimeout = 300
            Dim objSqlDataAdapter As New SqlDataAdapter
            objSqlDataAdapter = New SqlDataAdapter(cmd)
            objSqlDataAdapter.Fill(objDataTable)
            objDT = objDataTable
            objSqlDataAdapter.Dispose()
            objDataTable.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDS(ByVal str As String) As DataSet
        Try
            Initialise_Connection()
            Dim objDataSet As New DataSet
            Dim objSqlDataAdapter As New SqlDataAdapter
            objSqlDataAdapter = New SqlDataAdapter(str, objConnection)
            objSqlDataAdapter.Fill(objDataSet)
            objDS = objDataSet
            objSqlDataAdapter.Dispose()
            objDataSet.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function objDS(ByVal cmd As SqlCommand) As DataSet
        Try
            Initialise_Connection()
            Dim objDataSet As New DataSet
            Dim objSqlDataAdapter As New SqlDataAdapter
            objSqlDataAdapter = New SqlDataAdapter(cmd)
            objSqlDataAdapter.Fill(objDataSet)
            objDS = objDataSet
            objSqlDataAdapter.Dispose()
            objDataSet.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Initialise_Connection()
        If objConnection.State = ConnectionState.Broken Or objConnection.State = ConnectionState.Closed Then
            objConnection.Open()
        End If
    End Sub

    Public Function Encode(ByVal Value As String) As String
        Try
            Dim str_Value As String = Nothing
            For int_i As Integer = 0 To Value.Length - 1
                str_Value = str_Value & Convert.ToChar(Microsoft.VisualBasic.AscW(Value.Substring(int_i, 1)) + 10)
            Next
            Return str_Value
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Decode(ByVal Value As String) As String
        Try
            Dim str_Value As String = Nothing
            For int_i As Integer = 0 To Value.Length - 1
                str_Value = str_Value & Convert.ToChar(Microsoft.VisualBasic.AscW(Value.Substring(int_i, 1)) - 10)
            Next
            Return str_Value
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Module
