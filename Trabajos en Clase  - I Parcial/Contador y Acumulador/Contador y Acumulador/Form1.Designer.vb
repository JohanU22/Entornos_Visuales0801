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
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIndividual = New System.Windows.Forms.TextBox()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(72, 89)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 0
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(119, 190)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 1
        '
        'txtIndividual
        '
        Me.txtIndividual.Location = New System.Drawing.Point(119, 139)
        Me.txtIndividual.Name = "txtIndividual"
        Me.txtIndividual.Size = New System.Drawing.Size(100, 20)
        Me.txtIndividual.TabIndex = 2
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(101, 40)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtOrden.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(162, 89)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Precio Individual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 266)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.txtIndividual)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnSolicitar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIndividual As TextBox
    Friend WithEvents txtOrden As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
