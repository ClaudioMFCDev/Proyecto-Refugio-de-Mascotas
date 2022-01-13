Public Class AgregarMascota

    Private Sub AgregarMascota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Using contexto As New MascotaEntities
                Dim objetoEspecie = (From q In contexto.Especie
                                   Select New With {.ide = q.id_especie, .nombre = q.descripcion}).ToList

                Dim objetoRaza = (From q In contexto.Raza
                                   Select New With {.ide = q.id_raza, .nombre = q.descripcion}).ToList

                Dim objetoHogar = (From q In contexto.Hogar
                                   Select New With {.ide = q.id_hogar, .nombre = q.nombre}).ToList

                CBEspecie.DataSource = objetoEspecie
                CBEspecie.DisplayMember = "nombre"
                CBEspecie.ValueMember = "ide"
                CBEspecie.SelectedValue = -1

                CBRaza.DataSource = objetoRaza
                CBRaza.DisplayMember = "nombre"
                CBRaza.ValueMember = "ide"
                CBRaza.SelectedValue = -1

                CBHogar.DataSource = objetoHogar
                CBHogar.DisplayMember = "nombre"
                CBHogar.ValueMember = "ide"
                CBHogar.SelectedValue = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVerificar.Click
        If TBVerificar.Text = "" Then
            MessageBox.Show("Debe ingresar la identificacion de la mascota a agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim mascota As New Mascota(TBVerificar.Text)
            If mascota.Verificar(mascota.getId_mascota) Then
                MessageBox.Show("Ya existe otra Mascota con esa identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                GBAgregarMascota.Enabled = True
                GBAgregarMascota.Text = "Agregar Mascota: " & mascota.getId_mascota
                TBVerificar.ReadOnly = True
                BVerificar.Enabled = False
            End If
        End If
    End Sub

    Private Sub BAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAgregar.Click
        If (TBNombre.Text = "" Or TBSexo.Text = "" Or CBEspecie.Text = "" Or CBRaza.Text = "" Or TBColor.Text = "" Or CBHogar.Text = "") Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("¿Desea agregar a la nueva mascota?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Agregar Personal") = MsgBoxResult.Yes Then
                Dim mascotas As New Mascota(TBVerificar.Text, TBNombre.Text, TBSexo.Text, CBEspecie.SelectedValue, CBRaza.SelectedValue, TBColor.Text, CBHogar.SelectedValue)
                If mascotas.Agregar() Then
                    MessageBox.Show("La Mascota se ha agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'TBVerificar.Text = ""
                    TBNombre.Text = ""
                    TBSexo.Text = ""
                    CBEspecie.Text = ""
                    CBHogar.Text = ""
                    TBColor.Text = ""
                    CBHogar.Text = ""
                    GBAgregarMascota.Enabled = False
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