Public Class Eliminacolo

    Private Sub Eliminacolo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        leer("SELECT  * FROM `localizacion`", ComboBox1, "colonia")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        crear("DELETE FROM `localizacion` WHERE `colonia`= '" + ComboBox1.Text + "'")
        MsgBox("Se Elimino Correctamente ")
        LimpiarFormulario(Me)
        Eliminacolo_Load(sender, e)
    End Sub
End Class