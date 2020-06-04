Public Class Num_Aleatorio
    Private Sub Num_Aleatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtMaxim.Clear()
        txtMinim.Clear()
        txtNumAleatorio.Clear()
    End Sub

    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles btnNumero.Click
        Dim min, max As Double
        Dim num_generado As Long


        If (txtMinim.Text <> "") And (txtMaxim.Text <> "") Then
            min = Val(txtMinim.Text)
            max = Val(txtMaxim.Text)

            Randomize()
            num_generado = ((min - max) * Rnd() + max)
            txtNumAleatorio.Text = num_generado
        Else
            MessageBox.Show("Debe llenar todas las casillas correspondientes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
End Class