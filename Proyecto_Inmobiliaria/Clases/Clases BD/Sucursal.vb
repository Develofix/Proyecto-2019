Public Class Sucursal
    Inherits Objeto_BD
    Dim IDDep As Integer
    Dim IDCiu As Integer
    Dim IDBarrio As Integer
    Dim numCalle As Integer
    Dim Size As String
    Dim Nombre As String

    Public Sub New(ID As Integer, Departamento As Departamento, Ciudad As Ciudad, Barrio As Barrio, numCalle As Integer, Size As String, Nombre As String)
        MyBase.New(ID)
        Me.IDDep = Departamento.ID
        Me.IDCiu = Ciudad.ID
        Me.IDBarrio = Barrio.ID
        Me.numCalle = numCalle
        Me.Size = Size
        Me.Nombre = Nombre


    End Sub

End Class
