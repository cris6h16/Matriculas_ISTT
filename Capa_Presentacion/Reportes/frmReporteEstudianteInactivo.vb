﻿

Imports Capa_Datos
Imports Capa_Negocio
Imports Microsoft.Reporting.WinForms
Imports Org.BouncyCastle.Asn1

Public Class frmReporteEstudianteInactivo
    Private negocioUsuario As Negocio_Usuario

    Public Sub New()
        InitializeComponent()
        negocioUsuario = New Negocio_Usuario(New Dato_Usuario())
    End Sub

    Private Sub frmReporteEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rvEstudiante.RefreshReport()
        cargardata()
    End Sub
    Private Sub cargardata()
        ' Dim obj As New Negocio_Usuario();
        Dim ds As DataSet = negocioUsuario.listarInactivosDataSet()

        ' Asigna el DataSet al ReportViewer
        rvEstudiante.LocalReport.DataSources.Clear()
        rvEstudiante.LocalReport.DataSources.Add(New ReportDataSource("dsEstudiantes", ds.Tables("estudiantes")))
        rvEstudiante.RefreshReport()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

    End Sub

    Private Sub rvEstudiante_Load(sender As Object, e As EventArgs) Handles rvEstudiante.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
