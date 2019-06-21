Public Class LAutor
    Dim Autor As String
    Dim CodAutor As Integer
    Public Property _Autor
        Set(value)
            Autor = value
        End Set
        Get
            Return Autor
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
End Class
