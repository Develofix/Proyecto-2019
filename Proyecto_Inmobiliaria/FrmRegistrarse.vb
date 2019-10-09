Imports System.Text.RegularExpressions

Public Class FrmRegistrarse
    Dim contrasenia As String = 123
    Shadows menu As New ClassMenu(Me)


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Metodos.volverlogin(Me)
    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs)
        PnlRegistro.Visible = False

    End Sub

    Private Sub FrmRegistrarse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTPFechaNac.MaxDate = New Date(Now.Year - 18, Now.Month, Now.Day)
        DTPFechaNac.MinDate = New Date(Now.Year - 150, Now.Month, Now.Day)

        Me.DTPFechaNac.MaxDate = Now.Date
        Metodos.mantenertema(Me)
        Dim conexion As New BDCon
        Dim dato As New DataSet
        dato = conexion.consulta("select * from sucursales", "sucursales")

        For a = 0 To dato.Tables("sucursales").Rows.Count - 1

            CbxSucursales.Items.Add(dato.Tables("sucursales").Rows(a).Item(6).ToString)

        Next
        dato.Clear()
        dato = conexion.consulta("select Nombre, Apellido from Personas,Usuario where usuario.CIPersona=Personas.CIPersona And Usuario.IDUsuario=" & Metodos.usr.ToString, "personas")
        If Metodos.volver.Equals(False) Then
            menu.MnuStIUsuario.Text = "Bienvenido"
            menu.MnuStIUsuario.Enabled = False
        Else
            menu.MnuStIUsuario.Text = "Gerente"
            menu.MnuStIUsuario.Enabled = True
            Me.Text = "Propuru - " & dato.Tables("personas").Rows(0).Item(0).ToString & " " & dato.Tables("personas").Rows(0).Item(1).ToString
        End If



        CbxTipoDeUsuario.SelectedIndex = 0
        CbxSucursales.SelectedIndex = 0
        CbxTurno.SelectedIndex = 0

    End Sub

    Private Sub Registro_Paint(sender As Object, e As PaintEventArgs) Handles PnlRegistro.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Metodos.volverlogin(Me)
    End Sub

    Private Sub BtnCambiarTema_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub TxtUser_Enter(sender As Object, e As EventArgs) Handles TxtUser.Enter
        Metodos.MtdEnterAlTxt(TxtUser, "Usuario")
    End Sub

    Private Sub TxtUser_Leave(sender As Object, e As EventArgs) Handles TxtUser.Leave
        Metodos.MtdLeaveAlTxt(TxtUser, "Usuario")
    End Sub

    Private Sub TxtContraseña_Enter(sender As Object, e As EventArgs) Handles TxtContraseña.Enter
        Metodos.MtdEnterAlTxt(TxtContraseña, "Contraseña")
        TxtContraseña.PasswordChar = "*"
    End Sub

    Private Sub TxtContraseña_Leave(sender As Object, e As EventArgs) Handles TxtContraseña.Leave
        cambiarpasschar(TxtContraseña)
        Metodos.MtdLeaveAlTxt(TxtContraseña, "Contraseña")

    End Sub

    Private Sub TxtCI_Enter(sender As Object, e As EventArgs) Handles MtxtCedula.Enter

        Metodos.MtdEnterAlTxt(MtxtCedula, "Cédula")
        MtxtCedula.Mask = "0,000,000-0"

    End Sub

    Private Sub TxtCI_Leave(sender As Object, e As EventArgs) Handles MtxtCedula.Leave

        MtxtCedula.Mask = ""
        Dim txt As String = MtxtCedula.Text
        Dim longtxt As Integer = MtxtCedula.Text.Length


        For a = 0 To MtxtCedula.Text.Length - 1
            If MtxtCedula.Text.Chars(a) = " " Then
                longtxt -= 1
            End If
        Next

        If longtxt = 8 Then
            MtxtCedula.Mask = "0,000,000-0"
            txt = MtxtCedula.Text
            MtxtCedula.Mask = ""
            MtxtCedula.Text = txt
        ElseIf longtxt = 0 Then
            Metodos.MtdLeaveAlTxt(MtxtCedula, "Cédula")
        ElseIf longtxt < 8 Or longtxt > 0 Then
            MtxtCedula.Text = "Cédula"
            MtxtCedula.ForeColor = Color.Gray
            MsgBox("El formato de cédula que ingreso es incorrecto.", vbInformation, "Atención")

        End If


    End Sub

    Private Sub TxtNombre_Enter(sender As Object, e As EventArgs) Handles TxtNombre.Enter
        Metodos.MtdEnterAlTxt(TxtNombre, "Nombre")
    End Sub

    Private Sub TxtNombre_Leave(sender As Object, e As EventArgs) Handles TxtNombre.Leave
        Metodos.MtdLeaveAlTxt(TxtNombre, "Nombre")
    End Sub

    Private Sub TxtApellido_Enter(sender As Object, e As EventArgs) Handles TxtApellido.Enter
        Metodos.MtdEnterAlTxt(TxtApellido, "Apellido")
    End Sub

    Private Sub TxtApellido_Leave(sender As Object, e As EventArgs) Handles TxtApellido.Leave
        Metodos.MtdLeaveAlTxt(TxtApellido, "Apellido")
    End Sub

    Private Sub TxtEmail_Enter(sender As Object, e As EventArgs) Handles TxtEmail.Enter
        Metodos.MtdEnterAlTxt(TxtEmail, "Email")
    End Sub

    Private Sub TxtTelefono_Enter(sender As Object, e As EventArgs) Handles TxtTelefono.Enter
        Metodos.MtdEnterAlTxt(TxtTelefono, "Teléfono")
    End Sub

    Private Sub TxtTelefono_Leave(sender As Object, e As EventArgs) Handles TxtTelefono.Leave
        Metodos.validartel(TxtTelefono)
        Metodos.MtdLeaveAlTxt(TxtTelefono, "Teléfono")
    End Sub

    Private Sub Registro_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlRegistro.MouseClick
        PnlRegistro.Focus()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnRegistrarse_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        If Metodos.volver = False Then
            Metodos.cambiarform(Me, FrmLogin)
        Else
            FrmAdmin.tipo = "G"
            Metodos.cambiarform(Me, FrmAdmin)


        End If

    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.KeyUp
        Metodos.validarcaresp(TxtUser)
    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.KeyUp
        Metodos.validarcaresp(TxtContraseña)
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.KeyUp
        Metodos.validarletras(TxtNombre)
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.KeyUp
        Metodos.validarletras(TxtApellido)
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.Leave
        Metodos.validarcorreos(TxtEmail, "Email")

    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.KeyUp
        validarnumeros(TxtTelefono)
    End Sub

    Private Sub MtxtCedula_Click(sender As Object, e As EventArgs) Handles MtxtCedula.Click

        MtxtCedula.Select(0, 0)
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Metodos.buttonanimation(sender)
        Dim campos As String = ""

        campos += Metodos.MtdValidarCampoVacio(TxtUser, "Usuario")
        campos += Metodos.MtdValidarCampoVacio(TxtContraseña, "Contraseña")
        campos += Metodos.MtdValidarCampoVacio(TxTConfirmarContra, "Confirmar contraseña")
        campos += Metodos.MtdValidarCampoVacio(MtxtCedula, "Cédula")
        campos += Metodos.MtdValidarCampoVacio(TxtNombre, "Nombre")
        campos += Metodos.MtdValidarCampoVacio(TxtApellido, "Apellido")
        campos += Metodos.MtdValidarCampoVacio(TxtEmail, "Email")
        campos += Metodos.MtdValidarCampoVacio(TxtTelefono, "Teléfono")
        campos += Metodos.MtdValidarCampoVacio(TxtCalle, "Calle")
        campos += Metodos.MtdValidarCampoVacio(TxtNumCalle, "NumCalle")
        If campos = "" Then

            If TxtContraseña.Text <> TxTConfirmarContra.Text Then
                MsgBox("Las contraseñas no coinciden.", vbCritical, "Error")
            Else
                'Crea un codigo de 4 numeros que van del 0 al 9
                Randomize()
                Dim codigo As String = CInt(Rnd() * 10).ToString
                Randomize()
                codigo += CInt(Rnd() * 10).ToString
                Randomize()
                codigo += CInt(Rnd() * 10).ToString
                Randomize()
                codigo += CInt(Rnd() * 10).ToString
                'Manda correo con el codigo para verificar




                Dim tipousr As String = ""
                If Me.CbxTipoDeUsuario.Visible = False Then
                    tipousr = "C"
                Else
                    If Me.CbxTipoDeUsuario.SelectedIndex = 0 Then
                        tipousr = "A"
                    ElseIf Me.CbxTipoDeUsuario.SelectedIndex = 1 Then
                        tipousr = "G"
                    End If
                End If

                Dim arrayHorarios As New ArrayList
                With arrayHorarios
                    If CbxTurno.SelectedIndex = 0 Then
                        .Add("09:00")
                        .Add("10:00")
                        .Add("11:00")
                    Else
                        .Add("14:00")
                        .Add("15:00")
                        .Add("16:00")
                    End If
                End With

                Dim conexion As New BDCon
                Dim con As New BDCon
                Dim con2 As New BDCon
                Dim dato As New DataSet
                Dim dato2 As New DataSet
                Dim dato3 As New DataSet
                dato = conexion.consulta("select * from personas where CIPersona='" & Me.MtxtCedula.Text & "'", "personas")
                dato2 = con.consulta("select * from personas where CorreoPersona='" & Me.TxtEmail.Text & "'", "correoPersona")

                dato3 = con2.consulta("select * from personas where TelPersona='" & Me.TxtTelefono.Text & "'", "telPersona")
                MsgBox(dato.Tables("personas").Rows.Count)
                MsgBox(dato2.Tables("correoPersona").Rows.Count)
                MsgBox(dato3.Tables("telPersona").Rows.Count)
                If dato.Tables("personas").Rows.Count > 0 Then
                    MsgBox("Esa Cedula de identidad ya esta registrada", vbCritical, "Error")
                    'select * from personas where CorreoPersona='paparis060@gmail.com'
                ElseIf dato2.Tables("correoPersona").Rows.Count > 0 Then
                    MsgBox("Ese correo ya ha sido registrado")

                ElseIf dato3.Tables("telPersona").Rows.Count > 0 Then
                    MsgBox("Ese telefono ya ha sido registrado")
                Else

                    Dim correo As New Mensaje("El numero para verificar su correo es:" & codigo, "Codigo de registro", TxtEmail.Text, "develofix666@gmail.com", "develofixdeldiablo")
                    correo.enviarMail()

                    If InputBox("Ingrese el codigo enviado por correo") = codigo Then

                        dato.Clear()
                        dato = conexion.consulta("select * from usuario where usr='" & Me.TxtUser.Text & "'", "usuario")
                        If dato.Tables("usuario").Rows.Count > 0 Then
                            MsgBox("El nombre de usuario ya esta en uso", vbCritical, "Error")
                        Else
                            conexion.manipularBD("insert into personas (CIPersona,Nombre,Apellido,NumCalle,FechaNac,TelPersona,CorreoPersona) values ('" & Me.MtxtCedula.Text & "','" & Me.TxtNombre.Text & "','" & Me.TxtApellido.Text & "'," & Me.TxtNumCalle.Text & ",'" & Metodos.fechaBD(DTPFechaNac.Text) & "','" & Me.TxtTelefono.Text & "','" & Me.TxtEmail.Text & "')")
                            conexion.manipularBD("INSERT INTO usuario(Usr,TipoUsuario,CIPersona,Passwd) VALUES ('" & Me.TxtUser.Text & "','" & tipousr & "','" & Me.MtxtCedula.Text & "','" & FormateadorDeTextos.MD5encript(Me.TxtContraseña.Text) & "');")
                            Dim IDUsuario As String = conexion.getID("IDUsuario", "usuario", "usr='" & Me.TxtUser.Text & "' and passwd='" & FormateadorDeTextos.MD5encript(Me.TxtContraseña.Text) & "'")
                            Select Case tipousr
                                Case "C"
                                    conexion.manipularBD("insert into interesado values(" & IDUsuario & ")")
                                Case "A"
                                    Dim IDSucursal As String = conexion.getID("IDSucursal", "sucursales", "NomSucursal='" & CbxSucursales.Text & "'")
                                    conexion.manipularBD("insert into personal values(" & IDUsuario & "," & IDSucursal & ")")
                                    For a = 1 To 5
                                        For Each h As String In arrayHorarios
                                            conexion.manipularBD("INSERT INTO agenda(IDUsuarioP,Dia,Hora) VALUES (" & IDUsuario & "," & a & ",'" & h & "');")
                                        Next
                                    Next
                                Case "G"
                                    Dim IDSucursal As String = conexion.getID("IDSucursal", "sucursales", "NomSucursal='" & CbxSucursales.Text & "'")
                                    conexion.manipularBD("insert into personal values(" & IDUsuario & "," & IDSucursal & ")")
                                    For a = 1 To 5
                                        For Each h As String In arrayHorarios
                                            conexion.manipularBD("INSERT INTO agenda(IDUsuarioP,Dia,Hora) VALUES (" & IDUsuario & "," & a & ",'" & h & "');")
                                        Next
                                    Next
                            End Select



                            MsgBox("Cuenta creada correctamente.", vbInformation, "Registro completado")


                            If Metodos.volver = False Then
                                Metodos.cambiarform(Me, FrmLogin)
                            Else
                                FrmAdmin.tipo = "G"
                                Metodos.cambiarform(Me, FrmAdmin)


                            End If

                        End If
                    Else
                        MsgBox("Codigo incorrecto")
                    End If
                End If

            End If
        Else
            MsgBox("Los siguientes campos están vacíos: " + Chr(Keys.Enter) + campos, vbCritical, "Error")

        End If


    End Sub



    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TxTConfirmarContra.Enter
        Metodos.MtdEnterAlTxt(TxTConfirmarContra, "Confirmar contraseña")
        TxTConfirmarContra.PasswordChar = "*"
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TxTConfirmarContra.Leave
        cambiarpasschar(TxTConfirmarContra)
        Metodos.MtdLeaveAlTxt(TxTConfirmarContra, "Confirmar contraseña")
    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtContraseña.KeyUp

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TxTConfirmarContra.KeyUp
        Metodos.validarcaresp(TxTConfirmarContra)
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtUser.KeyUp

    End Sub

    Private Sub TxtCalle_TextChanged(sender As Object, e As EventArgs) Handles TxtCalle.KeyUp
        Metodos.validarletrasyespacio(sender)
    End Sub

    Private Sub TxtNumCalle_TextChanged(sender As Object, e As EventArgs) Handles TxtNumCalle.KeyUp
        Metodos.validarnumeros(sender)
    End Sub

    Private Sub TxtNumCalle_Enter(sender As Object, e As EventArgs) Handles TxtNumCalle.Enter
        Metodos.MtdEnterAlTxt(sender, "Número de calle")
    End Sub

    Private Sub TxtCalle_Enter(sender As Object, e As EventArgs) Handles TxtCalle.Enter
        Metodos.MtdEnterAlTxt(sender, "Dirección ( Calle )")
    End Sub

    Private Sub TxtNumCalle_Leave(sender As Object, e As EventArgs) Handles TxtNumCalle.Leave
        Metodos.MtdLeaveAlTxt(TxtNumCalle, "Número de calle")
    End Sub

    Private Sub TxtCalle_Leave(sender As Object, e As EventArgs) Handles TxtCalle.Leave
        Metodos.MtdLeaveAlTxt(TxtCalle, "Dirección ( Calle )")
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtNombre.KeyUp

    End Sub

    Private Sub TxtNumCalle_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtNumCalle.KeyUp

    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtApellido.KeyUp

    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtTelefono.KeyUp

    End Sub

    Private Sub TxtCalle_TextChanged(sender As Object, e As KeyEventArgs) Handles TxtCalle.KeyUp

    End Sub
End Class