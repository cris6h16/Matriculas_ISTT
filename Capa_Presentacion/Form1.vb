Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class Form1

    Private negocioUsuario As Negocio_Usuario
    Public Sub New()
        InitializeComponent()
        Me.negocioUsuario = New Negocio_Usuario(New Dato_Usuario())

        llenarTabla()
    End Sub

    Private Sub dgv_matriculados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_matriculados.CellContentClick

    End Sub

    Private Sub llenarTabla()

        Dim usuarios As List(Of Entidad_Usuario) = negocioUsuario.listarTodos()

        For Each u As Entidad_Usuario In usuarios
            dgv_matriculados.Rows.Add(
                u.Foto,
                u.Rol,
                u.Cedula,
                u.Nombres,
                u.Apellidos,
                u.Sexo,
                u.Nacimiento
            )
        Next
    End Sub
End Class