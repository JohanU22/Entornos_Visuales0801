<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOperaciones = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnAleatorio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Elija una opcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MENU PRINCIPAL"
        '
        'btnOperaciones
        '
        Me.btnOperaciones.BackColor = System.Drawing.Color.Gainsboro
        Me.btnOperaciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOperaciones.Location = New System.Drawing.Point(76, 108)
        Me.btnOperaciones.Name = "btnOperaciones"
        Me.btnOperaciones.Size = New System.Drawing.Size(153, 39)
        Me.btnOperaciones.TabIndex = 3
        Me.btnOperaciones.Text = "Operaciones Matematicas Basicas"
        Me.btnOperaciones.UseVisualStyleBackColor = False
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(98, 162)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(119, 25)
        Me.btnFactorial.TabIndex = 4
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnAleatorio
        '
        Me.btnAleatorio.Location = New System.Drawing.Point(76, 205)
        Me.btnAleatorio.Name = "btnAleatorio"
        Me.btnAleatorio.Size = New System.Drawing.Size(153, 36)
        Me.btnAleatorio.TabIndex = 5
        Me.btnAleatorio.Text = "Generar Numero Aleatorio"
        Me.btnAleatorio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(301, 308)
        Me.Controls.Add(Me.btnAleatorio)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnOperaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOperaciones As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnAleatorio As Button
End Class
