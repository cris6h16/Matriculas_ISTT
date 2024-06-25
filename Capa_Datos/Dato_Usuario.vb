Imports System.Data.SqlClient
Imports Capa_Entidades
Imports MySql.Data.MySqlClient
Public Class Dato_Usuario

    Dim datoRoles As Dato_Roles

    Public Sub New()
        datoRoles = New Dato_Roles()
    End Sub

    Public Function traer(cedula As String, contrasena As String) As Entidad_Usuario
        Dim query As String =
            "SELECT 
                u.id, 
                u.nombres, 
                u.apellidos, 
                u.cedula, 
                u.id_roles, 
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
                    Dim idRol As String = reader.GetString(4)
                    Dim cedulaR As String = reader.GetString(3)
                    Dim contrasenaR As String = reader.GetString(5)
                    Dim sexo As Char = reader.GetChar(6)
                    Dim nacimiento As Date = reader.GetDateTime(7)
                    Dim direccion As String = reader.GetString(8)

                    Dim rol As Entidad_Roles = Nothing

                    If idRol IsNot Nothing Or Not idRol.Equals("") Then
                        rol = datoRoles.traer(Integer.Parse(idRol))
                    End If

                    usuario = New Entidad_Usuario(id, nombres, apellidos, cedula, rol, contrasena, sexo, nacimiento, direccion)
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
                id_roles
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
                @id_roles
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
                cmd.Parameters.AddWithValue("@id_roles", usuario.Rol.Id)

                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function

End Class
