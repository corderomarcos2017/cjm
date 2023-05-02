<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.text1 = New System.Windows.Forms.TextBox
        Me.grilla = New System.Windows.Forms.DataGridView
        Me.codcli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoFac = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.condIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.radRazon = New System.Windows.Forms.RadioButton
        Me.radCocli = New System.Windows.Forms.RadioButton
        Me.filtro = New System.Windows.Forms.GroupBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'text1
        '
        Me.text1.Location = New System.Drawing.Point(80, 295)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(301, 20)
        Me.text1.TabIndex = 9
        Me.text1.Text = "."
        Me.text1.Visible = False
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codcli, Me.Razon, Me.cuit, Me.TipoFac, Me.condIVA, Me.Remito, Me.Direccion, Me.Localidad, Me.cp, Me.provincia, Me.Telefono, Me.Celular})
        Me.grilla.Location = New System.Drawing.Point(0, 85)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.RowHeadersVisible = False
        Me.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla.Size = New System.Drawing.Size(1263, 584)
        Me.grilla.TabIndex = 10
        '
        'codcli
        '
        Me.codcli.DataPropertyName = "codcli"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.codcli.DefaultCellStyle = DataGridViewCellStyle1
        Me.codcli.HeaderText = "Codigo de Cliente"
        Me.codcli.Name = "codcli"
        Me.codcli.ReadOnly = True
        Me.codcli.Width = 50
        '
        'Razon
        '
        Me.Razon.DataPropertyName = "razon"
        Me.Razon.HeaderText = "Razon Social"
        Me.Razon.Name = "Razon"
        Me.Razon.ReadOnly = True
        Me.Razon.Width = 230
        '
        'cuit
        '
        Me.cuit.DataPropertyName = "cuit"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cuit.DefaultCellStyle = DataGridViewCellStyle2
        Me.cuit.HeaderText = "C.U.I.T."
        Me.cuit.Name = "cuit"
        Me.cuit.ReadOnly = True
        Me.cuit.Width = 80
        '
        'TipoFac
        '
        Me.TipoFac.DataPropertyName = "tipofac"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoFac.DefaultCellStyle = DataGridViewCellStyle3
        Me.TipoFac.HeaderText = "Tipo Fac"
        Me.TipoFac.Name = "TipoFac"
        Me.TipoFac.ReadOnly = True
        Me.TipoFac.Width = 40
        '
        'condIVA
        '
        Me.condIVA.DataPropertyName = "condIVA"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.condIVA.DefaultCellStyle = DataGridViewCellStyle4
        Me.condIVA.HeaderText = "IVA"
        Me.condIVA.Name = "condIVA"
        Me.condIVA.ReadOnly = True
        Me.condIVA.Width = 40
        '
        'Remito
        '
        Me.Remito.DataPropertyName = "remito"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Remito.DefaultCellStyle = DataGridViewCellStyle5
        Me.Remito.HeaderText = "Remito"
        Me.Remito.Name = "Remito"
        Me.Remito.ReadOnly = True
        Me.Remito.Width = 45
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "direccion"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Direccion.DefaultCellStyle = DataGridViewCellStyle6
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 150
        '
        'Localidad
        '
        Me.Localidad.DataPropertyName = "localidad"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Localidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'cp
        '
        Me.cp.DataPropertyName = "cp"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cp.DefaultCellStyle = DataGridViewCellStyle8
        Me.cp.HeaderText = "C.P."
        Me.cp.Name = "cp"
        Me.cp.ReadOnly = True
        Me.cp.Width = 40
        '
        'provincia
        '
        Me.provincia.DataPropertyName = "provincia"
        Me.provincia.HeaderText = "Provincia"
        Me.provincia.Name = "provincia"
        Me.provincia.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Celular
        '
        Me.Celular.DataPropertyName = "Celular"
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        '
        'radRazon
        '
        Me.radRazon.AutoSize = True
        Me.radRazon.Checked = True
        Me.radRazon.Location = New System.Drawing.Point(6, 19)
        Me.radRazon.Name = "radRazon"
        Me.radRazon.Size = New System.Drawing.Size(88, 17)
        Me.radRazon.TabIndex = 100
        Me.radRazon.TabStop = True
        Me.radRazon.Text = "Razon Social"
        Me.radRazon.UseVisualStyleBackColor = True
        '
        'radCocli
        '
        Me.radCocli.AutoSize = True
        Me.radCocli.Location = New System.Drawing.Point(135, 19)
        Me.radCocli.Name = "radCocli"
        Me.radCocli.Size = New System.Drawing.Size(58, 17)
        Me.radCocli.TabIndex = 100
        Me.radCocli.Text = "Codigo"
        Me.radCocli.UseVisualStyleBackColor = True
        '
        'filtro
        '
        Me.filtro.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.filtro.Controls.Add(Me.radRazon)
        Me.filtro.Controls.Add(Me.radCocli)
        Me.filtro.Location = New System.Drawing.Point(226, 12)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(238, 51)
        Me.filtro.TabIndex = 101
        Me.filtro.TabStop = False
        Me.filtro.Text = "Filtrado por?"
        '
        'btnAgregar
        '

        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(12, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(62, 51)
        Me.btnAgregar.TabIndex = 109
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '

        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(81, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(62, 51)
        Me.btnModificar.TabIndex = 110
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(149, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(62, 51)
        Me.btnEliminar.TabIndex = 111
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(1190, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(62, 51)
        Me.btnSalir.TabIndex = 112
        Me.btnSalir.Text = "&Volver"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.filtro)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.grilla)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Clientes"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filtro.ResumeLayout(False)
        Me.filtro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents text1 As System.Windows.Forms.TextBox
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents radRazon As System.Windows.Forms.RadioButton
    Friend WithEvents radCocli As System.Windows.Forms.RadioButton
    Friend WithEvents filtro As System.Windows.Forms.GroupBox
    Friend WithEvents codcli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoFac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents condIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
