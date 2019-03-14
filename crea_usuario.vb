Public Class crea_usuario

    Private Sub crea_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' INSERT INTO `usuario` (`IDUser`, `user`, `pass`) VALUES (NULL, '2', '2');


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then

            MsgBox("Existen campos vacios ")
            LimpiarFormulario(Me)

        Else
            If TextBox2.Text = TextBox2.Text Then

                crear("INSERT INTO `usuario` (`IDUser`, `user`, `pass`) VALUES (NULL, '" + TextBox1.Text + "', '" + TextBox2.Text + "');")

                MsgBox("Usuario Creado Con Exito")
                LimpiarFormulario(Me)

            Else

                MsgBox("Las contraseñas no coinciden ")
                LimpiarFormulario(Me)

            End If

        End If

    End Sub
End Class