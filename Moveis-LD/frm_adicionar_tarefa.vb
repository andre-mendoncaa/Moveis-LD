Public Class frm_adicionar_tarefa
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        nova_tarefa(txt_ficha_cod.Text, txt_func.Text, txt_data.Text, txt_tipo.Text, txt_realizado.Text)
    End Sub
End Class