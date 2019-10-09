Public Class Cliente
    Inherits Persona

    Public Sub New(CI As String, Nombre As String, Apellido As String, numCalle As Integer, FechaNac As String, Telefono As Integer, CorreoElectronico As String)
        MyBase.New(CI, Nombre, Apellido, numCalle, FechaNac, Telefono, CorreoElectronico, "C")
    End Sub

    Public Sub New()

    End Sub

    Public Overrides Function getTipoUsuario() As Char
        Return Tipo
    End Function
End Class
