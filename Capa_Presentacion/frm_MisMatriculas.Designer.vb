<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MisMatriculas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_MisMatriculas = New System.Windows.Forms.DataGridView()
        Me.asignaturas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoDeMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_MisMatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(564, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 36)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "MIS MATRICULAS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.dgv_MisMatriculas)
        Me.Panel1.Location = New System.Drawing.Point(-8, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1405, 484)
        Me.Panel1.TabIndex = 27
        '
        'dgv_MisMatriculas
        '
        Me.dgv_MisMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_MisMatriculas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.asignaturas, Me.periodo, Me.docente, Me.tipoDeMatricula, Me.modalidad})
        Me.dgv_MisMatriculas.Location = New System.Drawing.Point(128, 73)
        Me.dgv_MisMatriculas.Name = "dgv_MisMatriculas"
        Me.dgv_MisMatriculas.RowHeadersWidth = 51
        Me.dgv_MisMatriculas.RowTemplate.Height = 24
        Me.dgv_MisMatriculas.Size = New System.Drawing.Size(1074, 339)
        Me.dgv_MisMatriculas.TabIndex = 15
        '
        'asignaturas
        '
        Me.asignaturas.HeaderText = "Asignaturas"
        Me.asignaturas.MinimumWidth = 6
        Me.asignaturas.Name = "asignaturas"
        Me.asignaturas.Width = 300
        '
        'periodo
        '
        Me.periodo.HeaderText = "Periodo"
        Me.periodo.MinimumWidth = 6
        Me.periodo.Name = "periodo"
        Me.periodo.Width = 125
        '
        'docente
        '
        Me.docente.HeaderText = "Docente"
        Me.docente.MinimumWidth = 6
        Me.docente.Name = "docente"
        Me.docente.Width = 340
        '
        'tipoDeMatricula
        '
        Me.tipoDeMatricula.HeaderText = "Tipo de Matricula"
        Me.tipoDeMatricula.MinimumWidth = 6
        Me.tipoDeMatricula.Name = "tipoDeMatricula"
        Me.tipoDeMatricula.Width = 125
        '
        'modalidad
        '
        Me.modalidad.HeaderText = "Modalidad"
        Me.modalidad.MinimumWidth = 6
        Me.modalidad.Name = "modalidad"
        Me.modalidad.Width = 125
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(1174, 643)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 41)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Cerrar Secion"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'frm_MisMatriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1396, 715)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_MisMatriculas"
        Me.Text = "frm_MisMatriculas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_MisMatriculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_MisMatriculas As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents asignaturas As DataGridViewTextBoxColumn
    Friend WithEvents periodo As DataGridViewTextBoxColumn
    Friend WithEvents docente As DataGridViewTextBoxColumn
    Friend WithEvents tipoDeMatricula As DataGridViewTextBoxColumn
    Friend WithEvents modalidad As DataGridViewTextBoxColumn
End Class
