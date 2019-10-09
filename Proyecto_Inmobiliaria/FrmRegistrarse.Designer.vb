<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarse))
        Me.TxtTurno = New System.Windows.Forms.TextBox()
        Me.CbxTurno = New System.Windows.Forms.ComboBox()
        Me.TxtTipoUser = New System.Windows.Forms.TextBox()
        Me.TxtSucursal = New System.Windows.Forms.TextBox()
        Me.CbxSucursales = New System.Windows.Forms.ComboBox()
        Me.TxtNumCalle = New System.Windows.Forms.TextBox()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.TxTConfirmarContra = New System.Windows.Forms.TextBox()
        Me.MtxtCedula = New System.Windows.Forms.MaskedTextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.CbxTipoDeUsuario = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TxtFechaNac = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.PnlRegistro = New System.Windows.Forms.Panel()
        Me.PnlRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtTurno
        '
        Me.TxtTurno.BackColor = System.Drawing.Color.Azure
        Me.TxtTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTurno.Enabled = False
        Me.TxtTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTurno.ForeColor = System.Drawing.Color.Gray
        Me.TxtTurno.Location = New System.Drawing.Point(347, 446)
        Me.TxtTurno.Name = "TxtTurno"
        Me.TxtTurno.Size = New System.Drawing.Size(119, 30)
        Me.TxtTurno.TabIndex = 77
        Me.TxtTurno.Text = "Turno"
        Me.TxtTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTurno.Visible = False
        '
        'CbxTurno
        '
        Me.CbxTurno.BackColor = System.Drawing.Color.Azure
        Me.CbxTurno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTurno.ForeColor = System.Drawing.Color.Black
        Me.CbxTurno.FormattingEnabled = True
        Me.CbxTurno.Items.AddRange(New Object() {"Matutino", "Vespertino"})
        Me.CbxTurno.Location = New System.Drawing.Point(347, 482)
        Me.CbxTurno.Name = "CbxTurno"
        Me.CbxTurno.Size = New System.Drawing.Size(119, 28)
        Me.CbxTurno.TabIndex = 76
        Me.CbxTurno.Visible = False
        '
        'TxtTipoUser
        '
        Me.TxtTipoUser.BackColor = System.Drawing.Color.Azure
        Me.TxtTipoUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTipoUser.Enabled = False
        Me.TxtTipoUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoUser.ForeColor = System.Drawing.Color.Gray
        Me.TxtTipoUser.Location = New System.Drawing.Point(11, 446)
        Me.TxtTipoUser.Name = "TxtTipoUser"
        Me.TxtTipoUser.Size = New System.Drawing.Size(175, 30)
        Me.TxtTipoUser.TabIndex = 75
        Me.TxtTipoUser.Text = "Tipo Usuario"
        Me.TxtTipoUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTipoUser.Visible = False
        '
        'TxtSucursal
        '
        Me.TxtSucursal.BackColor = System.Drawing.Color.Azure
        Me.TxtSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSucursal.Enabled = False
        Me.TxtSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSucursal.ForeColor = System.Drawing.Color.Gray
        Me.TxtSucursal.Location = New System.Drawing.Point(203, 446)
        Me.TxtSucursal.Name = "TxtSucursal"
        Me.TxtSucursal.Size = New System.Drawing.Size(127, 30)
        Me.TxtSucursal.TabIndex = 74
        Me.TxtSucursal.Text = "Sucursal"
        Me.TxtSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSucursal.Visible = False
        '
        'CbxSucursales
        '
        Me.CbxSucursales.BackColor = System.Drawing.Color.Azure
        Me.CbxSucursales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxSucursales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSucursales.ForeColor = System.Drawing.Color.Black
        Me.CbxSucursales.FormattingEnabled = True
        Me.CbxSucursales.Location = New System.Drawing.Point(203, 481)
        Me.CbxSucursales.Name = "CbxSucursales"
        Me.CbxSucursales.Size = New System.Drawing.Size(127, 28)
        Me.CbxSucursales.TabIndex = 72
        Me.CbxSucursales.Visible = False
        '
        'TxtNumCalle
        '
        Me.TxtNumCalle.BackColor = System.Drawing.Color.Azure
        Me.TxtNumCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumCalle.ForeColor = System.Drawing.Color.Gray
        Me.TxtNumCalle.Location = New System.Drawing.Point(11, 406)
        Me.TxtNumCalle.Name = "TxtNumCalle"
        Me.TxtNumCalle.Size = New System.Drawing.Size(455, 30)
        Me.TxtNumCalle.TabIndex = 71
        Me.TxtNumCalle.Text = "Número de calle"
        '
        'TxtCalle
        '
        Me.TxtCalle.BackColor = System.Drawing.Color.Azure
        Me.TxtCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCalle.ForeColor = System.Drawing.Color.Gray
        Me.TxtCalle.Location = New System.Drawing.Point(11, 366)
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(455, 30)
        Me.TxtCalle.TabIndex = 70
        Me.TxtCalle.Text = "Dirección ( Calle )"
        '
        'TxTConfirmarContra
        '
        Me.TxTConfirmarContra.BackColor = System.Drawing.Color.Azure
        Me.TxTConfirmarContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTConfirmarContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTConfirmarContra.ForeColor = System.Drawing.Color.Gray
        Me.TxTConfirmarContra.Location = New System.Drawing.Point(11, 93)
        Me.TxTConfirmarContra.Name = "TxTConfirmarContra"
        Me.TxTConfirmarContra.Size = New System.Drawing.Size(455, 30)
        Me.TxTConfirmarContra.TabIndex = 69
        Me.TxTConfirmarContra.Text = "Confirmar contraseña"
        '
        'MtxtCedula
        '
        Me.MtxtCedula.BackColor = System.Drawing.Color.Azure
        Me.MtxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MtxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.MtxtCedula.ForeColor = System.Drawing.Color.Gray
        Me.MtxtCedula.Location = New System.Drawing.Point(11, 130)
        Me.MtxtCedula.Name = "MtxtCedula"
        Me.MtxtCedula.Size = New System.Drawing.Size(455, 30)
        Me.MtxtCedula.TabIndex = 32
        Me.MtxtCedula.Text = "Cédula"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnIngresar.FlatAppearance.BorderSize = 0
        Me.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnIngresar.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonLoginTemaAzul1
        Me.BtnIngresar.Location = New System.Drawing.Point(85, 544)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(319, 45)
        Me.BtnIngresar.TabIndex = 27
        Me.BtnIngresar.Tag = "btnnormal"
        Me.BtnIngresar.Text = "Crear cuenta"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnVolver.FlatAppearance.BorderSize = 0
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(398, 595)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(62, 35)
        Me.BtnVolver.TabIndex = 3
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'CbxTipoDeUsuario
        '
        Me.CbxTipoDeUsuario.BackColor = System.Drawing.Color.Azure
        Me.CbxTipoDeUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbxTipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipoDeUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTipoDeUsuario.ForeColor = System.Drawing.Color.Black
        Me.CbxTipoDeUsuario.FormattingEnabled = True
        Me.CbxTipoDeUsuario.Items.AddRange(New Object() {"Agente Inmobiliario", "Gerente"})
        Me.CbxTipoDeUsuario.Location = New System.Drawing.Point(11, 481)
        Me.CbxTipoDeUsuario.Name = "CbxTipoDeUsuario"
        Me.CbxTipoDeUsuario.Size = New System.Drawing.Size(175, 28)
        Me.CbxTipoDeUsuario.TabIndex = 26
        Me.CbxTipoDeUsuario.Visible = False
        '
        'DTPFechaNac
        '
        Me.DTPFechaNac.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DTPFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaNac.Location = New System.Drawing.Point(347, 329)
        Me.DTPFechaNac.MaxDate = New Date(2019, 6, 20, 20, 15, 12, 0)
        Me.DTPFechaNac.Name = "DTPFechaNac"
        Me.DTPFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTPFechaNac.Size = New System.Drawing.Size(113, 24)
        Me.DTPFechaNac.TabIndex = 15
        Me.DTPFechaNac.Value = New Date(2019, 6, 20, 0, 0, 0, 0)
        '
        'TxtFechaNac
        '
        Me.TxtFechaNac.BackColor = System.Drawing.Color.Azure
        Me.TxtFechaNac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFechaNac.Enabled = False
        Me.TxtFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaNac.ForeColor = System.Drawing.Color.Black
        Me.TxtFechaNac.Location = New System.Drawing.Point(11, 326)
        Me.TxtFechaNac.Name = "TxtFechaNac"
        Me.TxtFechaNac.Size = New System.Drawing.Size(455, 30)
        Me.TxtFechaNac.TabIndex = 25
        Me.TxtFechaNac.Text = "Fecha de Nacimiento"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BackColor = System.Drawing.Color.Azure
        Me.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.ForeColor = System.Drawing.Color.Gray
        Me.TxtContraseña.Location = New System.Drawing.Point(11, 55)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(455, 30)
        Me.TxtContraseña.TabIndex = 24
        Me.TxtContraseña.Text = "Contraseña"
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.Azure
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.Gray
        Me.TxtUser.Location = New System.Drawing.Point(11, 19)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(455, 30)
        Me.TxtUser.TabIndex = 23
        Me.TxtUser.Text = "Usuario"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.Azure
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.ForeColor = System.Drawing.Color.Gray
        Me.TxtTelefono.Location = New System.Drawing.Point(11, 286)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(455, 30)
        Me.TxtTelefono.TabIndex = 14
        Me.TxtTelefono.Text = "Teléfono"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.Azure
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.Gray
        Me.TxtEmail.Location = New System.Drawing.Point(11, 246)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(455, 30)
        Me.TxtEmail.TabIndex = 13
        Me.TxtEmail.Text = "Email"
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.Azure
        Me.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.ForeColor = System.Drawing.Color.Gray
        Me.TxtApellido.Location = New System.Drawing.Point(11, 206)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(455, 30)
        Me.TxtApellido.TabIndex = 12
        Me.TxtApellido.Text = "Apellido"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.Azure
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Gray
        Me.TxtNombre.Location = New System.Drawing.Point(11, 168)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(455, 30)
        Me.TxtNombre.TabIndex = 11
        Me.TxtNombre.Text = "Nombre"
        '
        'PnlRegistro
        '
        Me.PnlRegistro.BackColor = System.Drawing.Color.Azure
        Me.PnlRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlRegistro.Controls.Add(Me.TxtTurno)
        Me.PnlRegistro.Controls.Add(Me.CbxTurno)
        Me.PnlRegistro.Controls.Add(Me.TxtTipoUser)
        Me.PnlRegistro.Controls.Add(Me.TxtSucursal)
        Me.PnlRegistro.Controls.Add(Me.CbxSucursales)
        Me.PnlRegistro.Controls.Add(Me.TxtNumCalle)
        Me.PnlRegistro.Controls.Add(Me.TxtCalle)
        Me.PnlRegistro.Controls.Add(Me.TxTConfirmarContra)
        Me.PnlRegistro.Controls.Add(Me.MtxtCedula)
        Me.PnlRegistro.Controls.Add(Me.BtnIngresar)
        Me.PnlRegistro.Controls.Add(Me.BtnVolver)
        Me.PnlRegistro.Controls.Add(Me.CbxTipoDeUsuario)
        Me.PnlRegistro.Controls.Add(Me.DTPFechaNac)
        Me.PnlRegistro.Controls.Add(Me.TxtFechaNac)
        Me.PnlRegistro.Controls.Add(Me.TxtContraseña)
        Me.PnlRegistro.Controls.Add(Me.TxtUser)
        Me.PnlRegistro.Controls.Add(Me.TxtTelefono)
        Me.PnlRegistro.Controls.Add(Me.TxtEmail)
        Me.PnlRegistro.Controls.Add(Me.TxtApellido)
        Me.PnlRegistro.Controls.Add(Me.TxtNombre)
        Me.PnlRegistro.Location = New System.Drawing.Point(418, 12)
        Me.PnlRegistro.Name = "PnlRegistro"
        Me.PnlRegistro.Size = New System.Drawing.Size(478, 637)
        Me.PnlRegistro.TabIndex = 4
        '
        'FrmRegistrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Proyecto_Inmobiliaria.My.Resources.Resources.FondoTemaAzul
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PnlRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistrarse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propuru - Registro"
        Me.PnlRegistro.ResumeLayout(False)
        Me.PnlRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtTurno As TextBox
    Friend WithEvents CbxTurno As ComboBox
    Friend WithEvents TxtTipoUser As TextBox
    Friend WithEvents TxtSucursal As TextBox
    Friend WithEvents CbxSucursales As ComboBox
    Friend WithEvents TxtNumCalle As TextBox
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents TxTConfirmarContra As TextBox
    Friend WithEvents MtxtCedula As MaskedTextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents CbxTipoDeUsuario As ComboBox
    Friend WithEvents DTPFechaNac As DateTimePicker
    Friend WithEvents TxtFechaNac As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents PnlRegistro As Panel
End Class
