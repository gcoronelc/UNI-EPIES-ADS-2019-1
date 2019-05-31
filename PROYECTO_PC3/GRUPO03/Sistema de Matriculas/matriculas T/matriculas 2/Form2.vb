Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Math

Public Class Form2
    Dim conexion As OleDbConnection
    Dim adaptador As OleDbDataAdapter
    Dim DsBase As DataSet
    Dim comando As OleDbCommand
    Dim consulta As String

    Dim Llenado As String




    Sub Mostrar(c As String)

        DsBase = New DataSet
        adaptador = New OleDbDataAdapter(c, conexion) 'comando sql , y conexion a base de datos'
        adaptador.Fill(DsBase)
        DGVAlmMat.DataSource = DsBase.Tables(0)

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sist_Matricula.accdb")
        
        Try
            conexion.Open()
            'MsgBox("Conexion Existosa", vbInformation)
        Catch ex As Exception
            MsgBox("No hay conexión", vbCritical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        consulta = "SELECT * FROM Llenado where Cod_Alm = My.Forms.Form2.FA.Text"
        Mostrar(consulta)

    End Sub
End Class