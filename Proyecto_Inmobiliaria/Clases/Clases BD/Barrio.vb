Public Class Barrio
    Inherits Objeto_BD
    Public Nombre As String
    Public Ciudad As Ciudad


    Public Sub New(id As Integer, nombre As String, ciudad As Ciudad)
        MyBase.New(id)
        Me.Nombre = nombre
        Me.Ciudad = ciudad
    End Sub

    Public Sub New()

    End Sub

End Class
