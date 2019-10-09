Public Class FrmAgendar
    Dim qrgen As New MessagingToolkit.Barcode.BarcodeEncoder
    Shadows menu As New ClassMenu(Me)
    Public images As New ArrayList
    Dim image As Integer = 0
    Public arrayDias As New ArrayList
    Dim arrayEmpleadosID As New ArrayList
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Metodos.cambiarform(Me, FrmCliente)
    End Sub





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Metodos.buttonanimation(sender)
        Metodos.cambiarform(Me, FrmCliente)
    End Sub


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnAgendarse.Click
        Metodos.buttonanimation(sender)

        GbxDatos.Visible = True

        Me.TxtEmpleado.Visible = True

        Me.CbxEmpleado.Visible = True

    End Sub

    Private Sub FrmAgendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DTPFechaVisita.MinDate = Now.AddDays(1)
        Me.CbxHora.SelectedIndex = 0
        Me.DTPFechaVisita.CustomFormat = "yyyy-MM-dd"
        If Metodos.log Then
            menu.MnuStIUsuario.Text = "Cliente"
        Else
            menu.MnuStIUsuario.Text = "Bienvenido"
        End If

        Dim con As New BDCon
        Metodos.mantenertema(Me)

        Dim dato As New DataSet
        dato = con.consulta("select IDUsuarioP,Nombre from personal ,usuario, personas where IDUsuarioP=IDUsuario and usuario.CIPersona=personas.CIPersona", "personas")
        For a = 0 To dato.Tables(0).Rows.Count - 1
            CbxEmpleado.Items.Add(dato.Tables(0).Rows(a).Item(1))
            arrayEmpleadosID.Add(dato.Tables(0).Rows(a).Item(0))
        Next
        CbxEmpleado.SelectedIndex = Metodos.encargado
        Metodos.encargado = 0

        PbxImage.Image = images.Item(images.Count - 1)
        TxtPrecio.Text = "$" & TxtPrecio.Text
        If TxtDescripcion.Text.Equals("") Then
            TxtDescripcion.Text = "Sin descripción"
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If Metodos.log Then
            Dim conexion As New BDCon
            Dim repetido As New DataSet

            If CbxHora.Text <> "Sin especificar" Then

                repetido = conexion.consulta("select * from visita where IDUsuarioI=" & Metodos.usr & " and IDPropiedades=" & Me.TxtID.Text & " and Dia_Visita='" & DTPFechaVisita.Text & "' and Hora_Visita='" & Me.CbxHora.Text & "'", "visita")

                If repetido.Tables("visita").Rows.Count = 1 Then
                    MsgBox("Ya ha agendado una visita igual a esta.", vbInformation, "Atención")
                Else
                    conexion.manipularBD("insert into visita(IDUsuarioI,IDPropiedades,Dia_Visita,Hora_Visita,IDUsuarioP,Modificada,Cancelada) values (" & usr & "," & Me.TxtID.Text & ",'" & DTPFechaVisita.Text & "','" & Me.CbxHora.Text & "'," & arrayEmpleadosID.Item(CbxEmpleado.SelectedIndex) & ",0,0)")
                    FrmQR.Show()
                    Me.Enabled = False
                    GbxDatos.Visible = False

                End If
            Else
                MsgBox("Seleccione una hora de visita antes de agendarse")
            End If
        Else
            If MsgBox("Para agendarse debe tener una cuenta. ¿Desea ingresar su cuenta o crear una cuenta nueva?", vbInformation + MessageBoxButtons.YesNo, "Atención") = MsgBoxResult.Yes Then
                Metodos.idprop = Me.TxtID.Text
                Metodos.reg = True
                Metodos.encargado = Me.CbxEmpleado.SelectedIndex

                Metodos.cambiarform(Me, FrmLogin)
            End If
            GbxDatos.Visible = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If image >= images.Count - 1 Then
            image = 0
        Else
            image += 1
        End If
        PbxImage.Image = images(image)
    End Sub

    Private Sub BtnRegistrarse_Click(sender As Object, e As EventArgs) Handles BtnRegistrarse.Click
        If image <= 0 Then
            image = images.Count - 1
        Else
            image -= 1
        End If
        PbxImage.Image = images(image)
    End Sub

    Private Sub LblImg_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PnlPropiedad_Paint(sender As Object, e As PaintEventArgs) Handles PnlPropiedad.Paint

    End Sub

    Private Sub CbxEmpleado_TextChanged(sender As Object, e As EventArgs) Handles CbxEmpleado.TextChanged
        Dim dato As New DataSet
        Dim con As New BDCon
        dato.Clear()
        dato = con.consulta("select distinct dias.Dia from dias, agenda where dias.IDDia=agenda.Dia and IDUsuarioP=" & arrayEmpleadosID.Item(CbxEmpleado.SelectedIndex), "agente_dias")
        Dim diasDisponiblesS As String = ""


        For a = 0 To dato.Tables("agente_dias").Rows.Count - 1
            If a = dato.Tables("agente_dias").Rows.Count - 1 Then
                arrayDias.Add(dato.Tables("agente_dias").Rows(a).Item(0))
                diasDisponiblesS += dato.Tables("agente_dias").Rows(a).Item(0)
            Else
                arrayDias.Add(dato.Tables("agente_dias").Rows(a).Item(0))
                diasDisponiblesS += dato.Tables("agente_dias").Rows(a).Item(0) & ", "
            End If

        Next

        Me.ToolTip1.SetToolTip(DTPFechaVisita, "Dias disponibles para el agente: " & diasDisponiblesS)
        Me.DTPFechaVisita_ValueChanged(sender, e)
    End Sub

    Private Sub CbxHora_Enter(sender As Object, e As EventArgs) Handles CbxHora.Enter
        If CbxHora.SelectedText = "Sin especificar" Then
            Dim con As New BDCon
            Dim data As New DataSet
            data = con.consulta("select Hora from agenda,dias where dias.IDDia=agenda.dia and dias.Dia='" & Metodos.diastring(Me.DTPFechaVisita.Value.DayOfWeek) & "' and agenda.IDUsuarioP=" & Me.arrayEmpleadosID.Item(CbxEmpleado.SelectedIndex) & "", "horas")
            If data.Tables("horas").Rows.Count = 0 Then
                CbxHora.Items.Clear()
                CbxHora.Items.Add("Sin especificar")
                CbxHora.SelectedIndex = 0
            Else

                CbxHora.Items.Clear()
                For a = 0 To data.Tables("horas").Rows.Count - 1
                    CbxHora.Items.Add(data.Tables("horas").Rows(a).Item(0))

                Next

                CbxHora.SelectedIndex = 0
            End If

        End If

    End Sub

    Private Sub DTPFechaVisita_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaVisita.ValueChanged
        Dim con As New BDCon

        Dim data As New DataSet
        If CbxEmpleado.Items.Count <> 0 Then

            data = con.consulta("select Hora from agenda,dias where dias.IDDia=agenda.dia and dias.Dia='" & Metodos.diastring(Me.DTPFechaVisita.Value.DayOfWeek) & "' and agenda.IDUsuarioP=" & Me.arrayEmpleadosID.Item(CbxEmpleado.SelectedIndex) & "", "horas")
            If data.Tables("horas").Rows.Count = 0 Then
                CbxHora.Items.Clear()
                CbxHora.Items.Add("Sin especificar")
                CbxHora.SelectedIndex = 0
            Else

                CbxHora.Items.Clear()
                For a = 0 To data.Tables("horas").Rows.Count - 1
                    CbxHora.Items.Add(data.Tables("horas").Rows(a).Item(0))

                Next

                CbxHora.SelectedIndex = 0
            End If
        End If
    End Sub


End Class