Imports Capa_Entidades

Public Class frm_MenuDeDocente
    Public docente As Entidad_Usuario
    Public Shared Property frm_MatricularEstudiante As frm_MatricularEstudiante

    Public Sub New(docente As Entidad_Usuario)
        InitializeComponent()
        Me.docente = docente
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_MatricularEstudiante = New frm_MatricularEstudiante(docente)
        frm_MatricularEstudiante.Show()
        Me.Hide()
    End Sub
End Class