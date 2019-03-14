Public Class agregar

    Private Sub agregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        leer("SELECT  * FROM `localizacion`", ComboBox2, "colonia")
        leer("SELECT  * FROM `localizacion2`", ComboBox1, "calle")



    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '     If caja_NomHumano.Text.Trim = "" Or Caja_colonia_humano.Text.Trim = "" Or Caja_direccionHuma.Text.Trim = "" Or Caja_NumDireccion_huma.Text.Trim = "" Then

        '   MsgBox("Existen Campos Vacios Que Requieren Ser LLenados Por Favor Verifique")

        '      Else

        '     crear("INSERT INTO `humano` (`id_humano`, `nombre`, `direccion`, `num_direccion`, `Coloia`, `telefono`, `celular`, `Nota`) VALUES (NULL,'" + caja_NomHumano.Text + "','" + Caja_direccionHuma.Text + "','" + Caja_NumDireccion_huma.Text + "','" + Caja_colonia_humano.Text + "','" + caja_telefono_humano.Text + "','" + Caja_celular_humano.Text + "','" + Caja_notas.Text + "');")

        MsgBox("Registro se guardo de manera temporal /n !Agregue una mascota para guardar de manera permanente ")




        Dim personaobj As New Class_Pesona(caja_NomHumano.Text, ComboBox1.Text, Caja_NumDireccion_huma.Text, ComboBox2.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, Caja_notas.Text)


        Dim form As New menupersona(personaobj)



        Me.Hide()
        Form.ShowDialog()
        Me.Show()

        LimpiarFormulario(Me)



        ' main.MascotaToolStripMenuItem_Click(sender, e) 
        '--------------------------------------------------------------------------------------------------






        '    End If



    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()

        agrega_colonia.ShowDialog()
        agregar_Load(sender, e)
        Me.Show()



    End Sub

    Function CerrarVentana(ByVal nombreformulario As String) As Boolean

        If Me.MdiChildren.Length > 0 Then

            For Each f As Form In Me.MdiChildren
                If f.Name = nombreformulario Then


                    f.Activate()
                    Return False



                End If
            Next

        Else

            Return (True)
        End If

        Return (False)

    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Hide()

        agrega_calle.ShowDialog()
        agregar_Load(sender, e)
        Me.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()

        eliminar_calle.ShowDialog()
        agregar_Load(sender, e)
        Me.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Me.Hide()

        Eliminacolo.ShowDialog()
        agregar_Load(sender, e)
        Me.Show()


    End Sub
End Class