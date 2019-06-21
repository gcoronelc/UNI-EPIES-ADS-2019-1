Public Class Form1

    Dim lbibliotecario1 As New LBibliotecario
    Dim dbibliotecario1 As New DBibliotecario
    Dim user, clave As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funciones As New DBibliotecario
    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try

            If txtclave.Text = "" Then
                MsgBox("Complete los datos porfavor", MsgBoxStyle.Information, "Mensaje del Sistema")
                Return
            End If

            lbibliotecario1._Nro_Carnet = Convert.ToString(txtuser.Text)
            lbibliotecario1._Contrasena = Convert.ToString(txtclave.Text)

            If dbibliotecario1.AccederBibliotcario(lbibliotecario1) Then
                Me.Hide()
                MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje del Sistema")
                FPrincipal.Show()
            Else
                MsgBox("Carnet o contraseña incorrecta", MsgBoxStyle.Critical, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class
