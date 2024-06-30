Public Class Entidad_Asignatura
    Private _Id_Asignatura As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Carrera As Entidad_Carrera
    Private _Nivel As Integer

    Public Sub New(id_Asignatura As Integer, nombre As String, descripcion As String, carrera As Entidad_Carrera, id_Nivel As Integer)
        Me.Id = id_Asignatura
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Carrera = carrera
        Me.Nivel = id_Nivel
    End Sub

    Public Property Id As Integer
        Get
            Return _Id_Asignatura
        End Get
        Set(value As Integer)
            _Id_Asignatura = value
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

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Carrera As Entidad_Carrera
        Get
            Return _Carrera
        End Get
        Set(value As Entidad_Carrera)
            _Carrera = value
        End Set
    End Property

    Public Property Nivel As Integer
        Get
            Return _Nivel
        End Get
        Set(value As Integer)
            _Nivel = value
        End Set
    End Property
End Class
