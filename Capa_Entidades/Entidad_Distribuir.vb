Public Class Entidad_Distribuir
    Private _id As Integer
    Private _Usuario As Entidad_Usuario
    Private _Asignatura As Entidad_Asignatura
    Private _Periodo As Entidad_Periodo

    Public Sub New(id As Integer, usuario As Entidad_Usuario, asignatura As Entidad_Asignatura, periodo As Entidad_Periodo)
        Me.Id = id
        Me.Usuario = usuario
        Me.Asignatura = asignatura
        Me.Periodo = periodo
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property Asignatura As Entidad_Asignatura
        Get
            Return _Asignatura
        End Get
        Set(value As Entidad_Asignatura)
            _Asignatura = value
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
End Class
