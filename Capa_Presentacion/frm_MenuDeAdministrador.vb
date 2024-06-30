Public Class frm_MenuDeAdministrador

    Public frm_RegistroDeUusarios As frm_RegistroDeUusarios
    Public frm_RegistroDeCarrera As frm_RegistroDeCarrera
    Public frm_RegistroDeAsignatura As frm_RegistroDeAsignatura
    Public frm_RegistroDePeriodosAcademicos As frm_RegistroDePeriodosAcademicos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.frm_RegistroDeUusarios = New frm_RegistroDeUusarios()
        Me.frm_RegistroDeUusarios.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.frm_RegistroDeCarrera = New frm_RegistroDeCarrera()
        Me.frm_RegistroDeCarrera.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.frm_RegistroDeAsignatura = New frm_RegistroDeAsignatura()
        Me.frm_RegistroDeAsignatura.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.frm_RegistroDePeriodosAcademicos = New frm_RegistroDePeriodosAcademicos()
        Me.frm_RegistroDePeriodosAcademicos.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class