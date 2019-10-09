Public Class FormateadorDeTextos

    'Reemplaza todos los caracteres de otro formato y los pone en un formato legible
    Public Shared Function convertirutf_defalut(stringutf As String) As String

        stringutf = stringutf.Replace("Âº", "º")

        stringutf = stringutf.Replace("Ã±", "ñ")

        stringutf = stringutf.Replace("Ã¡", "á")

        stringutf = stringutf.Replace("Ã³", "ó")

        stringutf = stringutf.Replace("Ã©", "é")

        stringutf = stringutf.Replace("Ãº", "ú")

        Return stringutf

    End Function

    Public Shared Function MD5encript(texto As String) As String
        Dim has As New OC.Core.Crypto.Hash
        Dim TextoMd5 = has.MD5(texto)
        Return TextoMd5
    End Function

    Public Shared Function stringadate(fechaString As String) As Date
        Dim arrayFecha As New ArrayList
        arrayFecha = separarColumnas("/", fechaString)
        Dim fecha As New Date(arrayFecha.Item(2), arrayFecha.Item(1), arrayFecha.Item(0))
        Return fecha
    End Function

    Public Shared Function formatoFechaBD(dia As String, mes As String, anio As String) As String
        Return anio & "-" & mes & "-" & dia
    End Function

    Public Shared Function sacarEspacios(cadena As String) As String
        Return Replace(cadena, " ", "")

    End Function

    Public Shared Function FormatoHora(cadena As String) As String
        Dim arrayCaracteres() As Char = cadena.ToCharArray
        Dim cadenaNueva As String = ""
        If arrayCaracteres.Length = 4 Then

            cadenaNueva += arrayCaracteres(0) & arrayCaracteres(1) & ":" & arrayCaracteres(2) & arrayCaracteres(3)
        ElseIf arrayCaracteres.Length = 3 Then

            cadenaNueva += "0" & arrayCaracteres(0) & ":" & arrayCaracteres(1) & arrayCaracteres(2)

        End If

        Return cadenaNueva
    End Function

    Public Shared Function formatoCI(CI As String) As String
        Dim CIFormateada As String = ""
        Dim ArrayCaracteres() As Char
        ArrayCaracteres = CI.ToCharArray

        If CI.Length = 8 Then

            CIFormateada += CI.First & "." & ArrayCaracteres(1) & ArrayCaracteres(2) & ArrayCaracteres(3) & "." & ArrayCaracteres(4) & ArrayCaracteres(5) & ArrayCaracteres(6) & "-" & ArrayCaracteres(7)

        ElseIf CI.Length = 7 Then

            CIFormateada += CI.First & ArrayCaracteres(1) & ArrayCaracteres(2) & "." & ArrayCaracteres(3) & ArrayCaracteres(4) & ArrayCaracteres(5) & "-" & ArrayCaracteres(6)

        End If

        Return CIFormateada
    End Function

    'Utilizando como separador lo que se le pase por parametros, separa en columnas y devuelve un array de estas
    Public Shared Function separarColumnas(separador As String, cadena As String) As ArrayList
        Dim columnas As New ArrayList
        Dim columna As String = ""
        'Crea una cadena hasta que se encuentra con el separador y entonces, lo guarda en el array
        'Repite el proceso hasta el final del array
        For Each a As Char In cadena.ToCharArray
            If a <> separador Then
                columna += a
            Else
                columnas.Add(columna)
                columna = ""
            End If
        Next
        'Como el ultimo campo no deberia terminar en coma, se debe agregar por separado este campo
        columnas.Add(columna)

        Return columnas

    End Function

    Public Shared Function sacarComillas(Cadena As String) As String
        Dim inicioFin As String = ""
        inicioFin += Cadena.First
        inicioFin += Cadena.Last
        Dim CadenaSinComillas As String = ""
        Dim arrayCaracteres() As Char
        arrayCaracteres = Cadena.ToCharArray
        If inicioFin = """""" Then
            For a = 1 To Cadena.Length - 2
                CadenaSinComillas += arrayCaracteres(a)
            Next
            Return CadenaSinComillas

        Else
            Return Cadena
        End If

    End Function

End Class
