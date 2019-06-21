Imports Microsoft.Reporting.WinForms
Public Class ReporteForm
    Public NombreReporte As String = "ReporteVB.NET.ReporteFecha.rdlc"
    Public FormaReporte As String = "Normal"

    Public Sub Populate()
        Dim dt As New DataTable

        Try
            MiAdaptador.Fill(dt)
            Dim rds As ReportDataSource = New ReportDataSource
            rds.Name = "dsDatos"
            rds.Value = dt

            ReportViewer1.Reset()
            ReportViewer1.LocalReport.ReportEmbeddedResource = NombreReporte
            ReportViewer1.LocalReport.EnableExternalImages = True
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)

            Dim newPageSettings As New System.Drawing.Printing.PageSettings
            newPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

            If FormaReporte = "Acostado" Then
                newPageSettings.Landscape = True
            End If
            ReportViewer1.SetPageSettings(newPageSettings)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            Console.WriteLine(Err.Description)
        End Try
    End Sub

    Private Sub ReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
End Class