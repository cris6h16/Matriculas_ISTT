Imports Capa_Entidades
Imports MySql.Data.MySqlClient

Public Class Dato_MatriculaAAsignatura
    Private datoUsuario As Dato_Usuario
    Private datoAsignatura As Dato_Asignatura
    Private datoPeriodo As Dato_Periodo


    Public Sub New(datoUsuario As Dato_Usuario, datoAsignatura As Dato_Asignatura, datoPeriodo As Dato_Periodo)
        Me.datoUsuario = datoUsuario
        Me.datoAsignatura = datoAsignatura
        Me.datoPeriodo = datoPeriodo
    End Sub
    Public Function crear(matricula As Entidad_MatriculaAAsignatura) As Boolean
        Dim query As String =
           "INSERT INTO matricula_a_asignatura ( 
                id,
                id_asignatura,
                id_usuario,
                id_periodo_academico,
                tipo_de_matricula,
                modalidad
            )
            VALUES( 
                @id,
                @id_asignatura,
                @id_usuario,
                @id_periodo_academico,
                @tipo_de_matricula,
                @modalidad
            )"

        Dim creado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@id", Nothing)
                cmd.Parameters.AddWithValue("@id_asignatura", matricula.Asignatura.Id)
                cmd.Parameters.AddWithValue("@id_usuario", matricula.Usuario.Id)
                cmd.Parameters.AddWithValue("@id_periodo_academico", matricula.Periodo.Id)
                cmd.Parameters.AddWithValue("@tipo_de_matricula", matricula.TipoDeMatricula.ToString)
                cmd.Parameters.AddWithValue("@modalidad", matricula.Modalidad.ToString)

                creado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return creado
    End Function


    Public Function existe(idUsuario As Integer, idAsignatura As Integer, idPeriodo As Integer) As Boolean

        Dim query As String =
            "SELECT 
                COUNT(id) 
            FROM 
                matricula_a_asignatura m 
            WHERE 
                (m.id_usuario = @id_usuario) AND (m.id_asignatura = @id_asignatura) AND (m.id_periodo_academico = @id_periodo_academico)"

        Dim matriculaYaExiste As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario)
                cmd.Parameters.AddWithValue("@id_asignatura", idAsignatura)
                cmd.Parameters.AddWithValue("@id_periodo_academico", idPeriodo)
                conn.Open()
                matriculaYaExiste = (CInt(cmd.ExecuteScalar()) > 0)
            End Using
        End Using

        Return matriculaYaExiste
    End Function



    Public Function listarPorIdAsignaturaYIdPeriodo(idAsignatura As Integer, idPeriodo As Integer) As HashSet(Of Entidad_MatriculaAAsignatura)
        Dim query As String =
        "SELECT 
            id,
            id_usuario,
            tipo_de_matricula,
            modalidad
        FROM 
            matricula_a_asignatura
        WHERE 
            (id_asignatura = @id_asignatura) AND (id_periodo_academico = @id_periodo_academico)"

        Dim matriculas As New HashSet(Of Entidad_MatriculaAAsignatura)
        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_asignatura", idAsignatura)
                cmd.Parameters.AddWithValue("@id_periodo_academico", idPeriodo)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32(0)
                        Dim idUsuario As Integer = reader.GetInt32(1)
                        Dim tipoDeMatricula As ETipoDeMatricula = [Enum].Parse(GetType(ETipoDeMatricula), reader.GetString(2))
                        Dim modalidad As EModalidad = [Enum].Parse(GetType(EModalidad), reader.GetString(3))

                        Dim usuario As Entidad_Usuario = datoUsuario.traerPorId(idUsuario)
                        Dim asignatura As Entidad_Asignatura = datoAsignatura.traer(idAsignatura)
                        Dim periodo As Entidad_Periodo = datoPeriodo.traer(idPeriodo)

                        If usuario Is Nothing Then
                            Throw New Exception("El usuario con id " & idUsuario & " no existe en la base de datos")
                        End If
                        If asignatura Is Nothing Then
                            Throw New Exception("La asignatura con id " & idAsignatura & " no existe en la base de datos")
                        End If
                        If periodo Is Nothing Then
                            Throw New Exception("El periodo con id " & idPeriodo & " no existe en la base de datos")
                        End If

                        Dim matricula As New Entidad_MatriculaAAsignatura(id, asignatura, usuario, periodo, tipoDeMatricula, modalidad)

                        matriculas.Add(matricula)
                    End While
                End Using
            End Using
        End Using

        Return matriculas
    End Function



    ' datosMatriculasAAsignaturas.borrarPorIdUsuarioYIdAsignaturaYIdPeriodo(idUsuario, idAsignatura, idPeriodo)
    Public Function borrarPorIdUsuarioYIdAsignaturaYIdPeriodo(idUsuario As Integer,
                                                              idAsignatura As Integer,
                                                              idPeriodo As Integer) As Boolean
        Dim query As String =
            "DELETE FROM matricula_a_asignatura 
            WHERE 
                (id_usuario = @id_usuario) AND (id_asignatura = @id_asignatura) AND (id_periodo_academico = @id_periodo_academico)"

        Dim borrado As Boolean = False

        Using conn As New MySqlConnection(InformacionDeConexion.direccionDeConexion)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario)
                cmd.Parameters.AddWithValue("@id_asignatura", idAsignatura)
                cmd.Parameters.AddWithValue("@id_periodo_academico", idPeriodo)
                conn.Open()
                borrado = (cmd.ExecuteNonQuery() > 0)
            End Using
        End Using

        Return borrado
    End Function
End Class
