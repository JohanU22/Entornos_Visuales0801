<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCalculadora
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
        Dim TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnSigno = New System.Windows.Forms.Button()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window
        TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.Controls.Add(Me.btn0, 0, 4)
        TableLayoutPanel1.Controls.Add(Me.btnSigno, 1, 4)
        TableLayoutPanel1.Controls.Add(Me.btnPunto, 2, 4)
        TableLayoutPanel1.Controls.Add(Me.btnMas, 3, 4)
        TableLayoutPanel1.Controls.Add(Me.btn1, 0, 3)
        TableLayoutPanel1.Controls.Add(Me.btn2, 1, 3)
        TableLayoutPanel1.Controls.Add(Me.btn3, 2, 3)
        TableLayoutPanel1.Controls.Add(Me.btnMenos, 3, 3)
        TableLayoutPanel1.Controls.Add(Me.btnIgual, 4, 3)
        TableLayoutPanel1.Controls.Add(Me.btn4, 0, 2)
        TableLayoutPanel1.Controls.Add(Me.btn5, 1, 2)
        TableLayoutPanel1.Controls.Add(Me.btn6, 2, 2)
        TableLayoutPanel1.Controls.Add(Me.btnMultiplicar, 3, 2)
        TableLayoutPanel1.Controls.Add(Me.txtResultado, 0, 0)
        TableLayoutPanel1.Controls.Add(Me.btn7, 0, 1)
        TableLayoutPanel1.Controls.Add(Me.btn8, 1, 1)
        TableLayoutPanel1.Controls.Add(Me.btn9, 2, 1)
        TableLayoutPanel1.Controls.Add(Me.btnDiv, 3, 1)
        TableLayoutPanel1.Controls.Add(Me.btnLimpiar, 4, 1)
        TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        TableLayoutPanel1.Size = New System.Drawing.Size(291, 321)
        TableLayoutPanel1.TabIndex = 0
        AddHandler TableLayoutPanel1.Paint, AddressOf Me.TableLayoutPanel1_Paint
        '
        'btn0
        '
        Me.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.Black
        Me.btn0.Location = New System.Drawing.Point(5, 261)
        Me.btn0.Margin = New System.Windows.Forms.Padding(5)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(48, 55)
        Me.btn0.TabIndex = 16
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnSigno
        '
        Me.btnSigno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSigno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSigno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSigno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigno.ForeColor = System.Drawing.Color.Black
        Me.btnSigno.Location = New System.Drawing.Point(63, 261)
        Me.btnSigno.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSigno.Name = "btnSigno"
        Me.btnSigno.Size = New System.Drawing.Size(48, 55)
        Me.btnSigno.TabIndex = 17
        Me.btnSigno.Text = "+ / -"
        Me.btnSigno.UseVisualStyleBackColor = True
        '
        'btnPunto
        '
        Me.btnPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPunto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunto.ForeColor = System.Drawing.Color.Black
        Me.btnPunto.Location = New System.Drawing.Point(121, 261)
        Me.btnPunto.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(48, 55)
        Me.btnPunto.TabIndex = 18
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = True
        '
        'btnMas
        '
        Me.btnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMas.ForeColor = System.Drawing.Color.Black
        Me.btnMas.Location = New System.Drawing.Point(179, 261)
        Me.btnMas.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(48, 55)
        Me.btnMas.TabIndex = 19
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Black
        Me.btn1.Location = New System.Drawing.Point(5, 197)
        Me.btn1.Margin = New System.Windows.Forms.Padding(5)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(48, 54)
        Me.btn1.TabIndex = 11
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Black
        Me.btn2.Location = New System.Drawing.Point(63, 197)
        Me.btn2.Margin = New System.Windows.Forms.Padding(5)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(48, 54)
        Me.btn2.TabIndex = 12
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.Black
        Me.btn3.Location = New System.Drawing.Point(121, 197)
        Me.btn3.Margin = New System.Windows.Forms.Padding(5)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(48, 54)
        Me.btn3.TabIndex = 13
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btnMenos
        '
        Me.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenos.ForeColor = System.Drawing.Color.Black
        Me.btnMenos.Location = New System.Drawing.Point(179, 197)
        Me.btnMenos.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(48, 54)
        Me.btnMenos.TabIndex = 14
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIgual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.ForeColor = System.Drawing.Color.Black
        Me.btnIgual.Location = New System.Drawing.Point(237, 197)
        Me.btnIgual.Margin = New System.Windows.Forms.Padding(5)
        Me.btnIgual.Name = "btnIgual"
        TableLayoutPanel1.SetRowSpan(Me.btnIgual, 2)
        Me.btnIgual.Size = New System.Drawing.Size(49, 119)
        Me.btnIgual.TabIndex = 15
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.Black
        Me.btn4.Location = New System.Drawing.Point(5, 133)
        Me.btn4.Margin = New System.Windows.Forms.Padding(5)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(48, 54)
        Me.btn4.TabIndex = 6
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.Black
        Me.btn5.Location = New System.Drawing.Point(63, 133)
        Me.btn5.Margin = New System.Windows.Forms.Padding(5)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(48, 54)
        Me.btn5.TabIndex = 7
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.Black
        Me.btn6.Location = New System.Drawing.Point(121, 133)
        Me.btn6.Margin = New System.Windows.Forms.Padding(5)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(48, 54)
        Me.btn6.TabIndex = 8
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMultiplicar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.ForeColor = System.Drawing.Color.Black
        Me.btnMultiplicar.Location = New System.Drawing.Point(179, 133)
        Me.btnMultiplicar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(48, 54)
        Me.btnMultiplicar.TabIndex = 9
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TableLayoutPanel1.SetColumnSpan(Me.txtResultado, 5)
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(3, 17)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(285, 29)
        Me.txtResultado.TabIndex = 0
        Me.txtResultado.Text = "0"
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn7
        '
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.Black
        Me.btn7.Location = New System.Drawing.Point(5, 69)
        Me.btn7.Margin = New System.Windows.Forms.Padding(5)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(48, 54)
        Me.btn7.TabIndex = 1
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.Black
        Me.btn8.Location = New System.Drawing.Point(63, 69)
        Me.btn8.Margin = New System.Windows.Forms.Padding(5)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(48, 54)
        Me.btn8.TabIndex = 2
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.Black
        Me.btn9.Location = New System.Drawing.Point(121, 69)
        Me.btn9.Margin = New System.Windows.Forms.Padding(5)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(48, 54)
        Me.btn9.TabIndex = 3
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDiv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.ForeColor = System.Drawing.Color.Black
        Me.btnDiv.Location = New System.Drawing.Point(179, 69)
        Me.btnDiv.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(48, 54)
        Me.btnDiv.TabIndex = 4
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(237, 69)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLimpiar.Name = "btnLimpiar"
        TableLayoutPanel1.SetRowSpan(Me.btnLimpiar, 2)
        Me.btnLimpiar.Size = New System.Drawing.Size(49, 118)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Borrar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 20)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(444, 321)
        Me.SplitContainer1.SplitterDistance = 291
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(35, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Historial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 23)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(143, 298)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Historial"
        '
        'FormCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormCalculadora"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.Text = "Calculadora"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btn0 As Button
    Friend WithEvents btnSigno As Button
    Friend WithEvents btnPunto As Button
    Friend WithEvents btnMas As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label1 As Label
End Class
