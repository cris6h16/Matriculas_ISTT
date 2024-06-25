Imports Capa_Entidades
Imports Capa_Negocio

Public Class frmPrincipal
    Dim negocioUsuario As Negocio_Usuario
    Public Sub New()
        InitializeComponent()
        negocioUsuario = New Negocio_Usuario(New Capa_Datos.Dato_Usuario())
    End Sub


    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try

            Dim usuario As Entidad_Usuario = negocioUsuario.traerUsuario(txtUsuario.Text, txtContrasena.Text)

            MessageBox.Show("Bienvenido " & usuario.Nombres & " " & usuario.Apellidos, "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
