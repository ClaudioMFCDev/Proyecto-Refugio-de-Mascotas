Public Class MostarMascota
    Dim mascotas As New Mascota()
    Private Sub MostarMascota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Using Base As New MascotaEntities

                Dim qEspecie = (From q In Base.Especie Select New With {.ide = q.id_especie, .especie = q.id_especie & " " & q.descripcion}).ToList
                Dim qHogar = (From q In Base.Hogar Select New With {.ide = q.id_hogar, .hogar = q.id_hogar & " " & q.nombre}).ToList

                CBEspecie.DataSource = qEspecie
                CBEspecie.DisplayMember = "especie"
                CBEspecie.ValueMember = "ide"
                CBEspecie.SelectedValue = -1

                CBHogar.DataSource = qHogar
                CBHogar.DisplayMember = "hogar"
                CBHogar.ValueMember = "ide"
                CBHogar.SelectedValue = -1

            End Using
            RBTodasMascotas.Checked = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RBHogar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBHogar.CheckedChanged
        CBHogar.Enabled = True
        CBEspecie.Enabled = False
        TBNombre.Enabled = False
    End Sub

    Private Sub RBEspecie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBEspecie.CheckedChanged
        CBHogar.Enabled = False
        CBEspecie.Enabled = True
        TBNombre.Enabled = False
    End Sub

    Private Sub RBNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNombre.CheckedChanged
        CBHogar.Enabled = False
        CBEspecie.Enabled = False
        TBNombre.Enabled = True
    End Sub

    Private Sub RBTodasMascotas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBTodasMascotas.CheckedChanged
        mascotas.mostrarMascotas(DGVFiltros)
        CBHogar.Enabled = False
        CBEspecie.Enabled = False
        TBNombre.Enabled = False
    End Sub

    Private Sub CBHogar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBHogar.SelectedIndexChanged
        Try
            mascotas.MostrarHogar(CBHogar.SelectedValue, DGVFiltros)
        Catch EX As Exception
        End Try
    End Sub

    Private Sub CBEspecie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEspecie.SelectedIndexChanged
        Try
            mascotas.MostrarEspecie(CBEspecie.SelectedValue, DGVFiltros)
        Catch EX As Exception
        End Try
    End Sub

    Private Sub TBNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBNombre.TextChanged
        mascotas.BuscarNombre(TBNombre.Text, DGVFiltros)
    End Sub
End Class