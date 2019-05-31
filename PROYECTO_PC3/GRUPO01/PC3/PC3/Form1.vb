Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If txtclave.Text = "" Then
                MsgBox("Complete los datos porfavor", MsgBoxStyle.Information, "Mensaje del Sistema")
                Return
            End If
            If txtuser.Text = "GCORONELC" And txtclave.Text = "UNI" Then
                Me.Hide()
                MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje del Sistema")
                FPrincipal.Show()
            Else
                MsgBox("Carnet o contraseña incorrecta", MsgBoxStyle.Critical, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea Salir del Sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub
End Class
