Public Class agrega_colonia

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        crear("INSERT INTO `localizacion` (`id_localizacion`, `colonia`) VALUES (NULL, '" + TextBox1.Text + "');")


        MsgBox("se agrego correctamente")
        LimpiarFormulario(Me)

    End Sub

    Private Sub agrega_colonia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class