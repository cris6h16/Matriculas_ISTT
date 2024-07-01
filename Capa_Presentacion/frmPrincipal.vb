Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frmPrincipal

    Public Shared Property frm_MenuDeAdministrador As frm_MenuDeAdministrador
    Public Shared Property frm_MenuDeDocente As frm_MenuDeDocente


    Dim negocioUsuario As Negocio_Usuario
    Public Sub New()
        InitializeComponent()
        negocioUsuario = New Negocio_Usuario(New Dato_Usuario())
    End Sub


    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try

            Dim usuario As Entidad_Usuario = negocioUsuario.traerPorCedulaYContrasena(txtUsuario.Text, txtContrasena.Text)

            If cbxAdministrador.Checked = True Then
                If Not usuario.Rol.Equals(ERoles.Administrador) Then Throw New Exception("El usuario no tiene el rol de Administrador")

                MsgBox("Bienvenido, se ha logueado como Administrador")
                frm_MenuDeAdministrador = New frm_MenuDeAdministrador()
                frm_MenuDeAdministrador.Show()
                Me.Hide()

            ElseIf cbxDocente.Checked = True Then
                If Not usuario.Rol.Equals(ERoles.Docente) Then Throw New Exception("El usuario no tiene el rol de Docente")

                MsgBox("Bienvenido, se ha logueado como Docente")
                frm_MenuDeDocente = New frm_MenuDeDocente(usuario)
                frm_MenuDeDocente.Show()
                Me.Hide()

            ElseIf cbxEstudiante.Checked = True Then
                If Not usuario.Rol.Equals(ERoles.Estudiante) Then Throw New Exception("El usuario no tiene el rol de Estudiante")
                ' MsgBox("Bienvenido, se ha logueado como Estudiante")
                MsgBox("no existe aun la vista para estudiantes")
                'frm_Estudiante.Show()
                'Me.Hide()

            Else
                MsgBox("Seleccione un rol")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

            frm_MenuDeAdministrador.Hide()
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEstudiante.CheckedChanged
        If Me.cbxEstudiante.Checked = True Then
            Me.cbxDocente.Checked = False
            Me.cbxAdministrador.Checked = False
        End If
    End Sub

    Private Sub cbxDocente_CheckedChanged(sender As Object, e As EventArgs) Handles cbxDocente.CheckedChanged

        If Me.cbxDocente.Checked = True Then
            Me.cbxEstudiante.Checked = False
            Me.cbxAdministrador.Checked = False
        End If

    End Sub

    Private Sub cbxAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAdministrador.CheckedChanged

        If Me.cbxAdministrador.Checked = True Then
            Me.cbxEstudiante.Checked = False
            Me.cbxDocente.Checked = False
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
