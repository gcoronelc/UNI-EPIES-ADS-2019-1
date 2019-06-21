<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNPrestamo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLector = New System.Windows.Forms.TextBox()
        Me.txtCodLector = New System.Windows.Forms.TextBox()
        Me.btnlector = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLibro = New System.Windows.Forms.TextBox()
        Me.txtCodLibro = New System.Windows.Forms.TextBox()
        Me.btnLibro = New System.Windows.Forms.Button()
        Me.dtpFecDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.dgvLibro = New System.Windows.Forms.DataGridView()
        Me.btndeuda = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(831, 52)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Registro de Préstamo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkCyan
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(58, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(518, 137)
        Me.Label2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(61, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 131)
        Me.Label3.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Código:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Libro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Lector:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Fecha de Entrega:"
        '
        'txtLector
        '
        Me.txtLector.BackColor = System.Drawing.Color.White
        Me.txtLector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLector.Location = New System.Drawing.Point(195, 104)
        Me.txtLector.Name = "txtLector"
        Me.txtLector.ReadOnly = True
        Me.txtLector.Size = New System.Drawing.Size(187, 20)
        Me.txtLector.TabIndex = 17
        '
        'txtCodLector
        '
        Me.txtCodLector.BackColor = System.Drawing.Color.White
        Me.txtCodLector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodLector.Location = New System.Drawing.Point(435, 104)
        Me.txtCodLector.Name = "txtCodLector"
        Me.txtCodLector.ReadOnly = True
        Me.txtCodLector.Size = New System.Drawing.Size(60, 20)
        Me.txtCodLector.TabIndex = 18
        '
        'btnlector
        '
        Me.btnlector.BackColor = System.Drawing.Color.DarkCyan
        Me.btnlector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlector.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnlector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlector.ForeColor = System.Drawing.Color.White
        Me.btnlector.Location = New System.Drawing.Point(501, 102)
        Me.btnlector.Name = "btnlector"
        Me.btnlector.Size = New System.Drawing.Size(36, 22)
        Me.btnlector.TabIndex = 19
        Me.btnlector.Text = "•••"
        Me.btnlector.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlector.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(388, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Código:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(74, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Fecha de Devolución:"
        '
        'txtLibro
        '
        Me.txtLibro.BackColor = System.Drawing.Color.White
        Me.txtLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLibro.Location = New System.Drawing.Point(195, 141)
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.ReadOnly = True
        Me.txtLibro.Size = New System.Drawing.Size(189, 20)
        Me.txtLibro.TabIndex = 22
        '
        'txtCodLibro
        '
        Me.txtCodLibro.BackColor = System.Drawing.Color.White
        Me.txtCodLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodLibro.Location = New System.Drawing.Point(435, 141)
        Me.txtCodLibro.Name = "txtCodLibro"
        Me.txtCodLibro.ReadOnly = True
        Me.txtCodLibro.Size = New System.Drawing.Size(60, 20)
        Me.txtCodLibro.TabIndex = 23
        '
        'btnLibro
        '
        Me.btnLibro.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLibro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLibro.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibro.ForeColor = System.Drawing.Color.White
        Me.btnLibro.Location = New System.Drawing.Point(501, 139)
        Me.btnLibro.Name = "btnLibro"
        Me.btnLibro.Size = New System.Drawing.Size(36, 22)
        Me.btnLibro.TabIndex = 19
        Me.btnLibro.Text = "•••"
        Me.btnLibro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLibro.UseVisualStyleBackColor = False
        '
        'dtpFecDevolucion
        '
        Me.dtpFecDevolucion.Location = New System.Drawing.Point(195, 193)
        Me.dtpFecDevolucion.Name = "dtpFecDevolucion"
        Me.dtpFecDevolucion.Size = New System.Drawing.Size(342, 20)
        Me.dtpFecDevolucion.TabIndex = 24
        '
        'dtpFecEntrega
        '
        Me.dtpFecEntrega.Enabled = False
        Me.dtpFecEntrega.Location = New System.Drawing.Point(195, 167)
        Me.dtpFecEntrega.Name = "dtpFecEntrega"
        Me.dtpFecEntrega.Size = New System.Drawing.Size(342, 20)
        Me.dtpFecEntrega.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DarkCyan
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(58, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(518, 23)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Datos del Registro"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DarkCyan
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(58, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(518, 167)
        Me.Label11.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(61, 268)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(512, 161)
        Me.Label12.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkCyan
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(58, 242)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(518, 23)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Listado de Libros"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(604, 67)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(172, 57)
        Me.btnRegistrar.TabIndex = 26
        Me.btnRegistrar.Text = "&Registrar Préstamo"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'dgvLibro
        '
        Me.dgvLibro.AllowUserToAddRows = False
        Me.dgvLibro.AllowUserToDeleteRows = False
        Me.dgvLibro.AllowUserToResizeColumns = False
        Me.dgvLibro.AllowUserToResizeRows = False
        Me.dgvLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLibro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvLibro.Location = New System.Drawing.Point(66, 273)
        Me.dgvLibro.MultiSelect = False
        Me.dgvLibro.Name = "dgvLibro"
        Me.dgvLibro.ReadOnly = True
        Me.dgvLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibro.Size = New System.Drawing.Size(502, 150)
        Me.dgvLibro.TabIndex = 28
        '
        'btndeuda
        '
        Me.btndeuda.BackColor = System.Drawing.Color.DarkCyan
        Me.btndeuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeuda.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btndeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeuda.ForeColor = System.Drawing.Color.White
        Me.btndeuda.Location = New System.Drawing.Point(604, 167)
        Me.btndeuda.Name = "btndeuda"
        Me.btndeuda.Size = New System.Drawing.Size(172, 57)
        Me.btndeuda.TabIndex = 29
        Me.btndeuda.Text = "&Deuda Lector"
        Me.btndeuda.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.SisBiblioteca.My.Resources.Resources.libros1
        Me.PictureBox1.Location = New System.Drawing.Point(604, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'FNPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 462)
        Me.Controls.Add(Me.btndeuda)
        Me.Controls.Add(Me.dgvLibro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFecEntrega)
        Me.Controls.Add(Me.dtpFecDevolucion)
        Me.Controls.Add(Me.txtCodLibro)
        Me.Controls.Add(Me.txtLibro)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnLibro)
        Me.Controls.Add(Me.btnlector)
        Me.Controls.Add(Me.txtCodLector)
        Me.Controls.Add(Me.txtLector)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FNPrestamo"
        Me.Text = "FNPrestamo"
        CType(Me.dgvLibro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLector As System.Windows.Forms.TextBox
    Friend WithEvents txtCodLector As System.Windows.Forms.TextBox
    Friend WithEvents btnlector As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLibro As System.Windows.Forms.TextBox
    Friend WithEvents txtCodLibro As System.Windows.Forms.TextBox
    Friend WithEvents btnLibro As System.Windows.Forms.Button
    Friend WithEvents dtpFecDevolucion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvLibro As DataGridView
    Friend WithEvents btndeuda As System.Windows.Forms.Button
End Class
