Public Class Prestamos
    Private InteresPrestamo As Double
    Private NoPrestamo As String = "0"
    Private CuotaPagar As Double = 0

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Monto As Double = txtMonto.Text
        Dim Tasa As Double = CDbl(txtTasaAnual.Text) / 100
        Dim Plazo As Integer = txtPlazo.Text
        Dim Periodo As Double = 0
        Dim R As Double

        Periodo = 12
        InteresPrestamo = CDbl(txtTasaAnual.Text) / 100 / 12

        R = (1 + Tasa / Periodo)

        CuotaPagar = Monto * (R - 1) / (1 - R ^ (-Plazo))

        txtCuota.Text = Format(CuotaPagar, "standard")
    End Sub

    Private Sub btnCompletar_Click(sender As Object, e As EventArgs) Handles btnCompletar.Click
        NoPrestamo = "1"

        If Consultar("select top 1  ID from prestamos order by id desc") = True Then
            NoPrestamo = CInt(MiDataSet.Tables(0).Rows(0).Item(0).ToString) + 1
        End If

        NoPrestamo = NoPrestamo.ToString.PadLeft(5, "0")
        txtPrestamo.Text = NoPrestamo

        FECHA_GENERAL = DateTimePicker1.Value.Date

        Guardar("insert into prestamos(id_prestamo,fecha,id_cliente) values('" & NoPrestamo & "','" & DateTimePicker1.Value.Date & "','" & lbIDcliente.Text & "')")
        Dim FechaPago As Date = DateTimePicker1.Value
        Dim SaldoInicial As Double = CDbl(txtMonto.Text)
        Dim CapitalPagado As Double = 0
        Dim InteresPagado As Double = 0
        Dim SaldoFinal As Double = 0

        For i As Integer = 1 To CInt(txtPlazo.Text)
            FechaPago = FechaPago.AddMonths(1)
            InteresPagado = SaldoInicial * InteresPrestamo
            CapitalPagado = CuotaPagar - InteresPagado
            SaldoFinal = SaldoInicial - CapitalPagado
            Guardar("insert into prestamo_detalle(id_prestamo,fecha_pago,saldo_inicial,cuota,pago_capital,pago_interes,saldo_final) values('" & NoPrestamo & "','" & FechaPago & "','" & SaldoInicial & "','" & CuotaPagar & "','" & CapitalPagado & "','" & InteresPagado & "','" & SaldoFinal & "')")
            SaldoInicial = SaldoInicial - CapitalPagado

        Next

        LlenarPrestamo(NoPrestamo)

        txtBuscaPrestamo.Text = NoPrestamo
    End Sub

    Public Sub LlenarPrestamo(ByVal Prestamo As String)
        If Consultar("select * from prestamo_detalle where id_prestamo='" & Prestamo & "'") = True Then
            DataGridView1.DataSource = MiDataSet.Tables(0)
        End If
    End Sub

    Private Sub cboCliente_GotFocus(sender As Object, e As EventArgs) Handles cboCliente.GotFocus
        If Consultar("select * from cliente") = True Then
            cboCliente.DataSource = MiDataSet.Tables(0)
            cboCliente.DisplayMember = "NOMBRE"
            cboCliente.ValueMember = "ID"

        End If
    End Sub

    Private Sub cboCliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedValueChanged
        lbIDcliente.Text = cboCliente.SelectedValue.ToString
    End Sub

    Private Sub txtBuscaPrestamo_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaPrestamo.TextChanged
        LlenarPrestamo(txtBuscaPrestamo.Text)
    End Sub

    Private Sub txtTasaAnual_Leave(sender As Object, e As EventArgs) Handles txtTasaAnual.Leave
        txtInteresMensual.Text = CDbl(txtTasaAnual.Text) / 12
    End Sub

    Private Sub txtInteresMensual_Leave(sender As Object, e As EventArgs) Handles txtInteresMensual.Leave
        txtTasaAnual.Text = CDbl(txtInteresMensual.Text) * 12
    End Sub

    Private Sub txtInteresMensual_TextChanged(sender As Object, e As EventArgs) Handles txtInteresMensual.TextChanged

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If txtBuscaPrestamo.Text = "" Then
            MessageBox.Show("Escriba el número de un préstamo primero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ConsultaReporte.ImprimirPrestamo(txtBuscaPrestamo.Text)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class
