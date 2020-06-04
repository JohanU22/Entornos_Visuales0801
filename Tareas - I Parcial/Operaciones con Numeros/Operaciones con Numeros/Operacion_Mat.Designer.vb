<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operacion_Mat
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkRaiz = New System.Windows.Forms.CheckBox()
        Me.checkPotencia = New System.Windows.Forms.CheckBox()
        Me.checkDivision = New System.Windows.Forms.CheckBox()
        Me.checkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.checkResta = New System.Windows.Forms.CheckBox()
        Me.checkSuma = New System.Windows.Forms.CheckBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtMult = New System.Windows.Forms.TextBox()
        Me.txtDiv = New System.Windows.Forms.TextBox()
        Me.txtPot = New System.Windows.Forms.TextBox()
        Me.txtRaiz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Elija una opcion:"
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(168, 60)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 53
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(29, 60)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 52
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(316, 60)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 51
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Valor 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Valor 1"
        '
        'checkRaiz
        '
        Me.checkRaiz.AutoSize = True
        Me.checkRaiz.Location = New System.Drawing.Point(51, 248)
        Me.checkRaiz.Name = "checkRaiz"
        Me.checkRaiz.Size = New System.Drawing.Size(196, 17)
        Me.checkRaiz.TabIndex = 48
        Me.checkRaiz.Text = "Raiz (Ingrese primero el valor mayor)"
        Me.checkRaiz.UseVisualStyleBackColor = True
        '
        'checkPotencia
        '
        Me.checkPotencia.AutoSize = True
        Me.checkPotencia.Location = New System.Drawing.Point(51, 225)
        Me.checkPotencia.Name = "checkPotencia"
        Me.checkPotencia.Size = New System.Drawing.Size(68, 17)
        Me.checkPotencia.TabIndex = 47
        Me.checkPotencia.Text = "Potencia"
        Me.checkPotencia.UseVisualStyleBackColor = True
        '
        'checkDivision
        '
        Me.checkDivision.AutoSize = True
        Me.checkDivision.Location = New System.Drawing.Point(51, 202)
        Me.checkDivision.Name = "checkDivision"
        Me.checkDivision.Size = New System.Drawing.Size(63, 17)
        Me.checkDivision.TabIndex = 46
        Me.checkDivision.Text = "División"
        Me.checkDivision.UseVisualStyleBackColor = True
        '
        'checkMultiplicacion
        '
        Me.checkMultiplicacion.AutoSize = True
        Me.checkMultiplicacion.Location = New System.Drawing.Point(52, 179)
        Me.checkMultiplicacion.Name = "checkMultiplicacion"
        Me.checkMultiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.checkMultiplicacion.TabIndex = 45
        Me.checkMultiplicacion.Text = "Multiplicación"
        Me.checkMultiplicacion.UseVisualStyleBackColor = True
        '
        'checkResta
        '
        Me.checkResta.AutoSize = True
        Me.checkResta.Location = New System.Drawing.Point(51, 156)
        Me.checkResta.Name = "checkResta"
        Me.checkResta.Size = New System.Drawing.Size(54, 17)
        Me.checkResta.TabIndex = 44
        Me.checkResta.Text = "Resta"
        Me.checkResta.UseVisualStyleBackColor = True
        '
        'checkSuma
        '
        Me.checkSuma.AutoSize = True
        Me.checkSuma.Location = New System.Drawing.Point(52, 133)
        Me.checkSuma.Name = "checkSuma"
        Me.checkSuma.Size = New System.Drawing.Size(53, 17)
        Me.checkSuma.TabIndex = 43
        Me.checkSuma.Text = "Suma"
        Me.checkSuma.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(324, 446)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 55
        Me.btnLimpiar.Text = "Li&mpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRaiz)
        Me.GroupBox1.Controls.Add(Me.txtPot)
        Me.GroupBox1.Controls.Add(Me.txtDiv)
        Me.GroupBox1.Controls.Add(Me.txtMult)
        Me.GroupBox1.Controls.Add(Me.txtResta)
        Me.GroupBox1.Controls.Add(Me.txtSuma)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 287)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 144)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Respuestas"
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(95, 31)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.ReadOnly = True
        Me.txtSuma.Size = New System.Drawing.Size(73, 20)
        Me.txtSuma.TabIndex = 57
        '
        'txtResta
        '
        Me.txtResta.Location = New System.Drawing.Point(95, 70)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.ReadOnly = True
        Me.txtResta.Size = New System.Drawing.Size(73, 20)
        Me.txtResta.TabIndex = 58
        '
        'txtMult
        '
        Me.txtMult.Location = New System.Drawing.Point(95, 108)
        Me.txtMult.Name = "txtMult"
        Me.txtMult.ReadOnly = True
        Me.txtMult.Size = New System.Drawing.Size(73, 20)
        Me.txtMult.TabIndex = 59
        '
        'txtDiv
        '
        Me.txtDiv.Location = New System.Drawing.Point(285, 31)
        Me.txtDiv.Name = "txtDiv"
        Me.txtDiv.ReadOnly = True
        Me.txtDiv.Size = New System.Drawing.Size(73, 20)
        Me.txtDiv.TabIndex = 60
        '
        'txtPot
        '
        Me.txtPot.Location = New System.Drawing.Point(285, 70)
        Me.txtPot.Name = "txtPot"
        Me.txtPot.ReadOnly = True
        Me.txtPot.Size = New System.Drawing.Size(73, 20)
        Me.txtPot.TabIndex = 61
        '
        'txtRaiz
        '
        Me.txtRaiz.Location = New System.Drawing.Point(285, 108)
        Me.txtRaiz.Name = "txtRaiz"
        Me.txtRaiz.ReadOnly = True
        Me.txtRaiz.Size = New System.Drawing.Size(73, 20)
        Me.txtRaiz.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Suma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Multiplicacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Resta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Raiz"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(232, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Potencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(235, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Division"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Location = New System.Drawing.Point(243, 446)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 57
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Operacion_Mat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 481)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.checkRaiz)
        Me.Controls.Add(Me.checkPotencia)
        Me.Controls.Add(Me.checkDivision)
        Me.Controls.Add(Me.checkMultiplicacion)
        Me.Controls.Add(Me.checkResta)
        Me.Controls.Add(Me.checkSuma)
        Me.Name = "Operacion_Mat"
        Me.Text = "Operacion_Mat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents checkRaiz As CheckBox
    Friend WithEvents checkPotencia As CheckBox
    Friend WithEvents checkDivision As CheckBox
    Friend WithEvents checkMultiplicacion As CheckBox
    Friend WithEvents checkResta As CheckBox
    Friend WithEvents checkSuma As CheckBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRaiz As TextBox
    Friend WithEvents txtPot As TextBox
    Friend WithEvents txtDiv As TextBox
    Friend WithEvents txtMult As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents btnSalir As Button
End Class
