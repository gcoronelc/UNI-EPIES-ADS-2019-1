Public Class FLector

    Dim FuncLector As New DLector
    Dim DatLector As New LLector

    Private Sub FLector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaLector()
    End Sub
    Public Sub CargarListaLector()
        Dim CantRegistros As Integer
        Try
            dgvLector.DataSource = FuncLector.MostrarLector
            dgvLector.Columns(0).Visible = False
            CantRegistros = dgvLector.RowCount
            lblRegistros.Text = Convert.ToString(CantRegistros)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvLector.ClearSelection()
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim FormAgregar As New FNLector
        FormAgregar.ShowDialog()
        CargarListaLector()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvLector.SelectedRows.Count > 0 Then
                ModificarLector()
                CargarListaLector()
            Else
                MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ModificarLector()
        Try
            Dim FormModificar As New FMLector
            FormModificar.CodLector = dgvLector.SelectedCells.Item(0).Value
            FormModificar.txtnombre.Text = dgvLector.SelectedCells.Item(1).Value
            FormModificar.txtapellido.Text = dgvLector.SelectedCells.Item(2).Value
            FormModificar.txtdireccion.Text = dgvLector.SelectedCells.Item(3).Value
            FormModificar.txtemail.Text = dgvLector.SelectedCells.Item(4).Value
            FormModificar.txttelefono.Text = dgvLector.SelectedCells.Item(5).Value
            FormModificar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvLector.SelectedRows.Count > 0 Then
                EliminarLector()
                CargarListaLector()
            Else
                MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub EliminarLector()
        Try
            DatLector._CodLector = dgvLector.SelectedCells.Item(0).Value

            If MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                If FuncLector.EliminarLector(DatLector) Then
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

End Class