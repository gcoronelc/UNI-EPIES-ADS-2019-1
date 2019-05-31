Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("El pedido a sido impreso Exitosamente")
        Me.Hide()
        Form3.Show()
    End Sub
End Class