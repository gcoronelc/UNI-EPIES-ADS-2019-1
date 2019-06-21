Public Class Form8
    Dim ID As Integer = 7

    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PedidosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DISEÑO_VARILLASadsDataSet)


    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DISEÑO_VARILLASadsDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.DISEÑO_VARILLASadsDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'DISEÑO_VARILLASadsDataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.DISEÑO_VARILLASadsDataSet.pedidos)

    End Sub

    Private Sub VentaTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click



        IdpedidoTextBox.Text = ID
        ID = ID + 1


    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ID = Val(ID) + 1
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

    Private Sub IdpedidoTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdpedidoTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        PedidosDataGridView.Rows.Clear()
    End Sub
End Class