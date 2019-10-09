Imports MySql.Data.MySqlClient
Imports System.IO
Public Class BDCon
    Private dato As New DataSet
    Private ad As MySqlDataAdapter
    Private conexion As New MySqlConnection
    Public Sub New()
        Try
            conexion.ConnectionString = "server=localhost;user=pruebausr;password=;database=bd_proyecto"
            conexion.Open()
        Catch
            MsgBox("No se pudo conectar")
        End Try
    End Sub

    Public Function consulta(stringconsulta As String, tabla As String) As DataSet
        dato.Clear()
        ad = New MySqlDataAdapter(stringconsulta, conexion)
        ad.Fill(dato, tabla)
        Return dato
    End Function

    Public Function consulta(comando As MySqlCommand, tabla As String) As DataSet
        dato.Clear()
        comando.ExecuteNonQuery()
        Dim adapter As New MySqlDataAdapter
        adapter.SelectCommand = comando
        ad.Fill(dato, tabla)
        Return dato
    End Function

    Public Sub manipularBD(stringconsulta As String)
        dato.Clear()
        ad = New MySqlDataAdapter(stringconsulta, conexion)
        ad.Fill(dato)
    End Sub

    Public Sub manipularBD(comando As MySqlCommand)
        dato.Clear()
        comando.Connection = Me.conexion
        comando.ExecuteNonQuery()
        Dim adapter As New MySqlDataAdapter
        adapter.SelectCommand = comando
    End Sub

    Public Function getID(NombreTuplaID As String, NombreTabla As String, where As String) As String
        dato.Clear()
        dato = Me.consulta("select " & NombreTuplaID & " from " & NombreTabla & " where " & where, NombreTabla)
        Dim ID As String = ""
        If dato.Tables(NombreTabla).Rows.Count = 1 Then
            ID = dato.Tables(NombreTabla).Rows(0).Item(NombreTuplaID)
            Return ID
        Else
            MsgBox("Error")
            Return ""
        End If

    End Function

    'Public Function cargarpropBD(numProp As Integer) As Propiedad
    '    dato.Clear()
    '    dato = Me.consulta("select * from propiedades limit " & numProp & ",1", "propiedades")
    '    Dim arrayprop As New ArrayList
    '    For a = 0 To dato.Tables("propiedades").Rows(0).ItemArray.Count - 1
    '        arrayprop.Add(dato.Tables("propiedades").Rows(0).Item(a))
    '    Next
    '    Dim Imagenes As New ArrayList
    '    For Each i As String In cargararrayBD("select image from imagenes_propiedades where IDPropiedades=" & arrayprop.Item(0), "imagenes_propiedades")

    '        Imagenes.Add(Image.FromFile(Application.StartupPath & "\ImgPropiedades\" & i))
    '    Next
    '    Dim propiedad As New Propiedad(arrayprop, cargararrayBD("select hora from propiedades_horas where IDPropiedades=" & arrayprop.Item(0), "propiedades_horas"), cargararrayBD("select dia from propiedades_dias where IDPropiedades=" & arrayprop.Item(0), "propiedades_dias"), Imagenes)
    '    Return propiedad
    'End Function

    Public Function cargarpropBD(numProp As Integer, consulta As String) As ArrayList
        dato.Clear()
        'Crea un array donde guardar los datos de las propiedades y realiza una consulta
        Dim arraydatospropiedades As New ArrayList
        dato = Me.consulta(consulta, "propiedades")
        'Recorre cada propiedad
        For a = 0 To dato.Tables("propiedades").Rows.Count - 1
            Dim propiedadtemp As New ArrayList
            'Agarra todos los items de una propiedad y los guarda en un array
            For b = 0 To dato.Tables("propiedades").Rows(a).ItemArray.Count - 1
                'Si algun campo esta vacio, guarda -1, sino, guarda el valor correspondiente
                If dato.Tables("propiedades").Rows(a).Item(b).ToString = "" Then
                    propiedadtemp.Add(-1)
                Else
                    propiedadtemp.Add(dato.Tables("propiedades").Rows(a).Item(b).ToString)
                End If


            Next
            'A ese array con todos los atributos de una propiedad los guarda en otro array donde estaran todas las propiedades
            arraydatospropiedades.Add(propiedadtemp)

        Next
        'Obtiene 6 propiedades en una consulta
        Dim arraypropiedades As New ArrayList
        'Recorre el array en el cual cada item es un array con los datos de una propiedad
        For a = 0 To arraydatospropiedades.Count - 1
            'Crea un array para las imagenes de la propiedad y obtiene el id
            Dim Imagenes As New ArrayList
            Dim idprop As String = arraydatospropiedades.Item(a).item(0)
            Dim arrayimagenes As New ArrayList
            'Guarda los bytes de las imagenes el arrayimagenes
            arrayimagenes = cargararrayBD("select image from imagenes_propiedades where IDPropiedades=" & idprop, "imagenes_propiedades")
            'Convierte los bytes a imagenes y las guarda en imagenes
            For i = 0 To arrayimagenes.Count - 1

                Imagenes.Add(Metodos.byteaimg(arrayimagenes.Item(i)))

            Next
            dato.Clear()
            'Consulta la localizacion de la propiedad
            dato = Me.consulta("select bar.Nombre, ciu.Nombre,dep.Nombre from barrios as bar, ciudades as ciu,departamentos as dep, propiedades as prop where bar.IDBarrio=prop.IDBarrio and prop.IDPropiedades=" & idprop & " and ciu.IDCiudad=prop.IDCiudad and dep.IDDepartamento=prop.IDDepartamento", "localizacion")

            Dim departamento As String = dato.Tables("localizacion").Rows(0).Item(2).ToString
            Dim barrio As String = dato.Tables("localizacion").Rows(0).Item(0).ToString
            Dim ciudad As String = dato.Tables("localizacion").Rows(0).Item(1).ToString

            Dim propiedad As Propiedad
            'Se fija si la propiedad tiene imagenes y si no tiene, agrega una imagen vacia
            If Imagenes.Count = 0 Then
                Imagenes.Add(Image.FromFile(Application.StartupPath & "\ImgPropiedades\noimage_ver2.png"))
            End If
            'Crea la propiedad con los datos obtenidos y guarda la propiedad en el array
            propiedad = New Propiedad(arraydatospropiedades.Item(a), Imagenes, ciudad, barrio, departamento)

            arraypropiedades.Add(propiedad)
        Next
        'Retorna el array donde se encuentran las 6 propiedades
        Return arraypropiedades

    End Function

    'Obtiene una propiedad
    Public Function cargarpropBD(IDProp As String, consulta As String) As Propiedad
        dato.Clear()
        'Crea el array donde se guardaran los datos de la propiedad y realiza la consulta
        Dim arraydatospropiedad As New ArrayList
        dato = Me.consulta(consulta & " where IDPropiedades=" & IDProp, "propiedades")

        'Añade cada dato al array
        For b = 0 To dato.Tables("propiedades").Rows(0).ItemArray.Count - 1
            'Verifica si esta vacio algun elemento, si lo esta, añade -1. Sino, añade el valor correspondiente
            If dato.Tables("propiedades").Rows(0).Item(b).ToString = "" Then
                arraydatospropiedad.Add(-1)
            Else
                arraydatospropiedad.Add(dato.Tables("propiedades").Rows(0).Item(b).ToString)
            End If



        Next


        Dim Imagenes As New ArrayList
        'Obtiene los bytes de las imagenes, las convierte a imagenes y las guarda en el array
        Dim arrayimagenes As New ArrayList
        arrayimagenes = cargararrayBD("select image from imagenes_propiedades where IDPropiedades=" & IDProp, "imagenes_propiedades")
        For i = 0 To arrayimagenes.Count - 1

            Imagenes.Add(Metodos.byteaimg(arrayimagenes.Item(i)))

        Next
        dato.Clear()
        'Obtiene la localizacion de la propiedad
        dato = Me.consulta("select bar.Nombre, ciu.Nombre,dep.Nombre from barrios as bar, ciudades as ciu,departamentos as dep, propiedades as prop where bar.IDBarrio=prop.IDBarrio and prop.IDPropiedades=" & IDProp & " and ciu.IDCiudad=prop.IDCiudad and dep.IDDepartamento=prop.IDDepartamento", "localizacion")

        Dim departamento As String = dato.Tables("localizacion").Rows(0).Item(2).ToString
        Dim barrio As String = dato.Tables("localizacion").Rows(0).Item(0).ToString
        Dim ciudad As String = dato.Tables("localizacion").Rows(0).Item(1).ToString

        Dim propiedad As Propiedad
        'Si no hay ninguna imagen asignada a la propiedad, se le asigna una default
        If Imagenes.Count = 0 Then
            Imagenes.Add(Image.FromFile(Application.StartupPath & "\ImgPropiedades\noimage_ver2.png"))
        End If

        'Crea y retorna la propiedad
        propiedad = New Propiedad(arraydatospropiedad, Imagenes, ciudad, barrio, departamento)

        Return propiedad

    End Function
End Class
