Public Class frm_MenuDeAdministrador

    Public Shared Property frm_RegistroDeUusarios As Form1
    Public Shared Property frm_RegistroDeCarrera As frm_RegistroDeCarrera
    Public Shared Property frm_RegistroDeAsignatura As frm_RegistroDeAsignatura
    Public Shared Property frm_RegistroDePeriodosAcademicos As frm_RegistroDePeriodosAcademicos
    Public Shared Property frm_AsignarMateriasADocentes As frm_AsignarMateriasADocentes


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_RegistroDeUusarios = New frm_RegistroDeUusarios()
        frm_RegistroDeUusarios.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_RegistroDeCarrera = New frm_RegistroDeCarrera()
        frm_RegistroDeCarrera.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        frm_RegistroDeAsignatura = New frm_RegistroDeAsignatura()
        frm_RegistroDeAsignatura.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_RegistroDePeriodosAcademicos = New frm_RegistroDePeriodosAcademicos()
        frm_RegistroDePeriodosAcademicos.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frm_AsignarMateriasADocentes = New frm_AsignarMateriasADocentes()
        frm_AsignarMateriasADocentes.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frm_MenuDeAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        frmReporteEstudianteActivo.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frm_ListaDeUsuarios.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmReporteEstudianteInactivo.Show()
    End Sub
End Class