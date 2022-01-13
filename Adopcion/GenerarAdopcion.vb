Public Class GenerarAdopcion
#Region "Variables Globales"

    Public mascota As New Mascota
    Public adopcion As New Adop
    Public adoptante As New Adoptante

    Public Tabla As New DataTable

    'Total de la Factura
    'Public total As Decimal = 0

#Region "Estructura del Detalle"

    Structure mascotaAdopcion
        Dim id_mascota As Integer
        Dim nombre As String
        Dim sexo As String
        Dim color As String
        Dim id_hogar As String
    End Structure

#End Region

    Public animal(100) As mascotaAdopcion
    Public usuario As New Usuario(Login.TBUsuario.Text, Login.TBPass.Text)

#End Region
#Region "Carga del Formulario"
    Private Sub GenerarAdopcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Using contexto As New MascotaEntities
                Dim objetoAdoptante = (From q In contexto.Adoptantes
                                       Select New With {.ide = q.id_adoptante, .nombre = q.nombre & " " & q.apellido}).ToList

                CBAdoptante.DataSource = objetoAdoptante
                CBAdoptante.DisplayMember = "nombre"
                CBAdoptante.ValueMember = "ide"
                CBAdoptante.SelectedValue = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        LBPersonal.Text = usuario.GetUsuario()

        Tabla.Columns.Add("Identificacion", GetType(Integer)) '0
        Tabla.Columns.Add("Nombre", GetType(String)) '1
        Tabla.Columns.Add("Sexo", GetType(String)) '2
        Tabla.Columns.Add("Color", GetType(String)) '3


        mascota.mostrarMascotas(DGVMascotas)

        Dim i As Integer
        i = DGVMascotas.CurrentRow.Index
        LNombre.Text = DGVMascotas.Item(1, i).Value
        LSexo.Text = DGVMascotas.Item(2, i).Value
        LIdentificacion.Text = DGVMascotas.Item(0, i).Value
        LEspecie.Text = DGVMascotas.Item(3, i).Value
        LRaza.Text = DGVMascotas.Item(4, i).Value
        LColor.Text = DGVMascotas.Item(5, i).Value
        LHogar.Text = DGVMascotas.Item(6, i).Value
    End Sub
#End Region

#Region "Buscador"
    Private Sub TBBuscador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBBuscador.TextChanged
        mascota.BuscarNombre(TBBuscador.Text, DGVMascotas)
    End Sub
    Private Sub DGVMascotas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVMascotas.CellContentClick
        Dim i As Integer
        i = DGVMascotas.CurrentRow.Index
        LNombre.Text = DGVMascotas.Item(1, i).Value
        LSexo.Text = DGVMascotas.Item(2, i).Value
        LIdentificacion.Text = DGVMascotas.Item(0, i).Value
        LEspecie.Text = DGVMascotas.Item(3, i).Value
        LRaza.Text = DGVMascotas.Item(4, i).Value
        LColor.Text = DGVMascotas.Item(5, i).Value
        LHogar.Text = DGVMascotas.Item(6, i).Value
    End Sub
#End Region

