Public Class LGenero
    Dim CodGenero As Integer
    Dim Genero As String
    Public Property _Genero
        Set(value)
            Genero = value
        End Set
        Get
            Return Genero
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
End Class
