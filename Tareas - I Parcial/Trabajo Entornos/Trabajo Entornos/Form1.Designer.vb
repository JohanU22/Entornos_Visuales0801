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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtUnitario = New System.Windows.Forms.TextBox()
        Me.cmbDescuentos = New System.Windows.Forms.ComboBox()
        Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
        Me.chkInteres = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIsv = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtUnitario)
        Me.GroupBox1.Controls.Add(Me.cmbDescuentos)
        Me.GroupBox1.Controls.Add(Me.cmbImpuesto)
        Me.GroupBox1.Controls.Add(Me.chkInteres)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkDescuento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 322)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(121, 103)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(209, 21)
        Me.txtCantidad.TabIndex = 13
        '
        'txtUnitario
        '
        Me.txtUnitario.Location = New System.Drawing.Point(121, 54)
        Me.txtUnitario.Name = "txtUnitario"
        Me.txtUnitario.Size = New System.Drawing.Size(209, 21)
        Me.txtUnitario.TabIndex = 5
        '
        'cmbDescuentos
        '
        Me.cmbDescuentos.Enabled = False
        Me.cmbDescuentos.FormattingEnabled = True
        Me.cmbDescuentos.Items.AddRange(New Object() {"Descuento de Temporada", "Descuento de Cliente", "Descuento de Tercera Edad", "Descuento por Volumen o Rappel", "Descuento por pronto pago", "Descuento Comercial", "Ninguno"})
        Me.cmbDescuentos.Location = New System.Drawing.Point(184, 166)
        Me.cmbDescuentos.Name = "cmbDescuentos"
        Me.cmbDescuentos.Size = New System.Drawing.Size(198, 23)
        Me.cmbDescuentos.TabIndex = 12
        Me.cmbDescuentos.Text = "Ninguno"
        '
        'cmbImpuesto
        '
        Me.cmbImpuesto.DisplayMember = "des15"
        Me.cmbImpuesto.Enabled = False
        Me.cmbImpuesto.FormattingEnabled = True
        Me.cmbImpuesto.Items.AddRange(New Object() {"Impuesto 15%", "Impuesto 17%", "Ninguno"})
        Me.cmbImpuesto.Location = New System.Drawing.Point(184, 232)
        Me.cmbImpuesto.Name = "cmbImpuesto"
        Me.cmbImpuesto.Size = New System.Drawing.Size(198, 23)
        Me.cmbImpuesto.TabIndex = 5
        Me.cmbImpuesto.Text = "Ninguno"
        Me.cmbImpuesto.ValueMember = "des15"
        '
        'chkInteres
        '
        Me.chkInteres.AutoSize = True
        Me.chkInteres.Location = New System.Drawing.Point(68, 237)
        Me.chkInteres.Name = "chkInteres"
        Me.chkInteres.Size = New System.Drawing.Size(83, 19)
        Me.chkInteres.TabIndex = 6
        Me.chkInteres.Text = "Aplicar ISV"
        Me.chkInteres.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Cantidad"
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.Location = New System.Drawing.Point(44, 168)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(116, 19)
        Me.chkDescuento.TabIndex = 5
        Me.chkDescuento.Text = "Aplicar Descuento"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Precio Unitario"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtIsv)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(14, 359)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 235)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(103, 182)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(209, 21)
        Me.txtTotal.TabIndex = 17
        '
        'txtIsv
        '
        Me.txtIsv.Enabled = False
        Me.txtIsv.Location = New System.Drawing.Point(103, 136)
        Me.txtIsv.Name = "txtIsv"
        Me.txtIsv.Size = New System.Drawing.Size(209, 21)
        Me.txtIsv.TabIndex = 16
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(103, 93)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(209, 21)
        Me.txtDescuento.TabIndex = 15
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(103, 47)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(209, 21)
        Me.txtSubtotal.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(40, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(49, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ISV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(31, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(31, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Subtotal"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(478, 72)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(107, 33)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(478, 196)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 32)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Location = New System.Drawing.Point(478, 133)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(107, 32)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImage = Global.Trabajo_Entornos.My.Resources.Resources.fondo_oscuro_abstracto_1048_1920
        Me.ClientSize = New System.Drawing.Size(606, 612)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtUnitario As TextBox
    Friend WithEvents cmbDescuentos As ComboBox
    Friend WithEvents cmbImpuesto As ComboBox
    Friend WithEvents chkInteres As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIsv As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
End Class
