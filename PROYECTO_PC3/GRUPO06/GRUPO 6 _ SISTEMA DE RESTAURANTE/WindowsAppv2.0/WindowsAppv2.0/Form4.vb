Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Esta seguro que dea cancelar  el pedido ", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'abajo se pone que se guarda el pedido y todo eso 
            Me.Hide()
            Form3.Show()
        End If

    End Sub
End Class