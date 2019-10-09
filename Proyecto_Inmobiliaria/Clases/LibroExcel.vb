Imports Microsoft.Office.Interop

Public Class LibroExcel

    'Aplicacion
    Dim xlApp As Excel.Application
    'Coleccion de excels
    Dim objBooks As Excel.Workbooks
    'Excel
    Dim xlLibro As Excel.Workbook
    'Coleccion de hojas del excel
    Dim objSheets As Excel.Sheets
    'Hoja de trabajo
    Dim objSheet As Excel._Worksheet
    'Celdas de la hoja
    Dim range As Excel.Range
    'Nombres de las hojas
    Public nombresSheets As New ArrayList
    'Si hay una hoja seleccionada
    Dim hojaSeleccionada As Boolean = False

    Public Function obtenerIndiceSheet(NombreSheet As String) As Integer

        Dim indice As Integer = -1
        For Each a As String In nombresSheets
            If a = NombreSheet Then
                indice += 1
                Exit For
            End If
            indice += 1
        Next

        Return indice

    End Function


    Public Sub New(Excel)
        'Inicializamos la aplicacion
        xlApp = New Excel.Application()
        'Inicializamos la coleccion de excels
        objBooks = xlApp.Workbooks
        'Inicializamos el excel en el cual trabajaremos
        xlLibro = objBooks.Open(Excel)
        'Lo activamos
        xlLibro.Activate()
        'Obtenemos las hojas de dicho excel y sus nombres
        objSheets = xlLibro.Sheets
        For a = 1 To objSheets.Count
            Dim sheet As Excel.Worksheet = objSheets.Item(a)
            nombresSheets.Add(sheet.Name)
        Next

    End Sub

    'Cambia la hoja de trabajo
    Public Sub setHoja(nomsheet As String)

        'Si existe una hoja con ese nombre
        If nombresSheets.Contains(nomsheet) Then
            'Asignamos la hoja de trabajo, la activamos y decimos que hay una hoja seleccionada
            objSheet = objSheets(nomsheet)
            objSheet.Activate()
            hojaSeleccionada = True
        Else
            MsgBox("No existe dicha hoja")
        End If

    End Sub

    Public Sub cambiarExcel(Excel As String)
        xlLibro = objBooks.Open(Excel)
    End Sub

    'Devuelve el valor dentro de una celda de una determinada sheet
    Public Function obtenerCelda(row As Integer, column As Integer) As String

        If hojaSeleccionada Then

            'Referenciamos la celda
            range = objSheet.Cells(row, column)

            'Obtenemos el valor, lo convertimos a string y lo retornamos
            Return range.Value.ToString
        Else
            Return "Error, hoja no seleccionada"
        End If

    End Function

    'Devuelve el numero de la primera fila que este en blanco
    Public Function obtenerFilaNull() As Integer

        If hojaSeleccionada Then
            Dim a As Integer = 1
            Try
                While obtenerCelda(a, 1) <> ""
                    a += 1

                End While
            Catch ex As Exception

            End Try


            Return a
        Else
            Return -1
        End If
    End Function

    'Pide una celda donde haya una una fila completa y lo que separa los elementos
    Public Function obtenerFiladeCeldaExcel(row As Integer, column As Integer, separador As String) As ArrayList
        Dim Fila As New ArrayList
        'Separa en columnas, añade al array y devuelve
        For Each a As String In FormateadorDeTextos.separarColumnas(separador, Me.obtenerCelda(row, column))
            Fila.Add(FormateadorDeTextos.convertirutf_defalut(a))
        Next
        Return Fila
    End Function

End Class
