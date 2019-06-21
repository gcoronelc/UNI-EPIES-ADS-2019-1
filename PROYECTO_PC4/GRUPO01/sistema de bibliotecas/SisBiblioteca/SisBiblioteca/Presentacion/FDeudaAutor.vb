Public Class FDeudaAutor
    Dim FuncPrestamo As New DPrestamo
    Dim DatPrestamo As New LPrestamo


  

    Private Sub FDeudaAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaDeuda()
        mensaje()
    End Sub

    Public Sub CargarListaDeuda()

        Try
            If Trim(txtbusqueda.Text) = "" Then
                dgvLector.DataSource = Nothing
                Return
            End If

            DatPrestamo._CodLector = Convert.ToInt32(txtbusqueda.Text)
            dgvLector.DataSource = FuncPrestamo.MostrarPrestamoDeuda(DatPrestamo)
           
        Catch ex As Exception
            MsgBox(ex.Message)
  
        End Try

    End Sub


    Private Sub txtbusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbusqueda.KeyPress
        Try
            If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        Try
            CargarListaDeuda()
            mensaje()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mensaje()
        Try
            If dgvLector.RowCount > 0 Then
                lblmensaje.Visible = False
            Else
                lblmensaje.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class