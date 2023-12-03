Public Class frm_adicionar_ficha
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        novaFicha(txt_nome.Text, txt_endereco.Text, txt_contato.Text, txt_objeto.Text, txt_total.Text)
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu_funcionario.Show()
    End Sub
End Class