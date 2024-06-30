Imports Capa_Entidades
Imports MySql.Data.MySqlClient

Public Class Dato_Asignatura

    Private datoCarrera As Dato_Carrera

    Public Sub New(datoCarrera As Dato_Carrera)
        Me.datoCarrera = datoCarrera
    End Sub


    Public Function existePorId(id As Integer) As Boolean
        Dim query As String =
            "SELECT 
                COUNT(id) 
            FROM 
                asignatura a 
            WHERE 
                a.id = @id"

        Dim existe As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                existe = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return existe
    End Function


    Public Function existePorNombre(nombre As String) As Boolean
        Dim query As String =
            "SELECT 
                COUNT(id) 
            FROM 
                asignatura a 
            WHERE 
                LOWER(a.nombre) = @nombre"

        Dim existe As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nombre", nombre.ToLower)
                conn.Open()
                existe = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return existe
    End Function

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

    Public Function listar() As HashSet(Of Entidad_Asignatura)

        '        Private _Id_Asignatura As Integer
        '        Private _Nombre As String
        '        Private _Descripcion As String
        '        Private _Carrera As Entidad_Carrera
        '        Private _Nivel As Integer


        Dim query As String =
        "SELECT 
            a.id,
            a.nombre,
            a.descripcion,
            a.id_carrera,
            a.nivel
        FROM 
            asignatura a"

        Dim asignaturas As New HashSet(Of Entidad_Asignatura)
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' leer asignatura
                        Dim id As Integer = reader.GetInt32(0)
                        Dim nombre As String = reader.GetString(1)
                        Dim descripcion As String = reader.GetString(2)
                        Dim idCarrera As Integer = reader.GetInt32(3)
                        Dim nivel As Byte = reader.GetByte(4)

                        ' leer carrera
                        Dim carrera As Entidad_Carrera = datoCarrera.traer(idCarrera)
                        If carrera Is Nothing Then
                            Throw New Exception("La carrera con id " & idCarrera & " no existe en la base de datos")
                        End If

                        ' crear asignatura
                        Dim asignatura As New Entidad_Asignatura(id, nombre, descripcion, carrera, nivel)

                        ' agregar a la lista
                        asignaturas.Add(asignatura)
                    End While
                End Using
            End Using
        End Using

        Return asignaturas
    End Function

    Public Function traer(id As Integer) As Entidad_Asignatura
        Dim query As String =
        "SELECT 
            id,
            nombre,
            descripcion,
            id_carrera,
            nivel
        FROM 
            asignatura
        WHERE 
            id = @id"

        Dim asignatura As Entidad_Asignatura = Nothing
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim nombre As String = reader.GetString(1)
                        Dim descripcion As String = reader.GetString(2)
                        Dim idCarrera As Integer = reader.GetInt32(3)
                        Dim nivel As Byte = reader.GetByte(4)

                        Dim carrera As Entidad_Carrera = datoCarrera.traer(idCarrera)
                        If carrera Is Nothing Then
                            Throw New Exception("La carrera con id " & idCarrera & " no existe en la base de datos")
                        End If

                        asignatura = New Entidad_Asignatura(id, nombre, descripcion, carrera, nivel)
                    End If
                End Using
            End Using
        End Using

        Return asignatura
    End Function
End Class
