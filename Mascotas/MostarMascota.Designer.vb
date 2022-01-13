<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MostarMascota
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
        Me.DGVFiltros = New System.Windows.Forms.DataGridView()
        Me.GBFiltros = New System.Windows.Forms.GroupBox()
        Me.CBEspecie = New System.Windows.Forms.ComboBox()
        Me.RBTodasMascotas = New System.Windows.Forms.RadioButton()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.CBHogar = New System.Windows.Forms.ComboBox()
        Me.RBNombre = New System.Windows.Forms.RadioButton()
        Me.RBEspecie = New System.Windows.Forms.RadioButton()
        Me.RBHogar = New System.Windows.Forms.RadioButton()
        CType(Me.DGVFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVFiltros
        '
        Me.DGVFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFiltros.Location = New System.Drawing.Point(43, 222)
        Me.DGVFiltros.Name = "DGVFiltros"
        Me.DGVFiltros.Size = New System.Drawing.Size(537, 126)
        Me.DGVFiltros.TabIndex = 4
        '
        'GBFiltros
        '
        Me.GBFiltros.Controls.Add(Me.CBEspecie)
        Me.GBFiltros.Controls.Add(Me.RBTodasMascotas)
        Me.GBFiltros.Controls.Add(Me.TBNombre)
        Me.GBFiltros.Controls.Add(Me.CBHogar)
        Me.GBFiltros.Controls.Add(Me.RBNombre)
        Me.GBFiltros.Controls.Add(Me.RBEspecie)
        Me.GBFiltros.Controls.Add(Me.RBHogar)
        Me.GBFiltros.Location = New System.Drawing.Point(158, 55)
        Me.GBFiltros.Name = "GBFiltros"
        Me.GBFiltros.Size = New System.Drawing.Size(263, 138)
        Me.GBFiltros.TabIndex = 3
        Me.GBFiltros.TabStop = False
        Me.GBFiltros.Text = "Filtros"
        '
        'CBEspecie
        '
        Me.CBEspecie.FormattingEnabled = True
        Me.CBEspecie.Location = New System.Drawing.Point(110, 48)
        Me.CBEspecie.Name = "CBEspecie"
        Me.CBEspecie.Size = New System.Drawing.Size(121, 21)
        Me.CBEspecie.TabIndex = 7
        '
        'RBTodasMascotas
        '
        Me.RBTodasMascotas.AutoSize = True
        Me.RBTodasMascotas.Location = New System.Drawing.Point(75, 115)
        Me.RBTodasMascotas.Name = "RBTodasMascotas"
        Me.RBTodasMascotas.Size = New System.Drawing.Size(124, 17)
        Me.RBTodasMascotas.TabIndex = 6
        Me.RBTodasMascotas.TabStop = True
        Me.RBTodasMascotas.Text = "Todas Las Mascotas"
        Me.RBTodasMascotas.UseVisualStyleBackColor = True
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(110, 76)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(121, 20)
        Me.TBNombre.TabIndex = 5
        '
        'CBHogar
        '
        Me.CBHogar.FormattingEnabled = True
        Me.CBHogar.Location = New System.Drawing.Point(110, 20)
        Me.CBHogar.Name = "CBHogar"
        Me.CBHogar.Size = New System.Drawing.Size(121, 21)
        Me.CBHogar.TabIndex = 3
        '
        'RBNombre
        '
        Me.RBNombre.AutoSize = True
        Me.RBNombre.Location = New System.Drawing.Point(6, 76)
        Me.RBNombre.Name = "RBNombre"
        Me.RBNombre.Size = New System.Drawing.Size(62, 17)
        Me.RBNombre.TabIndex = 2
        Me.RBNombre.TabStop = True
        Me.RBNombre.Text = "Nombre"
        Me.RBNombre.UseVisualStyleBackColor = True
        '
        'RBEspecie
        '
        Me.RBEspecie.AutoSize = True
        Me.RBEspecie.Location = New System.Drawing.Point(6, 48)
        Me.RBEspecie.Name = "RBEspecie"
        Me.RBEspecie.Size = New System.Drawing.Size(63, 17)
        Me.RBEspecie.TabIndex = 1
        Me.RBEspecie.TabStop = True
        Me.RBEspecie.Text = "Especie"
        Me.RBEspecie.UseVisualStyleBackColor = True
        '
        'RBHogar
        '
        Me.RBHogar.AutoSize = True
        Me.RBHogar.Location = New System.Drawing.Point(6, 20)
        Me.RBHogar.Name = "RBHogar"
        Me.RBHogar.Size = New System.Drawing.Size(54, 17)
        Me.RBHogar.TabIndex = 0
        Me.RBHogar.TabStop = True
        Me.RBHogar.Text = "Hogar"
        Me.RBHogar.UseVisualStyleBackColor = True
        '
        'MostarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 403)
        Me.Controls.Add(Me.DGVFiltros)
        Me.Controls.Add(Me.GBFiltros)
        Me.Name = "MostarMascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MostarMascota"
        CType(Me.DGVFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFiltros.ResumeLayout(False)
        Me.GBFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVFiltros As System.Windows.Forms.DataGridView
    Friend WithEvents GBFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents CBEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents RBTodasMascotas As System.Windows.Forms.RadioButton
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents CBHogar As System.Windows.Forms.ComboBox
    Friend WithEvents RBNombre As System.Windows.Forms.RadioButton
    Friend WithEvents RBEspecie As System.Windows.Forms.RadioButton
    Friend WithEvents RBHogar As System.Windows.Forms.RadioButton
End Class
