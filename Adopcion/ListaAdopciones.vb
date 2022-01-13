Public Class ListaAdopciones
    Dim adopcion As New Adop()

    Private Sub ListaAdopciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adopcion.MostrarListaCompleta(DGVAdopciones)
    End Sub

    Private Sub BDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDetalle.Click
        If DGVAdopciones.Rows.Count = 0 Then
            MessageBox.Show("No ha seleccionado ninguna factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim i As Integer = DGVAdopciones.CurrentRow.Index
            Dim mostrar As New Detalle
            adopcion.MostrarDetalle(mostrar.DGVDetalle, Me.DGVAdopciones.Item(0, i).Value)
            mostrar.LBAdopcion.Text = Me.DGVAdopciones.Item(0, i).Value
            mostrar.tb1.Text = Me.DGVAdopciones.Item(0, i).Value

            mostrar.LBFecha.Text = Me.DGVAdopciones.Item(1, i).Value
            mostrar.LBAdoptante.Text = Me.DGVAdopciones.Item(2, i).Value
            mostrar.LBPersonal.Text = Me.DGVAdopciones.Item(3, i).Value

            mostrar.Show()
        End If
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        If MsgBox("¿Desea cancelar la operación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cerrar Aplicación") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub
 
End Class