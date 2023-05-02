<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesAMC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientesAMC))
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtContacto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLocalidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCp = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtRazon = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtObs = New System.Windows.Forms.TextBox
        Me.lblCodcli = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCuit = New System.Windows.Forms.MaskedTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboRemito = New System.Windows.Forms.ComboBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboTipoFac = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.lblModo = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDiasVto = New System.Windows.Forms.TextBox
        Me.txtAliDesc = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCondPago = New System.Windows.Forms.ComboBox
        Me.cboCondIva = New System.Windows.Forms.ComboBox
        Me.txtNroIB = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtCelular = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtLimiteDeCredito = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtAdvertenciaAproxLimite = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 18)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Contacto"
        '
        'txtContacto
        '
        Me.txtContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Location = New System.Drawing.Point(9, 295)
        Me.txtContacto.MaxLength = 20
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(263, 24)
        Me.txtContacto.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(562, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Localidad"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.Location = New System.Drawing.Point(565, 171)
        Me.txtLocalidad.MaxLength = 20
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(302, 24)
        Me.txtLocalidad.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(463, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "C.P."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Razon Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Codigo de cliente"
        '
        'txtCp
        '
        Me.txtCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCp.Location = New System.Drawing.Point(457, 171)
        Me.txtCp.MaxLength = 8
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(102, 24)
        Me.txtCp.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(9, 171)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(442, 24)
        Me.txtDireccion.TabIndex = 1
        '
        'txtRazon
        '
        Me.txtRazon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazon.Location = New System.Drawing.Point(205, 113)
        Me.txtRazon.MaxLength = 60
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(442, 24)
        Me.txtRazon.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(9, 234)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(442, 24)
        Me.txtTelefono.TabIndex = 4
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(9, 359)
        Me.txtObs.MaxLength = 100
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(621, 24)
        Me.txtObs.TabIndex = 9
        '
        'lblCodcli
        '
        Me.lblCodcli.BackColor = System.Drawing.Color.Transparent
        Me.lblCodcli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodcli.ForeColor = System.Drawing.Color.Blue
        Me.lblCodcli.Location = New System.Drawing.Point(12, 113)
        Me.lblCodcli.Name = "lblCodcli"
        Me.lblCodcli.Size = New System.Drawing.Size(187, 28)
        Me.lblCodcli.TabIndex = 117
        Me.lblCodcli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 18)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Observaciones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 18)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Mail"
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(285, 295)
        Me.txtMail.MaxLength = 50
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(345, 24)
        Me.txtMail.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 397)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "C.U.I.T."
        '
        'txtCuit
        '
        Me.txtCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtCuit.Location = New System.Drawing.Point(9, 420)
        Me.txtCuit.Mask = "##-########-#"
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(142, 24)
        Me.txtCuit.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(602, 394)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 18)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Imprimir Remito"
        '
        'cboRemito
        '
        Me.cboRemito.BackColor = System.Drawing.SystemColors.Window
        Me.cboRemito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRemito.FormattingEnabled = True
        Me.cboRemito.Items.AddRange(New Object() {"N", "S"})
        Me.cboRemito.Location = New System.Drawing.Point(642, 418)
        Me.cboRemito.Name = "cboRemito"
        Me.cboRemito.Size = New System.Drawing.Size(65, 26)
        Me.cboRemito.TabIndex = 13
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 650)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(994, 22)
        Me.StatusStrip1.TabIndex = 129
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(737, 394)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 18)
        Me.Label14.TabIndex = 120
        Me.Label14.Text = "Tipo de Factura"
        '
        'cboTipoFac
        '
        Me.cboTipoFac.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoFac.FormattingEnabled = True
        Me.cboTipoFac.Items.AddRange(New Object() {"X", "A", "B"})
        Me.cboTipoFac.Location = New System.Drawing.Point(767, 418)
        Me.cboTipoFac.Name = "cboTipoFac"
        Me.cboTipoFac.Size = New System.Drawing.Size(65, 26)
        Me.cboTipoFac.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(395, 396)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 18)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Condición IVA"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(0, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1000, 3)
        Me.Label15.TabIndex = 236
        Me.Label15.Text = "Label15"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(920, 207)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(62, 51)
        Me.cmdAceptar.TabIndex = 30
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(920, 308)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(62, 51)
        Me.cmdCancelar.TabIndex = 31
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'lblModo
        '
        Me.lblModo.BackColor = System.Drawing.Color.Transparent
        Me.lblModo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModo.ForeColor = System.Drawing.Color.Red
        Me.lblModo.Location = New System.Drawing.Point(575, 47)
        Me.lblModo.Name = "lblModo"
        Me.lblModo.Size = New System.Drawing.Size(365, 25)
        Me.lblModo.TabIndex = 238
        Me.lblModo.Text = "CONSULTA"
        Me.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(573, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(374, 33)
        Me.Label16.TabIndex = 237
        Me.Label16.Text = "MAESTRO DE CLIENTES"
        '
        'txtDiasVto
        '
        Me.txtDiasVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasVto.Location = New System.Drawing.Point(336, 479)
        Me.txtDiasVto.MaxLength = 100
        Me.txtDiasVto.Name = "txtDiasVto"
        Me.txtDiasVto.Size = New System.Drawing.Size(56, 24)
        Me.txtDiasVto.TabIndex = 17
        Me.txtDiasVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAliDesc
        '
        Me.txtAliDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliDesc.Location = New System.Drawing.Point(223, 479)
        Me.txtAliDesc.MaxLength = 100
        Me.txtAliDesc.Name = "txtAliDesc"
        Me.txtAliDesc.Size = New System.Drawing.Size(56, 24)
        Me.txtAliDesc.TabIndex = 16
        Me.txtAliDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(333, 458)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 266
        Me.Label19.Text = "Dias Vto"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(285, 482)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 18)
        Me.Label18.TabIndex = 265
        Me.Label18.Text = "%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(220, 458)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 18)
        Me.Label17.TabIndex = 267
        Me.Label17.Text = "Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 18)
        Me.Label5.TabIndex = 264
        Me.Label5.Text = "Condición Pago"
        '
        'cboCondPago
        '
        Me.cboCondPago.BackColor = System.Drawing.SystemColors.Window
        Me.cboCondPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCondPago.FormattingEnabled = True
        Me.cboCondPago.Items.AddRange(New Object() {"Contado", "Cuenta Corriente"})
        Me.cboCondPago.Location = New System.Drawing.Point(9, 477)
        Me.cboCondPago.MaxLength = 16
        Me.cboCondPago.Name = "cboCondPago"
        Me.cboCondPago.Size = New System.Drawing.Size(203, 26)
        Me.cboCondPago.TabIndex = 15
        '
        'cboCondIva
        '
        Me.cboCondIva.BackColor = System.Drawing.SystemColors.Window
        Me.cboCondIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCondIva.FormattingEnabled = True
        Me.cboCondIva.Items.AddRange(New Object() {"Responsable Insc.", "Responsable No Insc.", "Consumidor Final", "Excento"})
        Me.cboCondIva.Location = New System.Drawing.Point(387, 418)
        Me.cboCondIva.Name = "cboCondIva"
        Me.cboCondIva.Size = New System.Drawing.Size(203, 26)
        Me.cboCondIva.TabIndex = 12
        '
        'txtNroIB
        '
        Me.txtNroIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroIB.Location = New System.Drawing.Point(154, 420)
        Me.txtNroIB.MaxLength = 100
        Me.txtNroIB.Name = "txtNroIB"
        Me.txtNroIB.Size = New System.Drawing.Size(217, 24)
        Me.txtNroIB.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(160, 399)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 18)
        Me.Label21.TabIndex = 270
        Me.Label21.Text = "Nro Ing.Brutos"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(454, 234)
        Me.txtCelular.MaxLength = 50
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(414, 24)
        Me.txtCelular.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(454, 213)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 18)
        Me.Label22.TabIndex = 114
        Me.Label22.Text = "Celular"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(434, 458)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 18)
        Me.Label23.TabIndex = 266
        Me.Label23.Text = "Limite de Credito"
        '
        'txtLimiteDeCredito
        '
        Me.txtLimiteDeCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimiteDeCredito.Location = New System.Drawing.Point(431, 477)
        Me.txtLimiteDeCredito.MaxLength = 100
        Me.txtLimiteDeCredito.Name = "txtLimiteDeCredito"
        Me.txtLimiteDeCredito.Size = New System.Drawing.Size(139, 24)
        Me.txtLimiteDeCredito.TabIndex = 18
        Me.txtLimiteDeCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(589, 458)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(225, 18)
        Me.Label24.TabIndex = 266
        Me.Label24.Text = "Advertencia de Aproximación"
        '
        'txtAdvertenciaAproxLimite
        '
        Me.txtAdvertenciaAproxLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvertenciaAproxLimite.Location = New System.Drawing.Point(642, 476)
        Me.txtAdvertenciaAproxLimite.MaxLength = 100
        Me.txtAdvertenciaAproxLimite.Name = "txtAdvertenciaAproxLimite"
        Me.txtAdvertenciaAproxLimite.Size = New System.Drawing.Size(139, 24)
        Me.txtAdvertenciaAproxLimite.TabIndex = 19
        Me.txtAdvertenciaAproxLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmClientesAMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(994, 672)
        Me.Controls.Add(Me.txtNroIB)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cboCondIva)
        Me.Controls.Add(Me.txtAdvertenciaAproxLimite)
        Me.Controls.Add(Me.txtLimiteDeCredito)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtDiasVto)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtAliDesc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCondPago)
        Me.Controls.Add(Me.lblModo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboRemito)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboTipoFac)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblCodcli)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtRazon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmClientesAMC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCp As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtRazon As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents lblCodcli As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboRemito As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboTipoFac As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblModo As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDiasVto As System.Windows.Forms.TextBox
    Friend WithEvents txtAliDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCondPago As System.Windows.Forms.ComboBox
    Friend WithEvents cboCondIva As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroIB As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtLimiteDeCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAdvertenciaAproxLimite As System.Windows.Forms.TextBox
End Class
