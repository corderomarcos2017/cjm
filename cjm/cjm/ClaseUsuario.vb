Public Class ClaseUsuario

    Private _idUsuario As Integer, _
            _nombreUsuario As String, _
            _idRol As Integer, _
            _ApellidoNombre As String, _
            _Password As String, _
            _Mail As String, _
            _activo As String, _
            _cambiarPassword As String

    Private miTabla As DataTable
    Public Sub New()
        'Me._idUsuario = 0
        'Me._nombreUsuario = ""
        'Me._idRol = 0
        'Me._ApellidoNombre = ""
        'Me._Password = ""
        'Me._Mail = ""
        'Me._activo = "S"
        'Me._cambiarPassword = "N"

        Me.idUsuario = 0
        Me.nombreUsuario = ""
        Me.idRol = 0
        Me.ApellidoNombre = ""
        Me.Password = ""
        Me.Mail = ""
        Me.Activo = "S"
        Me.cambiarPassword = "N"
    End Sub
    Public Sub New(ByVal _idUsuario As Integer, _
                   ByVal _nombreUsuario As String, _
                   ByVal _idRol As Integer, _
                   ByVal _ApellidoNombre As String, _
                   ByVal _password As String, _
                   ByVal _mail As String, _
                   ByVal _activo As String, _
                   ByVal _cambiarPassword As String)

        Me.idUsuario = _idUsuario
        Me.nombreUsuario = _nombreUsuario
        Me.idRol = _idRol
        Me.ApellidoNombre = _ApellidoNombre
        Me.Password = _password
        Me.Mail = _mail
        Me.Activo = _activo
        Me.cambiarPassword = _cambiarPassword

        'Me._idUsuario = _idUsuario
        'Me._nombreUsuario = _nombreUsuario
        'Me._idRol = _idRol
        'Me._ApellidoNombre = _ApellidoNombre
        'Me._Password = _password
        'Me._Mail = _mail
        'Me._activo = _activo
        'Me._cambiarPassword = _cambiarPassword

    End Sub
    Property idUsuario()
        Get
            Return Me._idUsuario
        End Get
        Set(ByVal value)
            Me._idUsuario = value
        End Set
    End Property
    Property nombreUsuario()
        Get
            Return _nombreUsuario
        End Get
        Set(ByVal value)
            _nombreUsuario = value
        End Set
    End Property
    Property idRol()
        Get
            Return Me._idRol
        End Get
        Set(ByVal value)
            Me._idRol = value
        End Set
    End Property
    Property ApellidoNombre()
        Get
            Return Me._ApellidoNombre
        End Get
        Set(ByVal value)
            Me._ApellidoNombre = value
        End Set
    End Property
    Property miPasswordAlmacenada()
        Get
            Return _Password
        End Get
        Set(ByVal value)
            _Password = value
        End Set
    End Property
    Property Password()
        Get
            Return Me._Password
        End Get
        Set(ByVal value)
            Me._Password = value
        End Set
    End Property
    Property Mail()
        Get
            Return Me._Mail
        End Get
        Set(ByVal value)
            Me._Mail = value
        End Set
    End Property
    Property Activo()
        Get
            Return Me._activo
        End Get
        Set(ByVal value)
            Me._activo = value
        End Set
    End Property
    Property cambiarPassword()
        Get
            Return Me._cambiarPassword
        End Get
        Set(ByVal value)
            Me._cambiarPassword = value
        End Set
    End Property
    Public Function traerUsuario(ByVal nombreUsuario As String) As Boolean
        Dim retorno As Boolean
        cargarBase()
        miDataSet.Clear()
        miAdapter = New OleDb.OleDbDataAdapter("select * from usuarios " & _
                    "where nombreusuario='" & nombreUsuario & "'", miConexion)
        miAdapter.Fill(miDataSet, "dtUsuarios")
        miAdapter.Dispose()

        'cargo en contenidio del dataset en un datatable
        miTabla = miDataSet.Tables("dtUsuarios")
        Dim cantidad As Integer = miTabla.Rows.Count()

        If cantidad > 0 Then
            retorno = True
            With miTabla.Rows(0)
                Me.idUsuario = .Item("IdUsuario")
                Me.nombreUsuario = .Item("nombreusuario").ToString
                Me.idRol = .Item("idRoles")
                Me.ApellidoNombre = .Item("ApellidoNombre").ToString()
                Me.Password = .Item("PASSWORD").ToString()
                Me.Mail = .Item("mail").ToString()
                Me.Activo = .Item("Activo").ToString()
                Me.cambiarPassword = .Item("CambiarPassword").ToString()
            End With
        Else
            retorno = False
        End If
        miDataSet.Clear()
        miConexion.Close()

        Return retorno
    End Function
    Public Function Agregar() As Single
        consulta = "INSERT INTO USUARIOS (nombreusuario, " & _
                   "idRoles, ApellidoNombre, Password, mail, Activo, " & _
                   "CambiarPassword ) values (" & _
                   "'" & Me.nombreUsuario & "', " & _
                   " " & Me.idRol & ", " & _
                   "'" & Me.ApellidoNombre & "', " & _
                   "'" & Me.Password & "', " & _
                   "'" & Me.Mail & "', " & _
                   "'S', " & _
                   "'N')"
        Dim resultado As Single = EjecutarMiConsulta(consulta, miConexion)
        Return resultado
    End Function
    Public Function Modificar() As Single
        consulta = "UPDATE [USUARIOS] SET " & _
                   "[nombreusuario] = '" & Me.nombreUsuario & "', " & _
                   "[idRoles] = " & Me.idRol & ", " & _
                   "[ApellidoNombre] = '" & Me.ApellidoNombre & "', " & _
                   "[Password] = '" & Me.Password & "', " & _
                   "[mail] = '" & Me.Mail & "', " & _
                   "[Activo] = '" & Me.Activo & "', " & _
                   "[CambiarPassword] = '" & Me.cambiarPassword & "' " & _
                   "WHERE [IdUsuario]= " & Me.idUsuario
        Dim resultado As Single = EjecutarMiConsulta(consulta, miConexion)
        Return resultado
    End Function
    Public Function Eliminar() As Single
        consulta = "DELETE FROM [USUARIOS] " & _
                   "WHERE [IdUsuario]= " & Me.idUsuario
        Dim resultado As Single = EjecutarMiConsulta(consulta, miConexion)
        Return resultado
    End Function
    Public Function EjecutarMiConsulta(ByVal miConsulta As String, ByVal cnn As OleDb.OleDbConnection)
        'Ejecuta cualquier consulta de Accion
        cnn.Close() : cnn.Open()
        miComandoABM.Connection = cnn
        miComandoABM.CommandType = CommandType.Text
        miComandoABM.CommandTimeout = 0
        miComandoABM.CommandText = consulta
        Dim Ejecutar As Integer = miComandoABM.ExecuteNonQuery
        cnn.Close()

        Return Ejecutar
    End Function
End Class
