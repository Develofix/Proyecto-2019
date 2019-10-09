Imports System.Drawing.Text
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Dim Usuarios(2, 2) As String
    Shadows menu As New ClassMenu(Me)
    Public pfc As PrivateFontCollection = New PrivateFontCollection
    Public conexion As New BDCon



    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Metodos.buttonanimation(BtnIngresar)

        Dim dato As New DataSet
        dato = conexion.consulta("select * from usuario where Usr='" & Me.TxtUser.Text & "' and Passwd='" & FormateadorDeTextos.MD5encript(Me.TxtPasswd.Text) & "'", "usuario")

        If dato.Tables("usuario").Rows.Count = 1 Then
            Metodos.usr = dato.Tables("usuario").Rows(0).Item(0).ToString

            Dim tipousr As String = dato.Tables("usuario").Rows(0).Item(2).ToString
            dato = conexion.consulta("select Nombre, Apellido from Personas,Usuario where usuario.CIPersona=Personas.CIPersona And Usuario.IDUsuario=" & Metodos.usr.ToString, "personas")

            Select Case tipousr
                Case "C"

                    Metodos.log = True
                    If Metodos.reg = True Then
                        Dim casa As New Propiedad
                        casa = conexion.cargarpropBD(Metodos.idprop, Metodos.consulta)
                        Metodos.cargarimg(FrmAgendar.images, casa.Imagenes)
                        Metodos.MtdDatosPropiedades(casa)
                        Metodos.reg = False
                        Metodos.cambiarform(Me, FrmAgendar)

                    Else
                        Metodos.cambiarform(Me, FrmCliente)
                        FrmCliente.Text = "Propuru - " & dato.Tables("personas").Rows(0).Item(0).ToString & " " & dato.Tables("personas").Rows(0).Item(1).ToString

                    End If

                Case "G"
                    Metodos.reg = False
                    FrmAdmin.tipo = "G"
                    Metodos.log = True
                    Metodos.cambiarform(Me, FrmAdmin)
                    FrmAdmin.Text = "Propuru - " & dato.Tables("personas").Rows(0).Item(0).ToString & " " & dato.Tables("personas").Rows(0).Item(1).ToString
                Case "A"
                    Metodos.reg = False
                    FrmAdmin.tipo = "A"
                    Metodos.log = True
                    Metodos.cambiarform(Me, FrmAdmin)
                    FrmAdmin.Text = "Propuru - " & dato.Tables("personas").Rows(0).Item(0).ToString & " " & dato.Tables("personas").Rows(0).Item(1).ToString
            End Select
        Else
            MsgBox("El usuario o contraseña ingresado es incorrecto.", vbCritical, "Error")
        End If

    End Sub







    Private Sub LOGINFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Metodos.timer.Enabled = True
        Metodos.timer.Interval = 60000
        timer.Start()
        consulta = "SELECT IDPropiedades,IDUsuarioProp,Precio,Tipo_Propiedad,Cantidad_Habitaciones,Cantidad_Baños,NumCalle,Estado,Superficie_Terreno,Superficie_Cubierta,Antiguedad,Condicion_Propiedad,Nombre,Cantidad_Garajes,Descripcion FROM propiedades"
        PnlLogin.Focus()
        Metodos.mantenertema(Me)
        menu.MnuStIUsuario.Text = "Bienvenido"
        menu.MnuStIUsuario.Enabled = False
        Metodos.volver = False


    End Sub



    Public Sub formato()
        pfc.AddFontFile(Application.StartupPath + "\..\..\Fonts\WorkSans-ExtraLight.ttf")
    End Sub

    Private Sub BtnRegistrarse_Click(sender As Object, e As EventArgs) Handles BtnVerPropiedades.Click

        Metodos.buttonanimation(BtnVerPropiedades)
        Metodos.cambiarform(Me, FrmCliente)

    End Sub

    Private Sub TxtUser_Enter(sender As Object, e As EventArgs) Handles TxtUser.Enter
        Metodos.MtdEnterAlTxt(TxtUser, "Escribe tu usuario")
    End Sub

    Private Sub TxtUser_Leave(sender As Object, e As EventArgs) Handles TxtUser.Leave
        Metodos.MtdLeaveAlTxt(TxtUser, "Escribe tu usuario")
    End Sub

    Private Sub TxtPasswd_Enter(sender As Object, e As EventArgs) Handles TxtPasswd.Enter
        Metodos.MtdEnterAlTxt(TxtPasswd, "Escribe tu contraseña")
        TxtPasswd.PasswordChar = "*"
    End Sub

    Private Sub TxtPasswd_Leave(sender As Object, e As EventArgs) Handles TxtPasswd.Leave
        cambiarpasschar(TxtPasswd)
        Metodos.MtdLeaveAlTxt(TxtPasswd, "Escribe tu contraseña")


    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles PnlLogin.MouseClick
        PnlLogin.Focus()

    End Sub

    Private Sub CbxTraslucido_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.KeyUp
        Metodos.validarcaresp(TxtUser)

    End Sub

    Private Sub TxtPasswd_TextChanged(sender As Object, e As EventArgs) Handles TxtPasswd.KeyUp
        Metodos.validarcaresp(TxtPasswd)
    End Sub

    Private Sub BtnRegistrarse_Click_1(sender As Object, e As EventArgs) Handles BtnRegistrarse.Click
        Metodos.cambiarform(Me, FrmRegistrarse)

    End Sub

    Private Sub PbxLoginImg_Click(sender As Object, e As EventArgs) Handles PbxLoginImg.Click
        PbxLoginImg.Focus()
    End Sub

End Class
