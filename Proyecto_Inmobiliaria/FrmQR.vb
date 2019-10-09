Imports MessagingToolkit
Imports System.IO
Imports System
Public Class FrmQR
    Dim qrgen As New MessagingToolkit.Barcode.BarcodeEncoder
    Private Sub FrmQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Metodos.mantenertema(Me)

        Dim str As String = ""
        Dim arrayDatos() As TextBox = {FrmAgendar.TxtID, FrmAgendar.TxtNombre, FrmAgendar.TxtPrecio, FrmAgendar.TxtBaños, FrmAgendar.TxtGarage, FrmAgendar.TxtCuartos, FrmAgendar.TxtCiudad, FrmAgendar.TxtBarrio, FrmAgendar.TxtDepartamento, FrmAgendar.TxtTerreno, FrmAgendar.TxtTerrenoCubierto, FrmAgendar.TxtCondicion, FrmAgendar.TxtAntiguedad, FrmAgendar.TxtTipo, FrmAgendar.TxtEstado}

        str = Metodos.MtdDatosPropiedades(arrayDatos)
        str += FormateadorDeTextos.formatoFechaBD(FrmAgendar.DTPFechaVisita.Value.Day, FrmAgendar.DTPFechaVisita.Value.Month, FrmAgendar.DTPFechaVisita.Value.Year) + Chr(Keys.Enter) + FrmAgendar.CbxHora.Text + Chr(Keys.Enter)


        PbxQR.Image = New Bitmap(qrgen.Encode(Barcode.BarcodeFormat.QRCode, str), PbxQR.Size.Width, PbxQR.Size.Height)
        Dim con As New BDCon
        Dim correoUsr As String = con.consulta("select CorreoPersona from personas, usuario where usuario.CIPersona=personas.CIPersona and usuario.IDUsuario=" & Metodos.usr, "correousr").Tables("correousr").Rows(0).Item(0).ToString
        Dim correo As New Mensaje("Gracias por agendarse con Propuru", "Visita agendada", correoUsr, "develofix666@gmail.com", "develofixdeldiablo")
        PbxQR.Image.Save(Application.StartupPath & "/imagenqr.png")
        correo.agregarAdjuntos(Application.StartupPath & "/imagenqr.png")
        correo.enviarMail()
        correo.Dispose()



    End Sub

    Private Sub FrmQR_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        FrmAgendar.Enabled = True
        FrmAgendar.Focus()
        File.Delete(Application.StartupPath & "/imagenqr.png")
    End Sub

    Private Sub FrmQR_Unfocus(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub



    Private Sub BtnVerPropiedades_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Metodos.buttonanimation(sender)
        Dim sfd As New SaveFileDialog()
        sfd.Title = "Guarde el codigo QR"
        sfd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
        sfd.FileName = "QRCode"
        sfd.ShowDialog()
        PbxQR.Image.Save(sfd.FileName)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Metodos.buttonanimation(sender)
        Me.Close()
    End Sub

End Class