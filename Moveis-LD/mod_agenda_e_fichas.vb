﻿Imports System.Data.SQLite
Imports ns1
Imports ZstdSharp.Unsafe

Module mod_agenda_e_fichas

    Sub preencherGridAfazeres()
        connection.Close()
        connection.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, data, tipo FROM tb_agenda WHERE funcionario = @funcionario_logado AND realizado='N'"
        Dim SQLiteAdapter As New SQLiteDataAdapter

        frm_menu_funcionario.AfazeresDataGrid.Columns.Clear()

        Dim colConcluido As New DataGridViewImageColumn()
        colConcluido.HeaderText = "Concluído"
        'colConcluido.Image = My.Resources.IconeConcluido ' Substitua My.Resources.IconeConcluido pelo recurso de imagem correto
        colConcluido.ImageLayout = DataGridViewImageCellLayout.Zoom
        colConcluido.ToolTipText = "Marcar como Concluído"
        frm_menu_funcionario.AfazeresDataGrid.Columns.Add(colConcluido)

        Dim colAlterar As New DataGridViewImageColumn()
        colAlterar.HeaderText = "Alterar"
        'colAlterar.Image = My.Resources.IconeAlterar ' Substitua My.Resources.IconeAlterar pelo recurso de imagem correto
        colAlterar.ImageLayout = DataGridViewImageCellLayout.Zoom
        colAlterar.ToolTipText = "Alterar"
        frm_menu_funcionario.AfazeresDataGrid.Columns.Add(colAlterar)

        Dim colData As New DataGridViewTextBoxColumn()
        colData.HeaderText = "Data"
        colData.DataPropertyName = "data"
        frm_menu_funcionario.AfazeresDataGrid.Columns.Add(colData)

        Dim colTipo As New DataGridViewTextBoxColumn()
        colTipo.HeaderText = "Tipo"
        colTipo.DataPropertyName = "tipo"
        frm_menu_funcionario.AfazeresDataGrid.Columns.Add(colTipo)

        command = New SQLiteCommand(commandText, connection)
        command.Parameters.AddWithValue("@funcionario_logado", funcionarioLogado)
        SQLiteAdapter.SelectCommand = command

        Try
            SQLiteAdapter.Fill(dt)

            frm_menu_funcionario.AfazeresDataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox("Erro ao preencher o grid: " & ex.Message)
        End Try

        frm_menu_funcionario.AfazeresDataGrid.Columns("cod").Visible = False
        connection.Close()
    End Sub



    Sub preencherGridConcluidos()
        connection.Close()
        connection.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, data, tipo FROM tb_agenda WHERE funcionario = @funcionario_logado AND realizado='S'"
        Dim SQLiteAdapter As New SQLiteDataAdapter

        frm_menu_funcionario.ConcluidosDataGrid.Columns.Clear()

        Dim colData As New DataGridViewTextBoxColumn()
        colData.HeaderText = "Data"
        colData.DataPropertyName = "data"
        frm_menu_funcionario.ConcluidosDataGrid.Columns.Add(colData)

        Dim colTipo As New DataGridViewTextBoxColumn()
        colTipo.HeaderText = "Tipo"
        colTipo.DataPropertyName = "tipo"
        frm_menu_funcionario.ConcluidosDataGrid.Columns.Add(colTipo)

        command = New SQLiteCommand(commandText, connection)
        command.Parameters.AddWithValue("@funcionario_logado", funcionarioLogado)
        SQLiteAdapter.SelectCommand = command

        Try
            SQLiteAdapter.Fill(dt)

            frm_menu_funcionario.ConcluidosDataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox("Erro ao preencher o grid: " & ex.Message)
        End Try

        frm_menu_funcionario.ConcluidosDataGrid.Columns("cod").Visible = False
        connection.Close()
    End Sub


    Sub preencherGridConcluidosGerente()
        connection.Close()
        connection.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, funcionario, data, tipo, ficha_cod FROM tb_agenda WHERE realizado='S'"
        Dim SQLiteAdapter As New SQLiteDataAdapter

        frm_menu_gerente.ConcluidoDataGrid.Columns.Clear()

        Dim colFuncionario As New DataGridViewTextBoxColumn()
        colFuncionario.HeaderText = "Funcionário"
        colFuncionario.DataPropertyName = "funcionario"
        frm_menu_gerente.ConcluidoDataGrid.Columns.Add(colFuncionario)

        Dim colData As New DataGridViewTextBoxColumn()
        colData.HeaderText = "Data"
        colData.DataPropertyName = "data"
        frm_menu_gerente.ConcluidoDataGrid.Columns.Add(colData)

        Dim colTipo As New DataGridViewTextBoxColumn()
        colTipo.HeaderText = "Tipo"
        colTipo.DataPropertyName = "tipo"
        frm_menu_gerente.ConcluidoDataGrid.Columns.Add(colTipo)

        Dim colFichaCod As New DataGridViewTextBoxColumn()
        colFichaCod.HeaderText = "Cód. da Ficha"
        colFichaCod.DataPropertyName = "ficha_cod"
        frm_menu_gerente.ConcluidoDataGrid.Columns.Add(colFichaCod)

        command = New SQLiteCommand(commandText, connection)
        SQLiteAdapter.SelectCommand = command

        Try
            SQLiteAdapter.Fill(dt)
            frm_menu_gerente.ConcluidoDataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox("Erro ao preencher o grid: " & ex.Message)
        End Try

        frm_menu_gerente.ConcluidoDataGrid.Columns("cod").Visible = False
        connection.Close()
    End Sub


    Sub preencherGridAgenda()
        connection.Close()
        connection.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim commandText As String = "SELECT cod, funcionario, data, tipo, ficha_cod FROM tb_agenda WHERE realizado='N'"
        Dim SQLiteAdapter As New SQLiteDataAdapter

        frm_menu_gerente.AgendaDataGrid.Columns.Clear()

        Dim colConcluido As New DataGridViewImageColumn()
        colConcluido.HeaderText = "Concluído"
        'colConcluido.Image = My.Resources.IconeConcluido ' Substitua My.Resources.IconeConcluido pelo recurso de imagem correto
        colConcluido.ImageLayout = DataGridViewImageCellLayout.Zoom
        colConcluido.ToolTipText = "Marcar como Concluído"
        frm_menu_funcionario.AfazeresDataGrid.Columns.Add(colConcluido)

        Dim colFuncionario As New DataGridViewTextBoxColumn()
        colFuncionario.HeaderText = "Funcionário"
        colFuncionario.DataPropertyName = "funcionario"
        frm_menu_gerente.AgendaDataGrid.Columns.Add(colFuncionario)

        Dim colData As New DataGridViewTextBoxColumn()
        colData.HeaderText = "Data"
        colData.DataPropertyName = "data"
        frm_menu_gerente.AgendaDataGrid.Columns.Add(colData)

        Dim colTipo As New DataGridViewTextBoxColumn()
        colTipo.HeaderText = "Tipo"
        colTipo.DataPropertyName = "tipo"
        frm_menu_gerente.AgendaDataGrid.Columns.Add(colTipo)

        Dim colFichaCod As New DataGridViewTextBoxColumn()
        colFichaCod.HeaderText = "Cód. da Ficha"
        colFichaCod.DataPropertyName = "ficha_cod"
        frm_menu_gerente.AgendaDataGrid.Columns.Add(colFichaCod)

        command = New SQLiteCommand(commandText, connection)
        SQLiteAdapter.SelectCommand = command

        Try
            SQLiteAdapter.Fill(dt)
            frm_menu_gerente.AgendaDataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox("Erro ao preencher o grid: " & ex.Message)
        End Try

        frm_menu_gerente.AgendaDataGrid.Columns("cod").Visible = False
        connection.Close()
    End Sub


    Sub marcar_concluido(cod)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
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
            Catch ex As Exception
            End Try
        End Using
        connection.Close()
    End Sub

    Sub marcar_nao_concluido(cod)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
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
            End Try
        End Using
        connection.Close()
    End Sub

    Sub nova_tarefa(ficha_cod, func, data, tipo, realizado)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
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
                End Try
            End Using
        End Using
        connection.Close()
    End Sub

    Sub nova_ficha(nome, endereco, contato, objeto, total)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
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
                End Try
            End Using
        End Using
        connection.Close()
    End Sub

    Sub preencherGridFichas()
        connection.Close()
        connection.Open()
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
        connection.Close()
    End Sub



    Sub mostrar_ficha(cod)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
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
                                        .txt_objeto.Text = reader.GetString(2)
                                        .txt_telefone.Text = reader.GetString(3)
                                        .txt_endereco.Text = reader.GetString(4)
                                        .txt_total.Text = reader.GetFloat(5)
                                    End With
                                End If
                            End Using
                        End Using
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                End Try
            End Using
            connection.Close()
        End Using
    End Sub

    Sub alterar_ficha(cod, nome, objeto, endereco, telefone, total)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
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
                End Try
            End Using
        End Using
        connection.Close()
    End Sub

    Sub alterar_agenda(cod, funcionario, data, tipo, realizado, ficha_cod)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "UPDATE tb_agenda SET funcionario = @funcionario, data = @data, tipo = @tipo, realizado = @realizado,
                                                    ficha_cod = @ficha_cod WHERE cod = @cod"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cod", cod)
                            command.Parameters.AddWithValue("@funcionario", funcionario)
                            command.Parameters.AddWithValue("@data", data)
                            command.Parameters.AddWithValue("@tipo", tipo)
                            command.Parameters.AddWithValue("@realizado", realizado)
                            command.Parameters.AddWithValue("@ficha_cod", ficha_cod)
                            command.ExecuteNonQuery()
                        End Using
                        MsgBox("Ficha alterada com sucesso!")
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                End Try
            End Using
        End Using
        connection.Close()
    End Sub

End Module