Public Class buscar

    Private Sub buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        leer("SELECT  * FROM `razas`", ComboBox1, "raza")
        leer("SELECT  * FROM `localizacion`", ComboBox2, "colonia")
        leer("SELECT  * FROM `localizacion2`", ComboBox3, "calle")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged



    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sql As String = " SELECT DISTINCT perro.nombre as 'Mascota',perro.raza as 'Raza',perro.sexo as 'Sexo' ,humano.nombre as 'Nombre',humano.direccion as 'Direccion', humano.num_direccion as 'No.Direccion', humano.Coloia as 'Colonia',humano.telefono as 'Telefono',humano.celular as 'Celular', humano.Nota as 'Nota' FROM `perro`,`humano` WHERE  humano.id_humano = perro.id_humano"

      


        If ComboBox1.Text <> "" Then
            sql = sql + " and `raza` = '" + ComboBox1.Text + "'"
        End If
        If ComboBox2.Text <> "" Then
            sql = sql + " and `Coloia` = '" + ComboBox2.Text + "'"
        End If
        If ComboBox3.Text <> "" Then
            sql = sql + " and `direccion` = '" + ComboBox3.Text + "'"
        End If
        ' MsgBox(sql)
        llenar_tabla(sql, tabla)



    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles tabla.CellDoubleClick




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Form1Agrega_Raza.ShowDialog()



    End Sub


    Private Sub buscar_MaximumSizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MaximumSizeChanged
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    End Sub
End Class