Imports System.Data.OleDb

Module Conexiones
    Public MiConexion As OleDbConnection
    Public MiComando As OleDbCommand
    Public MiAdaptador As OleDbDataAdapter
    Public MiDataSet As DataSet

    Public FECHA_GENERAL As Date

    Public Sub AbrirConexion()
        MiConexion = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=prestamos.mdb")
        MiConexion.Open()
    End Sub

    Public Function Consultar(ByVal Cadena As String)
        Dim EstadoConsulta As Boolean = False

        AbrirConexion()

        MiComando = New OleDbCommand(Cadena, MiConexion)
        MiComando.Parameters.AddWithValue("@FECHA", OleDbType.Date).Value = FECHA_GENERAL
        MiAdaptador = New OleDbDataAdapter(MiComando)

        MiDataSet = New DataSet
        MiAdaptador.Fill(MiDataSet)

        If MiDataSet.Tables(0).Rows.Count > 0 Then
            EstadoConsulta = True
        End If

        Return EstadoConsulta

    End Function

    Public Sub Guardar(ByVal Cadena As String)
        If MiConexion.State = ConnectionState.Closed Then
            AbrirConexion()
        End If

        MiComando = New OleDbCommand(Cadena, MiConexion)
        MiComando.Parameters.AddWithValue("@FECHA", OleDbType.Date).Value = FECHA_GENERAL
        MiComando.ExecuteNonQuery()

    End Sub

End Module
