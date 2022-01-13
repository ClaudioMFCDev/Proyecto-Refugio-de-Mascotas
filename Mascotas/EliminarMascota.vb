Public Class EliminarMascota

    Private Sub EliminarMascota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mascota As New Mascota()
        mascota.CargarBorrar(CBEliminarMascota)
    End Sub

    Private Sub BEliminarMascota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminarMascota.Click
        If MsgBox("¿Desea eliminar la Mascota?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar Mascota") = MsgBoxResult.Yes Then
            Dim mascota As New Mascota(CBEliminarMascota.SelectedValue)
            If mascota.Borrar(mascota.getId_mascota) Then
                MessageBox.Show("La Mascota se ha eliminado con exito", "Mascota Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                GBEliminarMascota.Enabled = False
                GBEliminarMascota.Text = "Eliminar Mascota: "

                mascota.CargarBorrar(CBEliminarMascota)
                TBNombre.Text = ""
                TBSexo.Text = ""
                TBEspecie.Text = ""
                TBRaza.Text = ""
                TBColor.Text = ""
                TBHogar.Text = ""

            Else
                MessageBox.Show("Error al eliminar Mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        If MsgBox("¿Desea cancelar la operación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Aplicación") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub CBEliminarMascota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEliminarMascota.SelectedIndexChanged
        Try
            Dim mascota As New Mascota(CBEliminarMascota.SelectedValue)
            Using DBF As New MascotaEntities
                mascota.ObtenerDatos(mascota.getId_mascota)
                Dim especie = (From q In DBF.Especie.AsEnumerable Where (q.id_especie = mascota.getId_especie) Select q).ToList
                Dim raza = (From q In DBF.Raza.AsEnumerable Where (q.id_raza = mascota.getId_raza) Select q).ToList
                Dim hogar = (From q In DBF.Hogar.AsEnumerable Where (q.id_hogar = mascota.getId_hogar) Select q).ToList

                GBEliminarMascota.Enabled = True
                GBEliminarMascota.Text = "Eliminar Mascota: " & mascota.getId_mascota

                TBNombre.Text = mascota.getNombre
                TBSexo.Text = mascota.getSexo
                TBEspecie.Text = especie.Item(0).descripcion
                TBRaza.Text = raza.Item(0).descripcion
                TBColor.Text = mascota.getColor
                TBHogar.Text = hogar.Item(0).nombre

            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        If MsgBox("¿Desea Salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Aplicación") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub LEliminarMascota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEliminarMascota.Click

    End Sub

    Private Sub GBEliminarMascota_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBEliminarMascota.Enter

    End Sub
End Class