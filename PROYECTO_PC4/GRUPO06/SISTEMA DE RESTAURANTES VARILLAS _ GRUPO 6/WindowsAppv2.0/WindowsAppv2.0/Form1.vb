Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim minus As String

        minus = LCase(TextBox1.Text)


        If (minus = "admin") And (TextBox2.Text = "ASD") Then
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("La contraseña o el usuario son incorrectos vuelva a escribir")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("¿Esta seguro que desea salir ? ", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'abajo se pone que se guarda el pedido y todo eso 
            End
        End If
    End Sub
End Class
