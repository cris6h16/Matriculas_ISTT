<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RegistroDePeriodosAcademicos
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
        Me.btn_regersar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dtp_fechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_periodo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_regersar)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.dtp_fechaFin)
        Me.Panel1.Controls.Add(Me.dtp_fechaInicio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txb_periodo)
        Me.Panel1.Location = New System.Drawing.Point(35, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 468)
        Me.Panel1.TabIndex = 0
        '
        'btn_regersar
        '
        Me.btn_regersar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_regersar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regersar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_regersar.Location = New System.Drawing.Point(726, 365)
        Me.btn_regersar.Name = "btn_regersar"
        Me.btn_regersar.Size = New System.Drawing.Size(130, 41)
        Me.btn_regersar.TabIndex = 28
        Me.btn_regersar.Text = "Regresar"
        Me.btn_regersar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(726, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 41)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Limpiar Datos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(513, 342)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(168, 64)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'dtp_fechaFin
        '
        Me.dtp_fechaFin.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fechaFin.Location = New System.Drawing.Point(496, 209)
        Me.dtp_fechaFin.Name = "dtp_fechaFin"
        Me.dtp_fechaFin.Size = New System.Drawing.Size(350, 30)
        Me.dtp_fechaFin.TabIndex = 8
        '
        'dtp_fechaInicio
        '
        Me.dtp_fechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fechaInicio.Location = New System.Drawing.Point(47, 209)
        Me.dtp_fechaInicio.Name = "dtp_fechaInicio"
        Me.dtp_fechaInicio.Size = New System.Drawing.Size(350, 30)
        Me.dtp_fechaInicio.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(491, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de Fin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha de Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ejemplo: 2022-IIP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre del periodo academico"
        '
        'txb_periodo
        '
        Me.txb_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_periodo.Location = New System.Drawing.Point(47, 66)
        Me.txb_periodo.Name = "txb_periodo"
        Me.txb_periodo.Size = New System.Drawing.Size(368, 30)
        Me.txb_periodo.TabIndex = 0
        '
        'frm_RegistroDePeriodosAcademicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(945, 507)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_RegistroDePeriodosAcademicos"
        Me.Text = "frm_RegistroDePeriodosAcademicos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txb_periodo As TextBox
    Friend WithEvents dtp_fechaInicio As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_fechaFin As DateTimePicker
    Friend WithEvents btn_regersar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGuardar As Button
End Class
