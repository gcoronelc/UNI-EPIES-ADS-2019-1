<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteLibros
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbbibliotecaDataSet = New SisBiblioteca.dbbibliotecaDataSet()
        Me.ReporteLibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteLibrosTableAdapter = New SisBiblioteca.dbbibliotecaDataSetTableAdapters.ReporteLibrosTableAdapter()
        CType(Me.dbbibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteLibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReporteLibrosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SisBiblioteca.ReporteLibros.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(820, 472)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbbibliotecaDataSet
        '
        Me.dbbibliotecaDataSet.DataSetName = "dbbibliotecaDataSet"
        Me.dbbibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteLibrosBindingSource
        '
        Me.ReporteLibrosBindingSource.DataMember = "ReporteLibros"
        Me.ReporteLibrosBindingSource.DataSource = Me.dbbibliotecaDataSet
        '
        'ReporteLibrosTableAdapter
        '
        Me.ReporteLibrosTableAdapter.ClearBeforeFill = True
        '
        'ReporteLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 472)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReporteLibros"
        Me.Text = "ReporteLibros"
        CType(Me.dbbibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteLibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteLibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbbibliotecaDataSet As SisBiblioteca.dbbibliotecaDataSet
    Friend WithEvents ReporteLibrosTableAdapter As SisBiblioteca.dbbibliotecaDataSetTableAdapters.ReporteLibrosTableAdapter
End Class
