Public Class FNPrestamo
    Dim FuncLibro As New DLibros
    Dim DatLibro As New LLibros


    Dim FuncLector As New DLector
    Dim DatLector As New LLector

    Dim FuncPrestamo As New DPrestamo
    Dim DatPrestamo As New LPrestamo

    Private Sub FNPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargarstocklibros()

        dtpFecDevolucion.MinDate = Now.Date

    End Sub

    Private Sub btnlector_Click(sender As Object, e As EventArgs) Handles btnlector.Click
        Dim FormVista As New FVistaLectores
        FormVista.ShowDialog()
    End Sub

    Private Sub btnLibro_Click(sender As Object, e As EventArgs) Handles btnLibro.Click
        Dim FormVista As New FVistaLibros
        FormVista.ShowDialog()
    End Sub
    Public Sub Cargarstocklibros()
        Try
            dgvLibro.DataSource = FuncLibro.MostrarStockLibros

          
            dgvLibro.Columns(0).Width = 50
            dgvLibro.Columns(3).Width = 70
            dgvLibro.ClearSelection()



        Catch ex As Exception
            MsgBox("este es el mensaje")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click


        Try
            If Trim(txtCodLector.Text) = "" Or Trim(txtCodLibro.Text) = "" Then
                MsgBox("Faltan Completar Datos", MsgBoxStyle.Information, "Mensaje del Sistema")
                Exit Sub
            End If

            If VerificarLibro() Then
                MsgBox("No hay más libros Disponibles.", MsgBoxStyle.Critical, "Mensaje del Sistema")
                Exit Sub
            End If

            If VerificarLector() Then
                If MsgBox("El Lector tiene libros pendientes fuera de fecha." + vbCrLf + "¿Desea registrar el prestamo de todas maneras?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                    Call RegistrarPrestamo()
                    Call Cargarstocklibros()
                    Exit Sub
                Else
                    Exit Sub
                End If

            Else
                Call RegistrarPrestamo()
                Call Cargarstocklibros()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LimpiarDatos()
        txtLector.Text = ""
        txtCodLector.Text = ""
        txtLibro.Text = ""
        txtCodLibro.Text = ""
        dgvLibro.ClearSelection()
    End Sub
    Public Sub RegistrarPrestamo()
        Try
            DatPrestamo._CodLector = Convert.ToInt32(txtCodLector.Text)
            DatPrestamo._CodLibro = Convert.ToInt32(txtCodLibro.Text)
            DatPrestamo._FecDevolucion = dtpFecDevolucion.Value.Date



            If FuncPrestamo.AgregarPrestamo(DatPrestamo) Then
                MsgBox("Registro Fue Agregado", MsgBoxStyle.Information, "Mensaje del Sistema")
                Call LimpiarDatos()
            Else
                MsgBox("Registro No Fue Agregado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function VerificarLector() As Boolean
        Try
            Dim resultado As DataTable
            DatLector._CodLector = Convert.ToInt32(txtCodLector.Text)

            resultado = FuncLector.VerificarLector(DatLector)

            If resultado.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function VerificarLibro() As Boolean
        Try
            Dim resultado As DataTable
            DatLibro._CodLibro = Convert.ToInt32(txtCodLibro.Text)

            resultado = FuncLibro.VerificarLibro(DatLibro)

            Dim cantidad = Convert.ToInt32(resultado.Rows(0).Item(0))


            If cantidad > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
            Return True
        End Try
    End Function
 

    Private Sub btnDeudaAutor_Click(sender As Object, e As EventArgs)
        Try
            Dim Formulario As New FDeudaAutor
            Formulario.txtbusqueda.Text = Me.txtCodLector.Text
            Formulario.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub btndeuda_Click(sender As Object, e As EventArgs) Handles btndeuda.Click
        Try
            Dim Formulario As New FDeudaAutor
            Formulario.txtbusqueda.Text = Me.txtCodLector.Text
            Formulario.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class