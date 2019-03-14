Imports MySql.Data.MySqlClient
Module conexion

    Dim mysqlconnstring As String = "server=127.0.0.1;user id=root;password=;database=veterinaria"
    Public conexion As MySqlConnection = strconexion()
    Public resultado As String
    Public command As New MySqlCommand
    Public dataadapter As New MySqlDataAdapter
    Public datatable As New DataTable
    Public dataset As New DataSet
    Dim sqlreader As MySqlDataReader
    Public UserId As String
    Public UserName As String

    Public Function strconexion() As MySqlConnection
        Return New MySqlConnection(mysqlconnstring)
    End Function


    Public Function ultimo_id() As String
        Dim id As String = ""
        Try
            With command
                .Connection = conexion
                .CommandText = "SELECT LAST_INSERT_ID() as ultimo"
                .CommandType = CommandType.Text
            End With
            If conexion.State = ConnectionState.Closed Then conexion.Open()
            sqlreader = command.ExecuteReader
            If (sqlreader.Read) Then
                id = (sqlreader("ultimo").ToString())
                conexion.Close()
                sqlreader.Close()
                Return id
            End If

            Return id
        Catch ex As Exception
            MsgBox("Error con la base de datos" + ex.ToString)
            Return id
        End Try

    End Function





    Public Function verificar_user(ByVal user As String, ByVal pass As String) As Boolean

        With command
            .Connection = conexion
            .CommandText ="SELECT `IDUser`,`user` FROM `usuario` WHERE `user`='" + user + "'AND `pass`='" + pass + "'"
            .CommandType = CommandType.Text
        End With
        Try

            If conexion.State = ConnectionState.Closed Then conexion.Open()
            sqlreader = command.ExecuteReader
            If (sqlreader.Read) Then
                UserId = (sqlreader("IDUser").ToString())
                UserName = (sqlreader("user").ToString())
                conexion.Close()
                sqlreader.Close()
                Return True
            Else
                conexion.Close()
                sqlreader.Close()
                Return False
            End If


        Catch ex As Exception
            MsgBox("error: " + ex.ToString)
            conexion.Close()
            sqlreader.Close()
            Return False
        End Try


    End Function

    Public Function verificar_user2(ByVal user As String) As Boolean

        With command
            .Connection = conexion
            .CommandText = "SELECT `IDUser`,`user` FROM `usuario` WHERE `user`='" + user + "'"
            .CommandType = CommandType.Text
        End With
        Try

            If conexion.State = ConnectionState.Closed Then conexion.Open()
            sqlreader = command.ExecuteReader
            If (sqlreader.Read) Then
                UserId = (sqlreader("IDUser").ToString())
                UserName = (sqlreader("user").ToString())
                conexion.Close()
                sqlreader.Close()
                Return True
            Else
                conexion.Close()
                sqlreader.Close()
                Return False
            End If


        Catch ex As Exception
            MsgBox("error: " + ex.ToString)
            conexion.Close()
            sqlreader.Close()
            Return False
        End Try


    End Function

    Public Function llenar_tabla(ByVal sql As String, ByVal tabla As Object) As Object
        command = New MySqlCommand
        With command
            .Connection = conexion
            .CommandText = sql
            .CommandType = CommandType.Text

        End With
        Try
            If conexion.State = ConnectionState.Closed Then conexion.Open()

            dataadapter = New MySqlDataAdapter(command)
            dataset = New DataSet
            dataadapter.Fill(dataset)
            tabla.datasource = dataset.Tables(0).DefaultView
            conexion.Close()
            sqlreader.Close()
            dataadapter.Dispose()
            dataset.Dispose()


        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
        Return tabla
    End Function



    '-----CRUD-------
    'create 
    Public Sub crear(ByVal sql As String)
        Try
            conexion.Open()
            With command
                .Connection = conexion
                .CommandText = sql
                resultado = command.ExecuteNonQuery
                If resultado = 0 Then
                    MsgBox("Error al guardar información.", MsgBoxStyle.Critical)
                End If
            End With
        Catch ex As Exception
            conexion.Close()
            MsgBox("Error: " & ex.Message)
        End Try
        conexion.Close()
    End Sub
    Public Sub crear_retorna_id(ByVal sql As String)
        Try
            conexion.Open()
            With command
                .Connection = conexion
                .CommandText = sql
                resultado = command.ExecuteNonQuery
                If resultado = 0 Then
                    MsgBox("Error al guardar información.", MsgBoxStyle.Critical)

                End If
            End With


        Catch ex As Exception
            conexion.Close()
            MsgBox("Error: " & ex.Message)
        End Try
        conexion.Close()

    End Sub
    'read especialidades
    Public Sub leer(ByVal sql As String, ByVal objeto As Object, ByVal nombretabla As String)
        Try
            dataset = New DataSet()
            conexion.Open()
            With command
                .Connection = conexion
                .CommandText = sql
                resultado = command.ExecuteNonQuery
                If resultado = 0 Then
                    MsgBox("Error al leer información.", MsgBoxStyle.Critical)
                End If
            End With
            dataadapter.SelectCommand = command
            dataadapter.Fill(dataset)

            objeto.DataSource = dataset.Tables(0)

            objeto.DisplayMember = nombretabla
            '  objeto.ValueMember = "id_raza"

        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
        End Try
        conexion.Close()
        dataadapter.Dispose()

    End Sub


    Public Sub LimpiarFormulario(ByVal formulario As Form)
        For Each dato As Object In formulario.Controls                  'recorre todo el form object a object

            If TypeOf dato Is TextBox Then                      'si el objeto es un textbox
                DirectCast(dato, TextBox).Text = ""             'casting y elimina el dato de cuadro

            ElseIf TypeOf dato Is ComboBox Then                 'si el objeto es ComboBox
                DirectCast(dato, ComboBox).SelectedIndex = -1   'Casting y elimina seleccion

            ElseIf TypeOf dato Is DateTimePicker Then           'si el Object es DateTimePicker
                DirectCast(dato, DateTimePicker).Text = ""      'Casting y reinicia la fecha

            ElseIf TypeOf dato Is MaskedTextBox Then            'si el Object es MaskedTextBox
                DirectCast(dato, MaskedTextBox).Text = ""       'Casting y elimina numero 
            End If

        Next
    End Sub





    Public Sub probarconexion()
        Try
            conexion.Open()
            MsgBox("Conexion realizada con exito")
            conexion.Close()
        Catch ex As Exception
            MsgBox("Conexion fallida" & ex.Message)
        End Try
    End Sub
End Module

