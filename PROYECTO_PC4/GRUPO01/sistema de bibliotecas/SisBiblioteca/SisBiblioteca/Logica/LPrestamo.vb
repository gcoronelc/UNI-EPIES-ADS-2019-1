Public Class LPrestamo
    Dim CodPrestamo, CodLector, CodLibro As Integer

    Dim Fec_Devolucion As Date
    Public Property _CodPrestamo
        Set(value)
            CodPrestamo = value
        End Set
        Get
            Return CodPrestamo
        End Get
    End Property
    Public Property _CodLector
        Set(value)
            CodLector = value
        End Set
        Get
            Return CodLector
        End Get
    End Property

    Public Property _CodLibro
        Set(value)
            CodLibro = value
        End Set
        Get
            Return CodLibro
        End Get
    End Property
    Public Property _FecDevolucion
        Set(value)
            Fec_Devolucion = value
        End Set
        Get
            Return Fec_Devolucion
        End Get
    End Property
End Class
