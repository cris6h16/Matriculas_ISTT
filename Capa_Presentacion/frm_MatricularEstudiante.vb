Imports System.Management
Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_MatricularEstudiante

    Private asignaturasNegocio As Negocio_Asignatura
    Private distribuirNegocio As Negocio_Distribuir
    Private usuarioNegocio As Negocio_Usuario
    Private matriculaAAsignaturaNegocio As Negocio_MatriculaAAsignatura

    Private docente As Entidad_Usuario
    Private misAsignaciones As HashSet(Of Entidad_Distribuir) ' contiene mis materias asignadas
    Private matriculadosEnLaAsignaturaSeleccionada As HashSet(Of Entidad_MatriculaAAsignatura)


    Public Sub New(docente As Entidad_Usuario)
        InitializeComponent()

        ' creo capa de datos
        Dim datoUsuario As Dato_Usuario = New Dato_Usuario()
        Dim datoCarrera As Dato_Carrera = New Dato_Carrera()
        Dim datoPeriodo As Dato_Periodo = New Dato_Periodo()
        Dim datoAsignatura As Dato_Asignatura = New Dato_Asignatura(datoCarrera)
        Dim datoDistribuir As Dato_Distribuir = New Dato_Distribuir(datoAsignatura, datoUsuario, datoPeriodo)
        Dim datoMatriculaAAsignatura As Dato_MatriculaAAsignatura = New Dato_MatriculaAAsignatura(datoUsuario, datoAsignatura, datoPeriodo)

        ' creo capa de negocio asignando capa de datos
        Me.asignaturasNegocio = New Negocio_Asignatura(datoAsignatura)
        Me.distribuirNegocio = New Negocio_Distribuir(datoDistribuir, datoUsuario, datoPeriodo, datoAsignatura)
        Me.usuarioNegocio = New Negocio_Usuario(datoUsuario)
        Me.matriculaAAsignaturaNegocio = New Negocio_MatriculaAAsignatura(datoMatriculaAAsignatura, datoPeriodo, datoAsignatura, datoUsuario)

        Me.docente = docente
        cargarMisAsignaturas()
        cargarTipoDeMatriculaYModalidad()
    End Sub

    Private Sub cargarTipoDeMatriculaYModalidad()
        'EModalidad.PRESENCIAL, EModalidad.DISTANCIA....

        For Each modalidad As EModalidad In [Enum].GetValues(GetType(EModalidad))
            cbx_modalidad.Items.Add(modalidad.ToString)
            cbx_modalidad.SelectedIndex = 0
        Next

        For Each tipoMatricula As ETipoDeMatricula In [Enum].GetValues(GetType(ETipoDeMatricula))
            cbx_tipoMatricula.Items.Add(tipoMatricula.ToString)
            cbx_tipoMatricula.SelectedIndex = 0
        Next
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
        'txb_periodo
        For Each asignacion As Entidad_Distribuir In misAsignaciones
            If asignacion.Asignatura.Nombre = txb_materiaMatriculados.Text Then
                txb_periodo.Text = asignacion.Periodo.Nombre
                Exit For
            End If
        Next
        cargarMatriculados()
    End Sub

    Private Sub cargarMatriculados()
        Dim idAsignaturaSeleccionada As Integer
        Dim idPeriodoCorrespondiente As Integer


        For Each asignacion As Entidad_Distribuir In misAsignaciones
            If asignacion.Asignatura.Nombre = txb_materiaMatriculados.Text Then
                idAsignaturaSeleccionada = asignacion.Asignatura.Id
                idPeriodoCorrespondiente = asignacion.Periodo.Id
                Exit For
            End If
        Next

        matriculadosEnLaAsignaturaSeleccionada = matriculaAAsignaturaNegocio.listarPorIdAsignaturaYIdPeriodo(
            idAsignaturaSeleccionada, idPeriodoCorrespondiente
        )

        dgv_matriculados.Rows.Clear()

        For Each matricula As Entidad_MatriculaAAsignatura In matriculadosEnLaAsignaturaSeleccionada
            dgv_matriculados.Rows.Add(
                matricula.Usuario.Cedula,
                matricula.Usuario.Nombres,
                matricula.Usuario.Apellidos,
                matricula.Usuario.Sexo,
                matricula.Usuario.Nacimiento
            )
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_matriculados.CellContentClick
        Dim idxBotonEliminar = dgv_matriculados.ColumnCount - 1
        If e.ColumnIndex = idxBotonEliminar Then
            Dim cedula As String = dgv_matriculados.Rows(e.RowIndex).Cells(0).Value

            Dim idUsuario As Integer
            Dim idAsignatura As Integer
            Dim idPeriodo As Integer

            ' obtener el id del usuario seleccionado de la tabla matriculados
            For Each matricula As Entidad_MatriculaAAsignatura In matriculadosEnLaAsignaturaSeleccionada
                If matricula.Usuario.Cedula = cedula Then
                    idUsuario = matricula.Usuario.Id
                    Exit For
                End If
            Next

            ' obtener el id de asignatura y el id periodo correspondiente
            For Each asignacion As Entidad_Distribuir In misAsignaciones
                If asignacion.Asignatura.Nombre = txb_materiaMatriculados.Text Then
                    idAsignatura = asignacion.Asignatura.Id
                    idPeriodo = asignacion.Periodo.Id
                    Exit For
                End If
            Next

            Try
                matriculaAAsignaturaNegocio.borrarPorIdUsuarioYIdAsignaturaYIdPeriodo(
                    idUsuario,
                    idAsignatura,
                    idPeriodo
                )
                MsgBox("Estudiante eliminado de la asignatura")
                cargarMatriculados()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
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

        Dim ceula As String = tbx_cedula.Text
        Dim tipoMatricula As ETipoDeMatricula = CType([Enum].Parse(GetType(ETipoDeMatricula), cbx_tipoMatricula.SelectedItem.ToString), ETipoDeMatricula)
        Dim modalidad As EModalidad = CType([Enum].Parse(GetType(EModalidad), cbx_modalidad.SelectedItem.ToString), EModalidad)
        Try
            Dim usuario As Entidad_Usuario = usuarioNegocio.traerPorCedula(ceula)
            Dim asignatura As Entidad_Asignatura
            Dim periodo As Entidad_Periodo

            If usuario.Rol <> ERoles.Estudiante Then
                Throw New Exception("Solo se pueden matricular a usuarios con el rol: Estudiante")
            End If

            For Each asignacion As Entidad_Distribuir In misAsignaciones
                If asignacion.Asignatura.Nombre = txb_materiaMatriculados.Text Then
                    asignatura = asignacion.Asignatura
                    periodo = asignacion.Periodo
                    Exit For
                End If
            Next

            matriculaAAsignaturaNegocio.crear(
                New Entidad_MatriculaAAsignatura(0, asignatura, usuario, periodo, tipoMatricula, modalidad)
            )
            MsgBox("Estudiante matriculado correctamente")
            cargarMatriculados()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cbx_asignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_asignaturas.SelectedIndexChanged
        txb_materiaMatriculados.Text = cbx_asignaturas.SelectedItem.ToString

        'txb_periodo
        For Each asignacion As Entidad_Distribuir In misAsignaciones
            If asignacion.Asignatura.Nombre = txb_materiaMatriculados.Text Then
                txb_periodo.Text = asignacion.Periodo.Nombre
                Exit For
            End If
        Next

        cargarMatriculados()
    End Sub

    Private Sub btn_regersar_Click(sender As Object, e As EventArgs) Handles btn_regersar.Click
        frmPrincipal.frm_MenuDeDocente.Show()
        Me.Close()
    End Sub

    Private Sub cbx_tipoMatricula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipoMatricula.SelectedIndexChanged

    End Sub
End Class