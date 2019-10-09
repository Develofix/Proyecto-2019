<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgendar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendar))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlPropiedad = New System.Windows.Forms.Panel()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.CbxHora = New System.Windows.Forms.ComboBox()
        Me.DTPFechaVisita = New System.Windows.Forms.DateTimePicker()
        Me.TxtEmpleado = New System.Windows.Forms.Label()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.CbxEmpleado = New System.Windows.Forms.ComboBox()
        Me.LblFechaVisita = New System.Windows.Forms.Label()
        Me.LblHoraVisita = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnRegistrarse = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnAgendarse = New System.Windows.Forms.Button()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtBaños = New System.Windows.Forms.TextBox()
        Me.TxtGarage = New System.Windows.Forms.TextBox()
        Me.PbxBaños = New System.Windows.Forms.PictureBox()
        Me.PbxHabitaciones = New System.Windows.Forms.PictureBox()
        Me.PbxGaraje = New System.Windows.Forms.PictureBox()
        Me.LblDepartamento = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.LblCondicion = New System.Windows.Forms.Label()
        Me.LblBarrio = New System.Windows.Forms.Label()
        Me.LblAntiguedad = New System.Windows.Forms.Label()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.LblSuperficieCubierta = New System.Windows.Forms.Label()
        Me.LblTerreno = New System.Windows.Forms.Label()
        Me.TxtBarrio = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCuartos = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.TxtAntiguedad = New System.Windows.Forms.TextBox()
        Me.TxtTerrenoCubierto = New System.Windows.Forms.TextBox()
        Me.TxtTerreno = New System.Windows.Forms.TextBox()
        Me.TxtCondicion = New System.Windows.Forms.TextBox()
        Me.PbxImage = New System.Windows.Forms.PictureBox()
        Me.PnlPropiedad.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        CType(Me.PbxBaños, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxGaraje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 24
        '
        'PnlPropiedad
        '
        Me.PnlPropiedad.BackColor = System.Drawing.Color.Azure
        Me.PnlPropiedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPropiedad.Controls.Add(Me.GbxDatos)
        Me.PnlPropiedad.Controls.Add(Me.Button1)
        Me.PnlPropiedad.Controls.Add(Me.BtnRegistrarse)
        Me.PnlPropiedad.Controls.Add(Me.LblNombre)
        Me.PnlPropiedad.Controls.Add(Me.LblID)
        Me.PnlPropiedad.Controls.Add(Me.TxtDescripcion)
        Me.PnlPropiedad.Controls.Add(Me.BtnVolver)
        Me.PnlPropiedad.Controls.Add(Me.BtnAgendarse)
        Me.PnlPropiedad.Controls.Add(Me.TxtEstado)
        Me.PnlPropiedad.Controls.Add(Me.TxtBaños)
        Me.PnlPropiedad.Controls.Add(Me.TxtGarage)
        Me.PnlPropiedad.Controls.Add(Me.PbxBaños)
        Me.PnlPropiedad.Controls.Add(Me.PbxHabitaciones)
        Me.PnlPropiedad.Controls.Add(Me.PbxGaraje)
        Me.PnlPropiedad.Controls.Add(Me.LblDepartamento)
        Me.PnlPropiedad.Controls.Add(Me.TxtPrecio)
        Me.PnlPropiedad.Controls.Add(Me.LblCondicion)
        Me.PnlPropiedad.Controls.Add(Me.LblBarrio)
        Me.PnlPropiedad.Controls.Add(Me.LblAntiguedad)
        Me.PnlPropiedad.Controls.Add(Me.LblCiudad)
        Me.PnlPropiedad.Controls.Add(Me.LblSuperficieCubierta)
        Me.PnlPropiedad.Controls.Add(Me.LblTerreno)
        Me.PnlPropiedad.Controls.Add(Me.TxtBarrio)
        Me.PnlPropiedad.Controls.Add(Me.TxtCiudad)
        Me.PnlPropiedad.Controls.Add(Me.TxtNombre)
        Me.PnlPropiedad.Controls.Add(Me.TxtCuartos)
        Me.PnlPropiedad.Controls.Add(Me.TxtID)
        Me.PnlPropiedad.Controls.Add(Me.TxtTipo)
        Me.PnlPropiedad.Controls.Add(Me.TxtDepartamento)
        Me.PnlPropiedad.Controls.Add(Me.TxtAntiguedad)
        Me.PnlPropiedad.Controls.Add(Me.TxtTerrenoCubierto)
        Me.PnlPropiedad.Controls.Add(Me.TxtTerreno)
        Me.PnlPropiedad.Controls.Add(Me.TxtCondicion)
        Me.PnlPropiedad.Controls.Add(Me.PbxImage)
        Me.PnlPropiedad.Location = New System.Drawing.Point(12, 36)
        Me.PnlPropiedad.Name = "PnlPropiedad"
        Me.PnlPropiedad.Size = New System.Drawing.Size(960, 613)
        Me.PnlPropiedad.TabIndex = 36
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.CbxHora)
        Me.GbxDatos.Controls.Add(Me.DTPFechaVisita)
        Me.GbxDatos.Controls.Add(Me.TxtEmpleado)
        Me.GbxDatos.Controls.Add(Me.BtnConfirmar)
        Me.GbxDatos.Controls.Add(Me.CbxEmpleado)
        Me.GbxDatos.Controls.Add(Me.LblFechaVisita)
        Me.GbxDatos.Controls.Add(Me.LblHoraVisita)
        Me.GbxDatos.Location = New System.Drawing.Point(641, 422)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(300, 176)
        Me.GbxDatos.TabIndex = 69
        Me.GbxDatos.TabStop = False
        Me.GbxDatos.Text = "Datos de la visita"
        Me.GbxDatos.Visible = False
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
        Me.CbxHora.Location = New System.Drawing.Point(161, 45)
        Me.CbxHora.Name = "CbxHora"
        Me.CbxHora.Size = New System.Drawing.Size(108, 28)
        Me.CbxHora.TabIndex = 64
        '
        'DTPFechaVisita
        '
        Me.DTPFechaVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.DTPFechaVisita.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaVisita.Location = New System.Drawing.Point(11, 47)
        Me.DTPFechaVisita.Name = "DTPFechaVisita"
        Me.DTPFechaVisita.Size = New System.Drawing.Size(126, 27)
        Me.DTPFechaVisita.TabIndex = 72
        Me.DTPFechaVisita.Value = New Date(2019, 10, 5, 20, 53, 44, 0)
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.AutoSize = True
        Me.TxtEmpleado.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpleado.Location = New System.Drawing.Point(11, 80)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.Size = New System.Drawing.Size(200, 25)
        Me.TxtEmpleado.TabIndex = 71
        Me.TxtEmpleado.Text = "Empleado Encargado"
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.BackColor = System.Drawing.Color.Transparent
        Me.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnConfirmar.FlatAppearance.BorderSize = 0
        Me.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Location = New System.Drawing.Point(209, 146)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(84, 25)
        Me.BtnConfirmar.TabIndex = 69
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConfirmar.UseVisualStyleBackColor = False
        '
        'CbxEmpleado
        '
        Me.CbxEmpleado.BackColor = System.Drawing.Color.Azure
        Me.CbxEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxEmpleado.ForeColor = System.Drawing.Color.Black
        Me.CbxEmpleado.FormattingEnabled = True
        Me.CbxEmpleado.Location = New System.Drawing.Point(11, 111)
        Me.CbxEmpleado.Name = "CbxEmpleado"
        Me.CbxEmpleado.Size = New System.Drawing.Size(258, 28)
        Me.CbxEmpleado.TabIndex = 70
        Me.CbxEmpleado.Visible = False
        '
        'LblFechaVisita
        '
        Me.LblFechaVisita.AutoSize = True
        Me.LblFechaVisita.BackColor = System.Drawing.Color.Gainsboro
        Me.LblFechaVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaVisita.Location = New System.Drawing.Point(11, 17)
        Me.LblFechaVisita.Name = "LblFechaVisita"
        Me.LblFechaVisita.Size = New System.Drawing.Size(67, 25)
        Me.LblFechaVisita.TabIndex = 67
        Me.LblFechaVisita.Text = "Fecha"
        '
        'LblHoraVisita
        '
        Me.LblHoraVisita.AutoSize = True
        Me.LblHoraVisita.BackColor = System.Drawing.Color.Gainsboro
        Me.LblHoraVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHoraVisita.Location = New System.Drawing.Point(161, 17)
        Me.LblHoraVisita.Name = "LblHoraVisita"
        Me.LblHoraVisita.Size = New System.Drawing.Size(54, 25)
        Me.LblHoraVisita.TabIndex = 68
        Me.LblHoraVisita.Text = "Hora"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(902, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = ">"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnRegistrarse
        '
        Me.BtnRegistrarse.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnRegistrarse.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.BtnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarse.Location = New System.Drawing.Point(645, 279)
        Me.BtnRegistrarse.Name = "BtnRegistrarse"
        Me.BtnRegistrarse.Size = New System.Drawing.Size(35, 35)
        Me.BtnRegistrarse.TabIndex = 61
        Me.BtnRegistrarse.Text = "<"
        Me.BtnRegistrarse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegistrarse.UseVisualStyleBackColor = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Gainsboro
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(13, 16)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(87, 25)
        Me.LblNombre.TabIndex = 60
        Me.LblNombre.Text = "Nombre"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.BackColor = System.Drawing.Color.Gainsboro
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(453, 16)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(33, 25)
        Me.LblID.TabIndex = 59
        Me.LblID.Text = "ID"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(158, 56)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(464, 180)
        Me.TxtDescripcion.TabIndex = 0
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnVolver.FlatAppearance.BorderSize = 0
        Me.BtnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnVolver.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnVolver.Location = New System.Drawing.Point(18, 544)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(167, 45)
        Me.BtnVolver.TabIndex = 58
        Me.BtnVolver.Tag = "btnchico"
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnAgendarse
        '
        Me.BtnAgendarse.BackColor = System.Drawing.Color.Transparent
        Me.BtnAgendarse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgendarse.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnAgendarse.FlatAppearance.BorderSize = 0
        Me.BtnAgendarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnAgendarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnAgendarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgendarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgendarse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAgendarse.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnAgendarse.Location = New System.Drawing.Point(458, 544)
        Me.BtnAgendarse.Name = "BtnAgendarse"
        Me.BtnAgendarse.Size = New System.Drawing.Size(167, 45)
        Me.BtnAgendarse.TabIndex = 57
        Me.BtnAgendarse.Tag = "btnchico"
        Me.BtnAgendarse.Text = "Agendarse"
        Me.BtnAgendarse.UseVisualStyleBackColor = False
        '
        'TxtEstado
        '
        Me.TxtEstado.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEstado.Enabled = False
        Me.TxtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstado.Location = New System.Drawing.Point(641, 393)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(300, 23)
        Me.TxtEstado.TabIndex = 56
        Me.TxtEstado.Text = "Estado"
        Me.TxtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBaños
        '
        Me.TxtBaños.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBaños.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBaños.Enabled = False
        Me.TxtBaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBaños.Location = New System.Drawing.Point(75, 122)
        Me.TxtBaños.Multiline = True
        Me.TxtBaños.Name = "TxtBaños"
        Me.TxtBaños.Size = New System.Drawing.Size(67, 50)
        Me.TxtBaños.TabIndex = 55
        Me.TxtBaños.Text = "1"
        Me.TxtBaños.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtGarage
        '
        Me.TxtGarage.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtGarage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtGarage.Enabled = False
        Me.TxtGarage.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGarage.Location = New System.Drawing.Point(75, 189)
        Me.TxtGarage.Multiline = True
        Me.TxtGarage.Name = "TxtGarage"
        Me.TxtGarage.Size = New System.Drawing.Size(67, 50)
        Me.TxtGarage.TabIndex = 54
        Me.TxtGarage.Text = "1"
        Me.TxtGarage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PbxBaños
        '
        Me.PbxBaños.BackColor = System.Drawing.Color.Gainsboro
        Me.PbxBaños.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.Baño
        Me.PbxBaños.Location = New System.Drawing.Point(19, 122)
        Me.PbxBaños.Name = "PbxBaños"
        Me.PbxBaños.Size = New System.Drawing.Size(50, 50)
        Me.PbxBaños.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxBaños.TabIndex = 53
        Me.PbxBaños.TabStop = False
        '
        'PbxHabitaciones
        '
        Me.PbxHabitaciones.BackColor = System.Drawing.Color.Gainsboro
        Me.PbxHabitaciones.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.Cama
        Me.PbxHabitaciones.Location = New System.Drawing.Point(19, 56)
        Me.PbxHabitaciones.Name = "PbxHabitaciones"
        Me.PbxHabitaciones.Size = New System.Drawing.Size(50, 50)
        Me.PbxHabitaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxHabitaciones.TabIndex = 52
        Me.PbxHabitaciones.TabStop = False
        '
        'PbxGaraje
        '
        Me.PbxGaraje.BackColor = System.Drawing.Color.Gainsboro
        Me.PbxGaraje.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.Garage
        Me.PbxGaraje.Location = New System.Drawing.Point(19, 189)
        Me.PbxGaraje.Name = "PbxGaraje"
        Me.PbxGaraje.Size = New System.Drawing.Size(50, 50)
        Me.PbxGaraje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxGaraje.TabIndex = 51
        Me.PbxGaraje.TabStop = False
        '
        'LblDepartamento
        '
        Me.LblDepartamento.AutoSize = True
        Me.LblDepartamento.BackColor = System.Drawing.Color.Gainsboro
        Me.LblDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepartamento.Location = New System.Drawing.Point(25, 275)
        Me.LblDepartamento.Name = "LblDepartamento"
        Me.LblDepartamento.Size = New System.Drawing.Size(127, 20)
        Me.LblDepartamento.TabIndex = 48
        Me.LblDepartamento.Text = "Departamento"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(641, 326)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(300, 30)
        Me.TxtPrecio.TabIndex = 46
        Me.TxtPrecio.Text = "Precio"
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblCondicion
        '
        Me.LblCondicion.AutoSize = True
        Me.LblCondicion.BackColor = System.Drawing.Color.Gainsboro
        Me.LblCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCondicion.Location = New System.Drawing.Point(25, 505)
        Me.LblCondicion.Name = "LblCondicion"
        Me.LblCondicion.Size = New System.Drawing.Size(92, 20)
        Me.LblCondicion.TabIndex = 31
        Me.LblCondicion.Text = "Condición"
        '
        'LblBarrio
        '
        Me.LblBarrio.AutoSize = True
        Me.LblBarrio.BackColor = System.Drawing.Color.Gainsboro
        Me.LblBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarrio.Location = New System.Drawing.Point(25, 339)
        Me.LblBarrio.Name = "LblBarrio"
        Me.LblBarrio.Size = New System.Drawing.Size(61, 20)
        Me.LblBarrio.TabIndex = 26
        Me.LblBarrio.Text = "Barrio"
        '
        'LblAntiguedad
        '
        Me.LblAntiguedad.AutoSize = True
        Me.LblAntiguedad.BackColor = System.Drawing.Color.Gainsboro
        Me.LblAntiguedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAntiguedad.Location = New System.Drawing.Point(25, 472)
        Me.LblAntiguedad.Name = "LblAntiguedad"
        Me.LblAntiguedad.Size = New System.Drawing.Size(164, 20)
        Me.LblAntiguedad.TabIndex = 30
        Me.LblAntiguedad.Text = "Antigüedad (Años)"
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.BackColor = System.Drawing.Color.Gainsboro
        Me.LblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.Location = New System.Drawing.Point(25, 306)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(67, 20)
        Me.LblCiudad.TabIndex = 21
        Me.LblCiudad.Text = "Ciudad"
        '
        'LblSuperficieCubierta
        '
        Me.LblSuperficieCubierta.AutoSize = True
        Me.LblSuperficieCubierta.BackColor = System.Drawing.Color.Gainsboro
        Me.LblSuperficieCubierta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSuperficieCubierta.Location = New System.Drawing.Point(25, 421)
        Me.LblSuperficieCubierta.Name = "LblSuperficieCubierta"
        Me.LblSuperficieCubierta.Size = New System.Drawing.Size(213, 20)
        Me.LblSuperficieCubierta.TabIndex = 27
        Me.LblSuperficieCubierta.Text = "Superficie Cubierta (m²)"
        '
        'LblTerreno
        '
        Me.LblTerreno.AutoSize = True
        Me.LblTerreno.BackColor = System.Drawing.Color.Gainsboro
        Me.LblTerreno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTerreno.Location = New System.Drawing.Point(25, 390)
        Me.LblTerreno.Name = "LblTerreno"
        Me.LblTerreno.Size = New System.Drawing.Size(116, 20)
        Me.LblTerreno.TabIndex = 28
        Me.LblTerreno.Text = "Terreno (m²)"
        '
        'TxtBarrio
        '
        Me.TxtBarrio.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBarrio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBarrio.Enabled = False
        Me.TxtBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarrio.Location = New System.Drawing.Point(92, 339)
        Me.TxtBarrio.Name = "TxtBarrio"
        Me.TxtBarrio.Size = New System.Drawing.Size(530, 20)
        Me.TxtBarrio.TabIndex = 50
        '
        'TxtCiudad
        '
        Me.TxtCiudad.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCiudad.Enabled = False
        Me.TxtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.Location = New System.Drawing.Point(98, 306)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(524, 20)
        Me.TxtCiudad.TabIndex = 49
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(106, 17)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(333, 23)
        Me.TxtNombre.TabIndex = 45
        '
        'TxtCuartos
        '
        Me.TxtCuartos.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCuartos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCuartos.Enabled = False
        Me.TxtCuartos.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuartos.Location = New System.Drawing.Point(75, 56)
        Me.TxtCuartos.Multiline = True
        Me.TxtCuartos.Name = "TxtCuartos"
        Me.TxtCuartos.Size = New System.Drawing.Size(67, 50)
        Me.TxtCuartos.TabIndex = 43
        Me.TxtCuartos.Text = "1"
        Me.TxtCuartos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtID
        '
        Me.TxtID.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtID.Enabled = False
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.Location = New System.Drawing.Point(492, 17)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(130, 23)
        Me.TxtID.TabIndex = 42
        '
        'TxtTipo
        '
        Me.TxtTipo.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTipo.Enabled = False
        Me.TxtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipo.Location = New System.Drawing.Point(641, 363)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(300, 23)
        Me.TxtTipo.TabIndex = 40
        Me.TxtTipo.Text = "Tipo"
        Me.TxtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDepartamento.Enabled = False
        Me.TxtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepartamento.Location = New System.Drawing.Point(158, 275)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(464, 20)
        Me.TxtDepartamento.TabIndex = 39
        '
        'TxtAntiguedad
        '
        Me.TxtAntiguedad.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtAntiguedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAntiguedad.Enabled = False
        Me.TxtAntiguedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAntiguedad.Location = New System.Drawing.Point(195, 472)
        Me.TxtAntiguedad.Name = "TxtAntiguedad"
        Me.TxtAntiguedad.Size = New System.Drawing.Size(427, 20)
        Me.TxtAntiguedad.TabIndex = 38
        '
        'TxtTerrenoCubierto
        '
        Me.TxtTerrenoCubierto.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtTerrenoCubierto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTerrenoCubierto.Enabled = False
        Me.TxtTerrenoCubierto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTerrenoCubierto.Location = New System.Drawing.Point(249, 421)
        Me.TxtTerrenoCubierto.Name = "TxtTerrenoCubierto"
        Me.TxtTerrenoCubierto.Size = New System.Drawing.Size(373, 20)
        Me.TxtTerrenoCubierto.TabIndex = 37
        '
        'TxtTerreno
        '
        Me.TxtTerreno.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtTerreno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTerreno.Enabled = False
        Me.TxtTerreno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTerreno.Location = New System.Drawing.Point(147, 390)
        Me.TxtTerreno.Name = "TxtTerreno"
        Me.TxtTerreno.Size = New System.Drawing.Size(475, 20)
        Me.TxtTerreno.TabIndex = 36
        '
        'TxtCondicion
        '
        Me.TxtCondicion.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCondicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCondicion.Enabled = False
        Me.TxtCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCondicion.Location = New System.Drawing.Point(123, 505)
        Me.TxtCondicion.Name = "TxtCondicion"
        Me.TxtCondicion.Size = New System.Drawing.Size(499, 20)
        Me.TxtCondicion.TabIndex = 35
        '
        'PbxImage
        '
        Me.PbxImage.Location = New System.Drawing.Point(641, 20)
        Me.PbxImage.Name = "PbxImage"
        Me.PbxImage.Size = New System.Drawing.Size(300, 300)
        Me.PbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxImage.TabIndex = 70
        Me.PbxImage.TabStop = False
        '
        'FrmAgendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Proyecto_Inmobiliaria.My.Resources.Resources.FondoTemaAzul
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PnlPropiedad)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propuru"
        Me.PnlPropiedad.ResumeLayout(False)
        Me.PnlPropiedad.PerformLayout()
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        CType(Me.PbxBaños, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxGaraje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PnlPropiedad As Panel
    Friend WithEvents GbxDatos As GroupBox
    Friend WithEvents CbxHora As ComboBox
    Friend WithEvents DTPFechaVisita As DateTimePicker
    Friend WithEvents TxtEmpleado As Label
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents CbxEmpleado As ComboBox
    Friend WithEvents LblFechaVisita As Label
    Friend WithEvents LblHoraVisita As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnRegistrarse As Button
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblID As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnAgendarse As Button
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents TxtBaños As TextBox
    Friend WithEvents TxtGarage As TextBox
    Friend WithEvents PbxBaños As PictureBox
    Friend WithEvents PbxHabitaciones As PictureBox
    Friend WithEvents PbxGaraje As PictureBox
    Friend WithEvents LblDepartamento As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents LblCondicion As Label
    Friend WithEvents LblBarrio As Label
    Friend WithEvents LblAntiguedad As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents LblSuperficieCubierta As Label
    Friend WithEvents LblTerreno As Label
    Friend WithEvents TxtBarrio As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCuartos As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents TxtAntiguedad As TextBox
    Friend WithEvents TxtTerrenoCubierto As TextBox
    Friend WithEvents TxtTerreno As TextBox
    Friend WithEvents TxtCondicion As TextBox
    Friend WithEvents PbxImage As PictureBox
End Class
