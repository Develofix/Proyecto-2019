Imports System.Net
Imports System.Net.Mail

Public Class Mensaje
    Inherits MailMessage
    Dim enviar As New SmtpClient

    Public Sub New(mensajestr As String, asunto As String, destino As String, origen As String, pass As String)

        Me.To.Clear()

        Me.Subject = ""
        Me.Body = mensajestr
        Me.Subject = asunto
        Me.To.Add(destino)
        Me.IsBodyHtml = True
        Me.From = New MailAddress(origen)

        enviar.Credentials = New NetworkCredential(origen, pass)

        enviar.Host = "smtp.gmail.com"
        enviar.Port = 587
        enviar.EnableSsl = True


    End Sub

    Public Sub cambiarMensaje(stringMensaje As String)
        Me.Body = stringMensaje
    End Sub

    Public Sub cambiarOrigen(origen As String, pass As String)
        Me.From = New MailAddress(origen)
        enviar.Credentials = New NetworkCredential(origen, pass)
    End Sub

    Public Sub cambiarAsunto(asunto As String)
        Me.Subject = asunto
    End Sub

    Public Sub cambiarDestino(destinatario As String)
        Me.To.Clear()
        Me.To.Add(destinatario)
    End Sub

    Public Sub agregarDestino(destinatario As String)
        Me.To.Add(destinatario)
    End Sub

    Public Sub cambiarServidor(stmpServerHostname As String, stmpPort As Integer)
        enviar.Host = stmpServerHostname
        enviar.Port = stmpPort
        enviar.EnableSsl = True
    End Sub

    Public Sub enviarMail()

        enviar.Send(Me)

    End Sub

    Public Sub agregarAdjuntos(fn As String)
        Dim adjunto As New Attachment(fn)
        Me.Attachments.Add(adjunto)
    End Sub

End Class
