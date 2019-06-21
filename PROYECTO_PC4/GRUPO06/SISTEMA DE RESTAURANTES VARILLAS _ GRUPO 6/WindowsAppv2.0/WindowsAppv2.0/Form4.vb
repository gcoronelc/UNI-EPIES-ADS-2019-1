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
    Private Sub PedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DISEÑO_VARILLASadsDataSet)

    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DISEÑO_VARILLASadsDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.DISEÑO_VARILLASadsDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'DISEÑO_VARILLASadsDataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.DISEÑO_VARILLASadsDataSet.pedidos)

        'TODO: esta línea de código carga datos en la tabla 'DISEÑO_VARILLASadsDataSet.pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.DISEÑO_VARILLASadsDataSet.pedidos)

    End Sub
    Dim u As Integer = 0

    Private Sub dgvproducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ' CostoTextBox.Text = dgvproducto.CurrentRow.Cells(5).Value

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CostoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        '  u = u + 1
        ' dgv_company.Rows.Add()
        ' dgv_company.Rows(dgv_company.RowCount - 1).Cells("dgvnombre").Value = NombreComboBox.Text
        '  dgv_company.Rows(dgv_company.RowCount - 1).Cells("dgventa").Value = VentaTextBox.Text
        '  dgv_company.Rows(dgv_company.RowCount - 1).Cells("dgvcat").Value = CategoriaComboBox.Text
        '  dgv_company.Rows(dgv_company.RowCount - 1).Cells("dgvfecha").Value = FechaDateTimePicker.Text
        '  dgv_company.Rows(dgv_company.RowCount - 1).Cells("dgvid").Value = u
        ' dgv_company.Rows(dgv_company.RowCount - 1).DefaultCellStyle.ForeColor = Color.Blue
        ''
    End Sub
End Class