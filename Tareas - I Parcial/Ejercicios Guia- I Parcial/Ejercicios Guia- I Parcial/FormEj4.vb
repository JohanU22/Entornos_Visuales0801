Public Class FormEj4
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim cant_num, cant_pares, cant_impares, cant_pos, cant_neg, numero As Integer
        Dim total As Double
        'Dim numero, cantidad, positivos, negativos, pares, impares, total As Integer
        cant_num = Val(txtNumero.Text)

        Try
            If Not IsNumeric(txtNumero.Text) Then
                MsgBox("Ingrese un numero")
            End If
            For i = 1 To cant_num Step 1
                numero = InputBox("Ingrese numero " & i, "Ingreso de numeros")
                cmbNumeros.Items.Add(numero)
                total += numero
                If numero > 0 Then
                    cant_pos += 1
                Else
                    cant_neg += 1
                End If
                If numero Mod 2 = 0 Then
                    cant_pares += 1
                Else
                    cant_impares += 1
                End If
            Next
            txtPares.Text = cant_pares
            txtImpares.Text = cant_impares
            txtNegativos.Text = cant_neg
            txtPositivos.Text = cant_pos
            txtTotal.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try







    End Sub

    Private Sub txtNumero_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumero.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese un numero")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.cmbNumeros.Items.Clear()
        txtNumero.Clear()
        txtImpares.Clear()
        txtPares.Clear()
        txtNegativos.Clear()
        txtPositivos.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FormPrincipal.Show()
    End Sub
End Class
