Public Class eliminausu

    Private Sub eliminausu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        leer("SELECT  * FROM `usuario`", ComboBox1, "user")
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' If ComboBox1.Size Then

        If ComboBox1.Items.Count <> 1 Then


            If verificar_user(TextBox1.Text, TextBox2.Text) Then

                crear("DELETE FROM `usuario` WHERE `user`= '" + ComboBox1.Text + "'")
                MsgBox("usuario eliminado con exito")
                LimpiarFormulario(Me)
                eliminausu_Load(sender, e)

            Else
                MsgBox("Contraseña Incorrecta")
                LimpiarFormulario(Me)

            End If

        Else

            MsgBox("No puede ejecutar la opcion de eliminar usuario cuando solo existe un usuario")
            LimpiarFormulario(Me)
        End If
    End Sub


End Class