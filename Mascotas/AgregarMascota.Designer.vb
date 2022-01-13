<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMascota
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
        Me.GBAgregarMascota = New System.Windows.Forms.GroupBox()
        Me.CBRaza = New System.Windows.Forms.ComboBox()
        Me.CBEspecie = New System.Windows.Forms.ComboBox()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TBColor = New System.Windows.Forms.TextBox()
        Me.TBSexo = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.CBHogar = New System.Windows.Forms.ComboBox()
        Me.LHogar = New System.Windows.Forms.Label()
        Me.LColor = New System.Windows.Forms.Label()
        Me.LRaza = New System.Windows.Forms.Label()
        Me.LEspecie = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.BVerificar = New System.Windows.Forms.Button()
        Me.TBVerificar = New System.Windows.Forms.TextBox()
        Me.LIdMascota = New System.Windows.Forms.Label()
        Me.GBAgregarMascota.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBAgregarMascota
        '
        Me.GBAgregarMascota.Controls.Add(Me.CBRaza)
        Me.GBAgregarMascota.Controls.Add(Me.CBEspecie)
        Me.GBAgregarMascota.Controls.Add(Me.BBorrar)
        Me.GBAgregarMascota.Controls.Add(Me.BAgregar)
        Me.GBAgregarMascota.Controls.Add(Me.TBColor)
        Me.GBAgregarMascota.Controls.Add(Me.TBSexo)
        Me.GBAgregarMascota.Controls.Add(Me.TBNombre)
        Me.GBAgregarMascota.Controls.Add(Me.CBHogar)
        Me.GBAgregarMascota.Controls.Add(Me.LHogar)
        Me.GBAgregarMascota.Controls.Add(Me.LColor)
        Me.GBAgregarMascota.Controls.Add(Me.LRaza)
        Me.GBAgregarMascota.Controls.Add(Me.LEspecie)
        Me.GBAgregarMascota.Controls.Add(Me.LSexo)
        Me.GBAgregarMascota.Controls.Add(Me.LNombre)
        Me.GBAgregarMascota.Location = New System.Drawing.Point(245, 63)
        Me.GBAgregarMascota.Name = "GBAgregarMascota"
        Me.GBAgregarMascota.Size = New System.Drawing.Size(286, 311)
        Me.GBAgregarMascota.TabIndex = 10
        Me.GBAgregarMascota.TabStop = False
        Me.GBAgregarMascota.Text = "Agregar Mascota"
        '
        'CBRaza
        '
        Me.CBRaza.FormattingEnabled = True
        Me.CBRaza.Location = New System.Drawing.Point(118, 139)
        Me.CBRaza.Name = "CBRaza"
        Me.CBRaza.Size = New System.Drawing.Size(100, 21)
        Me.CBRaza.TabIndex = 15
        '
        'CBEspecie
        '
        Me.CBEspecie.FormattingEnabled = True
        Me.CBEspecie.Location = New System.Drawing.Point(118, 104)
        Me.CBEspecie.Name = "CBEspecie"
        Me.CBEspecie.Size = New System.Drawing.Size(100, 21)
        Me.CBEspecie.TabIndex = 14
        '
        'BBorrar
        '
        Me.BBorrar.Location = New System.Drawing.Point(176, 270)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BBorrar.TabIndex = 13
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(79, 270)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BAgregar.TabIndex = 12
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'TBColor
        '
        Me.TBColor.Location = New System.Drawing.Point(118, 172)
        Me.TBColor.Name = "TBColor"
        Me.TBColor.Size = New System.Drawing.Size(100, 20)
        Me.TBColor.TabIndex = 11
        '
        'TBSexo
        '
        Me.TBSexo.Location = New System.Drawing.Point(118, 70)
        Me.TBSexo.Name = "TBSexo"
        Me.TBSexo.Size = New System.Drawing.Size(100, 20)
        Me.TBSexo.TabIndex = 8
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(118, 32)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 7
        '
        'CBHogar
        '
        Me.CBHogar.FormattingEnabled = True
        Me.CBHogar.Location = New System.Drawing.Point(118, 206)
        Me.CBHogar.Name = "CBHogar"
        Me.CBHogar.Size = New System.Drawing.Size(100, 21)
        Me.CBHogar.TabIndex = 6
        '
        'LHogar
        '
        Me.LHogar.AutoSize = True
        Me.LHogar.Location = New System.Drawing.Point(23, 206)
        Me.LHogar.Name = "LHogar"
        Me.LHogar.Size = New System.Drawing.Size(39, 13)
        Me.LHogar.TabIndex = 5
        Me.LHogar.Text = "Hogar:"
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Location = New System.Drawing.Point(20, 172)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(34, 13)
        Me.LColor.TabIndex = 4
        Me.LColor.Text = "Color:"
        '
        'LRaza
        '
        Me.LRaza.AutoSize = True
        Me.LRaza.Location = New System.Drawing.Point(20, 139)
        Me.LRaza.Name = "LRaza"
        Me.LRaza.Size = New System.Drawing.Size(35, 13)
        Me.LRaza.TabIndex = 3
        Me.LRaza.Text = "Raza:"
        '
        'LEspecie
        '
        Me.LEspecie.AutoSize = True
        Me.LEspecie.Location = New System.Drawing.Point(20, 104)
        Me.LEspecie.Name = "LEspecie"
        Me.LEspecie.Size = New System.Drawing.Size(48, 13)
        Me.LEspecie.TabIndex = 2
        Me.LEspecie.Text = "Especie:"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.Location = New System.Drawing.Point(21, 70)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(34, 13)
        Me.LSexo.TabIndex = 1
        Me.LSexo.Text = "Sexo:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(20, 32)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(47, 13)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre:"
        '
        'BVerificar
        '
        Me.BVerificar.Location = New System.Drawing.Point(102, 208)
        Me.BVerificar.Name = "BVerificar"
        Me.BVerificar.Size = New System.Drawing.Size(75, 23)
        Me.BVerificar.TabIndex = 9
        Me.BVerificar.Text = "Verificar"
        Me.BVerificar.UseVisualStyleBackColor = True
        '
        'TBVerificar
        '
        Me.TBVerificar.Location = New System.Drawing.Point(77, 171)
        Me.TBVerificar.Name = "TBVerificar"
        Me.TBVerificar.Size = New System.Drawing.Size(137, 20)
        Me.TBVerificar.TabIndex = 8
        '
        'LIdMascota
        '
        Me.LIdMascota.AutoSize = True
        Me.LIdMascota.Location = New System.Drawing.Point(77, 144)
        Me.LIdMascota.Name = "LIdMascota"
        Me.LIdMascota.Size = New System.Drawing.Size(140, 13)
        Me.LIdMascota.TabIndex = 7
        Me.LIdMascota.Text = "Identificacion de la Mascota"
        '
        'AgregarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 437)
        Me.Controls.Add(Me.GBAgregarMascota)
        Me.Controls.Add(Me.BVerificar)
        Me.Controls.Add(Me.TBVerificar)
        Me.Controls.Add(Me.LIdMascota)
        Me.Name = "AgregarMascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarMascota"
        Me.GBAgregarMascota.ResumeLayout(False)
        Me.GBAgregarMascota.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBAgregarMascota As System.Windows.Forms.GroupBox
    Friend WithEvents CBRaza As System.Windows.Forms.ComboBox
    Friend WithEvents CBEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents BBorrar As System.Windows.Forms.Button
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents TBColor As System.Windows.Forms.TextBox
    Friend WithEvents TBSexo As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents CBHogar As System.Windows.Forms.ComboBox
    Friend WithEvents LHogar As System.Windows.Forms.Label
    Friend WithEvents LColor As System.Windows.Forms.Label
    Friend WithEvents LRaza As System.Windows.Forms.Label
    Friend WithEvents LEspecie As System.Windows.Forms.Label
    Friend WithEvents LSexo As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents BVerificar As System.Windows.Forms.Button
    Friend WithEvents TBVerificar As System.Windows.Forms.TextBox
    Friend WithEvents LIdMascota As System.Windows.Forms.Label
End Class
