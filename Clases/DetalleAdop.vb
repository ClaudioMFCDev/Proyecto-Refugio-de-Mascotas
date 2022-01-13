Public Class DetalleAdop
    Private id_detalle As Integer
    Private id_adopcion As Integer
    Private Id_mascota As Integer
#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_id_detalle As Integer, ByVal p_id_adopcion As Integer, ByVal p_id_mascota As Integer)
        SetId_detalle(p_id_detalle)
        SetId_adopcion(p_id_adopcion)
        SetId_mascota(p_id_mascota)

    End Sub

#End Region

#Region "Get/Set"

#Region "Get"

    Public Function GetId_detalle()
        Return id_detalle
    End Function
    Public Function GetId_adopcion()
        Return id_adopcion
    End Function
    Public Function GetId_mascota()
        Return Id_mascota
    End Function



#End Region

#Region "Set"

    Private Sub SetId_detalle(ByVal p_id_detalle As Integer)
        id_detalle = p_id_detalle
    End Sub
    Private Sub SetId_adopcion(ByVal p_id_adopcion As Integer)
        id_adopcion = p_id_adopcion
    End Sub
    Private Sub SetId_mascota(ByVal p_id_mascota As Integer)
        Id_mascota = p_id_mascota
    End Sub


#End Region

#End Region

#Region "Procedimientos"



#End Region
End Class
