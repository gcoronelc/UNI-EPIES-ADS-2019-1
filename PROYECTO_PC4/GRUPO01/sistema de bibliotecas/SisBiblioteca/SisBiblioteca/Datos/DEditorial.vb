Imports System.Data.SqlClient
Public Class DEditorial
    Inherits DConexion
    Public Function MostraEditorial() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarEditorial", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablaeditorial As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablaeditorial)
                Return tablaeditorial
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


    Public Function AgregarEditorial(ByVal leditorial As LEditorial) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("AgregarEditorial", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@editorial", leditorial._Editorial)
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

    Public Function ModificarEditorial(ByVal leditorial As LEditorial) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ModificarEditorial", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codeditorial", leditorial._CodEditorial)
                .AddWithValue("@editorial", leditorial._Editorial)

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


    Public Function EliminarEditorial(ByVal leditorial As LEditorial) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("EliminarEditorial", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codeditorial", leditorial._CodEditorial)
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
