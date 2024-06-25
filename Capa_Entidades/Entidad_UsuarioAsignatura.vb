Public Class Entidad_UsuarioAsignatura
    Private _id As Integer
    Private _id_Usuario As Integer
    Private _id_Asignatura As Integer
    Private _id_Periodo As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Id_Usuario As Integer
        Get
            Return _id_Usuario
        End Get
        Set(value As Integer)
            _id_Usuario = value
        End Set
    End Property

    Public Property Id_Asignatura As Integer
        Get
            Return _id_Asignatura
        End Get
        Set(value As Integer)
            _id_Asignatura = value
        End Set
    End Property

    Public Property Id_Periodo As Integer
        Get
            Return _id_Periodo
        End Get
        Set(value As Integer)
            _id_Periodo = value
        End Set
    End Property
End Class
