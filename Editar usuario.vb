Public Class Editar_usuario

   
    Private Sub Editar_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        leer("SELECT  user FROM `usuario`", ComboBox1, "user")




    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim lector As String = ComboBox1.Text


        '("SELECT `user` FROM `usuario` WHERE `user`= '" + TextBox1.Text + " '")



        
        If verificar_user2(lector) Then





            If TextBox2.Text = TextBox3.Text Then

                crear("UPDATE `usuario` SET `pass` = '" + TextBox2.Text + "' WHERE `user`= '" + ComboBox1.Text + "'")

                MsgBox("La contraseña se cambio con exito")





            Else

                MsgBox("Las contraseñas no coinciden vuelve a intentar ")





            End If



        Else
            MsgBox("la contraseña actual no coicide")


        End If





    End Sub
End Class