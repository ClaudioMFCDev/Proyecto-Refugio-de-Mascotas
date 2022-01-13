Public Class Adoptante
    Private id_adoptante As Integer
    Private apellido As String
    Private nombre As String
    Private dni As Integer
    Private direccion As String
    Private email As String
    Private telefono As String

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_id_adoptante As Integer, ByVal p_apellido As String, ByVal p_nombre As String, ByVal p_dni As Integer, ByVal p_direccion As String, ByVal p_email As String, ByVal p_telefono As String)
        setId_adoptante(p_id_adoptante)
        setApellido(p_apellido)
        setNombre(p_nombre)
        setDni(p_dni)
        setDireccion(p_direccion)
        setEmail(p_email)
        setTelefono(p_telefono)


    End Sub

    Public Sub New(ByVal p_id_adoptante As Integer)
        setId_adoptante(p_id_adoptante)
        setApellido("")
        setNombre(0)
        setDni(0)
        setDireccion(0)
        setEmail(0)
        setTelefono(0)


    End Sub


#Region "Get"

    Public Function getId_adoptante()
        Return id_adoptante
    End Function

    Public Function getApellido()
        Return apellido
    End Function

    Public Function getNombre()
        Return nombre
    End Function

    Public Function getDni()
        Return dni
    End Function

    Public Function getDireccion()
        Return direccion
    End Function

    Public Function getEmail()
        Return email
    End Function

    Public Function getTelefono()
        Return telefono
    End Function



#End Region

#Region "Set"

    Private Sub setId_adoptante(ByVal p_id_adoptante As Integer)
        id_adoptante = p_id_adoptante
    End Sub

    Private Sub setApellido(ByVal p_apellido As String)
        apellido = p_apellido
    End Sub

    Private Sub setNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub

    Private Sub setDni(ByVal p_dni As Integer)
        dni = p_dni
    End Sub

    Private Sub setDireccion(ByVal p_direccion As String)
        direccion = p_direccion
    End Sub

    Private Sub setEmail(ByVal p_email As String)
        email = p_email
    End Sub

    Private Sub setTelefono(ByVal p_telefono As String)
        telefono = p_telefono
    End Sub



#End Region

#End Region

#Region "Procedimientos"
    Public Function Agregar()
        Try
            Using AGR As New MascotaEntities
                Dim datos As New Adoptantes
                With datos
                    .id_adoptante = getId_adoptante()
                    .apellido = getApellido()
                    .nombre = getNombre()
                    .dni = getDni()
                    .direccion = getDireccion()
                    .email = getEmail()
                    .telefono = getTelefono()

                End With

                AGR.AddToAdoptantes(datos)
                AGR.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Verificar(ByVal p_id_adoptante As Integer)
        Try
            Using VRF As New MascotaEntities
                Dim objetoVerificar = (From q In VRF.Adoptantes
                                       Where q.id_adoptante = p_id_adoptante
                                       Select q).First
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CargarBorrar(ByVal combo As ComboBox)
        Try
            Using Base As New MascotaEntities
                Dim qAdoptante = (From q In Base.Adoptantes Select New With {.idef = q.id_adoptante, .nombreA = q.id_adoptante & ": " & q.apellido & ": " & q.nombre}).ToList

                combo.DataSource = qAdoptante
                combo.DisplayMember = "nombreA"
                combo.ValueMember = "idef"
                combo.SelectedValue = -1
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Borrar(ByVal p_id_adoptante As Integer)
        Try
            Using BRR As New MascotaEntities
                Dim objetoBorrar = (From q In BRR.Adoptantes
                                    Where q.id_adoptante = p_id_adoptante
                                    Select q).First()

                BRR.Adoptantes.DeleteObject(objetoBorrar)
                BRR.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerDatos(ByVal p_id_adoptante As Integer)
        Try
            Using DTS As New MascotaEntities
                Dim datos As Adoptantes = (From q In DTS.Adoptantes Where (p_id_adoptante = q.id_adoptante) Select q).First()

                setId_adoptante(datos.id_adoptante)
                setApellido(datos.apellido)
                setNombre(datos.nombre)
                setDni(datos.dni)
                setDireccion(datos.direccion)
                setEmail(datos.email)
                setTelefono(datos.telefono)


            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
