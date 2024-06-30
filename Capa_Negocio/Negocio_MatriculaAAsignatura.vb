Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_MatriculaAAsignatura
    Private datoMatriculaAAsignatura As Dato_MatriculaAAsignatura
    Private datoPeriodo As Dato_Periodo
    Private datoAsignatura As Dato_Asignatura
    Private datoUsuario As Dato_Usuario

    Public Sub Neu(datoMatriculaAAsignatura As Dato_MatriculaAAsignatura,
                  datoPeriodo As Dato_Periodo,
                  datoAsignatura As Dato_Asignatura,
                  datoUsuario As Dato_Usuario)
        Me.datoMatriculaAAsignatura = datoMatriculaAAsignatura
        Me.datoPeriodo = datoPeriodo
        Me.datoAsignatura = datoAsignatura
        Me.datoUsuario = datoUsuario
    End Sub


    Public Function crear(matricula As Entidad_MatriculaAAsignatura) As Boolean
        ' verificar objeto matricula
        If matricula Is Nothing Then
            Throw New ArgumentException("La matricula no puede ser nula")
        End If

        ' verificar usuario
        If matricula.Usuario Is Nothing Then
            Throw New ArgumentException("El usuario no puede ser nulo")
        End If
        If matricula.Usuario.Id = 0 Then
            Throw New ArgumentException("El id del usuario no puede ser 0")
        End If

        ' verificar asignatura
        If matricula.Asignatura Is Nothing Then
            Throw New ArgumentException("La asignatura no puede ser nula")
        End If
        If matricula.Asignatura.Id = 0 Then
            Throw New ArgumentException("El id de la asignatura no puede ser 0")
        End If

        ' verificar periodo
        If matricula.Periodo Is Nothing Then
            Throw New ArgumentException("El periodo no puede ser nulo")
        End If
        If matricula.Periodo.Id = 0 Then
            Throw New ArgumentException("El id del periodo no puede ser 0")
        End If

        ' verificar que la matricula no exista
        If Me.datoMatriculaAAsignatura.existe(matricula.Usuario.Id, matricula.Asignatura.Id, matricula.Periodo.Id) Then
            Throw New ArgumentException("El estudiante ya esta matriculado en esta asignatura y este periodo")
        End If

        Return Me.datoMatriculaAAsignatura.crear(matricula)
    End Function





    Public Function listarPorIdAsignaturaYIdPeriodo(idAsignatura As Integer,
                                                    idPeriodo As Integer) As HashSet(Of Entidad_MatriculaAAsignatura)

        If Not datoPeriodo.existePorId(idPeriodo) Then
            Throw New ArgumentException("No existe un periodo con el id " & idPeriodo)
        End If

        If Not datoAsignatura.existePorId(idAsignatura) Then
            Throw New ArgumentException("No existe una asignatura con el id " & idAsignatura)
        End If

        Return Me.datoMatriculaAAsignatura.listarPorIdAsignaturaYIdPeriodo(idAsignatura, idPeriodo)
    End Function





    Public Function borrarPorIdUsuarioYIdAsignaturaYIdPeriodo(idUsuario As Integer,
                                                              idAsignatura As Integer,
                                                              idPeriodo As Integer) As Boolean

        If Not datoPeriodo.existePorId(idPeriodo) Then
            Throw New ArgumentException("No existe un periodo con el id " & idPeriodo)
        End If

        If Not datoAsignatura.existePorId(idAsignatura) Then
            Throw New ArgumentException("No existe una asignatura con el id " & idAsignatura)
        End If

        If Not datoUsuario.existePorId(idAsignatura) Then
            Throw New ArgumentException("No existe un usuario con el id " & idUsuario)
        End If

        Return Me.datoMatriculaAAsignatura.borrarPorIdUsuarioYIdAsignaturaYIdPeriodo(idUsuario, idAsignatura, idPeriodo)
    End Function
End Class
