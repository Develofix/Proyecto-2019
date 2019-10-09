<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.OFDExcel = New System.Windows.Forms.OpenFileDialog()
        Me.TabCAdmins = New System.Windows.Forms.TabControl()
        Me.TabPConsultas = New System.Windows.Forms.TabPage()
        Me.BtnRegistrarEmpleado = New System.Windows.Forms.Button()
        Me.BtnConsultarPropiedades = New System.Windows.Forms.Button()
        Me.BtnVisitasCanceladas = New System.Windows.Forms.Button()
        Me.BtnConsultarVisitasModificadas = New System.Windows.Forms.Button()
        Me.BtnConsultarAgenda = New System.Windows.Forms.Button()
        Me.LvwAgenda = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomCasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaVisita = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Hora = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PersonalEncargado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LvwPropiedades = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPModificarCancelar = New System.Windows.Forms.TabPage()
        Me.BtnCargarExcel = New System.Windows.Forms.Button()
        Me.LvwControlAgenda = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnVerAgenda = New System.Windows.Forms.Button()
        Me.BtnCancelarAgenda = New System.Windows.Forms.Button()
        Me.BtnModificarAgenda = New System.Windows.Forms.Button()
        Me.TabCAdmins.SuspendLayout()
        Me.TabPConsultas.SuspendLayout()
        Me.TabPModificarCancelar.SuspendLayout()
        Me.SuspendLayout()
        '
        'OFDExcel
        '
        Me.OFDExcel.FileName = "OpenFileDialog1"
        '
        'TabCAdmins
        '
        Me.TabCAdmins.Controls.Add(Me.TabPConsultas)
        Me.TabCAdmins.Controls.Add(Me.TabPModificarCancelar)
        Me.TabCAdmins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabCAdmins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCAdmins.Location = New System.Drawing.Point(12, 35)
        Me.TabCAdmins.Name = "TabCAdmins"
        Me.TabCAdmins.SelectedIndex = 0
        Me.TabCAdmins.Size = New System.Drawing.Size(960, 613)
        Me.TabCAdmins.TabIndex = 1
        '
        'TabPConsultas
        '
        Me.TabPConsultas.BackColor = System.Drawing.Color.Azure
        Me.TabPConsultas.Controls.Add(Me.BtnRegistrarEmpleado)
        Me.TabPConsultas.Controls.Add(Me.BtnConsultarPropiedades)
        Me.TabPConsultas.Controls.Add(Me.BtnVisitasCanceladas)
        Me.TabPConsultas.Controls.Add(Me.BtnConsultarVisitasModificadas)
        Me.TabPConsultas.Controls.Add(Me.BtnConsultarAgenda)
        Me.TabPConsultas.Controls.Add(Me.LvwAgenda)
        Me.TabPConsultas.Controls.Add(Me.LvwPropiedades)
        Me.TabPConsultas.Location = New System.Drawing.Point(4, 29)
        Me.TabPConsultas.Name = "TabPConsultas"
        Me.TabPConsultas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPConsultas.Size = New System.Drawing.Size(952, 580)
        Me.TabPConsultas.TabIndex = 0
        Me.TabPConsultas.Text = "Consultas"
        '
        'BtnRegistrarEmpleado
        '
        Me.BtnRegistrarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnRegistrarEmpleado.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarEmpleado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnRegistrarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnRegistrarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnRegistrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarEmpleado.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrarEmpleado.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnRegistrarEmpleado.Location = New System.Drawing.Point(558, 21)
        Me.BtnRegistrarEmpleado.Name = "BtnRegistrarEmpleado"
        Me.BtnRegistrarEmpleado.Size = New System.Drawing.Size(164, 59)
        Me.BtnRegistrarEmpleado.TabIndex = 10
        Me.BtnRegistrarEmpleado.Tag = "btnchico"
        Me.BtnRegistrarEmpleado.Text = "Registrar Empleados"
        Me.BtnRegistrarEmpleado.UseVisualStyleBackColor = True
        '
        'BtnConsultarPropiedades
        '
        Me.BtnConsultarPropiedades.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnConsultarPropiedades.FlatAppearance.BorderSize = 0
        Me.BtnConsultarPropiedades.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarPropiedades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarPropiedades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarPropiedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarPropiedades.ForeColor = System.Drawing.Color.White
        Me.BtnConsultarPropiedades.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnConsultarPropiedades.Location = New System.Drawing.Point(774, 21)
        Me.BtnConsultarPropiedades.Name = "BtnConsultarPropiedades"
        Me.BtnConsultarPropiedades.Size = New System.Drawing.Size(164, 59)
        Me.BtnConsultarPropiedades.TabIndex = 9
        Me.BtnConsultarPropiedades.Tag = "btnchico"
        Me.BtnConsultarPropiedades.Text = "Ver Propiedades"
        Me.BtnConsultarPropiedades.UseVisualStyleBackColor = True
        '
        'BtnVisitasCanceladas
        '
        Me.BtnVisitasCanceladas.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnVisitasCanceladas.FlatAppearance.BorderSize = 0
        Me.BtnVisitasCanceladas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnVisitasCanceladas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnVisitasCanceladas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnVisitasCanceladas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVisitasCanceladas.ForeColor = System.Drawing.Color.White
        Me.BtnVisitasCanceladas.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnVisitasCanceladas.Location = New System.Drawing.Point(356, 21)
        Me.BtnVisitasCanceladas.Name = "BtnVisitasCanceladas"
        Me.BtnVisitasCanceladas.Size = New System.Drawing.Size(164, 59)
        Me.BtnVisitasCanceladas.TabIndex = 8
        Me.BtnVisitasCanceladas.Tag = "btnchico"
        Me.BtnVisitasCanceladas.Text = "Agenda de Canceladas"
        Me.BtnVisitasCanceladas.UseVisualStyleBackColor = True
        '
        'BtnConsultarVisitasModificadas
        '
        Me.BtnConsultarVisitasModificadas.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnConsultarVisitasModificadas.FlatAppearance.BorderSize = 0
        Me.BtnConsultarVisitasModificadas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarVisitasModificadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarVisitasModificadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarVisitasModificadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarVisitasModificadas.ForeColor = System.Drawing.Color.White
        Me.BtnConsultarVisitasModificadas.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnConsultarVisitasModificadas.Location = New System.Drawing.Point(186, 21)
        Me.BtnConsultarVisitasModificadas.Name = "BtnConsultarVisitasModificadas"
        Me.BtnConsultarVisitasModificadas.Size = New System.Drawing.Size(164, 59)
        Me.BtnConsultarVisitasModificadas.TabIndex = 7
        Me.BtnConsultarVisitasModificadas.Tag = "btnchico"
        Me.BtnConsultarVisitasModificadas.Text = "Agenda de Modificadas"
        Me.BtnConsultarVisitasModificadas.UseVisualStyleBackColor = True
        '
        'BtnConsultarAgenda
        '
        Me.BtnConsultarAgenda.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnConsultarAgenda.FlatAppearance.BorderSize = 0
        Me.BtnConsultarAgenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnConsultarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarAgenda.ForeColor = System.Drawing.Color.White
        Me.BtnConsultarAgenda.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnConsultarAgenda.Location = New System.Drawing.Point(16, 21)
        Me.BtnConsultarAgenda.Name = "BtnConsultarAgenda"
        Me.BtnConsultarAgenda.Size = New System.Drawing.Size(164, 59)
        Me.BtnConsultarAgenda.TabIndex = 6
        Me.BtnConsultarAgenda.Tag = "btnchico"
        Me.BtnConsultarAgenda.Text = "Agenda de Hoy"
        Me.BtnConsultarAgenda.UseVisualStyleBackColor = True
        '
        'LvwAgenda
        '
        Me.LvwAgenda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.NombreCliente, Me.NomCasa, Me.FechaVisita, Me.Hora, Me.PersonalEncargado})
        Me.LvwAgenda.FullRowSelect = True
        Me.LvwAgenda.HideSelection = False
        Me.LvwAgenda.Location = New System.Drawing.Point(16, 86)
        Me.LvwAgenda.MultiSelect = False
        Me.LvwAgenda.Name = "LvwAgenda"
        Me.LvwAgenda.Size = New System.Drawing.Size(922, 477)
        Me.LvwAgenda.TabIndex = 11
        Me.LvwAgenda.UseCompatibleStateImageBehavior = False
        Me.LvwAgenda.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'NombreCliente
        '
        Me.NombreCliente.Text = "Nombre del cliente"
        Me.NombreCliente.Width = 158
        '
        'NomCasa
        '
        Me.NomCasa.Text = "Nombre de la casa"
        Me.NomCasa.Width = 158
        '
        'FechaVisita
        '
        Me.FechaVisita.Text = "Fecha de la visita"
        Me.FechaVisita.Width = 191
        '
        'Hora
        '
        Me.Hora.Text = "Hora de la visita"
        Me.Hora.Width = 206
        '
        'PersonalEncargado
        '
        Me.PersonalEncargado.Text = "Personal Encargado"
        Me.PersonalEncargado.Width = 175
        '
        'LvwPropiedades
        '
        Me.LvwPropiedades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.LvwPropiedades.FullRowSelect = True
        Me.LvwPropiedades.HideSelection = False
        Me.LvwPropiedades.Location = New System.Drawing.Point(16, 86)
        Me.LvwPropiedades.MultiSelect = False
        Me.LvwPropiedades.Name = "LvwPropiedades"
        Me.LvwPropiedades.Size = New System.Drawing.Size(922, 477)
        Me.LvwPropiedades.TabIndex = 12
        Me.LvwPropiedades.UseCompatibleStateImageBehavior = False
        Me.LvwPropiedades.View = System.Windows.Forms.View.Details
        Me.LvwPropiedades.Visible = False
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ID"
        Me.ColumnHeader14.Width = 30
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Nombre"
        Me.ColumnHeader15.Width = 73
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Precio"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Terreno Cubierto"
        Me.ColumnHeader17.Width = 140
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Terreno"
        Me.ColumnHeader18.Width = 78
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Departamento"
        Me.ColumnHeader8.Width = 121
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Barrio"
        Me.ColumnHeader9.Width = 73
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Condicion"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Tipo"
        Me.ColumnHeader11.Width = 67
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Estado"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Antiguedad"
        Me.ColumnHeader13.Width = 290
        '
        'TabPModificarCancelar
        '
        Me.TabPModificarCancelar.BackColor = System.Drawing.Color.Azure
        Me.TabPModificarCancelar.Controls.Add(Me.BtnCargarExcel)
        Me.TabPModificarCancelar.Controls.Add(Me.LvwControlAgenda)
        Me.TabPModificarCancelar.Controls.Add(Me.BtnVerAgenda)
        Me.TabPModificarCancelar.Controls.Add(Me.BtnCancelarAgenda)
        Me.TabPModificarCancelar.Controls.Add(Me.BtnModificarAgenda)
        Me.TabPModificarCancelar.Location = New System.Drawing.Point(4, 29)
        Me.TabPModificarCancelar.Name = "TabPModificarCancelar"
        Me.TabPModificarCancelar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPModificarCancelar.Size = New System.Drawing.Size(952, 580)
        Me.TabPModificarCancelar.TabIndex = 1
        Me.TabPModificarCancelar.Text = "Agenda y Propiedades"
        '
        'BtnCargarExcel
        '
        Me.BtnCargarExcel.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnCargarExcel.FlatAppearance.BorderSize = 0
        Me.BtnCargarExcel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnCargarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnCargarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnCargarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargarExcel.ForeColor = System.Drawing.Color.White
        Me.BtnCargarExcel.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnCargarExcel.Location = New System.Drawing.Point(421, 21)
        Me.BtnCargarExcel.Name = "BtnCargarExcel"
        Me.BtnCargarExcel.Size = New System.Drawing.Size(164, 59)
        Me.BtnCargarExcel.TabIndex = 13
        Me.BtnCargarExcel.Tag = "btnchico"
        Me.BtnCargarExcel.Text = "Cargar Excel"
        Me.BtnCargarExcel.UseVisualStyleBackColor = True
        '
        'LvwControlAgenda
        '
        Me.LvwControlAgenda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LvwControlAgenda.FullRowSelect = True
        Me.LvwControlAgenda.HideSelection = False
        Me.LvwControlAgenda.Location = New System.Drawing.Point(16, 86)
        Me.LvwControlAgenda.MultiSelect = False
        Me.LvwControlAgenda.Name = "LvwControlAgenda"
        Me.LvwControlAgenda.Size = New System.Drawing.Size(922, 477)
        Me.LvwControlAgenda.TabIndex = 12
        Me.LvwControlAgenda.UseCompatibleStateImageBehavior = False
        Me.LvwControlAgenda.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre del cliente"
        Me.ColumnHeader2.Width = 158
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre de la casa"
        Me.ColumnHeader3.Width = 158
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha de la visita"
        Me.ColumnHeader4.Width = 191
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hora de la visita"
        Me.ColumnHeader5.Width = 206
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Personal Encargado"
        Me.ColumnHeader6.Width = 175
        '
        'BtnVerAgenda
        '
        Me.BtnVerAgenda.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnVerAgenda.FlatAppearance.BorderSize = 0
        Me.BtnVerAgenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnVerAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnVerAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnVerAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerAgenda.ForeColor = System.Drawing.Color.White
        Me.BtnVerAgenda.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnVerAgenda.Location = New System.Drawing.Point(16, 27)
        Me.BtnVerAgenda.Name = "BtnVerAgenda"
        Me.BtnVerAgenda.Size = New System.Drawing.Size(164, 46)
        Me.BtnVerAgenda.TabIndex = 7
        Me.BtnVerAgenda.Tag = "btnchico"
        Me.BtnVerAgenda.Text = "Ver Agenda"
        Me.BtnVerAgenda.UseVisualStyleBackColor = True
        '
        'BtnCancelarAgenda
        '
        Me.BtnCancelarAgenda.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnCancelarAgenda.FlatAppearance.BorderSize = 0
        Me.BtnCancelarAgenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnCancelarAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnCancelarAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnCancelarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarAgenda.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarAgenda.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnCancelarAgenda.Location = New System.Drawing.Point(591, 27)
        Me.BtnCancelarAgenda.Name = "BtnCancelarAgenda"
        Me.BtnCancelarAgenda.Size = New System.Drawing.Size(164, 46)
        Me.BtnCancelarAgenda.TabIndex = 6
        Me.BtnCancelarAgenda.Tag = "btnchico"
        Me.BtnCancelarAgenda.Text = "Cancelar Visita"
        Me.BtnCancelarAgenda.UseVisualStyleBackColor = True
        '
        'BtnModificarAgenda
        '
        Me.BtnModificarAgenda.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnModificarAgenda.FlatAppearance.BorderSize = 0
        Me.BtnModificarAgenda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure
        Me.BtnModificarAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnModificarAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnModificarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarAgenda.ForeColor = System.Drawing.Color.White
        Me.BtnModificarAgenda.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnModificarAgenda.Location = New System.Drawing.Point(774, 27)
        Me.BtnModificarAgenda.Name = "BtnModificarAgenda"
        Me.BtnModificarAgenda.Size = New System.Drawing.Size(164, 46)
        Me.BtnModificarAgenda.TabIndex = 5
        Me.BtnModificarAgenda.Tag = "btnchico"
        Me.BtnModificarAgenda.Text = "Modificar Visita"
        Me.BtnModificarAgenda.UseVisualStyleBackColor = True
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Proyecto_Inmobiliaria.My.Resources.Resources.FondoTemaAzul
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.TabCAdmins)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propuru - Nombre Usuario"
        Me.TabCAdmins.ResumeLayout(False)
        Me.TabPConsultas.ResumeLayout(False)
        Me.TabPModificarCancelar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OFDExcel As OpenFileDialog
    Friend WithEvents TabCAdmins As TabControl
    Friend WithEvents TabPConsultas As TabPage
    Friend WithEvents BtnRegistrarEmpleado As Button
    Friend WithEvents BtnConsultarPropiedades As Button
    Friend WithEvents BtnVisitasCanceladas As Button
    Friend WithEvents BtnConsultarVisitasModificadas As Button
    Friend WithEvents BtnConsultarAgenda As Button
    Friend WithEvents LvwAgenda As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents NombreCliente As ColumnHeader
    Friend WithEvents NomCasa As ColumnHeader
    Friend WithEvents FechaVisita As ColumnHeader
    Friend WithEvents Hora As ColumnHeader
    Friend WithEvents PersonalEncargado As ColumnHeader
    Friend WithEvents LvwPropiedades As ListView
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents TabPModificarCancelar As TabPage
    Friend WithEvents BtnCargarExcel As Button
    Friend WithEvents LvwControlAgenda As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents BtnVerAgenda As Button
    Friend WithEvents BtnCancelarAgenda As Button
    Friend WithEvents BtnModificarAgenda As Button
End Class
