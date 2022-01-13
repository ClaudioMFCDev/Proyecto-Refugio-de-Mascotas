Public Class ModificarMascota

    Private Sub ModificarMascota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Using Base As New MascotaEntities

                Dim qMascotas = (From q In Base.Mascotas Select New With {.idef = q.id_mascota, .nombreM = q.id_mascota & " " & q.nombre}).ToList

                Dim qEspecie = (From q In Base.Especie Select New With {.ide = q.id_especie, .nombre = q.id_especie & " " & q.descripcion}).ToList
                Dim qRaza = (From q In Base.Raza Select New With {.ide = q.id_raza, .nombre = q.id_raza & " " & q.descripcion}).ToList
                Dim qHogar = (From q In Base.Hogar Select New With {.ide = q.id_hogar, .nombre = q.id_hogar & " " & q.nombre}).ToList

                CBModificarMascota.DataSource = qMascotas
                CBModificarMascota.DisplayMember = "nombreM"
                CBModificarMascota.ValueMember = "idef"
                CBModificarMascota.SelectedValue = -1

                CBEspecie.DataSource = qEspecie
                CBEspecie.DisplayMember = "nombre"
                CBEspecie.ValueMember = "ide"
                CBEspecie.SelectedValue = -1

                CBRaza.DataSource = qRaza
                CBRaza.DisplayMember = "nombre"
                CBRaza.ValueMember = "ide"
                CBRaza.SelectedValue = -1

                CBHogar.DataSource = qHogar
                CBHogar.DisplayMember = "nombre"
                CBHogar.ValueMember = "ide"
                CBHogar.SelectedValue = -1

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BModificarMascota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BModificarMascota.Click
        If (TBNombre.Text = "" Or TBSexo.Text = "" Or CBEspecie.Text = "" Or CBRaza.Text = "" Or TBColor.Text = "" Or CBHogar.Text = "") Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("¿Desea modificar la Mascota?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Modificar Mascota") = MsgBoxResult.Yes Then
                Dim mascota As New Mascota()
                If mascota.Modificar(CBModificarMascota.SelectedValue, TBNombre.Text, TBSexo.Text, CBEspecie.SelectedValue, CBRaza.SelectedValue, TBColor.Text, CBHogar.SelectedValue) Then
                    MessageBox.Show("La Mascota se ha modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    TBNombre.Text = ""
                    TBSexo.Text = ""
                    CBEspecie.Text = ""
                    CBRaza.Text = ""
                    TBColor.Text = ""
                    CBHogar.Text = ""

                Else
                    MessageBox.Show("Error al Modificar la Mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBorrar.Click
        If (TBNombre.Text = "" And TBSexo.Text = "" And CBEspecie.Text = "" And CBRaza.Text = "" And TBColor.Text = "" And CBHogar.Text = "") Then
            MessageBox.Show("Los campos ya se encuentran vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MsgBox("¿Desea borrar todos los datos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Borrar Datos") = MsgBoxResult.Yes Then
                TBNombre.Text = ""
                TBSexo.Text = ""
                CBEspecie.Text = ""
                CBRaza.Text = ""
                TBColor.Text = ""
                CBHogar.Text = ""
            End If
        End If
    End Sub

    Private Sub CBModificarMascota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBModificarMascota.SelectedIndexChanged
        Try
            Dim mascota As New Mascota(CBModificarMascota.SelectedValue)
            Using DBF As New MascotaEntities
                mascota.ObtenerDatos(mascota.getId_mascota)

                'Dim especie = (From q In DBF.Especie.AsEnumerable Where (q.id_especie = mascota.getId_especie) Select q).ToList
                'Dim raza = (From q In DBF.Raza.AsEnumerable Where (q.id_raza = mascota.getId_raza) Select q).ToList
                'Dim hogar = (From q In DBF.Hogar.AsEnumerable Where (q.id_hogar = mascota.getId_hogar) Select q).ToList

                GBModificarMascota.Enabled = True
                GBModificarMascota.Text = "Modificar Mascota: " & mascota.getId_mascota

                TBNombre.Text = mascota.getNombre
                TBSexo.Text = mascota.getSexo
                'CBEspecie.Text = especie.Item(0).descripcion
                'CBRaza.Text = raza.Item(0).descripcion
                TBColor.Text = mascota.getColor
                'CBHogar.Text = hogar.Item(0).nombre

            End Using
        Catch ex As Exception
        End Try
    End Sub
End Class