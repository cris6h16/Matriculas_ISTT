Imports Capa_Entidades
Imports MySql.Data.MySqlClient

Public Class Dato_Asignatura

    Public Function crear(asignatura As Entidad_Asignatura) As Boolean

        Dim query As String =
           "INSERT INTO asignatura ( 
                id,
                nombre,
                descripcion,
                carrera_id,
                nivel
            )
            VALUES( 
                @id,
                @nombre,
                @descripcion,
                @carrera_id,
                @nivel
            )"


        Dim creado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", Nothing)
                cmd.Parameters.AddWithValue("@nombre", asignatura.Nombre)
                cmd.Parameters.AddWithValue("@descripcion", asignatura.Descripcion)
                cmd.Parameters.AddWithValue("@carrera_id", asignatura.Carrera.Id_Carrera)
                cmd.Parameters.AddWithValue("@nivel", asignatura.Nivel)

                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function

End Class
