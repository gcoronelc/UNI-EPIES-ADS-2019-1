Imports System.Data.SqlClient


Public Class FMLibros
    Dim dconexion As New DConexion

    Dim FuncLibro As New DLibros
    Dim DatLibro As New LLibros
    Dim FuncAutor As New DAutor
    Dim FuncGenero As New DGenero
    Dim FuncEditorial As New DEditorial

    Public CodLibro As Integer
    Public CodAutor As Integer
    Public CodGenero As Integer
    Public CodEditorial As Integer
    Private Sub FMLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarAutor()
        Call CargarGenero()
        Call CargarEditorial()
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
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
                Call ModificarLibro()
            Else
                MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub ModificarLibro()
        Try
            Dim CantidadPrestada As Integer
            Dim CantidadNueva As Integer
            Dim NuevoSotck As Integer
            DatLibro._CodLibro = CodLibro
            DatLibro._Titulo = txtTitulo.Text
            DatLibro._CodAutor = Convert.ToInt32(cboAutor.SelectedValue.ToString)
            DatLibro._CodGenero = Convert.ToInt32(cboGenero.SelectedValue.ToString)
            DatLibro._CodEditorial = Convert.ToInt32(cboEditorial.SelectedValue.ToString)
            DatLibro._Ubicacion = txtUbicacion.Text
            DatLibro._Cantidad = txtCantidad.Text

            CantidadPrestada = CantidadLibro()
            CantidadNueva = Convert.ToInt32(txtCantidad.Text)

            If CantidadNueva < CantidadPrestada Then
                MsgBox("Cambie la cantidad de libros." + vbCrLf + "El total de libros prestados excede a este", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                Exit Sub
            Else
                NuevoSotck = CantidadNueva - CantidadPrestada
                Call CambiarValorStock(NuevoSotck, CodLibro)
            End If


            If FuncLibro.ModificarLibro(DatLibro) Then
                Me.Close()
            Else
                MsgBox("El Registro no fue Modificado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function CantidadLibro() As Integer
        Try
            Dim resultado As DataTable
            DatLibro._CodLibro = CodLibro
            resultado = FuncLibro.VerificarCantidadLibro(DatLibro)

            Dim cantidad As Integer

            If resultado.Rows.Count > 0 Then
                cantidad = resultado.Rows.Count
                Return cantidad
            Else
                cantidad = 0
                Return cantidad
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Public Sub CambiarValorStock(ByVal NuevoStock As Integer, ByVal CodLibro As Integer)
        Try
            dconexion.Conectar()
            Dim sql As String
            sql = "UPDATE stocklibros SET Disponibles = '" + NuevoStock.ToString + "' WHERE CodLibro = '" + CodLibro.ToString + "'"
            'MsgBox(sql)
            Dim cmd As New SqlCommand(sql, dconexion.con)

            If cmd.ExecuteNonQuery Then
                'MsgBox("Cambio Modificado Correctamente")
            Else
                MsgBox("NO se pudo modificar los datos debido a la Cantidad puesta")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dconexion.Desconectar()
        End Try

    End Sub



    Public Sub CargarAutor()
        Try

            cboAutor.DataSource = FuncAutor.MostrarAutor

            cboAutor.DisplayMember = "Autor"
            cboAutor.ValueMember = "Codigo"

            If CodAutor <> 0 Then
                cboAutor.SelectedValue = CodAutor
            End If
            CodAutor = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CargarGenero()
        Try

            cboGenero.DataSource = FuncGenero.MostrarGenero

            cboGenero.DisplayMember = "Genero"
            cboGenero.ValueMember = "Codigo"

            If CodGenero <> 0 Then
                cboGenero.SelectedValue = CodGenero
            End If
            CodGenero = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CargarEditorial()
        Try

            cboEditorial.DataSource = FuncEditorial.MostraEditorial

            cboEditorial.DisplayMember = "Editorial"
            cboEditorial.ValueMember = "Codigo"

            If CodEditorial <> 0 Then
                cboEditorial.SelectedValue = CodEditorial
            End If
            CodEditorial = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class