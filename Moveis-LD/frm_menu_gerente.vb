Public Class frm_menu_gerente
    Private Sub frm_menu_gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preencherGridConcluidosGerente()
    End Sub

    Private Sub btn_nova_ficha_Click(sender As Object, e As EventArgs) Handles btn_nova_ficha.Click
        Me.Hide()
        frm_adicionar_ficha.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
        frm_login.Show()
        cpfLogado = Nothing
        funcionarioLogado = Nothing
    End Sub
End Class