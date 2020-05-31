Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim pUnitario, cantidad As Integer
        Dim descuento = 0, total, subtotal, isv As Double
        Dim aplicadescuento, aplicaisv As Boolean
        Dim selected_isv = "Ninguno", selected_dis = "Ninguno", selected As String

        pUnitario = Val(txtUnitario.Text)
        cantidad = Val(txtCantidad.Text)


        subtotal = pUnitario * cantidad
        aplicadescuento = chkDescuento.CheckState
        selected_dis = cmbDescuentos.SelectedItem
        aplicaisv = chkInteres.CheckState
        selected_isv = cmbImpuesto.SelectedItem


            If aplicadescuento <> aplicaisv Then

                If (aplicadescuento = True) Then
                    If selected_dis = "Descuento de Temporada" Then
                        descuento = subtotal * 0.15
                        total = subtotal - descuento
                    ElseIf selected_dis = "Descuento de Cliente" Then
                        descuento = subtotal * 0.25
                        total = subtotal - descuento
                    ElseIf selected_dis = "Descuento de Tercera Edad" Then
                        descuento = subtotal * 0.5
                        total = subtotal - descuento
                    ElseIf selected_dis = "Descuento por Volumen o Rappel" Then
                        descuento = subtotal * 0.1
                        total = subtotal - descuento
                    ElseIf selected_dis = "Descuento por pronto pago" Then
                        descuento = subtotal * 0.35
                        total = subtotal - descuento
                    ElseIf selected_dis = "Descuento Comercial" Then
                        descuento = subtotal * 0.2
                        total = subtotal - descuento
                    End If
                End If
                If (aplicadescuento = True) And (selected_dis = "Ninguno") Then
                    MsgBox("Si selecciona Descuento, Seleccione un tipo de Descuento", vbInformation)
                End If

                If (aplicaisv = True) Then
                    If selected_isv = "Impuesto 15%" Then
                        isv = subtotal * 0.15
                        total = subtotal + isv
                    ElseIf selected_isv = "Impuesto 17%" Then
                        isv = subtotal * 0.17
                        total = subtotal + isv
                    End If
                End If
            If (aplicaisv = True) And (selected_isv = "Ninguno") Then
                MsgBox("Si selecciona Impuesto, Seleccione un tipo de Impuesto", vbInformation)
            End If
            txtSubtotal.Text = subtotal
            txtIsv.Text = isv
            txtDescuento.Text = descuento
            txtTotal.Text = total
            btnNuevo.Enabled = True




        ElseIf aplicadescuento = aplicaisv Then
            MsgBox("SELECCIONE UNICAMENTE 1 CASILLA, YA SEA DESCUENTO O ISV", vbInformation)
        End If



    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtCantidad.Clear()
        txtDescuento.Clear()
        txtIsv.Clear()
        txtUnitario.Clear()
        txtSubtotal.Clear()
        txtTotal.Clear()

        chkInteres.Checked = False
        chkDescuento.Checked = False
        cmbImpuesto.Text = "Ninguno"
        cmbDescuentos.Text = "Ninguno"
        cmbDescuentos.Enabled = False
        cmbImpuesto.Enabled = False
        btnNuevo.Enabled = False



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        cmbDescuentos.Enabled = True
        cmbImpuesto.Enabled = False
        cmbImpuesto.Text = "Ninguno"
        chkInteres.Checked = False

    End Sub

    Private Sub chkInteres_CheckedChanged(sender As Object, e As EventArgs) Handles chkInteres.CheckedChanged
        cmbImpuesto.Enabled = True
        cmbDescuentos.Enabled = False
        cmbDescuentos.Text = "Ninguno"
        chkDescuento.Checked = False
    End Sub

    Private Sub txtUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitario.KeyPress
        If (Not Char.IsControl(e.KeyChar)) And (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True

        End If



    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
