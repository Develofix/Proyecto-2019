Public Class Visita
    Inherits Objeto_BD
    Public Cliente As Cliente
    Public Propiedad As Propiedad
    Public DiaVisita As String
    Public HoraVisita As String
    Public PersonalEncargado As Personal
    Public Cancelada As Boolean
    Public Modificada As Boolean

    Public Sub New(id As Integer, cliente As Cliente, propiedad As Propiedad, diavisita As String, horavisita As String, personalencargado As Personal, cancelada As Boolean, modificada As Boolean)
        MyBase.New(id)
        Me.Cliente = cliente
        Me.Propiedad = propiedad
        Me.DiaVisita = diavisita
        Me.HoraVisita = horavisita
        Me.PersonalEncargado = personalencargado
        Me.Cancelada = cancelada
        Me.Modificada = modificada

    End Sub

    Public Sub New()

    End Sub
End Class
