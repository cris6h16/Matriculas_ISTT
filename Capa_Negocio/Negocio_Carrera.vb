Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_Carrera
    Private datoCarrera As Dato_Carrera

    Public Sub New(datoCarrera As Dato_Carrera)
        Me.datoCarrera = datoCarrera
    End Sub

    Public Function ListarCarreras() As HashSet(Of Entidad_Carrera)
        Return datoCarrera.listar()
    End Function


    Public Function crear(carrera As Entidad_Carrera) As Boolean
        If (carrera Is Nothing) Then
            Throw New ArgumentException("La carrera no puede ser nula")
        End If

        If (carrera.Id_Carrera <> 0) Then
            Throw New ArgumentException("Para crear una carrera no debe asignar un id")
        End If

        If (carrera.Nombre Is Nothing Or carrera.Nombre = "") Then
            Throw New ArgumentException("El nombre no puede estar vacio o nulo")
        End If

        If (carrera.DuracionEnSemestres <= 0) Then
            Throw New ArgumentException("La duracion en semestres no puede ser 0 o inferior")
        End If

        'verificar si ya existe
        If datoCarrera.existe(carrera.Nombre) Then
            Throw New ArgumentException("Ya existe una carrera con ese nombre")
        End If

        Return datoCarrera.crear(carrera)
    End Function
End Class
