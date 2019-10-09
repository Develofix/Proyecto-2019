Public Class Agenda
    Inherits Objeto_BD
    Public Personal As Persona
    Public Dia As String
    Public Hora As ArrayList

    Public Sub New(id As Integer, Personal As Persona, dia As String, hora As ArrayList)
        MyBase.New(id)
        Me.Personal = Personal
        Me.Dia = dia
        Me.Hora = hora
    End Sub

    Public Sub New()

    End Sub

End Class
