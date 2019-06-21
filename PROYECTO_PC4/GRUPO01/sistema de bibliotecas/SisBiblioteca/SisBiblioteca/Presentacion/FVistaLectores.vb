Public Class FVistaLectores
    Dim FuncLector As New DLector
    Private Sub FVistaLectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaLector()
    End Sub

    Public Sub CargarListaLector()

        Try
            dgvLector.DataSource = FuncLector.MostrarLector
            dgvLector.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvLector.ClearSelection()
        End Try
    End Sub

    Private Sub dgvLector_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLector.CellDoubleClick
        Try
            Dim lector As String
            Dim codigo As String
            lector = Me.dgvLector.SelectedCells.Item(1).Value + " " + Me.dgvLector.SelectedCells.Item(2).Value
            codigo = Me.dgvLector.SelectedCells.Item(0).Value

            FNPrestamo.txtLector.Text = lector
            FNPrestamo.txtCodLector.Text = codigo
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class