Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_Usuario

    Private negocioUsuario As Negocio_Usuario
    Private negocioTipoDeUsuario As Negocio_TipoDeUsuario

    Public Sub New()
        InitializeComponent()
        negocioUsuario = New Negocio_Usuario(New Dato_Usuario)
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

        ' Crear un objeto de tipo Entidad_Usuario con los datos capturados


        Dim usuario As New Entidad_Usuario(0, nombre, apellido, cedula, 1, contrasena, sexo, fechaNac, direccion)

        Try
            negocioUsuario.crear(usuario)
            MessageBox.Show("Usuario creado exitosamente", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class