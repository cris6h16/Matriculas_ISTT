Public Class Entidad_Carrera

    Private _Id_Carrera As Integer
    Private _Nombre As String
    Private _DuracionEnSemestres As Byte
    Private _EModalidad As EModalidad

    Public Sub New(id_Carrera As Integer, nombre As String, duracionEnSemestres As Byte, eModalidad As EModalidad)
        Me.Id_Carrera = id_Carrera
        Me.Nombre = nombre
        Me.DuracionEnSemestres = duracionEnSemestres
        Me.EModalidad = eModalidad
    End Sub

    Public Property Id_Carrera As Integer
        Get
            Return _Id_Carrera
        End Get
        Set(value As Integer)
            _Id_Carrera = value
        End Set
    End Property

    Public Property Nombre As String
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

    Public Property EModalidad As EModalidad
        Get
            Return _EModalidad
        End Get
        Set(value As EModalidad)
            _EModalidad = value
        End Set
    End Property
End Class
Public Enum EModalidad
    PRESENCIAL
    VIRTUAL
End Enum
