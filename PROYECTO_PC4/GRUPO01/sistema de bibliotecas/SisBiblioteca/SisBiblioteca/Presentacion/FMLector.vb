Public Class FMLector

    Dim FuncLector As New DLector
    Dim DatLector As New LLector
    Public CodLector As Integer
    Private Sub FMLector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                Call ModificarLector()
            Else
                MsgBox("Complete Todos los Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ModificarLector()
        Try
            DatLector._CodLector = CodLector
            DatLector._Nombres = txtnombre.Text
            DatLector._Apellidos = txtapellido.Text
            DatLector._Direccion = txtdireccion.Text
            DatLector._Email = txtemail.Text
            DatLector._Telefono = txttelefono.Text


            If FuncLector.ModificarLector(DatLector) Then
                Me.Close()
            Else
                MsgBox("El Registro no fue Modificado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class