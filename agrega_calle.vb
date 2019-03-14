Public Class agrega_calle

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        crear("INSERT INTO `localizacion2` (`id_localizacion2`, `calle`) VALUES (NULL, '" + TextBox1.Text + "');")



        MsgBox("se agrego correctamente")
        LimpiarFormulario(Me)

    End Sub

    Private Sub agrega_calle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class