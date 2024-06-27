<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RegistroDeAsignatura
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
        Me.btn_regersar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCarreras = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_niveles = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_regersar
        '
        Me.btn_regersar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_regersar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regersar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_regersar.Location = New System.Drawing.Point(716, 459)
        Me.btn_regersar.Name = "btn_regersar"
        Me.btn_regersar.Size = New System.Drawing.Size(130, 41)
        Me.btn_regersar.TabIndex = 25
        Me.btn_regersar.Text = "Regresar"
        Me.btn_regersar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(716, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 41)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Limpiar Datos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(503, 436)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(168, 64)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(53, 175)
        Me.txtDescripcion.MinimumSize = New System.Drawing.Size(370, 35)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(370, 35)
        Me.txtDescripcion.TabIndex = 27
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(50, 110)
        Me.txtNombre.MinimumSize = New System.Drawing.Size(370, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 35)
        Me.txtNombre.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "NOMBRE DE LA ASIGNATURA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "DESCRIPCION DE LA ASIGNATURA"
        '
        'cmbCarreras
        '
        Me.cmbCarreras.FormattingEnabled = True
        Me.cmbCarreras.Location = New System.Drawing.Point(53, 247)
        Me.cmbCarreras.Name = "cmbCarreras"
        Me.cmbCarreras.Size = New System.Drawing.Size(380, 24)
        Me.cmbCarreras.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CARRERA A LA QUE PERTENECE LA ASIGNATURA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "NIVEL AL QUE PERTENECE LA CARRERA"
        '
        'cmb_niveles
        '
        Me.cmb_niveles.FormattingEnabled = True
        Me.cmb_niveles.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"})
        Me.cmb_niveles.Location = New System.Drawing.Point(53, 309)
        Me.cmb_niveles.Name = "cmb_niveles"
        Me.cmb_niveles.Size = New System.Drawing.Size(380, 24)
        Me.cmb_niveles.TabIndex = 32
        '
        'frm_RegistroDeAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 543)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_niveles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCarreras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btn_regersar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frm_RegistroDeAsignatura"
        Me.Text = "frm_RegistroDeAsignaturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_regersar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCarreras As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_niveles As ComboBox
End Class
