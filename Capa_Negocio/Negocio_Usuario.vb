﻿Imports Capa_Datos
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

        Dim ususario As Entidad_Usuario = Me.datoUsuario.traer(cedula, contrasena)
        If ususario Is Nothing Then
            Throw New Exception("No se encontro un usuario con esa cedula y contraseña")
        End If

        Return ususario
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

        'If (usuario.Rol Is Nothing) Then
        'Throw New ArgumentException("El Rol no puede ser nulo")
        'End If

        If usuario.Contrasena Is Nothing Or usuario.Contrasena.Length < 8 Then
            Throw New ArgumentException("La contraseña debe tener al menos 8 caracteres")
        End If

        ' verificar no repetidos

        If datoUsuario.existeConEstaCedula(usuario.Cedula) Then
            Throw New ArgumentException("Ya existe un usuario con esa cedula")
        End If



        Return Me.datoUsuario.crear(usuario)
    End Function

End Class
