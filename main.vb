Public Class main
    Private Sub Form_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm1.ShowDialog()



    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click


    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim fomrAcerca As New acerca
        fomrAcerca.ShowDialog()


    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

    

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If CerrarVentana("formeliminate") Then

            Dim formeliminate As New eliminar
            formeliminate.MdiParent = Me
            formeliminate.Show()
            Me.Size = New System.Drawing.Size(Size.Width, Size.Height + 1)
            Me.Show()

        End If

    End Sub

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub




    Function CerrarVentana(ByVal nombreformulario As String) As Boolean

        If Me.MdiChildren.Length > 0 Then

            For Each f As Form In Me.MdiChildren
                If f.Name = nombreformulario Then


                    f.Activate()
                    Return False



                End If
            Next

        Else

            Return (True)
        End If

        Return (False)

    End Function


    Private Sub AgregToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click

        consulUsuario.ShowDialog()


    End Sub

    Private Sub PersonaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaToolStripMenuItem.Click

        If CerrarVentana("formAgrega") Then

            Dim formAgrega As New agregar
            formAgrega.MdiParent = Me
            formAgrega.Show()

            Me.Size = New System.Drawing.Size(Size.Width, Size.Height + 1)
            Me.Show()

        End If


    End Sub

    Public Sub MascotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MascotaToolStripMenuItem.Click


        '''''''''''''''''''''''''''''''''''''''''''''''''''''

        If CerrarVentana("formAgrega") Then

            Dim formAgrega As New Busca_personas
            formAgrega.MdiParent = Me
            formAgrega.Show()

            Me.Size = New System.Drawing.Size(Size.Width, Size.Height + 1)
            Me.Show()

        End If




    End Sub


    Private Sub MascotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MascotaToolStripMenuItem1.Click
        If CerrarVentana("Formbuscador") Then

            Dim Formbuscador As New buscar
            Formbuscador.MdiParent = Me

            Formbuscador.Show()
            Me.Size = New System.Drawing.Size(Size.Width, Size.Height + 1)
            Me.Show()

        End If

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click


        Me.Hide()

        crea_usuario.ShowDialog()

        Me.Show()

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click

    End Sub

    Private Sub PersonaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaToolStripMenuItem1.Click


        If CerrarVentana("Formbuscador") Then

            Dim Formbuscador As New Busca_personas
            Formbuscador.MdiParent = Me

            Formbuscador.Show()
            Me.Size = New System.Drawing.Size(Size.Width, Size.Height + 1)
            Me.Show()

        End If



        ' Me.Hide()
        ' Busca_personas.ShowDialog()
        ' Me.Show()


    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click

        Me.Hide()

        Editar_usuario.ShowDialog()

        Me.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem1.Click

        Me.Hide()

        eliminausu.ShowDialog()

        Me.Show()


    End Sub

    Private Sub CitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CitasToolStripMenuItem.Click

    End Sub
End Class