Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_Periodo
    Private datoPeriodo As Dato_Periodo

    Public Sub New(datoPeriodo As Dato_Periodo)
        Me.datoPeriodo = datoPeriodo
    End Sub

    Public Sub crear(periodo As Entidad_Periodo)
        If periodo Is Nothing Then
            Throw New ArgumentException("El periodo no puede ser nulo")
        End If
        If periodo.Id <> 0 Then
            Throw New ArgumentException("El id del periodo debe ser 0")
        End If
        If periodo.Nombre Is Nothing Or periodo.Nombre.Length <= 0 Then
            Throw New ArgumentException("El nombre del periodo no puede estar vacio")
        End If
        If periodo.Fecha_Inicio = Nothing Then
            Throw New ArgumentException("La fecha de inicio no puede estar vacia")
        End If
        If periodo.Fecha_Fin = Nothing Then
            Throw New ArgumentException("La fecha de fin no puede estar vacia")
        End If
        If periodo.Fecha_Inicio >= periodo.Fecha_Fin Then
            Throw New ArgumentException("La fecha de inicio no puede ser mayor o igual a la fecha de fin")
        End If

        Me.datoPeriodo.crear(periodo)
    End Sub

    Public Function listar() As HashSet(Of Entidad_Periodo)
        Return datoPeriodo.listar()
    End Function


End Class
