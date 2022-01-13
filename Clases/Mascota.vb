Public Class Mascota
    Private id_mascota As Integer
    Private nombre As String
    Private sexo As String
    Private id_especie As Integer
    Private id_raza As Integer
    Private color As String
    Private id_hogar As Integer

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_id_mascota As Integer, ByVal p_nombre As String, ByVal p_sexo As String, ByVal p_id_especie As Integer, ByVal p_id_raza As Integer, ByVal p_color As String, ByVal p_id_hogar As Integer)
        setId_mascota(p_id_mascota)
        setNombre(p_nombre)
        setSexo(p_sexo)
        setId_especie(p_id_especie)
        setId_raza(p_id_raza)
        setColor(p_color)
        setId_hogar(p_id_hogar)

    End Sub

    Public Sub New(ByVal p_id_mascota As Integer)
        setId_mascota(p_id_mascota)
        setNombre("")
        setSexo(0)
        setId_especie(0)
        setId_raza(0)
        setColor(0)
        setId_hogar(0)

    End Sub
#End Region


#Region "Get/Set"

#Region "Get"

    Public Function getId_mascota()
        Return id_mascota
    End Function

    Public Function getNombre()
        Return nombre
    End Function

    Public Function getSexo()
        Return sexo
    End Function

    Public Function getId_especie()
        Return id_especie
    End Function

    Public Function getId_raza()
        Return id_raza
    End Function

    Public Function getColor()
        Return color
    End Function

    Public Function getId_hogar()
        Return id_hogar
    End Function
#End Region

#Region "Set"

    Private Sub setId_mascota(ByVal p_id_mascota As Integer)
        id_mascota = p_id_mascota
    End Sub

    Private Sub setNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub

    Private Sub setSexo(ByVal p_sexo As String)
        sexo = p_sexo
    End Sub

    Private Sub setId_especie(ByVal p_id_especie As Integer)
        id_especie = p_id_especie
    End Sub

    Private Sub setId_raza(ByVal p_id_raza As Integer)
        id_raza = p_id_raza
    End Sub

    Private Sub setColor(ByVal p_color As String)
        color = p_color
    End Sub

    Private Sub setId_hogar(ByVal p_id_hogar As Integer)
        id_hogar = p_id_hogar
    End Sub
#End Region
#End Region


#Region "Procedimientos"

    Public Function mostrarMascotas(ByVal grid As DataGridView)
        Try
            Using MST As New MascotaEntities
                Dim objetoMostrar = (From q In MST.Mascotas
                                     Select id_mascota = q.id_mascota,
                                     nombre = q.nombre,
                                     sexo = q.sexo,
                                     Especie = q.Especie.descripcion,
                                     Raza = q.Raza.descripcion,
                                     color = q.color,
                                     Hogar = q.Hogar.nombre).ToList


                grid.DataSource = objetoMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function BuscarNombre(ByVal p_nombre As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New MascotaEntities
                Dim objMostrar = (From q In Mostrar.Mascotas Where q.nombre.StartsWith(p_nombre)
                                  Select id_mascota = q.id_mascota, nombre = q.nombre, sexo = q.sexo, id_especie = q.id_especie, id_raza = q.id_raza,
                                  color = q.color, id_hogar = q.Hogar.nombre).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarEspecie(ByVal p_id_especie As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New MascotaEntities
                Dim objMostrar = (From q In Mostrar.Mascotas Where p_id_especie = q.Especie.id_especie
                                  Select id_mascota = q.id_mascota, nombre = q.nombre, id_especie = q.id_especie,
                                  id_raza = q.id_raza, color = q.color, id_hogar = q.Hogar.id_hogar).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarHogar(ByVal p_id_hogar As Integer, ByVal grid As DataGridView)
        Try
            Using Mostrar As New MascotaEntities
                Dim objMostrar = (From q In Mostrar.Mascotas Where p_id_hogar = q.Hogar.id_hogar
                                  Select id_mascota = q.id_mascota, nombre = q.nombre, id_especie = q.id_especie,
                                  id_raza = q.id_raza, color = q.color, id_hogar = q.Hogar.id_hogar).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function



    Public Function Agregar()
        Try
            Using AGR As New MascotaEntities
                Dim datos As New Mascotas
                With datos
                    .id_mascota = getId_mascota()
                    .nombre = getNombre()
                    .sexo = getSexo()
                    .id_especie = getId_especie()
                    .id_raza = getId_raza()
                    .color = getColor()
                    .id_hogar = getId_hogar()


                End With

                AGR.AddToMascotas(datos)
                AGR.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function Verificar(ByVal p_id_mascota As Integer)
        Try
            Using VRF As New MascotaEntities
                Dim objetoVerificar = (From q In VRF.Mascotas
                                       Where q.id_mascota = p_id_mascota
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
                Dim qMascota = (From q In Base.Mascotas Select New With {.idef = q.id_mascota, .nombrel = q.id_mascota & ": " & q.nombre}).ToList

                combo.DataSource = qMascota
                combo.DisplayMember = "nombrel"
                combo.ValueMember = "idef"
                combo.SelectedValue = -1
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Borrar(ByVal p_id_mascota As Integer)
        Try
            Using BRR As New MascotaEntities
                Dim objetoBorrar = (From q In BRR.Mascotas
                                    Where q.id_mascota = p_id_mascota
                                    Select q).First()

                BRR.Mascotas.DeleteObject(objetoBorrar)
                BRR.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerDatos(ByVal p_id_mascota As Integer)
        Try
            Using DTS As New MascotaEntities
                Dim datos As Mascotas = (From q In DTS.Mascotas Where (p_id_mascota = q.id_mascota) Select q).First()

                setId_mascota(datos.id_mascota)
                setNombre(datos.nombre)
                setSexo(datos.sexo)
                setId_especie(datos.id_especie)
                setId_raza(datos.id_raza)
                setColor(datos.color)
                setId_hogar(datos.id_hogar)

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function Modificar(ByVal p_id_mascota As Integer, ByVal p_nombre As String, ByVal p_sexo As String, ByVal p_id_especie As Integer, ByVal p_id_raza As Integer, ByVal p_color As String, ByVal p_id_hogar As Integer)
        Try
            Using MDF As New MascotaEntities
                Dim objetoModificar = (From q In MDF.Mascotas
                                       Where q.id_mascota = p_id_mascota
                                       Select q).First

                objetoModificar.nombre = p_nombre
                objetoModificar.sexo = p_sexo
                objetoModificar.id_especie = p_id_especie
                objetoModificar.id_raza = p_id_raza
                objetoModificar.color = p_color
                objetoModificar.id_hogar = p_id_hogar


                MDF.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function ActualizarMascota(ByVal p_id_mascota As Integer)
        Try
            Using DBF As New MascotaEntities
                Dim mascota = (From q In DBF.Mascotas Where q.id_mascota = p_id_mascota Select q).First


                'DBF.SaveChanges()
                Return True
            End Using
        Catch Ex As Exception
            Return False
        End Try
    End Function

#End Region

End Class
