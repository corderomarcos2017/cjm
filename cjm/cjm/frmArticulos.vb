Public Class frmArticulos
    Private miTabla As DataTable, posicion As Single = 0, Registros As DataRow, posEqui As Single

    Private Sub frmArticulos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'frmArticulosCalcularStockActual.ShowDialog()
        Cambiar(True)
        conectar("")
        cargar()
        'grilla_Click(sender, e)
    End Sub
    Private Sub conectar(ByVal condicion As String)
        miConexion.Close() : miConexion.Open()
        miDataSet.Clear()

        miAdapter = New OleDb.OleDbDataAdapter("select * from Articulos " & condicion & " order by codart", miConexion)
        miAdapter.Fill(miDataSet, "dtArticulos")
        miAdapter.Dispose()

        'cargo en contenidio del dataset en un datatable
        miTabla = miDataSet.Tables("dtArticulos")
        miTabla.DefaultView.Sort = "Codart asc"


        'cierro la conexion
        miConexion.Close()
        posicion = 0
    End Sub
    Private Sub iniciar()
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        cboNivel1.Text = ""
        cboNivel2.Text = ""
        cboNivel3.Text = ""
        txtPunto.Text = ""
    End Sub
    Private Sub cargar()
        If miTabla.Rows.Count > 0 Then
            With miTabla.Rows(posicion)
                txtCodigo.Text = .Item("codart").ToString
                txtDescripcion.Text = IIf(IsDBNull(.Item("Descripcion").ToString), "", .Item("Descripcion").ToString)
                cboNivel1.Text = IIf(IsDBNull(.Item("Nivel1").ToString), 0, .Item("Nivel1").ToString)
                cboNivel2.Text = IIf(IsDBNull(.Item("Nivel2").ToString), 0, .Item("Nivel2").ToString)
                cboNivel3.Text = IIf(IsDBNull(.Item("Nivel3").ToString), 0, .Item("Nivel3").ToString)
                txtPunto.Text = IIf(IsDBNull(.Item("Punto").ToString), 0, .Item("Punto").ToString)

                lblStockActual.Text = IIf(IsDBNull(.Item("stockactual").ToString), 0, .Item("stockactual").ToString)

                lblUltimaFechaCompra.Text = IIf(IsDBNull(.Item("FechaUltimaCompra").ToString), "00/00/0000", .Item("FechaUltimaCompra").ToString)
                lblUltimaCostoCompra.Text = Format(IIf(IsDBNull(.Item("PrecioCosto").ToString), 0, .Item("PrecioCosto").ToString), "Standard")
                lblUltimoDescCompra.Text = Format(IIf(IsDBNull(.Item("UltimoDesc").ToString), 0, .Item("UltimoDesc").ToString), "Standard") & "%"


                'lblTCompras.Text = IIf(IsDBNull(.Item("Tcompras").ToString), 0, .Item("TCompras").ToString)
                'lblTComprasB.Text = IIf(IsDBNull(.Item("TcomprasB").ToString), 0, .Item("TComprasB").ToString)
                'lblTComprasN.Text = IIf(IsDBNull(.Item("TcomprasN").ToString), 0, .Item("TComprasN").ToString)

                'lblTVentas.Text = IIf(IsDBNull(.Item("TVentas").ToString), 0, .Item("TVentas").ToString)
                'lblTVentasB.Text = IIf(IsDBNull(.Item("TVentasB").ToString), 0, .Item("TVentasB").ToString)
                'lblTVentasN.Text = IIf(IsDBNull(.Item("TVentasN").ToString), 0, .Item("TVentasN").ToString)
                cargarEquivalencia()
            End With
        Else
            iniciar()
        End If
    End Sub
    Private Sub cargarEquivalencia()
        miConexion.Close() : miConexion.Open()
        midatasetAuxEqui.Clear()
        miAdapter = New OleDb.OleDbDataAdapter("SELECT * FROM ArticulosEquivalencias " & _
                                               "where codart= '" & txtCodigo.Text & "'", miConexion)
        miAdapter.Fill(midatasetAuxEqui, "dtArticulosAuxEqui")
        miAdapter.Dispose()
        GrillaEquivalencia.DataSource = midatasetAuxEqui
        GrillaEquivalencia.DataMember = "dtArticulosAuxEqui"

    End Sub
    Private Sub Cambiar(ByVal Cambio As Boolean)
        cmdAgregar.Enabled = Cambio
        cmdEliminar.Enabled = Cambio
        cmdModificar.Enabled = Cambio
        cmdSalir.Enabled = Cambio
        cmdBuscar.Enabled = Cambio
        cmdPrimero.Enabled = Cambio
        cmdAnterior.Enabled = Cambio
        cmdSiguiente.Enabled = Cambio
        cmdUltimo.Enabled = Cambio
        btnEquivalenciasAgregar.Enabled = Cambio
        btnEquivalenciasEliminar.Enabled = Cambio
        btnEquivalenciasModificar.Enabled = Cambio


        txtCodigo.Enabled = Not Cambio
        txtDescripcion.Enabled = Not Cambio
        cboNivel1.Enabled = Not Cambio
        cboNivel2.Enabled = Not Cambio
        cboNivel3.Enabled = Not Cambio
        txtPunto.Enabled = Not Cambio



        cmdAceptar.Enabled = Not Cambio
        cmdCancelar.Enabled = Not Cambio
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        frmArticulosNuevo.ShowDialog()

        Cambiar(False)

        CargarCombo("Nivel1", cboNivel1, "Articulos")
        CargarCombo("Nivel2", cboNivel2, "Articulos")
        CargarCombo("Nivel3", cboNivel3, "Articulos")

        Flag = 1
        iniciar()
        If vNuevo = 2 Then 'es copia
            If miTabla.Rows.Count > 0 Then
                With miTabla.Rows(posicion)

                    txtDescripcion.Text = IIf(IsDBNull(.Item("Descripcion").ToString), "", .Item("Descripcion").ToString)
                    cboNivel1.Text = IIf(IsDBNull(.Item("Nivel1").ToString), 0, .Item("Nivel1").ToString)
                    cboNivel2.Text = IIf(IsDBNull(.Item("Nivel2").ToString), 0, .Item("Nivel2").ToString)
                    cboNivel3.Text = IIf(IsDBNull(.Item("Nivel3").ToString), 0, .Item("Nivel3").ToString)
                End With
            End If
        End If

        txtCodigo.Focus()
    End Sub

    Private Sub txtSaltos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
                Handles txtCodigo.KeyDown, txtDescripcion.KeyDown, cboNivel1.KeyDown, _
                cboNivel2.KeyDown, cboNivel3.KeyDown, txtPunto.KeyDown
        saltar(e.KeyCode)

    End Sub
    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If Flag = 1 Then
            Dim busqueda As Single = 0
            busqueda = miTabla.DefaultView.Find(txtCodigo.Text)
            If busqueda >= 1 Then
                MessageBox.Show("El Nro de Parte : " & txtCodigo.Text & " ya fue cargada...", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodigo.Text = ""
                txtCodigo.Focus()
            End If
        End If
    End Sub
    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If miTabla.Rows.Count > 0 Then

            CargarCombo("Nivel1", cboNivel1, "Articulos")
            CargarCombo("Nivel2", cboNivel2, "Articulos")
            CargarCombo("Nivel3", cboNivel3, "Articulos")
            Cambiar(False)
            Flag = 2
            txtDescripcion.Focus()
        Else
            MessageBox.Show("No hay registros cargado en la tabla....", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub cargarRegistro()
        Registros("codart") = txtCodigo.Text
        Registros("Descripcion") = txtDescripcion.Text
        Registros("nivel1") = cboNivel1.Text
        Registros("nivel2") = cboNivel2.Text
        Registros("nivel3") = cboNivel3.Text
        Registros("punto") = IIf(txtPunto.Text = "", 0, txtPunto.Text)
        Registros("stockactual") = 0
        Registros("sb") = 0
        Registros("sn") = 0
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtCodigo.Text = "" Then
            MessageBox.Show("No puede seguir sin cargar el nro de parte...", "Error de Entrada..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Cambiar(True)

        miComandoABM.Connection = miConexion
        miComandoABM.CommandType = CommandType.Text
        If Flag = 1 Then

            Registros = miTabla.NewRow
            cargarRegistro()
            miDataSet.Tables("dtArticulos").Rows.Add(Registros)

            miComandoABM.CommandText = "INSERT INTO Articulos ( CodArt, Descripcion, " & _
                                       "Nivel1, Nivel2, Nivel3, PrecioCosto, " & _
                                       "punto, stockInicial, stockActual, SB, SN ) values (" & _
                                       "'" & txtCodigo.Text & "','" & txtDescripcion.Text & "'," & _
                                       "'" & cboNivel1.Text & "','" & cboNivel2.Text & "'," & _
                                       "'" & cboNivel3.Text & "', 0," & _
                                       IIf(txtPunto.Text = "", 0, txtPunto.Text) & ",0,0,0,0)"
        Else
            Registros = miTabla.Rows(posicion)
            cargarRegistro()

            miComandoABM.CommandText = "update articulos set " & _
                                         "Descripcion='" & txtDescripcion.Text & "'," & _
                                         "Nivel1  = '" & cboNivel1.Text & "'," & _
                                         "Nivel2  = '" & cboNivel2.Text & "'," & _
                                         "Nivel3  = '" & cboNivel3.Text & "'," & _
                                         "punto = " & Replace(IIf(txtPunto.Text = "", 0, txtPunto.Text), ",", ".") & " " & _
                                         "where CodArt ='" & txtCodigo.Text & "'"
        End If
        miConexion.Close()
        miConexion.Open()
        Ejecutar = miComandoABM.ExecuteNonQuery
        miConexion.Close()

        If Flag = 1 Then
            posicion = miTabla.Rows.Count - 1
            cargar()
        End If
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cambiar(True)
        If Flag = 1 Then
            cargar()
        End If
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If miTabla.Rows.Count > 0 Then
            If SiHayDatosParaMostrar("stock", " where codart = '" & txtCodigo.Text & "'", miConexion) = 1 Then
                MessageBox.Show("No se puede eliminar el articulo nro.: " & txtCodigo.Text & vbCrLf & vbCrLf & _
                                "Este articulo tiene movimientos de stock asociados ...", "Alerta: baja rechazada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            Else
                If MessageBox.Show("Confirma la baja", "Eliminacion de Registros", MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    miConexion.Close()
                    miConexion.Open()
                    miComandoABM.Connection = miConexion
                    miComandoABM.CommandType = CommandType.Text
                    miComandoABM.CommandText = "delete from articulos " & _
                                               "where codart ='" & txtCodigo.Text & "'"
                    Ejecutar = miComandoABM.ExecuteNonQuery
                    miConexion.Close()

                    Dim Registros As DataRow
                    Registros = miTabla.Rows(posicion)
                    If posicion = miTabla.Rows.Count - 1 Then
                        Registros.Delete()
                        posicion -= 1
                    Else
                        Registros.Delete()
                    End If
                    miDataSet.Tables("dtArticulos").AcceptChanges()
                    cargar()

                Else
                    MsgBox("Eliminacion cancelada ...", MsgBoxStyle.Exclamation, "Mensaje")
                End If

            End If
        Else
            MessageBox.Show("No hay registros cargado en la tabla....", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        'Criterio = InputBox("Ingrese Codigo de Articulo o Descripción", "Buscar...")
        'Criterio = Trim(Criterio)


        frmArticulosBuscarPor.ShowDialog()
        If Criterio <> "" Then
            'Application.DoEvents()
            'If IsNumeric(Criterio) Then
            '    Campo = "CodArt"
            'Else
            '    Criterio = UCase(Criterio)
            '    Campo = "Descripcion"
            'End If

            frmArticulosBuscar.ShowDialog()
            If Flagbuscar = True Then
                posicion = miTabla.DefaultView.Find(Criterio)
                If posicion = -1 Then
                    MessageBox.Show("Registro no encontrado ....", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    cargar()
                End If
            End If
        End If
    End Sub
    Private Sub btDesplazar(ByVal sender As System.Object, ByVal e As System.EventArgs) _
              Handles cmdPrimero.Click, cmdSiguiente.Click, cmdAnterior.Click, cmdUltimo.Click

        Dim opcion As Button = sender
        With miTabla.Rows
            Select Case opcion.Name
                Case "cmdPrimero" : posicion = 0
                Case "cmdAnterior" : If posicion = 0 Then posicion = .Count - 1 Else posicion -= 1
                Case "cmdSiguiente" : If posicion = .Count - 1 Then posicion = 0 Else posicion += 1
                Case "cmdUltimo" : posicion = .Count - 1
            End Select
        End With
        cargar()
    End Sub
    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub btnEquivalenciasAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquivalenciasAgregar.Click
        FlagEquivalencias = 1
        ArtCodigo = txtCodigo.Text

        frmArticulosEquivalencia.ShowDialog()


        If FlagEquivalencias <> 3 Then 'distinto de cancelar
            cargarEquivalencia()
        End If
    End Sub

    Private Sub btnEquivalenciasModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquivalenciasModificar.Click
        FlagEquivalencias = 2
        ArtCodigo = GrillaEquivalencia.CurrentRow.Cells.Item("CODIGO").Value 'Envio el codigo
        artEquivalencia = GrillaEquivalencia.CurrentRow.Cells.Item("equivalencia").Value 'envio equivalencia
        posEqui = GrillaEquivalencia.SelectedRows(0).Index 'POSICION EN LA GRILLA

        frmArticulosEquivalencia.ShowDialog() 'LLAMAR AL FOMULARIO DE CARGA Y MODIFICACION


        If FlagEquivalencias <> 3 Then 'distinto de cancelar
            cargarEquivalencia()
            GrillaEquivalencia.CurrentCell = GrillaEquivalencia.Rows(posEqui).Cells(1) 'Ir a la poscion donde estaba
        End If


    End Sub

    Private Sub btnEquivalenciasEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquivalenciasEliminar.Click
        artEquivalencia = GrillaEquivalencia.CurrentRow.Cells.Item("equivalencia").Value 'envio equivalencia

        If miTabla.Rows.Count > 0 Then
            If MessageBox.Show("Confirma la baja de la Equivalencia : " & artEquivalencia, "Eliminacion de Registros", MessageBoxButtons.YesNo, _
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                miConexion.Close()
                miConexion.Open()
                miComandoABM.Connection = miConexion
                miComandoABM.CommandType = CommandType.Text
                miComandoABM.CommandText = "delete FROM ArticulosEquivalencias " & _
                                                 "where Codart ='" & txtCodigo.Text & "' " & _
                                                 "and equivalencia ='" & artEquivalencia & "'"

                miConexion.Close() : miConexion.Open()
                Ejecutar = miComandoABM.ExecuteNonQuery
                miConexion.Close()


                cargarEquivalencia()

            Else
                MsgBox("Eliminacion cancelada ...", MsgBoxStyle.Exclamation, "Mensaje")
            End If
        Else
            MessageBox.Show("No hay registros cargado en la tabla....", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub
    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        frmArticulosFiltrar.ShowDialog()
        If vFiltro = True Then
            conectar(CriterioFiltrado)
            cargar()
            If CriterioFiltrado = "" Then
                Me.Text = "Maestro de Articulos"
            Else
                CriterioFiltrado = Mid(CriterioFiltrado, 6, Len(CriterioFiltrado) - 5)
                Me.Text = "Maestro de Articulos -     Filtrado por: " & CriterioFiltrado
            End If
        Else
            Me.Text = "Maestro de Articulos "
        End If
    End Sub
    Private Sub btnHojear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHojear.Click
        posActual = posicion
        frmArticulosHojear.ShowDialog()
        If Flagbuscar = True Then
            posicion = miTabla.DefaultView.Find(Criterio)
            If posicion = -1 Then
                MessageBox.Show("Registro no encontrado ....", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                cargar()
            End If
        End If

    End Sub
    Private Sub btnReCalcularStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReCalcularStock.Click
        vCodigo = txtCodigo.Text
        lblMensaje.Text = "Calculando stock actual... ESPERE UN MOMENTO!!!"
        Application.DoEvents()
        EjecutarConsulta("update articulos set stockActual = " & _
                         calcularStockDeUnArticulo(vCodigo, "") & _
                         " where codart = '" & vCodigo & "'", miConexion)
        lblMensaje.Text = ""

    End Sub
End Class