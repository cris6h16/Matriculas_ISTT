Public Class Entidad_Carrera
    Private _Id_Carrera As Integer
    Private _Nombre As String
    Private _DuracionEnSemestres As Byte
    Private _Id_Modalidad As Integer

    Public Property Id_Carrera As Integer
        Get
            Return _Id_Carrera
        End Get
        Set(value As Integer)
            _Id_Carrera = value
        End Set
    End Property

    Public Property Nombre_carrera As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property DuracionEnSemestres As Byte
        Get
            Return _DuracionEnSemestres
        End Get
        Set(value As Byte)
            _DuracionEnSemestres = value
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
