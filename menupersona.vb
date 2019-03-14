Public Class menupersona
    Public persona As Class_Pesona



    Sub New(ByVal persona As Class_Pesona)
        ' TODO: Complete member initialization 
        InitializeComponent()

        Me.persona = persona

        Me.Text = "Cliente :" + persona.nombre
        Label8.Text = persona.nombre
        Label9.Text = persona.direccion
        Label10.Text = persona.numero_direccion
        Label11.Text = persona.colonia
        Label11.Text = persona.telefono
        Label12.Text = persona.celular
        Label13.Text = persona.notas

        '''''''''''''''''''''''''''''''''''''''''''''''


    End Sub

    Private Sub menupersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub

 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim form As New AgregaMascota(persona)

        Me.Hide()
        form.ShowDialog()
        Me.Show()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        crear("DELETE  FROM `humano` WHERE `id_humano`= " + persona.id_persona + "")
        MsgBox("Se Elimino Correctamente ")



        Me.Close()




    End Sub
End Class