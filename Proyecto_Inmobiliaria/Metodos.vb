Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Module Metodos
    Public colorforms As String = "blue"
    Public opacidad As Double = 1
    Public log As Boolean = False
    Public volver As Boolean = False
    Public Tiempo As Integer = 0
    Public usr As Integer = 0
    Public consulta As String = "SELECT IDPropiedades,IDUsuarioProp,Precio,Tipo_Propiedad,Cantidad_Habitaciones,Cantidad_Baños,NumCalle,Estado,Superficie_Terreno,Superficie_Cubierta,Antiguedad,Condicion_Propiedad,Nombre,Cantidad_Garajes,Descripcion FROM propiedades"
    Public numprop As Integer = 0
    Public reg As Boolean = False
    Private i As Integer
    Public idprop As String = ""
    Public fecha As Integer = 0
    Public hora As Integer = 0
    Public encargado As Integer = 0
    Public WithEvents timer As New Timer


    Public Sub timer_tick(sender As Object, e As EventArgs) Handles timer.Tick
        'Crea la conexion y consulta todas las visitas existentes que no esten canceladas y que no se haya avisado previamente
        Dim con As New BDCon
        Dim data As New DataSet
        data = con.consulta("select * from visita where aviso=0 and cancelada=0", "visitas")
        For a = 0 To data.Tables("visitas").Rows.Count - 1
            'Obtiene la fecha de la visita y el id del cliente de la visita
            Dim fechaString As String = data.Tables("visitas").Rows(a).Item(3)
            Dim fechaVisita As Date
            Dim idCliente As Integer = Val(data.Tables("visitas").Rows(a).Item(1))
            fechaVisita = FormateadorDeTextos.stringadate(fechaString)
            'Resta 1 dia a la fecha de la visita y se fija si es igual a la fecha actual
            If fechaVisita.AddDays(-1).ToShortDateString = Now.Date.ToShortDateString Then
                'Si es 1 dia antes de la visita
                Dim con2 As New BDCon
                Dim con3 As New BDCon
                Dim correo As New DataSet
                'Obtiene la direccion de correo y nombre del cliente y el nombre de la propiedad
                correo = con2.consulta("select CorreoPersona, Nombre from personas, usuario where personas.CIPersona=usuario.CIPersona and usuario.IDUsuario=" & idCliente, "correoCliente")
                Dim dircorreoString As String = correo.Tables("correoCliente").Rows(0).Item(0).ToString
                Dim correoString As String = "Estimado cliente " & correo.Tables("correoCliente").Rows(0).Item(1).ToString & Chr(Keys.Enter)
                Dim dataPropNom As New DataSet
                dataPropNom = con3.consulta("select Nombre from propiedades where IDPropiedades=" & data.Tables("visitas").Rows(a).Item(2), "NomProp")
                correoString += "En este correo, le informamos que mañana " & fechaVisita.ToShortDateString & " a las " & data.Tables("visitas").Rows(a).Item(4) & "h tiene agendada una visita para la propiedad " & dataPropNom.Tables("NomProp").Rows(0).Item(0).ToString
                'Crea el mensaje, se lo manda al cliente y marca en la bd como avisado
                Dim mensaje As New Mensaje(correoString, "Visita agendada", dircorreoString, "develofix666@gmail.com", "develofixdeldiablo")
                mensaje.enviarMail()
                con2.manipularBD("update visita set aviso=1 where idvisita=" & data.Tables("visitas").Rows(a).Item(0))
            End If
        Next
        Dim data2 As New DataSet
        data2 = con.consulta("select * from visita where cancelada=0 and concluida=0", "concluidas")
        For a = 0 To data2.Tables("concluidas").Rows.Count - 1
            Dim fechaString As String = data2.Tables("concluidas").Rows(a).Item(3)
            Dim fechaVisita As Date
            fechaVisita = FormateadorDeTextos.stringadate(fechaString)
            If fechaVisita.AddDays(1).ToShortDateString = Now.Date.ToShortDateString Then
                con.manipularBD("update visita set concluida=1 where idvisita=" & data2.Tables("concluidas").Rows(a).Item(0))
            End If
        Next

    End Sub

    Public Sub verificarParametroNull(valor As String, comando As MySql.Data.MySqlClient.MySqlCommand, tipo As MySql.Data.MySqlClient.MySqlDbType, parametro As String)
        If valor = -1 Then
            comando.Parameters.Add(parametro, tipo).Value = DBNull.Value
        Else
            comando.Parameters.Add(parametro, tipo).Value = valor
        End If
    End Sub


    Public Sub volverlogin(form As Form)
        FrmLogin.Show()
        form.Close()
    End Sub

    Public Sub cambiarform(formo As Form, formd As Form)

        formd.Show()
        formo.Close()
    End Sub

    Public Sub MtdEnterAlTxt(TxtRecibido As Control, varTexto As String)

        If TxtRecibido.Text = varTexto Then
            TxtRecibido.Text = ""
            TxtRecibido.ForeColor = Color.Black
        End If

    End Sub

    Public Sub MtdLeaveAlTxt(TxtRecibido As Control, varTexto As String)

        If TxtRecibido.Text = "" Then
            TxtRecibido.Text = varTexto
            TxtRecibido.ForeColor = Color.Gray

        End If

    End Sub

    Public Sub cambiarpasschar(TxtRecibido As TextBox)
        If TxtRecibido.Text = "" Then
            TxtRecibido.PasswordChar = ""
        Else
            TxtRecibido.PasswordChar = "*"
        End If
    End Sub

    Public Sub validarcaresp(txt As TextBox)
        validar(txt, "([^0-9a-zA-Z])+", "Ingrese solo numeros y letras")
    End Sub

    Public Sub validarnumeros(txt As TextBox)
        validar(txt, "[^0-9]", "Ingrese solo numeros")
    End Sub

    Public Sub validarletras(txt As TextBox)
        validar(txt, "[^a-zA-Z]", "Ingrese solo letras")
    End Sub

    Public Sub validarletrasyespacio(txt As TextBox)
        validar(txt, "[^a-zA-Z ]", "Ingrese solo letras")
    End Sub

    Public Sub validarcorreos(txt As TextBox, texto As String)
        If txt.Text = "" Then
            MtdLeaveAlTxt(txt, texto)

        Else
            If validarbool("(^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$)", txt) = False Then
                validarinverso(txt, "(^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$)", "Ingreso mal el correo")
            End If

        End If

    End Sub

    Public Sub validartel(txt As TextBox)
        If txt.Text <> "" Then
            validarinverso(txt, "^[0-9]{9}$", "Ingreso mal el celular")
        End If

    End Sub



    Public Sub validar(txt As TextBox, patron As String, mensaje As String)
        Dim rx As New Regex(patron)

        If rx.IsMatch(txt.Text) Then
            MsgBox(mensaje, vbInformation, "Atención")
            Dim str As String = ""

            For a = 0 To rx.Match(txt.Text).Index - 1
                str += txt.Text.Chars(a)
            Next
            txt.Text = str
        End If
        txt.Select(txt.Text.Length, 0)
    End Sub

    Public Sub validarinverso(txt As TextBox, patron As String, mensaje As String)
        Dim rx As New Regex(patron)

        If rx.IsMatch(txt.Text) = False Then
            MsgBox(mensaje, vbInformation, "Atención")
            Dim str As String = ""

            For a = 0 To rx.Match(txt.Text).Index - 1
                str += txt.Text.Chars(a)
            Next
            txt.Text = str
        End If
        txt.Select(txt.Text.Length, 0)
    End Sub

    Public Function validarbool(patron As String, txt As TextBox) As Boolean
        Dim rx As New Regex(patron)
        Return rx.IsMatch(txt.Text)
    End Function


    'Temas

    Public Sub tema(form As Form, atras As Bitmap, adelante As Bitmap, login As Bitmap, chico As Bitmap, btnnormal As Bitmap)
        contenedores(form, atras, adelante, login, chico, btnnormal)
        For Each panel As Panel In form.Controls.OfType(Of Panel)()
            contenedores(panel, atras, adelante, login, chico, btnnormal)
        Next

        For Each tabcontrol As TabControl In form.Controls.OfType(Of TabControl)
            For Each tabpage As TabPage In tabcontrol.Controls.OfType(Of TabPage)

                contenedores(tabpage, atras, adelante, login, chico, btnnormal)
            Next
        Next
    End Sub

    Public Sub contenedores(contenedor As Control, atras As Bitmap, adelante As Bitmap, login As Bitmap, chico As Bitmap, btnnormal As Bitmap)
        For Each pbx As PictureBox In contenedor.Controls.OfType(Of PictureBox)()
            If pbx.Tag = "perfil" Then
                pbx.Image = login
            End If
        Next

        For Each btn As Button In contenedor.Controls.OfType(Of Button)()
            If btn.Tag = "btnatras" Then
                btn.Image = atras
            ElseIf btn.Tag = "btnadelante" Then
                btn.Image = adelante
            ElseIf btn.Tag = "btnnormal" Then
                btn.Image = btnnormal
            ElseIf btn.Tag = "btnchico" Then
                btn.Image = chico
            End If
        Next

    End Sub

    Public Sub azul(form As Form)
        colorforms = "blue"
        form.BackgroundImage = My.Resources.FondoTemaAzul
        tema(form, My.Resources.BotonAtrasTemaAzul, My.Resources.BotonAdelanteTemaAzul, My.Resources.PerfilAzul1, My.Resources.BotonChiquitoTemaAzul, My.Resources.BotonLoginTemaAzul)
    End Sub

    Public Sub marron(form As Form)
        colorforms = "brown"
        form.BackgroundImage = My.Resources.FondoTemaMarron
        tema(form, My.Resources.BotonAtrasTemaMarron, My.Resources.BotonAdelanteTemaMarron, My.Resources.PerfilMarron1, My.Resources.BotonChiquitoTemaMarron, My.Resources.BotonLoginTemaMarron)
    End Sub

    Public Sub gris(form As Form)
        colorforms = "gray"
        form.BackgroundImage = My.Resources.FondoTemaGris
        tema(form, My.Resources.BotonAtrasTemaGris, My.Resources.BotonAdelanteTemaGris, My.Resources.PerfilGris1, My.Resources.BotonChiquitoTemaGris, My.Resources.BotonLoginTemaGris)
    End Sub

    Public Sub mantenertema(form As Form)
        If colorforms = "blue" Then
            Metodos.azul(form)
            cambiaropacidad(form, opacidad)
        ElseIf colorforms = "brown" Then
            Metodos.marron(form)
            cambiaropacidad(form, opacidad)
        Else
            Metodos.gris(form)
            cambiaropacidad(form, opacidad)
        End If
    End Sub

    Public Sub cambiaropacidad(form As Form, opacity As Double)
        form.Opacity = opacity
        opacidad = opacity
    End Sub

    Public Sub MtdDatosPropiedades(prop As Propiedad)
        'Verifica y carga atributos de la propiedad
        validarSE(prop.Precio.ToString, FrmAgendar.TxtPrecio)
        validarSE(prop.Tipo.ToString, FrmAgendar.TxtTipo)
        validarSE(prop.Estado.ToString, FrmAgendar.TxtEstado)
        validarSE(prop.CantHabitaciones.ToString, FrmAgendar.TxtCuartos)
        validarSE(prop.Departamento.ToString, FrmAgendar.TxtDepartamento)
        validarSE(prop.Ciudad.ToString, FrmAgendar.TxtCiudad)
        validarSE(prop.Barrio.ToString, FrmAgendar.TxtBarrio)
        validarSE(prop.Terreno.ToString, FrmAgendar.TxtTerreno)
        validarSE(prop.SuperficieCubierta.ToString, FrmAgendar.TxtTerrenoCubierto)
        validarSE(prop.Antiguedad.ToString, FrmAgendar.TxtAntiguedad)
        validarSE(prop.Condicion.ToString, FrmAgendar.TxtCondicion)
        validarSE(prop.Nombre.ToString, FrmAgendar.TxtNombre)
        validarSE(prop.ID.ToString, FrmAgendar.TxtID)
        validarSE(prop.Descripcion.ToString, FrmAgendar.TxtDescripcion)







    End Sub

    Public Sub validarSE(valor As String, txt As TextBox)
        If valor = "-1" Then
            txt.Text = "S/E"
        Else
            txt.Text = valor
        End If
    End Sub


    Public Function MtdDatosPropiedades(Txts() As TextBox) As String
        Dim str As String = ""
        For Each i As TextBox In Txts
            str += i.Text + Chr(Keys.Enter)
        Next
        MtdDatosPropiedades = str

    End Function

    Public Sub cargarimg(images As ArrayList, imagescasa As ArrayList)

        For Each i As Bitmap In imagescasa

            images.Add(i)
        Next

    End Sub



    Public Function MtdValidarCampoVacio(Txt As Control, Texto As String) As String

        If Txt.Text.Equals(Texto) Then
            Dim str As String
            str = Texto + Chr(Keys.Enter)
            MtdValidarCampoVacio = str
        Else
            MtdValidarCampoVacio = ""
        End If


    End Function


    Public Sub MtdTimeButton(activar As Boolean)
        Dim fraccion As Integer = 0
        activar = False
        Dim TmrTimer As New Timer
        TmrTimer.Interval = 1
        TmrTimer.Start()


    End Sub

    Public Sub buttonanimation(btn As Button)
        btn.Location = New Point(btn.Location.X, btn.Location.Y + 5)
        System.Threading.Thread.Sleep(100)
        btn.Location = New Point(btn.Location.X, btn.Location.Y - 5)
    End Sub

    Public Sub validarhd(txtd As Control, txth As Control, textovacio As String, textoerror As String)
        If txth.Text <> "" Then
            ' If txtd.Text <> "Desde" Then

            If Val(txtd.Text) > Val(txth.Text) Then
                MsgBox(textoerror, vbCritical, "Error")
                txth.Text = ""
            End If
            ' Else
            '    MsgBox(textovacio)
            '    txth.Text = ""
            'End If
        End If

    End Sub

    Public Sub validardh(txth As Control, txtd As Control, msg As String)
        If txth.Text <> "Hasta" Then
            If Val(txtd.Text) > Val(txth.Text) Then

                MsgBox(msg, vbInformation, "Atención")
                txtd.Text = ""
            End If
        End If
    End Sub
    Public Sub agregarlvwagenda(list As ListView, consulta As String, tabla As String)
        Dim conexion As New BDCon
        Dim dato As New DataSet

        dato = conexion.consulta(consulta, tabla)
        list.Items.Clear()
        For a = 0 To dato.Tables(0).Rows.Count - 1
            'IDVisita,NombreCli,NombreProp,FechaVi,Personal
            Dim visita As New ListViewItem(dato.Tables(0).Rows(a).Item(0).ToString)
            visita.SubItems.Add(dato.Tables(0).Rows(a).Item(1).ToString)
            visita.SubItems.Add(dato.Tables(0).Rows(a).Item(2).ToString)
            visita.SubItems.Add(dato.Tables(0).Rows(a).Item(3))
            visita.SubItems.Add(dato.Tables(0).Rows(a).Item(4).ToString)
            visita.SubItems.Add(dato.Tables(0).Rows(a).Item(5).ToString)

            list.Items.Add(visita)
        Next
    End Sub

    Public Sub addpropiety(row As DataRow, list As ListView)
        Dim i As New ListViewItem(row.Item(0).ToString)

        i.SubItems.Add(row.Item(1).ToString)
        i.SubItems.Add(row.Item(2).ToString)
        i.SubItems.Add(row.Item(3).ToString)
        i.SubItems.Add(row.Item(4).ToString)
        i.SubItems.Add(row.Item(5).ToString)
        i.SubItems.Add(row.Item(6).ToString)
        i.SubItems.Add(row.Item(7).ToString)
        i.SubItems.Add(row.Item(8).ToString)
        i.SubItems.Add(row.Item(9).ToString)
        i.SubItems.Add(row.Item(10).ToString)

        list.Items.Add(i)
    End Sub

    Public Function fechaBD(d_m_a As String) As String
        Dim anio As String
        Dim mes As String
        Dim dia As String
        Dim campo As Integer = 0
        For Each a As Char In d_m_a
            If a = "/" Then
                campo += 1
            End If
            Select Case campo
                Case 0
                    If a <> "/" Then
                        dia += a
                    End If

                Case 1
                    If a <> "/" Then
                        mes += a
                    End If
                Case 2
                    If a <> "/" Then
                        anio += a
                    End If
            End Select

        Next
        Dim fecha As String = anio & "-" & mes & "-" & dia
        Return fecha
    End Function

    Public Function cargararrayBD(consulta As String, tabla As String) As ArrayList
        Dim conexion As New BDCon
        Dim dato As New DataSet
        Dim array As New ArrayList
        dato = conexion.consulta(consulta, tabla)
        For a = 0 To dato.Tables(tabla).Rows.Count - 1

            array.Add(dato.Tables(tabla).Rows(a).Item(0))

        Next
        Return array
    End Function

    Public Function byteaimg(arraybytes() As Byte) As Image
        Dim ms As New MemoryStream
        Dim bytesimg() As Byte
        bytesimg = arraybytes
        ms = New MemoryStream(bytesimg)
        Return Image.FromStream(ms)
    End Function



    Public Function diastring(dia As Integer) As String
        Select Case dia
            Case DayOfWeek.Monday
                Return "Lunes"
            Case DayOfWeek.Tuesday
                Return "Martes"
            Case DayOfWeek.Wednesday
                Return "Miercoles"
            Case DayOfWeek.Thursday
                Return "Jueves"
            Case DayOfWeek.Friday
                Return "Viernes"
            Case DayOfWeek.Saturday
                Return "Sabado"
            Case DayOfWeek.Sunday
                Return "Domingo"
        End Select

        Return ""
    End Function

    Public Function CargarArrayTables(excel As LibroExcel, numHoja As Integer) As ArrayTable
        excel.setHoja(excel.nombresSheets(numHoja))
        Dim Columnas As New ArrayList
        Columnas = excel.obtenerFiladeCeldaExcel(1, 1, ",")

        Dim Table As New ArrayTable(Columnas)

        For a = 2 To excel.obtenerFilaNull - 1
            Table.agregarFila(excel.obtenerFiladeCeldaExcel(a, 1, ","))
        Next
        Return Table
    End Function


End Module
