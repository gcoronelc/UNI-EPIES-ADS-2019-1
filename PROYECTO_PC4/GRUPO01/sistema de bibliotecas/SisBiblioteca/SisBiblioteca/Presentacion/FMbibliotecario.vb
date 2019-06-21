Public Class FMbibliotecario
    Dim FuncBibliotecario As New DBibliotecario
    Dim DatBibliotecario As New LBibliotecario
    Public CodBibliotecario As Integer
    Private Sub FMbibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                Call ModificarBibliotecario()
            Else
                MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ModificarBibliotecario()
        Try
            DatBibliotecario._CodBibliotecario = CodBibliotecario
            DatBibliotecario._Nombres = txtnombre.Text
            DatBibliotecario._Apellidos = txtapellido.Text
            DatBibliotecario._Direccion = txtdireccion.Text
            DatBibliotecario._Email = txtemail.Text
            DatBibliotecario._Telefono = txttelefono.Text
            DatBibliotecario._Dni = txtdni.Text

            If FuncBibliotecario.ModificarBibliotecario(DatBibliotecario) Then
                Me.Close()
            Else
                MsgBox("El Registro no fue Modificado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class