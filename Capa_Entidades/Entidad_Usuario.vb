Public Class Entidad_Usuario
    Private _Id As Integer
    Private _Nombres As String
    Private _Apellidos As String
    Private _Cedula As String
    Private _Contrasena As String
    Private _Sexo As Char
    Private _Nacimiento As Date
    Private _Direccion As String
    Private _Rol As ERoles

    Public Sub New(id As Integer, nombre As String, apellido As String, cedula As String, Rol As ERoles, contrasena As String, sexo As Char, nacimiento As Date, direccion As String)
        Me.Id = id
        Me.Nombres = nombre
        Me.Apellidos = apellido
        Me.Cedula = cedula
        Me.Rol = Rol
        Me.Contrasena = contrasena
        Me.Sexo = sexo
        Me.Nacimiento = nacimiento
        Me.Direccion = direccion
    End Sub

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Nombres As String
        Get
            Return _Nombres
        End Get
        Set(value As String)
            _Nombres = value.ToUpper
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _Apellidos
        End Get
        Set(value As String)
            _Apellidos = value.ToUpper
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return _Cedula
        End Get
        Set(value As String)
            _Cedula = value
        End Set
    End Property

    Public Property Contrasena As String
        Get
            Return _Contrasena
        End Get
        Set(value As String)
            _Contrasena = value
        End Set
    End Property

    Public Property Sexo As Char
        Get
            Return _Sexo
        End Get
        Set(value As Char)
            _Sexo = value
        End Set
    End Property

    Public Property Nacimiento As Date
        Get
            Return _Nacimiento
        End Get
        Set(value As Date)
            _Nacimiento = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Rol As ERoles
        Get
            Return _Rol
        End Get
        Set(value As ERoles)
            _Rol = value
        End Set
    End Property
End Class


Public Enum ERoles
    Estudiante
    Docente
    Administrador
End Enum
