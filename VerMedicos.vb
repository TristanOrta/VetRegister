Public Class VerMedicos

    Private Sub VerMedicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar_tabla()


    End Sub

    Private Sub cargar_tabla()
        Dim sql As String = "SELECT `nombre` AS 'Nombre',`ced_prof` AS 'Cedula profesional',`fecha_nac` AS 'Fecha de nacimiento',`telefono_movil` As 'Telefono movil',`telefono_fijo` AS 'Telefono fijo', `correo` AS 'Correo',`direccion` AS 'Direccion' FROM `medico` ORDER BY `Nombre` ASC "
        DataGridView1 = llenar_tabla(sql, DataGridView1)
        'oculta todos las columnas de la tabla
        For x = 0 To DataGridView1.ColumnCount - 1
            Me.DataGridView1.Columns(x).Visible = False
        Next
        Me.DataGridView1.Columns("Nombre").Visible = True
        Me.DataGridView1.Columns("Cedula profesional").Visible = True
        Me.DataGridView1.Columns("Telefono movil").Visible = True
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim nombre As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("Nombre").Value)
        Dim cedula As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("Cedula profesional").Value)
        Dim fecha As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("Fecha de nacimiento").Value)
        Dim telefonoM As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("Telefono movil").Value)
        Dim telefonoF As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("Telefono fijo").Value)
        Dim correo As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("Correo").Value)
        Dim direccion As String = (DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells("Direccion").Value)
        'Dim form As New Individual_Medico(nombre, cedula, fecha, telefonoM, telefonoF, correo, direccion)
        Me.Hide()
        'form.ShowDialog()
        Me.Show()
    End Sub

    
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class