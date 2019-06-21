<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regtrip
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
        Me.lbldni = New System.Windows.Forms.Label()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.gbcliente = New System.Windows.Forms.GroupBox()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lblcustomer = New System.Windows.Forms.TextBox()
        Me.lblres = New System.Windows.Forms.Label()
        Me.gbtrans = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvtransporte = New System.Windows.Forms.DataGridView()
        Me.dgvc1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paneltransporte = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblreserva = New System.Windows.Forms.Label()
        Me.btnreservar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gbcliente.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbtrans.SuspendLayout()
        CType(Me.dgvtransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paneltransporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.Location = New System.Drawing.Point(6, 34)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(29, 13)
        Me.lbldni.TabIndex = 0
        Me.lbldni.Text = "DNI:"
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(6, 56)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(33, 13)
        Me.lblcod.TabIndex = 1
        Me.lblcod.Text = "COD:"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(61, 31)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 2
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(61, 53)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 20)
        Me.txtcod.TabIndex = 3
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(189, 34)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(68, 35)
        Me.btnbuscar.TabIndex = 4
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'gbcliente
        '
        Me.gbcliente.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbcliente.Controls.Add(Me.btnbuscar)
        Me.gbcliente.Controls.Add(Me.txtdni)
        Me.gbcliente.Controls.Add(Me.txtcod)
        Me.gbcliente.Controls.Add(Me.lbldni)
        Me.gbcliente.Controls.Add(Me.lblcod)
        Me.gbcliente.Location = New System.Drawing.Point(27, 32)
        Me.gbcliente.Name = "gbcliente"
        Me.gbcliente.Size = New System.Drawing.Size(277, 85)
        Me.gbcliente.TabIndex = 1
        Me.gbcliente.TabStop = False
        Me.gbcliente.Text = "Identificar cliente"
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblresult.Location = New System.Drawing.Point(72, 12)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 13)
        Me.lblresult.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.lblcustomer)
        Me.Panel1.Controls.Add(Me.lblres)
        Me.Panel1.Controls.Add(Me.lblresult)
        Me.Panel1.Location = New System.Drawing.Point(27, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 65)
        Me.Panel1.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox7.Location = New System.Drawing.Point(72, 40)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(182, 22)
        Me.TextBox7.TabIndex = 6
        '
        'lblcustomer
        '
        Me.lblcustomer.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblcustomer.Location = New System.Drawing.Point(72, 3)
        Me.lblcustomer.Multiline = True
        Me.lblcustomer.Name = "lblcustomer"
        Me.lblcustomer.ReadOnly = True
        Me.lblcustomer.Size = New System.Drawing.Size(182, 33)
        Me.lblcustomer.TabIndex = 5
        '
        'lblres
        '
        Me.lblres.AutoSize = True
        Me.lblres.Location = New System.Drawing.Point(3, 12)
        Me.lblres.Name = "lblres"
        Me.lblres.Size = New System.Drawing.Size(63, 13)
        Me.lblres.TabIndex = 4
        Me.lblres.Text = "Resultados:"
        '
        'gbtrans
        '
        Me.gbtrans.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gbtrans.Controls.Add(Me.DateTimePicker1)
        Me.gbtrans.Controls.Add(Me.TextBox6)
        Me.gbtrans.Controls.Add(Me.Label1)
        Me.gbtrans.Controls.Add(Me.TextBox3)
        Me.gbtrans.Controls.Add(Me.TextBox2)
        Me.gbtrans.Controls.Add(Me.TextBox1)
        Me.gbtrans.Controls.Add(Me.Label5)
        Me.gbtrans.Controls.Add(Me.Label4)
        Me.gbtrans.Controls.Add(Me.Label3)
        Me.gbtrans.Controls.Add(Me.Label2)
        Me.gbtrans.Location = New System.Drawing.Point(27, 194)
        Me.gbtrans.Name = "gbtrans"
        Me.gbtrans.Size = New System.Drawing.Size(290, 178)
        Me.gbtrans.TabIndex = 5
        Me.gbtrans.TabStop = False
        Me.gbtrans.Text = "Buscar transporte"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(84, 146)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox6.Location = New System.Drawing.Point(84, 40)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 10
        Me.TextBox6.Text = "Estación Salaverry 781"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Inicio:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(84, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Zona:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ruta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Destino:"
        '
        'dgvtransporte
        '
        Me.dgvtransporte.BackgroundColor = System.Drawing.SystemColors.Desktop
        Me.dgvtransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtransporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvc1, Me.Column1})
        Me.dgvtransporte.GridColor = System.Drawing.SystemColors.Control
        Me.dgvtransporte.Location = New System.Drawing.Point(335, 30)
        Me.dgvtransporte.Name = "dgvtransporte"
        Me.dgvtransporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtransporte.Size = New System.Drawing.Size(234, 263)
        Me.dgvtransporte.TabIndex = 6
        '
        'dgvc1
        '
        Me.dgvc1.HeaderText = "Transporte"
        Me.dgvc1.Name = "dgvc1"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Vacante"
        Me.Column1.Name = "Column1"
        '
        'Paneltransporte
        '
        Me.Paneltransporte.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Paneltransporte.Controls.Add(Me.TextBox5)
        Me.Paneltransporte.Controls.Add(Me.Label6)
        Me.Paneltransporte.Controls.Add(Me.lblreserva)
        Me.Paneltransporte.Location = New System.Drawing.Point(323, 299)
        Me.Paneltransporte.Name = "Paneltransporte"
        Me.Paneltransporte.Size = New System.Drawing.Size(295, 71)
        Me.Paneltransporte.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox5.Location = New System.Drawing.Point(72, 9)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(216, 45)
        Me.TextBox5.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Resultados:"
        '
        'lblreserva
        '
        Me.lblreserva.AutoSize = True
        Me.lblreserva.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblreserva.Location = New System.Drawing.Point(72, 12)
        Me.lblreserva.Name = "lblreserva"
        Me.lblreserva.Size = New System.Drawing.Size(0, 13)
        Me.lblreserva.TabIndex = 3
        '
        'btnreservar
        '
        Me.btnreservar.Location = New System.Drawing.Point(575, 32)
        Me.btnreservar.Name = "btnreservar"
        Me.btnreservar.Size = New System.Drawing.Size(75, 37)
        Me.btnreservar.TabIndex = 7
        Me.btnreservar.Text = "Reservar vacante"
        Me.btnreservar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(575, 80)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 37)
        Me.btnmodificar.TabIndex = 8
        Me.btnmodificar.Text = "Modificar vacante"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(593, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 35)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Regtrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 384)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnreservar)
        Me.Controls.Add(Me.Paneltransporte)
        Me.Controls.Add(Me.dgvtransporte)
        Me.Controls.Add(Me.gbtrans)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbcliente)
        Me.Name = "Regtrip"
        Me.Text = "Registro y/o modificación de la tripulación"
        Me.gbcliente.ResumeLayout(False)
        Me.gbcliente.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbtrans.ResumeLayout(False)
        Me.gbtrans.PerformLayout()
        CType(Me.dgvtransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paneltransporte.ResumeLayout(False)
        Me.Paneltransporte.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbldni As Label
    Friend WithEvents lblcod As Label
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents gbcliente As GroupBox
    Friend WithEvents lblresult As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblres As Label
    Friend WithEvents gbtrans As GroupBox
    Friend WithEvents dgvtransporte As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Paneltransporte As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblreserva As Label
    Friend WithEvents btnreservar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents lblcustomer As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvc1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
End Class
