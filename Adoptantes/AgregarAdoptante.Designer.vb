<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarAdoptante
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
        Me.GBAgregarAdoptante = New System.Windows.Forms.GroupBox()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.BVerificar = New System.Windows.Forms.Button()
        Me.TBVerificar = New System.Windows.Forms.TextBox()
        Me.LIdAdoptante = New System.Windows.Forms.Label()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.GBAgregarAdoptante.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBAgregarAdoptante
        '
        Me.GBAgregarAdoptante.Controls.Add(Me.TBTelefono)
        Me.GBAgregarAdoptante.Controls.Add(Me.BBorrar)
        Me.GBAgregarAdoptante.Controls.Add(Me.BAgregar)
        Me.GBAgregarAdoptante.Controls.Add(Me.TBEmail)
        Me.GBAgregarAdoptante.Controls.Add(Me.TBDireccion)
        Me.GBAgregarAdoptante.Controls.Add(Me.TBDni)
        Me.GBAgregarAdoptante.Controls.Add(Me.TBNombre)
        Me.GBAgregarAdoptante.Controls.Add(Me.TBApellido)
        Me.GBAgregarAdoptante.Controls.Add(Me.LTelefono)
        Me.GBAgregarAdoptante.Controls.Add(Me.LEmail)
        Me.GBAgregarAdoptante.Controls.Add(Me.LDireccion)
        Me.GBAgregarAdoptante.Controls.Add(Me.LDni)
        Me.GBAgregarAdoptante.Controls.Add(Me.LNombre)
        Me.GBAgregarAdoptante.Controls.Add(Me.LApellido)
        Me.GBAgregarAdoptante.Location = New System.Drawing.Point(261, 78)
        Me.GBAgregarAdoptante.Name = "GBAgregarAdoptante"
        Me.GBAgregarAdoptante.Size = New System.Drawing.Size(286, 311)
        Me.GBAgregarAdoptante.TabIndex = 7
        Me.GBAgregarAdoptante.TabStop = False
        Me.GBAgregarAdoptante.Text = "Agregar Adoptante"
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
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(118, 172)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(100, 20)
        Me.TBEmail.TabIndex = 11
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(118, 136)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(100, 20)
        Me.TBDireccion.TabIndex = 10
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(118, 104)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(100, 20)
        Me.TBDni.TabIndex = 9
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(118, 70)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 8
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(118, 32)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(100, 20)
        Me.TBApellido.TabIndex = 7
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(20, 206)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LTelefono.TabIndex = 5
        Me.LTelefono.Text = "Telefono:"
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Location = New System.Drawing.Point(20, 172)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(35, 13)
        Me.LEmail.TabIndex = 4
        Me.LEmail.Text = "Email:"
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Location = New System.Drawing.Point(20, 139)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(55, 13)
        Me.LDireccion.TabIndex = 3
        Me.LDireccion.Text = "Dirección:"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(20, 104)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(26, 13)
        Me.LDni.TabIndex = 2
        Me.LDni.Text = "Dni:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(21, 70)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(47, 13)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(20, 32)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(47, 13)
        Me.LApellido.TabIndex = 0
        Me.LApellido.Text = "Apellido:"
        '
        'BVerificar
        '
        Me.BVerificar.Location = New System.Drawing.Point(103, 212)
        Me.BVerificar.Name = "BVerificar"
        Me.BVerificar.Size = New System.Drawing.Size(75, 23)
        Me.BVerificar.TabIndex = 6
        Me.BVerificar.Text = "Verificar"
        Me.BVerificar.UseVisualStyleBackColor = True
        '
        'TBVerificar
        '
        Me.TBVerificar.Location = New System.Drawing.Point(78, 175)
        Me.TBVerificar.Name = "TBVerificar"
        Me.TBVerificar.Size = New System.Drawing.Size(137, 20)
        Me.TBVerificar.TabIndex = 5
        '
        'LIdAdoptante
        '
        Me.LIdAdoptante.AutoSize = True
        Me.LIdAdoptante.Location = New System.Drawing.Point(78, 148)
        Me.LIdAdoptante.Name = "LIdAdoptante"
        Me.LIdAdoptante.Size = New System.Drawing.Size(139, 13)
        Me.LIdAdoptante.TabIndex = 4
        Me.LIdAdoptante.Text = "Identificacion del Adoptante"
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(118, 206)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TBTelefono.TabIndex = 14
        '
        'AgregarAdoptante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 467)
        Me.Controls.Add(Me.GBAgregarAdoptante)
        Me.Controls.Add(Me.BVerificar)
        Me.Controls.Add(Me.TBVerificar)
        Me.Controls.Add(Me.LIdAdoptante)
        Me.Name = "AgregarAdoptante"
        Me.Text = "AgregarAdoptante"
        Me.GBAgregarAdoptante.ResumeLayout(False)
        Me.GBAgregarAdoptante.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBAgregarAdoptante As System.Windows.Forms.GroupBox
    Friend WithEvents TBTelefono As System.Windows.Forms.TextBox
    Friend WithEvents BBorrar As System.Windows.Forms.Button
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents TBEmail As System.Windows.Forms.TextBox
    Friend WithEvents TBDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TBDni As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBApellido As System.Windows.Forms.TextBox
    Friend WithEvents LTelefono As System.Windows.Forms.Label
    Friend WithEvents LEmail As System.Windows.Forms.Label
    Friend WithEvents LDireccion As System.Windows.Forms.Label
    Friend WithEvents LDni As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LApellido As System.Windows.Forms.Label
    Friend WithEvents BVerificar As System.Windows.Forms.Button
    Friend WithEvents TBVerificar As System.Windows.Forms.TextBox
    Friend WithEvents LIdAdoptante As System.Windows.Forms.Label
End Class
