<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarAdopcion
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
        Me.BConfirmarAdopcion = New System.Windows.Forms.Button()
        Me.GBDetalle = New System.Windows.Forms.GroupBox()
        Me.BEliminarMascota = New System.Windows.Forms.Button()
        Me.DGVDetalleAdopcion = New System.Windows.Forms.DataGridView()
        Me.GBMascotas = New System.Windows.Forms.GroupBox()
        Me.LHogar = New System.Windows.Forms.Label()
        Me.LBHogar = New System.Windows.Forms.Label()
        Me.LColor = New System.Windows.Forms.Label()
        Me.LBColor = New System.Windows.Forms.Label()
        Me.BAregar = New System.Windows.Forms.Button()
        Me.GBBuscador = New System.Windows.Forms.GroupBox()
        Me.TBBuscador = New System.Windows.Forms.TextBox()
        Me.LBBuscador = New System.Windows.Forms.Label()
        Me.DGVMascotas = New System.Windows.Forms.DataGridView()
        Me.LRaza = New System.Windows.Forms.Label()
        Me.LEspecie = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LIdentificacion = New System.Windows.Forms.Label()
        Me.LBRaza = New System.Windows.Forms.Label()
        Me.LBEspecie = New System.Windows.Forms.Label()
        Me.LBSexo = New System.Windows.Forms.Label()
        Me.LBNombre = New System.Windows.Forms.Label()
        Me.LBidentificacion = New System.Windows.Forms.Label()
        Me.GBCabecera = New System.Windows.Forms.GroupBox()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.CBAdoptante = New System.Windows.Forms.ComboBox()
        Me.LAdoptante = New System.Windows.Forms.Label()
        Me.LBPersonal = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LPersonal = New System.Windows.Forms.Label()
        Me.GBDetalle.SuspendLayout()
        CType(Me.DGVDetalleAdopcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBMascotas.SuspendLayout()
        Me.GBBuscador.SuspendLayout()
        CType(Me.DGVMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'BConfirmarAdopcion
        '
        Me.BConfirmarAdopcion.Location = New System.Drawing.Point(469, 581)
        Me.BConfirmarAdopcion.Name = "BConfirmarAdopcion"
        Me.BConfirmarAdopcion.Size = New System.Drawing.Size(75, 38)
        Me.BConfirmarAdopcion.TabIndex = 8
        Me.BConfirmarAdopcion.Text = "Confirmar Adopcion"
        Me.BConfirmarAdopcion.UseVisualStyleBackColor = True
        '
        'GBDetalle
        '
        Me.GBDetalle.Controls.Add(Me.BEliminarMascota)
        Me.GBDetalle.Controls.Add(Me.DGVDetalleAdopcion)
        Me.GBDetalle.Location = New System.Drawing.Point(5, 398)
        Me.GBDetalle.Name = "GBDetalle"
        Me.GBDetalle.Size = New System.Drawing.Size(442, 227)
        Me.GBDetalle.TabIndex = 7
        Me.GBDetalle.TabStop = False
        Me.GBDetalle.Text = "Detalle Adopcion"
        '
        'BEliminarMascota
        '
        Me.BEliminarMascota.Location = New System.Drawing.Point(28, 198)
        Me.BEliminarMascota.Name = "BEliminarMascota"
        Me.BEliminarMascota.Size = New System.Drawing.Size(123, 23)
        Me.BEliminarMascota.TabIndex = 1
        Me.BEliminarMascota.Text = "Eliminar Mascota"
        Me.BEliminarMascota.UseVisualStyleBackColor = True
        '
        'DGVDetalleAdopcion
        '
        Me.DGVDetalleAdopcion.AllowUserToAddRows = False
        Me.DGVDetalleAdopcion.AllowUserToDeleteRows = False
        Me.DGVDetalleAdopcion.AllowUserToResizeRows = False
        Me.DGVDetalleAdopcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalleAdopcion.Location = New System.Drawing.Point(6, 28)
        Me.DGVDetalleAdopcion.Name = "DGVDetalleAdopcion"
        Me.DGVDetalleAdopcion.Size = New System.Drawing.Size(424, 150)
        Me.DGVDetalleAdopcion.TabIndex = 0
        '
        'GBMascotas
        '
        Me.GBMascotas.Controls.Add(Me.LHogar)
        Me.GBMascotas.Controls.Add(Me.LBHogar)
        Me.GBMascotas.Controls.Add(Me.LColor)
        Me.GBMascotas.Controls.Add(Me.LBColor)
        Me.GBMascotas.Controls.Add(Me.BAregar)
        Me.GBMascotas.Controls.Add(Me.GBBuscador)
        Me.GBMascotas.Controls.Add(Me.DGVMascotas)
        Me.GBMascotas.Controls.Add(Me.LRaza)
        Me.GBMascotas.Controls.Add(Me.LEspecie)
        Me.GBMascotas.Controls.Add(Me.LSexo)
        Me.GBMascotas.Controls.Add(Me.LNombre)
        Me.GBMascotas.Controls.Add(Me.LIdentificacion)
        Me.GBMascotas.Controls.Add(Me.LBRaza)
        Me.GBMascotas.Controls.Add(Me.LBEspecie)
        Me.GBMascotas.Controls.Add(Me.LBSexo)
        Me.GBMascotas.Controls.Add(Me.LBNombre)
        Me.GBMascotas.Controls.Add(Me.LBidentificacion)
        Me.GBMascotas.Location = New System.Drawing.Point(5, 102)
        Me.GBMascotas.Name = "GBMascotas"
        Me.GBMascotas.Size = New System.Drawing.Size(707, 258)
        Me.GBMascotas.TabIndex = 6
        Me.GBMascotas.TabStop = False
        Me.GBMascotas.Text = "Buscador de Mascotas"
        '
        'LHogar
        '
        Me.LHogar.AutoSize = True
        Me.LHogar.Location = New System.Drawing.Point(55, 192)
        Me.LHogar.Name = "LHogar"
        Me.LHogar.Size = New System.Drawing.Size(36, 13)
        Me.LHogar.TabIndex = 16
        Me.LHogar.Text = "Hogar"
        '
        'LBHogar
        '
        Me.LBHogar.AutoSize = True
        Me.LBHogar.Location = New System.Drawing.Point(11, 192)
        Me.LBHogar.Name = "LBHogar"
        Me.LBHogar.Size = New System.Drawing.Size(39, 13)
        Me.LBHogar.TabIndex = 15
        Me.LBHogar.Text = "Hogar:"
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Location = New System.Drawing.Point(52, 167)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(31, 13)
        Me.LColor.TabIndex = 14
        Me.LColor.Text = "Color"
        '
        'LBColor
        '
        Me.LBColor.AutoSize = True
        Me.LBColor.Location = New System.Drawing.Point(11, 167)
        Me.LBColor.Name = "LBColor"
        Me.LBColor.Size = New System.Drawing.Size(34, 13)
        Me.LBColor.TabIndex = 13
        Me.LBColor.Text = "Color:"
        '
        'BAregar
        '
        Me.BAregar.Location = New System.Drawing.Point(479, 192)
        Me.BAregar.Name = "BAregar"
        Me.BAregar.Size = New System.Drawing.Size(75, 40)
        Me.BAregar.TabIndex = 12
        Me.BAregar.Text = "Agregar Mascota"
        Me.BAregar.UseVisualStyleBackColor = True
        '
        'GBBuscador
        '
        Me.GBBuscador.Controls.Add(Me.TBBuscador)
        Me.GBBuscador.Controls.Add(Me.LBBuscador)
        Me.GBBuscador.Location = New System.Drawing.Point(206, 176)
        Me.GBBuscador.Name = "GBBuscador"
        Me.GBBuscador.Size = New System.Drawing.Size(171, 62)
        Me.GBBuscador.TabIndex = 11
        Me.GBBuscador.TabStop = False
        '
        'TBBuscador
        '
        Me.TBBuscador.Location = New System.Drawing.Point(24, 36)
        Me.TBBuscador.Name = "TBBuscador"
        Me.TBBuscador.Size = New System.Drawing.Size(132, 20)
        Me.TBBuscador.TabIndex = 1
        '
        'LBBuscador
        '
        Me.LBBuscador.AutoSize = True
        Me.LBBuscador.Location = New System.Drawing.Point(37, 16)
        Me.LBBuscador.Name = "LBBuscador"
        Me.LBBuscador.Size = New System.Drawing.Size(98, 13)
        Me.LBBuscador.TabIndex = 0
        Me.LBBuscador.Text = "Buscar por Nombre"
        '
        'DGVMascotas
        '
        Me.DGVMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMascotas.Location = New System.Drawing.Point(206, 33)
        Me.DGVMascotas.Name = "DGVMascotas"
        Me.DGVMascotas.Size = New System.Drawing.Size(480, 121)
        Me.DGVMascotas.TabIndex = 10
        '
        'LRaza
        '
        Me.LRaza.AutoSize = True
        Me.LRaza.Location = New System.Drawing.Point(56, 141)
        Me.LRaza.Name = "LRaza"
        Me.LRaza.Size = New System.Drawing.Size(32, 13)
        Me.LRaza.TabIndex = 9
        Me.LRaza.Text = "Raza"
        '
        'LEspecie
        '
        Me.LEspecie.AutoSize = True
        Me.LEspecie.Location = New System.Drawing.Point(65, 113)
        Me.LEspecie.Name = "LEspecie"
        Me.LEspecie.Size = New System.Drawing.Size(45, 13)
        Me.LEspecie.TabIndex = 8
        Me.LEspecie.Text = "Especie"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.Location = New System.Drawing.Point(52, 87)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(31, 13)
        Me.LSexo.TabIndex = 7
        Me.LSexo.Text = "Sexo"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(65, 59)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 6
        Me.LNombre.Text = "Nombre"
        '
        'LIdentificacion
        '
        Me.LIdentificacion.AutoSize = True
        Me.LIdentificacion.Location = New System.Drawing.Point(90, 33)
        Me.LIdentificacion.Name = "LIdentificacion"
        Me.LIdentificacion.Size = New System.Drawing.Size(13, 13)
        Me.LIdentificacion.TabIndex = 5
        Me.LIdentificacion.Text = "0"
        '
        'LBRaza
        '
        Me.LBRaza.AutoSize = True
        Me.LBRaza.Location = New System.Drawing.Point(11, 141)
        Me.LBRaza.Name = "LBRaza"
        Me.LBRaza.Size = New System.Drawing.Size(35, 13)
        Me.LBRaza.TabIndex = 4
        Me.LBRaza.Text = "Raza:"
        '
        'LBEspecie
        '
        Me.LBEspecie.AutoSize = True
        Me.LBEspecie.Location = New System.Drawing.Point(11, 113)
        Me.LBEspecie.Name = "LBEspecie"
        Me.LBEspecie.Size = New System.Drawing.Size(48, 13)
        Me.LBEspecie.TabIndex = 3
        Me.LBEspecie.Text = "Especie:"
        '
        'LBSexo
        '
        Me.LBSexo.AutoSize = True
        Me.LBSexo.Location = New System.Drawing.Point(11, 87)
        Me.LBSexo.Name = "LBSexo"
        Me.LBSexo.Size = New System.Drawing.Size(34, 13)
        Me.LBSexo.TabIndex = 2
        Me.LBSexo.Text = "Sexo:"
        '
        'LBNombre
        '
        Me.LBNombre.AutoSize = True
        Me.LBNombre.Location = New System.Drawing.Point(11, 59)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(47, 13)
        Me.LBNombre.TabIndex = 1
        Me.LBNombre.Text = "Nombre:"
        '
        'LBidentificacion
        '
        Me.LBidentificacion.AutoSize = True
        Me.LBidentificacion.Location = New System.Drawing.Point(11, 33)
        Me.LBidentificacion.Name = "LBidentificacion"
        Me.LBidentificacion.Size = New System.Drawing.Size(72, 13)
        Me.LBidentificacion.TabIndex = 0
        Me.LBidentificacion.Text = "identificacion:"
        '
        'GBCabecera
        '
        Me.GBCabecera.Controls.Add(Me.DTPFecha)
        Me.GBCabecera.Controls.Add(Me.CBAdoptante)
        Me.GBCabecera.Controls.Add(Me.LAdoptante)
        Me.GBCabecera.Controls.Add(Me.LBPersonal)
        Me.GBCabecera.Controls.Add(Me.LFecha)
        Me.GBCabecera.Controls.Add(Me.LPersonal)
        Me.GBCabecera.Location = New System.Drawing.Point(5, 5)
        Me.GBCabecera.Name = "GBCabecera"
        Me.GBCabecera.Size = New System.Drawing.Size(707, 65)
        Me.GBCabecera.TabIndex = 5
        Me.GBCabecera.TabStop = False
        Me.GBCabecera.Text = "DatosCabecera"
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(230, 22)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecha.TabIndex = 6
        '
        'CBAdoptante
        '
        Me.CBAdoptante.FormattingEnabled = True
        Me.CBAdoptante.Location = New System.Drawing.Point(543, 25)
        Me.CBAdoptante.Name = "CBAdoptante"
        Me.CBAdoptante.Size = New System.Drawing.Size(143, 21)
        Me.CBAdoptante.TabIndex = 5
        '
        'LAdoptante
        '
        Me.LAdoptante.AutoSize = True
        Me.LAdoptante.Location = New System.Drawing.Point(461, 25)
        Me.LAdoptante.Name = "LAdoptante"
        Me.LAdoptante.Size = New System.Drawing.Size(59, 13)
        Me.LAdoptante.TabIndex = 4
        Me.LAdoptante.Text = "Adoptante:"
        '
        'LBPersonal
        '
        Me.LBPersonal.AutoSize = True
        Me.LBPersonal.Location = New System.Drawing.Point(66, 25)
        Me.LBPersonal.Name = "LBPersonal"
        Me.LBPersonal.Size = New System.Drawing.Size(48, 13)
        Me.LBPersonal.TabIndex = 3
        Me.LBPersonal.Text = "Personal"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Location = New System.Drawing.Point(187, 25)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(37, 13)
        Me.LFecha.TabIndex = 1
        Me.LFecha.Text = "Fecha"
        '
        'LPersonal
        '
        Me.LPersonal.AutoSize = True
        Me.LPersonal.Location = New System.Drawing.Point(8, 25)
        Me.LPersonal.Name = "LPersonal"
        Me.LPersonal.Size = New System.Drawing.Size(51, 13)
        Me.LPersonal.TabIndex = 0
        Me.LPersonal.Text = "Personal:"
        '
        'GenerarAdopcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 651)
        Me.Controls.Add(Me.BConfirmarAdopcion)
        Me.Controls.Add(Me.GBDetalle)
        Me.Controls.Add(Me.GBMascotas)
        Me.Controls.Add(Me.GBCabecera)
        Me.Name = "GenerarAdopcion"
        Me.Text = "GenerarAdopcion"
        Me.GBDetalle.ResumeLayout(False)
        CType(Me.DGVDetalleAdopcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBMascotas.ResumeLayout(False)
        Me.GBMascotas.PerformLayout()
        Me.GBBuscador.ResumeLayout(False)
        Me.GBBuscador.PerformLayout()
        CType(Me.DGVMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCabecera.ResumeLayout(False)
        Me.GBCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BConfirmarAdopcion As System.Windows.Forms.Button
    Friend WithEvents GBDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents BEliminarMascota As System.Windows.Forms.Button
    Friend WithEvents DGVDetalleAdopcion As System.Windows.Forms.DataGridView
    Friend WithEvents GBMascotas As System.Windows.Forms.GroupBox
    Friend WithEvents LHogar As System.Windows.Forms.Label
    Friend WithEvents LBHogar As System.Windows.Forms.Label
    Friend WithEvents LColor As System.Windows.Forms.Label
    Friend WithEvents LBColor As System.Windows.Forms.Label
    Friend WithEvents BAregar As System.Windows.Forms.Button
    Friend WithEvents GBBuscador As System.Windows.Forms.GroupBox
    Friend WithEvents TBBuscador As System.Windows.Forms.TextBox
    Friend WithEvents LBBuscador As System.Windows.Forms.Label
    Friend WithEvents DGVMascotas As System.Windows.Forms.DataGridView
    Friend WithEvents LRaza As System.Windows.Forms.Label
    Friend WithEvents LEspecie As System.Windows.Forms.Label
    Friend WithEvents LSexo As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LIdentificacion As System.Windows.Forms.Label
    Friend WithEvents LBRaza As System.Windows.Forms.Label
    Friend WithEvents LBEspecie As System.Windows.Forms.Label
    Friend WithEvents LBSexo As System.Windows.Forms.Label
    Friend WithEvents LBNombre As System.Windows.Forms.Label
    Friend WithEvents LBidentificacion As System.Windows.Forms.Label
    Friend WithEvents GBCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBAdoptante As System.Windows.Forms.ComboBox
    Friend WithEvents LAdoptante As System.Windows.Forms.Label
    Friend WithEvents LBPersonal As System.Windows.Forms.Label
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents LPersonal As System.Windows.Forms.Label
End Class