#Region "Detalle"
    Private Sub BAregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAregar.Click
        'Cargamos a la tabla detalle la mascota seleccionada
        Dim i As Integer = DGVMascotas.CurrentRow.Index
        Dim j As Integer
        Dim carga As Boolean = False

        'Controlamos si la mascota seleccionada ya se encuentra cargada o no verificando ademas si al tabla esta vacia
        If DGVDetalleAdopcion.Rows.Count > 0 Then
            For j = 0 To (DGVDetalleAdopcion.Rows.Count - 1)
                If DGVDetalleAdopcion.Item(0, j).Value = LIdentificacion.Text Then
                    carga = True
                End If
            Next
        End If
        If carga = False Then

            'Se carga la estructura
            animal(0).id_mascota = LIdentificacion.Text
            animal(0).nombre = LNombre.Text
            animal(0).sexo = LSexo.Text
            animal(0).color = LColor.Text


            'agregamos a la tabla
            Tabla.Rows.Add(animal(0).id_mascota, animal(0).nombre, animal(0).sexo, animal(0).color)

            DGVDetalleAdopcion.DataSource = Tabla

        Else
            'Si la mascota ya se encuentra en la lista de adopcion, el sistema nos avisa
            MessageBox.Show("La Mascota seleccionada Ya se encuentra en la lista de Adopción", "Mascota no Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub BEliminarMascota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminarMascota.Click
        'Procedimiento para eliminar una mascota de la tabla detalle
        If DGVDetalleAdopcion.Rows.Count = 0 Then

            'Si ya se encuentra vacio, el sistema nos avisa
            MessageBox.Show("El detalle de Adopciones se encuentra vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Eliminamos la mascota seleccionada
            DGVDetalleAdopcion.Rows.RemoveAt(DGVDetalleAdopcion.CurrentRow.Index)
            DGVDetalleAdopcion.Refresh()
        End If
    End Sub
#End Region

#Region "Proceso de Adopcion"


    Private Sub BConfirmarAdopcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BConfirmarAdopcion.Click
        'Verificamos si la tabla de detalle se encuentra vacia
        If DGVDetalleAdopcion.Rows.Count = 0 Then
            MsgBox("La tabla detalles se encuentra vacia", MsgBoxStyle.Critical)
        Else
            If MsgBox("¿Confirmar Operacion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Factura") = MsgBoxResult.Yes Then
                Try
                    Using DBF As New MascotaEntities
                        'Creamos una factura auxiliar para obtener el ultimo numero registrado y el ultimo identificador 
                        '(Esta factura auxiliar no se registra)

                        Dim auxadopcion As New Adop()
                        Dim ultimaAdopcion As Integer = adopcion.UltimaAdopcion()


                        'Creamos la factura real 
                        'Esta factura se registra en la base de datos

                        Dim adopcionNueva As New Adop((ultimaAdopcion + 1), CBAdoptante.SelectedValue, DTPFecha.Text, Login.TBUsuario.Text)


                        'Recorremos la tabla "detalle" 
                        'Vamos agregando a los detalles de la factura recien creada

                        Dim i As Integer = 0
                        Dim row As System.Windows.Forms.DataGridViewRow
                        Dim ultimo As Integer = adopcion.UltimoDetalle()
                        While i < (Me.DGVDetalleAdopcion.Rows.Count)
                            row = Me.DGVDetalleAdopcion.Rows(i)
                            Dim detalle As New DetalleAdopcion
                            With detalle
                                .id_detalle = (ultimo + 1)
                                .id_adopcion = adopcionNueva.GetId
                                .id_mascota = Me.DGVDetalleAdopcion.Item(0, i).Value

                            End With
                            DBF.AddToDetalleAdopcion(detalle)
                            ultimo += 1

                            'factura.AgregarDetalle((ultimo + 1), Me.DGVDetalle.Item(0, i).Value, Me.DGVDetalle.Item(2, i).Value, facturaNueva.GetId)
                            'libro.ActualizarStock(Me.DGVDetalle.Item(0, i).Value,
                            'mascota.ActualizarMascota(Me.DGVDetalleAdopcion.Item(0, i).Value)

                            i += 1

                        End While
                        adopcionNueva.Agregar()

                        DBF.SaveChanges()

                        'Confirmamos el exito de la Operacion
                        MessageBox.Show("La operacion se realizo con exito", "Venta Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Actualizamos la lista de Productos
                        mascota.mostrarMascotas(DGVMascotas)

                        'Creamos un nuevo formulario para mostrar la factura y poder imprimirla
                        'Dim ticket As New DetalleAdop
                        'Dim aux As New DetalleAdop()

                        'Cargamos los datos de la factura con los detalles
                        'aux.MostrarDetalle(ticket.DGVDetalle, factura.getNumero)
                        'ticket.LFactura.Text = factura.getNumero
                        'ticket.LFecha.Text = factura.getFecha
                        'ticket.LTipo.Text = factura.getTipo
                        'ticket.LTotal.Text = factura.getTotal
                        'ticket.LCliente.Text = cliente.GetDNI
                        'ticket.LEstado.Text = factura.getEstado
                        'ticket.Show()

                        'Verificamos si el pago de la factura se ha realizado


                        'Reinicializamos el formulario
                        DGVDetalleAdopcion.DataSource = Nothing


                        'Else
                        ''En caso de Error en Base de Datos
                        'MessageBox.Show("Error al Cargar la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'End If
                    End Using
                Catch Ex As Exception
                    'En caso de Error
                    MessageBox.Show("Error en la operacion")
                End Try
            End If
        End If
    End Sub

#End Region
  
End Class