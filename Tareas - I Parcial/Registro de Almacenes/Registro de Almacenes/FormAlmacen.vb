Public Class FormAlmacen
    Private Sub btnElegir_Click(sender As Object, e As EventArgs) Handles btnElegir.Click
        Dim opcion_elegida As String
        Dim medA1, medA2, medA3, medA4, medA5, medA6, medA7, medA8, medA9, medA10 As Double
        opcion_elegida = cmbAlmacenes.SelectedItem

        Try
            If (Me.ValidateChildren And opcion_elegida <> "Ninguno") Then
                Select Case opcion_elegida
                    Case "Almacen Dirgen"
                        medA1 = almacen1()
                    Case "Almacen Luna Llena"
                        medA2 = almacen2()
                    Case "Almacen Los Santos"
                        medA3 = almacen3()
                    Case "Almacen de Ceiba"
                        medA4 = almacen4()
                    Case "Almacen Nuevo Horizonte"
                        medA5 = almacen5()
                    Case "Almacen Bella Vista"
                        medA6 = almacen6()
                    Case "Almacen El Hoyo"
                        medA7 = almacen7()
                    Case "Almacen El Paso"
                        medA8 = almacen8()
                    Case "Almacen Nuevo Dia"
                        medA9 = almacen9()
                    Case "Almacen El Amanecer"
                        medA10 = almacen10()
                    Case "Ninguno"

                End Select

                Select Case opcion_elegida
                    Case "Almacen Dirgen"
                        If medA1 < 10000 Then
                            lstBajo.Items.Add("Almacen Dirgen")
                        Else
                            lstSobre.Items.Add("Almacen Dirgen")
                        End If
                    Case "Almacen Luna Llena"
                        If medA2 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Almacen Los Santos"
                        If medA3 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Almacen de Ceiba"
                        If medA4 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Almacen Nuevo Horizonte"
                        If medA5 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Almacen Bella Vista"
                        If medA6 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Almacen El Hoyo"
                        If medA7 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Almacen El Paso"
                        If medA8 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Almacen Nuevo Dia"
                        If medA9 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Almacen El Amanecer"
                        If medA10 < 10000 Then
                            lstBajo.Items.Add("Luna LLena")
                        Else
                            lstSobre.Items.Add("Luna Llena")
                        End If
                    Case "Ninguno"

                End Select
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Function almacen1()
        Dim cant, i As Integer
        Dim sum, media1 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media1 = sum / cant

        Return media1
    End Function

    Public Function almacen2()
        Dim cant, i As Integer
        Dim sum, media2 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media2 = sum / cant

        Return media2
    End Function

    Public Function almacen3()
        Dim cant, i As Integer
        Dim sum, media3 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media3 = sum / cant


        Return media3
    End Function

    Public Function almacen4()
        Dim cant, i As Integer
        Dim sum, media4 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media4 = sum / cant


        Return media4
    End Function

    Public Function almacen5()
        Dim cant, i As Integer
        Dim sum, media5 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media5 = sum / cant


        Return media5
    End Function

    Public Function almacen6()
        Dim cant, i As Integer
        Dim sum, media6 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media6 = sum / cant

        Return media6
    End Function

    Public Function almacen7()
        Dim cant, i As Integer
        Dim sum, media7 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media7 = sum / cant

        Return media7
    End Function

    Public Function almacen8()
        Dim cant, i As Integer
        Dim sum, media8 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media8 = sum / cant

        Return media8
    End Function

    Public Function almacen9()
        Dim cant, i As Integer
        Dim sum, media9 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media9 = sum / cant

        Return media9
    End Function

    Public Function almacen10()
        Dim cant, i As Integer
        Dim sum, media10 As Double

        cant = InputBox("Ingrese la cantidad de ventas a ingresar", "Ingreso")


        For i = 1 To cant
            sum += InputBox("Ingrese el precio de la venta", "Ingreso")
        Next i


        media10 = sum / cant

        Return media10
    End Function

End Class

