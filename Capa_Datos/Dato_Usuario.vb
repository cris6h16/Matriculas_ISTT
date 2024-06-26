﻿Imports System.Data.SqlClient
Imports Capa_Entidades
Imports MySql.Data.MySqlClient
Public Class Dato_Usuario

    Public Function traer(cedula As String, contrasena As String) As Entidad_Usuario
        Dim query As String =
            "SELECT 
                u.id, 
                u.nombres, 
                u.apellidos, 
                u.cedula, 
                u.rol, 
                u.contrasena,
                u.sexo,
                u.nacimiento,
                u.direccion
             FROM usuarios u 
             WHERE cedula = @cedula 
             AND contrasena = @contrasena"

        Dim usuario As Entidad_Usuario = Nothing

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cedula", cedula)
                cmd.Parameters.AddWithValue("@contrasena", contrasena)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim id As Integer = reader.GetInt32(0)
                    Dim nombres As String = reader.GetString(1)
                    Dim apellidos As String = reader.GetString(2)
                    Dim rol As String = reader.GetString(4)
                    Dim cedulaR As String = reader.GetString(3)
                    Dim contrasenaR As String = reader.GetString(5)
                    Dim sexo As Char = reader.GetChar(6)
                    Dim nacimiento As Date = reader.GetDateTime(7)
                    Dim direccion As String = reader.GetString(8)

                    Dim eRol As ERoles = CType([Enum].Parse(GetType(ERoles), rol), ERoles)

                    usuario = New Entidad_Usuario(id, nombres, apellidos, cedula, eRol, contrasena, sexo, nacimiento, direccion)
                End If
            End Using
        End Using

        Return usuario
    End Function


    Public Function crear(usuario As Entidad_Usuario) As Boolean
        Dim query As String =
           "INSERT INTO usuarios ( 
                id,
                nombres,
                apellidos,
                cedula,
                contrasena,
                sexo,
                nacimiento,
                direccion,
                rol
            )
            VALUES( 
                @id,
                @nombres,
                @apellidos,
                @cedula,
                @contrasena,
                @sexo,
                @nacimiento,
                @direccion,
                @erol
            )"


        Dim creado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", Nothing)
                cmd.Parameters.AddWithValue("@nombres", usuario.Nombres)
                cmd.Parameters.AddWithValue("@apellidos", usuario.Apellidos)
                cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena)
                cmd.Parameters.AddWithValue("@sexo", usuario.Sexo)
                cmd.Parameters.AddWithValue("@nacimiento", usuario.Nacimiento)
                cmd.Parameters.AddWithValue("@direccion", usuario.Direccion)
                cmd.Parameters.AddWithValue("@erol", usuario.Rol.ToString)

                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function


    Public Function existeConEstaCedula(cedula As String) As Boolean
        Dim query As String = "SELECT COUNT(id) FROM usuarios WHERE cedula = @cedula"
        Dim existe As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cedula", cedula)
                conn.Open()
                existe = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return existe
    End Function



End Class
