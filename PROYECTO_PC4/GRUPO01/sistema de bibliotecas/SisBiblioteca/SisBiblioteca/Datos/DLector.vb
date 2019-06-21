Imports System.Data.SqlClient
Public Class DLector
    Inherits DConexion


    Public Function MostrarLector() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarLectores", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablalector As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablalector)
                Return tablalector
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
    Public Function VerificarLector(ByVal LLector As LLector) As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("VerificarLector", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablalector As New DataTable

            With cmd.Parameters
                .AddWithValue("@codlector", LLector._CodLector)

            End With

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablalector)
                Return tablalector
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


    Public Function AgregarLector(ByVal llector As LLector) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("AgregarLector", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@nombres", llector._Nombres)
                .AddWithValue("@apellidos", llector._Apellidos)
                .AddWithValue("@direccion", llector._Direccion)
                .AddWithValue("@email", llector._Email)
                .AddWithValue("@telefono", llector._Telefono)
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

    Public Function ModificarLector(ByVal llector As LLector) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ModificarLector", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codlector", llector._CodLector)
                .AddWithValue("@nombres", llector._Nombres)
                .AddWithValue("@apellidos", llector._Apellidos)
                .AddWithValue("@direccion", llector._Direccion)
                .AddWithValue("@email", llector._Email)
                .AddWithValue("@telefono", llector._Telefono)
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


    Public Function EliminarLector(ByVal llector As LLector) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("EliminarLector", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codlector", llector._CodLector)
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
