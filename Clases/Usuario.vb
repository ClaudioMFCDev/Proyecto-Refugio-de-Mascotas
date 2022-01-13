Public Class Usuario
    Private usuarioo As String
    Private pass As String

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_usuario As String, ByVal p_pass As String)
        SetUsuario(p_usuario)
        SetPass(p_pass)
    End Sub

#End Region

#Region "Get/Set"

#Region "Get"

    Public Function GetUsuario()
        Return usuarioo
    End Function

    Public Function GetPass()
        Return pass
    End Function

#Region "Set"

    Private Sub SetUsuario(ByVal p_usuario)
        usuarioo = p_usuario
    End Sub

    Private Sub SetPass(ByVal p_pass)
        pass = p_pass
    End Sub

#End Region

#End Region

#End Region

#Region "Procedimientos"

    Public Function Verificar(ByVal p_usuario, ByVal p_pass)
        Try
            Using verif As New MascotaEntities
                Dim objetoVerificar = (From q In verif.Usuarios
                                                    Where (q.usuario = p_usuario And q.pass = p_pass)
                                                    Select q)

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function



#End Region

End Class
