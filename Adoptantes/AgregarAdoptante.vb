Public Class AgregarAdoptante

    Private Sub AgregarAdoptante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVerificar.Click
        If TBVerificar.Text = "" Then
            MessageBox.Show("Debe ingresar la identificacion del Adoptante a agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim adoptante As New Adoptante(TBVerificar.Text)
            If adoptante.Verificar(adoptante.getId_adoptante) Then
                MessageBox.Show("Ya existe otro Adoptante con esa identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                GBAgregarAdoptante.Enabled = True
                GBAgregarAdoptante.Text = "Agregar Adoptante: " & adoptante.getId_adoptante
                TBVerificar.ReadOnly = True
                BVerificar.Enabled = False
            End If
        End If
    End Sub

    Private Sub BAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAgregar.Click
        If (TBApellido.Text = "" Or TBNombre.Text = "" Or TBDni.Text = "" Or TBDireccion.Text = "" Or TBEmail.Text = "" Or TBTelefono.Text = "") Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("¿Desea agregar al Nuevo Adoptante?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Agregar Personal") = MsgBoxResult.Yes Then
                Dim adoptante As New Adoptante(TBVerificar.Text, TBApellido.Text, TBNombre.Text, TBDni.Text, TBDireccion.Text, TBEmail.Text, TBTelefono.Text)
                If adoptante.Agregar() Then
                    MessageBox.Show("El Adoptante se ha agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'TBVerificar.Text = ""
                    TBApellido.Text = ""
                    TBNombre.Text = ""
                    TBDni.Text = ""
                    TBDireccion.Text = ""
                    TBEmail.Text = ""
                    TBTelefono.Text = ""

                    GBAgregarAdoptante.Enabled = False
                    TBVerificar.Text = ""
                    TBVerificar.ReadOnly = False
                    BVerificar.Enabled = True


                Else
                    MessageBox.Show("Error al Agregar a la Mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class