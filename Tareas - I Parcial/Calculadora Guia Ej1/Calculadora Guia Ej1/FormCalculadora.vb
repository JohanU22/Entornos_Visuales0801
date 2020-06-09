Public Class FormCalculadora
    Dim presiona_igual As Boolean
    Dim Capture_Operacion As String
    Dim Presionar_Operador As Boolean
    Dim Operacion As String
    Dim valor As Nullable(Of Double) = Nothing
    Dim valor_2 As Nullable(Of Double) = Nothing
    'Dim operaciones(25) As String


    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "9"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Evaluar_Operacion()
        Capture_Operacion += "/"
        Operacion = "/"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtResultado.Text = 0
        valor = Nothing
        valor_2 = Nothing
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "6"
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        Evaluar_Operacion()
        Capture_Operacion += "*"
        Operacion = "*"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "3"
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        Evaluar_Operacion()
        Capture_Operacion += "-"
        Operacion = "-"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Evaluar_Concatenacion()
        txtResultado.Text &= "0"
    End Sub

    Private Sub btnSigno_Click(sender As Object, e As EventArgs) Handles btnSigno.Click

    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        Evaluar_Concatenacion()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If

    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        Evaluar_Operacion()
        Capture_Operacion += "+"
        Operacion = "+"
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        presiona_igual = True
        Evaluar_Operacion()

        Operacion = ""
        Capture_Operacion += "=" + txtResultado.Text
        If Not IsNothing(ListView1.Items) Then
            ListView1.Items.Add(Capture_Operacion)
            Capture_Operacion = ""
        End If
    End Sub

    Public Sub Evaluar_Operacion()
        Presionar_Operador = True
        Capture_Operacion += txtResultado.Text
        valor_2 = Val(txtResultado.Text)
        If valor IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    valor += valor_2
                Case "-"
                    valor -= valor_2
                Case "*"
                    valor *= valor_2
                Case "/"
                    valor /= valor_2
            End Select
            txtResultado.Text = valor
        Else
            valor = valor_2
        End If

    End Sub

    Public Sub Evaluar_Concatenacion()
        If Presionar_Operador = True Then
            txtResultado.Text = ""
            Presionar_Operador = False
        ElseIf txtResultado.Text = 0 Then
            txtResultado.Text = ""
        End If


    End Sub

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
