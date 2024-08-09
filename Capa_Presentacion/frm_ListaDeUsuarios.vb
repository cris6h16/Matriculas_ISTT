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
        Try
            Dim cedula As String = obtenerCedulaDeLaFilaSeleccionada()

            Dim frm As New frm_ModificarUsuario(cedula)
            frm.ShowDialog()

            llenarTabla()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' optener la fila seleccionada actualmente
    Private Function obtenerCedulaDeLaFilaSeleccionada() As String
        If tablaUsuarios.SelectedRows.Count = 0 Then
            Throw New Exception("Seleccione una fila")
        End If

        Dim cedula As String = tablaUsuarios.SelectedRows(0).Cells(2).Value

        If cedula Is Nothing Or cedula = "" Then
            Throw New Exception("No se pudo obtener la cedula de la fila seleccionada")
        End If

        Return cedula
    End Function

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try

            Dim cedula As String = obtenerCedulaDeLaFilaSeleccionada()

            confirmarEliminacion() ' si no, lanzará una excepción

            negocioUsuario.eliminarPorCedula(cedula) ' eliminar el usuario

            llenarTabla()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub confirmarEliminacion()
        Dim result As Integer = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Throw New Exception("Eliminación cancelada")
        End If
    End Sub


    Private Sub dejarSoloFilasConLaCedulaQueComienzeCon(patron As String)
        For Each row As DataGridViewRow In tablaUsuarios.Rows
            If row.Cells(2).Value.ToString.StartsWith(patron) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txb_filtrar.TextChanged
        Dim patron As String = txb_filtrar.Text

        If patron.Length = 0 Then
            llenarTabla()
            Return
        End If

        dejarSoloFilasConLaCedulaQueComienzeCon(txb_filtrar.Text)
    End Sub
End Class