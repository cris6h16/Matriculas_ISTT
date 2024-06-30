Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_RegistroDePeriodosAcademicos

    Private periodoNegocio As Negocio_Periodo

    Public Sub New()
        InitializeComponent()
        Me.periodoNegocio = New Negocio_Periodo(New Dato_Periodo())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txb_periodo.Text
        Dim fechaInicio As Date = dtp_fechaInicio.Value
        Dim fechaFin As Date = dtp_fechaFin.Value
        Try
            Dim periodo As New Entidad_Periodo(0, nombre, fechaInicio, fechaFin)
            Me.periodoNegocio.crear(periodo)
            MsgBox("Periodo creado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_regersar_Click(sender As Object, e As EventArgs) Handles btn_regersar.Click
        Me.Hide()
        frm_MenuDeAdministrador.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.txb_periodo.Clear()
    End Sub
End Class