Public Class FNBibliotecario
    Dim FuncBibliotecario As New DBibliotecario
    Dim DatBibliotecario As New LBibliotecario
    Private Sub FNBibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                Call AgregarBibliotecario()
            Else
                MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
     

    End Sub

    Public Sub GenerarCarnet()
        Try
            Dim tablacarnet As DataTable
            tablacarnet = FuncBibliotecario.GenerarCarnet

            Dim carnet As String
            carnet = tablacarnet.Rows(0).Item(0).ToString

            txtnrocarnet.Text = carnet

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub AgregarBibliotecario()
        Try
            DatBibliotecario._Nombres = txtnombre.Text
            DatBibliotecario._Apellidos = txtapellido.Text
            DatBibliotecario._Direccion = txtdireccion.Text
            DatBibliotecario._Email = txtemail.Text
            DatBibliotecario._Telefono = txttelefono.Text
            DatBibliotecario._Dni = txtdni.Text
            DatBibliotecario._Nro_Carnet = txtnrocarnet.Text
            DatBibliotecario._Contrasena = txtclave.Text

            If FuncBibliotecario.AgregarBibliotecario(DatBibliotecario) Then
                Me.Close()
            Else
                MsgBox("El Registro no fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Call GenerarCarnet()
    End Sub
End Class