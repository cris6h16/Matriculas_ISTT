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

            If cbxAdministrador.Checked = True Then
                MsgBox("Bienvenido, se ha logueado como Administrador")
                frm_Administrador.Show()
                Me.Hide()

            ElseIf cbxDocente.Checked = True Then
                MsgBox("Bienvenido, se ha logueado como Docente")
                frm_Docente.Show()
                Me.Hide()

            ElseIf cbxEstudiante.Checked = True Then
                MsgBox("Bienvenido, se ha logueado como Estudiante")
                frm_Estudiante.Show()
                Me.Hide()

            Else
                MsgBox("Seleccione un rol")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

            frm_Administrador.Hide()
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

End Class
