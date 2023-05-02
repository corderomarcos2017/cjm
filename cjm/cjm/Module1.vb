Module Module1
    Public miConexion As New OleDb.OleDbConnection, _
           miAdapter As OleDb.OleDbDataAdapter, _
           miComandoABM As New OleDb.OleDbCommand, _
           miDataSet As New DataSet, miDataSetAux As New DataSet

    Public criterio As String, consulta As String, campo As String

    Public miUsuario As New ClaseUsuario 'Instancia de la clase usuario

    Public nombre As String, usuario As String, _
           password As String, cambiarPassword As String


    Public Sub cargarBase()
        miConexion.Close()
        'miConexion.ConnectionString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & CurDir() & "\sistema.mdb"
        miConexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & CurDir() & "\sistema.mdb"
        miConexion.Open()
    End Sub
    Public Sub EjecutarConsulta(ByVal miConsulta As String, ByVal cnn As OleDb.OleDbConnection)
        'Ejecuta cualquier consulta de Accion
        cnn.Close() : cnn.Open()
        miComandoABM.Connection = cnn
        miComandoABM.CommandType = CommandType.Text
        miComandoABM.CommandTimeout = 0
        miComandoABM.CommandText = miConsulta
        Dim Ejecutar As Integer = miComandoABM.ExecuteNonQuery
        cnn.Close()
    End Sub
    Public Sub saltar(ByVal UltimaTecla As Single)
        If UltimaTecla = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Public Function strZero(ByVal valorA As Object, ByVal ancho As Byte) As String
        strZero = Trim(Str(Val(valorA)))
        strZero = StrDup(ancho - Len(strZero), "0") & strZero
    End Function
End Module
