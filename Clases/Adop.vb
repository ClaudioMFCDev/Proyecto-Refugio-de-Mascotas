Public Class Adop
    Private id As Integer
    Private adoptante As Integer
    Private fecha As Date
    Private usuario As String

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_id As Integer, ByVal p_adoptante As Integer, ByVal p_fecha As Date, ByVal p_usuario As String)
        SetId(p_id)
        SetAdoptante(p_adoptante)
        SetFecha(p_fecha)
        SetUsuario(p_usuario)
    End Sub

#End Region

#Region "Get/Set"

#Region "Get"

    Public Function GetId()
        Return id
    End Function

    Public Function GetAdoptante()
        Return adoptante
    End Function
    Public Function GetFecha()
        Return fecha
    End Function
    Public Function GetUsuario()
        Return usuario
    End Function

#End Region

#Region "Set"

    Private Sub SetId(ByVal p_id)
        id = p_id
    End Sub

    Private Sub SetAdoptante(ByVal p_adoptante)
        adoptante = p_adoptante
    End Sub

    Private Sub SetFecha(ByVal p_fecha)
        fecha = p_fecha
    End Sub
    Private Sub SetUsuario(ByVal p_usuario)
        usuario = p_usuario
    End Sub

#End Region

#End Region

#Region "Procedimientos"
    Public Function UltimaAdopcion()
        Try
            Using DBF As New MascotaEntities
                Dim qUltimo = (From q In DBF.Adopcion Select q).ToList
                Dim contador As Integer = qUltimo.Count
                If contador = 0 Then
                    Return 0
                Else
                    Return qUltimo.Item(contador - 1).id_adopcion
                End If
            End Using
        Catch ex As Exception
            Return MessageBox.Show("Error al obtener ultima adopcion")
        End Try
    End Function



    Public Function UltimoDetalle()
        Try
            Using DBF As New MascotaEntities
                Dim qUltimo = (From q In DBF.DetalleAdopcion Select q).ToList
                Dim contador As Integer = qUltimo.Count

                If contador = 0 Then
                    Return 0
                Else
                    Return qUltimo.Item(contador - 1).id_detalle
                End If
            End Using
        Catch Ex As Exception
            Return MessageBox.Show("Error al obtener ultimo detalle")
        End Try
    End Function

    Public Function Agregar()
        Try
            Using DBF As New MascotaEntities
                Dim datos As New Adopcion
                ''     Dim vble As Integer = 0
                With datos
                    .id_adopcion = GetId()
                    .id_adoptante = GetAdoptante()
                    .fecha_adopcion = GetFecha()
                    .usuario = GetUsuario()
                End With

                DBF.AddToAdopcion(datos)
                DBF.SaveChanges()
                ''     vble = vble / 0
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function



    Public Function MostrarListaCompleta(ByVal grid As DataGridView)
        Try
            Using DBF As New MascotaEntities
                Dim objMostrar = (From q In DBF.Adopcion
                                  Select Numero = q.id_adopcion, Fecha = q.fecha_adopcion, Adoptante = (q.Adoptantes.nombre & " " & q.Adoptantes.apellido), Responsable = (q.Usuarios.usuario)).ToList

                grid.DataSource = objMostrar
            End Using
        Catch ex As Exception

        End Try
    End Function

    Public Function MostrarDetalle(ByVal grid As DataGridView, ByVal adopcion As Integer)
        Try
            Using DBF As New MascotaEntities
                Dim objMostrar = (From q In DBF.DetalleAdopcion Where (q.Adopcion.id_adopcion = adopcion)
                                  Select Mascota = q.Mascotas.nombre, Color = q.Mascotas.color, Sexo = q.Mascotas.sexo).ToList

                grid.DataSource = objMostrar
            End Using
        Catch ex As Exception
        End Try
    End Function
#End Region
End Class
