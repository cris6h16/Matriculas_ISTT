Imports System.IO
Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_RegistroDeUusarios

    Private negocioUsuario As Negocio_Usuario

    Public Sub New()
        InitializeComponent()
        negocioUsuario = New Negocio_Usuario(New Dato_Usuario)
        Me.cmbSexo.SelectedIndex = 0

        Me.cmbRoles.Items.AddRange(ERoles.GetNames(GetType(ERoles)))
        Me.cmbRoles.SelectedIndex = 0
        Me.dtpFechaNac.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Capturar los datos ingresados en los campos del formulario
        Dim cedula As String = txtCedula.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim sexo As String = cmbSexo.SelectedItem.ToString
        Dim fechaNac As Date = dtpFechaNac.Value
        Dim direccion As String = txtDireccion.Text
        Dim contrasena As String = txtContrasena.Text
        Dim foto As Image = ptbImagen.Image

        Dim rol As ERoles = CType([Enum].Parse(GetType(ERoles), cmbRoles.SelectedItem.ToString), ERoles)

        Dim usuario As New Entidad_Usuario(
            0,
            nombre,
            apellido,
            cedula,
            rol,
            contrasena,
            sexo,
            fechaNac,
            direccion,
            foto
            )

        Try
            negocioUsuario.crear(usuario)
            MsgBox("Usuario creado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmPrincipal.frm_MenuDeAdministrador.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.txtApellido.Clear()
        Me.txtCedula.Clear()
        Me.txtContrasena.Clear()
        Me.txtDireccion.Clear()
        Me.txtNombre.Clear()
        Me.cmbSexo.SelectedIndex = 0
        Me.dtpFechaNac.Value = Date.Now

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dtpFechaNac_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNac.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ptbImagen.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openFileDialog1 As New OpenFileDialog()
        ' Configurar el diálogo
        openFileDialog1.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog1.Title = "Seleccionar una imagen"
        ' Mostrar el diálogo y verificar si el usuario seleccionó un archivo
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                ' Mostrar la ruta del archivo para depuración
                MessageBox.Show("Ruta del archivo: " & openFileDialog1.FileName)
                ' Cargar la imagen en el PictureBox
                ptbImagen.Image = Image.FromFile(openFileDialog1.FileName)
                ' Ajustar el tamaño de la imagen al PictureBox
                ptbImagen.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
                MessageBox.Show("Error al cargar la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class