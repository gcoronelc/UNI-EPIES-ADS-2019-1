Public Class LLibros

    Dim Titulo, Ubicacion As String
    Dim Codlibro, CodAutor, CodGenero, CodEditorial, Cantidad As Integer
    Public Property _CodLibro
        Set(value)
            Codlibro = value
        End Set
        Get
            Return Codlibro
        End Get
    End Property
    Public Property _Titulo
        Set(value)
            Titulo = value
        End Set
        Get
            Return Titulo
        End Get
    End Property

    Public Property _Ubicacion
        Set(value)
            Ubicacion = value
        End Set
        Get
            Return Ubicacion
        End Get
    End Property

    Public Property _CodAutor
        Set(value)
            CodAutor = value
        End Set
        Get
            Return CodAutor
        End Get
    End Property

    Public Property _CodGenero
        Set(value)
            CodGenero = value
        End Set
        Get
            Return CodGenero
        End Get
    End Property


    Public Property _CodEditorial
        Set(value)
            CodEditorial = value
        End Set
        Get
            Return CodEditorial
        End Get
    End Property


    Public Property _Cantidad
        Set(value)
            Cantidad = value
        End Set
        Get
            Return Cantidad
        End Get
    End Property
End Class
