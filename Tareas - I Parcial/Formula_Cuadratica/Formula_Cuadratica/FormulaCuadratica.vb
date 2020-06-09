Public Class FormulaCuadratica
    Dim valor_a, valor_b, valor_c, res, res2 As Double

    Private Sub txtA_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtA.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If

    End Sub

    Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged

    End Sub

    Private Sub txtB_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtB.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Debe llenar todos los espacios con numeros")
        End If

    End Sub

    Private Sub txtC_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtC.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Debe ingresar un valor numerico")
        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""
        txtResultado1.Text = ""
        txtResultado2.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        valor_a = Val(txtA.Text)
        valor_b = Val(txtB.Text)
        valor_c = Val(txtC.Text)
        Try
            If Me.ValidateChildren And txtA.Text <> String.Empty And txtB.Text <> String.Empty And txtC.Text <> String.Empty And IsNumeric(txtA.Text) And IsNumeric(txtB.Text) And IsNumeric(txtC.Text) And txtA.Text <> 0 And txtB.Text <> 0 And txtC.Text <> 0 Then
                res = (-valor_b + (valor_b ^ 2 - (4 * valor_a * valor_c)) ^ 1 / 2) / (2 * valor_a)
                res2 = (-valor_b - (valor_b ^ 2 - (4 * valor_a * valor_c)) ^ 1 / 2) / (2 * valor_a)
                txtResultado1.Text = res
                txtResultado2.Text = res2
            Else
                MessageBox.Show("ERROR revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
