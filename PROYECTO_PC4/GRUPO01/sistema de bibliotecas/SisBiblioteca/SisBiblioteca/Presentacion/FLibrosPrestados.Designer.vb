<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLibrosPrestados
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
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRetornar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvPrestamo = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.cboBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dgvPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Location = New System.Drawing.Point(758, 90)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(13, 13)
        Me.lblRegistros.TabIndex = 25
        Me.lblRegistros.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(718, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "&Total:"
        '
        'btnRetornar
        '
        Me.btnRetornar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetornar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetornar.ForeColor = System.Drawing.Color.White
        Me.btnRetornar.Location = New System.Drawing.Point(686, 406)
        Me.btnRetornar.Name = "btnRetornar"
        Me.btnRetornar.Size = New System.Drawing.Size(105, 46)
        Me.btnRetornar.TabIndex = 21
        Me.btnRetornar.Text = "&Retornar"
        Me.btnRetornar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "&Lista de Prestamos Registrados"
        '
        'dgvPrestamo
        '
        Me.dgvPrestamo.AllowUserToAddRows = False
        Me.dgvPrestamo.AllowUserToDeleteRows = False
        Me.dgvPrestamo.AllowUserToResizeColumns = False
        Me.dgvPrestamo.AllowUserToResizeRows = False
        Me.dgvPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrestamo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvPrestamo.Location = New System.Drawing.Point(46, 110)
        Me.dgvPrestamo.MultiSelect = False
        Me.dgvPrestamo.Name = "dgvPrestamo"
        Me.dgvPrestamo.ReadOnly = True
        Me.dgvPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrestamo.Size = New System.Drawing.Size(745, 281)
        Me.dgvPrestamo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkCyan
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(43, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(751, 287)
        Me.Label2.TabIndex = 19
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusqueda.Location = New System.Drawing.Point(671, 54)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(148, 20)
        Me.txtBusqueda.TabIndex = 30
        '
        'cboBusqueda
        '
        Me.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboBusqueda.FormattingEnabled = True
        Me.cboBusqueda.Items.AddRange(New Object() {"Lector", "Titulo"})
        Me.cboBusqueda.Location = New System.Drawing.Point(544, 53)
        Me.cboBusqueda.Name = "cboBusqueda"
        Me.cboBusqueda.Size = New System.Drawing.Size(121, 21)
        Me.cboBusqueda.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label6.Location = New System.Drawing.Point(477, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Buscar por:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(831, 44)
        Me.Label5.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(831, 42)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Listado de libros Prestados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DarkCyan
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(46, 406)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(105, 46)
        Me.btnImprimir.TabIndex = 31
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'FLibrosPrestados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 464)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cboBusqueda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRetornar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvPrestamo)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FLibrosPrestados"
        Me.Text = "FLibrosPrestados"
        CType(Me.dgvPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegistros As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRetornar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvPrestamo As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents cboBusqueda As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
