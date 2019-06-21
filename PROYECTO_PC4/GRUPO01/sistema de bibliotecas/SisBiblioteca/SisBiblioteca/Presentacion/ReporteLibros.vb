Public Class ReporteLibros
    Public Busqueda As String
    Private Sub ReporteLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbbibliotecaDataSet.ReporteLibros' Puede moverla o quitarla según sea necesario.
        Me.ReporteLibrosTableAdapter.Fill(Me.dbbibliotecaDataSet.ReporteLibros, Busqueda)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class