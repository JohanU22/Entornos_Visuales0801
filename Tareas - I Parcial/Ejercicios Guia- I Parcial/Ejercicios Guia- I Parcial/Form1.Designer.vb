<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.btnCalculadora = New System.Windows.Forms.Button()
        Me.btnCuadratica = New System.Windows.Forms.Button()
        Me.btnAlmacen = New System.Windows.Forms.Button()
        Me.btnNumeros = New System.Windows.Forms.Button()
        Me.btnSalario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculadora
        '
        Me.btnCalculadora.BackColor = System.Drawing.Color.Orange
        Me.btnCalculadora.Font = New System.Drawing.Font("Century751 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculadora.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnCalculadora.Location = New System.Drawing.Point(53, 170)
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Size = New System.Drawing.Size(102, 45)
        Me.btnCalculadora.TabIndex = 0
        Me.btnCalculadora.Text = "Calculadora"
        Me.btnCalculadora.UseVisualStyleBackColor = False
        '
        'btnCuadratica
        '
        Me.btnCuadratica.BackColor = System.Drawing.Color.Gold
        Me.btnCuadratica.Font = New System.Drawing.Font("Century751 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuadratica.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnCuadratica.Location = New System.Drawing.Point(193, 167)
        Me.btnCuadratica.Name = "btnCuadratica"
        Me.btnCuadratica.Size = New System.Drawing.Size(101, 50)
        Me.btnCuadratica.TabIndex = 1
        Me.btnCuadratica.Text = "Formula Cuadratica"
        Me.btnCuadratica.UseVisualStyleBackColor = False
        '
        'btnAlmacen
        '
        Me.btnAlmacen.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAlmacen.Font = New System.Drawing.Font("Century751 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlmacen.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnAlmacen.Location = New System.Drawing.Point(315, 167)
        Me.btnAlmacen.Name = "btnAlmacen"
        Me.btnAlmacen.Size = New System.Drawing.Size(104, 50)
        Me.btnAlmacen.TabIndex = 2
        Me.btnAlmacen.Text = "Registro de Almacenes"
        Me.btnAlmacen.UseVisualStyleBackColor = False
        '
        'btnNumeros
        '
        Me.btnNumeros.BackColor = System.Drawing.Color.LawnGreen
        Me.btnNumeros.Font = New System.Drawing.Font("Century751 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumeros.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnNumeros.Location = New System.Drawing.Point(439, 170)
        Me.btnNumeros.Name = "btnNumeros"
        Me.btnNumeros.Size = New System.Drawing.Size(102, 47)
        Me.btnNumeros.TabIndex = 3
        Me.btnNumeros.Text = "Validar Numeros"
        Me.btnNumeros.UseVisualStyleBackColor = False
        '
        'btnSalario
        '
        Me.btnSalario.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnSalario.Font = New System.Drawing.Font("Century751 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalario.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnSalario.Location = New System.Drawing.Point(566, 167)
        Me.btnSalario.Name = "btnSalario"
        Me.btnSalario.Size = New System.Drawing.Size(93, 50)
        Me.btnSalario.TabIndex = 4
        Me.btnSalario.Text = "Calcular Salario"
        Me.btnSalario.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century751 BT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(209, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 35)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MENU PRINCIPAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century751 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(83, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Elija una opcion"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(587, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(689, 375)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalario)
        Me.Controls.Add(Me.btnNumeros)
        Me.Controls.Add(Me.btnAlmacen)
        Me.Controls.Add(Me.btnCuadratica)
        Me.Controls.Add(Me.btnCalculadora)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculadora As Button
    Friend WithEvents btnCuadratica As Button
    Friend WithEvents btnAlmacen As Button
    Friend WithEvents btnNumeros As Button
    Friend WithEvents btnSalario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
