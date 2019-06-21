Imports System.Data.SqlClient
Public Class DLibros
    Inherits DConexion


    Public Function MostrarLibros() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarLibros", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablalibros As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablalibros)
                Return tablalibros
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
    Public Function VerificarLibro(ByVal Llibro As LLibros) As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("VerificarLibro", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablalector As New DataTable

            With cmd.Parameters
                .AddWithValue("@codlibro", Llibro._CodLibro)

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
    Public Function VerificarCantidadLibro(ByVal Llibro As LLibros) As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("VerificarCantidadLibro", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablalector As New DataTable

            With cmd.Parameters
                .AddWithValue("@codlibro", Llibro._CodLibro)

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
    Public Function MostrarStockLibros() As DataTable
        Try
            Conectar()
            Dim cmd As New SqlCommand("MostrarLibrosStock", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim tablalibros As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptar As New SqlDataAdapter(cmd)
                adaptar.Fill(tablalibros)
                Return tablalibros
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

    Public Function Agregarlibro(ByVal llibro As LLibros) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("AgregarLibro", con)
            cmd.CommandType = CommandType.StoredProcedure


            With cmd.Parameters
                .AddWithValue("@titulo", llibro._Titulo)
                .AddWithValue("@codautor", llibro._CodAutor)
                .AddWithValue("@codgenero", llibro._CodGenero)
                .AddWithValue("@codeditorial", llibro._CodEditorial)
                .AddWithValue("@ubicacion", llibro._Ubicacion)
                .AddWithValue("@cantidad", llibro._Cantidad)
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

    Public Function ModificarLibro(ByVal llibro As LLibros) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("ModificarLibro", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codlibro", llibro._CodLibro)
                .AddWithValue("@titulo", llibro._Titulo)
                .AddWithValue("@codautor", llibro._CodAutor)
                .AddWithValue("@codgenero", llibro._CodGenero)
                .AddWithValue("@codeditorial", llibro._CodEditorial)
                .AddWithValue("@ubicacion", llibro._Ubicacion)
                .AddWithValue("@cantidad", llibro._Cantidad)
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


    Public Function EliminarLibro(ByVal llibro As LLibros) As Boolean

        Try
            Conectar()
            Dim cmd As New SqlCommand("EliminarLibro", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@codlibro", llibro._CodLibro)
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
