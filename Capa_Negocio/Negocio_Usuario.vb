Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_Usuario
    Dim datoUsuario As Dato_Usuario

    Public Sub New(datoUsuario As Dato_Usuario)
        Me.datoUsuario = datoUsuario
    End Sub

    Public Function traerUsuario(cedula As String, contrasena As String) As Entidad_Usuario
        If cedula = "" Or cedula Is Nothing Then
            Throw New ArgumentException("La cedula no puede estar vacia o nula")
        End If
        If contrasena = "" Or contrasena Is Nothing Then
            Throw New ArgumentException("La contraseña no puede estar vacia o nula")
        End If

        Dim ususario As Entidad_Usuario = Me.datoUsuario.traerUsuario(cedula, contrasena)
        If ususario Is Nothing Then
            Throw New Exception("No se encontro un usuario con esa cedula y contraseña")
        End If

    End Function

    Public Function crear(usuario As Entidad_Usuario) As Boolean
        If usuario Is Nothing Then
            Throw New ArgumentException("El usuario no puede ser nulo")
        End If
        If usuario.Id <> 0 Then
            Throw New ArgumentException("Para crear un usuario no debe asignar un id")
        End If

        If usuario.Cedula = "" Or usuario.Cedula Is Nothing Then
            Throw New ArgumentException("La cedula no puede estar vacia o nula")
        End If
        If usuario.Nombres = "" Or usuario.Nombres Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacio o nulo")
        End If
        If usuario.Apellidos = "" Or usuario.Apellidos Is Nothing Then
            Throw New ArgumentException("El apellido no puede estar vacio o nulo")
        End If
        If usuario.TipoDeUsuario Is Nothing Or usuario.TipoDeUsuario.Id = 0 Then
            Throw New ArgumentException("El tipo de usuario no puede ser nulo o tener un id de 0")
        End If

        If usuario.Sexo <> "M" AndAlso usuario.Sexo <> "F" Then
            Throw New ArgumentException("El sexo debe ser M o F")
        End If

        If usuario.Direccion Is Nothing Or usuario.Direccion.Length = 0 Then
            Throw New Exception("La direccion no puede estar vacia o nula")
        End If

        If usuario.Nacimiento = Nothing Then
            Throw New Exception("La fecha de nacimiento no puede ser nula")
        End If

        If usuario.Contrasena Is Nothing Or usuario.Contrasena.Length < 8 Then
            Throw New Exception("La contraseña debe tener al menos 8 caracteres")
        End If


        Return Me.datoUsuario.crear(usuario)
    End Function

End Class
