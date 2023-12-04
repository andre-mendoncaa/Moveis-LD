Public Class frm_adicionar_ficha
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs)
        nova_ficha(txt_nome.Text, txt_endereco.Text, txt_contato.Text, txt_objeto.Text, txt_total.Text)
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frm_menu_gerente.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu_gerente.Show()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        nova_ficha(txt_nome.Text, txt_endereco.Text, txt_contato.Text, txt_objeto.Text, txt_total.Text)
    End Sub
End Class