<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_RegistroDeUusarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRoles = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRO DE USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CEDULA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "APELLIDOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(516, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "SEXO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(516, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "FECHA DE NAC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(516, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DIRECCION"
        '
        'txtCedula
        '
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Location = New System.Drawing.Point(48, 389)
        Me.txtCedula.MinimumSize = New System.Drawing.Size(370, 35)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(370, 22)
        Me.txtCedula.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(48, 114)
        Me.txtNombre.MinimumSize = New System.Drawing.Size(370, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 22)
        Me.txtNombre.TabIndex = 10
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Location = New System.Drawing.Point(51, 179)
        Me.txtApellido.MinimumSize = New System.Drawing.Size(370, 35)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(370, 22)
        Me.txtApellido.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(517, 257)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(370, 22)
        Me.txtDireccion.TabIndex = 14
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaNac.Location = New System.Drawing.Point(517, 119)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(370, 22)
        Me.dtpFechaNac.TabIndex = 15
        Me.dtpFechaNac.Value = New Date(2005, 1, 5, 0, 0, 0, 0)
        '
        'cmbSexo
        '
        Me.cmbSexo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.DropDownWidth = 370
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.ItemHeight = 16
        Me.cmbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexo.Location = New System.Drawing.Point(517, 190)
        Me.cmbSexo.MaximumSize = New System.Drawing.Size(110, 0)
        Me.cmbSexo.MinimumSize = New System.Drawing.Size(370, 0)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(370, 24)
        Me.cmbSexo.TabIndex = 17
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(503, 475)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(168, 64)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(48, 460)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(370, 22)
        Me.txtContrasena.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "CONSTRASENA DE ACCESO"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbRoles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbSexo)
        Me.Panel1.Controls.Add(Me.dtpFechaNac)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.txtContrasena)
        Me.Panel1.Controls.Add(Me.txtApellido)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCedula)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(32, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 561)
        Me.Panel1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Rol del Usuario a Crear"
        '
        'cmbRoles
        '
        Me.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoles.FormattingEnabled = True
        Me.cmbRoles.Location = New System.Drawing.Point(54, 257)
        Me.cmbRoles.Name = "cmbRoles"
        Me.cmbRoles.Size = New System.Drawing.Size(380, 24)
        Me.cmbRoles.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(786, 498)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 41)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(786, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 41)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Limpiar Datos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capa_Presentacion.My.Resources.Resources.logousuario1
        Me.PictureBox1.Location = New System.Drawing.Point(646, 320)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frm_RegistroDeUusarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1017, 648)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_RegistroDeUusarios"
        Me.Text = "frm_Usuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbRoles As ComboBox
End Class
