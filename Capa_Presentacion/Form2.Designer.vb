<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRoles = New System.Windows.Forms.ComboBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ptbImagen = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbRoles)
        Me.Panel1.Controls.Add(Me.btn_actualizar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbSexo)
        Me.Panel1.Controls.Add(Me.dtpFechaNac)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.txtContrasena)
        Me.Panel1.Controls.Add(Me.txtApellido)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCedula)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(55, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 561)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.Controls.Add(Me.ptbImagen)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(541, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 148)
        Me.Panel2.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button3.Location = New System.Drawing.Point(160, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 52)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Cambiar de Foto"
        Me.Button3.UseVisualStyleBackColor = False
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
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_actualizar.Location = New System.Drawing.Point(605, 477)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(189, 71)
        Me.btn_actualizar.TabIndex = 21
        Me.btn_actualizar.Text = "ACTUALIZAR DATOS"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MODIFICAR USUARIO"
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
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(517, 257)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(370, 22)
        Me.txtDireccion.TabIndex = 14
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(48, 460)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(370, 22)
        Me.txtContrasena.TabIndex = 20
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
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(48, 114)
        Me.txtNombre.MinimumSize = New System.Drawing.Size(370, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 22)
        Me.txtNombre.TabIndex = 10
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
        'txtCedula
        '
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Location = New System.Drawing.Point(48, 389)
        Me.txtCedula.MinimumSize = New System.Drawing.Size(370, 35)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(370, 22)
        Me.txtCedula.TabIndex = 9
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
        'ptbImagen
        '
        Me.ptbImagen.Image = Global.Capa_Presentacion.My.Resources.Resources.logousuario1
        Me.ptbImagen.Location = New System.Drawing.Point(8, 9)
        Me.ptbImagen.Name = "ptbImagen"
        Me.ptbImagen.Size = New System.Drawing.Size(143, 131)
        Me.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbImagen.TabIndex = 16
        Me.ptbImagen.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ptbImagen As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbRoles As ComboBox
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
