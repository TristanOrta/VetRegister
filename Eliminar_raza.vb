Public Class Eliminar_raza

    Private Sub Eliminar_raza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        leer("SELECT  * FROM `razas`", ComboBox1, "raza")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        crear("DELETE FROM `razas` WHERE `raza`= '" + ComboBox1.Text + "'")
        MsgBox("Se Elimino Correctamente ")
        LimpiarFormulario(Me)
        Eliminar_raza_Load(sender, e)



    End Sub
End Class