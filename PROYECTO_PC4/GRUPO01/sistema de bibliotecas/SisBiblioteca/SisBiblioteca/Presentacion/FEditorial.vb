Public Class FEditorial
    Dim FuncEditorial As New DEditorial
    Dim DatEditorial As New LEditorial
    Private Sub FEditorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarListaEditorial()
    End Sub
   
 
    Public Sub CargarListaEditorial()
        Dim CantRegistros As Integer
        Try
            dgvEditorial.DataSource = FuncEditorial.MostraEditorial

            CantRegistros = dgvEditorial.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvEditorial.ClearSelection()
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
                Call AgregarEditorial()
                Call CargarListaEditorial()
                txtNEditorial.Clear()
            Else
                MsgBox("Ingrese una Editorial", MsgBoxStyle.Information, "Mensaje del Sistema")
                txtNEditorial.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub AgregarEditorial()
        Try
            DatEditorial._Editorial = txtNEditorial.Text


            If FuncEditorial.AgregarEditorial(DatEditorial) Then
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
                Call ModificarEditorial()
                Call CargarListaEditorial()
                txtMCodigo.Clear()
                txtMEditorial.Clear()

            Else
                MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
                If Trim(txtMCodigo.Text) = "" Then
                    txtMCodigo.Focus()
                Else
                    txtMEditorial.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ModificarEditorial()
        Try
            DatEditorial._CodEditorial = txtMCodigo.Text
            DatEditorial._Editorial = txtMEditorial.Text



            If FuncEditorial.ModificarEditorial(DatEditorial) Then
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
                Call EliminarEditorial()
                Call CargarListaEditorial()
                txtECodigo.Clear()
            Else
                MsgBox("Ingrese un Codigo", MsgBoxStyle.Information, "Mensaje del Sistema")
                txtECodigo.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub EliminarEditorial()
        Try
            DatEditorial._CodEditorial = txtECodigo.Text

            If MsgBox("¿Desea Eliminar este Registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                If FuncEditorial.EliminarEditorial(DatEditorial) Then
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

    Private Sub dgvEditorial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEditorial.CellClick
        txtMCodigo.Text = dgvEditorial.SelectedCells.Item(0).Value
        txtMEditorial.Text = dgvEditorial.SelectedCells.Item(1).Value

        txtECodigo.Text = dgvEditorial.SelectedCells.Item(0).Value
    End Sub
End Class