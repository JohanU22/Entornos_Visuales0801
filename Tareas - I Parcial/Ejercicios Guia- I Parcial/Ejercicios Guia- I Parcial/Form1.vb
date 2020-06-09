Public Class FormPrincipal
    Private Sub btnCalculadora_Click(sender As Object, e As EventArgs) Handles btnCalculadora.Click
        Me.Hide()
        FormCalculadora.Show()
    End Sub

    Private Sub btnCuadratica_Click(sender As Object, e As EventArgs) Handles btnCuadratica.Click
        Me.Hide()
        FormulaCuadratica.Show()
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        Me.Hide()
        FormAlmacen.Show()
    End Sub

    Private Sub btnNumeros_Click(sender As Object, e As EventArgs) Handles btnNumeros.Click
        Me.Hide()
        FormEj4.Show()

    End Sub

    Private Sub btnSalario_Click(sender As Object, e As EventArgs) Handles btnSalario.Click
        Me.Hide()
        FormEj5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
