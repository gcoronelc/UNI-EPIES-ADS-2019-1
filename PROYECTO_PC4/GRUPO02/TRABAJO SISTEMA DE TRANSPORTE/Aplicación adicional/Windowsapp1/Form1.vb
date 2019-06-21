Public Class Regtrip

    Private Sub Regtrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        String select = "SELECT idtransporte, reservas FROM tblTRANSPORTE";
     Connection c = New Connection();
     SqlDataAdapter dataAdapter = New SqlDataAdapter(select, c.con); //c.con Is the connection String
     SqlCommandBuilder commandBuilder = New SqlCommandBuilder(dataAdapter);

     DataTable table = New DataTable();
    End Sub     table.Locale = System.Globalization.CultureInfo.InvariantCulture
     dataAdapter.Fill(table)
     bindingSource.DataSource = table

     dgvtansporte.ReadOnly = true
     dgtransporte.DataSource = bindingSource

Private Sub Btnreservar_Click(sender As Object, e As EventArgs) Handles btnreservar.Click
        If dgvtransporte.SelectedCells Then
            dgvtransporte.Rows.[n].cell[1].value=dgvtransporte.Rows.[n].cell[1].value+1
                End If
    End Sub    }
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtdni.Text = "73736325" And txtcod.Text = "201901" Then
            lblcustomer.Text = "El cliente es: Juan Perez. No tiene antecedentes."
            TextBox7.Text = "No ha separado ninguna vacante."
        Else
            lblcustomer.Text = "Cliente no identificado"
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Char
        Dim b As Char
        Dim c As Char
        Dim d As Char
        Dim e As DateTime
        String select = "SELECT idtransporte, reservas FROM tblTRANSPORTE where inicio=a.."
     Connection c = New Connection()
     SqlDataAdapter dataAdapter = New SqlDataAdapter(select, c.con) // c.con Is the connection String
     SqlCommandBuilder commandBuilder = New SqlCommandBuilder(dataAdapter)

     DataTable table = New DataTable()
    End Sub     table.Locale = System.Globalization.CultureInfo.InvariantCulture
     dataAdapter.Fill(table)
     bindingSource.DataSource = table

     dgvtansporte.ReadOnly = true     
     dgtransporte.DataSource = bindingSource
    End Sub
End Class
