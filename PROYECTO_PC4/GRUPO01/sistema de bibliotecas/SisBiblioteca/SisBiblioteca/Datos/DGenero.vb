Imports System.Data.SqlClient
Public Class DGenero
    Inherits DConexion
    Public Function MostrarGenero() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarGenero", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablagenero As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablagenero)
                Return tablagenero
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


    Public Function AgregarGenero(ByVal lgenero As LGenero) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("AgregarGenero", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@genero", lgenero._Genero)
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

    Public Function ModificarGenero(ByVal lgenero As LGenero) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ModificarGenero", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codgenero", lgenero._CodGenero)
                .AddWithValue("@genero", lgenero._Genero)

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


    Public Function EliminarGenero(ByVal lgenero As LGenero) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("EliminarGenero", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codgenero", lgenero._CodGenero)
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
