Public Class FrmMain
    Private Sub LiênHệToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiênHệToolStripMenuItem.Click
        FrmGioiThieu.Show()
    End Sub

    Private Sub CậpNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậpToolStripMenuItem.Click
        FrmCapNhatSP.Show()
    End Sub

    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CậpNhậtKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtKHToolStripMenuItem.Click
        FrmCapNhatKH.Show()
    End Sub

    Private Sub XemKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemKHToolStripMenuItem.Click
        FrmXemKH.Show()
    End Sub

    Private Sub XemSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSPToolStripMenuItem.Click
        FrmXemSP.Show()

    End Sub

    Private Sub QuayLạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuayLạiToolStripMenuItem.Click
        FrmDangNhap.Show()
        Me.Hide()
    End Sub
End Class