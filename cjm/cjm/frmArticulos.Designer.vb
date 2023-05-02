<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblStockActual = New System.Windows.Forms.Label
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.lblModo = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboNivel1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdUltimo = New System.Windows.Forms.Button
        Me.cmdSiguiente = New System.Windows.Forms.Button
        Me.cmdAnterior = New System.Windows.Forms.Button
        Me.cmdPrimero = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboNivel2 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboNivel3 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnEquivalenciasAgregar = New System.Windows.Forms.Button
        Me.btnEquivalenciasModificar = New System.Windows.Forms.Button
        Me.btnEquivalenciasEliminar = New System.Windows.Forms.Button
        Me.GrillaEquivalencia = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Equivalencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPunto = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblUltimaFechaCompra = New System.Windows.Forms.Label
        Me.lblUltimaCostoCompra = New System.Windows.Forms.Label
        Me.lblUltimoDescCompra = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnFiltro = New System.Windows.Forms.Button
        Me.btnHojear = New System.Windows.Forms.Button
        Me.btnReCalcularStock = New System.Windows.Forms.Button
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaEquivalencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(994, 22)
        Me.StatusStrip1.TabIndex = 178
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.lblStockActual)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 494)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 88)
        Me.GroupBox2.TabIndex = 183
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "LightSkyBlue color anterior"
        Me.GroupBox2.Text = " STOCK ACTUAL"
        '
        'lblStockActual
        '
        Me.lblStockActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStockActual.Location = New System.Drawing.Point(6, 38)
        Me.lblStockActual.Name = "lblStockActual"
        Me.lblStockActual.Size = New System.Drawing.Size(175, 30)
        Me.lblStockActual.TabIndex = 168
        Me.lblStockActual.Text = "000000000"
        Me.lblStockActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(13, 12)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(62, 51)
        Me.cmdAgregar.TabIndex = 196
        Me.cmdAgregar.Text = "&Agregar"
        Me.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Image = Global.WindowsApplication1.My.Resources.Resources.livejournal
        Me.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdModificar.Location = New System.Drawing.Point(82, 12)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(62, 51)
        Me.cmdModificar.TabIndex = 197
        Me.cmdModificar.Text = "&Modificar"
        Me.cmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = Global.WindowsApplication1.My.Resources.Resources.recycle_bag
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(150, 12)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(62, 51)
        Me.cmdEliminar.TabIndex = 198
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(246, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(62, 51)
        Me.cmdAceptar.TabIndex = 194
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(314, 12)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(62, 51)
        Me.cmdCancelar.TabIndex = 195
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.WindowsApplication1.My.Resources.Resources.magnifier1
        Me.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBuscar.Location = New System.Drawing.Point(780, 12)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(62, 51)
        Me.cmdBuscar.TabIndex = 199
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.WindowsApplication1.My.Resources.Resources.door_in1
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalir.Location = New System.Drawing.Point(926, 12)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(62, 51)
        Me.cmdSalir.TabIndex = 193
        Me.cmdSalir.Text = "&Volver"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'lblModo
        '
        Me.lblModo.BackColor = System.Drawing.Color.Transparent
        Me.lblModo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModo.ForeColor = System.Drawing.Color.Red
        Me.lblModo.Location = New System.Drawing.Point(557, 134)
        Me.lblModo.Name = "lblModo"
        Me.lblModo.Size = New System.Drawing.Size(389, 25)
        Me.lblModo.TabIndex = 216
        Me.lblModo.Text = "CONSULTA"
        Me.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(556, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(400, 33)
        Me.Label13.TabIndex = 215
        Me.Label13.Text = "MAESTRO DE ARTICULOS"
        '
        'cboNivel1
        '
        Me.cboNivel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNivel1.FormattingEnabled = True
        Me.cboNivel1.Items.AddRange(New Object() {"RI", "RN", "CF", "RM", "EX"})
        Me.cboNivel1.Location = New System.Drawing.Point(9, 233)
        Me.cboNivel1.MaxLength = 100
        Me.cboNivel1.Name = "cboNivel1"
        Me.cboNivel1.Size = New System.Drawing.Size(449, 26)
        Me.cboNivel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Rubro (1er Nivel)"
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Image = Global.WindowsApplication1.My.Resources.Resources.control_end_blue
        Me.cmdUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdUltimo.Location = New System.Drawing.Point(607, 12)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(62, 51)
        Me.cmdUltimo.TabIndex = 213
        Me.cmdUltimo.Text = "&Ultimo"
        Me.cmdUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Image = Global.WindowsApplication1.My.Resources.Resources.control_fastforward_blue
        Me.cmdSiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSiguiente.Location = New System.Drawing.Point(539, 12)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(62, 51)
        Me.cmdSiguiente.TabIndex = 212
        Me.cmdSiguiente.Text = "S&iguiente"
        Me.cmdSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Image = Global.WindowsApplication1.My.Resources.Resources.control_rewind_blue
        Me.cmdAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAnterior.Location = New System.Drawing.Point(471, 12)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(62, 51)
        Me.cmdAnterior.TabIndex = 211
        Me.cmdAnterior.Text = "A&nterior"
        Me.cmdAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdPrimero
        '
        Me.cmdPrimero.Image = Global.WindowsApplication1.My.Resources.Resources.control_start_blue
        Me.cmdPrimero.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrimero.Location = New System.Drawing.Point(403, 12)
        Me.cmdPrimero.Name = "cmdPrimero"
        Me.cmdPrimero.Size = New System.Drawing.Size(62, 51)
        Me.cmdPrimero.TabIndex = 210
        Me.cmdPrimero.Text = "&Primero"
        Me.cmdPrimero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrimero.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Nro de Parte"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(9, 187)
        Me.txtDescripcion.MaxLength = 63
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(450, 25)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(9, 143)
        Me.txtCodigo.MaxLength = 18
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(198, 25)
        Me.txtCodigo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 218
        Me.Label3.Text = "Descripción"
        '
        'cboNivel2
        '
        Me.cboNivel2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNivel2.FormattingEnabled = True
        Me.cboNivel2.Items.AddRange(New Object() {"RI", "RN", "CF", "RM", "EX"})
        Me.cboNivel2.Location = New System.Drawing.Point(9, 281)
        Me.cboNivel2.MaxLength = 100
        Me.cboNivel2.Name = "cboNivel2"
        Me.cboNivel2.Size = New System.Drawing.Size(449, 26)
        Me.cboNivel2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 16)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Marca (2er Nivel)"
        '
        'cboNivel3
        '
        Me.cboNivel3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNivel3.FormattingEnabled = True
        Me.cboNivel3.Items.AddRange(New Object() {"RI", "RN", "CF", "RM", "EX"})
        Me.cboNivel3.Location = New System.Drawing.Point(9, 328)
        Me.cboNivel3.MaxLength = 100
        Me.cboNivel3.Name = "cboNivel3"
        Me.cboNivel3.Size = New System.Drawing.Size(449, 26)
        Me.cboNivel3.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "Fabrica (3er Nivel)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnEquivalenciasAgregar)
        Me.GroupBox1.Controls.Add(Me.btnEquivalenciasModificar)
        Me.GroupBox1.Controls.Add(Me.btnEquivalenciasEliminar)
        Me.GroupBox1.Controls.Add(Me.GrillaEquivalencia)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(538, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 253)
        Me.GroupBox1.TabIndex = 223
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga de Equivalencias"
        '
        'btnEquivalenciasAgregar
        '
        Me.btnEquivalenciasAgregar.Image = Global.WindowsApplication1.My.Resources.Resources.Agregar
        Me.btnEquivalenciasAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEquivalenciasAgregar.Location = New System.Drawing.Point(378, 19)
        Me.btnEquivalenciasAgregar.Name = "btnEquivalenciasAgregar"
        Me.btnEquivalenciasAgregar.Size = New System.Drawing.Size(64, 51)
        Me.btnEquivalenciasAgregar.TabIndex = 207
        Me.btnEquivalenciasAgregar.Text = "&Agregar"
        Me.btnEquivalenciasAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEquivalenciasAgregar.UseVisualStyleBackColor = True
        '
        'btnEquivalenciasModificar
        '
        Me.btnEquivalenciasModificar.Image = Global.WindowsApplication1.My.Resources.Resources.Modificar1
        Me.btnEquivalenciasModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEquivalenciasModificar.Location = New System.Drawing.Point(378, 76)
        Me.btnEquivalenciasModificar.Name = "btnEquivalenciasModificar"
        Me.btnEquivalenciasModificar.Size = New System.Drawing.Size(64, 51)
        Me.btnEquivalenciasModificar.TabIndex = 208
        Me.btnEquivalenciasModificar.Text = "&Modificar"
        Me.btnEquivalenciasModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEquivalenciasModificar.UseVisualStyleBackColor = True
        '
        'btnEquivalenciasEliminar
        '
        Me.btnEquivalenciasEliminar.Image = Global.WindowsApplication1.My.Resources.Resources.ELIMINAR
        Me.btnEquivalenciasEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEquivalenciasEliminar.Location = New System.Drawing.Point(378, 138)
        Me.btnEquivalenciasEliminar.Name = "btnEquivalenciasEliminar"
        Me.btnEquivalenciasEliminar.Size = New System.Drawing.Size(64, 51)
        Me.btnEquivalenciasEliminar.TabIndex = 209
        Me.btnEquivalenciasEliminar.Text = "&Eliminar"
        Me.btnEquivalenciasEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEquivalenciasEliminar.UseVisualStyleBackColor = True
        '
        'GrillaEquivalencia
        '
        Me.GrillaEquivalencia.AllowUserToAddRows = False
        Me.GrillaEquivalencia.AllowUserToDeleteRows = False
        Me.GrillaEquivalencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaEquivalencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Equivalencia})
        Me.GrillaEquivalencia.Location = New System.Drawing.Point(6, 19)
        Me.GrillaEquivalencia.Name = "GrillaEquivalencia"
        Me.GrillaEquivalencia.ReadOnly = True
        Me.GrillaEquivalencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaEquivalencia.Size = New System.Drawing.Size(366, 215)
        Me.GrillaEquivalencia.TabIndex = 206
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codart"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Equivalencia
        '
        Me.Equivalencia.DataPropertyName = "Equivalencia"
        Me.Equivalencia.HeaderText = "Equivalencia"
        Me.Equivalencia.Name = "Equivalencia"
        Me.Equivalencia.ReadOnly = True
        Me.Equivalencia.Width = 300
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(0, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1024, 3)
        Me.Label10.TabIndex = 224
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 16)
        Me.Label11.TabIndex = 226
        Me.Label11.Text = "Punto de Pedido"
        '
        'txtPunto
        '
        Me.txtPunto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPunto.Location = New System.Drawing.Point(9, 378)
        Me.txtPunto.MaxLength = 4
        Me.txtPunto.Name = "txtPunto"
        Me.txtPunto.Size = New System.Drawing.Size(121, 25)
        Me.txtPunto.TabIndex = 6
        Me.txtPunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 16)
        Me.Label16.TabIndex = 228
        Me.Label16.Text = "Ultima Compra"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(140, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 16)
        Me.Label17.TabIndex = 230
        Me.Label17.Text = "Precio Costo"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUltimaFechaCompra
        '
        Me.lblUltimaFechaCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblUltimaFechaCompra.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaFechaCompra.ForeColor = System.Drawing.Color.Blue
        Me.lblUltimaFechaCompra.Location = New System.Drawing.Point(10, 35)
        Me.lblUltimaFechaCompra.Name = "lblUltimaFechaCompra"
        Me.lblUltimaFechaCompra.Size = New System.Drawing.Size(110, 23)
        Me.lblUltimaFechaCompra.TabIndex = 231
        Me.lblUltimaFechaCompra.Text = "00/00/0000"
        Me.lblUltimaFechaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUltimaCostoCompra
        '
        Me.lblUltimaCostoCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblUltimaCostoCompra.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaCostoCompra.ForeColor = System.Drawing.Color.Blue
        Me.lblUltimaCostoCompra.Location = New System.Drawing.Point(140, 33)
        Me.lblUltimaCostoCompra.Name = "lblUltimaCostoCompra"
        Me.lblUltimaCostoCompra.Size = New System.Drawing.Size(107, 23)
        Me.lblUltimaCostoCompra.TabIndex = 232
        Me.lblUltimaCostoCompra.Text = "00,000,000.00"
        Me.lblUltimaCostoCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUltimoDescCompra
        '
        Me.lblUltimoDescCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblUltimoDescCompra.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimoDescCompra.ForeColor = System.Drawing.Color.Blue
        Me.lblUltimoDescCompra.Location = New System.Drawing.Point(253, 33)
        Me.lblUltimoDescCompra.Name = "lblUltimoDescCompra"
        Me.lblUltimoDescCompra.Size = New System.Drawing.Size(107, 23)
        Me.lblUltimoDescCompra.TabIndex = 234
        Me.lblUltimoDescCompra.Text = "00,00"
        Me.lblUltimoDescCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(253, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(107, 16)
        Me.Label22.TabIndex = 233
        Me.Label22.Text = "Ultimo Desc %"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox3.Controls.Add(Me.lblUltimaFechaCompra)
        Me.GroupBox3.Controls.Add(Me.lblUltimoDescCompra)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lblUltimaCostoCompra)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 420)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 68)
        Me.GroupBox3.TabIndex = 235
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "   Datos de la ultima Compra   "
        '
        'btnFiltro
        '
        Me.btnFiltro.Image = Global.WindowsApplication1.My.Resources.Resources._476
        Me.btnFiltro.Location = New System.Drawing.Point(848, 12)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(62, 51)
        Me.btnFiltro.TabIndex = 199
        Me.btnFiltro.Text = "&Filtro"
        Me.btnFiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFiltro.UseVisualStyleBackColor = True
        '
        'btnHojear
        '
        Me.btnHojear.Image = Global.WindowsApplication1.My.Resources.Resources.doc
        Me.btnHojear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHojear.Location = New System.Drawing.Point(683, 12)
        Me.btnHojear.Name = "btnHojear"
        Me.btnHojear.Size = New System.Drawing.Size(62, 51)
        Me.btnHojear.TabIndex = 199
        Me.btnHojear.Text = "&Hojear"
        Me.btnHojear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHojear.UseVisualStyleBackColor = True
        '
        'btnReCalcularStock
        '
        Me.btnReCalcularStock.Image = Global.WindowsApplication1.My.Resources.Resources.CALCULA
        Me.btnReCalcularStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReCalcularStock.Location = New System.Drawing.Point(213, 511)
        Me.btnReCalcularStock.Name = "btnReCalcularStock"
        Me.btnReCalcularStock.Size = New System.Drawing.Size(84, 71)
        Me.btnReCalcularStock.TabIndex = 236
        Me.btnReCalcularStock.Text = "&Re Calcular Stock"
        Me.btnReCalcularStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReCalcularStock.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(303, 526)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(578, 36)
        Me.lblMensaje.TabIndex = 237
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Fondo_0074
        Me.ClientSize = New System.Drawing.Size(994, 662)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnReCalcularStock)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtPunto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboNivel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboNivel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblModo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboNivel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdPrimero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.btnFiltro)
        Me.Controls.Add(Me.btnHojear)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Articulos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GrillaEquivalencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStockActual As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents lblModo As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboNivel1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdUltimo As System.Windows.Forms.Button
    Friend WithEvents cmdSiguiente As System.Windows.Forms.Button
    Friend WithEvents cmdAnterior As System.Windows.Forms.Button
    Friend WithEvents cmdPrimero As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboNivel2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboNivel3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEquivalenciasAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEquivalenciasModificar As System.Windows.Forms.Button
    Friend WithEvents btnEquivalenciasEliminar As System.Windows.Forms.Button
    Friend WithEvents GrillaEquivalencia As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPunto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblUltimaFechaCompra As System.Windows.Forms.Label
    Friend WithEvents lblUltimaCostoCompra As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Equivalencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblUltimoDescCompra As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltro As System.Windows.Forms.Button
    Friend WithEvents btnHojear As System.Windows.Forms.Button
    Friend WithEvents btnReCalcularStock As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
