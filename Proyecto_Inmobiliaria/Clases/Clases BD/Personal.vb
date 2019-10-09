Public Class Personal
    Inherits Persona

    Public Sub New(CI As String, Nombre As String, Apellido As String, numCalle As Integer, FechaNac As String, Telefono As Integer, CorreoElectronico As String, Tipo As Char)
        MyBase.New(CI, Nombre, Apellido, numCalle, FechaNac, Telefono, CorreoElectronico, Tipo)
    End Sub

    Public Sub New()

    End Sub

    Public Overrides Function getTipoUsuario() As Char
        Return Tipo
    End Function


End Class
