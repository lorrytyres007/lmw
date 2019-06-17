Public Class Class1
    Public Class HardDrive
        Private dsk_model As String
        Private dsk_type As String
        Private dsk_serialNo As String

        Public Property Model() As String

            Get
                Return dsk_model
            End Get
            Set(ByVal value As String)
                dsk_model = value
            End Set
        End Property

        Public Property Type() As String

            Get
                Return dsk_type
            End Get
            Set(ByVal value As String)
                dsk_type = value
            End Set
        End Property

        Public Property serialNo() As String
            Get
                Return dsk_serialNo
            End Get
            Set(ByVal value As String)
                dsk_serialNo = value
            End Set
        End Property


    End Class

End Class
