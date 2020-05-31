<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkRaiz = New System.Windows.Forms.CheckBox()
        Me.checkPotencia = New System.Windows.Forms.CheckBox()
        Me.checkDivision = New System.Windows.Forms.CheckBox()
        Me.checkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.checkResta = New System.Windows.Forms.CheckBox()
        Me.checkSuma = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(166, 315)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Resultado"
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(166, 58)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 39
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(27, 58)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 38
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(314, 312)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 37
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(314, 58)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 36
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Valor 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Valor 1"
        '
        'checkRaiz
        '
        Me.checkRaiz.AutoSize = True
        Me.checkRaiz.Location = New System.Drawing.Point(59, 262)
        Me.checkRaiz.Name = "checkRaiz"
        Me.checkRaiz.Size = New System.Drawing.Size(196, 17)
        Me.checkRaiz.TabIndex = 33
        Me.checkRaiz.Text = "Raiz (Ingrese primero el valor mayor)"
        Me.checkRaiz.UseVisualStyleBackColor = True
        '
        'checkPotencia
        '
        Me.checkPotencia.AutoSize = True
        Me.checkPotencia.Location = New System.Drawing.Point(59, 239)
        Me.checkPotencia.Name = "checkPotencia"
        Me.checkPotencia.Size = New System.Drawing.Size(68, 17)
        Me.checkPotencia.TabIndex = 32
        Me.checkPotencia.Text = "Potencia"
        Me.checkPotencia.UseVisualStyleBackColor = True
        '
        'checkDivision
        '
        Me.checkDivision.AutoSize = True
        Me.checkDivision.Location = New System.Drawing.Point(59, 216)
        Me.checkDivision.Name = "checkDivision"
        Me.checkDivision.Size = New System.Drawing.Size(63, 17)
        Me.checkDivision.TabIndex = 31
        Me.checkDivision.Text = "División"
        Me.checkDivision.UseVisualStyleBackColor = True
        '
        'checkMultiplicacion
        '
        Me.checkMultiplicacion.AutoSize = True
        Me.checkMultiplicacion.Location = New System.Drawing.Point(60, 193)
        Me.checkMultiplicacion.Name = "checkMultiplicacion"
        Me.checkMultiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.checkMultiplicacion.TabIndex = 30
        Me.checkMultiplicacion.Text = "Multiplicación"
        Me.checkMultiplicacion.UseVisualStyleBackColor = True
        '
        'checkResta
        '
        Me.checkResta.AutoSize = True
        Me.checkResta.Location = New System.Drawing.Point(59, 170)
        Me.checkResta.Name = "checkResta"
        Me.checkResta.Size = New System.Drawing.Size(54, 17)
        Me.checkResta.TabIndex = 29
        Me.checkResta.Text = "Resta"
        Me.checkResta.UseVisualStyleBackColor = True
        '
        'checkSuma
        '
        Me.checkSuma.AutoSize = True
        Me.checkSuma.Location = New System.Drawing.Point(60, 147)
        Me.checkSuma.Name = "checkSuma"
        Me.checkSuma.Size = New System.Drawing.Size(53, 17)
        Me.checkSuma.TabIndex = 28
        Me.checkSuma.Text = "Suma"
        Me.checkSuma.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Elija una opcion:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 393)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.checkRaiz)
        Me.Controls.Add(Me.checkPotencia)
        Me.Controls.Add(Me.checkDivision)
        Me.Controls.Add(Me.checkMultiplicacion)
        Me.Controls.Add(Me.checkResta)
        Me.Controls.Add(Me.checkSuma)
        Me.Name = "Form1"
        Me.Text = "Calculadora Matematica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents checkRaiz As CheckBox
    Friend WithEvents checkPotencia As CheckBox
    Friend WithEvents checkDivision As CheckBox
    Friend WithEvents checkMultiplicacion As CheckBox
    Friend WithEvents checkResta As CheckBox
    Friend WithEvents checkSuma As CheckBox
    Friend WithEvents Label4 As Label
End Class
