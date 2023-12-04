Imports Org.BouncyCastle.Crypto.Engines

Public Class frm_menu_funcionario
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub btn_alterar_senha_Click(sender As Object, e As EventArgs) Handles btn_alterar_senha.Click
        Me.Close()
        frm_alterar_senha.Show()
    End Sub

    Private Sub frm_menu_funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = funcionarioLogado
        preencherGridAfazeres()
        preencherGridConcluidos()
    End Sub

    Private Sub AfazeresDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles AfazeresDataGrid.CellDoubleClick
        connection.Open()
        If e.ColumnIndex = 1 Then
            Dim value As String = AfazeresDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString()
            marcar_concluido(value)
            preencherGridConcluidos()
            preencherGridAfazeres()
        ElseIf e.ColumnIndex = 2 Then
            Dim value As String = AfazeresDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim agendaMais As New frm_agenda_mais()

            agendaMais.CarregarDados(value)
            agendaMais.Show()
        End If
        connection.Close()
    End Sub

    Private Sub ConcluidosDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ConcluidosDataGrid.CellDoubleClick
        connection.Open()
        If e.ColumnIndex = 1 Then
            Dim value As String = ConcluidosDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString()
            marcar_nao_concluido(value)
            preencherGridConcluidos()
            preencherGridAfazeres()
        End If
        connection.Close()
    End Sub
End Class