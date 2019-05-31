<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGVcursos = New System.Windows.Forms.DataGridView()
        Me.FA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FE = New System.Windows.Forms.TextBox()
        Me.FD = New System.Windows.Forms.TextBox()
        Me.FC = New System.Windows.Forms.TextBox()
        Me.BTactivar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBciclos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVhorarios = New System.Windows.Forms.DataGridView()
        Me.FB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.DGVcursos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DGVhorarios,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DGVcursos
        '
        Me.DGVcursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcursos.Location = New System.Drawing.Point(12, 72)
        Me.DGVcursos.Name = "DGVcursos"
        Me.DGVcursos.Size = New System.Drawing.Size(385, 150)
        Me.DGVcursos.TabIndex = 26
        '
        'FA
        '
        Me.FA.Location = New System.Drawing.Point(237, 26)
        Me.FA.Name = "FA"
        Me.FA.Size = New System.Drawing.Size(116, 20)
        Me.FA.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "CODIGO DEL ALUMNO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 41)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "MATRICULAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FE
        '
        Me.FE.Location = New System.Drawing.Point(636, 298)
        Me.FE.Name = "FE"
        Me.FE.Size = New System.Drawing.Size(163, 20)
        Me.FE.TabIndex = 22
        '
        'FD
        '
        Me.FD.Location = New System.Drawing.Point(569, 299)
        Me.FD.Name = "FD"
        Me.FD.Size = New System.Drawing.Size(33, 20)
        Me.FD.TabIndex = 21
        '
        'FC
        '
        Me.FC.Location = New System.Drawing.Point(210, 301)
        Me.FC.Name = "FC"
        Me.FC.Size = New System.Drawing.Size(338, 20)
        Me.FC.TabIndex = 20
        '
        'BTactivar
        '
        Me.BTactivar.Location = New System.Drawing.Point(167, 25)
        Me.BTactivar.Name = "BTactivar"
        Me.BTactivar.Size = New System.Drawing.Size(36, 21)
        Me.BTactivar.TabIndex = 19
        Me.BTactivar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(653, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "HORARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(566, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "SECCION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "CURSO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CICLO"
        '
        'CBciclos
        '
        Me.CBciclos.FormattingEnabled = True
        Me.CBciclos.Items.AddRange(New Object() {"I CICLO", "II CICLO", "III CICLO", "IV CICLO", "V CICLO", "VI CICLO", "VII CICLO", "VIII CICLO", "IX CICLO", "X CICLO"})
        Me.CBciclos.Location = New System.Drawing.Point(12, 25)
        Me.CBciclos.Name = "CBciclos"
        Me.CBciclos.Size = New System.Drawing.Size(139, 21)
        Me.CBciclos.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "CURSOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(455, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "HORARIO"
        '
        'DGVhorarios
        '
        Me.DGVhorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVhorarios.Location = New System.Drawing.Point(407, 72)
        Me.DGVhorarios.Name = "DGVhorarios"
        Me.DGVhorarios.Size = New System.Drawing.Size(385, 150)
        Me.DGVhorarios.TabIndex = 29
        '
        'FB
        '
        Me.FB.Location = New System.Drawing.Point(71, 301)
        Me.FB.Name = "FB"
        Me.FB.Size = New System.Drawing.Size(99, 20)
        Me.FB.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "COD CURSO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(323, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "ELECCIÓN REALIZADA"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(506, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 28)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "FINALIZAR MATRICULA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(662, 418)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(114, 28)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 470)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.FB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVhorarios)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVcursos)
        Me.Controls.Add(Me.FA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FE)
        Me.Controls.Add(Me.FD)
        Me.Controls.Add(Me.FC)
        Me.Controls.Add(Me.BTactivar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBciclos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGVcursos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DGVhorarios,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DGVcursos As System.Windows.Forms.DataGridView
    Friend WithEvents FA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FE As System.Windows.Forms.TextBox
    Friend WithEvents FD As System.Windows.Forms.TextBox
    Friend WithEvents FC As System.Windows.Forms.TextBox
    Friend WithEvents BTactivar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBciclos As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGVhorarios As System.Windows.Forms.DataGridView
    Friend WithEvents FB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSalir As Button
End Class
