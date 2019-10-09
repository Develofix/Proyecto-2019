<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.PnlFiltros = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbnSinEspecificar = New System.Windows.Forms.RadioButton()
        Me.ChkGarage2 = New System.Windows.Forms.CheckBox()
        Me.ChkGarage3 = New System.Windows.Forms.CheckBox()
        Me.ChkGarage1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAplicar = New System.Windows.Forms.Button()
        Me.CbxCondicion = New System.Windows.Forms.ComboBox()
        Me.LblCondicion = New System.Windows.Forms.Label()
        Me.TxtHastaA = New System.Windows.Forms.TextBox()
        Me.TxtDesdeA = New System.Windows.Forms.TextBox()
        Me.TxtHastaTC = New System.Windows.Forms.TextBox()
        Me.TxtDesdeTC = New System.Windows.Forms.TextBox()
        Me.LblAntiguedad = New System.Windows.Forms.Label()
        Me.LblTerrenoCub = New System.Windows.Forms.Label()
        Me.TxtHastaT = New System.Windows.Forms.TextBox()
        Me.TxtDesdeT = New System.Windows.Forms.TextBox()
        Me.LblTerreno = New System.Windows.Forms.Label()
        Me.RbnAlquiler = New System.Windows.Forms.RadioButton()
        Me.RbnCompra = New System.Windows.Forms.RadioButton()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CbxBarrio = New System.Windows.Forms.ComboBox()
        Me.CbxCiudad = New System.Windows.Forms.ComboBox()
        Me.CbxDepartamento = New System.Windows.Forms.ComboBox()
        Me.LblBarrio = New System.Windows.Forms.Label()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.LblDepartamento = New System.Windows.Forms.Label()
        Me.ChkBaños2 = New System.Windows.Forms.CheckBox()
        Me.ChkBaños3 = New System.Windows.Forms.CheckBox()
        Me.ChkBaños1 = New System.Windows.Forms.CheckBox()
        Me.ChkHab2 = New System.Windows.Forms.CheckBox()
        Me.ChkHab3 = New System.Windows.Forms.CheckBox()
        Me.ChkHab4 = New System.Windows.Forms.CheckBox()
        Me.ChkHab5 = New System.Windows.Forms.CheckBox()
        Me.ChkHab1 = New System.Windows.Forms.CheckBox()
        Me.LblBaños = New System.Windows.Forms.Label()
        Me.LblHabitaciones = New System.Windows.Forms.Label()
        Me.CbxTipo = New System.Windows.Forms.ComboBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.TxtHastaP = New System.Windows.Forms.TextBox()
        Me.TxtDesdeP = New System.Windows.Forms.TextBox()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.PnlOrdenar_Buscar = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnOrdenarPrecio = New System.Windows.Forms.Button()
        Me.LblOrdenar = New System.Windows.Forms.Label()
        Me.PnlCasas = New System.Windows.Forms.Panel()
        Me.PnlCasa5 = New System.Windows.Forms.Panel()
        Me.LblEstado5 = New System.Windows.Forms.Label()
        Me.LblPrecio5 = New System.Windows.Forms.Label()
        Me.LblTipo5 = New System.Windows.Forms.Label()
        Me.PnlCasa6 = New System.Windows.Forms.Panel()
        Me.LblEstado6 = New System.Windows.Forms.Label()
        Me.LblPrecio6 = New System.Windows.Forms.Label()
        Me.LblTipo6 = New System.Windows.Forms.Label()
        Me.PnlCasa3 = New System.Windows.Forms.Panel()
        Me.LblEstado3 = New System.Windows.Forms.Label()
        Me.LblPrecio3 = New System.Windows.Forms.Label()
        Me.LblTipo3 = New System.Windows.Forms.Label()
        Me.PnlCasa2 = New System.Windows.Forms.Panel()
        Me.LblEstado2 = New System.Windows.Forms.Label()
        Me.LblTipo2 = New System.Windows.Forms.Label()
        Me.LblPrecio2 = New System.Windows.Forms.Label()
        Me.PnlCasa4 = New System.Windows.Forms.Panel()
        Me.LblEstado4 = New System.Windows.Forms.Label()
        Me.LblPrecio4 = New System.Windows.Forms.Label()
        Me.LblTipo4 = New System.Windows.Forms.Label()
        Me.PnlCasa1 = New System.Windows.Forms.Panel()
        Me.LblEstado1 = New System.Windows.Forms.Label()
        Me.LblTipo1 = New System.Windows.Forms.Label()
        Me.LblPrecio1 = New System.Windows.Forms.Label()
        Me.PbxCasa6 = New System.Windows.Forms.PictureBox()
        Me.PbxCasa5 = New System.Windows.Forms.PictureBox()
        Me.PbxCasa4 = New System.Windows.Forms.PictureBox()
        Me.PbxCasa3 = New System.Windows.Forms.PictureBox()
        Me.PbxCasa2 = New System.Windows.Forms.PictureBox()
        Me.PbxCasa1 = New System.Windows.Forms.PictureBox()
        Me.BtnPagSiguiente = New System.Windows.Forms.Button()
        Me.BtnPagAnterior = New System.Windows.Forms.Button()
        Me.PnlFiltros.SuspendLayout()
        Me.PnlOrdenar_Buscar.SuspendLayout()
        Me.PnlCasas.SuspendLayout()
        Me.PnlCasa5.SuspendLayout()
        Me.PnlCasa6.SuspendLayout()
        Me.PnlCasa3.SuspendLayout()
        Me.PnlCasa2.SuspendLayout()
        Me.PnlCasa4.SuspendLayout()
        Me.PnlCasa1.SuspendLayout()
        CType(Me.PbxCasa6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCasa5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCasa4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCasa3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCasa2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCasa1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlFiltros
        '
        Me.PnlFiltros.AutoScroll = True
        Me.PnlFiltros.BackColor = System.Drawing.Color.Azure
        Me.PnlFiltros.Controls.Add(Me.Button2)
        Me.PnlFiltros.Controls.Add(Me.Button1)
        Me.PnlFiltros.Controls.Add(Me.rbnSinEspecificar)
        Me.PnlFiltros.Controls.Add(Me.ChkGarage2)
        Me.PnlFiltros.Controls.Add(Me.ChkGarage3)
        Me.PnlFiltros.Controls.Add(Me.ChkGarage1)
        Me.PnlFiltros.Controls.Add(Me.Label1)
        Me.PnlFiltros.Controls.Add(Me.BtnAplicar)
        Me.PnlFiltros.Controls.Add(Me.CbxCondicion)
        Me.PnlFiltros.Controls.Add(Me.LblCondicion)
        Me.PnlFiltros.Controls.Add(Me.TxtHastaA)
        Me.PnlFiltros.Controls.Add(Me.TxtDesdeA)
        Me.PnlFiltros.Controls.Add(Me.TxtHastaTC)
        Me.PnlFiltros.Controls.Add(Me.TxtDesdeTC)
        Me.PnlFiltros.Controls.Add(Me.LblAntiguedad)
        Me.PnlFiltros.Controls.Add(Me.LblTerrenoCub)
        Me.PnlFiltros.Controls.Add(Me.TxtHastaT)
        Me.PnlFiltros.Controls.Add(Me.TxtDesdeT)
        Me.PnlFiltros.Controls.Add(Me.LblTerreno)
        Me.PnlFiltros.Controls.Add(Me.RbnAlquiler)
        Me.PnlFiltros.Controls.Add(Me.RbnCompra)
        Me.PnlFiltros.Controls.Add(Me.LblEstado)
        Me.PnlFiltros.Controls.Add(Me.CbxBarrio)
        Me.PnlFiltros.Controls.Add(Me.CbxCiudad)
        Me.PnlFiltros.Controls.Add(Me.CbxDepartamento)
        Me.PnlFiltros.Controls.Add(Me.LblBarrio)
        Me.PnlFiltros.Controls.Add(Me.LblCiudad)
        Me.PnlFiltros.Controls.Add(Me.LblDepartamento)
        Me.PnlFiltros.Controls.Add(Me.ChkBaños2)
        Me.PnlFiltros.Controls.Add(Me.ChkBaños3)
        Me.PnlFiltros.Controls.Add(Me.ChkBaños1)
        Me.PnlFiltros.Controls.Add(Me.ChkHab2)
        Me.PnlFiltros.Controls.Add(Me.ChkHab3)
        Me.PnlFiltros.Controls.Add(Me.ChkHab4)
        Me.PnlFiltros.Controls.Add(Me.ChkHab5)
        Me.PnlFiltros.Controls.Add(Me.ChkHab1)
        Me.PnlFiltros.Controls.Add(Me.LblBaños)
        Me.PnlFiltros.Controls.Add(Me.LblHabitaciones)
        Me.PnlFiltros.Controls.Add(Me.CbxTipo)
        Me.PnlFiltros.Controls.Add(Me.LblTipo)
        Me.PnlFiltros.Controls.Add(Me.TxtHastaP)
        Me.PnlFiltros.Controls.Add(Me.TxtDesdeP)
        Me.PnlFiltros.Controls.Add(Me.LblPrecio)
        Me.PnlFiltros.Location = New System.Drawing.Point(8, 33)
        Me.PnlFiltros.Name = "PnlFiltros"
        Me.PnlFiltros.Size = New System.Drawing.Size(226, 613)
        Me.PnlFiltros.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(10, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "Restablecer"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Azure
        Me.Button1.Location = New System.Drawing.Point(12, 682)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 21)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "------"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rbnSinEspecificar
        '
        Me.rbnSinEspecificar.AutoSize = True
        Me.rbnSinEspecificar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbnSinEspecificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnSinEspecificar.Location = New System.Drawing.Point(10, 452)
        Me.rbnSinEspecificar.Name = "rbnSinEspecificar"
        Me.rbnSinEspecificar.Size = New System.Drawing.Size(115, 20)
        Me.rbnSinEspecificar.TabIndex = 81
        Me.rbnSinEspecificar.TabStop = True
        Me.rbnSinEspecificar.Tag = "marcar"
        Me.rbnSinEspecificar.Text = "Sin Especificar"
        Me.rbnSinEspecificar.UseVisualStyleBackColor = False
        '
        'ChkGarage2
        '
        Me.ChkGarage2.AutoSize = True
        Me.ChkGarage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkGarage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGarage2.Location = New System.Drawing.Point(51, 235)
        Me.ChkGarage2.Name = "ChkGarage2"
        Me.ChkGarage2.Size = New System.Drawing.Size(34, 20)
        Me.ChkGarage2.TabIndex = 80
        Me.ChkGarage2.Tag = "marcado"
        Me.ChkGarage2.Text = "2"
        Me.ChkGarage2.UseVisualStyleBackColor = False
        '
        'ChkGarage3
        '
        Me.ChkGarage3.AutoSize = True
        Me.ChkGarage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkGarage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGarage3.Location = New System.Drawing.Point(90, 234)
        Me.ChkGarage3.Name = "ChkGarage3"
        Me.ChkGarage3.Size = New System.Drawing.Size(41, 20)
        Me.ChkGarage3.TabIndex = 79
        Me.ChkGarage3.Tag = "marcado"
        Me.ChkGarage3.Text = "3+"
        Me.ChkGarage3.UseVisualStyleBackColor = False
        '
        'ChkGarage1
        '
        Me.ChkGarage1.AutoSize = True
        Me.ChkGarage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkGarage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGarage1.Location = New System.Drawing.Point(12, 235)
        Me.ChkGarage1.Name = "ChkGarage1"
        Me.ChkGarage1.Size = New System.Drawing.Size(34, 20)
        Me.ChkGarage1.TabIndex = 78
        Me.ChkGarage1.Tag = "marcado"
        Me.ChkGarage1.Text = "1"
        Me.ChkGarage1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Garage"
        '
        'BtnAplicar
        '
        Me.BtnAplicar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAplicar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnAplicar.FlatAppearance.BorderSize = 0
        Me.BtnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAplicar.Location = New System.Drawing.Point(129, 11)
        Me.BtnAplicar.Name = "BtnAplicar"
        Me.BtnAplicar.Size = New System.Drawing.Size(67, 24)
        Me.BtnAplicar.TabIndex = 76
        Me.BtnAplicar.Text = "Aplicar"
        Me.BtnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAplicar.UseVisualStyleBackColor = False
        '
        'CbxCondicion
        '
        Me.CbxCondicion.BackColor = System.Drawing.Color.White
        Me.CbxCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCondicion.FormattingEnabled = True
        Me.CbxCondicion.Items.AddRange(New Object() {"(Sin especificar)", "Excelente estado", "Buen estado", "Construcción", "Requiere mantenimiento", "A estrenar"})
        Me.CbxCondicion.Location = New System.Drawing.Point(12, 651)
        Me.CbxCondicion.Name = "CbxCondicion"
        Me.CbxCondicion.Size = New System.Drawing.Size(185, 24)
        Me.CbxCondicion.TabIndex = 75
        Me.CbxCondicion.Tag = "cbx"
        '
        'LblCondicion
        '
        Me.LblCondicion.AutoSize = True
        Me.LblCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCondicion.Location = New System.Drawing.Point(9, 631)
        Me.LblCondicion.Name = "LblCondicion"
        Me.LblCondicion.Size = New System.Drawing.Size(77, 16)
        Me.LblCondicion.TabIndex = 74
        Me.LblCondicion.Text = "Condición"
        '
        'TxtHastaA
        '
        Me.TxtHastaA.BackColor = System.Drawing.Color.Azure
        Me.TxtHastaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHastaA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHastaA.ForeColor = System.Drawing.Color.Gray
        Me.TxtHastaA.Location = New System.Drawing.Point(115, 598)
        Me.TxtHastaA.Name = "TxtHastaA"
        Me.TxtHastaA.Size = New System.Drawing.Size(82, 22)
        Me.TxtHastaA.TabIndex = 73
        Me.TxtHastaA.Tag = "hasta"
        Me.TxtHastaA.Text = "Hasta"
        '
        'TxtDesdeA
        '
        Me.TxtDesdeA.BackColor = System.Drawing.Color.Azure
        Me.TxtDesdeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesdeA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesdeA.ForeColor = System.Drawing.Color.Gray
        Me.TxtDesdeA.Location = New System.Drawing.Point(11, 598)
        Me.TxtDesdeA.Name = "TxtDesdeA"
        Me.TxtDesdeA.Size = New System.Drawing.Size(77, 22)
        Me.TxtDesdeA.TabIndex = 72
        Me.TxtDesdeA.Tag = "desde"
        Me.TxtDesdeA.Text = "Desde"
        '
        'TxtHastaTC
        '
        Me.TxtHastaTC.BackColor = System.Drawing.Color.Azure
        Me.TxtHastaTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHastaTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHastaTC.ForeColor = System.Drawing.Color.Gray
        Me.TxtHastaTC.Location = New System.Drawing.Point(115, 550)
        Me.TxtHastaTC.Name = "TxtHastaTC"
        Me.TxtHastaTC.Size = New System.Drawing.Size(82, 22)
        Me.TxtHastaTC.TabIndex = 71
        Me.TxtHastaTC.Tag = "hasta"
        Me.TxtHastaTC.Text = "Hasta"
        '
        'TxtDesdeTC
        '
        Me.TxtDesdeTC.BackColor = System.Drawing.Color.Azure
        Me.TxtDesdeTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesdeTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesdeTC.ForeColor = System.Drawing.Color.Gray
        Me.TxtDesdeTC.Location = New System.Drawing.Point(10, 550)
        Me.TxtDesdeTC.Name = "TxtDesdeTC"
        Me.TxtDesdeTC.Size = New System.Drawing.Size(77, 22)
        Me.TxtDesdeTC.TabIndex = 70
        Me.TxtDesdeTC.Tag = "desde"
        Me.TxtDesdeTC.Text = "Desde"
        '
        'LblAntiguedad
        '
        Me.LblAntiguedad.AutoSize = True
        Me.LblAntiguedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAntiguedad.Location = New System.Drawing.Point(8, 578)
        Me.LblAntiguedad.Name = "LblAntiguedad"
        Me.LblAntiguedad.Size = New System.Drawing.Size(135, 16)
        Me.LblAntiguedad.TabIndex = 67
        Me.LblAntiguedad.Text = "Antigüedad (años)"
        '
        'LblTerrenoCub
        '
        Me.LblTerrenoCub.AutoSize = True
        Me.LblTerrenoCub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTerrenoCub.Location = New System.Drawing.Point(8, 530)
        Me.LblTerrenoCub.Name = "LblTerrenoCub"
        Me.LblTerrenoCub.Size = New System.Drawing.Size(123, 16)
        Me.LblTerrenoCub.TabIndex = 64
        Me.LblTerrenoCub.Text = "Terreno cubierto"
        '
        'TxtHastaT
        '
        Me.TxtHastaT.BackColor = System.Drawing.Color.Azure
        Me.TxtHastaT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHastaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHastaT.ForeColor = System.Drawing.Color.Gray
        Me.TxtHastaT.Location = New System.Drawing.Point(115, 502)
        Me.TxtHastaT.Name = "TxtHastaT"
        Me.TxtHastaT.Size = New System.Drawing.Size(82, 22)
        Me.TxtHastaT.TabIndex = 63
        Me.TxtHastaT.Tag = "hasta"
        Me.TxtHastaT.Text = "Hasta"
        '
        'TxtDesdeT
        '
        Me.TxtDesdeT.BackColor = System.Drawing.Color.Azure
        Me.TxtDesdeT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesdeT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesdeT.ForeColor = System.Drawing.Color.Gray
        Me.TxtDesdeT.Location = New System.Drawing.Point(11, 502)
        Me.TxtDesdeT.Name = "TxtDesdeT"
        Me.TxtDesdeT.Size = New System.Drawing.Size(77, 22)
        Me.TxtDesdeT.TabIndex = 62
        Me.TxtDesdeT.Tag = "desde"
        Me.TxtDesdeT.Text = "Desde"
        '
        'LblTerreno
        '
        Me.LblTerreno.AutoSize = True
        Me.LblTerreno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTerreno.Location = New System.Drawing.Point(8, 480)
        Me.LblTerreno.Name = "LblTerreno"
        Me.LblTerreno.Size = New System.Drawing.Size(94, 16)
        Me.LblTerreno.TabIndex = 61
        Me.LblTerreno.Text = "Terreno (m²)"
        '
        'RbnAlquiler
        '
        Me.RbnAlquiler.AutoSize = True
        Me.RbnAlquiler.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RbnAlquiler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnAlquiler.Location = New System.Drawing.Point(77, 427)
        Me.RbnAlquiler.Name = "RbnAlquiler"
        Me.RbnAlquiler.Size = New System.Drawing.Size(71, 20)
        Me.RbnAlquiler.TabIndex = 60
        Me.RbnAlquiler.TabStop = True
        Me.RbnAlquiler.Tag = "marcado"
        Me.RbnAlquiler.Text = "Alquiler"
        Me.RbnAlquiler.UseVisualStyleBackColor = False
        '
        'RbnCompra
        '
        Me.RbnCompra.AutoSize = True
        Me.RbnCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RbnCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbnCompra.Location = New System.Drawing.Point(10, 427)
        Me.RbnCompra.Name = "RbnCompra"
        Me.RbnCompra.Size = New System.Drawing.Size(61, 20)
        Me.RbnCompra.TabIndex = 59
        Me.RbnCompra.TabStop = True
        Me.RbnCompra.Tag = "marcado"
        Me.RbnCompra.Text = "Venta"
        Me.RbnCompra.UseVisualStyleBackColor = False
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(8, 408)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(57, 16)
        Me.LblEstado.TabIndex = 58
        Me.LblEstado.Text = "Estado"
        '
        'CbxBarrio
        '
        Me.CbxBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxBarrio.FormattingEnabled = True
        Me.CbxBarrio.Items.AddRange(New Object() {"(Sin especificar)"})
        Me.CbxBarrio.Location = New System.Drawing.Point(11, 376)
        Me.CbxBarrio.Name = "CbxBarrio"
        Me.CbxBarrio.Size = New System.Drawing.Size(186, 24)
        Me.CbxBarrio.TabIndex = 57
        Me.CbxBarrio.Tag = "cbx"
        '
        'CbxCiudad
        '
        Me.CbxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCiudad.FormattingEnabled = True
        Me.CbxCiudad.Items.AddRange(New Object() {"(Sin especificar)"})
        Me.CbxCiudad.Location = New System.Drawing.Point(10, 326)
        Me.CbxCiudad.Name = "CbxCiudad"
        Me.CbxCiudad.Size = New System.Drawing.Size(187, 24)
        Me.CbxCiudad.TabIndex = 56
        Me.CbxCiudad.Tag = "cbx"
        '
        'CbxDepartamento
        '
        Me.CbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDepartamento.FormattingEnabled = True
        Me.CbxDepartamento.Items.AddRange(New Object() {"(Sin especificar)"})
        Me.CbxDepartamento.Location = New System.Drawing.Point(11, 277)
        Me.CbxDepartamento.Name = "CbxDepartamento"
        Me.CbxDepartamento.Size = New System.Drawing.Size(186, 24)
        Me.CbxDepartamento.TabIndex = 55
        Me.CbxDepartamento.Tag = "cbx"
        '
        'LblBarrio
        '
        Me.LblBarrio.AutoSize = True
        Me.LblBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarrio.Location = New System.Drawing.Point(8, 357)
        Me.LblBarrio.Name = "LblBarrio"
        Me.LblBarrio.Size = New System.Drawing.Size(50, 16)
        Me.LblBarrio.TabIndex = 54
        Me.LblBarrio.Text = "Barrio"
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.Location = New System.Drawing.Point(8, 307)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(57, 16)
        Me.LblCiudad.TabIndex = 53
        Me.LblCiudad.Text = "Ciudad"
        '
        'LblDepartamento
        '
        Me.LblDepartamento.AutoSize = True
        Me.LblDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepartamento.Location = New System.Drawing.Point(8, 258)
        Me.LblDepartamento.Name = "LblDepartamento"
        Me.LblDepartamento.Size = New System.Drawing.Size(106, 16)
        Me.LblDepartamento.TabIndex = 52
        Me.LblDepartamento.Text = "Departamento"
        '
        'ChkBaños2
        '
        Me.ChkBaños2.AutoSize = True
        Me.ChkBaños2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkBaños2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBaños2.Location = New System.Drawing.Point(50, 191)
        Me.ChkBaños2.Name = "ChkBaños2"
        Me.ChkBaños2.Size = New System.Drawing.Size(34, 20)
        Me.ChkBaños2.TabIndex = 50
        Me.ChkBaños2.Tag = "marcado"
        Me.ChkBaños2.Text = "2"
        Me.ChkBaños2.UseVisualStyleBackColor = False
        '
        'ChkBaños3
        '
        Me.ChkBaños3.AutoSize = True
        Me.ChkBaños3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkBaños3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBaños3.Location = New System.Drawing.Point(89, 190)
        Me.ChkBaños3.Name = "ChkBaños3"
        Me.ChkBaños3.Size = New System.Drawing.Size(41, 20)
        Me.ChkBaños3.TabIndex = 49
        Me.ChkBaños3.Tag = "marcado"
        Me.ChkBaños3.Text = "3+"
        Me.ChkBaños3.UseVisualStyleBackColor = False
        '
        'ChkBaños1
        '
        Me.ChkBaños1.AutoSize = True
        Me.ChkBaños1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkBaños1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBaños1.Location = New System.Drawing.Point(11, 191)
        Me.ChkBaños1.Name = "ChkBaños1"
        Me.ChkBaños1.Size = New System.Drawing.Size(34, 20)
        Me.ChkBaños1.TabIndex = 46
        Me.ChkBaños1.Tag = "marcado"
        Me.ChkBaños1.Text = "1"
        Me.ChkBaños1.UseVisualStyleBackColor = False
        '
        'ChkHab2
        '
        Me.ChkHab2.AutoSize = True
        Me.ChkHab2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkHab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHab2.Location = New System.Drawing.Point(49, 145)
        Me.ChkHab2.Name = "ChkHab2"
        Me.ChkHab2.Size = New System.Drawing.Size(34, 20)
        Me.ChkHab2.TabIndex = 45
        Me.ChkHab2.Tag = "marcado"
        Me.ChkHab2.Text = "2"
        Me.ChkHab2.UseVisualStyleBackColor = False
        '
        'ChkHab3
        '
        Me.ChkHab3.AutoSize = True
        Me.ChkHab3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkHab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHab3.Location = New System.Drawing.Point(88, 145)
        Me.ChkHab3.Name = "ChkHab3"
        Me.ChkHab3.Size = New System.Drawing.Size(34, 20)
        Me.ChkHab3.TabIndex = 44
        Me.ChkHab3.Tag = "marcado"
        Me.ChkHab3.Text = "3"
        Me.ChkHab3.UseVisualStyleBackColor = False
        '
        'ChkHab4
        '
        Me.ChkHab4.AutoSize = True
        Me.ChkHab4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkHab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHab4.Location = New System.Drawing.Point(127, 145)
        Me.ChkHab4.Name = "ChkHab4"
        Me.ChkHab4.Size = New System.Drawing.Size(34, 20)
        Me.ChkHab4.TabIndex = 43
        Me.ChkHab4.Tag = "marcado"
        Me.ChkHab4.Text = "4"
        Me.ChkHab4.UseVisualStyleBackColor = False
        '
        'ChkHab5
        '
        Me.ChkHab5.AutoSize = True
        Me.ChkHab5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkHab5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHab5.Location = New System.Drawing.Point(165, 145)
        Me.ChkHab5.Name = "ChkHab5"
        Me.ChkHab5.Size = New System.Drawing.Size(41, 20)
        Me.ChkHab5.TabIndex = 42
        Me.ChkHab5.Tag = "marcado"
        Me.ChkHab5.Text = "5+"
        Me.ChkHab5.UseVisualStyleBackColor = False
        '
        'ChkHab1
        '
        Me.ChkHab1.AutoSize = True
        Me.ChkHab1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ChkHab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHab1.Location = New System.Drawing.Point(11, 145)
        Me.ChkHab1.Name = "ChkHab1"
        Me.ChkHab1.Size = New System.Drawing.Size(34, 20)
        Me.ChkHab1.TabIndex = 41
        Me.ChkHab1.Tag = "marcado"
        Me.ChkHab1.Text = "1"
        Me.ChkHab1.UseVisualStyleBackColor = False
        '
        'LblBaños
        '
        Me.LblBaños.AutoSize = True
        Me.LblBaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBaños.Location = New System.Drawing.Point(8, 171)
        Me.LblBaños.Name = "LblBaños"
        Me.LblBaños.Size = New System.Drawing.Size(52, 16)
        Me.LblBaños.TabIndex = 40
        Me.LblBaños.Text = "Baños"
        '
        'LblHabitaciones
        '
        Me.LblHabitaciones.AutoSize = True
        Me.LblHabitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHabitaciones.Location = New System.Drawing.Point(8, 126)
        Me.LblHabitaciones.Name = "LblHabitaciones"
        Me.LblHabitaciones.Size = New System.Drawing.Size(100, 16)
        Me.LblHabitaciones.TabIndex = 33
        Me.LblHabitaciones.Text = "Habitaciones"
        '
        'CbxTipo
        '
        Me.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTipo.FormattingEnabled = True
        Me.CbxTipo.Items.AddRange(New Object() {"(Sin especificar)", "Apartamento", "Edificio", "Local comercial", "Terreno", "Casa"})
        Me.CbxTipo.Location = New System.Drawing.Point(54, 93)
        Me.CbxTipo.Name = "CbxTipo"
        Me.CbxTipo.Size = New System.Drawing.Size(143, 24)
        Me.CbxTipo.TabIndex = 32
        Me.CbxTipo.Tag = "cbx"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.Location = New System.Drawing.Point(8, 96)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(40, 16)
        Me.LblTipo.TabIndex = 31
        Me.LblTipo.Text = "Tipo"
        '
        'TxtHastaP
        '
        Me.TxtHastaP.BackColor = System.Drawing.Color.Azure
        Me.TxtHastaP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHastaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHastaP.ForeColor = System.Drawing.Color.Gray
        Me.TxtHastaP.Location = New System.Drawing.Point(110, 60)
        Me.TxtHastaP.Name = "TxtHastaP"
        Me.TxtHastaP.Size = New System.Drawing.Size(87, 22)
        Me.TxtHastaP.TabIndex = 30
        Me.TxtHastaP.Tag = "hasta"
        Me.TxtHastaP.Text = "Hasta"
        '
        'TxtDesdeP
        '
        Me.TxtDesdeP.BackColor = System.Drawing.Color.Azure
        Me.TxtDesdeP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesdeP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesdeP.ForeColor = System.Drawing.Color.Gray
        Me.TxtDesdeP.Location = New System.Drawing.Point(11, 60)
        Me.TxtDesdeP.Name = "TxtDesdeP"
        Me.TxtDesdeP.Size = New System.Drawing.Size(77, 22)
        Me.TxtDesdeP.TabIndex = 29
        Me.TxtDesdeP.Tag = "desde"
        Me.TxtDesdeP.Text = "Desde"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.Location = New System.Drawing.Point(8, 40)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(53, 16)
        Me.LblPrecio.TabIndex = 28
        Me.LblPrecio.Text = "Precio"
        '
        'PnlOrdenar_Buscar
        '
        Me.PnlOrdenar_Buscar.BackColor = System.Drawing.Color.Azure
        Me.PnlOrdenar_Buscar.Controls.Add(Me.BtnBuscar)
        Me.PnlOrdenar_Buscar.Controls.Add(Me.TxtBuscar)
        Me.PnlOrdenar_Buscar.Controls.Add(Me.BtnOrdenarPrecio)
        Me.PnlOrdenar_Buscar.Controls.Add(Me.LblOrdenar)
        Me.PnlOrdenar_Buscar.Location = New System.Drawing.Point(240, 33)
        Me.PnlOrdenar_Buscar.Name = "PnlOrdenar_Buscar"
        Me.PnlOrdenar_Buscar.Size = New System.Drawing.Size(732, 30)
        Me.PnlOrdenar_Buscar.TabIndex = 28
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBuscar.Location = New System.Drawing.Point(313, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(20, 20)
        Me.BtnBuscar.TabIndex = 21
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.Azure
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.Gray
        Me.TxtBuscar.Location = New System.Drawing.Point(5, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(302, 22)
        Me.TxtBuscar.TabIndex = 2
        Me.TxtBuscar.Text = "Buscar por ID"
        '
        'BtnOrdenarPrecio
        '
        Me.BtnOrdenarPrecio.BackColor = System.Drawing.Color.Transparent
        Me.BtnOrdenarPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOrdenarPrecio.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnOrdenarPrecio.FlatAppearance.BorderSize = 0
        Me.BtnOrdenarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOrdenarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrdenarPrecio.Location = New System.Drawing.Point(652, 4)
        Me.BtnOrdenarPrecio.Name = "BtnOrdenarPrecio"
        Me.BtnOrdenarPrecio.Size = New System.Drawing.Size(61, 24)
        Me.BtnOrdenarPrecio.TabIndex = 1
        Me.BtnOrdenarPrecio.Text = "Precio"
        Me.BtnOrdenarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOrdenarPrecio.UseVisualStyleBackColor = False
        '
        'LblOrdenar
        '
        Me.LblOrdenar.AutoSize = True
        Me.LblOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrdenar.Location = New System.Drawing.Point(555, 8)
        Me.LblOrdenar.Name = "LblOrdenar"
        Me.LblOrdenar.Size = New System.Drawing.Size(91, 16)
        Me.LblOrdenar.TabIndex = 0
        Me.LblOrdenar.Text = "Ordenar por"
        '
        'PnlCasas
        '
        Me.PnlCasas.BackColor = System.Drawing.Color.Azure
        Me.PnlCasas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCasas.Controls.Add(Me.PnlCasa5)
        Me.PnlCasas.Controls.Add(Me.PnlCasa6)
        Me.PnlCasas.Controls.Add(Me.PnlCasa3)
        Me.PnlCasas.Controls.Add(Me.PnlCasa2)
        Me.PnlCasas.Controls.Add(Me.PnlCasa4)
        Me.PnlCasas.Controls.Add(Me.PnlCasa1)
        Me.PnlCasas.Controls.Add(Me.PbxCasa6)
        Me.PnlCasas.Controls.Add(Me.PbxCasa5)
        Me.PnlCasas.Controls.Add(Me.PbxCasa4)
        Me.PnlCasas.Controls.Add(Me.PbxCasa3)
        Me.PnlCasas.Controls.Add(Me.PbxCasa2)
        Me.PnlCasas.Controls.Add(Me.PbxCasa1)
        Me.PnlCasas.Controls.Add(Me.BtnPagSiguiente)
        Me.PnlCasas.Controls.Add(Me.BtnPagAnterior)
        Me.PnlCasas.Location = New System.Drawing.Point(240, 73)
        Me.PnlCasas.Name = "PnlCasas"
        Me.PnlCasas.Size = New System.Drawing.Size(732, 573)
        Me.PnlCasas.TabIndex = 27
        '
        'PnlCasa5
        '
        Me.PnlCasa5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlCasa5.Controls.Add(Me.LblEstado5)
        Me.PnlCasa5.Controls.Add(Me.LblPrecio5)
        Me.PnlCasa5.Controls.Add(Me.LblTipo5)
        Me.PnlCasa5.Location = New System.Drawing.Point(257, 367)
        Me.PnlCasa5.Name = "PnlCasa5"
        Me.PnlCasa5.Size = New System.Drawing.Size(216, 115)
        Me.PnlCasa5.TabIndex = 32
        Me.PnlCasa5.Visible = False
        '
        'LblEstado5
        '
        Me.LblEstado5.AutoSize = True
        Me.LblEstado5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblEstado5.Location = New System.Drawing.Point(155, 87)
        Me.LblEstado5.Name = "LblEstado5"
        Me.LblEstado5.Size = New System.Drawing.Size(55, 16)
        Me.LblEstado5.TabIndex = 8
        Me.LblEstado5.Text = "Label7"
        '
        'LblPrecio5
        '
        Me.LblPrecio5.AutoSize = True
        Me.LblPrecio5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio5.Location = New System.Drawing.Point(3, 14)
        Me.LblPrecio5.Name = "LblPrecio5"
        Me.LblPrecio5.Size = New System.Drawing.Size(55, 16)
        Me.LblPrecio5.TabIndex = 2
        Me.LblPrecio5.Text = "Label3"
        '
        'LblTipo5
        '
        Me.LblTipo5.AutoSize = True
        Me.LblTipo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblTipo5.Location = New System.Drawing.Point(3, 84)
        Me.LblTipo5.Name = "LblTipo5"
        Me.LblTipo5.Size = New System.Drawing.Size(55, 16)
        Me.LblTipo5.TabIndex = 7
        Me.LblTipo5.Text = "Label8"
        '
        'PnlCasa6
        '
        Me.PnlCasa6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlCasa6.Controls.Add(Me.LblEstado6)
        Me.PnlCasa6.Controls.Add(Me.LblPrecio6)
        Me.PnlCasa6.Controls.Add(Me.LblTipo6)
        Me.PnlCasa6.Location = New System.Drawing.Point(494, 367)
        Me.PnlCasa6.Name = "PnlCasa6"
        Me.PnlCasa6.Size = New System.Drawing.Size(216, 115)
        Me.PnlCasa6.TabIndex = 33
        Me.PnlCasa6.Visible = False
        '
        'LblEstado6
        '
        Me.LblEstado6.AutoSize = True
        Me.LblEstado6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblEstado6.Location = New System.Drawing.Point(147, 90)
        Me.LblEstado6.Name = "LblEstado6"
        Me.LblEstado6.Size = New System.Drawing.Size(63, 16)
        Me.LblEstado6.TabIndex = 12
        Me.LblEstado6.Text = "Label11"
        '
        'LblPrecio6
        '
        Me.LblPrecio6.AutoSize = True
        Me.LblPrecio6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio6.Location = New System.Drawing.Point(3, 14)
        Me.LblPrecio6.Name = "LblPrecio6"
        Me.LblPrecio6.Size = New System.Drawing.Size(55, 16)
        Me.LblPrecio6.TabIndex = 4
        Me.LblPrecio6.Text = "Label5"
        '
        'LblTipo6
        '
        Me.LblTipo6.AutoSize = True
        Me.LblTipo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblTipo6.Location = New System.Drawing.Point(3, 90)
        Me.LblTipo6.Name = "LblTipo6"
        Me.LblTipo6.Size = New System.Drawing.Size(63, 16)
        Me.LblTipo6.TabIndex = 11
        Me.LblTipo6.Text = "Label12"
        '
        'PnlCasa3
        '
        Me.PnlCasa3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlCasa3.Controls.Add(Me.LblEstado3)
        Me.PnlCasa3.Controls.Add(Me.LblPrecio3)
        Me.PnlCasa3.Controls.Add(Me.LblTipo3)
        Me.PnlCasa3.Location = New System.Drawing.Point(494, 125)
        Me.PnlCasa3.Name = "PnlCasa3"
        Me.PnlCasa3.Size = New System.Drawing.Size(216, 115)
        Me.PnlCasa3.TabIndex = 30
        Me.PnlCasa3.Visible = False
        '
        'LblEstado3
        '
        Me.LblEstado3.AutoSize = True
        Me.LblEstado3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblEstado3.Location = New System.Drawing.Point(147, 83)
        Me.LblEstado3.Name = "LblEstado3"
        Me.LblEstado3.Size = New System.Drawing.Size(55, 16)
        Me.LblEstado3.TabIndex = 6
        Me.LblEstado3.Text = "Label5"
        '
        'LblPrecio3
        '
        Me.LblPrecio3.AutoSize = True
        Me.LblPrecio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio3.Location = New System.Drawing.Point(3, 16)
        Me.LblPrecio3.Name = "LblPrecio3"
        Me.LblPrecio3.Size = New System.Drawing.Size(55, 16)
        Me.LblPrecio3.TabIndex = 2
        Me.LblPrecio3.Text = "Label2"
        '
        'LblTipo3
        '
        Me.LblTipo3.AutoSize = True
        Me.LblTipo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblTipo3.Location = New System.Drawing.Point(3, 80)
        Me.LblTipo3.Name = "LblTipo3"
        Me.LblTipo3.Size = New System.Drawing.Size(55, 16)
        Me.LblTipo3.TabIndex = 5
        Me.LblTipo3.Text = "Label6"
        '
        'PnlCasa2
        '
        Me.PnlCasa2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlCasa2.Controls.Add(Me.LblEstado2)
        Me.PnlCasa2.Controls.Add(Me.LblTipo2)
        Me.PnlCasa2.Controls.Add(Me.LblPrecio2)
        Me.PnlCasa2.Location = New System.Drawing.Point(257, 125)
        Me.PnlCasa2.Name = "PnlCasa2"
        Me.PnlCasa2.Size = New System.Drawing.Size(216, 115)
        Me.PnlCasa2.TabIndex = 29
        Me.PnlCasa2.Visible = False
        '
        'LblEstado2
        '
        Me.LblEstado2.AutoSize = True
        Me.LblEstado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblEstado2.Location = New System.Drawing.Point(155, 83)
        Me.LblEstado2.Name = "LblEstado2"
        Me.LblEstado2.Size = New System.Drawing.Size(55, 16)
        Me.LblEstado2.TabIndex = 4
        Me.LblEstado2.Text = "Label3"
        '
        'LblTipo2
        '
        Me.LblTipo2.AutoSize = True
        Me.LblTipo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblTipo2.Location = New System.Drawing.Point(3, 80)
        Me.LblTipo2.Name = "LblTipo2"
        Me.LblTipo2.Size = New System.Drawing.Size(55, 16)
        Me.LblTipo2.TabIndex = 3
        Me.LblTipo2.Text = "Label4"
        '
        'LblPrecio2
        '
        Me.LblPrecio2.AutoSize = True
        Me.LblPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio2.Location = New System.Drawing.Point(3, 16)
        Me.LblPrecio2.Name = "LblPrecio2"
        Me.LblPrecio2.Size = New System.Drawing.Size(55, 16)
        Me.LblPrecio2.TabIndex = 1
        Me.LblPrecio2.Text = "Label1"
        '
        'PnlCasa4
        '
        Me.PnlCasa4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlCasa4.Controls.Add(Me.LblEstado4)
        Me.PnlCasa4.Controls.Add(Me.LblPrecio4)
        Me.PnlCasa4.Controls.Add(Me.LblTipo4)
        Me.PnlCasa4.Location = New System.Drawing.Point(19, 367)
        Me.PnlCasa4.Name = "PnlCasa4"
        Me.PnlCasa4.Size = New System.Drawing.Size(216, 115)
        Me.PnlCasa4.TabIndex = 31
        Me.PnlCasa4.Visible = False
        '
        'LblEstado4
        '
        Me.LblEstado4.AutoSize = True
        Me.LblEstado4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblEstado4.Location = New System.Drawing.Point(155, 87)
        Me.LblEstado4.Name = "LblEstado4"
        Me.LblEstado4.Size = New System.Drawing.Size(55, 16)
        Me.LblEstado4.TabIndex = 8
        Me.LblEstado4.Text = "Label7"
        '
        'LblPrecio4
        '
        Me.LblPrecio4.AutoSize = True
        Me.LblPrecio4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio4.Location = New System.Drawing.Point(3, 14)
        Me.LblPrecio4.Name = "LblPrecio4"
        Me.LblPrecio4.Size = New System.Drawing.Size(55, 16)
        Me.LblPrecio4.TabIndex = 2
        Me.LblPrecio4.Text = "Label3"
        '
        'LblTipo4
        '
        Me.LblTipo4.AutoSize = True
        Me.LblTipo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblTipo4.Location = New System.Drawing.Point(3, 84)
        Me.LblTipo4.Name = "LblTipo4"
        Me.LblTipo4.Size = New System.Drawing.Size(55, 16)
        Me.LblTipo4.TabIndex = 7
        Me.LblTipo4.Text = "Label8"
        '
        'PnlCasa1
        '
        Me.PnlCasa1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlCasa1.Controls.Add(Me.LblEstado1)
        Me.PnlCasa1.Controls.Add(Me.LblTipo1)
        Me.PnlCasa1.Controls.Add(Me.LblPrecio1)
        Me.PnlCasa1.Location = New System.Drawing.Point(19, 125)
        Me.PnlCasa1.Name = "PnlCasa1"
        Me.PnlCasa1.Size = New System.Drawing.Size(216, 115)
        Me.PnlCasa1.TabIndex = 28
        Me.PnlCasa1.Visible = False
        '
        'LblEstado1
        '
        Me.LblEstado1.AutoSize = True
        Me.LblEstado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblEstado1.Location = New System.Drawing.Point(155, 83)
        Me.LblEstado1.Name = "LblEstado1"
        Me.LblEstado1.Size = New System.Drawing.Size(55, 16)
        Me.LblEstado1.TabIndex = 2
        Me.LblEstado1.Text = "Label2"
        '
        'LblTipo1
        '
        Me.LblTipo1.AutoSize = True
        Me.LblTipo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblTipo1.Location = New System.Drawing.Point(3, 80)
        Me.LblTipo1.Name = "LblTipo1"
        Me.LblTipo1.Size = New System.Drawing.Size(55, 16)
        Me.LblTipo1.TabIndex = 1
        Me.LblTipo1.Text = "Label1"
        '
        'LblPrecio1
        '
        Me.LblPrecio1.AutoSize = True
        Me.LblPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio1.Location = New System.Drawing.Point(3, 16)
        Me.LblPrecio1.Name = "LblPrecio1"
        Me.LblPrecio1.Size = New System.Drawing.Size(55, 16)
        Me.LblPrecio1.TabIndex = 0
        Me.LblPrecio1.Text = "Label1"
        '
        'PbxCasa6
        '
        Me.PbxCasa6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxCasa6.Location = New System.Drawing.Point(487, 260)
        Me.PbxCasa6.Name = "PbxCasa6"
        Me.PbxCasa6.Size = New System.Drawing.Size(230, 230)
        Me.PbxCasa6.TabIndex = 27
        Me.PbxCasa6.TabStop = False
        '
        'PbxCasa5
        '
        Me.PbxCasa5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxCasa5.Location = New System.Drawing.Point(250, 260)
        Me.PbxCasa5.Name = "PbxCasa5"
        Me.PbxCasa5.Size = New System.Drawing.Size(230, 230)
        Me.PbxCasa5.TabIndex = 26
        Me.PbxCasa5.TabStop = False
        '
        'PbxCasa4
        '
        Me.PbxCasa4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxCasa4.Location = New System.Drawing.Point(12, 260)
        Me.PbxCasa4.Name = "PbxCasa4"
        Me.PbxCasa4.Size = New System.Drawing.Size(230, 230)
        Me.PbxCasa4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxCasa4.TabIndex = 25
        Me.PbxCasa4.TabStop = False
        '
        'PbxCasa3
        '
        Me.PbxCasa3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxCasa3.Location = New System.Drawing.Point(487, 18)
        Me.PbxCasa3.Name = "PbxCasa3"
        Me.PbxCasa3.Size = New System.Drawing.Size(230, 230)
        Me.PbxCasa3.TabIndex = 24
        Me.PbxCasa3.TabStop = False
        '
        'PbxCasa2
        '
        Me.PbxCasa2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxCasa2.Location = New System.Drawing.Point(250, 18)
        Me.PbxCasa2.Name = "PbxCasa2"
        Me.PbxCasa2.Size = New System.Drawing.Size(230, 230)
        Me.PbxCasa2.TabIndex = 23
        Me.PbxCasa2.TabStop = False
        '
        'PbxCasa1
        '
        Me.PbxCasa1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxCasa1.Location = New System.Drawing.Point(12, 18)
        Me.PbxCasa1.Name = "PbxCasa1"
        Me.PbxCasa1.Size = New System.Drawing.Size(230, 230)
        Me.PbxCasa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxCasa1.TabIndex = 21
        Me.PbxCasa1.TabStop = False
        '
        'BtnPagSiguiente
        '
        Me.BtnPagSiguiente.BackColor = System.Drawing.Color.Transparent
        Me.BtnPagSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPagSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnPagSiguiente.FlatAppearance.BorderSize = 0
        Me.BtnPagSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnPagSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnPagSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagSiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnPagSiguiente.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonAdelanteTemaAzul
        Me.BtnPagSiguiente.Location = New System.Drawing.Point(627, 510)
        Me.BtnPagSiguiente.Name = "BtnPagSiguiente"
        Me.BtnPagSiguiente.Size = New System.Drawing.Size(90, 45)
        Me.BtnPagSiguiente.TabIndex = 20
        Me.BtnPagSiguiente.Tag = "btnadelante"
        Me.BtnPagSiguiente.UseVisualStyleBackColor = False
        '
        'BtnPagAnterior
        '
        Me.BtnPagAnterior.BackColor = System.Drawing.Color.Transparent
        Me.BtnPagAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPagAnterior.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.BtnPagAnterior.FlatAppearance.BorderSize = 0
        Me.BtnPagAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.BtnPagAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.BtnPagAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagAnterior.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnPagAnterior.Image = Global.Proyecto_Inmobiliaria.My.Resources.Resources.BotonAtrasTemaAzul
        Me.BtnPagAnterior.Location = New System.Drawing.Point(12, 510)
        Me.BtnPagAnterior.Name = "BtnPagAnterior"
        Me.BtnPagAnterior.Size = New System.Drawing.Size(89, 45)
        Me.BtnPagAnterior.TabIndex = 19
        Me.BtnPagAnterior.Tag = "btnatras"
        Me.BtnPagAnterior.UseVisualStyleBackColor = False
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = Global.Proyecto_Inmobiliaria.My.Resources.Resources.FondoTemaAzul
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PnlFiltros)
        Me.Controls.Add(Me.PnlOrdenar_Buscar)
        Me.Controls.Add(Me.PnlCasas)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propuru"
        Me.PnlFiltros.ResumeLayout(False)
        Me.PnlFiltros.PerformLayout()
        Me.PnlOrdenar_Buscar.ResumeLayout(False)
        Me.PnlOrdenar_Buscar.PerformLayout()
        Me.PnlCasas.ResumeLayout(False)
        Me.PnlCasa5.ResumeLayout(False)
        Me.PnlCasa5.PerformLayout()
        Me.PnlCasa6.ResumeLayout(False)
        Me.PnlCasa6.PerformLayout()
        Me.PnlCasa3.ResumeLayout(False)
        Me.PnlCasa3.PerformLayout()
        Me.PnlCasa2.ResumeLayout(False)
        Me.PnlCasa2.PerformLayout()
        Me.PnlCasa4.ResumeLayout(False)
        Me.PnlCasa4.PerformLayout()
        Me.PnlCasa1.ResumeLayout(False)
        Me.PnlCasa1.PerformLayout()
        CType(Me.PbxCasa6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCasa5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCasa4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCasa3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCasa2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCasa1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlFiltros As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents rbnSinEspecificar As RadioButton
    Friend WithEvents ChkGarage2 As CheckBox
    Friend WithEvents ChkGarage3 As CheckBox
    Friend WithEvents ChkGarage1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAplicar As Button
    Friend WithEvents CbxCondicion As ComboBox
    Friend WithEvents LblCondicion As Label
    Friend WithEvents TxtHastaA As TextBox
    Friend WithEvents TxtDesdeA As TextBox
    Friend WithEvents TxtHastaTC As TextBox
    Friend WithEvents TxtDesdeTC As TextBox
    Friend WithEvents LblAntiguedad As Label
    Friend WithEvents LblTerrenoCub As Label
    Friend WithEvents TxtHastaT As TextBox
    Friend WithEvents TxtDesdeT As TextBox
    Friend WithEvents LblTerreno As Label
    Friend WithEvents RbnAlquiler As RadioButton
    Friend WithEvents RbnCompra As RadioButton
    Friend WithEvents LblEstado As Label
    Friend WithEvents CbxBarrio As ComboBox
    Friend WithEvents CbxCiudad As ComboBox
    Friend WithEvents CbxDepartamento As ComboBox
    Friend WithEvents LblBarrio As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents LblDepartamento As Label
    Friend WithEvents ChkBaños2 As CheckBox
    Friend WithEvents ChkBaños3 As CheckBox
    Friend WithEvents ChkBaños1 As CheckBox
    Friend WithEvents ChkHab2 As CheckBox
    Friend WithEvents ChkHab3 As CheckBox
    Friend WithEvents ChkHab4 As CheckBox
    Friend WithEvents ChkHab5 As CheckBox
    Friend WithEvents ChkHab1 As CheckBox
    Friend WithEvents LblBaños As Label
    Friend WithEvents LblHabitaciones As Label
    Friend WithEvents CbxTipo As ComboBox
    Friend WithEvents LblTipo As Label
    Friend WithEvents TxtHastaP As TextBox
    Friend WithEvents TxtDesdeP As TextBox
    Friend WithEvents LblPrecio As Label
    Friend WithEvents PnlOrdenar_Buscar As Panel
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnOrdenarPrecio As Button
    Friend WithEvents LblOrdenar As Label
    Friend WithEvents PnlCasas As Panel
    Friend WithEvents PnlCasa5 As Panel
    Friend WithEvents LblEstado5 As Label
    Friend WithEvents LblPrecio5 As Label
    Friend WithEvents LblTipo5 As Label
    Friend WithEvents PnlCasa6 As Panel
    Friend WithEvents LblEstado6 As Label
    Friend WithEvents LblPrecio6 As Label
    Friend WithEvents LblTipo6 As Label
    Friend WithEvents PnlCasa3 As Panel
    Friend WithEvents LblEstado3 As Label
    Friend WithEvents LblPrecio3 As Label
    Friend WithEvents LblTipo3 As Label
    Friend WithEvents PnlCasa2 As Panel
    Friend WithEvents LblEstado2 As Label
    Friend WithEvents LblTipo2 As Label
    Friend WithEvents LblPrecio2 As Label
    Friend WithEvents PnlCasa4 As Panel
    Friend WithEvents LblEstado4 As Label
    Friend WithEvents LblPrecio4 As Label
    Friend WithEvents LblTipo4 As Label
    Friend WithEvents PnlCasa1 As Panel
    Friend WithEvents LblEstado1 As Label
    Friend WithEvents LblTipo1 As Label
    Friend WithEvents LblPrecio1 As Label
    Friend WithEvents PbxCasa6 As PictureBox
    Friend WithEvents PbxCasa5 As PictureBox
    Friend WithEvents PbxCasa4 As PictureBox
    Friend WithEvents PbxCasa3 As PictureBox
    Friend WithEvents PbxCasa2 As PictureBox
    Friend WithEvents PbxCasa1 As PictureBox
    Friend WithEvents BtnPagSiguiente As Button
    Friend WithEvents BtnPagAnterior As Button
End Class
