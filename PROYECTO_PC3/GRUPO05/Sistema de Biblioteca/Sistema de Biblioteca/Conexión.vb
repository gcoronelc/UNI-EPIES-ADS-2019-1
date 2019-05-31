Imports System.Data.Sql
Imports System.Data.SqlClient
Module Conexion

    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=MS02-31\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Usuarios where Usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
        End Try
        Return resultado
    End Function

    Function contraseña(ByVal contras As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select * from Usuarios where Contraseña='" & contras & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contrasena")
            End If
            respuesta.Close()
        Catch ex As Exception
        End Try
        Return resultado
    End Function

End Module
