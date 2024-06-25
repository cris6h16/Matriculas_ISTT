Public Class Entidad_Roles

    Private _Id As Integer
    Private _ERol As ERoles

    Public Sub New(id As Integer, eRol As ERoles)
        Me.Id = id
        Me.ERol = eRol
    End Sub

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property ERol As ERoles
        Get
            Return _ERol
        End Get
        Set(value As ERoles)
            _ERol = value
        End Set
    End Property
End Class



Public Enum ERoles
        Docente
        Estudiante
    End Enum
