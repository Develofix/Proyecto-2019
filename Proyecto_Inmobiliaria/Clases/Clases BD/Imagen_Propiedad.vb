Public Class Imagen_Propiedad
    Inherits Objeto_BD
    Public IDPropiedad As Integer
    Public Imagen As Image

    Public Sub New(id As Integer, idpropiedad As Integer, imagen As Image)
        MyBase.New(id)
        Me.IDPropiedad = idpropiedad
        Me.Imagen = imagen
    End Sub

    Public Sub New()

    End Sub
End Class
