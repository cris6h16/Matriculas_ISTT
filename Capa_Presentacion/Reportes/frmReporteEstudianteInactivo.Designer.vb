<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteEstudianteInactivo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMatriculas = New Capa_Presentacion.dsMatriculas()
        Me.rvEstudiantes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rvEstudiante = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.DsMatriculas
        '
        'DsMatriculas
        '
        Me.DsMatriculas.DataSetName = "dsMatriculas"
        Me.DsMatriculas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvEstudiantes
        '
        Me.rvEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvEstudiantes.Location = New System.Drawing.Point(0, 0)
        Me.rvEstudiantes.Name = "rvEstudiantes"
        Me.rvEstudiantes.ServerReport.BearerToken = Nothing
        Me.rvEstudiantes.Size = New System.Drawing.Size(1116, 527)
        Me.rvEstudiantes.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 22)
        Me.TextBox1.TabIndex = 0
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReporte.Location = New System.Drawing.Point(359, 8)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(132, 40)
        Me.btnReporte.TabIndex = 1
        Me.btnReporte.Text = "Cargar el Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 84)
        Me.Panel1.TabIndex = 1
        '
        'rvEstudiante
        '
        Me.rvEstudiante.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsEstudiantes"
        ReportDataSource1.Value = Me.EstudiantesBindingSource
        Me.rvEstudiante.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvEstudiante.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.rEstudiantes.rdlc"
        Me.rvEstudiante.Location = New System.Drawing.Point(0, 84)
        Me.rvEstudiante.Name = "rvEstudiante"
        Me.rvEstudiante.ServerReport.BearerToken = Nothing
        Me.rvEstudiante.Size = New System.Drawing.Size(1116, 443)
        Me.rvEstudiante.TabIndex = 2
        '
        'frmReporteEstudianteInactivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 527)
        Me.Controls.Add(Me.rvEstudiante)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rvEstudiantes)
        Me.Name = "frmReporteEstudianteInactivo"
        Me.Text = "frmReporteEstudiante"
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMatriculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvEstudiantes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnReporte As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rvEstudiante As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstudiantesBindingSource As BindingSource
    Friend WithEvents DsMatriculas As dsMatriculas
End Class
