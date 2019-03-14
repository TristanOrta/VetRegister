Public Class eliminar_calle



    Private Sub eliminar_calle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        leer("SELECT  * FROM `localizacion2`", ComboBox1, "calle")


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        crear("DELETE FROM `localizacion2` WHERE `calle`= '" + ComboBox1.Text + "'")
        MsgBox("Se Elimino Correctamente ")
        LimpiarFormulario(Me)
        eliminar_calle_Load(sender, e)

    End Sub
End Class