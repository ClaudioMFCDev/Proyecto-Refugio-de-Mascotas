<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportecomprobante
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MascotaDataSet2 = New Mascota.MascotaDataSet2()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbidadopcion2 = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Generar_comprobanteTableAdapter1 = New Mascota.MascotaDataSet2TableAdapters.generar_comprobanteTableAdapter()
        CType(Me.MascotaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MascotaDataSet2
        '
        Me.MascotaDataSet2.DataSetName = "MascotaDataSet2"
        Me.MascotaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "Mascota.reporte2.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(781, 451)
        Me.ReportViewer3.TabIndex = 0
        '
        'tbidadopcion2
        '
        Me.tbidadopcion2.Location = New System.Drawing.Point(377, 109)
        Me.tbidadopcion2.Name = "tbidadopcion2"
        Me.tbidadopcion2.Size = New System.Drawing.Size(100, 20)
        Me.tbidadopcion2.TabIndex = 1
        Me.tbidadopcion2.Visible = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "generar_comprobante"
        Me.BindingSource1.DataSource = Me.MascotaDataSet2
        '
        'Generar_comprobanteTableAdapter1
        '
        Me.Generar_comprobanteTableAdapter1.ClearBeforeFill = True
        '
        'frmreportecomprobante
        '
        Me.ClientSize = New System.Drawing.Size(781, 451)
        Me.Controls.Add(Me.tbidadopcion2)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Name = "frmreportecomprobante"
        CType(Me.MascotaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_comprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents generar_comprobanteTableAdapter As MascotaDataSet2TableAdapters.generar_comprobanteTableAdapter
    Friend WithEvents txtidadopcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MascotaDataSet2 As MascotaDataSet2
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbidadopcion2 As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Generar_comprobanteTableAdapter1 As MascotaDataSet2TableAdapters.generar_comprobanteTableAdapter
End Class
