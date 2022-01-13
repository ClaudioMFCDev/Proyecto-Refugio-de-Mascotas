Public Class Detalle



    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        frmreportecomprobante.tbidadopcion2.Text = Me.tb1.Text

        frmreportecomprobante.Show()
    End Sub

    Private Sub Detalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnImprimir.Visible = True
    End Sub

    Private Sub LBAdopcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBAdopcion.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb1.TextChanged


    End Sub
End Class