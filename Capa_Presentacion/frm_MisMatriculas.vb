Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_MisMatriculas

    Private matriculaAAsignatura As Negocio_MatriculaAAsignatura
    Private distribuirNegocio As Negocio_Distribuir

    Private estudiante As Entidad_Usuario

    Public Sub New(estudiante As Entidad_Usuario)
        InitializeComponent()

        ' creo capa de datos
        Dim datoUsuario As Dato_Usuario = New Dato_Usuario()
        Dim datoCarrera As Dato_Carrera = New Dato_Carrera()
        Dim datoPeriodo As Dato_Periodo = New Dato_Periodo()
        Dim datoAsignatura As Dato_Asignatura = New Dato_Asignatura(datoCarrera)
        Dim datoDistribuir As Dato_Distribuir = New Dato_Distribuir(datoAsignatura, datoUsuario, datoPeriodo)
        Dim datoMatriculasAAsignaturas As Dato_MatriculaAAsignatura = New Dato_MatriculaAAsignatura(datoUsuario, datoAsignatura, datoPeriodo)

        ' creo capa de negocio asignando capa de datos
        Me.matriculaAAsignatura = New Negocio_MatriculaAAsignatura(datoMatriculasAAsignaturas, datoPeriodo, datoAsignatura, datoUsuario)
        Me.distribuirNegocio = New Negocio_Distribuir(datoDistribuir, datoUsuario, datoPeriodo, datoAsignatura)

        Me.estudiante = estudiante
        cargarMisMatriculas()
    End Sub

    Private Sub cargarMisMatriculas()
        Try
            Dim miMatricula As HashSet(Of Entidad_MatriculaAAsignatura) = matriculaAAsignatura.listarPorIdUsuario(estudiante.Id)

        dgv_MisMatriculas.Rows.Clear()

            For Each matricula As Entidad_MatriculaAAsignatura In miMatricula
                Dim distribucion As Entidad_Distribuir = distribuirNegocio.traerPorIdPeriodoYIdAsignatura(
                    matricula.Periodo.Id, matricula.Asignatura.Id
                )

                dgv_MisMatriculas.Rows.Add(
                    matricula.Asignatura.Nombre,
                    matricula.Periodo.Nombre,
                    distribucion.Usuario.Nombres + " " + distribucion.Usuario.Apellidos,
                    matricula.TipoDeMatricula.ToString,
                    matricula.Modalidad.ToString
                )
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub
End Class