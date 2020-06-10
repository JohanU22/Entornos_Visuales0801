Public Class FormPrincipal
    Dim Usuario_validado As Boolean
    Dim usuario As String
    Dim contraseña As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click
        Dim usuario_reg, contraseña_reg As String

        usuario_reg = InputBox("Ingrese un usuario tipo administrador:")
        contraseña_reg = InputBox("Ingrese una contraseña de administrador:")

        If (usuario_reg <> "" And contraseña_reg <> "") Then

            usuario_reg = usuario_reg.ToLower

            Try
                If (usuario_reg = "administrador" And contraseña_reg = "SinHacer2020") Then
                    MessageBox.Show("Ha Ingresado Exitosamente", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Usuario_validado = True
                Else
                    MessageBox.Show("Debe ingresar los datos de administrador correctos", "Error")
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Recuerde llenar todas las casillas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        contraseña = txtContraseña.Text
        usuario = txtUsuario.Text

        If (usuario <> "" And contraseña <> "") Then
            Try
                usuario = usuario.ToLower
                If (Usuario_validado = True) And (usuario = "administrador" And contraseña = "SinHacer2020") Then
                    MessageBox.Show("Ha Ingresado Exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    FormIngreso.Show()
                Else
                    MessageBox.Show("Debe registrarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtUsuario.Clear()
                    txtContraseña.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Recuerde llenar todas las casillas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class
