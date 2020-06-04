Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)


        'Dim aplica_cmb As Boolean



    End Sub

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        Me.Hide()
        Operacion_Mat.Show()

    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Me.Hide()
        VentanaFactorial.Show()


    End Sub

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        Me.Hide()
        Num_Aleatorio.Show()

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
