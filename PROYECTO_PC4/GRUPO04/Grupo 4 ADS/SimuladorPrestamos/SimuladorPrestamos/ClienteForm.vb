Public Class ClienteForm

    Private Sub ClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaDatos()
    End Sub

    Public Sub LlenaDatos()
        If Consultar("select * from cliente where nombre like'%" & txtBuscar.Text & "%' or telefono like'%" & txtBuscar.Text & "%'") = True Then
            DataGridView1.DataSource = MiDataSet.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub


    Public Sub LimpiarCampos()
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtCedula.Text = ""
        lbID.Text = "0"
        txtNombre.Focus()
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lbID.Text = "0" Then
            If MessageBox.Show("¿Seguro que desea insertar este nuevo registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Guardar("insert into cliente(nombre,telefono,cedula) values('" & txtNombre.Text & "','" & txtTelefono.Text & "','" & txtCedula.Text & "')")
                LimpiarCampos()
                LlenaDatos()
            End If
        Else
            If MessageBox.Show("¿Seguro que desea modificar estos datos?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Guardar("update cliente set nombre='" & txtNombre.Text & "',telefono='" & txtTelefono.Text & "',cedula='" & txtCedula.Text & "' where id=" & lbID.Text)
                LimpiarCampos()
                LlenaDatos()
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Try
            If DataGridView1.RowCount > 0 Then
                lbID.Text = DataGridView1.CurrentRow.Cells("ID").Value
                txtNombre.Text = DataGridView1.CurrentRow.Cells("NOMBRE").Value.ToString
                txtCedula.Text = DataGridView1.CurrentRow.Cells("CEDULA").Value.ToString
                txtTelefono.Text = DataGridView1.CurrentRow.Cells("TELEFONO").Value.ToString
            Else
                lbID.Text = "0"
                txtNombre.Text = ""
                txtCedula.Text = ""
                txtTelefono.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        LlenaDatos()
    End Sub
End Class