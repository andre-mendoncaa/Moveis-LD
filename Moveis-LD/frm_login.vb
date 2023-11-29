Imports System.Data.SQLite
Imports System.Drawing.Text

Public Class frm_login
    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        Dim cpf = txt_cpf.Text
        Dim senha = txt_senha.Text
        logar(cpf, senha)
    End Sub

End Class