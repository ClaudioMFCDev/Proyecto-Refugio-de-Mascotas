Public Class frmreportecomprobante

    Private Sub frmreportecomprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MascotaDataSet1.generar_comprobante' table. You can move, or remove it, as needed.
        MascotaDataSet2.EnforceConstraints = False
        Me.generar_comprobanteTableAdapter.Fill(Me.MascotaDataSet2.generar_comprobante, id_adopcion:=tbidadopcion2.Text)

        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub ReportViewer3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer3.Load

    End Sub
End Class