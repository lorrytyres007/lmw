Imports System.Data.SqlClient

Public Class clsGledger
#Region "Property"
    Dim intCompanycode As Integer
    Public Property CompanyCode() As Integer
        Get
            Return intCompanycode
        End Get
        Set(ByVal value As Integer)
            intCompanycode = value
        End Set
    End Property
#End Region
    Public Function BindRecords() As DataSet
        Try
            Return objDS("sp_Gledger_BindData @CompanyCode=" & CompanyCode)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
