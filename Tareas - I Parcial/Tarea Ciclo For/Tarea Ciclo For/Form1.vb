Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim numero, Var, Vi, Vf As Integer
        Dim fact As Double

        numero = Val(txtNumero.Text)
        Vi = 1
        Vf = numero
        fact = 1

        If numero >= 0 And (IsNumeric(numero)) And (Val(txtNumero.Text) - Int(Val(txtNumero.Text)) = 0) Then

            For Var = Vf To Vi Step -1
                fact = Var * fact
            Next Var

            txtFactorial.Text = fact
            txtFactorial.TextAlign = HorizontalAlignment.Center
        End If

        If numero < 0 Or (Not IsNumeric(numero)) Or (Val(txtNumero.Text) - Int(Val(txtNumero.Text)) <> 0) Then
            MsgBox("MATH ERROR ...Debe ingresar un numero entero positivo")
        End If

        If txtNumero.Text = "" Then
            MsgBox("Debe ingresar un valor en la casilla")

        End If

    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub


End Class
