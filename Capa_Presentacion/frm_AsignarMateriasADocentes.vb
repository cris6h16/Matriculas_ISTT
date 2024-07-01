Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_AsignarMateriasADocentes

    Private negocioAsignatura As Negocio_Asignatura
    Private negocioUsuaeio As Negocio_Usuario
    Private negocioDistribuir As Negocio_Distribuir
    Private negocioPeriodo As Negocio_Periodo

    Private asignaturas As HashSet(Of Entidad_Asignatura)
    Private docentes As HashSet(Of Entidad_Usuario)
    Private periodos As HashSet(Of Entidad_Periodo)
    Private asignaciones As HashSet(Of Entidad_Distribuir)

    Public Sub New()
        InitializeComponent()

        ' creo capa de datos
        Dim datoUsuario As Dato_Usuario = New Dato_Usuario()
        Dim datoCarrera As Dato_Carrera = New Dato_Carrera()
        Dim datoPeriodo As Dato_Periodo = New Dato_Periodo()
        Dim datoAsignatura As Dato_Asignatura = New Dato_Asignatura(datoCarrera)
        Dim datoDistribuir As Dato_Distribuir = New Dato_Distribuir(datoAsignatura, datoUsuario, datoPeriodo)

        ' creo capa de negocio asignando capa de datos
        Me.negocioAsignatura = New Negocio_Asignatura(datoAsignatura)
        Me.negocioUsuaeio = New Negocio_Usuario(datoUsuario)
        Me.negocioDistribuir = New Negocio_Distribuir(datoDistribuir, datoUsuario)
        Me.negocioPeriodo = New Negocio_Periodo(datoPeriodo)

        Try
            Me.cargarAsignaturas()
            Me.cargarDocentes()
            Me.cargarPeriodos()
            Me.cargarAsignaciones()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cargarAsignaciones()
        asignaciones = Me.negocioDistribuir.listar()

        ' limpiar tabla
        Me.dgv_asignaciones.Rows.Clear()

        ' iterar sobre las asignaciones
        For Each asignacion As Entidad_Distribuir In asignaciones
            Me.dgv_asignaciones.Rows.Add( ' por cada asignacion agregar una fila a la tabla
                asignacion.Id,
                asignacion.Asignatura.Nombre,
                asignacion.Periodo.Nombre,
                asignacion.Usuario.Cedula,
                asignacion.Usuario.Nombres,
                asignacion.Usuario.Apellidos
            )
        Next
    End Sub

    Private Sub cargarPeriodos()
        periodos = negocioPeriodo.listar()
        ' iterar sobre los periodos
        For Each periodo As Entidad_Periodo In periodos
            Me.cbx_periodos.Items.Add( ' por cada periodo agregar un item al combobox
                periodo.Nombre
            )
        Next

        If periodos.Count <= 0 Then
            Throw New Exception("No existen periodos registrados, debe registrar almenos 1 periodo antes de asignar materias a docentes")
        Else
            Me.cbx_periodos.SelectedIndex = 0
        End If
    End Sub

    Private Sub cargarDocentes()
        docentes = Me.negocioUsuaeio.listarTipoDeUsuario(ERoles.Docente)
        ' iterar sobre los docentes
        For Each docente As Entidad_Usuario In docentes
            Me.dgw_docentes.Rows.Add( ' por cada docente agregar una fila a la tabla
                docente.Cedula,
                docente.Nombres,
                docente.Apellidos
            )
        Next

        If docentes.Count <= 0 Then
            Throw New Exception("No existen docentes registrados, debe registrar almenos 1 docente antes de asignar materias")
        End If
    End Sub

    Private Sub cargarAsignaturas()
        asignaturas = Me.negocioAsignatura.listar()
        ' iterar sobre las asignaturas
        For Each asignatura As Entidad_Asignatura In asignaturas
            Me.dgv_asignaturas.Rows.Add( ' por cada asignatura agregar una fila a la tabla
                asignatura.Nivel,
                asignatura.Nombre,
                asignatura.Carrera.Nombre
            )
        Next

        If asignaturas.Count <= 0 Then
            Throw New Exception("No existen asignaturas registradas, debe registrar almenos 1 asignatura antes de asignar materias a docentes")
        End If
    End Sub

    Private Sub frm_AsignarMateriasADocentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim docente As Entidad_Usuario = Me.ObtenerDocenteSeleccionado()
            Dim asignatura As Entidad_Asignatura = Me.ObtenerAsignaturaSeleccionada()
            Dim periodo As Entidad_Periodo = Me.ObtenerPeriodoSeleccionado()

            Dim distribuir As New Entidad_Distribuir(0, docente, asignatura, periodo)

            Me.negocioDistribuir.crear(distribuir)
            MsgBox("Se ha asignado la materia al docente correctamente")

            Me.cargarAsignaciones()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ObtenerPeriodoSeleccionado() As Entidad_Periodo
        Dim nombre As String = Me.cbx_periodos.SelectedItem.ToString
        For Each periodo As Entidad_Periodo In Me.periodos
            If periodo.Nombre = nombre Then
                Return periodo
            End If
        Next
        Return Nothing
    End Function

    Private Function ObtenerAsignaturaSeleccionada() As Entidad_Asignatura
        Dim filaSeleccionada As Integer = Me.dgv_asignaturas.CurrentRow.Index
        Dim nombre As String = Me.dgv_asignaturas.Item(1, filaSeleccionada).Value.ToString
        For Each asignatura As Entidad_Asignatura In Me.asignaturas
            If asignatura.Nombre = nombre Then
                Return asignatura
            End If
        Next
        Return Nothing
    End Function

    Private Function ObtenerDocenteSeleccionado() As Entidad_Usuario
        Dim filaSeleccionada As Integer = Me.dgw_docentes.CurrentRow.Index
        Dim cedula As String = Me.dgw_docentes.Item(0, filaSeleccionada).Value.ToString
        For Each docente As Entidad_Usuario In Me.docentes
            If docente.Cedula = cedula Then
                Return docente
            End If
        Next
        Return Nothing
    End Function

    Private Sub dgv_asignaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_asignaciones.CellContentClick
        ' el boton eliminar es la ultima columna
        Dim IdxBotonEliminar = dgv_asignaciones.ColumnCount - 1

        ' si la columna clickeada es el boton eliminar
        If e.ColumnIndex = IdxBotonEliminar Then

            Dim filaSeleccionada As Integer = e.RowIndex
            Dim idAsignacion As Integer = Me.dgv_asignaciones.Item(0, filaSeleccionada).Value

            Dim result As DialogResult = MessageBox.Show("Desea eliminar asignacion?", "Eliminar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    negocioDistribuir.borrar(idAsignacion)
                    cargarAsignaciones()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btn_regersar_Click(sender As Object, e As EventArgs) Handles btn_regersar.Click
        frmPrincipal.frm_MenuDeAdministrador.Show()
        Me.Close()
    End Sub
End Class