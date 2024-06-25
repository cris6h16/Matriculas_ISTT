Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_Roles

    Private datoRoles As Dato_Roles

    Public Sub New(datoRoles As Dato_Roles)
        Me.datoRoles = datoRoles
    End Sub

    Public Function traer(eRole As ERoles) As Entidad_Roles

        If eRole = Nothing Then
            Throw New Exception("El rol no puede ser nulo")
        End If

        Dim rol As Entidad_Roles = Me.datoRoles.traer(eRole)

        If rol Is Nothing Then
            Throw New Exception("No se encontro ningun rol llamado: " & eRole.ToString)
        End If

        Return rol
    End Function
End Class
