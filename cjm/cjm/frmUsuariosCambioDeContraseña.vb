Public Class frmUsuariosCambioDeContraseña
    Private Sub frmUsuariosCambioDeContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblNombre.Text = usuario & "(" & miUsuario.nombreUsuario & ")"
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtPasswordActual.Text = miUsuario.Password Then
            If txtPasswordNueva.Text = txtPasswordRepitala.Text Then
                password = txtPasswordNueva.Text

                miUsuario.Password = txtPasswordNueva.Text
                miUsuario.cambiarPassword = "N"
                miUsuario.Modificar()
                MessageBox.Show("La contraseña se cambio con exito..", "Password cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                lblMensajeContraseña.Text = "Las contraseñas no coinciden..."
            End If
        Else
            lblMensajeContraseña.Text = "La contraseña actual es incorrecta..."
        End If

        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class