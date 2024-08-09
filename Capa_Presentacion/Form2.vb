Imports Capa_Entidades
Imports Capa_Negocio
Imports Capa_Datos

Public Class Form2

    Private entidad_Usuario As Entidad_Usuario
    Private negocioUsuario As Negocio_Usuario

    Public Sub New(cedula As String)
        InitializeComponent()
        negocioUsuario = New Negocio_Usuario(New Dato_Usuario())

        Me.entidad_Usuario = traerUuarioPorCedula(cedula)
        llenarComboBoxes()
        llenarCampos()
    End Sub
    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
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
            foto,
            True
)
        Try
            negocioUsuario.actualizar(usuario)
            MsgBox("Usuario ACTUALIZADO correctamente")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        ' refrescar la entidad y resfresar los campos
        entidad_Usuario = traerUuarioPorCedula(cedula)
        llenarCampos()

    End Sub

    Private Sub llenarComboBoxes()
        ' Llenar el ComboBox de Roles
        Me.cmbRoles.Items.AddRange(ERoles.GetNames(GetType(ERoles)))
        Me.cmbRoles.SelectedIndex = 0

        ' Llenar el ComboBox de Sexo: solo es 'M' o 'F'
        Me.cmbSexo.Items.AddRange(New String() {"M", "F"})
    End Sub

    Private Sub llenarCampos()
        txtCedula.Text = entidad_Usuario.Cedula
        txtNombre.Text = entidad_Usuario.Nombres
        txtApellido.Text = entidad_Usuario.Apellidos
        txtContrasena.Text = entidad_Usuario.Contrasena
        txtDireccion.Text = entidad_Usuario.Direccion
        cmbRoles.SelectedItem = entidad_Usuario.Rol.ToString
        cmbSexo.SelectedItem = entidad_Usuario.Sexo
        dtpFechaNac.Value = entidad_Usuario.Nacimiento
        ptbImagen.Image = entidad_Usuario.Foto
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


    Private Function traerUuarioPorCedula(cedula As String) As Entidad_Usuario
        Try
            Return negocioUsuario.traerPorCedula(cedula)
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Function
End Class