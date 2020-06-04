<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Num_Aleatorio
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
        Me.btnNumero = New System.Windows.Forms.Button()
        Me.txtNumAleatorio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMinim = New System.Windows.Forms.MaskedTextBox()
        Me.txtMaxim = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNumero
        '
        Me.btnNumero.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNumero.Location = New System.Drawing.Point(103, 157)
        Me.btnNumero.Name = "btnNumero"
        Me.btnNumero.Size = New System.Drawing.Size(75, 37)
        Me.btnNumero.TabIndex = 0
        Me.btnNumero.Text = "Generar Numero"
        Me.btnNumero.UseVisualStyleBackColor = False
        '
        'txtNumAleatorio
        '
        Me.txtNumAleatorio.Location = New System.Drawing.Point(128, 221)
        Me.txtNumAleatorio.Name = "txtNumAleatorio"
        Me.txtNumAleatorio.Size = New System.Drawing.Size(100, 20)
        Me.txtNumAleatorio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero Aleatorio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rango de Numeros"
        '
        'txtMinim
        '
        Me.txtMinim.Location = New System.Drawing.Point(131, 64)
        Me.txtMinim.Mask = "99999"
        Me.txtMinim.Name = "txtMinim"
        Me.txtMinim.Size = New System.Drawing.Size(42, 20)
        Me.txtMinim.TabIndex = 4
        Me.txtMinim.ValidatingType = GetType(Integer)
        '
        'txtMaxim
        '
        Me.txtMaxim.Location = New System.Drawing.Point(131, 101)
        Me.txtMaxim.Mask = "99999"
        Me.txtMaxim.Name = "txtMaxim"
        Me.txtMaxim.Size = New System.Drawing.Size(42, 20)
        Me.txtMaxim.TabIndex = 5
        Me.txtMaxim.ValidatingType = GetType(Integer)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valor Minimo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Valor Maximo"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Location = New System.Drawing.Point(118, 297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "S&alir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevo.Location = New System.Drawing.Point(209, 297)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nu&evo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Num_Aleatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(296, 332)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaxim)
        Me.Controls.Add(Me.txtMinim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumAleatorio)
        Me.Controls.Add(Me.btnNumero)
        Me.Name = "Num_Aleatorio"
        Me.Text = "Numero Aleatorio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNumero As Button
    Friend WithEvents txtNumAleatorio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMinim As MaskedTextBox
    Friend WithEvents txtMaxim As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
End Class
