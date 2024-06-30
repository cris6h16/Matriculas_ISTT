Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_Distribuir
    Private datoDistribuir As Dato_Distribuir
    Private datoUsuario As Dato_Usuario

    Public Sub New(datoDistribuir As Dato_Distribuir, datoUsuario As Dato_Usuario)
        Me.datoDistribuir = datoDistribuir
        Me.datoUsuario = datoUsuario
    End Sub

    Public Function crear(distribuir As Entidad_Distribuir) As Boolean
        If distribuir Is Nothing Then
            Throw New ArgumentException("El argumento no puede ser nulo")
        End If
        If distribuir.Usuario Is Nothing Then
            Throw New ArgumentException("El usuario no puede ser nulo")
        End If
        If distribuir.Usuario.Id = 0 Then
            Throw New ArgumentException("El id del usuario no puede ser 0")
        End If
        If distribuir.Asignatura Is Nothing Then
            Throw New ArgumentException("La asignatura no puede ser nula")
        End If
        If distribuir.Asignatura.Id = 0 Then
            Throw New ArgumentException("El id de la asignatura no puede ser 0")
        End If
        If distribuir.Periodo Is Nothing Then
            Throw New ArgumentException("El periodo no puede ser nulo")
        End If
        If distribuir.Periodo.Id = 0 Then
            Throw New ArgumentException("El id del periodo no puede ser 0")
        End If

        If Me.datoDistribuir.existe(distribuir.Asignatura.Id, distribuir.Periodo.Id) Then
            Throw New ArgumentException("La asignatura ya fue asignada a un Docente en este periodo")
        End If

        Return Me.datoDistribuir.crear(distribuir)
    End Function

    Public Function listar() As HashSet(Of Entidad_Distribuir)
        Return Me.datoDistribuir.listar()
    End Function

    Public Function listarPorIdUsuario(idDocente As Integer) As HashSet(Of Entidad_Distribuir)

        If Not datoUsuario.existePorId(idDocente) Then
            Throw New ArgumentException("No existe un usuario con el id " & idDocente)
        End If

        Return Me.datoDistribuir.listarPorIdUsuario(idDocente)

    End Function



    Public Function borrar(idDistribuir As Integer) As Boolean

        If Not datoDistribuir.existe(idDistribuir) Then
            Throw New Exception("No existe una distribucion con el id " & idDistribuir)
        End If

        Return Me.datoDistribuir.borrar(idDistribuir)

    End Function

End Class
