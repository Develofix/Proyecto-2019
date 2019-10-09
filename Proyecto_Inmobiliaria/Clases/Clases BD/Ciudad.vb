Public Class Ciudad
    Inherits Objeto_BD
    Public Nombre As String
    Public Departamento As Departamento

    Public Sub New(id As Integer, nombre As String, departamento As Departamento)
        MyBase.New(id)
        Me.Nombre = nombre
        Me.Departamento = departamento
    End Sub

    Public Sub New()

    End Sub

End Class
