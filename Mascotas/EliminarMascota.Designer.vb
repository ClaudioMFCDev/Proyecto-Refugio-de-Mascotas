<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarMascota
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
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.GBEliminarMascota = New System.Windows.Forms.GroupBox()
        Me.BEliminarMascota = New System.Windows.Forms.Button()
        Me.TBHogar = New System.Windows.Forms.TextBox()
        Me.TBColor = New System.Windows.Forms.TextBox()
        Me.TBRaza = New System.Windows.Forms.TextBox()
        Me.TBEspecie = New System.Windows.Forms.TextBox()
        Me.TBSexo = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LHogar = New System.Windows.Forms.Label()
        Me.LColor = New System.Windows.Forms.Label()
        Me.LRaza = New System.Windows.Forms.Label()
        Me.LEspecie = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.CBEliminarMascota = New System.Windows.Forms.ComboBox()
        Me.LEliminarMascota = New System.Windows.Forms.Label()
        Me.GBEliminarMascota.SuspendLayout()
        Me.SuspendLayout()
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(243, 384)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 47
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(134, 384)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(88, 23)
        Me.BCancelar.TabIndex = 46
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'GBEliminarMascota
        '
        Me.GBEliminarMascota.Controls.Add(Me.BEliminarMascota)
        Me.GBEliminarMascota.Controls.Add(Me.TBHogar)
        Me.GBEliminarMascota.Controls.Add(Me.TBColor)
        Me.GBEliminarMascota.Controls.Add(Me.TBRaza)
        Me.GBEliminarMascota.Controls.Add(Me.TBEspecie)
        Me.GBEliminarMascota.Controls.Add(Me.TBSexo)
        Me.GBEliminarMascota.Controls.Add(Me.TBNombre)
        Me.GBEliminarMascota.Controls.Add(Me.LHogar)
        Me.GBEliminarMascota.Controls.Add(Me.LColor)
        Me.GBEliminarMascota.Controls.Add(Me.LRaza)
        Me.GBEliminarMascota.Controls.Add(Me.LEspecie)
        Me.GBEliminarMascota.Controls.Add(Me.LSexo)
        Me.GBEliminarMascota.Controls.Add(Me.LNombre)
        Me.GBEliminarMascota.Location = New System.Drawing.Point(85, 73)
        Me.GBEliminarMascota.Name = "GBEliminarMascota"
        Me.GBEliminarMascota.Size = New System.Drawing.Size(270, 305)
        Me.GBEliminarMascota.TabIndex = 45
        Me.GBEliminarMascota.TabStop = False
        Me.GBEliminarMascota.Text = "Eliminar Mascota"
        '
        'BEliminarMascota
        '
        Me.BEliminarMascota.Location = New System.Drawing.Point(107, 263)
        Me.BEliminarMascota.Name = "BEliminarMascota"
        Me.BEliminarMascota.Size = New System.Drawing.Size(130, 23)
        Me.BEliminarMascota.TabIndex = 12
        Me.BEliminarMascota.Text = "Eliminar Mascota"
        Me.BEliminarMascota.UseVisualStyleBackColor = True
        '
        'TBHogar
        '
        Me.TBHogar.Location = New System.Drawing.Point(107, 217)
        Me.TBHogar.Name = "TBHogar"
        Me.TBHogar.Size = New System.Drawing.Size(130, 20)
        Me.TBHogar.TabIndex = 11
        '
        'TBColor
        '
        Me.TBColor.Location = New System.Drawing.Point(107, 182)
        Me.TBColor.Name = "TBColor"
        Me.TBColor.Size = New System.Drawing.Size(130, 20)
        Me.TBColor.TabIndex = 10
        '
        'TBRaza
        '
        Me.TBRaza.Location = New System.Drawing.Point(107, 147)
        Me.TBRaza.Name = "TBRaza"
        Me.TBRaza.Size = New System.Drawing.Size(130, 20)
        Me.TBRaza.TabIndex = 9
        '
        'TBEspecie
        '
        Me.TBEspecie.Location = New System.Drawing.Point(107, 111)
        Me.TBEspecie.Name = "TBEspecie"
        Me.TBEspecie.Size = New System.Drawing.Size(130, 20)
        Me.TBEspecie.TabIndex = 8
        '
        'TBSexo
        '
        Me.TBSexo.Location = New System.Drawing.Point(107, 77)
        Me.TBSexo.Name = "TBSexo"
        Me.TBSexo.Size = New System.Drawing.Size(130, 20)
        Me.TBSexo.TabIndex = 7
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(107, 40)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(130, 20)
        Me.TBNombre.TabIndex = 6
        '
        'LHogar
        '
        Me.LHogar.AutoSize = True
        Me.LHogar.Location = New System.Drawing.Point(21, 217)
        Me.LHogar.Name = "LHogar"
        Me.LHogar.Size = New System.Drawing.Size(36, 13)
        Me.LHogar.TabIndex = 5
        Me.LHogar.Text = "Hogar"
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Location = New System.Drawing.Point(21, 182)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(31, 13)
        Me.LColor.TabIndex = 4
        Me.LColor.Text = "Color"
        '
        'LRaza
        '
        Me.LRaza.AutoSize = True
        Me.LRaza.Location = New System.Drawing.Point(21, 147)
        Me.LRaza.Name = "LRaza"
        Me.LRaza.Size = New System.Drawing.Size(32, 13)
        Me.LRaza.TabIndex = 3
        Me.LRaza.Text = "Raza"
        '
        'LEspecie
        '
        Me.LEspecie.AutoSize = True
        Me.LEspecie.Location = New System.Drawing.Point(21, 111)
        Me.LEspecie.Name = "LEspecie"
        Me.LEspecie.Size = New System.Drawing.Size(45, 13)
        Me.LEspecie.TabIndex = 2
        Me.LEspecie.Text = "Especie"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.Location = New System.Drawing.Point(21, 77)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(31, 13)
        Me.LSexo.TabIndex = 1
        Me.LSexo.Text = "Sexo"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(21, 40)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre"
        '
        'CBEliminarMascota
        '
        Me.CBEliminarMascota.FormattingEnabled = True
        Me.CBEliminarMascota.Location = New System.Drawing.Point(85, 46)
        Me.CBEliminarMascota.Name = "CBEliminarMascota"
        Me.CBEliminarMascota.Size = New System.Drawing.Size(270, 21)
        Me.CBEliminarMascota.TabIndex = 44
        '
        'LEliminarMascota
        '
        Me.LEliminarMascota.Location = New System.Drawing.Point(167, 9)
        Me.LEliminarMascota.Name = "LEliminarMascota"
        Me.LEliminarMascota.Size = New System.Drawing.Size(113, 34)
        Me.LEliminarMascota.TabIndex = 43
        Me.LEliminarMascota.Text = "Seleccione la Mascota a Eliminar"
        Me.LEliminarMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EliminarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 416)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.GBEliminarMascota)
        Me.Controls.Add(Me.CBEliminarMascota)
        Me.Controls.Add(Me.LEliminarMascota)
        Me.Name = "EliminarMascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EliminarMascota"
        Me.GBEliminarMascota.ResumeLayout(False)
        Me.GBEliminarMascota.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents GBEliminarMascota As System.Windows.Forms.GroupBox
    Friend WithEvents BEliminarMascota As System.Windows.Forms.Button
    Friend WithEvents TBHogar As System.Windows.Forms.TextBox
    Friend WithEvents TBColor As System.Windows.Forms.TextBox
    Friend WithEvents TBRaza As System.Windows.Forms.TextBox
    Friend WithEvents TBEspecie As System.Windows.Forms.TextBox
    Friend WithEvents TBSexo As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents LHogar As System.Windows.Forms.Label
    Friend WithEvents LColor As System.Windows.Forms.Label
    Friend WithEvents LRaza As System.Windows.Forms.Label
    Friend WithEvents LEspecie As System.Windows.Forms.Label
    Friend WithEvents LSexo As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents CBEliminarMascota As System.Windows.Forms.ComboBox
    Friend WithEvents LEliminarMascota As System.Windows.Forms.Label
End Class
