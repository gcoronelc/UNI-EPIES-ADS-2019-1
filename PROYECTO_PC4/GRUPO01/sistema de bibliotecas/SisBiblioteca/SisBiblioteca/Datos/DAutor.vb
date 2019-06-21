Imports System.Data.SqlClient
Public Class DAutor
    Inherits DConexion
    Public Function MostrarAutor() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarAutor", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablaautor As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablaautor)
                Return tablaautor
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


    Public Function AgregarAutor(ByVal lautor As LAutor) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("AgregarAutor", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@autor", lautor._Autor)
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

    Public Function ModificarAutor(ByVal lautor As LAutor) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ModificarAutor", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codautor", lautor._CodAutor)
                .AddWithValue("@autor", lautor._Autor)

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


    Public Function EliminarAutor(ByVal lautor As LAutor) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("EliminarAutor", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codautor", lautor._CodAutor)
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
