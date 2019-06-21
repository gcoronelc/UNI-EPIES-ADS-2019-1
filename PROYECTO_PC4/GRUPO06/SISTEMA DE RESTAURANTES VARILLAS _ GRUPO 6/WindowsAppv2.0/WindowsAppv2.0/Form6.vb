Public Class Form6
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DISEÑO_VARILLASadsDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DISEÑO_VARILLASadsDataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.DISEÑO_VARILLASadsDataSet.pedidos)

        Dim monto As Double = Convert.ToDouble(PedidosDataGridView.CurrentRow.Cells(3).Value)

        Label3.Text = monto

        'Label3.Text = Convert.ToDouble(PedidosDataGridView.SelectedRows(1).Cells("VENTA1").Value)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()

    End Sub
End Class