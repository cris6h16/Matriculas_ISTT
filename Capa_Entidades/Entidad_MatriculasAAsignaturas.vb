Public Class Entidad_MatriculasAAsignaturas

    Private _Id As Integer
    Private _Id_Asignatura As Integer
    Private _Id_Estudiante As Integer
    Private _Id_TipoDeMatricula As Integer
    Private _Id_Modalidad As Integer

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Id_Asignatura As Integer
        Get
            Return _Id_Asignatura
        End Get
        Set(value As Integer)
            _Id_Asignatura = value
        End Set
    End Property

    Public Property Id_Estudiante As Integer
        Get
            Return _Id_Estudiante
        End Get
        Set(value As Integer)
            _Id_Estudiante = value
        End Set
    End Property

    Public Property Id_TipoDeMatricula As Integer
        Get
            Return _Id_TipoDeMatricula
        End Get
        Set(value As Integer)
            _Id_TipoDeMatricula = value
        End Set
    End Property

    Public Property Id_Modalidad As Integer
        Get
            Return _Id_Modalidad
        End Get
        Set(value As Integer)
            _Id_Modalidad = value
        End Set
    End Property
End Class
