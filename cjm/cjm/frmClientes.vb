Public Class frmClientes

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        text1.Text = criterio
    End Sub
    Private Sub grilla_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grilla.DoubleClick
        Criterio = grilla.CurrentRow.Cells.Item("CodCli").Value
    End Sub
    Private Sub grilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grilla.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : grilla_DoubleClick(sender, e)
            Case Keys.Escape : Me.Close()
            Case 65 To 90 : text1.Text = text1.Text + Chr(e.KeyCode) 'A hasta Z
            Case 48 To 57 : text1.Text = text1.Text + Chr(e.KeyCode) '0 hasta 9 del teclado alfanumerico
            Case 96 To 105 : text1.Text = text1.Text + Chr(e.KeyCode - 48) '0 hasta 9 del teclado numerico
            Case 32 : text1.Text = text1.Text & " "
            Case 190 : text1.Text = text1.Text & "."
            Case 188 : text1.Text = text1.Text & ","
            Case 109 : text1.Text = text1.Text & "-"
            Case 111 : text1.Text = text1.Text & "/"
            Case 8
                If text1.Text <> "" Then
                    text1.Text = Microsoft.VisualBasic.Left(text1.Text, Len(text1.Text) - 1)
                Else
                    text1.Text = ""
                End If
        End Select
    End Sub
    Private Sub Text1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text1.TextChanged
        consulta = "select * from clientes "

        Select Case Campo
            Case "codcli"
                If text1.Text <> "" Then
                    consulta += "where codcli like '%" & text1.Text & "%' order by codcli"
                Else
                    consulta += "order by codcli"
                End If
            Case "razon"
                If text1.Text <> "" Then
                    consulta += "where razon like '" & text1.Text & "%' order by razon"
                Else
                    consulta += "order by razon"
                End If
        End Select
        miAdapter = New OleDb.OleDbDataAdapter(consulta, miConexion)
        filtro.Text = "Filtrado por? " & campo & " -->" & text1.Text

        miDataSetAux.Clear()
        miAdapter.Fill(miDataSetAux, "btClientesAux")
        grilla.DataSource = miDataSetAux
        grilla.DataMember = "btClientesAux"
        grilla.Focus()
    End Sub
    Private Sub radRazon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRazon.CheckedChanged
        campo = "razon"
        limpiar(sender, e)
    End Sub
    Private Sub radCocli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCocli.CheckedChanged
        campo = "codcli"
        limpiar(sender, e)
    End Sub
    Private Sub limpiar(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If criterio = "" Then
            text1.Text = criterio
            Text1_TextChanged(sender, e)
        Else
            text1.Text = criterio
            criterio = ""
        End If
        grilla.Focus()
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmClientesAMC.ShowDialog()

    End Sub

End Class