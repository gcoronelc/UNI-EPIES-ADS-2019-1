Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Math
Public Class Form1
    Dim conexion As OleDbConnection
    Dim adaptador As OleDbDataAdapter
    Dim DsBase As DataSet
    Dim comando As OleDbCommand
    Dim consulta As String
    Dim consulta2 As String
    Dim Llenado As String

    Public Sub New(user As String)
            
        MyBase.New()
        InitializeComponent()
        FA.Text = user
        frmlogin.Hide()
    End Sub



    Sub Mostrar(c As String)

        DsBase = New DataSet
        adaptador = New OleDbDataAdapter(c, conexion) 'comando sql , y conexion a base de datos'
        adaptador.Fill(DsBase)
        DGVcursos.DataSource = DsBase.Tables(0)

    End Sub
    Sub Mostrar2(c As String)

        DsBase = New DataSet
        adaptador = New OleDbDataAdapter(c, conexion) 'comando sql , y conexion a base de datos'
        adaptador.Fill(DsBase)

        DGVhorarios.DataSource = DsBase.Tables(0)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Sist_Matricula.accdb; Persist Security Info=False;")
        
        Try
            conexion.Open()
            'MsgBox("Conexion Existosa", vbInformation)
        Catch ex As Exception
            MsgBox("No hay conexión", vbCritical, "Error")
        End Try
    End Sub


    Private Sub BTactivar_Click(sender As Object, e As EventArgs) Handles BTactivar.Click
        If CBciclos.SelectedIndex = 0 Then
            consulta = "Select *FROM Horario"
            Mostrar2(consulta)
            consulta2 = "Select *FROM Curso"
            Mostrar(consulta2)
          
        End If
        If CBciclos.SelectedIndex = 1 Then
            consulta = "Select *FROM Curso"
            Mostrar(consulta)
         
        End If
    End Sub


    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim row As String() = New String() {FA.Text, FB.Text, FC.Text, FC.Text, FD.Text, FE.Text}

        'DataGridView.Rows.Add(row)


        'Dim a,b,c,,d,e As String
        'a = TextBox4.Text.
        'If DGVcursos.Rows() Then
        'Then

        'End If
        'b = "Select Cod_Curso FROM Curso"
        'c = "Select Sección FROM Curso"
        'd = "Select Nombre FROM Curso"
        'e = "Select  FROM Curso" '
        Llenado = "Insert into Llenado(Cod_Alm,Cod_Curso,Nombre,Sección,Horario)"
        Llenado +=
        "VALUES('" & FA.Text & "','" & FB.Text & "','" & FC.Text & "','" & FD.Text & "','" & FE.Text & "')"
    End Sub

    Private Sub DGVcursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVcursos.CellClick
        Dim K As Integer
        K = DGVcursos.CurrentRow.Index
        FB.Text = DGVcursos.Item(1, K).Value()
        FC.Text = DGVcursos.Item(3, K).Value()
        FD.Text = DGVcursos.Item(2, K).Value()
    End Sub

    Private Sub DGVhorarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVhorarios.CellClick
        Dim L As Integer
        L = DGVhorarios.CurrentRow.Index
        FE.Text = DGVhorarios.Item(1, L).Value() + " - " + DGVhorarios.Item(2, L).Value() + " - " + DGVhorarios.Item(3, L).Value() + " - " + DGVhorarios.Item(4, L).Value()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles FE.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        
        Me.Close()
        
    End Sub
End Class