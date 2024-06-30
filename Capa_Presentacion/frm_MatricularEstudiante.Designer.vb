<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MatricularEstudiante
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_matricular = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbx_cedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_sexo = New System.Windows.Forms.TextBox()
        Me.txb_apellidos = New System.Windows.Forms.TextBox()
        Me.txb_nombres = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_asignaturas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_materiaMatriculados = New System.Windows.Forms.TextBox()
        Me.dgv_matriculados = New System.Windows.Forms.DataGridView()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matriculado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txb_rol = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_matriculados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cbx_asignaturas)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txb_materiaMatriculados)
        Me.Panel1.Controls.Add(Me.dgv_matriculados)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1025, 695)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.Controls.Add(Me.txb_rol)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btn_matricular)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txb_sexo)
        Me.Panel2.Controls.Add(Me.txb_apellidos)
        Me.Panel2.Controls.Add(Me.txb_nombres)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dtpFechaNac)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(3, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 280)
        Me.Panel2.TabIndex = 10
        '
        'btn_matricular
        '
        Me.btn_matricular.BackColor = System.Drawing.Color.LightYellow
        Me.btn_matricular.Enabled = False
        Me.btn_matricular.Location = New System.Drawing.Point(324, 226)
        Me.btn_matricular.Name = "btn_matricular"
        Me.btn_matricular.Size = New System.Drawing.Size(359, 41)
        Me.btn_matricular.TabIndex = 10
        Me.btn_matricular.Text = "MATRICULAR"
        Me.btn_matricular.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.tbx_cedula)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(3, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(994, 70)
        Me.Panel3.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGreen
        Me.Button1.Location = New System.Drawing.Point(657, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 41)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbx_cedula
        '
        Me.tbx_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_cedula.Location = New System.Drawing.Point(375, 19)
        Me.tbx_cedula.Name = "tbx_cedula"
        Me.tbx_cedula.Size = New System.Drawing.Size(250, 30)
        Me.tbx_cedula.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(85, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cedula del Estudante:"
        '
        'txb_sexo
        '
        Me.txb_sexo.Enabled = False
        Me.txb_sexo.Location = New System.Drawing.Point(649, 115)
        Me.txb_sexo.Name = "txb_sexo"
        Me.txb_sexo.Size = New System.Drawing.Size(113, 22)
        Me.txb_sexo.TabIndex = 32
        '
        'txb_apellidos
        '
        Me.txb_apellidos.Enabled = False
        Me.txb_apellidos.Location = New System.Drawing.Point(31, 176)
        Me.txb_apellidos.Name = "txb_apellidos"
        Me.txb_apellidos.Size = New System.Drawing.Size(309, 22)
        Me.txb_apellidos.TabIndex = 31
        '
        'txb_nombres
        '
        Me.txb_nombres.Enabled = False
        Me.txb_nombres.Location = New System.Drawing.Point(32, 117)
        Me.txb_nombres.Name = "txb_nombres"
        Me.txb_nombres.Size = New System.Drawing.Size(308, 22)
        Me.txb_nombres.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 22)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Apellidos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 22)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Nombres:"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaNac.Enabled = False
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaNac.Location = New System.Drawing.Point(393, 115)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(208, 22)
        Me.dtpFechaNac.TabIndex = 26
        Me.dtpFechaNac.Value = New Date(2005, 1, 5, 0, 0, 0, 0)
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(393, 176)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(567, 22)
        Me.txtDireccion.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(392, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "DIRECCION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(392, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "FECHA DE NAC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(645, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 19)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "SEXO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 22)
        Me.Label5.TabIndex = 10
        '
        'cbx_asignaturas
        '
        Me.cbx_asignaturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_asignaturas.FormattingEnabled = True
        Me.cbx_asignaturas.Location = New System.Drawing.Point(292, 79)
        Me.cbx_asignaturas.Name = "cbx_asignaturas"
        Me.cbx_asignaturas.Size = New System.Drawing.Size(603, 28)
        Me.cbx_asignaturas.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MATRICULAR ESTUDIANTES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccione la Materia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estudiantes Matriculados en la Materia:"
        '
        'txb_materiaMatriculados
        '
        Me.txb_materiaMatriculados.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.txb_materiaMatriculados.Location = New System.Drawing.Point(474, 418)
        Me.txb_materiaMatriculados.Name = "txb_materiaMatriculados"
        Me.txb_materiaMatriculados.Size = New System.Drawing.Size(526, 34)
        Me.txb_materiaMatriculados.TabIndex = 1
        '
        'dgv_matriculados
        '
        Me.dgv_matriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_matriculados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.nombres, Me.apellidos, Me.sexo, Me.nacimiento, Me.matriculado})
        Me.dgv_matriculados.Location = New System.Drawing.Point(3, 464)
        Me.dgv_matriculados.Name = "dgv_matriculados"
        Me.dgv_matriculados.RowHeadersWidth = 51
        Me.dgv_matriculados.RowTemplate.Height = 24
        Me.dgv_matriculados.Size = New System.Drawing.Size(997, 228)
        Me.dgv_matriculados.TabIndex = 0
        '
        'cedula
        '
        Me.cedula.FillWeight = 10.0!
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.MinimumWidth = 6
        Me.cedula.Name = "cedula"
        Me.cedula.Width = 130
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.MinimumWidth = 6
        Me.nombres.Name = "nombres"
        Me.nombres.Width = 280
        '
        'apellidos
        '
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.MinimumWidth = 6
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Width = 280
        '
        'sexo
        '
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.MinimumWidth = 6
        Me.sexo.Name = "sexo"
        Me.sexo.Width = 50
        '
        'nacimiento
        '
        Me.nacimiento.HeaderText = "Nacimiento"
        Me.nacimiento.MinimumWidth = 6
        Me.nacimiento.Name = "nacimiento"
        Me.nacimiento.Width = 125
        '
        'matriculado
        '
        Me.matriculado.HeaderText = "Matriculado"
        Me.matriculado.MinimumWidth = 6
        Me.matriculado.Name = "matriculado"
        Me.matriculado.Width = 80
        '
        'txb_rol
        '
        Me.txb_rol.Enabled = False
        Me.txb_rol.Location = New System.Drawing.Point(800, 115)
        Me.txb_rol.Name = "txb_rol"
        Me.txb_rol.Size = New System.Drawing.Size(143, 22)
        Me.txb_rol.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(796, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 19)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Rol"
        '
        'frm_MatricularEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 720)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_MatricularEstudiante"
        Me.Text = "frm_MatricularEstudiante"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv_matriculados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_matriculados As DataGridView
    Friend WithEvents txb_materiaMatriculados As TextBox
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents matriculado As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents tbx_cedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_asignaturas As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txb_apellidos As TextBox
    Friend WithEvents txb_nombres As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txb_sexo As TextBox
    Friend WithEvents btn_matricular As Button
    Friend WithEvents txb_rol As TextBox
    Friend WithEvents Label11 As Label
End Class
