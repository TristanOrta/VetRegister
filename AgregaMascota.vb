Public Class AgregaMascota

    Dim Macho As Integer = 1
    Dim Hembra As Integer = 1



    Private persona As Class_Pesona

    Sub New(ByVal persona As Class_Pesona)
        ' TODO: Complete member initialization 

        InitializeComponent()

        Me.persona = persona
    End Sub

    Private Sub AgregaMascota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        leer("SELECT  * FROM `razas`", ComboBox1, "raza")


    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub AgregarMascota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarMascota.Click

        If persona.agregado = False Then

            crear("INSERT INTO `humano` (`id_humano`, `nombre`, `direccion`, `num_direccion`, `Coloia`, `telefono`, `celular`, `Nota`) VALUES (NULL,'" + persona.nombre + "','" + persona.direccion + "','" + persona.numero_direccion + "','" + persona.colonia + "','" + persona.telefono + "','" + persona.celular + "','" + persona.notas + "');")

            persona.id_persona = ultimo_id()
            persona.agregado = True

        End If

        crear("INSERT INTO `perro` (`ID_perro`, `nombre`, `raza`, `id_humano`, `sexo`) VALUES (NULL, '" + TextBox1.Text + "', '" + ComboBox1.Text + "', '" + persona.id_persona + "', '" + ComboBox2.Text + "');")

        MsgBox("Se Agrego Correctamente  ", MsgBoxStyle.Information, "MASCOTA")

        LimpiarFormulario(Me)


        ' If MsgBox("Decea agregar otro registro de mascota?", MsgBoxStyle.YesNo, "MASCOTA") = False Then




        '  End If





    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged




    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        '    KeyAscii = Asc(StrConv(Chr$(KeyAscii), vbUpperCase))

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Me.Hide()
        Form1Agrega_Raza.ShowDialog()
        AgregaMascota_Load(sender, e)
        Me.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        Eliminar_raza.ShowDialog()
        AgregaMascota_Load(sender, e)
        Me.Show()

    End Sub
End Class