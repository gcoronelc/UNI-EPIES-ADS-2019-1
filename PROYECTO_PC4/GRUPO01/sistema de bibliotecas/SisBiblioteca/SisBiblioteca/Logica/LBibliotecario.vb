Public Class LBibliotecario
    Dim Nombres, Apellidos, Direccion, Email, Nro_Carnet, Contrasena As String
    Dim CodBibliotecario, Telefono, Dni As Integer
    Public Property _CodBibliotecario
        Set(value)
            CodBibliotecario = value
        End Set
        Get
            Return CodBibliotecario
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

    Public Property _Nro_Carnet
        Set(value)
            Nro_Carnet = value
        End Set
        Get
            Return Nro_Carnet
        End Get
    End Property

    Public Property _Contrasena
        Set(value)
            Contrasena = value
        End Set
        Get
            Return Contrasena
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

    Public Property _Dni
        Set(value)
            Dni = value
        End Set
        Get
            Return Dni
        End Get
    End Property
End Class
