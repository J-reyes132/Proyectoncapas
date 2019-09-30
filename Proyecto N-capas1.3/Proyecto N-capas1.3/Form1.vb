Public Class Form1
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_precio.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        DataGridViewRow fila = New DataGridViewRow();
        fila.CreateCells(dtgvproductos);


    End Sub
End Class
