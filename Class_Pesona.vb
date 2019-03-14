Public Class Class_Pesona

    Public id_persona As String
    Public nombre As String
    Public direccion As String
    Public numero_direccion As String
    Public colonia As String
    Public telefono As String
    Public celular As String
    Public notas As String
    Public agregado As Boolean

    Sub New(ByVal nombre As String, ByVal direccion As String, ByVal numero_direccion As String, ByVal colonia As String, ByVal telefono As String, ByVal celular As String, ByVal notas As String)


        Me.agregado = False


        Me.id_persona = ""
        Me.nombre = nombre
        Me.direccion = direccion
        Me.numero_direccion = numero_direccion
        Me.colonia = colonia
        Me.telefono = telefono
        Me.celular = celular
        Me.notas = notas



    End Sub

    Sub New(ByVal id_persona As String, ByVal nombre As String, ByVal direccion As String, ByVal numero_direccion As String, ByVal colonia As String, ByVal telefono As String, ByVal celular As String, ByVal notas As String)


        Me.agregado = True


        Me.id_persona = id_persona
        Me.nombre = nombre
        Me.direccion = direccion
        Me.numero_direccion = numero_direccion
        Me.colonia = colonia
        Me.telefono = telefono
        Me.celular = celular
        Me.notas = notas



    End Sub

End Class

