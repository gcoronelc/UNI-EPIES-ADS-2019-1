Public Class FPrincipal

    Private Sub FPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PanelContenido(FInicio)

    End Sub

   
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If MsgBox("¿Desea Salir del Sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Return
        End If

    End Sub


    Public Sub PanelContenido(ByVal Formulario As Form)

        Panel1.Controls.Clear()
        Formulario.TopLevel = False
        Formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Formulario.Dock = DockStyle.Fill
        Panel1.Controls.Add(Formulario)

        Formulario.Show()

        'For Each cajatexto In Formulario.Controls
        '    If TypeOf (cajatexto) Is TextBox Then
        '        cajatexto.Clear()
        '    End If
        'Next
     


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Call PanelContenido(FBibliotecario)
        FBibliotecario.CargarListaBibliotecario()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

        Call PanelContenido(FLector)
        FLector.CargarListaLector()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Call PanelContenido(FLibros)
        FLibros.CargarListaLibro()
        FLibros.txtBusqueda.Clear()
    End Sub

    Private Sub NuevoPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPrestamoToolStripMenuItem.Click

        Call PanelContenido(FNPrestamo)
        FNPrestamo.Cargarstocklibros()
        FNPrestamo.txtLector.Clear()
        FNPrestamo.txtLibro.Clear()
        FNPrestamo.txtCodLector.Clear()
        FNPrestamo.txtCodLibro.Clear()
    End Sub

    Private Sub LibrosPrestadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPrestadosToolStripMenuItem.Click
        Call PanelContenido(FLibrosPrestados)
        FLibrosPrestados.CargarListaPrestamo()
        FLibrosPrestados.txtBusqueda.Clear()
    End Sub

    Private Sub LibrosDevueltosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDevueltosToolStripMenuItem.Click
        Call PanelContenido(FLibrosDevueltos)
        FLibrosDevueltos.CargarListaPrestamo()
        FLibrosDevueltos.txtBusqueda.Clear()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call PanelContenido(FInicio)
    End Sub
End Class