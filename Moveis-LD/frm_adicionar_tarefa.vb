﻿Public Class frm_adicionar_tarefa
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs)
        nova_tarefa(txt_ficha_cod.Text, txt_func.Text, txt_data.Text, txt_tipo.Text, txt_realizado.Text)
        preencherGridAgenda()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frm_menu_gerente.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu_gerente.Show()
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles btn_salvar.Click
        nova_tarefa(txt_ficha_cod.Text, txt_func.Text, txt_data.Text, txt_tipo.Text, txt_realizado.Text)
        preencherGridAgenda()
    End Sub
End Class