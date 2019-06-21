Public Class LEditorial
    Dim CodEditorial As Integer
    Dim Editorial As String
    Public Property _CodEditorial
        Set(value)
            CodEditorial = value
        End Set
        Get
            Return CodEditorial
        End Get
    End Property

    Public Property _Editorial
        Set(value)
            Editorial = value
        End Set
        Get
            Return Editorial
        End Get
    End Property

End Class
