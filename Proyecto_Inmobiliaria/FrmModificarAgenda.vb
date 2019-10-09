Public Class FrmModificarAgenda

    Public arrayDias As New ArrayList
    Public idAgente As Integer

    Private Sub FrmModificarAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Metodos.mantenertema(Me)
        Me.DTPFechaNueva.MinDate = Now.AddDays(1)
        Me.DTPFechaNueva.CustomFormat = "yyyy-MM-dd"
        Me.Focus()
        Me.CbxHora.SelectedItem = CbxHora.Items(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Metodos.buttonanimation(sender)
        Me.Close()
        FrmAdmin.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Metodos.buttonanimation(sender)
        Dim validarDia As Boolean = False
        For Each dia As String In arrayDias
            If Metodos.diastring(Me.DTPFechaNueva.Value.DayOfWeek) = dia Then
                validarDia = True
            End If
        Next
        If CbxHora.Text <> "Sin especificar" Then


            If FrmAdmin.LvwControlAgenda.Items.Count > 0 And validarDia Then
                Dim conexion As New BDCon
                conexion.manipularBD("update visita set Hora_Visita='" & CbxHora.Text & "' where IDVisita=" & FrmAdmin.LvwControlAgenda.SelectedItems(0).SubItems(0).Text)
                conexion.manipularBD("update visita set Dia_Visita='" & DTPFechaNueva.Text & "' where IDVisita=" & FrmAdmin.LvwControlAgenda.SelectedItems(0).SubItems(0).Text)
                conexion.manipularBD("update visita set Modificada='1' where IDVisita=" & FrmAdmin.LvwControlAgenda.SelectedItems(0).SubItems(0).Text)
            End If
            Metodos.agregarlvwagenda(FrmAdmin.LvwControlAgenda, "select visita.IDVisita, personas.Nombre, propiedades.Nombre, visita.Dia_Visita, visita.Hora_Visita,visita.IDUsuarioP from personas, visita, usuario, propiedades where visita.IDUsuarioI = usuario.IDUsuario and usuario.CIPersona=personas.CIPersona and propiedades.IDPropiedades=visita.IDPropiedades and visita.Cancelada=0", "visita")
            Me.Close()
        Else
            MsgBox("Seleccione una hora valida")
        End If
    End Sub

    Private Sub DTPFechaNueva_Leave(sender As Object, e As EventArgs) Handles DTPFechaNueva.ValueChanged
        Dim con As New BDCon
        Dim data As New DataSet
        data = con.consulta("select Hora from agenda,dias where dias.IDDia=agenda.dia and dias.Dia='" & Metodos.diastring(Me.DTPFechaNueva.Value.DayOfWeek) & "' and agenda.IDUsuarioP=" & Me.idAgente & "", "horas")
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
    End Sub
End Class