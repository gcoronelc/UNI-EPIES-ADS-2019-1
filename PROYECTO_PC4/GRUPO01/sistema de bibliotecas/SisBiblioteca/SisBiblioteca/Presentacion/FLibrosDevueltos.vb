Public Class FLibrosDevueltos
    Dim FuncPrestamo As New DPrestamo
    Dim DatPrestamo As New LPrestamo
    Dim Busqueda As DataView
    Private Sub FLibrosDevueltos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaPrestamo()
        cboBusqueda.SelectedIndex = 0
        txtBusqueda.Text = ""
    End Sub



    Public Sub CargarListaPrestamo()
        Dim CantRegistros As Integer
        Try
            Busqueda = FuncPrestamo.MostrarPrestamoCancelado.DefaultView
            dgvPrestamo.DataSource = FuncPrestamo.MostrarPrestamoCancelado
            dgvPrestamo.DataSource = Busqueda

            dgvPrestamo.Columns(6).Visible = False
            CantRegistros = dgvPrestamo.RowCount
            lblRegistros.Text = Convert.ToString(CantRegistros)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvPrestamo.ClearSelection()
            dgvPrestamo.Columns(0).Width = 50
            dgvPrestamo.Columns(3).Width = 80
            dgvPrestamo.Columns(4).Width = 90
            dgvPrestamo.Columns(5).Width = 80
        End Try
    End Sub


    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try

            Busqueda.RowFilter = cboBusqueda.Text & " like '%" & txtBusqueda.Text & "%'"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 
End Class