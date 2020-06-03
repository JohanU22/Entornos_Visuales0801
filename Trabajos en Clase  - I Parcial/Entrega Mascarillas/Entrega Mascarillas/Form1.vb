Public Class Form1

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        'For, DoWhile
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtDepartamentos.Text)
        If (departamentos > 0 And departamentos <= 18) Then
            For i = 1 To departamentos Step 1
                Do
                    mascarillas = InputBox("Ingrese la cantidad de mascarillas" & i, "Ingresar")
                Loop While (mascarillas < 0 Or mascarillas > 10000)
                cmbDepartamento.Items.Add(mascarillas)
            Next
        Else
            MessageBox.Show("No se pueden ingresar valores mayores a 18", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios, cantEntrega As Integer
        Dim itemDepartamento As String
        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString
        municipios = Val(txtMunicipios.Text)
        txtStock.Text = itemDepartamento

        If (idDepartamento >= 0 And idDepartamento <= 18) Then
            validar_municipios(idDepartamento, itemDepartamento, cantEntrega, municipios)

        Else
            MessageBox.Show("Debe ingresar valores adecuados", "Alerta", MessageBoxButtons.OK)
        End If


    End Sub

    Public Function validar_municipios(idDep As Integer, itemDep As Integer, cantE As Integer, municip As Integer)
        Select Case idDep
            Case 0
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 1
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 2
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 3
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 4
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 5
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 6
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 7
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 8
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 9
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 10
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 11
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 12
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 13
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 14
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 15
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 16
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 17
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
            Case 18
                For i = 1 To municip Step 1
                    While (itemDep > 0)
                        cantE = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")

                        If (itemDep > cantE Or itemDep = cantE) Then
                            municip += 1
                            itemDep -= cantE
                            txtStock.Text = itemDep
                        ElseIf (itemDep < cantE) Then
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        If (itemDep = 0) Then
                            MessageBox.Show("Mascarillas Entregadas", "Exito", MessageBoxButtons.OK)
                            txtStock.Text = itemDep
                        End If

                    End While
                Next
                txtStock.Text = itemDep
        End Select

    End Function


End Class
