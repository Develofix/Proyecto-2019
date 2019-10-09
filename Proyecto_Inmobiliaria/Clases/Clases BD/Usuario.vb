Imports Proyecto_Inmobiliaria

Public Class Usuario
    Inherits Objeto_BD
    Public NomUsr As String
    Public tipoUsr As Char
    Public CI As String
    Public Pass As String

    Public Sub New(NomUsr As String, persona As Persona, Pass As String)
        Me.NomUsr = NomUsr
        Me.tipoUsr = persona.getTipoUsuario
        Me.CI = persona.CI
        Me.Pass = Pass
    End Sub
End Class
