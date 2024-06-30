Imports Capa_Entidades
Imports MySql.Data.MySqlClient

Public Class Dato_Periodo
    Public Function existe(nombreDelPeriodo As String) As Boolean
        Dim query As String = "SELECT COUNT(id) FROM periodo_academico p WHERE LOWER(p.nombre) = @nombre"
        Dim yaExiste As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nombre", nombreDelPeriodo.ToLower)
                conn.Open()
                existe = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return existe
    End Function

    Public Function crear(periodo As Entidad_Periodo) As Boolean

        Dim query As String =
           "INSERT INTO periodo_academico ( 
                id,
                nombre,
                fecha_inicio,
                fecha_fin
            )
            VALUES( 
                @id,
                @nombre,
                @fecha_inicio,
                @fecha_fin
            )"

        Dim creado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", Nothing)
                cmd.Parameters.AddWithValue("@nombre", periodo.Nombre)
                cmd.Parameters.AddWithValue("@fecha_inicio", periodo.Fecha_Inicio)
                cmd.Parameters.AddWithValue("@fecha_fin", periodo.Fecha_Fin)

                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function


    Public Function listar() As HashSet(Of Entidad_Periodo)

        Dim query As String =
        "SELECT 
            id,
            nombre,
            fecha_inicio,
            fecha_fin
        FROM 
            periodo_academico"

        Dim periodos As New HashSet(Of Entidad_Periodo)

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32(0)
                        Dim nombre As String = reader.GetString(1)
                        Dim fechaInicio As Date = reader.GetDateTime(2)
                        Dim fechaFin As Date = reader.GetDateTime(3)

                        Dim periodo As New Entidad_Periodo(id, nombre, fechaInicio, fechaFin)

                        periodos.Add(periodo)
                    End While
                End Using
            End Using
        End Using

        Return periodos
    End Function

    Public Function traer(id As Integer) As Entidad_Periodo
        Dim query As String =
        "SELECT 
            id,
            nombre,
            fecha_inicio,
            fecha_fin
        FROM 
            periodo_academico
        WHERE 
            id = @id"

        Dim periodo As Entidad_Periodo = Nothing
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim nombre As String = reader.GetString(1)
                        Dim fechaInicio As Date = reader.GetDateTime(2)
                        Dim fechaFin As Date = reader.GetDateTime(3)

                        periodo = New Entidad_Periodo(id, nombre, fechaInicio, fechaFin)
                    End If
                End Using
            End Using
        End Using

        Return periodo
    End Function
End Class
