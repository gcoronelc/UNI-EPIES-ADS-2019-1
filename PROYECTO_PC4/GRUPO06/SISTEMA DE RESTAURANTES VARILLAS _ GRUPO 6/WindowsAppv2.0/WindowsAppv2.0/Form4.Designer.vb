<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim IdpedidoLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim VentaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Pedido2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DISEÑO_VARILLASadsDataSet = New WindowsAppv2._0.DISEÑO_VARILLASadsDataSet()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosTableAdapter = New WindowsAppv2._0.DISEÑO_VARILLASadsDataSetTableAdapters.pedidosTableAdapter()
        Me.TableAdapterManager = New WindowsAppv2._0.DISEÑO_VARILLASadsDataSetTableAdapters.TableAdapterManager()
        Me.ProductoTableAdapter = New WindowsAppv2._0.DISEÑO_VARILLASadsDataSetTableAdapters.ProductoTableAdapter()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgv_company = New System.Windows.Forms.DataGridView()
        Me.dgvpedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvfecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiseñO_VARILLASadsDataSet1 = New WindowsAppv2._0.DISEÑO_VARILLASadsDataSet()
        Me.PedidosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PedidosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdpedidoTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.VentaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        IdpedidoLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        VentaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CType(Me.Pedido2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISEÑO_VARILLASadsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_company, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiseñO_VARILLASadsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdpedidoLabel
        '
        IdpedidoLabel.AutoSize = True
        IdpedidoLabel.Location = New System.Drawing.Point(31, 61)
        IdpedidoLabel.Name = "IdpedidoLabel"
        IdpedidoLabel.Size = New System.Drawing.Size(50, 13)
        IdpedidoLabel.TabIndex = 26
        IdpedidoLabel.Text = "idpedido:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(26, 94)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(54, 13)
        CategoriaLabel.TabIndex = 27
        CategoriaLabel.Text = "categoria:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(45, 140)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 28
        NombreLabel.Text = "nombre:"
        '
        'VentaLabel
        '
        VentaLabel.AutoSize = True
        VentaLabel.Location = New System.Drawing.Point(53, 167)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(37, 13)
        VentaLabel.TabIndex = 29
        VentaLabel.Text = "venta:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(5, 208)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 30
        FechaLabel.Text = "fecha:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(161, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Pedido2BindingSource1
        '
        Me.Pedido2BindingSource1.DataMember = "Pedido2"
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "Producto"
        '
        'DISEÑO_VARILLASadsDataSet
        '
        Me.DISEÑO_VARILLASadsDataSet.DataSetName = "DISEÑO_VARILLASadsDataSet"
        Me.DISEÑO_VARILLASadsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.DISEÑO_VARILLASadsDataSet
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pedidosTableAdapter = Me.PedidosTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsAppv2._0.DISEÑO_VARILLASadsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.DISEÑO_VARILLASadsDataSet
        '
        'dgv_company
        '
        Me.dgv_company.AutoGenerateColumns = False
        Me.dgv_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_company.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvpedido, Me.dgvcat, Me.dgvnombre, Me.dgvventa, Me.dgvfecha})
        Me.dgv_company.DataSource = Me.PedidosBindingSource
        Me.dgv_company.Location = New System.Drawing.Point(284, 187)
        Me.dgv_company.Name = "dgv_company"
        Me.dgv_company.Size = New System.Drawing.Size(548, 144)
        Me.dgv_company.TabIndex = 18
        '
        'dgvpedido
        '
        Me.dgvpedido.DataPropertyName = "idpedido"
        Me.dgvpedido.HeaderText = "idpedido"
        Me.dgvpedido.Name = "dgvpedido"
        '
        'dgvcat
        '
        Me.dgvcat.DataPropertyName = "categoria"
        Me.dgvcat.HeaderText = "categoria"
        Me.dgvcat.Name = "dgvcat"
        '
        'dgvnombre
        '
        Me.dgvnombre.DataPropertyName = "nombre"
        Me.dgvnombre.HeaderText = "nombre"
        Me.dgvnombre.Name = "dgvnombre"
        '
        'dgvventa
        '
        Me.dgvventa.DataPropertyName = "venta"
        Me.dgvventa.HeaderText = "venta"
        Me.dgvventa.Name = "dgvventa"
        '
        'dgvfecha
        '
        Me.dgvfecha.DataPropertyName = "fecha"
        Me.dgvfecha.HeaderText = "fecha"
        Me.dgvfecha.Name = "dgvfecha"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(284, 29)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(442, 128)
        Me.ProductoDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdProducto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Venta"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Venta"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DiseñO_VARILLASadsDataSet1
        '
        Me.DiseñO_VARILLASadsDataSet1.DataSetName = "DISEÑO_VARILLASadsDataSet"
        Me.DiseñO_VARILLASadsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosBindingNavigator
        '
        Me.PedidosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PedidosBindingNavigator.BindingSource = Me.PedidosBindingSource
        Me.PedidosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PedidosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PedidosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PedidosBindingNavigatorSaveItem})
        Me.PedidosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PedidosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PedidosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PedidosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PedidosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PedidosBindingNavigator.Name = "PedidosBindingNavigator"
        Me.PedidosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PedidosBindingNavigator.Size = New System.Drawing.Size(910, 25)
        Me.PedidosBindingNavigator.TabIndex = 26
        Me.PedidosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PedidosBindingNavigatorSaveItem
        '
        Me.PedidosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PedidosBindingNavigatorSaveItem.Image = CType(resources.GetObject("PedidosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PedidosBindingNavigatorSaveItem.Name = "PedidosBindingNavigatorSaveItem"
        Me.PedidosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PedidosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdpedidoTextBox
        '
        Me.IdpedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "idpedido", True))
        Me.IdpedidoTextBox.Location = New System.Drawing.Point(87, 58)
        Me.IdpedidoTextBox.Name = "IdpedidoTextBox"
        Me.IdpedidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdpedidoTextBox.TabIndex = 27
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "categoria", True))
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "Categoria", True))
        Me.CategoriaComboBox.DataSource = Me.ProductoBindingSource
        Me.CategoriaComboBox.DisplayMember = "Categoria"
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(86, 91)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoriaComboBox.TabIndex = 28
        Me.CategoriaComboBox.ValueMember = "Categoria"
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "nombre", True))
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "Nombre", True))
        Me.NombreComboBox.DataSource = Me.ProductoBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(96, 137)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NombreComboBox.TabIndex = 29
        Me.NombreComboBox.ValueMember = "Nombre"
        '
        'VentaTextBox
        '
        Me.VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "venta", True))
        Me.VentaTextBox.Location = New System.Drawing.Point(96, 164)
        Me.VentaTextBox.Name = "VentaTextBox"
        Me.VentaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VentaTextBox.TabIndex = 30
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(48, 204)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 31
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 425)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(VentaLabel)
        Me.Controls.Add(Me.VentaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaComboBox)
        Me.Controls.Add(IdpedidoLabel)
        Me.Controls.Add(Me.IdpedidoTextBox)
        Me.Controls.Add(Me.PedidosBindingNavigator)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.dgv_company)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form4"
        Me.Text = "Comanda Pedido"
        CType(Me.Pedido2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISEÑO_VARILLASadsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_company, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiseñO_VARILLASadsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidosBindingNavigator.ResumeLayout(False)
        Me.PedidosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Pedido2BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DISEÑO_VARILLASadsDataSet As DISEÑO_VARILLASadsDataSet
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As DISEÑO_VARILLASadsDataSetTableAdapters.pedidosTableAdapter
    Friend WithEvents TableAdapterManager As DISEÑO_VARILLASadsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoTableAdapter As DISEÑO_VARILLASadsDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents dgv_company As DataGridView
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DiseñO_VARILLASadsDataSet1 As DISEÑO_VARILLASadsDataSet
    Friend WithEvents dgvpedido As DataGridViewTextBoxColumn
    Friend WithEvents dgvcat As DataGridViewTextBoxColumn
    Friend WithEvents dgvnombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvventa As DataGridViewTextBoxColumn
    Friend WithEvents dgvfecha As DataGridViewTextBoxColumn
    Friend WithEvents PedidosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PedidosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents IdpedidoTextBox As TextBox
    Friend WithEvents CategoriaComboBox As ComboBox
    Friend WithEvents NombreComboBox As ComboBox
    Friend WithEvents VentaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
End Class
