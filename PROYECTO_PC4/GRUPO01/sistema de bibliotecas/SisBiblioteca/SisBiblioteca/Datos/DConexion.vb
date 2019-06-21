Imports System.Data.SqlClient
Imports System.Configuration
Public Class DConexion
    Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("cndbbiblioteca").ToString)

    Public Sub Conectar()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
