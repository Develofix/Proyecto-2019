Public Class Propietario
    Inherits Cliente

    Public Sub New(CI As String, Nombre As String, Apellido As String, numCalle As Integer, FechaNac As String, Telefono As Integer, CorreoElectronico As String)
        MyBase.New(CI, Nombre, Apellido, numCalle, FechaNac, Telefono, CorreoElectronico)
        Me.Tipo = "P"
    End Sub

    Public Sub New()

    End Sub

End Class
