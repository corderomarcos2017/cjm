Public Class frmInicioSesion



    Dim TraigoMiUsuario As Boolean

    Private Sub chkMostrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrar.CheckedChanged
        If chkMostrar.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
        txtPassword.Focus()
        txtPassword.SelectionStart = Len(txtPassword.Text) + 1

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        End
    End Sub

  

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = 13 Then 'Si pulso la tecla ENTER
            If UCase(txtUsuario.Text) = "ADMIN" Or Len(txtUsuario.Text) >= 8 Then
                'Devuelve Verdadero si encontro el usuario
                TraigoMiUsuario = miUsuario.traerUsuario(txtUsuario.Text)

                If TraigoMiUsuario = True Then 'Si encontre al usuario
                    'Guardo el Apellido y nombre del usuario en el lblNombre
                    lblNombre.Text = miUsuario.ApellidoNombre
                    lblNombre.ForeColor = Color.Blue

                    txtPassword.Enabled = True
                    cmdAceptar.Enabled = True
                    txtPassword.BackColor = Color.White

                    'Si el usuario tiene el campo CambiarPassword en "S" se va activar esta opcion
                    If miUsuario.cambiarPassword = "S" Then
                        frmUsuariosCambioDeContraseña.Show()
                    Else
                        saltar(e.KeyCode)
                    End If

                Else
                    txtUsuario.Text = ""
                    txtPassword.Enabled = False
                    cmdAceptar.Enabled = False
                    txtPassword.BackColor = Color.LightBlue

                    lblNombre.Text = "Usuario no registrado o nombre incorrecto, intente nuevamente."
                    lblNombre.ForeColor = Color.Red

                End If
            Else
                lblNombre.Text = ""
                lblNombre.Text = "Debe escribir un minimo de 8 caracteres para el nombre de usuario"
                txtUsuario.SelectionStart = 0
                txtUsuario.SelectionLength = Len(txtUsuario.Text)
                lblNombre.ForeColor = Color.Red
                txtPassword.Enabled = False
                cmdAceptar.Enabled = False
                txtPassword.BackColor = Color.LightBlue

            End If

        End If
    End Sub
    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        saltar(e.KeyCode) 'Avanzo al siguiente objeto si pulso la tecla ENTER
    End Sub
    Private Sub txtPassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If lblMensajeContraseña.Text = "La contraseña no coincide con el usuario, intente nuevamente." And txtPassword.Text <> "" Then
            lblMensajeContraseña.Text = ""
        End If
    End Sub
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtPassword.Text = miUsuario.Password Then
            frmMenuPrincipal.ShowDialog()
            txtUsuario.Focus()
            txtPassword.Text = ""
            txtUsuario.Text = ""
        Else
            lblMensajeContraseña.Text = "La constraseña no coincide con el usuario, intente nuevamente."
            lblMensajeContraseña.ForeColor = Color.Red
            'MessageBox.Show("La constraseña es incorrecta...", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            txtPassword.Focus()
        End If
    End Sub
    Private Sub btnOlvideUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOlvideUsuario.Click
        'Dim correo As String
        'correo = InputBox("Ingrese su correro")
        'If correo <> "" Then
        '    miDataSet.Clear()

        '    miAdapter = New OleDb.OleDbDataAdapter("select * from usuarios where mail='" & correo & "'", miConexion)
        '    miAdapter.Fill(miDataSet, "dtUsuariosTemp")
        '    miAdapter.Dispose()

        '    'cargo en contenidio del dataset en un datatable
        '    miTabla = miDataSet.Tables("dtUsuariosTemp")
        '    ' miTabla.DefaultView.Sort = "IdUsuario asc"
        '    cantidad = miTabla.Rows.Count()
        '    If cantidad > 0 Then
        '        Dim nombre As String = miTabla.Rows(0).Item("apenom").ToString
        '        Dim usuario As String = miTabla.Rows(0).Item("nombreusuario").ToString

        '        enviarCorreo("corderomarcos2017@gmail.com", "fajblkaipibxokgz", _
        '                     "Hola " & nombre & ", tu usuario es " & usuario, _
        '                     "Asunto, recuperar usuario", correo)

        '    Else
        '        MessageBox.Show("Correo no encontrado...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    End If



        'End If

    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged
        If UCase(txtUsuario.Text) = "ADMIN" Or Len(txtUsuario.Text) >= 8 Then
  
        Else
            lblNombre.Text = ""

            txtPassword.Enabled = False
            cmdAceptar.Enabled = False
            txtPassword.BackColor = Color.LightBlue

        End If
    End Sub

    Private Sub frmInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class