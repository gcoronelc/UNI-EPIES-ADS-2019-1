Public Class Form1

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If usuarioRegistrado(TextBox1.Text) = True Then
                Dim contra As String = contraseña(TextBox1.Text)
                If contra.Equals(TextBox2.Text) = True Then
                    Form2.Show()
                    Me.Hide()
                Else
                    MsgBox("Nombre o contraseña no validos", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Usuario no registrado")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
    End Sub
End Class
