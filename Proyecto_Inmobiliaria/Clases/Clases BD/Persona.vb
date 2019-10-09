Public MustInherit Class Persona

    Public CI As String
    Public Nombre As String
    Public Apellido As String
    Public numCalle As Integer
    Public FechaNac As String
    Public Telefono As Integer
    Public CorreoElectronico As String
    Public Tipo As Char

    Public Sub New(CI As String, Nombre As String, Apellido As String, numCalle As Integer, FechaNac As String, Telefono As Integer, CorreoElectronico As String, Tipo As Char)

        Me.CI = CI
        Me.Nombre = Nombre
        Me.Apellido = Apellido
        Me.numCalle = numCalle
        Me.FechaNac = FechaNac
        Me.Telefono = Telefono
        Me.CorreoElectronico = CorreoElectronico
        Me.Tipo = Tipo

    End Sub

    Public Sub New()

    End Sub

    Public MustOverride Function getTipoUsuario() As Char

End Class
