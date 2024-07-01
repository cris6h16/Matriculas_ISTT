Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_Distribuir
    Private datoDistribuir As Dato_Distribuir
    Private datoUsuario As Dato_Usuario
    Private datoPeriodo As Dato_Periodo
    Private datoAsignatura As Dato_Asignatura

    Public Sub New(datoDistribuir As Dato_Distribuir, datoUsuario As Dato_Usuario, datoPeriodo As Dato_Periodo, datoAsignatura As Dato_Asignatura)
        Me.datoDistribuir = datoDistribuir
        Me.datoUsuario = datoUsuario
        Me.datoPeriodo = datoPeriodo
        Me.datoAsignatura = datoAsignatura
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

    'traerPorIdPeriodoYIdAsignatura
    Public Function traerPorIdPeriodoYIdAsignatura(idPeriodo As Integer, idAsignatura As Integer) As Entidad_Distribuir

        If Not datoPeriodo.existePorId(idPeriodo) Then
            Throw New ArgumentException("No existe un periodo con el id " & idPeriodo)
        End If

        If Not datoAsignatura.existePorId(idAsignatura) Then
            Throw New ArgumentException("No existe una asignatura con el id " & idAsignatura)
        End If

        Return Me.datoDistribuir.traerPorIdPeriodoYIdAsignatura(idPeriodo, idAsignatura)

    End Function

End Class
