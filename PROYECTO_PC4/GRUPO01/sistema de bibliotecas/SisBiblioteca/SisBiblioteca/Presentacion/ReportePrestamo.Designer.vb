<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePrestamo
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
        Me.ReportePrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbbibliotecaDataSet1 = New SisBiblioteca.dbbibliotecaDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportePrestamosTableAdapter = New SisBiblioteca.dbbibliotecaDataSet1TableAdapters.ReportePrestamosTableAdapter()
        CType(Me.ReportePrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbbibliotecaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportePrestamosBindingSource
        '
        Me.ReportePrestamosBindingSource.DataMember = "ReportePrestamos"
        Me.ReportePrestamosBindingSource.DataSource = Me.dbbibliotecaDataSet1
        '
        'dbbibliotecaDataSet1
        '
        Me.dbbibliotecaDataSet1.DataSetName = "dbbibliotecaDataSet1"
        Me.dbbibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReportePrestamosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SisBiblioteca.ReportePrestamo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(759, 427)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportePrestamosTableAdapter
        '
        Me.ReportePrestamosTableAdapter.ClearBeforeFill = True
        '
        'ReportePrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 427)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReportePrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportePrestamo"
        CType(Me.ReportePrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbbibliotecaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportePrestamosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbbibliotecaDataSet1 As SisBiblioteca.dbbibliotecaDataSet1
    Friend WithEvents ReportePrestamosTableAdapter As SisBiblioteca.dbbibliotecaDataSet1TableAdapters.ReportePrestamosTableAdapter
End Class
