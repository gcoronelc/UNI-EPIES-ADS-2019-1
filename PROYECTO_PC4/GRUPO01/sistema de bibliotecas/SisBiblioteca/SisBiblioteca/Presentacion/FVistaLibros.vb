Public Class FVistaLibros
    Dim FuncLibro As New DLibros
    Dim Busqueda As New DataView
    Private Sub FVistaLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarListaLibro()
    End Sub

    Public Sub CargarListaLibro()
        Dim CantRegistros As Integer
        Try

            Busqueda = FuncLibro.MostrarLibros.DefaultView

            dgvLibro.DataSource = FuncLibro.MostrarLibros
            dgvLibro.DataSource = Busqueda

            dgvLibro.Columns(0).Visible = False
            dgvLibro.Columns(2).Visible = False
            dgvLibro.Columns(4).Visible = False
            dgvLibro.Columns(6).Visible = False

            CantRegistros = dgvLibro.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvLibro.ClearSelection()
            cboBusqueda.SelectedIndex = 0
            dgvLibro.Columns(8).Width = 60
            dgvLibro.Columns(9).Width = 50
        End Try
    End Sub

    Private Sub dgvLibro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibro.CellDoubleClick
        Try
            Dim libro As String
            Dim codigo As String
            libro = Me.dgvLibro.SelectedCells.Item(1).Value
            codigo = Me.dgvLibro.SelectedCells.Item(0).Value

            FNPrestamo.txtLibro.Text = libro
            FNPrestamo.txtCodLibro.Text = codigo
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try

            Busqueda.RowFilter = cboBusqueda.Text & " like '" & txtBusqueda.Text & "%'"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class