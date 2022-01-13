<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarMascota
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
        Me.GBModificarMascota = New System.Windows.Forms.GroupBox()
        Me.CBRaza = New System.Windows.Forms.ComboBox()
        Me.CBEspecie = New System.Windows.Forms.ComboBox()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.BModificarMascota = New System.Windows.Forms.Button()
        Me.CBHogar = New System.Windows.Forms.ComboBox()
        Me.LHogar = New System.Windows.Forms.Label()
        Me.TBColor = New System.Windows.Forms.TextBox()
        Me.LColor = New System.Windows.Forms.Label()
        Me.LRaza = New System.Windows.Forms.Label()
        Me.LBEspecie = New System.Windows.Forms.Label()
        Me.TBSexo = New System.Windows.Forms.TextBox()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.CBModificarMascota = New System.Windows.Forms.ComboBox()
        Me.LModificaMascota = New System.Windows.Forms.Label()
        Me.GBModificarMascota.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBModificarMascota
        '
        Me.GBModificarMascota.Controls.Add(Me.CBRaza)
        Me.GBModificarMascota.Controls.Add(Me.CBEspecie)
        Me.GBModificarMascota.Controls.Add(Me.BBorrar)
        Me.GBModificarMascota.Controls.Add(Me.BModificarMascota)
        Me.GBModificarMascota.Controls.Add(Me.CBHogar)
        Me.GBModificarMascota.Controls.Add(Me.LHogar)
        Me.GBModificarMascota.Controls.Add(Me.TBColor)
        Me.GBModificarMascota.Controls.Add(Me.LColor)
        Me.GBModificarMascota.Controls.Add(Me.LRaza)
        Me.GBModificarMascota.Controls.Add(Me.LBEspecie)
        Me.GBModificarMascota.Controls.Add(Me.TBSexo)
        Me.GBModificarMascota.Controls.Add(Me.LSexo)
        Me.GBModificarMascota.Controls.Add(Me.TBNombre)
        Me.GBModificarMascota.Controls.Add(Me.LNombre)
        Me.GBModificarMascota.Location = New System.Drawing.Point(31, 89)
        Me.GBModificarMascota.Name = "GBModificarMascota"
        Me.GBModificarMascota.Size = New System.Drawing.Size(284, 305)
        Me.GBModificarMascota.TabIndex = 7
        Me.GBModificarMascota.TabStop = False
        Me.GBModificarMascota.Text = "Modificar Mascota"
        '
        'CBRaza
        '
        Me.CBRaza.FormattingEnabled = True
        Me.CBRaza.Location = New System.Drawing.Point(83, 138)
        Me.CBRaza.Name = "CBRaza"
        Me.CBRaza.Size = New System.Drawing.Size(166, 21)
        Me.CBRaza.TabIndex = 15
        '
        'CBEspecie
        '
        Me.CBEspecie.FormattingEnabled = True
        Me.CBEspecie.Location = New System.Drawing.Point(83, 107)
        Me.CBEspecie.Name = "CBEspecie"
        Me.CBEspecie.Size = New System.Drawing.Size(166, 21)
        Me.CBEspecie.TabIndex = 14
        '
        'BBorrar
        '
        Me.BBorrar.Location = New System.Drawing.Point(174, 251)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BBorrar.TabIndex = 13
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = True
        '
        'BModificarMascota
        '
        Me.BModificarMascota.Location = New System.Drawing.Point(83, 251)
        Me.BModificarMascota.Name = "BModificarMascota"
        Me.BModificarMascota.Size = New System.Drawing.Size(75, 23)
        Me.BModificarMascota.TabIndex = 12
        Me.BModificarMascota.Text = "Modificar"
        Me.BModificarMascota.UseVisualStyleBackColor = True
        '
        'CBHogar
        '
        Me.CBHogar.FormattingEnabled = True
        Me.CBHogar.Location = New System.Drawing.Point(83, 208)
        Me.CBHogar.Name = "CBHogar"
        Me.CBHogar.Size = New System.Drawing.Size(166, 21)
        Me.CBHogar.TabIndex = 11
        '
        'LHogar
        '
        Me.LHogar.AutoSize = True
        Me.LHogar.Location = New System.Drawing.Point(19, 208)
        Me.LHogar.Name = "LHogar"
        Me.LHogar.Size = New System.Drawing.Size(36, 13)
        Me.LHogar.TabIndex = 10
        Me.LHogar.Text = "Hogar"
        '
        'TBColor
        '
        Me.TBColor.Location = New System.Drawing.Point(83, 173)
        Me.TBColor.Name = "TBColor"
        Me.TBColor.Size = New System.Drawing.Size(166, 20)
        Me.TBColor.TabIndex = 9
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Location = New System.Drawing.Point(19, 173)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(34, 13)
        Me.LColor.TabIndex = 8
        Me.LColor.Text = "Color:"
        '
        'LRaza
        '
        Me.LRaza.AutoSize = True
        Me.LRaza.Location = New System.Drawing.Point(19, 141)
        Me.LRaza.Name = "LRaza"
        Me.LRaza.Size = New System.Drawing.Size(35, 13)
        Me.LRaza.TabIndex = 6
        Me.LRaza.Text = "Raza:"
        '
        'LBEspecie
        '
        Me.LBEspecie.AutoSize = True
        Me.LBEspecie.Location = New System.Drawing.Point(19, 107)
        Me.LBEspecie.Name = "LBEspecie"
        Me.LBEspecie.Size = New System.Drawing.Size(48, 13)
        Me.LBEspecie.TabIndex = 4
        Me.LBEspecie.Text = "Especie:"
        '
        'TBSexo
        '
        Me.TBSexo.Location = New System.Drawing.Point(83, 72)
        Me.TBSexo.Name = "TBSexo"
        Me.TBSexo.Size = New System.Drawing.Size(166, 20)
        Me.TBSexo.TabIndex = 3
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.Location = New System.Drawing.Point(19, 72)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(34, 13)
        Me.LSexo.TabIndex = 2
        Me.LSexo.Text = "Sexo:"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(83, 36)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(166, 20)
        Me.TBNombre.TabIndex = 1
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(19, 36)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(47, 13)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre:"
        '
        'CBModificarMascota
        '
        Me.CBModificarMascota.FormattingEnabled = True
        Me.CBModificarMascota.Location = New System.Drawing.Point(71, 51)
        Me.CBModificarMascota.Name = "CBModificarMascota"
        Me.CBModificarMascota.Size = New System.Drawing.Size(210, 21)
        Me.CBModificarMascota.TabIndex = 6
        '
        'LModificaMascota
        '
        Me.LModificaMascota.AutoSize = True
        Me.LModificaMascota.Location = New System.Drawing.Point(68, 23)
        Me.LModificaMascota.Name = "LModificaMascota"
        Me.LModificaMascota.Size = New System.Drawing.Size(213, 13)
        Me.LModificaMascota.TabIndex = 5
        Me.LModificaMascota.Text = "Seleccione la Mascota que desea modificar"
        '
        'ModificarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 375)
        Me.Controls.Add(Me.GBModificarMascota)
        Me.Controls.Add(Me.CBModificarMascota)
        Me.Controls.Add(Me.LModificaMascota)
        Me.Name = "ModificarMascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarMascota"
        Me.GBModificarMascota.ResumeLayout(False)
        Me.GBModificarMascota.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBModificarMascota As System.Windows.Forms.GroupBox
    Friend WithEvents CBRaza As System.Windows.Forms.ComboBox
    Friend WithEvents CBEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents BBorrar As System.Windows.Forms.Button
    Friend WithEvents BModificarMascota As System.Windows.Forms.Button
    Friend WithEvents CBHogar As System.Windows.Forms.ComboBox
    Friend WithEvents LHogar As System.Windows.Forms.Label
    Friend WithEvents TBColor As System.Windows.Forms.TextBox
    Friend WithEvents LColor As System.Windows.Forms.Label
    Friend WithEvents LRaza As System.Windows.Forms.Label
    Friend WithEvents LBEspecie As System.Windows.Forms.Label
    Friend WithEvents TBSexo As System.Windows.Forms.TextBox
    Friend WithEvents LSexo As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents CBModificarMascota As System.Windows.Forms.ComboBox
    Friend WithEvents LModificaMascota As System.Windows.Forms.Label
End Class
