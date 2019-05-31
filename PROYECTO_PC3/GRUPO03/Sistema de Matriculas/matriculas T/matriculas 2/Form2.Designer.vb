<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVAlmMat = New System.Windows.Forms.DataGridView()
        CType(Me.DGVAlmMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "MOSTRAR CURSOS MATRICULADOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGVAlmMat
        '
        Me.DGVAlmMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAlmMat.Location = New System.Drawing.Point(38, 121)
        Me.DGVAlmMat.Name = "DGVAlmMat"
        Me.DGVAlmMat.Size = New System.Drawing.Size(385, 150)
        Me.DGVAlmMat.TabIndex = 27
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 388)
        Me.Controls.Add(Me.DGVAlmMat)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DGVAlmMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGVAlmMat As System.Windows.Forms.DataGridView
End Class
