Imports MySql.Data.MySqlClient
Public Class FrmAdmin
    Public tipo As String = ""
    Shadows menu As New ClassMenu(Me)
    Dim excel As LibroExcel
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Metodos.volverlogin(Me)
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New BDCon
        If tipo = "G" Then
            menu.MnuStIUsuario.Text = "Gerente"
            For a = 0 To LvwAgenda.Columns.Count - 1
                LvwAgenda.Columns.Item(a).Width = LvwAgenda.Width / LvwAgenda.Columns.Count
            Next
            For a = 0 To LvwControlAgenda.Columns.Count - 1
                LvwControlAgenda.Columns.Item(a).Width = LvwControlAgenda.Width / LvwControlAgenda.Columns.Count
            Next
        End If
        If tipo = "A" Then
            menu.MnuStIUsuario.Text = "Agente Inmobiliario"
            LvwPropiedades.Visible = True
            LvwAgenda.Visible = False
            For a = 0 To LvwPropiedades.Columns.Count - 1
                LvwPropiedades.Columns.Item(a).Width = LvwPropiedades.Width / LvwPropiedades.Columns.Count
            Next
            For a = 0 To LvwControlAgenda.Columns.Count - 1
                LvwControlAgenda.Columns.Item(a).Width = LvwControlAgenda.Width / LvwControlAgenda.Columns.Count
            Next
        End If


        Dim dato As New DataSet
        dato.Clear()
        dato = conexion.consulta("select Nombre, Apellido from Personas,Usuario where usuario.CIPersona=Personas.CIPersona And Usuario.IDUsuario=" & Metodos.usr.ToString, "personas")


        If Metodos.volver = True Then
            Me.Text = "Propuru - " & dato.Tables("personas").Rows(0).Item(0).ToString & " " & dato.Tables("personas").Rows(0).Item(1).ToString
        End If

        Metodos.mantenertema(Me)
        menu.MnuStIUsuario.Enabled = True

        If tipo.Equals("G") Then
            BtnConsultarPropiedades.Visible = False
        Else
            BtnConsultarAgenda.Visible = False
            BtnConsultarVisitasModificadas.Visible = False
            BtnVisitasCanceladas.Visible = False
            BtnRegistrarEmpleado.Visible = False
            BtnCargarExcel.Visible = False


        End If
    End Sub

    Private Sub BtnRegistrarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnRegistrarEmpleado.Click
        Metodos.buttonanimation(sender)
        Metodos.volver = True
        Metodos.cambiarform(Me, FrmRegistrarse)
        FrmRegistrarse.CbxTipoDeUsuario.Visible = True
        FrmRegistrarse.CbxSucursales.Visible = True
        FrmRegistrarse.TxtTipoUser.Visible = True
        FrmRegistrarse.TxtSucursal.Visible = True
        FrmRegistrarse.CbxTurno.Visible = True
        FrmRegistrarse.TxtTurno.Visible = True


    End Sub

    Private Sub BtnConsultarAgenda_Click(sender As Object, e As EventArgs) Handles BtnConsultarAgenda.Click
        Metodos.buttonanimation(sender)
        Metodos.agregarlvwagenda(LvwAgenda, "select visita.IDVisita, personas.Nombre, propiedades.Nombre, visita.Dia_Visita, visita.Hora_Visita,visita.IDUsuarioP from personas, visita, usuario, propiedades where visita.IDUsuarioI = usuario.IDUsuario and usuario.CIPersona=personas.CIPersona and propiedades.IDPropiedades=visita.IDPropiedades and visita.Dia_Visita='" & Now.Date.Year & "-" & Now.Date.Month & "-" & Now.Date.Day & "'", "visita")
        If LvwAgenda.Items.Count = 0 Then
            MsgBox("No hay ninguna visita para el dia de hoy", vbInformation, "Atención")
        End If
    End Sub



    Private Sub BtnConsultarVisitasModificadas_Click(sender As Object, e As EventArgs) Handles BtnConsultarVisitasModificadas.Click
        Metodos.buttonanimation(sender)
        Metodos.agregarlvwagenda(LvwAgenda, "select visita.IDVisita, personas.Nombre, propiedades.Nombre, visita.Dia_Visita, visita.Hora_Visita,visita.IDUsuarioP from personas, visita, usuario, propiedades where visita.IDUsuarioI = usuario.IDUsuario and usuario.CIPersona=personas.CIPersona and propiedades.IDPropiedades=visita.IDPropiedades and visita.Modificada=1", "visita")
        If LvwAgenda.Items.Count = 0 Then
            MsgBox("No hay ninguna visita modificada", vbInformation, "Atención")
        End If
    End Sub

    Private Sub BtnVisitasCanceladas_Click(sender As Object, e As EventArgs) Handles BtnVisitasCanceladas.Click
        Metodos.buttonanimation(sender)
        Metodos.agregarlvwagenda(LvwAgenda, "select visita.IDVisita, personas.Nombre, propiedades.Nombre, visita.Dia_Visita, visita.Hora_Visita,visita.IDUsuarioP from personas, visita, usuario, propiedades where visita.IDUsuarioI = usuario.IDUsuario and usuario.CIPersona=personas.CIPersona and propiedades.IDPropiedades=visita.IDPropiedades and visita.Cancelada=1", "visita")
        If LvwAgenda.Items.Count = 0 Then
            MsgBox("No hay ninguna visita cancelada", vbInformation, "Atención")
        End If
    End Sub

    Private Sub BtnConsultarPropiedades_Click(sender As Object, e As EventArgs) Handles BtnConsultarPropiedades.Click
        Metodos.buttonanimation(sender)

        Dim conexion As New BDCon
        Dim dato As New DataSet
        dato = conexion.consulta("select propiedades.IDPropiedades, propiedades.Nombre, Precio, Superficie_Cubierta, Superficie_Terreno, departamentos.Nombre, barrios.Nombre, propiedades.Condicion_Propiedad, Tipo_Propiedad,Estado,Antiguedad from propiedades, departamentos, barrios where departamentos.IDDepartamento=propiedades.IDDepartamento and barrios.IDBarrio=propiedades.IDBarrio", "propiedades")
        For a = 0 To dato.Tables("propiedades").Rows.Count - 1
            Metodos.addpropiety(dato.Tables("propiedades").Rows(a), LvwPropiedades)
        Next
        If LvwPropiedades.Items.Count = 0 Then
            MsgBox("No hay ninguna propiedad registrada", vbInformation, "Atención")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnVerAgenda.Click
        Metodos.buttonanimation(sender)
        LvwControlAgenda.Items.Clear()
        Metodos.agregarlvwagenda(LvwControlAgenda, "select visita.IDVisita, personas.Nombre, propiedades.Nombre, visita.Dia_Visita, visita.Hora_Visita,visita.IDUsuarioP from personas, visita, usuario, propiedades where visita.IDUsuarioI = usuario.IDUsuario and usuario.CIPersona=personas.CIPersona and propiedades.IDPropiedades=visita.IDPropiedades and visita.Cancelada=0", "visita")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancelarAgenda.Click
        Metodos.buttonanimation(sender)

        If LvwControlAgenda.SelectedItems.Count > 0 Then

            Dim idvisita As Integer = Val(LvwControlAgenda.SelectedItems(0).SubItems(0).Text)
            Dim conexion As New BDCon
            Dim dato As New DataSet
            conexion.manipularBD("update visita set cancelada=1 where IDVisita=" & idvisita)
            LvwControlAgenda.Items.RemoveAt(LvwControlAgenda.SelectedItems(0).Index)
        Else
            MsgBox("Seleccione alguna vista antes", vbInformation, "Atención")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnModificarAgenda.Click
        Metodos.buttonanimation(sender)

        If LvwControlAgenda.SelectedItems.Count > 0 Then
            'Obtiene el ID de la visita seleccionada
            Dim idvisita As Integer = Val(LvwControlAgenda.SelectedItems(0).SubItems(0).Text)
            Dim conexion As New BDCon
            Dim dato As New DataSet
            'Setea la fecha actual de la visita en el Label
            FrmModificarAgenda.LblFechaOrigen.Text = LvwControlAgenda.SelectedItems(0).SubItems(3).Text & " " & LvwControlAgenda.SelectedItems(0).SubItems(4).Text
            'Obtenemos el ID del personal asignado a la visita
            Dim idUsuario As Integer = Val(conexion.getID("IDUsuarioP", "Visita", "IDVisita=" & idvisita))
            dato.Clear()
            dato = conexion.consulta("select distinct dias.Dia from dias, agenda where dias.IDDia=agenda.Dia and IDUsuarioP=" & idUsuario, "agente_dias")

            Dim diasDisponiblesS As String = ""
            For a = 0 To dato.Tables("agente_dias").Rows.Count - 1
                FrmModificarAgenda.arrayDias.Add(dato.Tables("agente_dias").Rows(a).Item(0))
                diasDisponiblesS += dato.Tables("agente_dias").Rows(a).Item(0) & ", "
            Next
            FrmModificarAgenda.LblDiasDisponibles.Text = diasDisponiblesS

            FrmModificarAgenda.idAgente = idUsuario

            FrmModificarAgenda.Show()

        Else
            MsgBox("Seleccione un elemento antes", vbCritical, "Error")
        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnCargarExcel.Click
        Dim validarExcel As Boolean = False
        With OFDExcel
            .Filter = "Excel File (*.xlsx)|*.xlsx"
            .Multiselect = False
            .FileName = ""

            If .ShowDialog() = DialogResult.OK Then
                excel = New LibroExcel(.FileName)
                validarExcel = True

            End If
        End With
        If validarExcel Then


            Dim arrayTables As New ArrayList

            For a = 0 To excel.nombresSheets.Count - 1
                Dim Table As ArrayTable

                Table = CargarArrayTables(excel, a)

                Table.Nombre = excel.nombresSheets.Item(a)

                arrayTables.Add(Table)
            Next


            'Arrays de Objetos
            Dim arrayClientes As New ArrayList
            Dim arrayPersonal As New ArrayList
            Dim arrayUsuarios As New ArrayList
            Dim arrayPropiedad As New ArrayList
            Dim arrayCiudades As New ArrayList
            Dim arrayDepartamentos As New ArrayList
            Dim arrayBarrios As New ArrayList
            Dim arrayAgenda As New ArrayList
            Dim arrayVisitas As New ArrayList
            Dim arrayPropietarios As New ArrayList

            'Obtiene indices de las tablas
            Dim TablePersona As Integer = excel.obtenerIndiceSheet("Personas")
            Dim TableTelefonos As Integer = excel.obtenerIndiceSheet("Telefono")
            Dim TablePropiedades As Integer = excel.obtenerIndiceSheet("Propiedades")
            Dim TableReservas As Integer = excel.obtenerIndiceSheet("Reservas")
            Dim TableNumReservas As Integer = excel.obtenerIndiceSheet("Numero Reservas")
            Dim TableCiudades As Integer = excel.obtenerIndiceSheet("Ciudades")
            Dim TableHorarios As Integer = excel.obtenerIndiceSheet("Horarios")
            Dim TableAgenda As Integer = excel.obtenerIndiceSheet("Agenda")

            'Cargar Personas

            'Se fija en la longitud de la tabla y recorre cada fila menos el titulo de las columnas
            For a = 1 To arrayTables.Item(TablePersona).obtenerLongitud - 1
                'Se fija el valor de la columna tipo en una fila
                Select Case arrayTables.Item(TablePersona).columna("tipo").item(a)
                    Case "Interesado"
                        'Obtiene toda la fila del cliente y los guarda en un array
                        Dim datosCliente As New ArrayList
                        datosCliente = arrayTables.Item(TablePersona).obtenerFila(a)
                        Dim telsCliente As New ArrayList
                        'Recorre toda la tabla de telefonos y se fija en las filas donde la CI del cliente coincida y guarda el telefono de dicha fila
                        For b = 1 To arrayTables.Item(TableTelefonos).obtenerLongitud - 1
                            If arrayTables.Item(TableTelefonos).columna("CI").item(b) = datosCliente.Item(0) Then
                                telsCliente.Add(arrayTables.Item(TableTelefonos).columna("telefono").item(b))
                            End If
                        Next
                        Dim telCliente As Integer = -1
                        If telsCliente.Count <> 0 Then
                            telCliente = telsCliente.Item(0)
                        End If
                        'Crea un objeto cliente con los datos obtenidos del excel
                        With datosCliente
                            Dim cliente As New Cliente(FormateadorDeTextos.formatoCI(.Item(0)), FormateadorDeTextos.sacarComillas(.Item(1)), FormateadorDeTextos.sacarComillas(.Item(2)), -1, .Item(3), telCliente, .Item(4))
                            Dim usuario As New Usuario(FormateadorDeTextos.sacarEspacios(cliente.Nombre), cliente, -1)
                            arrayUsuarios.Add(usuario)
                            arrayClientes.Add(cliente)
                        End With
                    Case """Agente Inmobiliario"""
                        Dim datosCliente As New ArrayList
                        datosCliente = arrayTables.Item(TablePersona).obtenerFila(a)
                        'Crea el personal y el usuario correspondiente y los guarda en los array
                        With datosCliente
                            Dim personal As New Personal(FormateadorDeTextos.formatoCI(.Item(0)), FormateadorDeTextos.sacarComillas(.Item(1)), FormateadorDeTextos.sacarComillas(.Item(2)), -1, .Item(3), -1, .Item(4), "A")
                            Dim usuario As New Usuario(FormateadorDeTextos.sacarEspacios(personal.Nombre), personal, -1)
                            arrayUsuarios.Add(usuario)
                            arrayPersonal.Add(personal)
                        End With
                    Case "Propietario"
                        Dim datosCliente As New ArrayList
                        datosCliente = arrayTables.Item(TablePersona).obtenerFila(a)
                        Dim telsCliente As New ArrayList
                        'Recorre toda la tabla de telefonos y se fija en las filas donde la CI del cliente coincida y guarda el telefono de dicha fila
                        For b = 1 To arrayTables.Item(TableTelefonos).obtenerLongitud - 1
                            If arrayTables.Item(TableTelefonos).columna("CI").item(b) = datosCliente.Item(0) Then
                                telsCliente.Add(arrayTables.Item(TableTelefonos).columna("telefono").item(b))
                            End If
                        Next
                        Dim telCliente As Integer = -1
                        If telsCliente.Count <> 0 Then
                            telCliente = telsCliente.Item(0)
                        End If
                        'Crea el propietario y el usuario correspondiente y los guarda en los array
                        With datosCliente
                            Dim propietario As New Propietario(FormateadorDeTextos.formatoCI(.Item(0)), FormateadorDeTextos.sacarComillas(.Item(1)), FormateadorDeTextos.sacarComillas(.Item(2)), -1, .Item(3), telCliente, .Item(4))
                            Dim usuario As New Usuario(FormateadorDeTextos.sacarEspacios(propietario.Nombre), propietario, -1)
                            arrayUsuarios.Add(usuario)
                            arrayPropietarios.Add(propietario)
                        End With

                End Select
            Next

            'Cargar Departamentos

            Dim arrayDep As New ArrayList
            For a = 1 To arrayTables.Item(TableCiudades).obtenerLongitud - 1
                Dim tableDep As ArrayTable
                tableDep = arrayTables.Item(TableCiudades)
                Dim Nombredep As String = tableDep.columna("nombre_departamento").item(a)
                If Not arrayDep.Contains(Nombredep) Then
                    Dim departamento As New Departamento(a, Nombredep)
                    arrayDepartamentos.Add(departamento)
                End If
                arrayDep.Add(Nombredep)
            Next


            'Cargar ciudades

            For a = 1 To arrayTables.Item(TableCiudades).obtenerLongitud - 1
                Dim DatosCiudad As New ArrayList
                DatosCiudad = arrayTables.Item(TableCiudades).obtenerFila(a)
                'Se fija si el departamento existe
                Dim dep As String = DatosCiudad.Item(2)
                Dim departamento As New Departamento
                For Each d As Departamento In arrayDepartamentos
                    'Si existe, inicializa el departamento
                    If d.Nombre = dep Then
                        departamento = d
                    End If
                Next
                If arrayDep.Contains(dep) Then
                    'Crea la ciudad y la guarda en el array
                    Dim ciudad As New Ciudad(DatosCiudad.Item(0), FormateadorDeTextos.sacarComillas(DatosCiudad.Item(1)), departamento)

                    arrayCiudades.Add(ciudad)
                End If
            Next

            'Cargar Propiedades

            'Se fija en la longitud de la tabla y recorre cada fila menos el titulo de las columnas
            For a = 1 To arrayTables.Item(TablePropiedades).obtenerLongitud - 1
                'Obtiene los datos de la propiedad y los guarda en el array
                Dim datosPropiedad As New ArrayList
                datosPropiedad = arrayTables.Item(TablePropiedades).obtenerFila(a)
                'Se fija que exista la ciudad donde esta ubicada la propiedad, si existe crea la propiedad y el barrio, luego los guarda en el array correspondiente
                Dim idciudad As Integer = datosPropiedad.Item(1)
                Dim barrioNombre As String = FormateadorDeTextos.sacarComillas(datosPropiedad.Item(2))
                For Each c As Ciudad In arrayCiudades
                    If c.ID = idciudad Then
                        With datosPropiedad
                            Dim Barrio As New Barrio(a, barrioNombre, c)
                            Dim propiedad As New Propiedad(ID:= .Item(0), IDProp:=-1, Precio:= .Item(5), Tipo:= .Item(11), CantHabitaciones:= .Item(6), CantBaños:= .Item(7), NumCalle:= .Item(4), Estado:=-1, Terreno:=-1, SuperficieCubierta:=-1, Antiguedad:=-1, Condicion:=-1, Nombre:= .Item(2) & "," & .Item(3), CantGarajes:= .Item(8), Descripcion:= .Item(9), Imagenes:=New ArrayList, ciudad:=c.Nombre, barrio:= .Item(2), departamento:=c.Departamento.Nombre)
                            arrayPropiedad.Add(propiedad)
                            arrayBarrios.Add(Barrio)
                        End With
                    End If
                Next
            Next

            'Cargar agenda

            For a = 1 To arrayTables.Item(TableAgenda).obtenerLongitud - 1
                Dim datosAgenda As New ArrayList
                datosAgenda = arrayTables.Item(TableAgenda).obtenerFila(a)
                For Each p As Personal In arrayPersonal
                    'Se fija que exista el personal de la agenda
                    If p.CI = FormateadorDeTextos.formatoCI(datosAgenda.Item(1)) Then
                        Dim horasAgenda As New ArrayList
                        'Recorre toda la tabla de horarios y se fija en las filas donde la ID de la agenda coincida y guarda el horario de dicha fila

                        For b = 1 To arrayTables.Item(TableHorarios).obtenerLongitud - 1
                            If arrayTables.Item(TableHorarios).columna("id_agenda").item(b) = datosAgenda.Item(0) Then
                                horasAgenda.Add(arrayTables.Item(TableHorarios).columna("horario").item(b))
                            End If
                        Next
                        'Se fija que hayan horarios para esa agenda y los guarda
                        If horasAgenda.Count > 0 Then
                            Dim agenda As New Agenda(datosAgenda.Item(0), p, datosAgenda.Item(3), horasAgenda)
                            arrayAgenda.Add(agenda)

                        End If

                    End If
                Next
            Next
            'Pasa por todas las reservas
            For a = 1 To arrayTables.Item(TableReservas).obtenerLongitud - 1
                Dim datosReserva As New ArrayList
                datosReserva = arrayTables.Item(TableReservas).obtenerFila(a)
                Dim validarAgente As Boolean = False
                Dim validarCliente As Boolean = False
                Dim validarPropiedad As Boolean = False
                Dim ValidarHora As Boolean = False
                Dim fechaVisita As String = ""
                Dim horaVisita As String = ""
                Dim propiedad As New Propiedad
                Dim cliente As New Cliente
                Dim personal As New Personal
                Dim agenda As New Agenda
                'Verifica si el personal, el cliente y la propiedad existen
                For Each p As Personal In arrayPersonal
                    If p.CI = datosReserva.Item(1) Then
                        validarAgente = True
                        personal = p
                        Exit For
                    End If
                Next
                For Each c As Cliente In arrayClientes
                    If c.CI = datosReserva.Item(2) Then
                        validarCliente = True
                        cliente = c
                        Exit For
                    End If
                Next
                For Each prop As Propiedad In arrayPropiedad
                    If prop.ID = datosReserva.Item(2) Then
                        validarPropiedad = True
                        propiedad = prop
                        Exit For
                    End If
                Next
                'Obtiene tambien, la fecha y hora de la visita
                For b = 1 To arrayTables.Item(TableNumReservas).obtenerLongitud - 1
                    If arrayTables.Item(TableNumReservas).columna("Nºreserva").item(b) = datosReserva.Item(4) Then
                        fechaVisita = arrayTables.Item(TableNumReservas).columna("fecha").item(b)
                        horaVisita = arrayTables.Item(TableNumReservas).columna("hora").item(b)
                    End If
                Next

                For Each ag As Agenda In arrayAgenda
                    If ag.Personal.CI = datosReserva.Item(1) Then
                        For Each h As String In ag.Hora
                            If h = horaVisita Then
                                ValidarHora = True
                            End If
                        Next
                    End If
                Next

                'Con todos los datos y las validaciones, crea el objeto visita y lo añade al array correspondiente
                If validarAgente And validarCliente And validarPropiedad And ValidarHora And fechaVisita <> "" And horaVisita <> "" Then
                    Dim visita As New Visita(datosReserva.Item(0), cliente, propiedad, fechaVisita, horaVisita, personal, 0, 0)
                    arrayVisitas.Add(visita)
                End If

            Next

            'Ingreso de datos a la BD

            Dim con As New BDCon
            Dim informe As String = ""
            'Ingresar Clientes

            For Each c As Cliente In arrayClientes
                Try
                    If c.Telefono <> -1 Then
                        con.manipularBD("INSERT INTO personas (CIPersona,Nombre,Apellido,FechaNac,TelPersona,CorreoPersona) VALUES ('" & c.CI & "','" & c.Nombre & "','" & c.Apellido & "','" & c.FechaNac & "','" & c.Telefono & "','" & c.CorreoElectronico & "');")
                    Else
                        con.manipularBD("INSERT INTO personas (CIPersona,Nombre,Apellido,FechaNac,CorreoPersona) VALUES ('" & c.CI & "','" & c.Nombre & "','" & c.Apellido & "','" & c.FechaNac & "','" & c.CorreoElectronico & "');")

                    End If

                Catch ex As Exception
                    informe += "Por alguna razón, el cliente " & c.Nombre & c.Apellido & " no se ha podido ingresar. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)
                End Try

            Next

            'Ingresar Propietarios

            For Each c As Propietario In arrayPropietarios
                Try
                    If c.Telefono <> -1 Then
                        con.manipularBD("INSERT INTO personas (CIPersona,Nombre,Apellido,FechaNac,TelPersona,CorreoPersona) VALUES ('" & c.CI & "','" & c.Nombre & "','" & c.Apellido & "','" & c.FechaNac & "','" & c.Telefono & "','" & c.CorreoElectronico & "');")
                    Else
                        con.manipularBD("INSERT INTO personas (CIPersona,Nombre,Apellido,FechaNac,CorreoPersona) VALUES ('" & c.CI & "','" & c.Nombre & "','" & c.Apellido & "','" & c.FechaNac & "','" & c.CorreoElectronico & "');")

                    End If
                Catch ex As Exception
                    informe += "Por alguna razón, el propietario " & c.Nombre & c.Apellido & " no se ha podido ingresar. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)
                End Try
            Next

            'Ingresar Personal

            For Each c As Personal In arrayPersonal
                Try
                    If c.Telefono <> -1 Then
                        con.manipularBD("INSERT INTO personas (CIPersona,Nombre,Apellido,FechaNac,TelPersona,CorreoPersona) VALUES ('" & c.CI & "','" & c.Nombre & "','" & c.Apellido & "','" & c.FechaNac & "','" & c.Telefono & "','" & c.CorreoElectronico & "');")
                    Else
                        con.manipularBD("INSERT INTO personas (CIPersona,Nombre,Apellido,FechaNac,CorreoPersona) VALUES ('" & c.CI & "','" & c.Nombre & "','" & c.Apellido & "','" & c.FechaNac & "','" & c.CorreoElectronico & "');")

                    End If
                Catch ex As Exception
                    informe += "Por alguna razón, el agente " & c.Nombre & c.Apellido & " no se ha podido ingresar. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)
                End Try
            Next

            'Cargar usuarios

            For Each u As Usuario In arrayUsuarios
                Try

                    Dim data As New DataSet
                    data = con.consulta("select * from usuario where CIPersona='" & u.CI & "'", "Usuario")
                    If data.Tables("Usuario").Rows.Count = 0 Then

                        If u.Pass <> -1 Then

                            con.manipularBD("INSERT INTO usuario(Usr,TipoUsuario,CIPersona,Passwd) VALUES ('" & u.NomUsr & "','" & u.tipoUsr & "','" & u.CI & "','" & u.Pass & "');")
                            Select Case u.tipoUsr
                                Case "C"

                                    Dim idUsr As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & u.CI & "'"))

                                    con.manipularBD("INSERT INTO interesado VALUES(" & idUsr & ");")
                                Case "A"
                                    Dim idUsr As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & u.CI & "'"))

                                    con.manipularBD("INSERT INTO personal VALUES(" & idUsr & ",null);")
                                Case "P"
                                    Dim idUsr As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & u.CI & "'"))

                                    con.manipularBD("INSERT INTO propietario VALUES(" & idUsr & ");")
                            End Select
                        Else
                            con.manipularBD("INSERT INTO usuario(Usr,TipoUsuario,CIPersona,Passwd) VALUES ('" & u.NomUsr & "','" & u.tipoUsr & "','" & u.CI & "','" & u.NomUsr & "');")
                            Select Case u.tipoUsr
                                Case "C"

                                    Dim idUsr As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & u.CI & "'"))

                                    con.manipularBD("INSERT INTO interesado VALUES(" & idUsr & ");")
                                Case "A"

                                    Dim idUsr As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & u.CI & "'"))

                                    con.manipularBD("INSERT INTO personal VALUES(" & idUsr & ",null);")
                                Case "P"

                                    Dim idUsr As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & u.CI & "'"))

                                    con.manipularBD("INSERT INTO propietario VALUES(" & idUsr & ");")
                            End Select
                        End If
                    Else
                        Throw New Exception
                    End If
                Catch ex As Exception
                    informe += "Por alguna razón, el usuario de la persona con CI: " & u.CI & " no se ha podido ingresar. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)
                End Try
            Next

            'Cargar dias

            Dim arrayDias As New ArrayList
            arrayDias.Add("Lunes")
            arrayDias.Add("Martes")
            arrayDias.Add("Miercoles")
            arrayDias.Add("Jueves")
            arrayDias.Add("Viernes")
            arrayDias.Add("Sabado")
            arrayDias.Add("Domingo")

            For Each a As String In arrayDias
                Dim data As New DataSet
                data = con.consulta("select * from dias where Dia='" & a & "'", "dias")
                If data.Tables("dias").Rows.Count = 0 Then
                    con.manipularBD("INSERT INTO dias(Dia) VALUES ('" & a & "');")
                End If
            Next

            'Cargar departamentos

            For Each d As Departamento In arrayDepartamentos
                Try
                    Dim data As New DataSet
                    data = con.consulta("SELECT * FROM departamentos where Nombre='" & d.Nombre & "'", "Departamento")
                    If data.Tables("Departamento").Rows.Count = 0 Then
                        con.manipularBD("INSERT INTO departamentos(Nombre)VALUES('" & d.Nombre & "')")
                    Else
                        Throw New Exception
                    End If
                Catch ex As Exception
                    informe += "Por alguna razón, el departamento " & d.Nombre & " no se ha podido ingresar. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)
                End Try
            Next

            'Cargar Ciudades

            For Each c As Ciudad In arrayCiudades
                Try
                    Dim IDDep As Integer = Val(con.getID("IDDepartamento", "departamentos", "Nombre='" & c.Departamento.Nombre & "'"))

                    Dim data As New DataSet
                    data = con.consulta("SELECT * FROM ciudades where Nombre='" & c.Nombre & "' and IDDepartamento=" & IDDep, "Ciudad")
                    If data.Tables("Ciudad").Rows.Count = 0 Then
                        con.manipularBD("INSERT INTO ciudades(Nombre,IDDepartamento)VALUES('" & c.Nombre & "'," & IDDep & ");")
                    Else
                        Throw New Exception
                    End If
                Catch ex As Exception
                    informe += "Por alguna razón, la ciudad " & c.Nombre & " no se ha podido ingresar. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)
                End Try
            Next

            'Cargar Barrios

            For Each b As Barrio In arrayBarrios
                Try
                    Dim IDCiudad As Integer = Val(con.getID("IDCiudad", "ciudades", "Nombre='" & b.Ciudad.Nombre & "'"))

                    Dim data As New DataSet
                    data = con.consulta("SELECT * FROM barrios where Nombre='" & b.Nombre & "' and IDCiudad=" & IDCiudad & "", "Barrio")
                    If data.Tables("Barrio").Rows.Count = 0 Then
                        con.manipularBD("INSERT INTO barrios(Nombre,IDCiudad) VALUES ('" & b.Nombre & "'," & IDCiudad & ");")
                    Else
                        Throw New Exception
                    End If
                Catch ex As Exception
                    informe += "Por alguna razón, el barrio " & b.Nombre & " no se ha podido ingresar. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)
                End Try
            Next

            'Cargar Propiedades

            For Each p As Propiedad In arrayPropiedad
                Try
                    Dim data As New DataSet
                    Dim IDDepartamento As Integer = Val(con.getID("IDDepartamento", "departamentos", "Nombre='" & FormateadorDeTextos.sacarComillas(p.Departamento) & "'"))
                    Dim IDCiudad As Integer = Val(con.getID("IDCiudad", "ciudades", "Nombre='" & FormateadorDeTextos.sacarComillas(p.Ciudad) & "'"))
                    Dim IDBarrio As Integer = Val(con.getID("IDBarrio", "`barrios`", "Nombre='" & FormateadorDeTextos.sacarComillas(p.Barrio) & "'"))

                    data = con.consulta("SELECT * FROM propiedades where Tipo_Propiedad='" & p.Tipo & "' and IDCiudad=" & IDCiudad & " and IDBarrio=" & IDBarrio & " ", "propiedad")
                    If data.Tables("propiedad").Rows.Count = 0 Then
                        Dim comando As New MySqlCommand
                        comando.CommandText = "INSERT INTO propiedades(IDUsuarioProp,Precio,Tipo_Propiedad,Cantidad_Habitaciones,Cantidad_Baños,IDDepartamento,IDCiudad,IDBarrio,NumCalle,Estado,Superficie_Terreno,Superficie_Cubierta,Antiguedad,Condicion_Propiedad,Nombre,Cantidad_Garajes,Descripcion) VALUES (@IDUsuarioProp," & p.Precio & ",'" & p.Tipo & "'," & p.CantHabitaciones & "," & p.CantBaños & "," & IDDepartamento & "," & IDCiudad & "," & IDBarrio & "," & p.numCalle & ",@Estado,@Superficie_Terreno,@Superficie_Cubierta,@Antiguedad,@Condicion_Propiedad,'" & p.Nombre & "'," & p.CantGarajes & ",'" & p.Descripcion & "');"
                        'Validar propietario
                        Metodos.verificarParametroNull(p.IDProp, comando, MySqlDbType.Int16, "@IDUsuarioProp")
                        'Validar Estado
                        Metodos.verificarParametroNull(p.Estado, comando, MySqlDbType.VarChar, "@Estado")
                        'Validar Superficie
                        Metodos.verificarParametroNull(p.Terreno, comando, MySqlDbType.Decimal, "@Superficie_Terreno")
                        Metodos.verificarParametroNull(p.SuperficieCubierta, comando, MySqlDbType.Decimal, "@Superficie_Cubierta")
                        'Validar Antiguedad
                        Metodos.verificarParametroNull(p.Antiguedad, comando, MySqlDbType.VarChar, "@Antiguedad")
                        'Validar Condicion
                        Metodos.verificarParametroNull(p.Condicion, comando, MySqlDbType.VarChar, "@Condicion_Propiedad")

                        con.manipularBD(comando)

                    Else
                        Throw New Exception
                    End If
                Catch ex As Exception
                    informe += "Por alguna razón, la propiedad " & p.Nombre & " no se ha podido ingresar. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)

                End Try
            Next

            'Cargar agenda

            For Each a As Agenda In arrayAgenda
                Try
                    Dim idUsr As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & a.Personal.CI & "'"))
                    Dim idDia As Integer = Val(con.getID("IDDia", "dias", "Dia='" & a.Dia & "'"))
                    For Each b As Integer In a.Hora
                        Dim data As New DataSet
                        data = con.consulta("select * from agenda where IDUsuarioP=" & idUsr & " and Dia=" & idDia & " and Hora='" & FormateadorDeTextos.FormatoHora(b.ToString) & "'", "agenda")
                        If data.Tables("agenda").Rows.Count = 0 Then
                            con.manipularBD("INSERT INTO agenda(IDUsuarioP,Dia,Hora) VALUES(" & idUsr & "," & idDia & ",'" & FormateadorDeTextos.FormatoHora(b.ToString) & "');")

                        Else
                            Throw New Exception
                        End If
                    Next
                Catch ex As Exception
                    informe += "Por alguna razón, no se ha podido ingresar una de las agendas. Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)

                End Try

            Next

            'Cargar Visitas

            For Each v As Visita In arrayVisitas
                Try
                    Dim idUsrP As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & v.PersonalEncargado.CI & "'"))
                    Dim idUsrI As Integer = Val(con.getID("IDUsuario", "usuario", "CIPersona='" & v.Cliente.CI & "'"))
                    Dim idProp As Integer = Val(con.getID("IDPropiedades", "propiedades", "nombre='" & v.Propiedad.Nombre & "' and Tipo_Propiedad='" & v.Propiedad.Tipo & "' and NumCalle=" & v.Propiedad.numCalle & ""))
                    con.manipularBD("INSERT INTO visita(IDUsuarioI,IDPropiedades,Dia_Visita,Hora_Visita,IDUsuarioP,Modificada,Cancelada) VALUES (" & idUsrI & "," & idProp & ",'" & v.DiaVisita & "'," & FormateadorDeTextos.FormatoHora(v.HoraVisita) & "," & idUsrP & ",0,0);")
                Catch ex As Exception
                    informe += "Por alguna razón, no se ha podido ingresar la visita de el cliente de CI " & v.Cliente.CI & " a la propiedad " & v.Propiedad.Nombre & ". Posiblemente este ya haya sido ingresado en la BD" & Chr(Keys.Enter)

                End Try

            Next
            If informe = "" Then
                MsgBox("Todo ha concluido correctamente")
            Else
                If MsgBox("Desea ver el informe del ingreso de datos?", vbYesNo) = MsgBoxResult.Yes Then
                    MsgBox(informe)
                End If
            End If

        Else
            MsgBox("No se ha seleccionado ningun excel")
        End If
    End Sub


End Class