<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioSesion))
        Me.chkMostrar = New System.Windows.Forms.CheckBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMensajeContraseña = New System.Windows.Forms.Label
        Me.btnOlvideContraseña = New System.Windows.Forms.Button
        Me.btnOlvideUsuario = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chkMostrar
        '
        Me.chkMostrar.AutoSize = True
        Me.chkMostrar.BackColor = System.Drawing.Color.Transparent
        Me.chkMostrar.Location = New System.Drawing.Point(258, 343)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(117, 17)
        Me.chkMostrar.TabIndex = 2
        Me.chkMostrar.Text = "Mostrar contraseña"
        Me.chkMostrar.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.LightBlue
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Enabled = False
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(125, 240)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(381, 31)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(127, 122)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(379, 31)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Blue
        Me.lblNombre.Location = New System.Drawing.Point(121, 154)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(400, 49)
        Me.lblNombre.TabIndex = 199
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 23)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Ingrese contraseña"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 23)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Ingrese su nombre de usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMensajeContraseña
        '
        Me.lblMensajeContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblMensajeContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeContraseña.ForeColor = System.Drawing.Color.Blue
        Me.lblMensajeContraseña.Location = New System.Drawing.Point(121, 274)
        Me.lblMensajeContraseña.Name = "lblMensajeContraseña"
        Me.lblMensajeContraseña.Size = New System.Drawing.Size(400, 49)
        Me.lblMensajeContraseña.TabIndex = 199
        Me.lblMensajeContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOlvideContraseña
        '
        Me.btnOlvideContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOlvideContraseña.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOlvideContraseña.Location = New System.Drawing.Point(342, 450)
        Me.btnOlvideContraseña.Name = "btnOlvideContraseña"
        Me.btnOlvideContraseña.Size = New System.Drawing.Size(114, 24)
        Me.btnOlvideContraseña.TabIndex = 6
        Me.btnOlvideContraseña.Text = "&Contraseña"
        Me.btnOlvideContraseña.UseVisualStyleBackColor = False
        '
        'btnOlvideUsuario
        '
        Me.btnOlvideUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOlvideUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOlvideUsuario.Location = New System.Drawing.Point(226, 450)
        Me.btnOlvideUsuario.Name = "btnOlvideUsuario"
        Me.btnOlvideUsuario.Size = New System.Drawing.Size(110, 24)
        Me.btnOlvideUsuario.TabIndex = 5
        Me.btnOlvideUsuario.Text = "&Usuario"
        Me.btnOlvideUsuario.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 207
        Me.Label4.Text = "Me olvide:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(127, 366)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(189, 68)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "&Ingresar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(322, 366)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(189, 68)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Salir"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(654, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOlvideContraseña)
        Me.Controls.Add(Me.btnOlvideUsuario)
        Me.Controls.Add(Me.chkMostrar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblMensajeContraseña)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Ventas y Control de Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMensajeContraseña As System.Windows.Forms.Label
    Friend WithEvents btnOlvideContraseña As System.Windows.Forms.Button
    Friend WithEvents btnOlvideUsuario As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
