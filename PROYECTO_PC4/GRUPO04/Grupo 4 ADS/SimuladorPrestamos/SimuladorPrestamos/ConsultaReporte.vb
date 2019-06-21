Public Class ConsultaReporte
    Public Shared Sub ImprimirPrestamo(ByVal MiPrestamo As String)
        AbrirConexion()

        Consultar("SELECT Prestamos.ID_PRESTAMO, Prestamos.FECHA, Prestamos.ID_CLIENTE, Prestamo_detalle.FECHA_PAGO, " & _
                                           "Prestamo_detalle.SALDO_INICIAL, Prestamo_detalle.CUOTA, Prestamo_detalle.PAGO_CAPITAL, " & _
                                           "Prestamo_detalle.PAGO_INTERES, Prestamo_detalle.SALDO_FINAL, Cliente.Nombre, Cliente.Telefono, Cliente.Cedula FROM  " & _
                                           "((Prestamos INNER JOIN Prestamo_detalle ON Prestamos.ID_PRESTAMO = Prestamo_detalle.ID_PRESTAMO) INNER JOIN " & _
                                           "Cliente ON Prestamos.ID_CLIENTE = Cliente.Id) where prestamos.ID_PRESTAMO='" & MiPrestamo & "'")

        Dim MiForm As New ReporteForm
        MiForm.NombreReporte = "SimuladorPrestamos.ReportePrestamos.rdlc"
        MiForm.Show()

    End Sub

End Class
