Imports Capa_Datos
Imports Capa_Entidades

Public Class Negocio_Asignatura

    Private datoAsignatura As Dato_Asignatura

    Public Sub New(datoAsignatura As Dato_Asignatura)
        Me.datoAsignatura = datoAsignatura
    End Sub

    Public Function crear(asignatura As Entidad_Asignatura) As Boolean
        If (asignatura Is Nothing) Then
            Throw New ArgumentException("La asignatura no puede ser nula")
        End If

        If (asignatura.Id_Asignatura <> 0) Then
            Throw New ArgumentException("Para crear una asignatura no debe asignar un id")
        End If

        If (asignatura.Nombre Is Nothing Or asignatura.Nombre = "") Then
            Throw New ArgumentException("El nombre no puede estar vacio o nulo")
        End If

        If (asignatura.Descripcion Is Nothing Or asignatura.Descripcion = "") Then
            Throw New ArgumentException("La descripcion no puede estar vacia o nula")
        End If

        If (asignatura.Carrera Is Nothing) Then
            Throw New ArgumentException("La carrera no puede ser nula")
        End If

        If (asignatura.Carrera.Id_Carrera = 0) Then
            Throw New ArgumentException("La carrera no tiene un id asignado")
        End If

        If (asignatura.Nivel <= 0) Then
            Throw New ArgumentException("El nivel no puede ser 0 o inferior")
        End If

        Return Me.datoAsignatura.crear(asignatura)
    End Function
End Class
