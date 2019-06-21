Public Class FNLibros
    Dim FuncLibro As New DLibros
    Dim DatLibro As New LLibros


    Dim FuncAutor As New DAutor
    Dim FuncGenero As New DGenero
    Dim FuncEditorial As New DEditorial
    Private Sub FNLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarAutor()
        Call CargarGenero()
        Call CargarEditorial()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try
            Dim valordecajas As Boolean
            valordecajas = True

            For Each Caja As Control In Me.Controls
                If TypeOf (Caja) Is TextBox Then
                    If Trim(Caja.Text) = "" Then
                        valordecajas = False
                        Exit For
                    End If
                End If
            Next

            If valordecajas Then
                Call AgregarLibro()
            Else
                MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub AgregarLibro()
        Try
            DatLibro._Titulo = txtTitulo.Text
            DatLibro._CodAutor = Convert.ToInt32(cboAutor.SelectedValue.ToString)
            DatLibro._CodGenero = Convert.ToInt32(cboGenero.SelectedValue.ToString)
            DatLibro._CodEditorial = Convert.ToInt32(cboEditorial.SelectedValue.ToString)
            DatLibro._Ubicacion = txtUbicacion.Text
            DatLibro._Cantidad = txtCantidad.Text
        
            If FuncLibro.Agregarlibro(DatLibro) Then
                Me.Close()
            Else
                MsgBox("El Registro no fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CargarAutor()
        Try

            cboAutor.DataSource = FuncAutor.MostrarAutor

            cboAutor.DisplayMember = "Autor"
            cboAutor.ValueMember = "Codigo"

            'If idcargo <> 0 Then
            '    cbocargo.SelectedValue = idcargo
            'End If
            'idcargo = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CargarGenero()
        Try

            cboGenero.DataSource = FuncGenero.MostrarGenero

            cboGenero.DisplayMember = "Genero"
            cboGenero.ValueMember = "Codigo"

            'If idcargo <> 0 Then
            '    cbocargo.SelectedValue = idcargo
            'End If
            'idcargo = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CargarEditorial()
        Try

            cboEditorial.DataSource = FuncEditorial.MostraEditorial

            cboEditorial.DisplayMember = "Editorial"
            cboEditorial.ValueMember = "Codigo"

            'If idcargo <> 0 Then
            '    cbocargo.SelectedValue = idcargo
            'End If
            'idcargo = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class