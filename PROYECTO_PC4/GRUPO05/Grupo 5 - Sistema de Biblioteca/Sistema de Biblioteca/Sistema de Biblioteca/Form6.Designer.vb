<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim NumDocPrestamistaLabel As System.Windows.Forms.Label
        Dim NumDocUsuarioLabel As System.Windows.Forms.Label
        Dim FechaInicioLabel As System.Windows.Forms.Label
        Dim FechaFinLabel As System.Windows.Forms.Label
        Dim ObsInicioLabel As System.Windows.Forms.Label
        Dim ObsFinLabel As System.Windows.Forms.Label
        Dim AutorNombreLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Me.SISTBIBLIOTECADataSet = New Sistema_de_Biblioteca.SISTBIBLIOTECADataSet()
        Me.PRESTAMOSBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRESTAMOSBTableAdapter = New Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.PRESTAMOSBTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.TableAdapterManager()
        Me.PRESTAMOSBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PRESTAMOSBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NumDocPrestamistaTextBox = New System.Windows.Forms.TextBox()
        Me.NumDocUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.FechaInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaFinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ObsInicioTextBox = New System.Windows.Forms.TextBox()
        Me.ObsFinTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AUTORSBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AUTORSBTableAdapter = New Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.AUTORSBTableAdapter()
        Me.AutorNombreTextBox = New System.Windows.Forms.TextBox()
        Me.LIBROSSBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBROSSBTableAdapter = New Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.LIBROSSBTableAdapter()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PRESTAMOSBBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRESTAMOSBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIBROSSBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        NumDocPrestamistaLabel = New System.Windows.Forms.Label()
        NumDocUsuarioLabel = New System.Windows.Forms.Label()
        FechaInicioLabel = New System.Windows.Forms.Label()
        FechaFinLabel = New System.Windows.Forms.Label()
        ObsInicioLabel = New System.Windows.Forms.Label()
        ObsFinLabel = New System.Windows.Forms.Label()
        AutorNombreLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        CType(Me.SISTBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTAMOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTAMOSBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PRESTAMOSBBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AUTORSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBROSSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PRESTAMOSBBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTAMOSBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBROSSBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SISTBIBLIOTECADataSet
        '
        Me.SISTBIBLIOTECADataSet.DataSetName = "SISTBIBLIOTECADataSet"
        Me.SISTBIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRESTAMOSBBindingSource
        '
        Me.PRESTAMOSBBindingSource.DataMember = "PRESTAMOSB"
        Me.PRESTAMOSBBindingSource.DataSource = Me.SISTBIBLIOTECADataSet
        '
        'PRESTAMOSBTableAdapter
        '
        Me.PRESTAMOSBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUTORSBTableAdapter = Me.AUTORSBTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LIBROSSBTableAdapter = Me.LIBROSSBTableAdapter
        Me.TableAdapterManager.PRESTAMISTASBTableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMOESTUDIOTableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMOSBTableAdapter = Me.PRESTAMOSBTableAdapter
        Me.TableAdapterManager.SANCIONSBTableAdapter = Nothing
        Me.TableAdapterManager.TEMASBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOSBTableAdapter = Nothing
        '
        'PRESTAMOSBBindingNavigator
        '
        Me.PRESTAMOSBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PRESTAMOSBBindingNavigator.BindingSource = Me.PRESTAMOSBBindingSource
        Me.PRESTAMOSBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PRESTAMOSBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PRESTAMOSBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PRESTAMOSBBindingNavigatorSaveItem})
        Me.PRESTAMOSBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PRESTAMOSBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PRESTAMOSBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PRESTAMOSBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PRESTAMOSBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PRESTAMOSBBindingNavigator.Name = "PRESTAMOSBBindingNavigator"
        Me.PRESTAMOSBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PRESTAMOSBBindingNavigator.Size = New System.Drawing.Size(468, 25)
        Me.PRESTAMOSBBindingNavigator.TabIndex = 0
        Me.PRESTAMOSBBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PRESTAMOSBBindingNavigatorSaveItem
        '
        Me.PRESTAMOSBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PRESTAMOSBBindingNavigatorSaveItem.Image = CType(resources.GetObject("PRESTAMOSBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PRESTAMOSBBindingNavigatorSaveItem.Name = "PRESTAMOSBBindingNavigatorSaveItem"
        Me.PRESTAMOSBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PRESTAMOSBBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NumDocPrestamistaLabel
        '
        NumDocPrestamistaLabel.AutoSize = True
        NumDocPrestamistaLabel.Location = New System.Drawing.Point(13, 22)
        NumDocPrestamistaLabel.Name = "NumDocPrestamistaLabel"
        NumDocPrestamistaLabel.Size = New System.Drawing.Size(86, 13)
        NumDocPrestamistaLabel.TabIndex = 3
        NumDocPrestamistaLabel.Text = "DNI Prestamista:"
        '
        'NumDocPrestamistaTextBox
        '
        Me.NumDocPrestamistaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTAMOSBBindingSource, "NumDocPrestamista", True))
        Me.NumDocPrestamistaTextBox.Location = New System.Drawing.Point(105, 19)
        Me.NumDocPrestamistaTextBox.Name = "NumDocPrestamistaTextBox"
        Me.NumDocPrestamistaTextBox.Size = New System.Drawing.Size(99, 20)
        Me.NumDocPrestamistaTextBox.TabIndex = 4
        '
        'NumDocUsuarioLabel
        '
        NumDocUsuarioLabel.AutoSize = True
        NumDocUsuarioLabel.Location = New System.Drawing.Point(13, 48)
        NumDocUsuarioLabel.Name = "NumDocUsuarioLabel"
        NumDocUsuarioLabel.Size = New System.Drawing.Size(68, 13)
        NumDocUsuarioLabel.TabIndex = 5
        NumDocUsuarioLabel.Text = "DNI Usuario:"
        '
        'NumDocUsuarioTextBox
        '
        Me.NumDocUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTAMOSBBindingSource, "NumDocUsuario", True))
        Me.NumDocUsuarioTextBox.Location = New System.Drawing.Point(105, 45)
        Me.NumDocUsuarioTextBox.Name = "NumDocUsuarioTextBox"
        Me.NumDocUsuarioTextBox.Size = New System.Drawing.Size(99, 20)
        Me.NumDocUsuarioTextBox.TabIndex = 6
        '
        'FechaInicioLabel
        '
        FechaInicioLabel.AutoSize = True
        FechaInicioLabel.Location = New System.Drawing.Point(220, 22)
        FechaInicioLabel.Name = "FechaInicioLabel"
        FechaInicioLabel.Size = New System.Drawing.Size(68, 13)
        FechaInicioLabel.TabIndex = 9
        FechaInicioLabel.Text = "Fecha Inicio:"
        '
        'FechaInicioDateTimePicker
        '
        Me.FechaInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRESTAMOSBBindingSource, "FechaInicio", True))
        Me.FechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicioDateTimePicker.Location = New System.Drawing.Point(294, 16)
        Me.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker"
        Me.FechaInicioDateTimePicker.Size = New System.Drawing.Size(97, 20)
        Me.FechaInicioDateTimePicker.TabIndex = 10
        '
        'FechaFinLabel
        '
        FechaFinLabel.AutoSize = True
        FechaFinLabel.Location = New System.Drawing.Point(231, 48)
        FechaFinLabel.Name = "FechaFinLabel"
        FechaFinLabel.Size = New System.Drawing.Size(57, 13)
        FechaFinLabel.TabIndex = 11
        FechaFinLabel.Text = "Fecha Fin:"
        '
        'FechaFinDateTimePicker
        '
        Me.FechaFinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRESTAMOSBBindingSource, "FechaFin", True))
        Me.FechaFinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinDateTimePicker.Location = New System.Drawing.Point(294, 42)
        Me.FechaFinDateTimePicker.Name = "FechaFinDateTimePicker"
        Me.FechaFinDateTimePicker.Size = New System.Drawing.Size(97, 20)
        Me.FechaFinDateTimePicker.TabIndex = 12
        '
        'ObsInicioLabel
        '
        ObsInicioLabel.AutoSize = True
        ObsInicioLabel.Location = New System.Drawing.Point(14, 21)
        ObsInicioLabel.Name = "ObsInicioLabel"
        ObsInicioLabel.Size = New System.Drawing.Size(57, 13)
        ObsInicioLabel.TabIndex = 15
        ObsInicioLabel.Text = "Obs Inicio:"
        '
        'ObsInicioTextBox
        '
        Me.ObsInicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTAMOSBBindingSource, "ObsInicio", True))
        Me.ObsInicioTextBox.Location = New System.Drawing.Point(12, 37)
        Me.ObsInicioTextBox.Multiline = True
        Me.ObsInicioTextBox.Name = "ObsInicioTextBox"
        Me.ObsInicioTextBox.Size = New System.Drawing.Size(403, 47)
        Me.ObsInicioTextBox.TabIndex = 16
        '
        'ObsFinLabel
        '
        ObsFinLabel.AutoSize = True
        ObsFinLabel.Location = New System.Drawing.Point(13, 91)
        ObsFinLabel.Name = "ObsFinLabel"
        ObsFinLabel.Size = New System.Drawing.Size(46, 13)
        ObsFinLabel.TabIndex = 17
        ObsFinLabel.Text = "Obs Fin:"
        '
        'ObsFinTextBox
        '
        Me.ObsFinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTAMOSBBindingSource, "ObsFin", True))
        Me.ObsFinTextBox.Location = New System.Drawing.Point(12, 107)
        Me.ObsFinTextBox.Multiline = True
        Me.ObsFinTextBox.Name = "ObsFinTextBox"
        Me.ObsFinTextBox.Size = New System.Drawing.Size(403, 46)
        Me.ObsFinTextBox.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(CategoriaLabel)
        Me.GroupBox1.Controls.Add(Me.CategoriaTextBox)
        Me.GroupBox1.Controls.Add(Me.LIBROSSBDataGridView)
        Me.GroupBox1.Controls.Add(TituloLabel)
        Me.GroupBox1.Controls.Add(Me.TituloTextBox)
        Me.GroupBox1.Controls.Add(AutorNombreLabel)
        Me.GroupBox1.Controls.Add(Me.AutorNombreTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 207)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Libro:"
        '
        'AUTORSBBindingSource
        '
        Me.AUTORSBBindingSource.DataMember = "AUTORSB"
        Me.AUTORSBBindingSource.DataSource = Me.SISTBIBLIOTECADataSet
        '
        'AUTORSBTableAdapter
        '
        Me.AUTORSBTableAdapter.ClearBeforeFill = True
        '
        'AutorNombreLabel
        '
        AutorNombreLabel.AutoSize = True
        AutorNombreLabel.Location = New System.Drawing.Point(14, 49)
        AutorNombreLabel.Name = "AutorNombreLabel"
        AutorNombreLabel.Size = New System.Drawing.Size(35, 13)
        AutorNombreLabel.TabIndex = 0
        AutorNombreLabel.Text = "Autor:"
        '
        'AutorNombreTextBox
        '
        Me.AutorNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AUTORSBBindingSource, "AutorNombre", True))
        Me.AutorNombreTextBox.Location = New System.Drawing.Point(55, 46)
        Me.AutorNombreTextBox.Name = "AutorNombreTextBox"
        Me.AutorNombreTextBox.Size = New System.Drawing.Size(173, 20)
        Me.AutorNombreTextBox.TabIndex = 1
        '
        'LIBROSSBBindingSource
        '
        Me.LIBROSSBBindingSource.DataMember = "LIBROSSB"
        Me.LIBROSSBBindingSource.DataSource = Me.SISTBIBLIOTECADataSet
        '
        'LIBROSSBTableAdapter
        '
        Me.LIBROSSBTableAdapter.ClearBeforeFill = True
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(13, 23)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(36, 13)
        TituloLabel.TabIndex = 2
        TituloLabel.Text = "Titulo:"
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIBROSSBBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(55, 20)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(360, 20)
        Me.TituloTextBox.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumDocPrestamistaTextBox)
        Me.GroupBox2.Controls.Add(NumDocPrestamistaLabel)
        Me.GroupBox2.Controls.Add(FechaInicioLabel)
        Me.GroupBox2.Controls.Add(Me.FechaInicioDateTimePicker)
        Me.GroupBox2.Controls.Add(NumDocUsuarioLabel)
        Me.GroupBox2.Controls.Add(FechaFinLabel)
        Me.GroupBox2.Controls.Add(Me.NumDocUsuarioTextBox)
        Me.GroupBox2.Controls.Add(Me.FechaFinDateTimePicker)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 75)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(ObsInicioLabel)
        Me.GroupBox3.Controls.Add(Me.ObsFinTextBox)
        Me.GroupBox3.Controls.Add(ObsFinLabel)
        Me.GroupBox3.Controls.Add(Me.ObsInicioTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(436, 172)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Observaciones:"
        '
        'PRESTAMOSBBindingSource1
        '
        Me.PRESTAMOSBBindingSource1.DataMember = "FK__PRESTAMOS__IDlib__1BFD2C07"
        Me.PRESTAMOSBBindingSource1.DataSource = Me.LIBROSSBBindingSource
        '
        'PRESTAMOSBDataGridView
        '
        Me.PRESTAMOSBDataGridView.AutoGenerateColumns = False
        Me.PRESTAMOSBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRESTAMOSBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PRESTAMOSBDataGridView.DataSource = Me.PRESTAMOSBBindingSource1
        Me.PRESTAMOSBDataGridView.Location = New System.Drawing.Point(12, 500)
        Me.PRESTAMOSBDataGridView.Name = "PRESTAMOSBDataGridView"
        Me.PRESTAMOSBDataGridView.Size = New System.Drawing.Size(436, 165)
        Me.PRESTAMOSBDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumDocPrestamista"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NumDocPrestamista"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumDocUsuario"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NumDocUsuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaInicio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FechaInicio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaFin"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FechaFin"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ObsInicio"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ObsInicio"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ObsFin"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ObsFin"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'LIBROSSBDataGridView
        '
        Me.LIBROSSBDataGridView.AutoGenerateColumns = False
        Me.LIBROSSBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LIBROSSBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.LIBROSSBDataGridView.DataSource = Me.LIBROSSBBindingSource
        Me.LIBROSSBDataGridView.Location = New System.Drawing.Point(17, 72)
        Me.LIBROSSBDataGridView.Name = "LIBROSSBDataGridView"
        Me.LIBROSSBDataGridView.Size = New System.Drawing.Size(398, 115)
        Me.LIBROSSBDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Titulo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Titulo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "N_ejemplares"
        Me.DataGridViewTextBoxColumn12.HeaderText = "N_ejemplares"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Estante"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Estante"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Casillero"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Casillero"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(254, 49)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 6
        CategoriaLabel.Text = "Categoria:"
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LIBROSSBBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(315, 46)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoriaTextBox.TabIndex = 7
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 681)
        Me.Controls.Add(Me.PRESTAMOSBDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PRESTAMOSBBindingNavigator)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Prestamo"
        CType(Me.SISTBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTAMOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTAMOSBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PRESTAMOSBBindingNavigator.ResumeLayout(False)
        Me.PRESTAMOSBBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AUTORSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBROSSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PRESTAMOSBBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTAMOSBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBROSSBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SISTBIBLIOTECADataSet As Sistema_de_Biblioteca.SISTBIBLIOTECADataSet
    Friend WithEvents PRESTAMOSBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRESTAMOSBTableAdapter As Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.PRESTAMOSBTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRESTAMOSBBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PRESTAMOSBBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AUTORSBTableAdapter As Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.AUTORSBTableAdapter
    Friend WithEvents NumDocPrestamistaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumDocUsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaInicioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaFinDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ObsInicioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObsFinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AUTORSBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIBROSSBTableAdapter As Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.LIBROSSBTableAdapter
    Friend WithEvents AutorNombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LIBROSSBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LIBROSSBDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PRESTAMOSBBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PRESTAMOSBDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
