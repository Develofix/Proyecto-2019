Public Class Departamento
    Inherits Objeto_BD
    Public Nombre As String

    Public Sub New(id As Integer, nombre As String)
        MyBase.New(id)
        Me.Nombre = nombre
    End Sub

    Public Sub New()

    End Sub

End Class
