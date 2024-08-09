<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ListaDeUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tablaUsuarios = New System.Windows.Forms.DataGridView()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ROL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificarCol = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.txb_filtrar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tablaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablaUsuarios
        '
        Me.tablaUsuarios.AllowUserToAddRows = False
        Me.tablaUsuarios.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Foto, Me.ROL, Me.cedula, Me.nombres, Me.apellidos, Me.sexo, Me.nacimiento, Me.modificarCol})
        Me.tablaUsuarios.Location = New System.Drawing.Point(31, 120)
        Me.tablaUsuarios.Name = "tablaUsuarios"
        Me.tablaUsuarios.ReadOnly = True
        Me.tablaUsuarios.RowHeadersWidth = 51
        Me.tablaUsuarios.RowTemplate.Height = 24
        Me.tablaUsuarios.Size = New System.Drawing.Size(1290, 376)
        Me.tablaUsuarios.TabIndex = 1
        '
        'Foto
        '
        Me.Foto.Frozen = True
        Me.Foto.HeaderText = "Foto"
        Me.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Foto.MinimumWidth = 50
        Me.Foto.Name = "Foto"
        Me.Foto.ReadOnly = True
        Me.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Foto.Width = 50
        '
        'ROL
        '
        Me.ROL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ROL.FillWeight = 11.0!
        Me.ROL.HeaderText = "ROL"
        Me.ROL.MinimumWidth = 50
        Me.ROL.Name = "ROL"
        Me.ROL.ReadOnly = True
        '
        'cedula
        '
        Me.cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cedula.FillWeight = 18.0!
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.MinimumWidth = 6
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'nombres
        '
        Me.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombres.FillWeight = 21.06999!
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.MinimumWidth = 6
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        '
        'apellidos
        '
        Me.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.apellidos.FillWeight = 21.06999!
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.MinimumWidth = 6
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        '
        'sexo
        '
        Me.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sexo.FillWeight = 5.750282!
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.MinimumWidth = 6
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        '
        'nacimiento
        '
        Me.nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nacimiento.FillWeight = 9.0!
        Me.nacimiento.HeaderText = "Nacimiento"
        Me.nacimiento.MinimumWidth = 27
        Me.nacimiento.Name = "nacimiento"
        Me.nacimiento.ReadOnly = True
        '
        'modificarCol
        '
        Me.modificarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.modificarCol.FillWeight = 8.083086!
        Me.modificarCol.HeaderText = "ACTIVAR / DESACTIVAR"
        Me.modificarCol.MinimumWidth = 6
        Me.modificarCol.Name = "modificarCol"
        Me.modificarCol.ReadOnly = True
        Me.modificarCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.modificarCol.Text = "Modificar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.LightCoral
        Me.btn_eliminar.Location = New System.Drawing.Point(71, 528)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(139, 50)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_modificar.Location = New System.Drawing.Point(233, 528)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(139, 50)
        Me.btn_modificar.TabIndex = 3
        Me.btn_modificar.Text = "MODIFICAR"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'txb_filtrar
        '
        Me.txb_filtrar.Font = New System.Drawing.Font("Noto Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txb_filtrar.Location = New System.Drawing.Point(243, 61)
        Me.txb_filtrar.Name = "txb_filtrar"
        Me.txb_filtrar.Size = New System.Drawing.Size(190, 31)
        Me.txb_filtrar.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(47, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "buscar por CEDULA"
        '
        'frm_ListaDeUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 664)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txb_filtrar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.tablaUsuarios)
        Me.Name = "frm_ListaDeUsuarios"
        Me.Text = "Form1"
        CType(Me.tablaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tablaUsuarios As DataGridView
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents txb_filtrar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents ROL As DataGridViewTextBoxColumn
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents modificarCol As DataGridViewButtonColumn
End Class
