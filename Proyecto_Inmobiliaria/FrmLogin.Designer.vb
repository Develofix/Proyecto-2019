<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TxtPasswd = New System.Windows.Forms.TextBox()
        Me.BtnVerPropiedades = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.PnlLogin = New System.Windows.Forms.Panel()
        Me.PbxLoginImg = New System.Windows.Forms.PictureBox()
        Me.BtnRegistrarse = New System.Windows.Forms.Button()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.PbxGif = New System.Windows.Forms.PictureBox()
        Me.PnlLogin.SuspendLayout()
        CType(Me.PbxLoginImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPasswd
        '
        Me.TxtPasswd.BackColor = System.Drawing.Color.Azure
        Me.TxtPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswd.ForeColor = System.Drawing.Color.Gray
        Me.TxtPasswd.Location = New System.Drawing.Point(19, 184)
        Me.TxtPasswd.Name = "TxtPasswd"
        Me.TxtPasswd.Size = New System.Drawing.Size(302, 30)
        Me.TxtPasswd.TabIndex = 2
        Me.TxtPasswd.Text = "Escribe tu contraseña"
        '
        'BtnVerPropiedades
        '
        Me.BtnVerPropiedades.BackColor = System.Drawing.Color.Transparent
        Me.BtnVerPropiedades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVerPropiedades.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnVerPropiedades.FlatAppearance.BorderSize = 0
        Me.BtnVerPropiedades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnVerPropiedades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnVerPropiedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerPropiedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerPropiedades.ForeColor = System.Drawing.Color.Azure
        Me.BtnVerPropiedades.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonChiquitoTemaAzul
        Me.BtnVerPropiedades.Location = New System.Drawing.Point(3, 567)
        Me.BtnVerPropiedades.Name = "BtnVerPropiedades"
        Me.BtnVerPropiedades.Size = New System.Drawing.Size(333, 52)
        Me.BtnVerPropiedades.TabIndex = 0
        Me.BtnVerPropiedades.Tag = "btnchico"
        Me.BtnVerPropiedades.Text = "Ver propiedades"
        Me.BtnVerPropiedades.UseVisualStyleBackColor = False
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
        Me.BtnIngresar.Location = New System.Drawing.Point(19, 239)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(302, 45)
        Me.BtnIngresar.TabIndex = 3
        Me.BtnIngresar.Tag = "btnnormal"
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'PnlLogin
        '
        Me.PnlLogin.BackColor = System.Drawing.Color.Azure
        Me.PnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLogin.Controls.Add(Me.PbxLoginImg)
        Me.PnlLogin.Controls.Add(Me.BtnRegistrarse)
        Me.PnlLogin.Controls.Add(Me.TxtUser)
        Me.PnlLogin.Controls.Add(Me.TxtPasswd)
        Me.PnlLogin.Controls.Add(Me.BtnIngresar)
        Me.PnlLogin.Controls.Add(Me.BtnVerPropiedades)
        Me.PnlLogin.Location = New System.Drawing.Point(530, 12)
        Me.PnlLogin.Name = "PnlLogin"
        Me.PnlLogin.Size = New System.Drawing.Size(341, 637)
        Me.PnlLogin.TabIndex = 1
        '
        'PbxLoginImg
        '
        Me.PbxLoginImg.BackColor = System.Drawing.Color.Transparent
        Me.PbxLoginImg.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.PerfilAzul1
        Me.PbxLoginImg.Location = New System.Drawing.Point(19, 12)
        Me.PbxLoginImg.Name = "PbxLoginImg"
        Me.PbxLoginImg.Size = New System.Drawing.Size(302, 126)
        Me.PbxLoginImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxLoginImg.TabIndex = 3
        Me.PbxLoginImg.TabStop = False
        Me.PbxLoginImg.Tag = "perfil"
        '
        'BtnRegistrarse
        '
        Me.BtnRegistrarse.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnRegistrarse.FlatAppearance.BorderSize = 0
        Me.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarse.Location = New System.Drawing.Point(107, 533)
        Me.BtnRegistrarse.Name = "BtnRegistrarse"
        Me.BtnRegistrarse.Size = New System.Drawing.Size(125, 28)
        Me.BtnRegistrarse.TabIndex = 4
        Me.BtnRegistrarse.Text = "Crear cuenta"
        Me.BtnRegistrarse.UseVisualStyleBackColor = False
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.Azure
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.Gray
        Me.TxtUser.Location = New System.Drawing.Point(19, 148)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(302, 30)
        Me.TxtUser.TabIndex = 1
        Me.TxtUser.Text = "Escribe tu usuario"
        '
        'PbxGif
        '
        Me.PbxGif.BackColor = System.Drawing.Color.Transparent
        Me.PbxGif.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.AnimacionIcono
        Me.PbxGif.Location = New System.Drawing.Point(3, 238)
        Me.PbxGif.Name = "PbxGif"
        Me.PbxGif.Size = New System.Drawing.Size(525, 189)
        Me.PbxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxGif.TabIndex = 2
        Me.PbxGif.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Proyecto_Inmobiliaria.My.Resources.Resources.FondoTemaAzul
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PbxGif)
        Me.Controls.Add(Me.PnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propuru - Login"
        Me.PnlLogin.ResumeLayout(False)
        Me.PnlLogin.PerformLayout()
        CType(Me.PbxLoginImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtPasswd As TextBox
    Friend WithEvents BtnVerPropiedades As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents PnlLogin As Panel
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents PbxGif As PictureBox
    Friend WithEvents BtnRegistrarse As Button
    Friend WithEvents PbxLoginImg As PictureBox
End Class
