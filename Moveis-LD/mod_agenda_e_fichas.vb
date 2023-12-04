Imports System.Data.SQLite
Imports ns1
Imports ZstdSharp.Unsafe

Module mod_agenda_e_fichas

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
        frm_menu_funcionario.ConcluidosDataGrid.Columns("cod").Visible = False
    End Sub

    Sub preencherGridConcluidosGerente()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, funcionario, data, tipo FROM tb_agenda WHERE realizado='S'"
        Dim SQLiteAdapter As New SQLiteDataAdapter

        ' Limpa as colunas existentes no Bunifu DataGridView
        frm_menu_gerente.ConcluidoDataGrid.Columns.Clear()

        ' Adiciona manualmente as colunas desejadas ao Bunifu DataGridView
        Dim colFuncionario As New DataGridViewTextBoxColumn()
        colFuncionario.HeaderText = "Funcionário"
        colFuncionario.DataPropertyName = "funcionario" ' Nome da coluna no banco de dados
        frm_menu_gerente.ConcluidoDataGrid.Columns.Add(colFuncionario)

        Dim colData As New DataGridViewTextBoxColumn()
        colData.HeaderText = "Data"
        colData.DataPropertyName = "data" ' Nome da coluna no banco de dados
        frm_menu_gerente.ConcluidoDataGrid.Columns.Add(colData)

        Dim colTipo As New DataGridViewTextBoxColumn()
        colTipo.HeaderText = "Tipo"
        colTipo.DataPropertyName = "tipo" ' Nome da coluna no banco de dados
        frm_menu_gerente.ConcluidoDataGrid.Columns.Add(colTipo)

        ' Preenche os dados no DataTable
        command = New SQLiteCommand(commandText, connection)
        SQLiteAdapter.SelectCommand = command

        Try
            SQLiteAdapter.Fill(dt)

            ' Associa o DataTable ao DataSource do Bunifu DataGridView
            frm_menu_gerente.ConcluidoDataGrid.DataSource = dt
        Catch ex As Exception
            ' Trate exceções, se necessário
            MsgBox("Erro ao preencher o grid: " & ex.Message)
        End Try

        ' Esconde a coluna "cod" no Bunifu DataGridView
        frm_menu_gerente.ConcluidoDataGrid.Columns("cod").Visible = False
    End Sub


    Sub preencherGridAgenda()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, funcionario, data, tipo, ficha_cod FROM tb_agenda WHERE realizado='N'"
        Dim SQLiteAdapter As New SQLiteDataAdapter
        command = New SQLiteCommand(commandText, connection)
        SQLiteAdapter.SelectCommand = command
        SQLiteAdapter.Fill(dt)
        frm_menu_gerente.AgendaDataGrid.DataSource = dt
        frm_menu_gerente.AgendaDataGrid.Columns("cod").Visible = False
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

    Sub nova_tarefa(ficha_cod, func, data, tipo, realizado)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "INSERT INTO tb_agenda(ficha_cod, funcionario, data, tipo, realizado) VALUES (@ficha_cod, @func, @data, @tipo, @realizado)"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@ficha_cod", ficha_cod)
                            command.Parameters.AddWithValue("@func", func)
                            command.Parameters.AddWithValue("@data", data)
                            command.Parameters.AddWithValue("@tipo", tipo)
                            command.Parameters.AddWithValue("@realizado", realizado)
                            command.ExecuteNonQuery()
                        End Using
                        MsgBox("Tarefa adicionada com sucesso!")
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox("Erro: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub nova_ficha(nome, endereco, contato, objeto, total)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "INSERT INTO tb_fichas(nome, endereco, contato, objeto, total) VALUES (@nome, @endereco, @contato, @objeto, @total)"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@nome", nome)
                            command.Parameters.AddWithValue("@endereco", endereco)
                            command.Parameters.AddWithValue("@contato", contato)
                            command.Parameters.AddWithValue("@objeto", objeto)
                            command.Parameters.AddWithValue("@total", total)
                            command.ExecuteNonQuery()
                        End Using
                        MsgBox("Ficha adicionada com sucesso!")
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox("Erro: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Sub preencherGridFichas()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, nome, endereco FROM tb_fichas"
        Dim SQLiteAdapter As New SQLiteDataAdapter

        frm_menu_gerente.FichasDataGrid.Columns.Clear()

        Dim colCodigo As New DataGridViewTextBoxColumn()
        colCodigo.HeaderText = "Código"
        colCodigo.DataPropertyName = "cod"
        frm_menu_gerente.FichasDataGrid.Columns.Add(colCodigo)

        Dim colNome As New DataGridViewTextBoxColumn()
        colNome.HeaderText = "Nome"
        colNome.DataPropertyName = "nome"
        frm_menu_gerente.FichasDataGrid.Columns.Add(colNome)

        Dim colEndereco As New DataGridViewTextBoxColumn()
        colEndereco.HeaderText = "Endereço"
        colEndereco.DataPropertyName = "endereco"
        frm_menu_gerente.FichasDataGrid.Columns.Add(colEndereco)

        command = New SQLiteCommand(commandText, connection)
        SQLiteAdapter.SelectCommand = command

        Try
            SQLiteAdapter.Fill(dt)
            frm_menu_gerente.FichasDataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox("Erro ao preencher o grid: " & ex.Message)
        End Try
    End Sub



    Sub mostrar_ficha(cod)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "SELECT * FROM tb_fichas WHERE cod=@cod"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cod", cod)

                            Using reader As SQLiteDataReader = command.ExecuteReader()
                                If reader.HasRows Then
                                    reader.Read()
                                    With frm_menu_gerente
                                        .lbl_cod.Text = reader.GetInt16(0)
                                        .txt_nome.Text = reader.GetString(1)
                                        .txt_endereco.Text = reader.GetString(2)
                                        .txt_telefone.Text = reader.GetString(3)
                                        .txt_objeto.Text = reader.GetString(4)
                                        .txt_total.Text = reader.GetFloat(5)
                                    End With
                                End If
                            End Using
                        End Using
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox("Erro: " & ex.Message)
                End Try
            End Using
            connection.Close()
        End Using
    End Sub

    Sub alterar_ficha(cod, nome, objeto, endereco, telefone, total)
        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "UPDATE tb_fichas SET nome = @nome, objeto = @objeto, endereco = @endereco, contato = @telefone WHERE cod = @cod"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cod", cod)
                            command.Parameters.AddWithValue("@nome", nome)
                            command.Parameters.AddWithValue("@objeto", objeto)
                            command.Parameters.AddWithValue("@endereco", endereco)
                            command.Parameters.AddWithValue("@telefone", telefone)
                            command.Parameters.AddWithValue("@total", total)
                            command.ExecuteNonQuery()
                        End Using
                        MsgBox("Ficha alterada com sucesso!")
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox("Erro: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Module