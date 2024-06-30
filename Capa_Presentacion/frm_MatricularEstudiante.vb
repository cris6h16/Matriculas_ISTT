Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_MatricularEstudiante

    Private asignaturasNegocio As Negocio_Asignatura
    Private distribuirNegocio As Negocio_Distribuir
    Private usuarioNegocio As Negocio_Usuario

    Private docente As Entidad_Usuario
    Private misAsignaciones As HashSet(Of Entidad_Distribuir) ' contiene mis materias asignadas

    Public Sub New(docente As Entidad_Usuario)
        InitializeComponent()
        Me.docente = docente
        cargarMisAsignaturas()
    End Sub

    Private Sub cargarMisAsignaturas()
        Try
            misAsignaciones = distribuirNegocio.listarPorIdUsuario(docente.Id)
            If misAsignaciones.Count <= 0 Then
                Throw New Exception("No tiene asignaturas asignadas, por lo cual no puede matricular estudiantes")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

        For Each distribuir As Entidad_Distribuir In misAsignaciones
            cbx_asignaturas.Items.Add(distribuir.Asignatura.Nombre)
        Next

        cbx_asignaturas.SelectedIndex = 0
        txb_materiaMatriculados.Text = cbx_asignaturas.SelectedItem.ToString
        cargarMatriculados()
    End Sub

    Private Sub cargarMatriculados()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_matriculados.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cedula As String = tbx_cedula.Text
        Dim usuario As Entidad_Usuario

        Try
            usuario = usuarioNegocio.traerPorCedula(cedula)
        Catch ex As Exception
            MsgBox(ex.Message)
            busquedaFallida()
            Return
        End Try

        txb_nombres.Text = usuario.Nombres
        txb_apellidos.Text = usuario.Apellidos
        txtDireccion.Text = usuario.Direccion
        txb_sexo.Text = usuario.Sexo
        dtpFechaNac.Value = usuario.Nacimiento
        txb_rol.Text = usuario.Rol.ToString

        ' activar boton
        btn_matricular.BackColor = Color.Yellow
        btn_matricular.Enabled = True
    End Sub

    Private Sub busquedaFallida()
        ' desactivar boton
        btn_matricular.BackColor = Color.LightYellow
        btn_matricular.Enabled = False
        ' limpiar campos de usuario
        txb_nombres.Clear()
        txb_apellidos.Clear()
        txtDireccion.Clear()
        txb_sexo.Clear()
        dtpFechaNac.Value = Date.Now
        txb_rol.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_matricular.Click

    End Sub

    Private Sub cbx_asignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_asignaturas.SelectedIndexChanged
        txb_materiaMatriculados.Text = cbx_asignaturas.SelectedItem.ToString
        cargarMatriculados()
    End Sub
End Class