Public Class FGenero
    Dim FuncGenero As New DGenero
    Dim DatGenero As New LGenero
    Private Sub FGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarListaGenero()
    End Sub
  


    Public Sub CargarListaGenero()
        Dim CantRegistros As Integer
        Try
            dgvGenero.DataSource = FuncGenero.MostrarGenero

            CantRegistros = dgvGenero.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvGenero.ClearSelection()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim valordecajas As Boolean
            valordecajas = True

            For Each Caja As Control In GroupBox2.Controls
                If TypeOf (Caja) Is TextBox Then
                    If Trim(Caja.Text) = "" Then
                        valordecajas = False
                        Exit For
                    End If
                End If
            Next

            If valordecajas Then
                Call AgregarGenero()
                Call CargarListaGenero()
                txtNGenero.Clear()
            Else
                MsgBox("Ingrese un Género Literario", MsgBoxStyle.Information, "Mensaje del Sistema")
                txtNGenero.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub AgregarGenero()
        Try
            DatGenero._Genero = txtNGenero.Text


            If FuncGenero.AgregarGenero(DatGenero) Then
                MsgBox("El Registro fue Agregado", MsgBoxStyle.Information, "Mensaje del Sistema")
            Else
                MsgBox("El Registro no fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim valordecajas As Boolean
            valordecajas = True

            For Each Caja As Control In GroupBox3.Controls
                If TypeOf (Caja) Is TextBox Then
                    If Trim(Caja.Text) = "" Then
                        valordecajas = False
                        Exit For
                    End If
                End If
            Next

            If valordecajas Then
                Call ModificarGenero()
                Call CargarListaGenero()
                txtMCodigo.Clear()
                txtMGenero.Clear()

            Else
                MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
                If Trim(txtMCodigo.Text) = "" Then
                    txtMCodigo.Focus()
                Else
                    txtMGenero.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ModificarGenero()
        Try
            DatGenero._CodGenero = txtMCodigo.Text
            DatGenero._Genero = txtMGenero.Text



            If FuncGenero.ModificarGenero(DatGenero) Then
                MsgBox("El Registro fue Modificado", MsgBoxStyle.Information, "Mensaje del Sistema")
            Else
                MsgBox("El Registro no fue Modificado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim valordecajas As Boolean
            valordecajas = True

            For Each Caja As Control In GroupBox4.Controls
                If TypeOf (Caja) Is TextBox Then
                    If Trim(Caja.Text) = "" Then
                        valordecajas = False
                        Exit For
                    End If
                End If
            Next

            If valordecajas Then
                Call EliminarGenero()
                Call CargarListaGenero()
                txtECodigo.Clear()
            Else
                MsgBox("Ingrese un Codigo", MsgBoxStyle.Information, "Mensaje del Sistema")
                txtECodigo.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub EliminarGenero()
        Try
            DatGenero._CodGenero = txtECodigo.Text

            If MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                If FuncGenero.EliminarGenero(DatGenero) Then
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


    Private Sub dgvGenero_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGenero.CellClick
        txtMCodigo.Text = dgvGenero.SelectedCells.Item(0).Value
        txtMGenero.Text = dgvGenero.SelectedCells.Item(1).Value

        txtECodigo.Text = dgvGenero.SelectedCells.Item(0).Value
    End Sub
End Class