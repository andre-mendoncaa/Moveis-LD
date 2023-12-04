﻿Public Class frm_cadastro_funcionarios
    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Dim cpf, nome, senha, acesso, status As String
        cpf = txt_cpf.Text
        nome = txt_nome.Text
        senha = txt_senha.Text
        acesso = cmb_acesso.Text
        status = cmb_status.Text
        cadastrar(cpf, nome, senha, acesso, status)
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Dim cpf As String
        cpf = txt_cpf.Text
        procurar_usuario(cpf)
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs)
        Dim cpf As String
        cpf = txt_cpf.Text
        excluir_cadastro(cpf)
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        Dim cpf, nome, senha, acesso, status As String
        cpf = txt_cpf.Text
        nome = txt_nome.Text
        senha = txt_senha.Text
        acesso = cmb_acesso.Text
        status = cmb_status.Text
        atualizar_cadastro(cpf, nome, senha, acesso, status)
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu_gerente.Show()
    End Sub
End Class