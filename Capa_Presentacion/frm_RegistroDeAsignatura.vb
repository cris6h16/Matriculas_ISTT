Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_RegistroDeAsignatura

    Private carreraNegocio As Negocio_Carrera
    Private asignaturaNegocio As Negocio_Asignatura
    Private carrerasHS As HashSet(Of Entidad_Carrera)

    Public Sub New()
        InitializeComponent()

        ' creo capa de datos
        Dim datoCarrera As Dato_Carrera = New Dato_Carrera()
        Dim datoAsignatura As Dato_Asignatura = New Dato_Asignatura(datoCarrera)

        ' creo capa de negocio asignando capa de datos
        Me.carreraNegocio = New Negocio_Carrera(datoCarrera)
        Me.asignaturaNegocio = New Negocio_Asignatura(datoAsignatura)

        Try
            Me.carrerasHS = Me.carreraNegocio.ListarCarreras()
            If carrerasHS.Count <= 0 Then
                Throw New Exception("No existen carreras registradas, debe registrar almenos 1 carrera antes de agregar asignaturas")
            End If
            For Each carrera As Entidad_Carrera In Me.carrerasHS
                cmbCarreras.Items.Add(carrera.Nombre)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frm_RegistroDeAsignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        Try
            Dim nombre As String = txtNombre.Text
            Dim descripcion As String = txtDescripcion.Text
            Dim carrera As Entidad_Carrera = Me.ObtenerCarreraSeleccionada()
            Dim nivel As String = cmb_niveles.SelectedItem.ToString

            Dim asignatura As New Entidad_Asignatura(0, nombre, descripcion, carrera, nivel)

            Me.asignaturaNegocio.crear(asignatura)
            MsgBox("Asignatura creada correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function ObtenerCarreraSeleccionada() As Entidad_Carrera
        If carrerasHS.Count < 1 Then
            Throw New Exception("Debe insertar carreras antes de agregar alguna materia")
        End If
        Dim nombreCarreraSeleccionada As String = cmbCarreras.SelectedItem.ToString()
        For Each carrera As Entidad_Carrera In Me.carrerasHS
            If carrera.Nombre = nombreCarreraSeleccionada Then
                Return carrera
            End If
        Next
        Return Nothing
    End Function


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btn_regersar_Click(sender As Object, e As EventArgs) Handles btn_regersar.Click
        Me.Hide()
        frmPrincipal.frm_MenuDeAdministrador.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class