<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaAdopciones
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
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BDetalle = New System.Windows.Forms.Button()
        Me.DGVAdopciones = New System.Windows.Forms.DataGridView()
        CType(Me.DGVAdopciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(521, 233)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 5
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BDetalle
        '
        Me.BDetalle.Location = New System.Drawing.Point(521, 283)
        Me.BDetalle.Name = "BDetalle"
        Me.BDetalle.Size = New System.Drawing.Size(75, 23)
        Me.BDetalle.TabIndex = 4
        Me.BDetalle.Text = "Ver Detalle"
        Me.BDetalle.UseVisualStyleBackColor = True
        '
        'DGVAdopciones
        '
        Me.DGVAdopciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdopciones.Location = New System.Drawing.Point(25, 118)
        Me.DGVAdopciones.Name = "DGVAdopciones"
        Me.DGVAdopciones.Size = New System.Drawing.Size(479, 188)
        Me.DGVAdopciones.TabIndex = 3
        '
        'ListaAdopciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 425)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BDetalle)
        Me.Controls.Add(Me.DGVAdopciones)
        Me.Name = "ListaAdopciones"
        Me.Text = "ListaAdopciones"
        CType(Me.DGVAdopciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BDetalle As System.Windows.Forms.Button
    Friend WithEvents DGVAdopciones As System.Windows.Forms.DataGridView
End Class
