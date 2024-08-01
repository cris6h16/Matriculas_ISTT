<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarMateriasADocentes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_asignaciones = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asignatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedulaDocente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidoDocente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminarCol = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_asignaturas = New System.Windows.Forms.DataGridView()
        Me.nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgw_docentes = New System.Windows.Forms.DataGridView()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_periodos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_regersar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgv_asignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_asignaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw_docentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_asignaciones
        '
        Me.dgv_asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_asignaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.asignatura, Me.periodo, Me.cedulaDocente, Me.docente, Me.apellidoDocente, Me.eliminarCol})
        Me.dgv_asignaciones.Location = New System.Drawing.Point(12, 500)
        Me.dgv_asignaciones.Name = "dgv_asignaciones"
        Me.dgv_asignaciones.RowHeadersWidth = 51
        Me.dgv_asignaciones.RowTemplate.Height = 24
        Me.dgv_asignaciones.Size = New System.Drawing.Size(1203, 181)
        Me.dgv_asignaciones.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 60
        '
        'asignatura
        '
        Me.asignatura.HeaderText = "Asignatura"
        Me.asignatura.MinimumWidth = 6
        Me.asignatura.Name = "asignatura"
        Me.asignatura.Width = 220
        '
        'periodo
        '
        Me.periodo.HeaderText = "Periodo"
        Me.periodo.MinimumWidth = 6
        Me.periodo.Name = "periodo"
        Me.periodo.Width = 125
        '
        'cedulaDocente
        '
        Me.cedulaDocente.HeaderText = "Cedula del Docente"
        Me.cedulaDocente.MinimumWidth = 6
        Me.cedulaDocente.Name = "cedulaDocente"
        Me.cedulaDocente.Width = 125
        '
        'docente
        '
        Me.docente.HeaderText = "Nombre del Docente"
        Me.docente.MinimumWidth = 6
        Me.docente.Name = "docente"
        Me.docente.Width = 250
        '
        'apellidoDocente
        '
        Me.apellidoDocente.HeaderText = "Apellido del Docente"
        Me.apellidoDocente.MinimumWidth = 6
        Me.apellidoDocente.Name = "apellidoDocente"
        Me.apellidoDocente.Width = 230
        '
        'eliminarCol
        '
        Me.eliminarCol.HeaderText = "Eliminar"
        Me.eliminarCol.MinimumWidth = 6
        Me.eliminarCol.Name = "eliminarCol"
        Me.eliminarCol.Text = "Eliminar"
        Me.eliminarCol.Width = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(434, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ASIGNAR MATERIAS A DOCENTES"
        '
        'dgv_asignaturas
        '
        Me.dgv_asignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_asignaturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nivel, Me.nombre, Me.carrera})
        Me.dgv_asignaturas.Location = New System.Drawing.Point(12, 96)
        Me.dgv_asignaturas.Name = "dgv_asignaturas"
        Me.dgv_asignaturas.RowHeadersWidth = 51
        Me.dgv_asignaturas.RowTemplate.Height = 24
        Me.dgv_asignaturas.Size = New System.Drawing.Size(566, 168)
        Me.dgv_asignaturas.TabIndex = 7
        '
        'nivel
        '
        Me.nivel.HeaderText = "Nivel"
        Me.nivel.MinimumWidth = 6
        Me.nivel.Name = "nivel"
        Me.nivel.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 220
        '
        'carrera
        '
        Me.carrera.HeaderText = "Carrera"
        Me.carrera.MinimumWidth = 6
        Me.carrera.Name = "carrera"
        Me.carrera.Width = 220
        '
        'dgw_docentes
        '
        Me.dgw_docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_docentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.nombres, Me.apellidos})
        Me.dgw_docentes.Location = New System.Drawing.Point(671, 96)
        Me.dgw_docentes.Name = "dgw_docentes"
        Me.dgw_docentes.RowHeadersWidth = 51
        Me.dgw_docentes.RowTemplate.Height = 24
        Me.dgw_docentes.Size = New System.Drawing.Size(544, 168)
        Me.dgw_docentes.TabIndex = 8
        '
        'cedula
        '
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.MinimumWidth = 6
        Me.cedula.Name = "cedula"
        Me.cedula.Width = 125
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.MinimumWidth = 6
        Me.nombres.Name = "nombres"
        Me.nombres.Width = 180
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.MinimumWidth = 6
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Width = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ASIGNATURAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(667, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "DOCENTES"
        '
        'cbx_periodos
        '
        Me.cbx_periodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_periodos.FormattingEnabled = True
        Me.cbx_periodos.Location = New System.Drawing.Point(574, 279)
        Me.cbx_periodos.Name = "cbx_periodos"
        Me.cbx_periodos.Size = New System.Drawing.Size(217, 33)
        Me.cbx_periodos.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(347, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "PERIODO ACADEMICO"
        '
        'btn_regersar
        '
        Me.btn_regersar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_regersar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regersar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_regersar.Location = New System.Drawing.Point(1046, 687)
        Me.btn_regersar.Name = "btn_regersar"
        Me.btn_regersar.Size = New System.Drawing.Size(130, 41)
        Me.btn_regersar.TabIndex = 31
        Me.btn_regersar.Text = "Regresar"
        Me.btn_regersar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(502, 353)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(260, 64)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "ASIGNAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 468)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 29)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "ASIGNACIONES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.dgw_docentes)
        Me.Panel1.Controls.Add(Me.btn_regersar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dgv_asignaciones)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dgv_asignaturas)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbx_periodos)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 749)
        Me.Panel1.TabIndex = 33
        '
        'frm_AsignarMateriasADocentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 795)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_AsignarMateriasADocentes"
        Me.Text = "frm_AsignarMateriasADocentes"
        CType(Me.dgv_asignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_asignaturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw_docentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_asignaciones As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_asignaturas As DataGridView
    Friend WithEvents dgw_docentes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_periodos As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_regersar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents nivel As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents carrera As DataGridViewTextBoxColumn
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents asignatura As DataGridViewTextBoxColumn
    Friend WithEvents periodo As DataGridViewTextBoxColumn
    Friend WithEvents cedulaDocente As DataGridViewTextBoxColumn
    Friend WithEvents docente As DataGridViewTextBoxColumn
    Friend WithEvents apellidoDocente As DataGridViewTextBoxColumn
    Friend WithEvents eliminarCol As DataGridViewButtonColumn
    Friend WithEvents Panel1 As Panel
End Class
