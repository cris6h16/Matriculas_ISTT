Imports Capa_Entidades
Imports MySql.Data.MySqlClient

Public Class Dato_Distribuir

    Private datoAsignatura As Dato_Asignatura
    Private datoUsuario As Dato_Usuario
    Private datoPeriodo As Dato_Periodo

    Public Sub New(datoAsignatura As Dato_Asignatura, datoUsuario As Dato_Usuario, datoPeriodo As Dato_Periodo)
        Me.datoAsignatura = datoAsignatura
        Me.datoUsuario = datoUsuario
        Me.datoPeriodo = datoPeriodo
    End Sub


    Public Function existe(idAsignatura As Integer, idPeriodo As Integer) As Boolean
        Dim query As String =
            "SELECT 
                COUNT(id) 
            FROM 
                distribuir d 
            WHERE 
                (d.id_asignatura = @id) AND (d.id_periodo_academico = @id_periodo_academico)"

        Dim docenteYaAsignado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", idAsignatura)
                cmd.Parameters.AddWithValue("@id_periodo_academico", idPeriodo)
                conn.Open()
                docenteYaAsignado = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return docenteYaAsignado
    End Function

    Public Function existe(idDistribuir As Integer) As Boolean
        Dim query As String =
            "SELECT 
                COUNT(id) 
            FROM 
                distribuir d 
            WHERE 
                d.id = @id"

        Dim docenteYaAsignado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", idDistribuir)
                conn.Open()
                docenteYaAsignado = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return docenteYaAsignado
    End Function

    Public Function crear(usuarioAsignatura As Entidad_Distribuir) As Boolean

        Dim query As String =
           "INSERT INTO distribuir ( 
                id,
                id_usuario,
                id_asignatura,
                id_periodo_academico
            )
            VALUES( 
                @id,
                @id_usuario,
                @id_asignatura,
                @id_periodo_academico
            )"

        Dim creado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", Nothing)
                cmd.Parameters.AddWithValue("@id_usuario", usuarioAsignatura.Usuario.Id)
                cmd.Parameters.AddWithValue("@id_asignatura", usuarioAsignatura.Asignatura.Id)
                cmd.Parameters.AddWithValue("@id_periodo_academico", usuarioAsignatura.Periodo.Id)

                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function


    Public Function listar() As HashSet(Of Entidad_Distribuir)

        Dim query As String =
        "SELECT 
            d.id,
            d.id_usuario,
            d.id_asignatura,
            d.id_periodo_academico
        FROM 
            distribuir d"

        Dim distribuciones As New HashSet(Of Entidad_Distribuir)

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32(0)
                        Dim idUsuario As Integer = reader.GetInt32(1)
                        Dim idAsignatura As Integer = reader.GetInt32(2)
                        Dim idPeriodo As Integer = reader.GetInt32(3)

                        Dim usuario As Entidad_Usuario = datoUsuario.traerPorId(idUsuario)
                        Dim asignatura As Entidad_Asignatura = datoAsignatura.traer(idAsignatura)
                        Dim periodo As Entidad_Periodo = datoPeriodo.traer(idPeriodo)

                        If usuario Is Nothing Then
                            Throw New Exception("No se pudo encontrar el usuario con id " & reader.GetInt32(1))
                        End If
                        If asignatura Is Nothing Then
                            Throw New Exception("No se pudo encontrar la asignatura con id " & reader.GetInt32(2))
                        End If
                        If periodo Is Nothing Then
                            Throw New Exception("No se pudo encontrar el periodo con id " & reader.GetInt32(3))
                        End If

                        Dim distribucion As New Entidad_Distribuir(id, usuario, asignatura, periodo)
                        distribuciones.Add(distribucion)
                    End While
                End Using
            End Using
        End Using

        Return distribuciones
    End Function

    Public Function listarPorIdUsuario(idUsuario As Integer) As HashSet(Of Entidad_Distribuir)

        Dim query As String =
        "SELECT 
            d.id,
            d.id_asignatura,
            d.id_periodo_academico
        FROM 
            distribuir d
        WHERE 
            d.id_usuario = @id_usuario"

        Dim distribuciones As New HashSet(Of Entidad_Distribuir)

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32(0)
                        Dim idAsignatura As Integer = reader.GetInt32(1)
                        Dim idPeriodo As Integer = reader.GetInt32(2)

                        Dim usuario As Entidad_Usuario = datoUsuario.traerPorId(idUsuario)
                        Dim asignatura As Entidad_Asignatura = datoAsignatura.traer(idAsignatura)
                        Dim periodo As Entidad_Periodo = datoPeriodo.traer(idPeriodo)

                        If usuario Is Nothing Then
                            Throw New Exception("No se pudo encontrar el usuario con id " & reader.GetInt32(1))
                        End If
                        If asignatura Is Nothing Then
                            Throw New Exception("No se pudo encontrar la asignatura con id " & reader.GetInt32(2))
                        End If
                        If periodo Is Nothing Then
                            Throw New Exception("No se pudo encontrar el periodo con id " & reader.GetInt32(3))
                        End If

                        Dim distribucion As New Entidad_Distribuir(id, usuario, asignatura, periodo)
                        distribuciones.Add(distribucion)
                    End While
                End Using
            End Using
        End Using

        Return distribuciones
    End Function


    Public Function borrar(id As Integer) As Boolean
        Dim query As String = "DELETE FROM distribuir WHERE id = @id"
        Dim borrado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                borrado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return borrado
    End Function

End Class
