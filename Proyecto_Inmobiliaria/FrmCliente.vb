Public Class FrmCliente
    Dim casa1, casa2, casa3, casa4, casa5, casa6 As New Propiedad
    Dim filtro As New DataSet
    Dim filtro2 As New DataSet
    Dim test As String = ""
    Dim modif As Boolean = False
    Dim ID As String = ""




    Public conexion As New BDCon

    Shadows menu As New ClassMenu(Me)

    Public Sub cargarpresprop(prop As Propiedad, pbx As PictureBox, lblpreciop As Label, lbltipop As Label, lblestadop As Label)
        'Verifica y carga Precio
        If prop.Precio = -1 Then
            lblpreciop.Text = "S/E"
        Else
            lblpreciop.Text = "$" & prop.Precio
        End If
        'Verifica y carga Tipo
        If prop.Tipo = "-1" Then
            lbltipop.Text = "S/E"
        Else
            lbltipop.Text = prop.Tipo
        End If
        'Verifica y carga Estado
        If prop.Estado = "-1" Then
            lblestadop.Text = "S/E"
        Else
            lblestadop.Text = prop.Estado
        End If

        pbx.Image = New Bitmap(prop.Imagenes(prop.Imagenes.Count - 1), pbx.Size)
    End Sub



    Public Sub cargarlasprop(consulta As String)


        Dim arraypropiedad As New ArrayList

        arraypropiedad = conexion.cargarpropBD(numprop, consulta)


        'Casa 1
        Try
            casa1 = arraypropiedad.Item(0)
            cargarpresprop(casa1, PbxCasa1, LblPrecio1, LblTipo1, LblEstado1)
            PbxCasa1.Visible = True

        Catch ex As Exception
            PbxCasa1.Visible = False
            PnlCasa1.Visible = False
        End Try


        'Casa 2
        Try
            casa2 = arraypropiedad.Item(1)
            cargarpresprop(casa2, PbxCasa2, LblPrecio2, LblTipo2, LblEstado2)
            PbxCasa2.Visible = True

        Catch ex As Exception
            PbxCasa2.Visible = False
            PnlCasa2.Visible = False
        End Try

        'Casa 3
        Try
            casa3 = arraypropiedad.Item(2)
            cargarpresprop(casa3, PbxCasa3, LblPrecio3, LblTipo3, LblEstado3)
            PbxCasa3.Visible = True

        Catch ex As Exception
            PbxCasa3.Visible = False
            PnlCasa3.Visible = False
        End Try

        'Casa 4
        Try
            casa4 = arraypropiedad.Item(3)
            cargarpresprop(casa4, PbxCasa4, LblPrecio4, LblTipo4, LblEstado4)
            PbxCasa4.Visible = True

        Catch ex As Exception
            PbxCasa4.Visible = False
            PnlCasa4.Visible = False
        End Try

        'Casa5
        Try
            casa5 = arraypropiedad.Item(4)
            cargarpresprop(casa5, PbxCasa5, LblPrecio5, LblTipo5, LblEstado5)
            PbxCasa5.Visible = True

        Catch ex As Exception
            PbxCasa5.Visible = False
            PnlCasa5.Visible = False
        End Try

        'Casa6
        Try
            casa6 = arraypropiedad.Item(5)
            cargarpresprop(casa6, PbxCasa6, LblPrecio6, LblTipo6, LblEstado6)
            PbxCasa6.Visible = True

        Catch ex As Exception
            PbxCasa6.Visible = False
            PnlCasa6.Visible = False
        End Try
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles Me.Load

        rbnSinEspecificar.Checked = True

        'cargar departamentos
        filtro = conexion.consulta("select * from departamentos", "departamentos")
        For i = 0 To filtro.Tables("departamentos").Rows.Count - 1
            CbxDepartamento.Items.Add(filtro.Tables("departamentos").Rows(i).Item(1).ToString)
        Next



        CbxTipo.SelectedIndex = 0
        CbxDepartamento.SelectedIndex = 0
        CbxCiudad.SelectedIndex = 0
        CbxBarrio.SelectedIndex = 0
        CbxCondicion.SelectedIndex = 0

        cargarlasprop(consulta & cambiarlimite(numprop))

        menu.MnuStIUsuario.Text = "Cliente"

        If Metodos.log = False Then
            menu.MnuStIUsuario.Text = "Bienvenido"
        End If

        Metodos.mantenertema(Me)

        cambiarimagen(BtnBuscar, New Bitmap(My.Resources.Lupa, BtnBuscar.Size.Width, BtnBuscar.Size.Height))


    End Sub

    Public Function cambiarlimite(numprop As Integer) As String
        Return " limit " & numprop.ToString & ",6"
    End Function

    Private Sub cambiarimagen(objeto As Object, imagen As Bitmap)
        objeto.Image = imagen
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Metodos.volverlogin(Me)
    End Sub


    Private Sub TxtDesdeP_Enter(sender As Object, e As EventArgs) Handles TxtDesdeP.Enter
        Metodos.MtdEnterAlTxt(TxtDesdeP, "Desde")
    End Sub

    Private Sub TxtDesdeT_Enter(sender As Object, e As EventArgs) Handles TxtDesdeT.Enter
        Metodos.MtdEnterAlTxt(TxtDesdeT, "Desde")
    End Sub

    Private Sub TxtDesdeTC_Enter(sender As Object, e As EventArgs) Handles TxtDesdeTC.Enter
        Metodos.MtdEnterAlTxt(TxtDesdeTC, "Desde")
    End Sub

    Private Sub TxtDesdeA_Enter(sender As Object, e As EventArgs) Handles TxtDesdeA.Enter
        Metodos.MtdEnterAlTxt(TxtDesdeA, "Desde")
    End Sub

    Private Sub TxtDesdeP_Leave(sender As Object, e As EventArgs) Handles TxtDesdeP.Leave
        Metodos.validardh(TxtHastaP, sender, "El precio base no debe ser mayor al precio limite")
        Metodos.MtdLeaveAlTxt(TxtDesdeP, "Desde")

    End Sub

    Private Sub TxtDesdeT_Leave(sender As Object, e As EventArgs) Handles TxtDesdeT.Leave
        Metodos.validardh(TxtHastaT, sender, "El terreno base no debe ser mayor al terreno limite")
        Metodos.MtdLeaveAlTxt(TxtDesdeT, "Desde")
    End Sub

    Private Sub TxtDesdeTC_Leave(sender As Object, e As EventArgs) Handles TxtDesdeTC.Leave
        Metodos.validardh(TxtHastaTC, sender, "El terreno cubierto base no debe ser mayor al terreno cubierto limite")
        Metodos.MtdLeaveAlTxt(TxtDesdeTC, "Desde")
    End Sub

    Private Sub TxtDesdeA_Leave(sender As Object, e As EventArgs) Handles TxtDesdeA.Leave
        Metodos.validardh(TxtHastaA, sender, "La antiguedad base no debe ser mayor a la antiguedad limite")
        Metodos.MtdLeaveAlTxt(TxtDesdeA, "Desde")
    End Sub

    Private Sub TxtHastaP_Enter(sender As Object, e As EventArgs) Handles TxtHastaP.Enter
        Metodos.MtdEnterAlTxt(TxtHastaP, "Hasta")
    End Sub

    Private Sub TxtHastaT_Enter(sender As Object, e As EventArgs) Handles TxtHastaT.Enter
        Metodos.MtdEnterAlTxt(TxtHastaT, "Hasta")
    End Sub

    Private Sub TxtHastaTC_Enter(sender As Object, e As EventArgs) Handles TxtHastaTC.Enter
        Metodos.MtdEnterAlTxt(TxtHastaTC, "Hasta")
    End Sub

    Private Sub TxtHastaA_Enter(sender As Object, e As EventArgs) Handles TxtHastaA.Enter
        Metodos.MtdEnterAlTxt(TxtHastaA, "Hasta")
    End Sub

    Private Sub TxtHastaP_Leave(sender As Object, e As EventArgs) Handles TxtHastaP.Leave
        Metodos.validarhd(TxtDesdeP, sender, "No ha ingresado el precio base", "El precio base no puede ser mayor al precio limite")
        Metodos.MtdLeaveAlTxt(TxtHastaP, "Hasta")

    End Sub

    Private Sub TxtHastaT_Leave(sender As Object, e As EventArgs) Handles TxtHastaT.Leave
        Metodos.validarhd(TxtDesdeT, sender, "No ha ingresado la medida del terreno base", "La medida base base del terreno no puede ser mayor a la medida limite")
        Metodos.MtdLeaveAlTxt(TxtHastaT, "Hasta")
    End Sub

    Private Sub TxtHastaTC_Leave(sender As Object, e As EventArgs) Handles TxtHastaTC.Leave
        Metodos.validarhd(TxtDesdeTC, sender, "No ha ingresado la medida del terreno cubierto base", "La medida base base del terreno cubierto no puede ser mayor a la medida limite")
        Metodos.MtdLeaveAlTxt(TxtHastaTC, "Hasta")
    End Sub

    Private Sub TxtHastaA_Leave(sender As Object, e As EventArgs) Handles TxtHastaA.Leave
        Metodos.validarhd(TxtDesdeA, sender, "No ha ingresado la antiguedad base", "La antiguedad base no puede ser mayor a la antiguedad limite")
        Metodos.MtdLeaveAlTxt(TxtHastaA, "Hasta")
    End Sub

    Private Sub TxtUser_Leave(sender As Object, e As EventArgs) Handles TxtBuscar.Leave
        Metodos.MtdLeaveAlTxt(TxtBuscar, "Buscar por ID")
    End Sub

    Private Sub TxtBuscar_Enter(sender As Object, e As EventArgs) Handles TxtBuscar.Enter
        Metodos.MtdEnterAlTxt(TxtBuscar, "Buscar por ID")
    End Sub

    Private Sub CerrarSeciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Metodos.volverlogin(Me)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

    End Sub



    Private Sub PnlCasa2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PnlCasa2_Click(sender As Object, e As EventArgs)
        Metodos.cambiarform(Me, FrmAgendar)
    End Sub

    Private Sub PnlCasa3_Click(sender As Object, e As EventArgs)
        Metodos.cambiarform(Me, FrmAgendar)
    End Sub

    Private Sub PnlCasa4_Click(sender As Object, e As EventArgs)
        Metodos.cambiarform(Me, FrmAgendar)
    End Sub

    Private Sub PnlCasa5_Click(sender As Object, e As EventArgs)
        Metodos.cambiarform(Me, FrmAgendar)
    End Sub

    Private Sub PnlCasa6_Click(sender As Object, e As EventArgs)
        Metodos.cambiarform(Me, FrmAgendar)
    End Sub

    Private Sub LblCasa1_MouseEnter(sender As Object, e As EventArgs) Handles PbxCasa1.MouseEnter
        PnlCasa1.Visible = True
    End Sub

    Private Sub LblCasa1_MouseLeave(sender As Object, e As EventArgs) Handles PbxCasa1.MouseLeave
        PnlCasa1.Visible = False
    End Sub

    Private Sub LblCasa2_MouseEnter(sender As Object, e As EventArgs) Handles PbxCasa2.MouseEnter
        PnlCasa2.Visible = True
    End Sub

    Private Sub LblCasa3_MouseEnter(sender As Object, e As EventArgs) Handles PbxCasa3.MouseEnter
        PnlCasa3.Visible = True
    End Sub

    Private Sub LblCasa4_MouseEnter(sender As Object, e As EventArgs) Handles PbxCasa4.MouseEnter
        PnlCasa4.Visible = True
    End Sub

    Private Sub LblCasa6_MouseEnter(sender As Object, e As EventArgs) Handles PbxCasa6.MouseEnter
        PnlCasa6.Visible = True
    End Sub

    Private Sub LblCasa2_MouseLeave(sender As Object, e As EventArgs) Handles PbxCasa2.MouseLeave
        PnlCasa2.Visible = False
    End Sub

    Private Sub LblCasa3_MouseLeave(sender As Object, e As EventArgs) Handles PbxCasa3.MouseLeave
        PnlCasa3.Visible = False
    End Sub

    Private Sub LblCasa4_MouseLeave(sender As Object, e As EventArgs) Handles PbxCasa4.MouseLeave
        PnlCasa4.Visible = False
    End Sub

    Private Sub LblCasa6_MouseLeave(sender As Object, e As EventArgs) Handles PbxCasa6.MouseLeave
        PnlCasa6.Visible = False
    End Sub

    Private Sub LblCasa1_Click(sender As Object, e As EventArgs) Handles PbxCasa1.Click
        Metodos.cargarimg(FrmAgendar.images, casa1.Imagenes)
        Metodos.MtdDatosPropiedades(casa1)
        Metodos.cambiarform(Me, FrmAgendar)
    End Sub

    Private Sub TxtDesdeP_TextChanged(sender As Object, e As EventArgs) Handles TxtDesdeP.KeyUp
        Metodos.validarnumeros(TxtDesdeP)
    End Sub

    Private Sub TxtHastaP_TextChanged(sender As Object, e As EventArgs) Handles TxtHastaP.KeyUp
        Metodos.validarnumeros(TxtHastaP)
    End Sub

    Private Sub TxtDesdeT_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtDesdeT.KeyUp
        Metodos.validarnumeros(TxtDesdeT)
    End Sub

    Private Sub TxtHastaT_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtHastaT.KeyUp
        Metodos.validarnumeros(TxtHastaT)
    End Sub

    Private Sub TxtDesdeTC_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtDesdeTC.KeyUp
        Metodos.validarnumeros(TxtDesdeTC)
    End Sub

    Private Sub TxtHastaTC_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtHastaTC.KeyUp
        Metodos.validarnumeros(TxtHastaTC)
    End Sub

    Private Sub TxtDesdeA_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtDesdeA.KeyUp
        Metodos.validarnumeros(TxtDesdeA)
    End Sub

    Private Sub TxtHastaA_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtHastaA.KeyUp
        Metodos.validarnumeros(TxtHastaA)
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.KeyUp
        Metodos.validarnumeros(TxtBuscar)
    End Sub

    Private Sub BtnPagAnterior_Click(sender As Object, e As EventArgs) Handles BtnPagAnterior.Click
        Metodos.buttonanimation(BtnPagAnterior)
        If Metodos.numprop > 1 Then
            Metodos.numprop -= 6

            cargarlasprop(consulta & cambiarlimite(numprop))
        End If
        If PbxCasa6.Visible Then
            BtnPagSiguiente.Enabled = True
        End If
    End Sub

    Private Sub BtnPagSiguiente_Click(sender As Object, e As EventArgs) Handles BtnPagSiguiente.Click
        Metodos.buttonanimation(BtnPagSiguiente)
        Metodos.numprop += 6
        cargarlasprop(consulta & cambiarlimite(numprop))
        If PbxCasa6.Visible = False And PbxCasa5.Visible = False And PbxCasa4.Visible = False And PbxCasa3.Visible = False And PbxCasa2.Visible = False And PbxCasa1.Visible = False Then
            MsgBox("Ya no hay mas propiedades", vbCritical, "Error")
            Metodos.numprop -= 6
            cargarlasprop(consulta & cambiarlimite(numprop))
        End If
    End Sub

    Private Sub TxtDesdeP_TextChanged_1(sender As Object, e As EventArgs) Handles TxtDesdeP.TextChanged

    End Sub

    Private Sub PbxCasa5_MouseEnter(sender As Object, e As EventArgs) Handles PbxCasa5.MouseEnter
        Me.PnlCasa5.Visible = True
    End Sub

    Private Sub PbxCasa5_MouseLeave(sender As Object, e As EventArgs) Handles PbxCasa5.MouseLeave
        Me.PnlCasa5.Visible = False
    End Sub

    Private Sub BtnAplicar_Click(sender As Object, e As EventArgs) Handles BtnAplicar.Click


        consulta = "SELECT IDPropiedades,IDUsuarioProp,Precio,Tipo_Propiedad,Cantidad_Habitaciones,Cantidad_Baños,NumCalle,Estado,Superficie_Terreno,Superficie_Cubierta,Antiguedad,Condicion_Propiedad,Nombre,Cantidad_Garajes,Descripcion FROM propiedades where "

        'Precio
        If TxtDesdeP.Text = "Desde" And TxtHastaP.Text <> "Hasta" Then
            'max
            'filtro = conexion.consulta("Select * from propiedades where Precio_Alquiler<" & TxtHastaP.Text, "Propiedades")
            consulta += "Precio<" & TxtHastaP.Text
            modif = True

        ElseIf TxtDesdeP.Text <> "Desde" And TxtHastaP.Text = "Hasta" Then
            'min
            'filtro = conexion.consulta("Select * from propiedades where Precio_Alquiler>" & TxtDesdeP.Text, "Propiedades")
            consulta += "Precio>" & TxtDesdeP.Text
            modif = True
        ElseIf TxtDesdeP.Text <> "Desde" And TxtHastaP.Text <> "Hasta" Then
            'min y max
            'filtro = conexion.consulta("Select * from propiedades where Precio_Alquiler between " & TxtDesdeP.Text & " And " & TxtHastaP.Text, "Propiedades")
            consulta += "Precio between " & TxtDesdeP.Text & " And " & TxtHastaP.Text
            modif = True
        End If

        'Tipo
        If CbxTipo.SelectedItem <> "(Sin especificar)" Then
            If modif = True Then
                consulta += " And Tipo_Propiedad Like '" & CbxTipo.Text & "'"
            Else
                consulta += "Tipo_Propiedad Like '" & CbxTipo.Text & "'"
                modif = True
            End If
            'filtro = conexion.consulta("Select * from propiedades where Tipo_Propiedad Like '" & CbxTipo.Text & "'", "Propiedades")
        End If


        'Habitaciones
        Dim hab As String = ""
        If ChkHab1.Checked Then
            hab = hab & ",1"
        End If
        If ChkHab2.Checked Then
            hab = hab & ",2"
        End If
        If ChkHab3.Checked Then
            hab = hab & ",3"
        End If
        If ChkHab4.Checked Then
            hab = hab & ",4"
        End If




        If hab <> "" Then
            Dim a As New ArrayList
            For i = 0 To hab.Length - 1
                a.Add(hab.Chars(i))
            Next
            a.RemoveAt(0)
            hab = ""
            For i = 0 To a.Count - 1
                hab += a.Item(i)
            Next

            If modif = True Then
                consulta += " and Cantidad_Habitaciones in (" & hab & ")"
            Else
                consulta += "Cantidad_Habitaciones in (" & hab & ")"
                modif = True
            End If
            'filtro = conexion.consulta("select * from propiedades where Cantidad_Habitaciones in (" & hab & ")", "Propiedades")
        End If

        If ChkHab5.Checked Then
            'filtro2 = conexion.consulta("select * from propiedades where Cantidad_Habitaciones>5", "Propiedades")

            If hab = "" Then

                If modif = True Then
                    consulta += " and Cantidad_Habitaciones>4"
                Else
                    consulta += "Cantidad_Habitaciones>4"
                    modif = True
                End If

            Else

                If modif = True Then
                    'consulta += " or Cantidad_Habitaciones>4"
                    consulta = "select * From propiedades Where ( Cantidad_Habitaciones In (" & hab & ") or Cantidad_Habitaciones>4 )"
                Else
                    consulta += "Cantidad_Habitaciones>4"
                    modif = True
                End If

            End If

        End If

        'Baños
        Dim bañ As String = ""
        If ChkBaños1.Checked Then
            bañ = bañ & ",1"
        End If
        If ChkBaños2.Checked Then
            bañ = bañ & ",2"
        End If

        If bañ <> "" Then
            Dim aa As New ArrayList
            For i = 0 To bañ.Length - 1
                aa.Add(bañ.Chars(i))
            Next
            aa.RemoveAt(0)
            bañ = ""
            For i = 0 To aa.Count - 1
                bañ += aa.Item(i)
            Next

            If modif = True Then
                consulta += " And Cantidad_Baños In (" & bañ & ")"
            Else
                consulta += "Cantidad_Baños In (" & bañ & ")"
                modif = True
            End If
            'filtro = conexion.consulta("Select * from propiedades where Cantidad_Baños In (" & bañ & ")", "Propiedades")
        End If

        If ChkBaños3.Checked Then

            If bañ = "" Then

                If modif = True Then
                    consulta += " And Cantidad_Baños>2"
                Else
                    consulta += "Cantidad_Baños>2"
                    modif = True
                End If

            Else

                If modif = True Then
                    'consulta += " Or Cantidad_Baños>2"
                    consulta = "select * from propiedades where ( Cantidad_Baños In (" & bañ & ") Or Cantidad_Baños>2 )"
                Else
                    consulta += "Cantidad_Baños>2"
                    modif = True
                End If

            End If

        End If


        'Garage
        Dim garage As String = ""
        If ChkGarage1.Checked Then
            garage = garage & ",1"
        End If
        If ChkGarage2.Checked Then
            garage = garage & ",2"
        End If

        If garage <> "" Then
            Dim aaa As New ArrayList
            For i = 0 To garage.Length - 1
                aaa.Add(garage.Chars(i))
            Next
            aaa.RemoveAt(0)
            garage = ""
            For i = 0 To aaa.Count - 1
                garage += aaa.Item(i)
            Next

            If modif = True Then
                consulta += " And Cantidad_Garajes In (" & garage & ")"
            Else
                consulta += "Cantidad_Garajes In (" & garage & ")"
                modif = True
            End If
            'filtro = conexion.consulta("Select * from propiedades where Cantidad_Garajes In (" & garage & ")", "Propiedades")
        End If

        If ChkGarage3.Checked Then
            'filtro2 = conexion.consulta("Select * from propiedades where Cantidad_Garajes>3", "Propiedades")

            If ChkGarage3.Checked Then

                If garage = "" Then

                    If modif = True Then
                        consulta += " And Cantidad_Garajes>2"
                    Else
                        consulta += "Cantidad_Garajes>2"
                        modif = True
                    End If

                Else

                    If modif = True Then
                        'consulta += " Or Cantidad_Garajes>2"
                        consulta = "select * from propiedades where ( Cantidad_Garajes In (" & garage & ") Or Cantidad_Garajes>2 )"
                    Else
                        consulta += "Cantidad_Garajes>2"
                        modif = True
                    End If

                End If

            End If

        End If

        'Departamento
        If CbxDepartamento.SelectedItem <> "(Sin especificar)" Then
            filtro = conexion.consulta("Select * from departamentos where nombre Like '" & CbxDepartamento.Text & "'", "departamentos")

            If modif = True Then
                consulta += " and IDDepartamento=" & filtro.Tables("departamentos").Rows(0).Item(0).ToString()
            Else
                consulta += "IDDepartamento=" & filtro.Tables("departamentos").Rows(0).Item(0).ToString()
                modif = True
            End If
        End If

        'Ciudad
        If CbxCiudad.SelectedItem <> "(Sin especificar)" Then
            filtro = conexion.consulta("select * from ciudades where nombre like '" & CbxCiudad.Text & "'", "ciudades")
            If modif = True Then
                consulta += " and IDCiudad=" & filtro.Tables("ciudades").Rows(0).Item(0).ToString()
            Else
                consulta += "IDCiudad=" & filtro.Tables("ciudades").Rows(0).Item(0).ToString()
                modif = True
            End If
        End If

        'Barrio
        If CbxBarrio.SelectedItem <> "(Sin especificar)" Then
            filtro = conexion.consulta("select * from barrios where nombre like '" & CbxBarrio.Text & "'", "barrios")
            If modif = True Then
                consulta += " and IDBarrio=" & filtro.Tables("barrios").Rows(0).Item(0).ToString()
            Else
                consulta += "IDBarrio=" & filtro.Tables("barrios").Rows(0).Item(0).ToString()
                modif = True
            End If
        End If

        'Estado
        If RbnAlquiler.Checked Then
            'filtro = conexion.consulta("select * from propiedades where estado like 'Alquiler'", "Propiedades")
            If modif = True Then
                consulta += " and estado like 'Alquiler'"
            Else
                consulta += "estado like 'Alquiler'"
                modif = True
            End If
        ElseIf RbnCompra.Checked Then
            'filtro = conexion.consulta("select * from propiedades where estado like 'Venta'", "Propiedades")
            If modif = True Then
                consulta += " and estado like 'Venta'"
            Else
                consulta += "estado like 'Venta'"
                modif = True
            End If
        End If

        'Terreno
        If TxtDesdeT.Text = "Desde" And TxtHastaT.Text <> "Hasta" Then
            'max
            'filtro = conexion.consulta("select * from propiedades where Superficie_Terreno<" & TxtHastaT.Text, "Propiedades")
            If modif = True Then
                consulta += " and Superficie_Terreno<" & TxtHastaT.Text
            Else
                consulta += "Superficie_Terreno<" & TxtHastaT.Text
                modif = True
            End If
        ElseIf TxtDesdeT.Text <> "Desde" And TxtHastaT.Text = "Hasta" Then
            'min
            'filtro = conexion.consulta("select * from propiedades where Superficie_Terreno>" & TxtDesdeT.Text, "Propiedades")
            If modif = True Then
                consulta += " and Superficie_Terreno>" & TxtDesdeT.Text
            Else
                consulta += "Superficie_Terreno>" & TxtDesdeT.Text
                modif = True
            End If
        ElseIf TxtDesdeT.Text <> "Desde" And TxtHastaT.Text <> "Hasta" Then
            'min y max
            'filtro = conexion.consulta("select * from propiedades where Superficie_Terreno between " & TxtDesdeT.Text & " and " & TxtHastaT.Text, "Propiedades")
            If modif = True Then
                consulta += " and Superficie_Terreno between " & TxtDesdeT.Text & " and " & TxtHastaT.Text
            Else
                consulta += "Superficie_Terreno between " & TxtDesdeT.Text & " and " & TxtHastaT.Text
                modif = True
            End If
        End If

        'Terreno Cubierto
        If TxtDesdeTC.Text = "Desde" And TxtHastaTC.Text <> "Hasta" Then
            'max
            'filtro = conexion.consulta("select * from propiedades where Superficie_Cubierta<" & TxtHastaTC.Text, "Propiedades")
            If modif = True Then
                consulta += " and Superficie_Cubierta<" & TxtHastaTC.Text
            Else
                consulta += "Superficie_Cubierta<" & TxtHastaTC.Text
                modif = True
            End If
        ElseIf TxtDesdeTC.Text <> "Desde" And TxtHastaTC.Text = "Hasta" Then
            'min
            'filtro = conexion.consulta("select * from propiedades where Superficie_Cubierta>" & TxtDesdeTC.Text, "Propiedades")
            If modif = True Then
                consulta += " and Superficie_Cubierta>" & TxtDesdeTC.Text
            Else
                consulta += "Superficie_Cubierta>" & TxtDesdeTC.Text
                modif = True
            End If
        ElseIf TxtDesdeTC.Text <> "Desde" And TxtHastaTC.Text <> "Hasta" Then
            'min y max
            'filtro = conexion.consulta("select * from propiedades where Superficie_Cubierta between " & TxtDesdeTC.Text & " and " & TxtHastaTC.Text, "Propiedades")
            If modif = True Then
                consulta += " and Superficie_Cubierta between " & TxtDesdeTC.Text & " and " & TxtHastaTC.Text
            Else
                consulta += "Superficie_Cubierta between " & TxtDesdeTC.Text & " and " & TxtHastaTC.Text
                modif = True
            End If
        End If

        'Antiguedad
        If TxtDesdeA.Text = "Desde" And TxtHastaA.Text <> "Hasta" Then
            'max
            'filtro = conexion.consulta("select * from propiedades where Antiguedad<" & TxtHastaA.Text, "Propiedades")
            If modif = True Then
                consulta += " and Antiguedad<" & TxtHastaA.Text
            Else
                consulta += "Antiguedad<" & TxtHastaA.Text
                modif = True
            End If
        ElseIf TxtDesdeA.Text <> "Desde" And TxtHastaA.Text = "Hasta" Then
            'min
            'filtro = conexion.consulta("select * from propiedades where Antiguedad>" & TxtDesdeA.Text, "Propiedades")
            If modif = True Then
                consulta += " and Antiguedad>" & TxtDesdeA.Text
            Else
                consulta += "Antiguedad>" & TxtDesdeA.Text
                modif = True
            End If
        ElseIf TxtDesdeA.Text <> "Desde" And TxtHastaA.Text <> "Hasta" Then
            'min y max
            'filtro = conexion.consulta("select * from propiedades where Antiguedad between " & TxtDesdeA.Text & " and " & TxtHastaA.Text, "Propiedades")
            If modif = True Then
                consulta += " and Antiguedad between " & TxtDesdeA.Text & " and " & TxtHastaA.Text
            Else
                consulta += "Antiguedad between " & TxtDesdeA.Text & " and " & TxtHastaA.Text
                modif = True
            End If
        End If

        'Condicion
        If CbxCondicion.SelectedItem <> "(Sin especificar)" Then
            'filtro = conexion.consulta("select * from propiedades where Condicion_Propiedad like '" & CbxCondicion.Text & "'", "Propiedades")
            If modif = True Then
                consulta += " and Condicion_Propiedad like '" & CbxCondicion.Text & "'"
            Else
                consulta += "Condicion_Propiedad like '" & CbxCondicion.Text & "'"
                modif = True
            End If
        End If




        If consulta <> "SELECT IDPropiedades,IDUsuarioProp,Precio,Tipo_Propiedad,Cantidad_Habitaciones,Cantidad_Baños,NumCalle,Estado,Superficie_Terreno,Superficie_Cubierta,Antiguedad,Condicion_Propiedad,Nombre,Cantidad_Garajes,Descripcion FROM propiedades where " Then
            numprop = 0
            cargarlasprop(consulta & cambiarlimite(numprop))
        Else
            consulta = "SELECT IDPropiedades,IDUsuarioProp,Precio,Tipo_Propiedad,Cantidad_Habitaciones,Cantidad_Baños,NumCalle,Estado,Superficie_Terreno,Superficie_Cubierta,Antiguedad,Condicion_Propiedad,Nombre,Cantidad_Garajes,Descripcion FROM propiedades"
            cargarlasprop(consulta & cambiarlimite(numprop))
        End If

        modif = False


        'Probar
        'For i = 0 To filtro.Tables("Propiedades").Rows.Count - 1
        '
        'For n = 0 To filtro.Tables("Propiedades").Rows(i).ItemArray.Count - 1
        'test = test & filtro.Tables("Propiedades").Rows(i).Item(n).ToString
        'test = test & Chr(Keys.Space)
        'Next
        'test = test & Chr(Keys.Enter)
        ' Next
        ' MsgBox(test)

    End Sub

    Public Function verificarpropiedad(prop As Propiedad) As Boolean
        If prop.Imagenes.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CbxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxDepartamento.SelectedIndexChanged
        If CbxDepartamento.Text <> "(Sin especificar)" Then
            CbxCiudad.Items.Clear()
            CbxCiudad.Items.Add("(Sin especificar)")
            CbxCiudad.SelectedIndex = 0
            CbxBarrio.Items.Clear()
            CbxBarrio.Items.Add("(Sin especificar)")
            CbxBarrio.SelectedIndex = 0
            filtro2 = conexion.consulta("select IDDepartamento from departamentos where Nombre= '" & CbxDepartamento.SelectedItem.ToString & "'", "departamentos")

            'cargar ciudades
            filtro = conexion.consulta("select * from ciudades where IDDepartamento=" & filtro2.Tables("departamentos").Rows(0).Item(0).ToString, "ciudades")
            For i = 0 To filtro.Tables("ciudades").Rows.Count - 1
                CbxCiudad.Items.Add(filtro.Tables("ciudades").Rows(i).Item(1).ToString)
            Next
        End If
    End Sub

    Private Sub CbxCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCiudad.SelectedIndexChanged
        If CbxCiudad.Text <> "(Sin especificar)" Then
            CbxBarrio.Items.Clear()
            CbxBarrio.Items.Add("(Sin especificar)")
            CbxBarrio.SelectedIndex = 0
            filtro2 = conexion.consulta("select * from ciudades where Nombre= '" & CbxCiudad.SelectedItem.ToString & "'", "ciudades")

            'cargar barrios
            filtro = conexion.consulta("select * from barrios where IDCiudad=" & filtro2.Tables("ciudades").Rows(0).Item(0).ToString, "barrios")
            For i = 0 To filtro.Tables("barrios").Rows.Count - 1
                CbxBarrio.Items.Add(filtro.Tables("barrios").Rows(i).Item(1).ToString)
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cargarlasprop("SELECT IDPropiedades,IDUsuarioProp,Precio,Tipo_Propiedad,Cantidad_Habitaciones,Cantidad_Baños,NumCalle,Estado,Superficie_Terreno,Superficie_Cubierta,Antiguedad,Condicion_Propiedad,Nombre,Cantidad_Garajes,Descripcion FROM propiedades")

        For Each cbx As ComboBox In Me.PnlFiltros.Controls.OfType(Of ComboBox)
            cbx.SelectedIndex = 0
        Next
        For Each rbn As RadioButton In Me.PnlFiltros.Controls.OfType(Of RadioButton)
            If rbn.Tag = "marcar" Then
                rbn.Checked = True
            Else
                rbn.Checked = False
            End If
        Next
        For Each txt As TextBox In Me.PnlFiltros.Controls.OfType(Of TextBox)
            If txt.Tag = "desde" Then

                txt.Text = "Desde"
                txt.ForeColor = Color.Gray

            Else

                txt.Text = "Hasta"
                txt.ForeColor = Color.Gray

            End If
        Next
        For Each chk As CheckBox In Me.PnlFiltros.Controls.OfType(Of CheckBox)
            chk.Checked = False
        Next


    End Sub

    Private Sub LblCasa2_Click(sender As Object, e As EventArgs) Handles PbxCasa2.Click
        Metodos.cargarimg(FrmAgendar.images, casa2.Imagenes)
        Metodos.MtdDatosPropiedades(casa2)
        Metodos.cambiarform(Me, FrmAgendar)

    End Sub

    Private Sub LblCasa3_Click(sender As Object, e As EventArgs) Handles PbxCasa3.Click
        Metodos.cargarimg(FrmAgendar.images, casa3.Imagenes)
        Metodos.MtdDatosPropiedades(casa3)
        Metodos.cambiarform(Me, FrmAgendar)


    End Sub

    Private Sub LblCasa4_Click(sender As Object, e As EventArgs) Handles PbxCasa4.Click
        Metodos.cargarimg(FrmAgendar.images, casa4.Imagenes)
        Metodos.MtdDatosPropiedades(casa4)
        Metodos.cambiarform(Me, FrmAgendar)


    End Sub

    Private Sub LblCasa5_Click(sender As Object, e As EventArgs) Handles PbxCasa5.Click
        Metodos.cargarimg(FrmAgendar.images, casa5.Imagenes)
        Metodos.MtdDatosPropiedades(casa5)
        Metodos.cambiarform(Me, FrmAgendar)


    End Sub

    Private Sub LblCasa6_Click(sender As Object, e As EventArgs) Handles PbxCasa6.Click
        Metodos.cargarimg(FrmAgendar.images, casa6.Imagenes)
        Metodos.MtdDatosPropiedades(casa6)
        Metodos.cambiarform(Me, FrmAgendar)


    End Sub

End Class