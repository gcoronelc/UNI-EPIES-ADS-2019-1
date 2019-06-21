Public Class LLector
    Dim Nombres, Apellidos, Direccion, Email As String
    Dim CodLector, Telefono As Integer
    Public Property _CodLector
        Set(value)
            CodLector = value
        End Set
        Get
            Return CodLector
        End Get
    End Property

    Public Property _Nombres
        Set(value)
            Nombres = value
        End Set
        Get
            Return Nombres
        End Get
    End Property

    Public Property _Apellidos
        Set(value)
            Apellidos = value
        End Set
        Get
            Return Apellidos
        End Get
    End Property


    Public Property _Direccion
        Set(value)
            Direccion = value
        End Set
        Get
            Return Direccion
        End Get
    End Property

    Public Property _Email
        Set(value)
            Email = value
        End Set
        Get
            Return Email
        End Get
    End Property

    Public Property _Telefono
        Set(value)
            Telefono = value
        End Set
        Get
            Return Telefono
        End Get
    End Property
End Class
