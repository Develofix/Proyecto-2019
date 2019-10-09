<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarAgenda
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblDiasDisponibles = New System.Windows.Forms.Label()
        Me.DTPFechaNueva = New System.Windows.Forms.DateTimePicker()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.CbxHora = New System.Windows.Forms.ComboBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblFechaOriginal = New System.Windows.Forms.Label()
        Me.LblFechaOrigen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.Azure
        Me.BtnSalir.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnSalir.Location = New System.Drawing.Point(12, 278)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(171, 52)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Tag = "btnchico"
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Azure
        Me.BtnModificar.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnModificar.Location = New System.Drawing.Point(427, 278)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(162, 52)
        Me.BtnModificar.TabIndex = 6
        Me.BtnModificar.Tag = "btnchico"
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(465, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Dias Disponibles"
        '
        'LblDiasDisponibles
        '
        Me.LblDiasDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDiasDisponibles.Location = New System.Drawing.Point(147, 110)
        Me.LblDiasDisponibles.Name = "LblDiasDisponibles"
        Me.LblDiasDisponibles.Size = New System.Drawing.Size(299, 31)
        Me.LblDiasDisponibles.TabIndex = 77
        Me.LblDiasDisponibles.Text = "Label1"
        '
        'DTPFechaNueva
        '
        Me.DTPFechaNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.DTPFechaNueva.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaNueva.Location = New System.Drawing.Point(146, 166)
        Me.DTPFechaNueva.Name = "DTPFechaNueva"
        Me.DTPFechaNueva.Size = New System.Drawing.Size(300, 27)
        Me.DTPFechaNueva.TabIndex = 76
        Me.DTPFechaNueva.Value = New Date(2019, 10, 5, 20, 53, 44, 0)
        '
        'LblHora
        '
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.Location = New System.Drawing.Point(466, 230)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(39, 18)
        Me.LblHora.TabIndex = 75
        Me.LblHora.Text = "Hora"
        '
        'CbxHora
        '
        Me.CbxHora.BackColor = System.Drawing.Color.Azure
        Me.CbxHora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxHora.ForeColor = System.Drawing.Color.Black
        Me.CbxHora.FormattingEnabled = True
        Me.CbxHora.Items.AddRange(New Object() {"Sin especificar"})
        Me.CbxHora.Location = New System.Drawing.Point(146, 220)
        Me.CbxHora.Name = "CbxHora"
        Me.CbxHora.Size = New System.Drawing.Size(300, 28)
        Me.CbxHora.TabIndex = 74
        '
        'LblFecha
        '
        Me.LblFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblFecha.Location = New System.Drawing.Point(465, 173)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(46, 18)
        Me.LblFecha.TabIndex = 73
        Me.LblFecha.Text = "Fecha"
        '
        'LblFechaOriginal
        '
        Me.LblFechaOriginal.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaOriginal.Location = New System.Drawing.Point(287, 39)
        Me.LblFechaOriginal.Name = "LblFechaOriginal"
        Me.LblFechaOriginal.Size = New System.Drawing.Size(76, 18)
        Me.LblFechaOriginal.TabIndex = 72
        Me.LblFechaOriginal.Text = "Fecha Original"
        '
        'LblFechaOrigen
        '
        Me.LblFechaOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFechaOrigen.Location = New System.Drawing.Point(147, 57)
        Me.LblFechaOrigen.Name = "LblFechaOrigen"
        Me.LblFechaOrigen.Size = New System.Drawing.Size(357, 35)
        Me.LblFechaOrigen.TabIndex = 71
        Me.LblFechaOrigen.Text = "Label1"
        '
        'FrmModificarAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Inmobiliaria.My.Resources.Resources.FondoTemaAzul
        Me.ClientSize = New System.Drawing.Size(610, 355)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblDiasDisponibles)
        Me.Controls.Add(Me.DTPFechaNueva)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.CbxHora)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblFechaOriginal)
        Me.Controls.Add(Me.LblFechaOrigen)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModificarAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModificarAgenda"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LblDiasDisponibles As Label
    Friend WithEvents DTPFechaNueva As DateTimePicker
    Friend WithEvents LblHora As Label
    Friend WithEvents CbxHora As ComboBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblFechaOriginal As Label
    Friend WithEvents LblFechaOrigen As Label
End Class
