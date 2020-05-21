Public Class FrmPrincipal
    Private Sub LaborToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaborToolStripMenuItem.Click
        Dim frm As New FrmLabor
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class