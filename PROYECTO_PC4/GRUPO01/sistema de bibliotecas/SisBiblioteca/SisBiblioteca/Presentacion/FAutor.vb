Public Class FAutor
    Dim FuncAutor As New DAutor
    Dim DatAutor As New LAutor
    Private Sub FAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarListaAutor()
    End Sub

    Public Sub CargarListaAutor()
        Dim CantRegistros As Integer
        Try
            dgvAutor.DataSource = FuncAutor.MostrarAutor

            CantRegistros = dgvAutor.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvAutor.ClearSelection()
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
                Call AgregarLector()
                Call CargarListaAutor()
                txtNAutor.Clear()
            Else
                MsgBox("Ingrese un Autor", MsgBoxStyle.Information, "Mensaje del Sistema")
                txtNAutor.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
   
    Public Sub AgregarLector()
        Try
            DatAutor._Autor = txtNAutor.Text


            If FuncAutor.AgregarAutor(DatAutor) Then
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
                Call ModificarLector()
                Call CargarListaAutor()
                txtMCodigo.Clear()
                txtMAutor.Clear()

            Else
                MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
                If Trim(txtMCodigo.Text) = "" Then
                    txtMCodigo.Focus()
                Else
                    txtMAutor.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ModificarLector()
        Try
            DatAutor._CodAutor = txtMCodigo.Text
            DatAutor._Autor = txtMAutor.Text



            If FuncAutor.ModificarAutor(DatAutor) Then
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
                Call EliminarAutor()
                Call CargarListaAutor()
                txtECodigo.Clear()
            Else
                MsgBox("Ingrese un Codigo", MsgBoxStyle.Information, "Mensaje del Sistema")
                txtECodigo.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub EliminarAutor()
        Try
            DatAutor._CodAutor = txtECodigo.Text

            If MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                If FuncAutor.EliminarAutor(DatAutor) Then
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

    Private Sub dgvAutor_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAutor.CellClick
        txtMCodigo.Text = dgvAutor.SelectedCells.Item(0).Value
        txtMAutor.Text = dgvAutor.SelectedCells.Item(1).Value

        txtECodigo.Text = dgvAutor.SelectedCells.Item(0).Value
    End Sub
End Class