Partial Class dsMatriculas
    Partial Public Class estudiantesDataTable
        Private Sub estudiantesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nombresColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub estudiantesDataTable_estudiantesRowChanging(sender As Object, e As estudiantesRowChangeEvent) Handles Me.estudiantesRowChanging

        End Sub

    End Class
End Class
