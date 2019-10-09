Public Class ArrayTable
    Inherits ArrayList

    Private NombreTable As String

    Public Property Nombre As String
        Get
            Return NombreTable
        End Get
        Set(value As String)
            NombreTable = value
        End Set
    End Property

    'Inicializamos la clase con el constructor de la clase base y luego se añade las columnas
    Public Sub New(Columnas As ArrayList)
        MyBase.New
        For a = 0 To Columnas.Count - 1
            Dim column As New ArrayList
            column.Add(Columnas.Item(a))
            Me.Add(column)
        Next
    End Sub

    'Pide el numero de una fila, agarra el item de esa posicion de cada columna y devuelve esto en forma de una fila en arrayList
    Public Function obtenerFila(numFila As Integer) As ArrayList
        Dim fila As New ArrayList
        For Each a As ArrayList In Me
            fila.Add(a.Item(numFila))
        Next
        Return fila
    End Function

    'Se fija si la fila completa todas las columnas, agarra cada item de la fila ingresada y los añade en sus respectivas columnas
    Public Sub agregarFila(Fila As ArrayList)

        If Fila.Count = Me.Count Then
            Dim b As Integer = 0
            For Each a As ArrayList In Me
                a.Add(Fila.Item(b))
                b += 1

            Next
        Else
            MsgBox("La fila a ingresar debe cubrir todas las columnas")
        End If

    End Sub

    Public Function ObtenerIndiceColumna(NomColumna As String) As Integer
        Dim indice As Integer = -1
        For Each a As ArrayList In Me
            If a.Item(0) = NomColumna Then
                indice += 1
                Exit For
            End If
            indice += 1
        Next

        Return indice
    End Function

    Public Function columna(indice As Integer)
        Return Me.Item(indice)
    End Function

    Public Function columna(nomColumna As String)
        Return Me.Item(Me.ObtenerIndiceColumna(nomColumna))
    End Function

    Public Function obtenerLongitud() As Integer
        Return Me.Item(0).count
    End Function

End Class
