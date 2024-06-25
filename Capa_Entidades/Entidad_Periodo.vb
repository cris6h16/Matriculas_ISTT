Public Class Entidad_Periodo
    Private _Id_Periodo As Integer
    Private _Nombre As String
    Private _Fecha_Inicio As Date
    Private _Fecha_Fin As Date

    Public Property Id_Periodo As Integer
        Get
            Return _Id_Periodo
        End Get
        Set(value As Integer)
            _Id_Periodo = value
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

    Public Property Fecha_Inicio As Date
        Get
            Return _Fecha_Inicio
        End Get
        Set(value As Date)
            _Fecha_Inicio = value
        End Set
    End Property

    Public Property Fecha_Fin As Date
        Get
            Return _Fecha_Fin
        End Get
        Set(value As Date)
            _Fecha_Fin = value
        End Set
    End Property
End Class
