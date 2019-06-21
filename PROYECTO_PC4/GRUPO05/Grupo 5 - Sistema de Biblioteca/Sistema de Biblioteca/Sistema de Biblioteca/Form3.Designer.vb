<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim NumDocUsuarioLabel As System.Windows.Forms.Label
        Dim UsuarioNombreLabel As System.Windows.Forms.Label
        Dim FechaIngresoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Me.SISTBIBLIOTECADataSet = New Sistema_de_Biblioteca.SISTBIBLIOTECADataSet()
        Me.USUARIOSBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOSBTableAdapter = New Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.USUARIOSBTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.TableAdapterManager()
        Me.USUARIOSBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NumDocUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioNombreTextBox = New System.Windows.Forms.TextBox()
        Me.FechaIngresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        NumDocUsuarioLabel = New System.Windows.Forms.Label()
        UsuarioNombreLabel = New System.Windows.Forms.Label()
        FechaIngresoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        CType(Me.SISTBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOSBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.USUARIOSBBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SISTBIBLIOTECADataSet
        '
        Me.SISTBIBLIOTECADataSet.DataSetName = "SISTBIBLIOTECADataSet"
        Me.SISTBIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIOSBBindingSource
        '
        Me.USUARIOSBBindingSource.DataMember = "USUARIOSB"
        Me.USUARIOSBBindingSource.DataSource = Me.SISTBIBLIOTECADataSet
        '
        'USUARIOSBTableAdapter
        '
        Me.USUARIOSBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AUTORSBTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LIBROSSBTableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMISTASBTableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMOESTUDIOTableAdapter = Nothing
        Me.TableAdapterManager.PRESTAMOSBTableAdapter = Nothing
        Me.TableAdapterManager.SANCIONSBTableAdapter = Nothing
        Me.TableAdapterManager.TEMASBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOSBTableAdapter = Me.USUARIOSBTableAdapter
        '
        'USUARIOSBBindingNavigator
        '
        Me.USUARIOSBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.USUARIOSBBindingNavigator.BindingSource = Me.USUARIOSBBindingSource
        Me.USUARIOSBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.USUARIOSBBindingNavigator.DeleteItem = Nothing
        Me.USUARIOSBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem})
        Me.USUARIOSBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.USUARIOSBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.USUARIOSBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.USUARIOSBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.USUARIOSBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.USUARIOSBBindingNavigator.Name = "USUARIOSBBindingNavigator"
        Me.USUARIOSBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.USUARIOSBBindingNavigator.Size = New System.Drawing.Size(475, 25)
        Me.USUARIOSBBindingNavigator.TabIndex = 0
        Me.USUARIOSBBindingNavigator.Text = "BindingNavigator1"
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
        'NumDocUsuarioLabel
        '
        NumDocUsuarioLabel.AutoSize = True
        NumDocUsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumDocUsuarioLabel.Location = New System.Drawing.Point(34, 121)
        NumDocUsuarioLabel.Name = "NumDocUsuarioLabel"
        NumDocUsuarioLabel.Size = New System.Drawing.Size(123, 17)
        NumDocUsuarioLabel.TabIndex = 1
        NumDocUsuarioLabel.Text = "Num Doc Usuario:"
        '
        'NumDocUsuarioTextBox
        '
        Me.NumDocUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBBindingSource, "NumDocUsuario", True))
        Me.NumDocUsuarioTextBox.Location = New System.Drawing.Point(172, 120)
        Me.NumDocUsuarioTextBox.Name = "NumDocUsuarioTextBox"
        Me.NumDocUsuarioTextBox.Size = New System.Drawing.Size(133, 20)
        Me.NumDocUsuarioTextBox.TabIndex = 2
        '
        'UsuarioNombreLabel
        '
        UsuarioNombreLabel.AutoSize = True
        UsuarioNombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioNombreLabel.Location = New System.Drawing.Point(34, 149)
        UsuarioNombreLabel.Name = "UsuarioNombreLabel"
        UsuarioNombreLabel.Size = New System.Drawing.Size(115, 17)
        UsuarioNombreLabel.TabIndex = 3
        UsuarioNombreLabel.Text = "Usuario Nombre:"
        '
        'UsuarioNombreTextBox
        '
        Me.UsuarioNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBBindingSource, "UsuarioNombre", True))
        Me.UsuarioNombreTextBox.Location = New System.Drawing.Point(172, 149)
        Me.UsuarioNombreTextBox.Name = "UsuarioNombreTextBox"
        Me.UsuarioNombreTextBox.Size = New System.Drawing.Size(266, 20)
        Me.UsuarioNombreTextBox.TabIndex = 4
        '
        'FechaIngresoLabel
        '
        FechaIngresoLabel.AutoSize = True
        FechaIngresoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaIngresoLabel.Location = New System.Drawing.Point(17, 53)
        FechaIngresoLabel.Name = "FechaIngresoLabel"
        FechaIngresoLabel.Size = New System.Drawing.Size(102, 17)
        FechaIngresoLabel.TabIndex = 5
        FechaIngresoLabel.Text = "Fecha Ingreso:"
        '
        'FechaIngresoDateTimePicker
        '
        Me.FechaIngresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.USUARIOSBBindingSource, "FechaIngreso", True))
        Me.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaIngresoDateTimePicker.Location = New System.Drawing.Point(125, 53)
        Me.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker"
        Me.FechaIngresoDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.FechaIngresoDateTimePicker.TabIndex = 6
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(34, 183)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 17)
        DireccionLabel.TabIndex = 7
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(172, 183)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(266, 20)
        Me.DireccionTextBox.TabIndex = 8
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CelularLabel.Location = New System.Drawing.Point(34, 218)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(56, 17)
        CelularLabel.TabIndex = 9
        CelularLabel.Text = "Celular:"
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(172, 215)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CelularTextBox.TabIndex = 10
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(34, 251)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(55, 17)
        CorreoLabel.TabIndex = 11
        CorreoLabel.Text = "Correo:"
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBBindingSource, "Correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(172, 248)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(258, 20)
        Me.CorreoTextBox.TabIndex = 12
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 311)
        Me.Controls.Add(NumDocUsuarioLabel)
        Me.Controls.Add(Me.NumDocUsuarioTextBox)
        Me.Controls.Add(UsuarioNombreLabel)
        Me.Controls.Add(Me.UsuarioNombreTextBox)
        Me.Controls.Add(FechaIngresoLabel)
        Me.Controls.Add(Me.FechaIngresoDateTimePicker)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(Me.USUARIOSBBindingNavigator)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Estudiante"
        CType(Me.SISTBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOSBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.USUARIOSBBindingNavigator.ResumeLayout(False)
        Me.USUARIOSBBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SISTBIBLIOTECADataSet As Sistema_de_Biblioteca.SISTBIBLIOTECADataSet
    Friend WithEvents USUARIOSBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOSBTableAdapter As Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.USUARIOSBTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_de_Biblioteca.SISTBIBLIOTECADataSetTableAdapters.TableAdapterManager
    Friend WithEvents USUARIOSBBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NumDocUsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioNombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaIngresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorreoTextBox As System.Windows.Forms.TextBox
End Class
