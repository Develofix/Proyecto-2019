Public Class Propiedad
    Inherits Objeto_BD
    Public IDProp, Antiguedad, CantBaños, CantHabitaciones, CantGarajes, numCalle As Integer
    Public Nombre, Condicion, Tipo, Estado, Precio, Descripcion As String
    Public Departamento As String
    Public Ciudad As String
    Public Barrio As String
    Public Terreno, SuperficieCubierta As String
    Public Imagenes As ArrayList



    Public Sub New(prop As ArrayList, imagenes As ArrayList, ciudad As String, barrio As String, departamento As String)
        MyBase.New(prop.Item(0))

        Me.IDProp = prop.Item(1)
        Me.Precio = prop.Item(2)
        Me.Tipo = prop.Item(3)
        Me.CantHabitaciones = prop.Item(4)
        Me.CantBaños = prop.Item(5)
        Me.numCalle = prop.Item(6)
        Me.Estado = prop.Item(7)
        Me.Terreno = prop.Item(8)
        Me.SuperficieCubierta = prop.Item(9)
        Me.Antiguedad = prop.Item(10)
        Me.Condicion = prop.Item(11)
        Me.Nombre = prop.Item(12)
        Me.CantGarajes = prop.Item(13)
        Me.Descripcion = prop.Item(14)
        Me.Ciudad = ciudad
        Me.Barrio = barrio
        Me.Departamento = departamento
        Me.Imagenes = imagenes
    End Sub


    Public Sub New(ID As Integer, IDProp As Integer, Precio As Integer, Tipo As String, CantHabitaciones As Integer, CantBaños As Integer, NumCalle As Integer,
                   Estado As String, Terreno As String, SuperficieCubierta As String, Antiguedad As Integer, Condicion As String, Nombre As String, CantGarajes As Integer,
                   Descripcion As String, Imagenes As ArrayList, ciudad As String, barrio As String, departamento As String)
        MyBase.New(ID)
        Me.IDProp = IDProp
        Me.Precio = Precio
        Me.Tipo = Tipo
        Me.CantHabitaciones = CantHabitaciones
        Me.CantBaños = CantBaños
        Me.numCalle = NumCalle
        Me.Estado = Estado
        Me.Terreno = Terreno
        Me.SuperficieCubierta = SuperficieCubierta
        Me.Antiguedad = Antiguedad
        Me.Condicion = Condicion
        Me.Nombre = Nombre
        Me.CantGarajes = CantGarajes
        Me.Descripcion = Descripcion
        Me.Ciudad = ciudad
        Me.Barrio = barrio
        Me.Departamento = departamento
        Me.Imagenes = Imagenes
    End Sub

    Public Sub New()

    End Sub


End Class
