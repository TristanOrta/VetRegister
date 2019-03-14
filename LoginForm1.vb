
Public Class LoginForm1

    Dim cont As Integer



    Private Sub Login_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Me.Close()
    End Sub



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If cont = 5 Then
            MsgBox("Te has equivocado 5 veces CERRANDO EL SISTEMA", MsgBoxStyle.Exclamation, "ERROR CERRANDO SISTEMA")

            Me.Close()

        End If


        If (Me.userbox.Text = "" Or Me.contrabox.Text = "") Then


            '  MsgBox("ERROR Usuario y/o  ", MsgBoxStyle.Exclamation, "ERROR")




            cont += 1
                  End If

        If verificar_user2(userbox.Text) Then

            MsgBox("BIENVENIDO ", MsgBoxStyle.Information, "Kaia Veterinaria")

            ' Menu.show()
            Me.Close()

        Else
            MsgBox("Usuario incorrecto")

            LimpiarFormulario(Me)
            OK.Enabled = False

            cont += 1
            If cont = 5 Then
                MsgBox("Te has equivocado 5 veces CERRANDO EL SISTEMA", MsgBoxStyle.Exclamation, "ERROR CERRANDO SISTEMA")

                Me.Close()

            End If



        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        main.Close()


    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.OK.Enabled = False


    End Sub

    Private Sub userbox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles userbox.KeyUp, contrabox.KeyUp

        If contrabox.Text.Length > 0 And userbox.Text.Length > 0 Then
            OK.Enabled = True
        Else
            OK.Enabled = False

        End If

    End Sub



    Private Sub LoginForm1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' main.Close()
        If UserId = "" And UserName = "" Then
            main.Close()

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        probarconexion()



    End Sub
End Class


