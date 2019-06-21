Imports System.Data.SqlClient
Public Class DPrestamo
    Inherits DConexion
    Public Function MostrarPrestamo() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarPrestamo", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablaprestamo As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablaprestamo)
                Return tablaprestamo
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
    Public Function MostrarPrestamoCancelado() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarPrestamoDevueltos", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablaprestamo As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablaprestamo)
                Return tablaprestamo
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
    Public Function MostrarPrestamoDeuda(ByVal lprestamo As LPrestamo) As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarPrestamoDeudaLecor", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tabladeuda As New DataTable


            With cmd.Parameters
                .AddWithValue("@codlector", lprestamo._CodLector)
            End With



            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tabladeuda)
                Return tabladeuda
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


    Public Function AgregarPrestamo(ByVal lprestamo As LPrestamo) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("AgregarPrestamo", con)
            cmd.CommandType = CommandType.StoredProcedure


            With cmd.Parameters
                .AddWithValue("@codlector", lprestamo._CodLector)
                .AddWithValue("@codlibro", lprestamo._CodLibro)
                .AddWithValue("@fec_devolucion", lprestamo._FecDevolucion)

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

    Public Function ModificarLibro(ByVal lprestamo As LPrestamo) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ModificarPrestamoRetorno", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codprestamo", lprestamo._CodPrestamo)
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
