Public Class FLibros
    Dim FuncLibro As New DLibros
    Dim DatLibros As New LLibros
    Dim Busqueda As New DataView


    Private Sub FLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaLibro()
    End Sub
    Private Sub btnAutor_Click(sender As Object, e As EventArgs) Handles btnAutor.Click
        Dim FormAutores As New FAutor
        FormAutores.ShowDialog()
    End Sub

    Private Sub btnGenero_Click(sender As Object, e As EventArgs) Handles btnGenero.Click
        Dim FormGenero As New FGenero
        FormGenero.ShowDialog()
    End Sub

    Private Sub btnEditorial_Click(sender As Object, e As EventArgs) Handles btnEditorial.Click
        Dim FormEditorial As New FEditorial
        FormEditorial.ShowDialog()
    End Sub

    Public Sub CargarListaLibro()
        Dim CantRegistros As Integer
        Try

            Busqueda = FuncLibro.MostrarLibros.DefaultView

            dgvLibro.DataSource = FuncLibro.MostrarLibros
            dgvLibro.DataSource = Busqueda

            dgvLibro.Columns(0).Visible = False
            dgvLibro.Columns(2).Visible = False
            dgvLibro.Columns(4).Visible = False
            dgvLibro.Columns(6).Visible = False

            CantRegistros = dgvLibro.RowCount
            lblRegistros.Text = Convert.ToString(CantRegistros)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvLibro.ClearSelection()
            cboBusqueda.SelectedIndex = 0
            dgvLibro.Columns(8).Width = 60
            dgvLibro.Columns(9).Width = 50
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim FormAgregar As New FNLibros
        FormAgregar.ShowDialog()
        CargarListaLibro()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvLibro.SelectedRows.Count > 0 Then
                ModificarLibro()
                CargarListaLibro()
            Else
                MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ModificarLibro()
        Try
            Dim FormModificar As New FMLibros
            FormModificar.CodLibro = dgvLibro.SelectedCells.Item(0).Value
            FormModificar.txtTitulo.Text = dgvLibro.SelectedCells.Item(1).Value
            FormModificar.CodAutor = dgvLibro.SelectedCells.Item(2).Value
            FormModificar.CodGenero = dgvLibro.SelectedCells.Item(4).Value
            FormModificar.CodEditorial = dgvLibro.SelectedCells.Item(6).Value

            FormModificar.txtUbicacion.Text = dgvLibro.SelectedCells.Item(8).Value
            FormModificar.txtCantidad.Text = dgvLibro.SelectedCells.Item(9).Value

            FormModificar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvLibro.SelectedRows.Count > 0 Then
                EliminarLibro()
                CargarListaLibro()
            Else
                MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
 
    Public Sub EliminarLibro()
        Try
            DatLibros._CodLibro = dgvLibro.SelectedCells.Item(0).Value

            If MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                If FuncLibro.EliminarLibro(DatLibros) Then
                    MsgBox("Registro eliminado Correctamente", MsgBoxStyle.Information, "Mensaje del Sistema")
                Else
                    MsgBox("No se pudo eliminar el Registro", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                End If
            Else
                Return
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try

            Busqueda.RowFilter = cboBusqueda.Text & " like '" & txtBusqueda.Text & "%'"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            ReporteLibros.Busqueda = Convert.ToString(txtBusqueda.Text)
            ReporteLibros.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        
    End Sub
End Class