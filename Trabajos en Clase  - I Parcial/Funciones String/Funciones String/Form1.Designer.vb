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
        Me.components = New System.ComponentModel.Container()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.txtCadena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.txtPrimero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUltimo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPosicion = New System.Windows.Forms.TextBox()
        Me.p = New System.Windows.Forms.Label()
        Me.txtMayusculas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMinusculas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBorrar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPosicionFija = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(123, 87)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 0
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'txtCadena
        '
        Me.txtCadena.Location = New System.Drawing.Point(86, 50)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(145, 20)
        Me.txtCadena.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Longitud"
        '
        'txtLongitud
        '
        Me.txtLongitud.Location = New System.Drawing.Point(114, 170)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(100, 20)
        Me.txtLongitud.TabIndex = 3
        '
        'txtPrimero
        '
        Me.txtPrimero.Location = New System.Drawing.Point(114, 206)
        Me.txtPrimero.Name = "txtPrimero"
        Me.txtPrimero.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimero.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Primer Valor"
        '
        'txtUltimo
        '
        Me.txtUltimo.Location = New System.Drawing.Point(114, 247)
        Me.txtUltimo.Name = "txtUltimo"
        Me.txtUltimo.Size = New System.Drawing.Size(100, 20)
        Me.txtUltimo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ultimo Valor"
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(114, 287)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(100, 20)
        Me.txtPosicion.TabIndex = 9
        '
        'p
        '
        Me.p.AutoSize = True
        Me.p.Location = New System.Drawing.Point(52, 290)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(47, 13)
        Me.p.TabIndex = 8
        Me.p.Text = "Posicion"
        '
        'txtMayusculas
        '
        Me.txtMayusculas.Location = New System.Drawing.Point(114, 329)
        Me.txtMayusculas.Name = "txtMayusculas"
        Me.txtMayusculas.Size = New System.Drawing.Size(100, 20)
        Me.txtMayusculas.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mayusculas"
        '
        'txtMinusculas
        '
        Me.txtMinusculas.Location = New System.Drawing.Point(114, 369)
        Me.txtMinusculas.Name = "txtMinusculas"
        Me.txtMinusculas.Size = New System.Drawing.Size(100, 20)
        Me.txtMinusculas.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Minusculas"
        '
        'txtBorrar
        '
        Me.txtBorrar.Location = New System.Drawing.Point(114, 410)
        Me.txtBorrar.Name = "txtBorrar"
        Me.txtBorrar.Size = New System.Drawing.Size(100, 20)
        Me.txtBorrar.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Borrar"
        '
        'txtPosicionFija
        '
        Me.txtPosicionFija.Location = New System.Drawing.Point(114, 457)
        Me.txtPosicionFija.Name = "txtPosicionFija"
        Me.txtPosicionFija.Size = New System.Drawing.Size(100, 20)
        Me.txtPosicionFija.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Posicion Fija"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 521)
        Me.Controls.Add(Me.txtPosicionFija)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBorrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMinusculas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMayusculas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPosicion)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.txtUltimo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrimero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.btnMostrar)
        Me.Name = "Form1"
        Me.Text = "Funciones String"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrar As Button
    Friend WithEvents txtCadena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLongitud As TextBox
    Friend WithEvents txtPrimero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUltimo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPosicion As TextBox
    Friend WithEvents p As Label
    Friend WithEvents txtMayusculas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMinusculas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBorrar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPosicionFija As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
