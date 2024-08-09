Imports Capa_Datos
Imports Capa_Entidades
Imports Capa_Negocio

Public Class frm_ListaDeUsuarios

    Private negocioUsuario As Negocio_Usuario
    Public Sub New()
        InitializeComponent()
        Me.negocioUsuario = New Negocio_Usuario(New Dato_Usuario())

        llenarTabla()
    End Sub
    Private Sub dgv_matriculados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaUsuarios.CellContentClick

        Dim idxBotonActivar = tablaUsuarios.ColumnCount - 1
        If e.ColumnIndex = idxBotonActivar Then

            ' Obtener el color actual de la fila
            Dim colorActual As Color = tablaUsuarios.Rows(e.RowIndex).DefaultCellStyle.BackColor

            ' Determinar el nuevo estado basado en el color actual
            Dim activo As Boolean
            If colorActual = Color.Red Then
                activo = True
            Else
                activo = False
            End If

            ' Obtener la cédula del usuario
            Dim cedula As String = tablaUsuarios.Rows(e.RowIndex).Cells(2).Value

            Try
                ' Llamar al método para cambiar el estado
                negocioUsuario.cambiarEstadoPorCedula(cedula, activo)

                ' Mostrar mensaje de éxito
                MsgBox("Se cambió el estado del estudiante")

                ' Actualizar la tabla
                llenarTabla()
            Catch ex As Exception
                ' Mostrar mensaje de error
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub llenarTabla()

        ' limpiar la tabla
        tablaUsuarios.Rows.Clear()

        Dim usuarios As List(Of Entidad_Usuario) = negocioUsuario.listarTodos()

        For Each u As Entidad_Usuario In usuarios
            tablaUsuarios.Rows.Add(
                u.Foto,
                u.Rol,
                u.Cedula,
                u.Nombres,
                u.Apellidos,
                u.Sexo,
                u.Nacimiento
            )
        Next

        ' iterar las filas de la tabla, si el usuario no esta activo, cambiar el color de la fila
        For Each row As DataGridViewRow In tablaUsuarios.Rows
            For Each u As Entidad_Usuario In usuarios
                If row.Cells(2).Value = u.Cedula Then
                    If u.Activo = False Then
                        row.DefaultCellStyle.BackColor = Color.Red
                    Else
                        row.DefaultCellStyle.BackColor = Color.LightGreen

                    End If
                End If
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim fila As DataGridViewRow = obtenerFilaSeleccionada()
        Dim cedula As String = fila.Cells(2).Value

        Dim frm As New frm_ModificarUsuario(cedula)
    End Sub

    ' optener la fila seleccionada actualmente
    Private Function obtenerFilaSeleccionada() As DataGridViewRow
        If tablaUsuarios.SelectedRows.Count = 0 Then
            Throw New Exception("Seleccione una fila")
        End If

        Return tablaUsuarios.SelectedRows(0)
    End Function
End Class