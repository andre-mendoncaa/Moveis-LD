Imports Org.BouncyCastle.Crypto.Engines

Public Class frm_menu_funcionario
    Private Sub frm_menu_funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preencherGridAfazeres()
        preencherGridConcluidos()
    End Sub

    Private Sub AfazeresDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AfazeresDataGrid.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim value As String = AfazeresDataGrid.Rows(e.RowIndex).Cells(1).Value.ToString()
            ' Cria uma nova instância do formulário secundário
            Dim form2 As New frm_agenda_mais(value)

            ' Exibe o formulário secundário como um diálogo modal
            Me.Close()
            form2.Show()
        End If
    End Sub

    Private Sub ConcluidosDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ConcluidosDataGrid.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim value As String = ConcluidosDataGrid.Rows(e.RowIndex).Cells(1).Value.ToString()
            ' Cria uma nova instância do formulário secundário
            Dim form2 As New frm_agenda_mais(value)

            ' Exibe o formulário secundário como um diálogo modal
            Me.Close()
            form2.Show()
        End If
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
        frm_login.Show()
        cpfLogado = Nothing
        funcionarioLogado = Nothing
    End Sub

    Private Sub AlterarSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarSenhaToolStripMenuItem.Click
        Me.Hide()
        frm_alterar_senha.Show()
    End Sub
End Class