<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle
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
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.BImprimir = New System.Windows.Forms.Button()
        Me.LBPersonal = New System.Windows.Forms.Label()
        Me.LPersonal = New System.Windows.Forms.Label()
        Me.LBAdoptante = New System.Windows.Forms.Label()
        Me.LAdoptante = New System.Windows.Forms.Label()
        Me.LBFecha = New System.Windows.Forms.Label()
        Me.LBAdopcion = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LAdopcion = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.tb1 = New System.Windows.Forms.TextBox()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVDetalle
        '
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Location = New System.Drawing.Point(33, 197)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.Size = New System.Drawing.Size(459, 137)
        Me.DGVDetalle.TabIndex = 3
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.BImprimir)
        Me.GBDatos.Controls.Add(Me.LBPersonal)
        Me.GBDatos.Controls.Add(Me.LPersonal)
        Me.GBDatos.Controls.Add(Me.LBAdoptante)
        Me.GBDatos.Controls.Add(Me.LAdoptante)
        Me.GBDatos.Controls.Add(Me.LBFecha)
        Me.GBDatos.Controls.Add(Me.LBAdopcion)
        Me.GBDatos.Controls.Add(Me.LFecha)
        Me.GBDatos.Controls.Add(Me.LAdopcion)
        Me.GBDatos.Location = New System.Drawing.Point(33, 48)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(459, 134)
        Me.GBDatos.TabIndex = 2
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos"
        '
        'BImprimir
        '
        Me.BImprimir.BackColor = System.Drawing.Color.Crimson
        Me.BImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BImprimir.ForeColor = System.Drawing.Color.Cornsilk
        Me.BImprimir.Location = New System.Drawing.Point(262, -36)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(191, 35)
        Me.BImprimir.TabIndex = 5
        Me.BImprimir.Text = "Imprimir comprobante"
        Me.BImprimir.UseVisualStyleBackColor = False
        '
        'LBPersonal
        '
        Me.LBPersonal.AutoSize = True
        Me.LBPersonal.Location = New System.Drawing.Point(339, 88)
        Me.LBPersonal.Name = "LBPersonal"
        Me.LBPersonal.Size = New System.Drawing.Size(47, 13)
        Me.LBPersonal.TabIndex = 7
        Me.LBPersonal.Text = "personal"
        '
        'LPersonal
        '
        Me.LPersonal.AutoSize = True
        Me.LPersonal.Location = New System.Drawing.Point(265, 88)
        Me.LPersonal.Name = "LPersonal"
        Me.LPersonal.Size = New System.Drawing.Size(68, 13)
        Me.LPersonal.TabIndex = 6
        Me.LPersonal.Text = "PERSONAL:"
        '
        'LBAdoptante
        '
        Me.LBAdoptante.AutoSize = True
        Me.LBAdoptante.Location = New System.Drawing.Point(339, 35)
        Me.LBAdoptante.Name = "LBAdoptante"
        Me.LBAdoptante.Size = New System.Drawing.Size(55, 13)
        Me.LBAdoptante.TabIndex = 5
        Me.LBAdoptante.Text = "adoptante"
        '
        'LAdoptante
        '
        Me.LAdoptante.AutoSize = True
        Me.LAdoptante.Location = New System.Drawing.Point(262, 35)
        Me.LAdoptante.Name = "LAdoptante"
        Me.LAdoptante.Size = New System.Drawing.Size(76, 13)
        Me.LAdoptante.TabIndex = 4
        Me.LAdoptante.Text = "ADOPTANTE:"
        '
        'LBFecha
        '
        Me.LBFecha.AutoSize = True
        Me.LBFecha.Location = New System.Drawing.Point(77, 88)
        Me.LBFecha.Name = "LBFecha"
        Me.LBFecha.Size = New System.Drawing.Size(34, 13)
        Me.LBFecha.TabIndex = 3
        Me.LBFecha.Text = "fecha"
        '
        'LBAdopcion
        '
        Me.LBAdopcion.AutoSize = True
        Me.LBAdopcion.Location = New System.Drawing.Point(99, 35)
        Me.LBAdopcion.Name = "LBAdopcion"
        Me.LBAdopcion.Size = New System.Drawing.Size(51, 13)
        Me.LBAdopcion.TabIndex = 2
        Me.LBAdopcion.Text = "adopcion"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Location = New System.Drawing.Point(26, 88)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(45, 13)
        Me.LFecha.TabIndex = 1
        Me.LFecha.Text = "FECHA:"
        '
        'LAdopcion
        '
        Me.LAdopcion.AutoSize = True
        Me.LAdopcion.Location = New System.Drawing.Point(23, 35)
        Me.LAdopcion.Name = "LAdopcion"
        Me.LAdopcion.Size = New System.Drawing.Size(81, 13)
        Me.LAdopcion.TabIndex = 0
        Me.LAdopcion.Text = "ADOPCION N°:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(230, 341)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(261, 23)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(327, 22)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(100, 20)
        Me.tb1.TabIndex = 5
        Me.tb1.Text = "1"
        '
        'Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 388)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.DGVDetalle)
        Me.Controls.Add(Me.GBDatos)
        Me.Name = "Detalle"
        Me.Text = "Detalle"
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents LBPersonal As System.Windows.Forms.Label
    Friend WithEvents LPersonal As System.Windows.Forms.Label
    Friend WithEvents LBAdoptante As System.Windows.Forms.Label
    Friend WithEvents LAdoptante As System.Windows.Forms.Label
    Friend WithEvents LBFecha As System.Windows.Forms.Label
    Friend WithEvents LBAdopcion As System.Windows.Forms.Label
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents LAdopcion As System.Windows.Forms.Label
    Friend WithEvents BImprimir As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
End Class
