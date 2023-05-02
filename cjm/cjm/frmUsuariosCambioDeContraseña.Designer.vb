<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuariosCambioDeContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuariosCambioDeContraseña))
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkMostrar = New System.Windows.Forms.CheckBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.txtPasswordNueva = New System.Windows.Forms.TextBox
        Me.txtPasswordActual = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMensajeContraseña = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPasswordRepitala = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIOS - Cambio de contraseña"
        '
        'chkMostrar
        '
        Me.chkMostrar.AutoSize = True
        Me.chkMostrar.BackColor = System.Drawing.Color.Transparent
        Me.chkMostrar.Location = New System.Drawing.Point(268, 416)
        Me.chkMostrar.Name = "chkMostrar"
        Me.chkMostrar.Size = New System.Drawing.Size(117, 17)
        Me.chkMostrar.TabIndex = 3
        Me.chkMostrar.Text = "Mostrar contraseña"
        Me.chkMostrar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(125, 439)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(189, 68)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "&Ingresar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(320, 439)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(189, 68)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'txtPasswordNueva
        '
        Me.txtPasswordNueva.BackColor = System.Drawing.Color.White
        Me.txtPasswordNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordNueva.Location = New System.Drawing.Point(125, 240)
        Me.txtPasswordNueva.Name = "txtPasswordNueva"
        Me.txtPasswordNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordNueva.Size = New System.Drawing.Size(381, 31)
        Me.txtPasswordNueva.TabIndex = 1
        Me.txtPasswordNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPasswordActual
        '
        Me.txtPasswordActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordActual.Location = New System.Drawing.Point(125, 169)
        Me.txtPasswordActual.Name = "txtPasswordActual"
        Me.txtPasswordActual.Size = New System.Drawing.Size(381, 31)
        Me.txtPasswordActual.TabIndex = 0
        Me.txtPasswordActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Blue
        Me.lblNombre.Location = New System.Drawing.Point(125, 93)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(381, 31)
        Me.lblNombre.TabIndex = 199
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 31)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Ingrese la nueva contraseña"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 31)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Nombre de usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMensajeContraseña
        '
        Me.lblMensajeContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblMensajeContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeContraseña.ForeColor = System.Drawing.Color.Blue
        Me.lblMensajeContraseña.Location = New System.Drawing.Point(121, 364)
        Me.lblMensajeContraseña.Name = "lblMensajeContraseña"
        Me.lblMensajeContraseña.Size = New System.Drawing.Size(400, 49)
        Me.lblMensajeContraseña.TabIndex = 199
        Me.lblMensajeContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(381, 31)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Ingrese la contraseña actual"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(381, 31)
        Me.Label4.TabIndex = 202
        Me.Label4.Text = "Repitala"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPasswordRepitala
        '
        Me.txtPasswordRepitala.BackColor = System.Drawing.Color.White
        Me.txtPasswordRepitala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordRepitala.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordRepitala.Location = New System.Drawing.Point(125, 304)
        Me.txtPasswordRepitala.Name = "txtPasswordRepitala"
        Me.txtPasswordRepitala.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordRepitala.Size = New System.Drawing.Size(381, 31)
        Me.txtPasswordRepitala.TabIndex = 2
        Me.txtPasswordRepitala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmUsuariosCambioDeContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(654, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkMostrar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtPasswordRepitala)
        Me.Controls.Add(Me.txtPasswordNueva)
        Me.Controls.Add(Me.txtPasswordActual)
        Me.Controls.Add(Me.lblMensajeContraseña)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUsuariosCambioDeContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Ventas y Control de Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkMostrar As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents txtPasswordNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordActual As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMensajeContraseña As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordRepitala As System.Windows.Forms.TextBox
End Class
