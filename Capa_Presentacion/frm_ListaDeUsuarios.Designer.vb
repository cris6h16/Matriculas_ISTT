<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListaDeUsuarios
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
        Me.tablaUsuarios = New System.Windows.Forms.DataGridView()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ROL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificarCol = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.tablaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablaUsuarios
        '
        Me.tablaUsuarios.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Foto, Me.ROL, Me.cedula, Me.nombres, Me.apellidos, Me.sexo, Me.nacimiento, Me.modificarCol})
        Me.tablaUsuarios.Location = New System.Drawing.Point(12, 116)
        Me.tablaUsuarios.Name = "tablaUsuarios"
        Me.tablaUsuarios.RowHeadersWidth = 51
        Me.tablaUsuarios.RowTemplate.Height = 24
        Me.tablaUsuarios.Size = New System.Drawing.Size(1290, 376)
        Me.tablaUsuarios.TabIndex = 1
        '
        'Foto
        '
        Me.Foto.HeaderText = "Foto"
        Me.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Foto.MinimumWidth = 50
        Me.Foto.Name = "Foto"
        Me.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Foto.Width = 50
        '
        'ROL
        '
        Me.ROL.HeaderText = "ROL"
        Me.ROL.MinimumWidth = 6
        Me.ROL.Name = "ROL"
        Me.ROL.Width = 125
        '
        'cedula
        '
        Me.cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cedula.FillWeight = 20.85341!
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.MinimumWidth = 6
        Me.cedula.Name = "cedula"
        '
        'nombres
        '
        Me.nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombres.FillWeight = 20.85341!
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.MinimumWidth = 6
        Me.nombres.Name = "nombres"
        '
        'apellidos
        '
        Me.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.apellidos.FillWeight = 20.85341!
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.MinimumWidth = 6
        Me.apellidos.Name = "apellidos"
        '
        'sexo
        '
        Me.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sexo.FillWeight = 5.691175!
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.MinimumWidth = 6
        Me.sexo.Name = "sexo"
        '
        'nacimiento
        '
        Me.nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nacimiento.FillWeight = 8.341364!
        Me.nacimiento.HeaderText = "Nacimiento"
        Me.nacimiento.MinimumWidth = 27
        Me.nacimiento.Name = "nacimiento"
        '
        'modificarCol
        '
        Me.modificarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.modificarCol.HeaderText = "ACTIVAR / DESACTIVAR"
        Me.modificarCol.MinimumWidth = 6
        Me.modificarCol.Name = "modificarCol"
        Me.modificarCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.modificarCol.Text = "Modificar"
        Me.modificarCol.Width = 150
        '
        'frm_ListaDeUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 664)
        Me.Controls.Add(Me.tablaUsuarios)
        Me.Name = "frm_ListaDeUsuarios"
        Me.Text = "Form1"
        CType(Me.tablaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablaUsuarios As DataGridView
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents ROL As DataGridViewTextBoxColumn
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents modificarCol As DataGridViewButtonColumn
End Class
