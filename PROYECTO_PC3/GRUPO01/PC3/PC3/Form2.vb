Public Class FPrincipal

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

    End Sub

    Private Sub LibrosDevueltosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDevueltosToolStripMenuItem.Click
        Me.Hide()
        FReferencia.Show()

    End Sub

    Private Sub NuevoPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPrestamoToolStripMenuItem.Click
        Me.Hide()
        FAutor.Show()
    End Sub

    Private Sub LibrosPrestadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPrestadosToolStripMenuItem.Click
        Me.Hide()
        FTitulo.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        FAbstract.Show()

    End Sub
End Class