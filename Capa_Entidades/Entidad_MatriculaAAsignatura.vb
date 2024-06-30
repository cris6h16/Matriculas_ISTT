Public Class Entidad_MatriculaAAsignatura

    Private _Id As Integer
    Private _Asignatura As Entidad_Asignatura
    Private _Usuario As Entidad_Usuario
    Private _Periodo As Entidad_Periodo
    Private _TipoDeMatricula As ETipoDeMatricula
    Private _Modalidad As EModalidad

    Public Sub New(id As Integer, asignatura As Entidad_Asignatura, usuario As Entidad_Usuario, periodo As Entidad_Periodo, tipoDeMatricula As ETipoDeMatricula, modalidad As EModalidad)
        Me.Id = id
        Me.Asignatura = asignatura
        Me.Usuario = usuario
        Me.Periodo = periodo
        Me.TipoDeMatricula = tipoDeMatricula
        Me.Modalidad = modalidad
    End Sub

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Asignatura As Entidad_Asignatura
        Get
            Return _Asignatura
        End Get
        Set(value As Entidad_Asignatura)
            _Asignatura = value
        End Set
    End Property

    Public Property Usuario As Entidad_Usuario
        Get
            Return _Usuario
        End Get
        Set(value As Entidad_Usuario)
            _Usuario = value
        End Set
    End Property

    Public Property Periodo As Entidad_Periodo
        Get
            Return _Periodo
        End Get
        Set(value As Entidad_Periodo)
            _Periodo = value
        End Set
    End Property

    Public Property TipoDeMatricula As ETipoDeMatricula
        Get
            Return _TipoDeMatricula
        End Get
        Set(value As ETipoDeMatricula)
            _TipoDeMatricula = value
        End Set
    End Property

    Public Property Modalidad As EModalidad
        Get
            Return _Modalidad
        End Get
        Set(value As EModalidad)
            _Modalidad = value
        End Set
    End Property
End Class

Public Enum ETipoDeMatricula
    ORDINARIA
    EXTRAORDINARIA
    ESPECIAL
End Enum
