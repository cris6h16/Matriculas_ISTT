Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_Usuario
    Dim datoUsuario As Dato_Usuario

    Public Sub New(datoUsuario As Dato_Usuario)
        Me.datoUsuario = datoUsuario
    End Sub

    Public Sub cambiarEstadoPorCedula(cedula As String, activo As Boolean)
        If cedula = "" Or cedula Is Nothing Then
            Throw New ArgumentException("La cedula no puede estar vacia o nula")
        End If

        datoUsuario.cambiarEstadoPorCedula(cedula, activo)
    End Sub

    Public Sub actualizar(usuario As Entidad_Usuario)


        If (usuario Is Nothing) Then
            Throw New ArgumentException("El usuario no puede ser nulo")
        End If


        If (usuario.Nombres = "" Or usuario.Nombres Is Nothing) Then
            Throw New ArgumentException("El nombre no puede estar vacio o nulo")
        End If

        If (usuario.Apellidos = "" Or usuario.Apellidos Is Nothing) Then
            Throw New ArgumentException("El apellido no puede estar vacio o nulo")
        End If

        If (usuario.Cedula.Length <> 10 Or usuario.Cedula Is Nothing) Then
            Throw New ArgumentException("La cedula debe tener 10 caracteres")
        End If

        If (usuario.Sexo <> "M" AndAlso usuario.Sexo <> "F") Then
            Throw New ArgumentException("El sexo debe ser M o F")
        End If

        If (usuario.Nacimiento = Nothing) Then
            Throw New ArgumentException("La fecha de nacimiento no puede ser nula")
        End If

        If (usuario.Direccion Is Nothing Or usuario.Direccion.Length = 0) Then
            Throw New ArgumentException("La direccion no puede estar vacia o nula")
        End If

        If usuario.Contrasena Is Nothing Or usuario.Contrasena.Length < 8 Then
            Throw New ArgumentException("La contraseña debe tener al menos 8 caracteres")
        End If

        If usuario.Foto Is Nothing Then
            Throw New ArgumentException("La foto no puede ser nula")
        End If

        ' si existe un usuario con la Cedula igual & el ID distinto, entonces no se puede actualizar

        If datoUsuario.existePorCedula(usuario.Cedula) Then
            Dim usuarioExistente As Entidad_Usuario = datoUsuario.traerPorCedula(usuario.Cedula)
            If usuarioExistente.Id <> usuario.Id Then
                Throw New ArgumentException("Ya existe un usuario con esa cedula")
            End If
        End If



        ' verificar si existe el usuario con el id

        If Not datoUsuario.existePorId(usuario.Id) Then
            Throw New ArgumentException("No existe un usuario con el ID: " & usuario.Id)
        End If


        Me.datoUsuario.actualizarPorId(usuario)
    End Sub

    Public Sub eliminarPorCedula(cedula As String)
        If cedula Is Nothing Or cedula.Length <> 10 Then
            Throw New ArgumentException("La cedula debe tener 10 digitos")
        End If

        ' verificar si existe el usuario con la cedula

        If Not datoUsuario.existePorCedula(cedula) Then
            Throw New ArgumentException("No existe un usuario con cedula " & cedula)
        End If

        ' eliminar el usuario con la capa de datos
        Me.datoUsuario.eliminarPorCedula(cedula)
    End Sub

    Public Function traerPorCedulaYContrasena(cedula As String, contrasena As String) As Entidad_Usuario
        If cedula = "" Or cedula Is Nothing Then
            Throw New ArgumentException("La cedula no puede estar vacia o nula")
        End If
        If contrasena = "" Or contrasena Is Nothing Then
            Throw New ArgumentException("La contraseña no puede estar vacia o nula")
        End If

        Dim ususario As Entidad_Usuario = Me.datoUsuario.traerPorCedulaYContrasena(cedula, contrasena)
        If ususario Is Nothing Then
            Throw New Exception("No se encontro un usuario con esa cedula y contraseña")
        End If

        Return ususario
    End Function



    Public Function traerPorCedula(cedula As String) As Entidad_Usuario
        If cedula.Length <> 10 Then
            Throw New ArgumentException("La cedula debe tener 10 digitos")
        End If

        If Not datoUsuario.existePorCedula(cedula) Then
            Throw New ArgumentException("No existe ningun usuario con cedula " & cedula)
        End If

        Return Me.datoUsuario.traerPorCedula(cedula)
    End Function

    Public Function crear(usuario As Entidad_Usuario) As Boolean

        'Private _Id As Integer
        'Private _Nombres As String
        'Private _Apellidos As String
        'Private _Cedula As String
        'Private _Contrasena As String
        'Private _Sexo As Char
        'Private _Nacimiento As Date
        'Private _Direccion As String
        'Private _Rol As Entidad_Roles
        ' Private _Foto As Image
        ' Private _Activo As Boolean


        If (usuario Is Nothing) Then
            Throw New ArgumentException("El usuario no puede ser nulo")
        End If

        If (usuario.Id <> 0) Then
            Throw New ArgumentException("Para crear un usuario no debe asignar un id")
        End If

        If (usuario.Nombres = "" Or usuario.Nombres Is Nothing) Then
            Throw New ArgumentException("El nombre no puede estar vacio o nulo")
        End If

        If (usuario.Apellidos = "" Or usuario.Apellidos Is Nothing) Then
            Throw New ArgumentException("El apellido no puede estar vacio o nulo")
        End If

        If (usuario.Cedula.Length <> 10 Or usuario.Cedula Is Nothing) Then
            Throw New ArgumentException("La cedula debe tener 10 caracteres")
        End If

        If (usuario.Sexo <> "M" AndAlso usuario.Sexo <> "F") Then
            Throw New ArgumentException("El sexo debe ser M o F")
        End If

        If (usuario.Nacimiento = Nothing) Then
            Throw New ArgumentException("La fecha de nacimiento no puede ser nula")
        End If

        If (usuario.Direccion Is Nothing Or usuario.Direccion.Length = 0) Then
            Throw New ArgumentException("La direccion no puede estar vacia o nula")
        End If

        If usuario.Contrasena Is Nothing Or usuario.Contrasena.Length < 8 Then
            Throw New ArgumentException("La contraseña debe tener al menos 8 caracteres")
        End If

        If usuario.Foto Is Nothing Then
            Throw New ArgumentException("La foto no puede ser nula")
        End If



        ' verificar no repetidos

        If datoUsuario.existePorCedula(usuario.Cedula) Then
            Throw New ArgumentException("Ya existe un usuario con esa cedula")
        End If



        Return Me.datoUsuario.crear(usuario)
    End Function


    ' listar estudiantes pasar: ERoles.ESTUDIANTE
    ' listar docentes pasar: ERoles.DOCENTE
    ' listar administradores pasar: ERoles.ADMINISTRADOR
    Public Function listarTipoDeUsuario(eRol As ERoles) As HashSet(Of Entidad_Usuario)
        Return Me.datoUsuario.listarTipoDeUsuario(eRol)
    End Function

    ' listar todos los usuarios
    Public Function listarTodosDataSet() As DataSet
        Return Me.datoUsuario.listarTodosDataSet()
    End Function

    Public Function listarTodos() As List(Of Entidad_Usuario)
        Return Me.datoUsuario.listarTodos()
    End Function

    Public Function listarActivosDataSet() As DataSet
        Return Me.datoUsuario.listarActivosDataSet()
    End Function

    Public Function listarInactivosDataSet() As DataSet
        Return Me.datoUsuario.listarInactivosDataSet()
    End Function

End Class
