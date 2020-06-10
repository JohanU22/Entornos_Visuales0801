Public Class FormIngreso
    Dim numcasos_atlantida, casosact_atlantida, casosrecu_atlantida, casosmuerto_atlantida As Integer
    Dim numcasos_Morazan, casosact_Morazan, casosrecu_Morazan, casosmuerto_Morazan As Integer
    Dim numcasos_Ocotepeque, casosact_Ocotepeque, casosrecu_Ocotepeque, casosmuerto_Ocotepeque As Integer
    Dim numcasos_Copan, casosact_Copan, casosrecu_Copan, casosmuerto_Copan As Integer
    Dim numcasos_Barbara, casosact_Barbara, casosrecu_Barbara, casosmuerto_Barbara As Integer
    Dim numcasos_Cortes, casosact_Cortes, casosrecu_Cortes, casosmuerto_Cortes As Integer
    Dim numcasos_Colon, casosact_Colon, casosrecu_Colon, casosmuerto_Colon As Integer
    Dim numcasos_Dios, casosact_Dios, casosrecu_Dios, casosmuerto_Dios As Integer
    Dim numcasos_olancho, casosact_olancho, casosrecu_olancho, casosmuerto_olancho As Integer
    Dim numcasos_Paraiso, casosact_Paraiso, casosrecu_Paraiso, casosmuerto_Paraiso As Integer

    Private Sub cmbEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbEstado.Validating

    End Sub

    Private Sub cmbResultadoPrueba_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbResultadoPrueba.Validating

    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese su municipio de residencia")
        End If
    End Sub

    Private Sub cmbDepartamento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbDepartamento.Validating

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un dato necesario")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Debe ingresar un nombre")
        End If
    End Sub

    Dim numcasos_Choluteca, casosact_Choluteca, casosrecu_Choluteca, casosmuerto_Choluteca As Integer

    Private Sub btnEspecifico_Click(sender As Object, e As EventArgs) Handles btnEspecifico.Click
        Try

            Select Case cmbEspecifico.SelectedItem
                Case "Atlantida"
                    lstEspecifico.Items.Add("         Atlantida")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_atlantida)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_atlantida)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_atlantida)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_atlantida)
                Case "Francisco Morazan"
                    lstEspecifico.Items.Add("        Francisco Morazan")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Morazan)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Morazan)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Morazan)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Morazan)
                Case "Ocotepeque"
                    lstEspecifico.Items.Add("         Ocotepeque")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Ocotepeque)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Ocotepeque)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Ocotepeque)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Ocotepeque)
                Case "Copan"
                    lstEspecifico.Items.Add("           Copan")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Copan)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Copan)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Copan)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Copan)
                Case "Santa Barbara"
                    lstEspecifico.Items.Add("         Santa Barbara")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Barbara)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Barbara)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Barbara)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Barbara)
                Case "Cortes"
                    lstEspecifico.Items.Add("           Cortes")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Cortes)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Cortes)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Cortes)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Cortes)
                Case "Colon"
                    lstEspecifico.Items.Add("           Colon")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Colon)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Colon)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Colon)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Colon)
                Case "Gracias a Dios"
                    lstEspecifico.Items.Add("         Gracias a Dios")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Dios)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Dios)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Dios)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Dios)
                Case "Olancho"
                    lstEspecifico.Items.Add("         Olancho")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_olancho)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_olancho)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_olancho)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_olancho)
                Case "El Paraiso"
                    lstEspecifico.Items.Add("         El Paraiso")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Paraiso)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Paraiso)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Paraiso)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Paraiso)
                Case "Choluteca"
                    lstEspecifico.Items.Add("         Choluteca")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Choluteca)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Choluteca)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Choluteca)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Choluteca)
                Case "Valle"
                    lstEspecifico.Items.Add("         Valle")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Valle)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Valle)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Valle)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Valle)
                Case "La Paz"
                    lstEspecifico.Items.Add("          La Paz")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Paz)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Paz)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Paz)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Paz)
                Case "Intibuca"
                    lstEspecifico.Items.Add("         Intibuca")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Intibuca)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Intibuca)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Intibuca)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Intibuca)
                Case "Lempira"
                    lstEspecifico.Items.Add("         Lempira")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Lempira)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Lempira)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Lempira)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Lempira)
                Case "Comayagua"
                    lstEspecifico.Items.Add("          Comayagua")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Comayagua)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Comayagua)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Comayagua)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Comayagua)
                Case "Yoro"
                    lstEspecifico.Items.Add("          Yoro")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Yoro)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Yoro)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Yoro)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Yoro)
                Case "Islas de la Bahia"
                    lstEspecifico.Items.Add("         Islas de la Bahia")
                    lstEspecifico.Items.Add("Numero de Casos: " & numcasos_Islas)
                    lstEspecifico.Items.Add("Numero de Casos Activos: " & casosact_Islas)
                    lstEspecifico.Items.Add("Numero de Fallecidos: " & casosmuerto_Islas)
                    lstEspecifico.Items.Add("Numero de Recuperados: " & casosrecu_Islas)
                Case "Ninguno"
                    MessageBox.Show("Debe elegir un departamento obligatoriamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtNombre.Clear()


    End Sub

    Dim numcasos_Valle, casosact_Valle, casosrecu_Valle, casosmuerto_Valle As Integer
    Dim numcasos_Paz, casosact_Paz, casosrecu_Paz, casosmuerto_Paz As Integer
    Dim numcasos_Intibuca, casosact_Intibuca, casosrecu_Intibuca, casosmuerto_Intibuca As Integer
    Dim numcasos_Lempira, casosact_Lempira, casosrecu_Lempira, casosmuerto_Lempira As Integer
    Dim numcasos_Comayagua, casosact_Comayagua, casosrecu_Comayagua, casosmuerto_Comayagua As Integer
    Dim numcasos_Yoro, casosact_Yoro, casosrecu_Yoro, casosmuerto_Yoro As Integer
    Dim numcasos_Islas, casosact_Islas, casosrecu_Islas, casosmuerto_Islas As Integer

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    Private Sub lstReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReporte.SelectedIndexChanged
        Dim cancelar As Integer

        Try
            If (lstReporte.Items(0) <> "") And (MsgBox("Seguro(a) que Desea Borrar?... Nota: Al borrar reporte solo se borra lo mostrado en la lista, mas no los datos ya ingresados", vbQuestion + vbYesNo) = vbYes) Then
                lstReporte.Items.Clear()

            Else
                cancelar = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    '------------------------------------------------------------------------------------------------------------------

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim cancelar As Integer

        Try
            If (MsgBox("Seguro(a) que Desea Salir?", vbQuestion + vbYesNo) = vbYes) Then
                Me.Close()

            Else
                cancelar = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------------------------------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim nombre, edad, municipio, departamento, estado, resultado As String

        nombre = txtNombre.Text
        edad = txtEdad.Text
        municipio = txtMunicipio.Text
        departamento = cmbDepartamento.SelectedItem
        estado = cmbEstado.SelectedItem
        resultado = cmbResultadoPrueba.SelectedItem

        Try
            If (txtEdad.Text <> "" And txtNombre.Text <> "" And txtMunicipio.Text <> "" And cmbDepartamento.SelectedItem <> "Ninguno" And cmbEstado.SelectedItem <> "" And cmbResultadoPrueba.SelectedItem <> "") Then
                lstHistorial.Items.Add("Nombre: " & nombre & " / Edad: " & edad & " / Departamento: " & departamento & " / Resultado de la prueba: " & resultado & " / Estado: " & estado)

                Select Case cmbDepartamento.SelectedItem
                    Case "Atlantida"
                        numcasos_atlantida = numcasos_atlantida + 1
                        Atlantida(estado)
                    Case "Francisco Morazan"
                        numcasos_Morazan = numcasos_Morazan + 1
                        Morazan(estado)
                    Case "Ocotepeque"
                        numcasos_Ocotepeque = numcasos_Ocotepeque + 1
                        Ocotepeque(estado)
                    Case "Copan"
                        numcasos_Copan = numcasos_Copan + 1
                        Copan(estado)
                    Case "Santa Barbara"
                        numcasos_Barbara = numcasos_Barbara + 1
                        Barbara(estado)
                    Case "Cortes"
                        numcasos_Cortes = numcasos_Cortes + 1
                        Cortes(estado)
                    Case "Colon"
                        numcasos_Colon = numcasos_Colon + 1
                        Colon(estado)
                    Case "Gracias a Dios"
                        numcasos_Dios = numcasos_Dios + 1
                        Dios(estado)
                    Case "Olancho"
                        numcasos_olancho = numcasos_olancho + 1
                        Olancho(estado)
                    Case "El Paraiso"
                        numcasos_Paraiso = numcasos_Paraiso + 1
                        Paraiso(estado)
                    Case "Choluteca"
                        numcasos_Choluteca = numcasos_Choluteca + 1
                        Choluteca(estado)
                    Case "Valle"
                        numcasos_Valle = numcasos_Valle + 1
                        Valle(estado)
                    Case "La Paz"
                        numcasos_Paz = numcasos_Paz + 1
                        Paz(estado)
                    Case "Intibuca"
                        numcasos_Intibuca = numcasos_Intibuca + 1
                        Intibuca(estado)
                    Case "Lempira"
                        numcasos_Lempira = numcasos_Lempira + 1
                        Lempira(estado)
                    Case "Comayagua"
                        numcasos_Comayagua = numcasos_Comayagua + 1
                        Comayagua(estado)
                    Case "Yoro"
                        numcasos_Yoro = numcasos_Yoro + 1
                        Yoro(estado)
                    Case "Islas de la Bahia"
                        numcasos_Yoro = numcasos_Yoro + 1
                        Yoro(estado)
                    Case "Ninguno"
                        MessageBox.Show("Debe elegir un departamento obligatoriamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                MessageBox.Show("Debe llenar absolutamente todos los datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
    '------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click

        lstReporte.Items.Add("         1.Atlantida")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_atlantida)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_atlantida)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_atlantida)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_atlantida)
        lstReporte.Items.Add("     2.Francisco Morazan")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Morazan)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Morazan)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Morazan)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Morazan)
        lstReporte.Items.Add("       3.Ocotepeque")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Ocotepeque)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Ocotepeque)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Ocotepeque)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Ocotepeque)
        lstReporte.Items.Add("          4.Copan")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Copan)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Copan)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Copan)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Copan)
        lstReporte.Items.Add("      5. Santa Barbara")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Barbara)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Barbara)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Barbara)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Barbara)
        lstReporte.Items.Add("        6. Cortes")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Cortes)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Cortes)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Cortes)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Cortes)
        lstReporte.Items.Add("        7. Colon")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Colon)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Colon)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Colon)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Colon)
        lstReporte.Items.Add("      8. Gracias a Dios")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Dios)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Dios)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Dios)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Dios)
        lstReporte.Items.Add("      9. Olancho")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_olancho)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_olancho)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_olancho)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_olancho)
        lstReporte.Items.Add("      10. El Paraiso")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Paraiso)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Paraiso)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Paraiso)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Paraiso)
        lstReporte.Items.Add("      11. Choluteca")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Choluteca)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Choluteca)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Choluteca)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Choluteca)
        lstReporte.Items.Add("      12. Valle")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Valle)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Valle)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Valle)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Valle)
        lstReporte.Items.Add("      13. La Paz")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Paz)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Paz)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Paz)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Paz)
        lstReporte.Items.Add("      14. Intibuca")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Intibuca)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Intibuca)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Intibuca)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Intibuca)
        lstReporte.Items.Add("      15. Intibuca")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Lempira)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Lempira)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Lempira)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Lempira)
        lstReporte.Items.Add("      16. Comayagua")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Comayagua)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Comayagua)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Comayagua)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Comayagua)
        lstReporte.Items.Add("        17. Yoro")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Yoro)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Yoro)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Yoro)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Yoro)
        lstReporte.Items.Add("       18. Islas de la Bahia")
        lstReporte.Items.Add("Numero de Casos: " & numcasos_Islas)
        lstReporte.Items.Add("Numero de Casos Activos: " & casosact_Islas)
        lstReporte.Items.Add("Numero de Fallecidos: " & casosmuerto_Islas)
        lstReporte.Items.Add("Numero de Recuperados: " & casosrecu_Islas)


    End Sub

    '---------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------

    Public Function Atlantida(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_atlantida = casosact_atlantida + 1
            Case "Recuperado"
                casosrecu_atlantida = casosrecu_atlantida + 1
            Case "Muerto"
                casosmuerto_atlantida = casosmuerto_atlantida + 1
        End Select

    End Function

    Public Function Morazan(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Morazan = casosact_Morazan + 1
            Case "Recuperado"
                casosrecu_Morazan = casosrecu_Morazan + 1
            Case "Muerto"
                casosmuerto_Morazan = casosmuerto_Morazan + 1
        End Select

    End Function

    Public Function Ocotepeque(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Ocotepeque = casosact_Ocotepeque + 1
            Case "Recuperado"
                casosrecu_Ocotepeque = casosrecu_Ocotepeque + 1
            Case "Muerto"
                casosmuerto_Ocotepeque = casosmuerto_Ocotepeque + 1
        End Select

    End Function

    Public Function Copan(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Copan = casosact_Copan + 1
            Case "Recuperado"
                casosrecu_Copan = casosrecu_Copan + 1
            Case "Muerto"
                casosmuerto_Copan = casosmuerto_Copan + 1
        End Select

    End Function

    Public Function Barbara(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Barbara = casosact_Barbara + 1
            Case "Recuperado"
                casosrecu_Barbara = casosrecu_Barbara + 1
            Case "Muerto"
                casosmuerto_Barbara = casosmuerto_Barbara + 1
        End Select

    End Function

    Public Function Cortes(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Cortes = casosact_Cortes + 1
            Case "Recuperado"
                casosrecu_Cortes = casosrecu_Cortes + 1
            Case "Muerto"
                casosmuerto_Cortes = casosmuerto_Cortes + 1
        End Select

    End Function

    Public Function Colon(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Colon = casosact_Colon + 1
            Case "Recuperado"
                casosrecu_Colon = casosrecu_Colon + 1
            Case "Muerto"
                casosmuerto_Colon = casosmuerto_Colon + 1
        End Select

    End Function

    Public Function Dios(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Dios = casosact_Dios + 1
            Case "Recuperado"
                casosrecu_Dios = casosrecu_Dios + 1
            Case "Muerto"
                casosmuerto_Dios = casosmuerto_Dios + 1
        End Select

    End Function

    Public Function Olancho(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_olancho = casosact_olancho + 1
            Case "Recuperado"
                casosrecu_olancho = casosrecu_olancho + 1
            Case "Muerto"
                casosmuerto_olancho = casosmuerto_olancho + 1
        End Select

    End Function

    Public Function Paraiso(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Paraiso = casosact_Paraiso + 1
            Case "Recuperado"
                casosrecu_Paraiso = casosrecu_Paraiso + 1
            Case "Muerto"
                casosmuerto_Paraiso = casosmuerto_Paraiso + 1
        End Select

    End Function

    Public Function Choluteca(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Choluteca = casosact_Choluteca + 1
            Case "Recuperado"
                casosrecu_Choluteca = casosrecu_Choluteca + 1
            Case "Muerto"
                casosmuerto_Choluteca = casosmuerto_Choluteca + 1
        End Select

    End Function


    Public Function Valle(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Valle = casosact_Valle + 1
            Case "Recuperado"
                casosrecu_Valle = casosrecu_Valle + 1
            Case "Muerto"
                casosmuerto_Valle = casosmuerto_Valle + 1
        End Select

    End Function

    Public Function Paz(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Paz = casosact_Paz + 1
            Case "Recuperado"
                casosrecu_Paz = casosrecu_Paz + 1
            Case "Muerto"
                casosmuerto_Paz = casosmuerto_Paz + 1
        End Select

    End Function


    Public Function Intibuca(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Intibuca = casosact_Intibuca + 1
            Case "Recuperado"
                casosrecu_Intibuca = casosrecu_Intibuca + 1
            Case "Muerto"
                casosmuerto_Intibuca = casosmuerto_Intibuca + 1
        End Select

    End Function

    Public Function Lempira(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Lempira = casosact_Lempira + 1
            Case "Recuperado"
                casosrecu_Lempira = casosrecu_Lempira + 1
            Case "Muerto"
                casosmuerto_Lempira = casosmuerto_Lempira + 1
        End Select

    End Function

    Public Function Comayagua(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Comayagua = casosact_Comayagua + 1
            Case "Recuperado"
                casosrecu_Comayagua = casosrecu_Comayagua + 1
            Case "Muerto"
                casosmuerto_Comayagua = casosmuerto_Comayagua + 1
        End Select

    End Function

    Public Function Yoro(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Yoro = casosact_Yoro + 1
            Case "Recuperado"
                casosrecu_Yoro = casosrecu_Yoro + 1
            Case "Muerto"
                casosmuerto_Yoro = casosmuerto_Yoro + 1
        End Select

    End Function

    Public Function Islas(estad_o As String)

        Select Case estad_o
            Case "Activo"
                casosact_Islas = casosact_Islas + 1
            Case "Recuperado"
                casosrecu_Islas = casosrecu_Islas + 1
            Case "Muerto"
                casosmuerto_Islas = casosmuerto_Islas + 1
        End Select

    End Function


    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEstado.Items.Add("Activo")
        cmbEstado.Items.Add("Recuperado")
        cmbEstado.Items.Add("Muerto")


    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged

    End Sub
End Class