Imports Capa_Entidades
Imports MySql.Data.MySqlClient

Public Class Dato_Carrera
    Public Function existe(nombreDeLaCarrera As String) As Boolean
        Dim query As String = "SELECT COUNT(id) FROM carrera c WHERE LOWER(c.nombre) = @nombre"
        Dim yaExiste As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nombre", nombreDeLaCarrera.ToLower)
                conn.Open()
                existe = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return existe
    End Function

    Public Function crear(carrera As Entidad_Carrera) As Boolean
        Dim query As String =
           "INSERT INTO carrera ( 
                id,
                nombre,
                duracion_en_semestres,
                modalidad
            )
            VALUES( 
                @id,
                @nombre,
                @duracion,
                @modalidad
            )"

        Dim creado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", Nothing)
                cmd.Parameters.AddWithValue("@nombre", carrera.Nombre)
                cmd.Parameters.AddWithValue("@duracion", carrera.DuracionEnSemestres)
                cmd.Parameters.AddWithValue("@modalidad", carrera.EModalidad.ToString)

                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function


    Public Function ListarCarreras() As HashSet(Of Entidad_Carrera)

        Dim query As String = 
        "SELECT 
            id,
            nombre,
            duracion_en_semestres,
            modalidad
        FROM carrera"

        Dim carreras As New HashSet(Of Entidad_Carrera)
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32(0)
                        Dim nombre As String = reader.GetString(1)
                        Dim duracion As Byte = reader.GetByte(2)
                        Dim modalidad As EModalidad = CType([Enum].Parse(GetType(EModalidad), reader.GetString(3)), EModalidad)

                        Dim carrera As New Entidad_Carrera(id, nombre, duracion, modalidad)
                        carreras.Add(carrera)
                    End While
                End Using
            End Using
        End Using

        Return carreras
    End Function
End Class
