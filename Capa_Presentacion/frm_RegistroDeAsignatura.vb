Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_RegistroDeAsignatura

    Private carreraNegocio As Negocio_Carrera
    Private carrerasHS As HashSet(Of Entidad_Carrera)

    Public Sub New()
        InitializeComponent()
        Me.carreraNegocio = New Negocio_Carrera(New Dato_Carrera())

        Try
            Me.carrerasHS = Me.carreraNegocio.ListarCarreras()
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

        Dim nombre As String = txtNombre.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim carrera As Entidad_Carrera = Me.ObtenerCarreraSeleccionada()
        Dim nivel As String = cmb_niveles.SelectedItem.ToString

        Dim asignatura As New Entidad_Asignatura(0, nombre, descripcion, carrera, nivel)

        Try
            Me.asignaturaNegocio.crear(asignatura)
            MsgBox("Asignatura creada correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function ObtenerCarreraSeleccionada() As Entidad_Carrera
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
        frm_MenuDeAdministrador.Show()
    End Sub
End Class