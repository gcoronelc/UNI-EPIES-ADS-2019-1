Imports System.Data.SqlClient
Public Class DBibliotecario
    Inherits DConexion
    Public Function AccederBibliotcario(ByVal lbibliotecario As LBibliotecario) As Boolean
        Try
            Conectar()
            Dim cmd As New SqlCommand("AccederBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@user", lbibliotecario._Nro_Carnet)
                .AddWithValue("@clave", lbibliotecario._Contrasena)
            End With

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function
    Public Function GenerarCarnet() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("NroCarnetBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim tablagenerada As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablagenerada)
                Return tablagenerada
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function MostrarBibliotecarios() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarBibliotecarios", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablabibliotecarios As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablabibliotecarios)
                Return tablabibliotecarios
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)

        Finally
            Desconectar()
        End Try
    End Function


    Public Function AgregarBibliotecario(ByVal lbibliotecario As LBibliotecario) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("AgregarBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@nombres", lbibliotecario._Nombres)
                .AddWithValue("@apellidos", lbibliotecario._Apellidos)
                .AddWithValue("@direccion", lbibliotecario._Direccion)
                .AddWithValue("@email", lbibliotecario._Email)
                .AddWithValue("@telefono", lbibliotecario._Telefono)
                .AddWithValue("@dni", lbibliotecario._Dni)
                .AddWithValue("@nro_carnet", lbibliotecario._Nro_Carnet)
                .AddWithValue("@contrasena", lbibliotecario._Contrasena)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            Desconectar()
        End Try
    End Function

    Public Function ModificarBibliotecario(ByVal lbibliotecario As LBibliotecario) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ModificarBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codbibliotecario", lbibliotecario._CodBibliotecario)
                .AddWithValue("@nombres", lbibliotecario._Nombres)
                .AddWithValue("@apellidos", lbibliotecario._Apellidos)
                .AddWithValue("@direccion", lbibliotecario._Direccion)
                .AddWithValue("@email", lbibliotecario._Email)
                .AddWithValue("@telefono", lbibliotecario._Telefono)
                .AddWithValue("@dni", lbibliotecario._Dni)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            Desconectar()
        End Try
    End Function


    Public Function EliminarBibliotecario(ByVal lbibliotecario As LBibliotecario) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("EliminarBibliotecario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codbibliotecario", lbibliotecario._CodBibliotecario)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        Finally
            Desconectar()
        End Try
    End Function
End Class
