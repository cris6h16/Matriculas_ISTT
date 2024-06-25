Imports Capa_Entidades
Imports MySql.Data.MySqlClient

Public Class Dato_Roles
    Public Function traer(id As Integer) As Entidad_Roles
        Dim query As String =
            "SELECT r.id, r.erol
             FROM roles r 
             WHERE r.id = @id"

        Dim rol As Entidad_Roles = Nothing

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim idR As Integer = reader.GetInt32(0)
                    Dim eRolR As ERoles = CType([Enum].Parse(GetType(ERoles), reader.GetString(1)), ERoles)

                    rol = New Entidad_Roles(id, eRolR)
                End If
            End Using
        End Using

        Return rol
    End Function


    Public Function crear(eRol As ERoles) As Boolean
        Dim query As String =
           "INSERT INTO roles ( id ,erol) VALUES( @id , @erol)"

        Dim creado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", Nothing)
                cmd.Parameters.AddWithValue("@erol", eRol.ToString)
                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function
End Class
