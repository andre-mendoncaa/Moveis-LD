Imports System.Data.SQLite

Public Class frm_menu_gerente
    Private Sub frm_menu_gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preencherGridConcluidosGerente()
        preencherGridFichas()
        preencherGridAgenda()
    End Sub

    Private Sub btn_nova_ficha_Click(sender As Object, e As EventArgs) Handles btn_nova_ficha.Click
        Me.Close()
        frm_adicionar_ficha.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
        frm_login.Show()
        cpfLogado = Nothing
        funcionarioLogado = Nothing
    End Sub

    Private Sub btn_nova_tarefa_Click(sender As Object, e As EventArgs) Handles btn_nova_tarefa.Click
        Me.Close()
        frm_adicionar_tarefa.Show()
    End Sub

    Private Sub FichasDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles FichasDataGrid.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Dim value As String = FichasDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString()
            ' Cria uma nova instância do formulário secundário
            mostrar_ficha(value)
        End If
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        Dim cod = lbl_cod.Text
        Dim nome = txt_nome.Text
        Dim objeto = txt_objeto.Text
        Dim endereco = txt_endereco.Text
        Dim telefone = txt_telefone.Text
        Dim total = txt_total.Text
        alterar_ficha(cod, nome, objeto, endereco, telefone, total)
        preencherGridFichas()
    End Sub

    Private Sub GerenciarContaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarContaeToolStripMenuItem.Click
        Me.Close()
        frm_cadastro_funcionarios.Show()
    End Sub

    Private Sub ConcluidoDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ConcluidoDataGrid.CellDoubleClick
        If e.ColumnIndex = 1 Then
            Dim value As String = ConcluidoDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString()
            marcar_nao_concluido(value)
            preencherGridConcluidosGerente()
            preencherGridAgenda()
        End If
    End Sub

    Private Sub AgendaDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles AgendaDataGrid.CellDoubleClick
        If e.ColumnIndex = 1 Then
            Dim value As String = AgendaDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString()
            marcar_concluido(value)
            preencherGridConcluidosGerente()
            preencherGridAgenda()
        ElseIf e.ColumnIndex = 2 Then
            Dim value As String = AgendaDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim alterarTarefa As New frm_alterar_tarefa()

            alterarTarefa.CarregarDados(value)
            alterarTarefa.Show()
        End If
    End Sub


End Class