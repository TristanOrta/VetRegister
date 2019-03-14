Public Class Busca_personas

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub Busca_personas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        leer("SELECT  * FROM `localizacion`", ComboBox1, "colonia")

        leer("SELECT  * FROM `localizacion2`", ComboBox2, "calle")

        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1



    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim id_persona As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("id_humano").Value)
        Dim nombre As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("NOMBRE").Value)
        Dim direccion As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("DIRECCION").Value)
        Dim numero_direccion As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("NO.DIRECCION").Value)
        Dim colonia As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("COLONIA").Value)
        Dim telefono As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("TELEFONO").Value)
        Dim celular As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("CELULAR").Value)
        Dim notas As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("NOTA").Value)
        


        Dim persona As Class_Pesona = New Class_Pesona(id_persona, nombre, direccion, numero_direccion, colonia, telefono, celular, notas)

        Me.Hide()
        Dim form As menupersona = New menupersona(persona)
        form.ShowDialog


        Me.Show()

    End Sub

    ' Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim sql As String = " SELECT DISTINCT perro.nombre as 'Mascota',perro.raza as 'Raza',perro.sexo as 'Sexo' ,humano.nombre as 'Nombre',humano.direccion as 'Direccion', humano.num_direccion as 'No.Direccion', humano.Coloia as 'Colonia',humano.telefono as 'Telefono',humano.celular as 'Celular', humano.Nota as 'Nota' FROM `perro`,`humano` WHERE  humano.id_humano = perro.id_humano"




    '  If ComboBox1.Text <> "" Then
    '       sql = sql + " and `raza` = '" + ComboBox1.Text + "'"
    '   End If
    '  If ComboBox2.Text <> "" Then
    '     sql = sql + " and `Coloia` = '" + ComboBox2.Text + "'"
    'End If
    '   If ComboBox3.Text <> "" Then
    '      sql = sql + " and `direccion` = '" + ComboBox3.Text + "'"
    ' End If
    ' MsgBox(sql)
    ' llenar_tabla(sql, tabla)





    '  End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        If ComboBox1.Text.Trim = "" And ComboBox2.Text.Trim = "" Then 'si ambos combox estan vacios entra

            Dim sql As String = "SELECT `id_humano`, `nombre` AS 'NOMBRE',`direccion` AS 'DIRECCION',`num_direccion` AS 'NO.DIRECCION',`Coloia` As 'COLONIA',`telefono` AS 'TELEFONO', `celular` AS 'CELULAR',`Nota` AS 'NOTA' FROM `humano`  "

            DataGridView1 = llenar_tabla(sql, DataGridView1)

        ElseIf ComboBox1.Text.Trim = "" Then ' como tambien se cumple y no hay un else tambien entrara aqui(agrego else)

            Dim sql As String = "SELECT `id_humano`, `nombre` AS 'NOMBRE',`direccion` AS 'DIRECCION',`num_direccion` AS 'NO.DIRECCION',`Coloia` As 'COLONIA',`telefono` AS 'TELEFONO', `celular` AS 'CELULAR',`Nota` AS 'NOTA' FROM `humano` WHERE    `direccion` ='" + ComboBox2.Text + "'"

            ' Dim sql As String = "SELECT * FROM `humano` WHERE    `direccion` ='" + ComboBox2.Text + "'"


            DataGridView1 = llenar_tabla(Sql, DataGridView1)

        ElseIf ComboBox2.Text.Trim = "" Then ' como tambien se cumple y no hay un else tambien entrara aqui(agrego else)

            Dim sql As String = "SELECT `id_humano`, `nombre` AS 'NOMBRE',`direccion` AS 'DIRECCION',`num_direccion` AS 'NO.DIRECCION',`Coloia` As 'COLONIA',`telefono` AS 'TELEFONO', `celular` AS 'CELULAR',`Nota` AS 'NOTA' FROM `humano` WHERE    `Coloia` ='" + ComboBox1.Text + "'"

            DataGridView1 = llenar_tabla(sql, DataGridView1)


        Else ' como tambien se cumple y no hay un else tambien entrara aqui(agrego else)

            Dim sql As String = "SELECT `id_humano`, `nombre` AS 'NOMBRE',`direccion` AS 'DIRECCION',`num_direccion` AS 'NO.DIRECCION',`Coloia` As 'COLONIA',`telefono` AS 'TELEFONO', `celular` AS 'CELULAR',`Nota` AS 'NOTA' FROM `humano` WHERE    `Coloia` ='" + ComboBox1.Text + "' and `direccion` ='" + ComboBox2.Text + "'"

            DataGridView1 = llenar_tabla(sql, DataGridView1)


        End If







        'oculta todos las columnas de la tabla



        '    If ComboBox1.Text <> "" Then
        'sql = sql + "and  `Coloia` = '" + ComboBox1.Text + "' "
        '  End If
        ' If ComboBox2.Text <> "" Then
        'sql = sql + "and `direccion` = '" + ComboBox2.Text + "'"
        'End If
        ' DataGridView1 = llenar_tabla(Sql, DataGridView1)
        '    MsgBox("sql " + Sql)

        '-----------------------------------------------------------------------------------------------------------
        For x = 0 To DataGridView1.ColumnCount - 1
            Me.DataGridView1.Columns(x).Visible = False
        Next
        Me.DataGridView1.Columns("NOMBRE").Visible = True
        Me.DataGridView1.Columns("COLONIA").Visible = True
        Me.DataGridView1.Columns("CELULAR").Visible = True



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim sql As String = "SELECT `id_humano`, `nombre` AS 'NOMBRE',`direccion` AS 'DIRECCION',`num_direccion` AS 'NO.DIRECCION',`Coloia` As 'COLONIA',`telefono` AS 'TELEFONO', `celular` AS 'CELULAR',`Nota` AS 'NOTA' FROM `humano` where '" + MaskedTextBox1.Text + "'= `celular`"
        DataGridView1 = llenar_tabla(sql, DataGridView1)
        For x = 0 To DataGridView1.ColumnCount - 1
            Me.DataGridView1.Columns(x).Visible = False
        Next
        Me.DataGridView1.Columns("NOMBRE").Visible = True
        Me.DataGridView1.Columns("COLONIA").Visible = True
        Me.DataGridView1.Columns("CELULAR").Visible = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class