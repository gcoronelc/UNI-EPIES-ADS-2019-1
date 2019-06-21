Imports System.Data.Sql
Imports System.Data.SqlClient
Module Conexion

    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=M02-23\SQLEXPRESS;Initial Catalog=SISTBIBLIOTECA;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from PRESTAMISTASB where Usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
        End Try
        Return resultado
    End Function

    Function contraseña(ByVal nombreUsuario As String) As String
        Dim resultado1 As String = ""
        Try
            enunciado = New SqlCommand("Select Contraseña from PRESTAMISTASB where Usuario='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado1 = respuesta.Item("Contraseña")
            End If
            respuesta.Close()
        Catch ex As Exception
        End Try
        Return resultado1
    End Function

    Function Insertar(ByVal NumDocUsuario As Integer, ByVal UsuarioNombre As String, ByVal FechaIngreso As Date, ByVal Direccion As Integer, ByVal Celular As Integer, ByVal Correo As String) As String
        Dim resultado1 As String = ""
        Try
            enunciado = New SqlCommand("insert into USUARIOSB(NumDocUsuario, UsuarioNombre, FechaIngreso, Direccion, Celular, Correo) values ('" & NumDocUsuario & "','" & UsuarioNombre & "''" & FechaIngreso & "''" & Direccion & "''" & Celular & "''" & Correo & "')", conexion)
            enunciado.ExecuteNonQuery()
            resultado1 = "Se ha guardado correctamente"
            conexion.Close()
        Catch ex As Exception
            resultado1 = "No se pudo guardar" + ex.ToString
            conexion.Close()
        End Try
        Return resultado1
    End Function
End Module
