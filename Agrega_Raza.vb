Public Class Form1Agrega_Raza

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        crear("INSERT INTO `razas` (`id_raza`, `raza`) VALUES (NULL, '" + TextBox1.Text + "');")




        MsgBox("se agrego correctamente")
        LimpiarFormulario(Me)



    End Sub
End Class