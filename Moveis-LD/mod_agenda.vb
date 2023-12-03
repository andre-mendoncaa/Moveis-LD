Imports System.Data.SQLite
Imports ns1
Imports ZstdSharp.Unsafe

Module mod_agenda

    Sub preencherGridAfazeres()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, data, tipo FROM tb_agenda WHERE funcionario = @funcionario_logado AND realizado='N'"
        Dim SQLiteAdapter As New SQLiteDataAdapter
        command = New SQLiteCommand(commandText, connection)
        command.Parameters.AddWithValue("@funcionario_logado", funcionarioLogado)
        SQLiteAdapter.SelectCommand = command
        SQLiteAdapter.Fill(dt)
        frm_menu_funcionario.AfazeresDataGrid.DataSource = dt
        frm_menu_funcionario.AfazeresDataGrid.Columns("cod").Visible = False
    End Sub

    Sub preencherGridConcluidos()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, data, tipo FROM tb_agenda WHERE funcionario = @funcionario_logado AND realizado='S'"
        Dim SQLiteAdapter As New SQLiteDataAdapter
        command = New SQLiteCommand(commandText, connection)
        command.Parameters.AddWithValue("@funcionario_logado", funcionarioLogado)
        SQLiteAdapter.SelectCommand = command
        SQLiteAdapter.Fill(dt)
        frm_menu_funcionario.ConcluidosDataGrid.DataSource = dt
        'frm_menu_funcionario.ConcluidosDataGrid.Columns("cod").Visible = False
    End Sub

    Sub preencherGridConcluidosGerente()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT tb_agenda.cod, tb_agenda.funcionario, tb_agenda.data, tb_agenda.tipo, tb_fichas.nome, tb_fichas.endereco, tb_fichas.objeto 
                                    FROM tb_agenda INNER JOIN tb_fichas ON tb_agenda.ficha_cod = tb_fichas.cod"
        Dim SQLiteAdapter As New SQLiteDataAdapter
        command = New SQLiteCommand(commandText, connection)
        SQLiteAdapter.SelectCommand = command
        SQLiteAdapter.Fill(dt)
        frm_menu_gerente.ConcluidoDataGrid.DataSource = dt
        frm_menu_gerente.ConcluidoDataGrid.Columns("cod").Visible = False
    End Sub

    Sub marcar_concluido(cod)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "UPDATE tb_agenda SET realizado = 'S' WHERE cod = @cod"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@cod", cod)
                        command.ExecuteNonQuery()
                        MsgBox("Tarefa marcada como concluída.")
                    End Using
                End If
            Catch ex As SQLiteException
                MsgBox("Erro de SQLite: " & ex.Message)
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
            End Try
        End Using
    End Sub

    Sub marcar_nao_concluido(cod)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "UPDATE tb_agenda SET realizado = 'N' WHERE cod = @cod"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@cod", cod)
                        command.ExecuteNonQuery()
                        MsgBox("Tarefa marcada como não concluída.")
                    End Using
                End If
            Catch ex As SQLiteException
                MsgBox("Erro de SQLite: " & ex.Message)
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
            End Try
        End Using
    End Sub
End Module