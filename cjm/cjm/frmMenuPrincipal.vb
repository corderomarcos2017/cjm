Public Class frmMenuPrincipal

    Private Sub MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarBase()

 
    End Sub
 
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub MaestroDeClientesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaestroDeClientesToolStripMenuItem.Click
        campo = "razon"
        frmClientes.MdiParent = Me
        frmClientes.WindowState = FormWindowState.Maximized
        frmClientes.Show()
    End Sub
End Class
