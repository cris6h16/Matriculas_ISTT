Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_RegistroDeCarrera

    Private negocioCarrera As Negocio_Carrera

    Public Sub New()
        InitializeComponent()
        Me.negocioCarrera = New Negocio_Carrera(New Dato_Carrera)

        ' agregar modalidades en el combobox
        For Each modalidad As EModalidad In [Enum].GetValues(GetType(EModalidad))
            cmbModalidades.Items.Add(modalidad.ToString)
        Next

        ' 
        Me.cbxDuracionSemestres.SelectedIndex = 0
        Me.cmbModalidades.SelectedIndex = 0

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtNombre.Text
        Dim duracion As String = cbxDuracionSemestres.SelectedItem.ToString
        Dim modalidad As String = cmbModalidades.SelectedItem.ToString

        Dim emodalidad As EModalidad = CType([Enum].Parse(GetType(EModalidad), modalidad), EModalidad)
        Dim carrera As New Entidad_Carrera(0, nombre, duracion, emodalidad)
        Try
            Me.negocioCarrera.crear(carrera)
            MsgBox("Carrera creada correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.txtNombre.Clear()
        Me.cbxDuracionSemestres.SelectedIndex = 0
        Me.cmbModalidades.SelectedIndex = 0
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Hide()
        frmPrincipal.frm_MenuDeAdministrador.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class