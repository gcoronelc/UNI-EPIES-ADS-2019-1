Public Class ReportePrestamo
    Public Busqueda As String
    Private Sub ReportePrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbbibliotecaDataSet1.ReportePrestamos' Puede moverla o quitarla según sea necesario.
        Me.ReportePrestamosTableAdapter.Fill(Me.dbbibliotecaDataSet1.ReportePrestamos, Busqueda)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class