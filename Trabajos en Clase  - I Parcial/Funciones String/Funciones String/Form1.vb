Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cadena As String
        cadena = txtCadena.Text
        txtLongitud.Text = cadena.Length
        txtUltimo.Text = cadena.Substring(cadena.Length - 1, 1)
        txtPrimero.Text = cadena.Substring(0, 1)
        txtPosicion.Text = cadena.IndexOf("B", 0) + 1
        txtMayusculas.Text = cadena.ToUpper
        txtMinusculas.Text = cadena.ToLower
        txtBorrar.Text = cadena.Replace(" ", "")
        txtPosicionFija.Text = cadena.Substring(2, 7)


    End Sub

    Private Sub txtCadena_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCadena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class
