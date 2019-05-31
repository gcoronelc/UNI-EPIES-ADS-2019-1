Public Class frmlogin

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblhora.Text = TimeOfDay
        txtUsuario.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Try


            Dim user = txtUsuario.Text
            Dim password = txtpassword.Text

            If ((user.Equals("20121111E") And password.Equals("1234") = True ) Or  
                         (user.Equals("20120001A") And password.Equals("1234") = True ))   Then
                'Form1.Show()
                Dim cd As New Form1(user)
                cd.ShowDialog()
                             
            Else
                MsgBox("Ingrese nuevamente sus datos correctos", MsgBoxStyle.Information, "Accesos denegado al sistema")
                txtpassword.Clear()
                txtUsuario.Focus()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class