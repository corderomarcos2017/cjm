Public Class frmClientesAMC
    'Private posicion As Single, Registros As DataRow
    'Public dsClientes As New DataSet
    'Private Sub frmClientesAMC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    dsClientes.Reset()
    '    Me.Dispose()
    'End Sub
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Cambiar(True)
    '    CargarDataSet("select * from Clientes order by codcli", dsClientes, "dtClientes", miConexion)
    '    dsClientes.Tables("dtClientes").DefaultView.Sort = "CodCli ASC"
    '    posicion = 0
    '    cargar()
    '    Color_Textbox(Me)
    'End Sub
    'Private Sub Cambiar(ByVal Cambio As Boolean)

    '    txtRazon.Enabled = Not Cambio
    '    txtDireccion.Enabled = Not Cambio
    '    txtCp.Enabled = Not Cambio
    '    txtLocalidad.Enabled = Not Cambio
    '    txtTelefono.Enabled = Not Cambio
    '    txtContacto.Enabled = Not Cambio
    '    txtCelular.Enabled = Not Cambio
    '    txtObs.Enabled = Not Cambio
    '    txtMail.Enabled = Not Cambio
    '    txtCuit.Enabled = Not Cambio
    '    cboCondIva.Enabled = Not Cambio
    '    cboRemito.Enabled = Not Cambio
    '    cboTipoFac.Enabled = Not Cambio

    '    txtNroIB.Enabled = Not Cambio
    '    cboCondPago.Enabled = Not Cambio
    '    txtAliDesc.Enabled = Not Cambio
    '    txtDiasVto.Enabled = Not Cambio
    '    txtLimiteDeCredito.Enabled = Not Cambio
    '    txtAdvertenciaAproxLimite.Enabled = Not Cambio

    '    cmdAceptar.Enabled = Not Cambio
    '    cmdCancelar.Enabled = Not Cambio
    'End Sub
    'Private Sub iniciar()
    '    txtRazon.Text = ""
    '    txtDireccion.Text = ""
    '    txtCp.Text = ""
    '    txtLocalidad.Text = ""
    '    txtTelefono.Text = ""
    '    txtContacto.Text = ""
    '    txtCelular.Text = ""
    '    txtObs.Text = ""
    '    txtMail.Text = ""
    '    txtCuit.Text = "__-________-_"
    '    cboCondIva.SelectedIndex = -1

    '    cboRemito.SelectedIndex = 0
    '    cboTipoFac.SelectedIndex = 0


    '    txtNroIB.Text = ""
    '    cboCondPago.Text = ""
    '    txtAliDesc.Text = ""
    '    txtDiasVto.Text = ""
    '    txtLimiteDeCredito.Clear()
    '    txtAdvertenciaAproxLimite.Clear()
    'End Sub
    'Private Sub cargar()
    '    If dsClientes.Tables("dtClientes").Rows.Count > 0 Then
    '        Dim Registros As DataRow
    '        Registros = dsClientes.Tables("dtClientes").Rows(posicion)
    '        lblCodcli.Text = Registros("Codcli").ToString
    '        txtRazon.Text = Registros("Razon").ToString
    '        txtDireccion.Text = Registros("direccion").ToString
    '        txtCp.Text = Registros("cp").ToString
    '        txtLocalidad.Text = Registros("localidad").ToString
    '        txtTelefono.Text = Registros("telefono").ToString
    '        txtContacto.Text = Registros("contacto").ToString
    '        txtCelular.Text = Registros("celular").ToString
    '        txtMail.Text = Registros("mail").ToString
    '        txtCuit.Text = Registros("cuit").ToString
    '        txtObs.Text = Registros("Obs").ToString
    '        cboCondIva.Text = Registros("CondIVA").ToString
    '        cboRemito.Text = Registros("iRemito").ToString
    '        cboTipoFac.Text = Registros("Tipofac").ToString
    '        txtNroIB.Text = Registros("NroIB").ToString
    '        cboCondPago.Text = Registros("CondPago").ToString
    '        txtAliDesc.Text = Registros("AliDesc").ToString
    '        txtDiasVto.Text = Registros("DiasVto").ToString
    '        txtLimiteDeCredito.Text = Registros("LimiteDeCredito").ToString
    '        txtAdvertenciaAproxLimite.Text = Registros("AdvertenciaAproxLimite").ToString
    '    Else
    '        iniciar()
    '    End If
    'End Sub
    ''**********************************************************************************************************************
    'Private Sub btDesplazar(ByVal sender As System.Object, ByVal e As System.EventArgs)


    '    Dim opcion As Button = sender
    '    With dsClientes.Tables("dtClientes").Rows
    '        Select Case opcion.Name
    '            Case "cmdPrimero" : posicion = 0
    '            Case "cmdAnterior" : If posicion = 0 Then posicion = .Count - 1 Else posicion -= 1
    '            Case "cmdSiguiente" : If posicion = .Count - 1 Then posicion = 0 Else posicion += 1
    '            Case "cmdUltimo" : posicion = .Count - 1
    '        End Select
    '    End With
    '    cargar()
    'End Sub
    ''**********************************************************************************************************************
    'Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Close()
    'End Sub
    'Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Cambiar(False)
    '    Flag = 1
    '    iniciar()
    '    lblCodcli.Text = "Nuevo Registro"
    '    lblModo.Text = "NUEVO REGISTRO"
    'End Sub
    'Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If dsClientes.Tables("dtClientes").Rows.Count > 0 Then
    '        Cambiar(False)
    '        Flag = 2
    '        txtRazon.Focus()
    '        lblModo.Text = "MODIFICACION"

    '    Else
    '        MessageBox.Show("No hay registros cargado en la tabla....", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End If
    'End Sub
    'Private Sub CargarRegistro() 'Procedimiento para actualizar le dataset
    '    Registros("codcli") = lblCodcli.Text
    '    Registros("Razon") = txtRazon.Text
    '    Registros("cuit") = txtCuit.Text
    '    Registros("condiva") = cboCondIva.Text
    '    Registros("TipoFac") = cboTipoFac.Text
    '    Registros("direccion") = txtDireccion.Text
    '    Registros("cp") = txtCp.Text
    '    Registros("localidad") = txtLocalidad.Text
    '    Registros("telefono") = txtTelefono.Text
    '    Registros("celular") = txtTelefono.Text
    '    Registros("contacto") = txtContacto.Text
    '    Registros("Obs") = txtObs.Text
    '    Registros("mail") = txtMail.Text
    '    Registros("Iremito") = cboRemito.Text
    '    Registros("Fax") = txtFax.Text
    '    Registros("NroIB") = txtNroIB.Text
    '    Registros("CondPago") = cboCondPago.Text
    '    Registros("AliDesc") = IIf(txtAliDesc.Text = "", 0, txtAliDesc.Text)
    '    Registros("DiasVto") = IIf(txtDiasVto.Text = "", 0, txtDiasVto.Text)
    '    Registros("LimiteDeCredito") = IIf(txtLimiteDeCredito.Text = "", 0, txtLimiteDeCredito.Text)
    '    Registros("AdvertenciaAproxLimite") = IIf(txtAdvertenciaAproxLimite.Text = "", 0, txtAdvertenciaAproxLimite.Text)
    'End Sub
    'Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
    '    Cambiar(True)

    '    'Por las dudas autocompleto los textbox que llevan numeros
    '    txtDiasVto.Text = IIf(txtDiasVto.Text = "", 0, txtDiasVto.Text)
    '    txtAliDesc.Text = IIf(txtAliDesc.Text = "", 0, txtAliDesc.Text)
    '    txtLimiteDeCredito.Text = IIf(txtLimiteDeCredito.Text = "", 0, txtLimiteDeCredito.Text)
    '    txtAdvertenciaAproxLimite.Text = IIf(txtAdvertenciaAproxLimite.Text = "", 0, txtAdvertenciaAproxLimite.Text)

    '    With dsClientes.Tables("dtClientes")
    '        If Flag = 1 Then
    '            '--------------------  Incrementar numero -------------------------------------
    '            lblCodcli.Text = strZero(IncrementarTablaContador2("Codcli", "contador"), 5)

    '            '--------------------  Actualizo el DataSet -------------------------------------
    '            Registros = .NewRow
    '            CargarRegistro()
    '            .Rows.Add(Registros)

    '            '--------------------  Consulta para Anexar Registro -------------------------------------
    '            vConsulta = "insert into clientes " & _
    '                        "(codcli, razon, direccion, celular, telefono, cp," & _
    '                        "localidad, contacto, obs, Iremito, mail, cuit, " & _
    '                        "TIPOFAC, condpago, condIVA, LimiteDeCredito, AdvertenciaAproxLimite) " & _
    '                        "values ('" & lblCodcli.Text & "','" & txtRazon.Text & "'," & _
    '                        "'" & txtDireccion.Text & "','" & txtCelular.Text & "'," & _
    '                        "'" & txtTelefono.Text & "','" & txtCp.Text & "'," & _
    '                        "'" & txtLocalidad.Text & "'," & _
    '                        "'" & txtContacto.Text & "','" & txtObs.Text & _
    '                        "','" & cboRemito.Text & "','" & txtMail.Text & "','" & _
    '                        txtCuit.Text & "','" & cboTipoFac.Text & "','" & _
    '                        cboCondPago.Text & "','" & cboCondIva.Text & "'," & _
    '                        Replace(txtLimiteDeCredito.Text, ",", ".") & "," & _
    '                        Replace(txtAdvertenciaAproxLimite.Text, ",", ".") & ")"
    '        Else
    '            '--------------------  Actualizo el DataSet -------------------------------------
    '            Registros = .Rows(posicion)
    '            CargarRegistro()

    '            '--------------------  Consulta para Actualizar Registro -------------------------------------
    '            vConsulta = "update clientes set " & _
    '                 "razon    ='" & txtRazon.Text & "'," & _
    '                 "direccion='" & txtDireccion.Text & "'," & _
    '                 "celular ='" & txtCelular.Text & "'," & _
    '                 "telefono ='" & txtTelefono.Text & "'," & _
    '                 "cp       ='" & txtCp.Text & "', " & _
    '                 "Localidad='" & txtLocalidad.Text & "'," & _
    '                 "Contacto ='" & txtContacto.Text & "'," & _
    '                 "obs      ='" & txtObs.Text & "'," & _
    '                 "Iremito  ='" & cboRemito.Text & "'," & _
    '                 "mail='" & txtMail.Text & "'," & _
    '                 "TipoFac='" & cboTipoFac.Text & "'," & _
    '                 "cuit ='" & txtCuit.Text & "'," & _
    '                 "condpago ='" & cboCondPago.Text & "'," & _
    '                 "condiva ='" & cboCondIva.Text & "'," & _
    '                 "LimiteDeCredito=" & Replace(IIf(txtLimiteDeCredito.Text = "", 0, txtLimiteDeCredito.Text), ",", ".") & ", " & _
    '                 "AdvertenciaAproxLimite=" & Replace(IIf(txtAdvertenciaAproxLimite.Text = "", 0, txtAdvertenciaAproxLimite.Text), ",", ".") & " " & _
    '                 "where codcli ='" & lblCodcli.Text & "'"
    '        End If
    '        EjecutarConsulta(vConsulta, miConexion)

    '        If Flag = 1 Then
    '            posicion = .Rows.Count - 1
    '            cargar()
    '        End If

    '    End With
    '    lblModo.Text = "CONSULTA"

    'End Sub
    'Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
    '    Cambiar(True)
    '    lblModo.Text = "CONSULTA"
    '    cargar()
    'End Sub
    'Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If dsClientes.Tables("dtClientes").Rows.Count > 0 Then
    '        If MessageBox.Show("Confirma la baja", "Eliminacion de Registros", MessageBoxButtons.YesNo, _
    '            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then


    '            vConsulta = "delete from clientes where codcli ='" & lblCodcli.Text & "'"
    '            EjecutarConsulta(vConsulta, miConexion)

    '            With dsClientes.Tables("dtClientes")
    '                Dim Registros As DataRow
    '                Registros = .Rows(posicion)
    '                If posicion = .Rows.Count - 1 Then
    '                    Registros.Delete()
    '                    posicion -= 1
    '                Else
    '                    Registros.Delete()
    '                End If
    '                .AcceptChanges()
    '            End With

    '            cargar()
    '        Else
    '            MsgBox("Eliminacion cancelada ...", MsgBoxStyle.Exclamation, "Mensaje")
    '        End If
    '    Else
    '        MessageBox.Show("No hay registros cargado en la tabla....", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End If
    'End Sub
    'Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    frmClientesBuscarPor.ShowDialog()
    '    If criterio <> "" Then
    '        frmClientesBuscar.ShowDialog()
    '        If Flagbuscar = True Then
    '            posicion = dsClientes.Tables("dtClientes").DefaultView.Find(criterio)
    '            If posicion = -1 Then
    '                MessageBox.Show("Registro no encontrado ....", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Else
    '                cargar()
    '            End If
    '        End If
    '    End If
    'End Sub
    'Private Sub txtRazon_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    '         Handles txtRazon.KeyDown, txtDireccion.KeyDown, txtCp.KeyDown, _
    '         txtLocalidad.KeyDown, txtTelefono.KeyDown, txtCelular.KeyDown, txtContacto.KeyDown, _
    '         txtMail.KeyDown, txtObs.KeyDown, txtCuit.KeyDown, txtNroIB.KeyDown, _
    '         cboTipoFac.KeyDown, cboRemito.KeyDown, _
    '         cboCondIva.KeyDown, cboCondPago.KeyDown, txtAliDesc.KeyDown, _
    '         txtDiasVto.KeyDown, txtCelular.KeyDown, txtLimiteDeCredito.KeyDown, _
    '         txtAdvertenciaAproxLimite.KeyDown

    '    If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    'End Sub

    'Private Sub btnHojear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    posActual = posicion
    '    frmClientesHojear.ShowDialog()
    '    If Flagbuscar = True Then
    '        posicion = dsClientes.Tables("dtClientes").DefaultView.Find(criterio)
    '        If posicion = -1 Then
    '            MessageBox.Show("Registro no encontrado ....", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Else
    '            cargar()
    '        End If
    '    End If
    'End Sub

    'Private Sub txtLimiteDeCredito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimiteDeCredito.TextChanged
    '    txtAdvertenciaAproxLimite.Text = Val(txtLimiteDeCredito.Text) * 0.9

    'End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

    End Sub
End Class