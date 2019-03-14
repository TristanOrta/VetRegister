Public Class consulUsuario

    Private Sub consulUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llenar_tabla("SELECT `user` FROM `usuario`", DataGridView1)
        Dim sql As String = "SELECT `user` FROM `usuario` ORDER BY `usuario`.`user` ASC "
        DataGridView1 = llenar_tabla(sql, DataGridView1)
        'oculta todos las columnas de la tabla
       



    End Sub
End Class