<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlmacen
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
        Me.cmbAlmacenes = New System.Windows.Forms.ComboBox()
        Me.btnElegir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstSobre = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lstBajo = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbAlmacenes
        '
        Me.cmbAlmacenes.FormattingEnabled = True
        Me.cmbAlmacenes.Items.AddRange(New Object() {"Almacen Dirgen", "Almacen Luna Llena", "Almacen Los Santos", "Almacen de Ceiba", "Almacen Nuevo Horizonte", "Almacen Bella Vista", "Almacen El Hoyo", "Almacen El Paso", "Almacen Nuevo Dia", "Almacen El Amanecer", "Ninguno"})
        Me.cmbAlmacenes.Location = New System.Drawing.Point(30, 65)
        Me.cmbAlmacenes.Name = "cmbAlmacenes"
        Me.cmbAlmacenes.Size = New System.Drawing.Size(121, 21)
        Me.cmbAlmacenes.TabIndex = 0
        Me.cmbAlmacenes.Text = "Ninguno"
        '
        'btnElegir
        '
        Me.btnElegir.Location = New System.Drawing.Point(57, 109)
        Me.btnElegir.Name = "btnElegir"
        Me.btnElegir.Size = New System.Drawing.Size(75, 23)
        Me.btnElegir.TabIndex = 1
        Me.btnElegir.Text = "Elegir"
        Me.btnElegir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbAlmacenes)
        Me.Panel1.Controls.Add(Me.btnElegir)
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 327)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Elija el Almacen a registrar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NewsGoth BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "REGISTRO DE VENTAS"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lstSobre)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(220, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 155)
        Me.Panel2.TabIndex = 6
        '
        'lstSobre
        '
        Me.lstSobre.FormattingEnabled = True
        Me.lstSobre.Location = New System.Drawing.Point(3, 36)
        Me.lstSobre.Name = "lstSobre"
        Me.lstSobre.Size = New System.Drawing.Size(213, 108)
        Me.lstSobre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ventas Superiores a la Media"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lstBajo)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(218, 195)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 166)
        Me.Panel3.TabIndex = 7
        '
        'lstBajo
        '
        Me.lstBajo.FormattingEnabled = True
        Me.lstBajo.Location = New System.Drawing.Point(3, 37)
        Me.lstBajo.Name = "lstBajo"
        Me.lstBajo.Size = New System.Drawing.Size(213, 121)
        Me.lstBajo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ventas Inferiores a la Media"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Regresar Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 410)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAlmacen"
        Me.Text = "Registro de Almacenes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAlmacenes As ComboBox
    Friend WithEvents btnElegir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstSobre As ListBox
    Friend WithEvents lstBajo As ListBox
    Friend WithEvents Button1 As Button
End Class
