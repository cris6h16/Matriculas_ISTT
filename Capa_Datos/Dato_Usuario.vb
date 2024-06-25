Imports System.Data.SqlClient
Imports Capa_Entidades
Imports MySql.Data.MySqlClient
Public Class Dato_Usuario

    Public Function traerUsuario(cedula As String, contrasena As String) As Entidad_Usuario
        Dim query As String =
            "SELECT u.id, u.nombres, u.apellidos, u.cedula, u.tipo_de_usuario_id, u.contrasena
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
                    usuario = New Entidad_Usuario(
                        reader.GetInt32(0).ToString,
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetInt32(4),
                        reader.GetString(5)
                        )
                End If
            End Using
        End Using

        Return usuario
    End Function


    Public Function crear(usuario As Entidad_Usuario) As Boolean
        Dim query As String =
           "INSERT INTO usuarios ( id ,nombres ,apellidos ,cedula ,tipo_de_usuario_id, contrasena)
            VALUES( @id ,@nombres ,@apellidos ,@cedula ,@id_tipo_de_usuario, @contrasena)"

        Dim creado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", Nothing)
                cmd.Parameters.AddWithValue("@nombres", usuario.Nombres)
                cmd.Parameters.AddWithValue("@apellidos", usuario.Apellidos)
                cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)
                cmd.Parameters.AddWithValue("@id_tipo_de_usuario", usuario.Id_TipoDeUsuario)
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena)

                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function

End Class
