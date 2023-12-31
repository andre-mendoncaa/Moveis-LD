﻿Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Module mod_usuarios

    Public dbCommand As String = ""
    Public bindingSrc As BindingSource
    Public dbName As String = "db_moveis.db"
    Public dbPath As String = Application.StartupPath & "\" & dbName
    Public conString As String = "Data Source=" & dbPath & ";Version=3"
    Public connection As New SQLiteConnection(conString)
    Public command As New SQLiteCommand("", connection)
    'Fim das conexões
    Public cpfLogado As String
    Public funcionarioLogado As String

    Sub logar(cpf As String, senha As String)

        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "SELECT * FROM tb_usuarios WHERE cpf=@cpf AND senha=@senha"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cpf", cpf)
                            command.Parameters.AddWithValue("@senha", senha)

                            Dim reader As SQLiteDataReader = command.ExecuteReader()

                            If reader.HasRows Then
                                reader.Read()
                                If reader.GetString(4) = "inativo" Then
                                    MsgBox("Você não pode entrar no sistema pois sua conta está desativada.")
                                Else
                                    If reader.GetString(3) = "gerente" Then
                                        MsgBox("Entrou como gerente.")
                                        cpfLogado = cpf
                                        funcionarioLogado = reader.GetString(1)
                                        frm_menu_gerente.Show()
                                    Else
                                        MsgBox("Entrou como funcionário.")
                                        cpfLogado = cpf
                                        funcionarioLogado = reader.GetString(1)
                                        frm_menu_funcionario.Show()

                                    End If
                                    frm_login.Hide()
                                    limpar_campos_login()
                                End If
                            Else
                                MsgBox("CPF ou senha inválidos!")
                                limpar_campos_login()
                            End If
                        End Using
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                End Try
            End Using
        End Using
        connection.Close()
    End Sub




    Sub cadastrar(cpf As String, nome As String, senha As String, acesso As String, status As String)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "INSERT INTO tb_usuarios VALUES (@cpf, @nome, @senha, @acesso, @status)"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cpf", cpf)
                            command.Parameters.AddWithValue("@nome", nome)
                            command.Parameters.AddWithValue("@senha", senha)
                            command.Parameters.AddWithValue("@acesso", acesso)
                            command.Parameters.AddWithValue("@status", status)
                            command.ExecuteNonQuery()
                        End Using
                        MsgBox("Cadastro realizado com sucesso!")
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                End Try
            End Using
        End Using
        connection.Close()
    End Sub


    Sub procurar_usuario(cpf As String)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "SELECT * FROM tb_usuarios WHERE cpf=@cpf"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cpf", cpf)

                            Using reader As SQLiteDataReader = command.ExecuteReader()
                                If reader.Read() Then
                                    'MsgBox("Esse funcionário já está cadastrado!")
                                    With frm_cadastro_funcionarios
                                        .txt_nome.Text = reader.GetString(1)
                                        .txt_senha.Text = reader.GetString(2)
                                        .cmb_acesso.Text = reader.GetString(3)
                                        .cmb_status.Text = reader.GetString(4)
                                        .btn_atualizar.Enabled = True
                                    End With
                                Else
                                    limpar_campos_cadastro()
                                    With frm_cadastro_funcionarios
                                        .btn_atualizar.Enabled = False
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
        End Using
        connection.Close()
    End Sub


    Sub atualizar_cadastro(cpf As String, nome As String, senha As String, acesso As String, status As String)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "UPDATE tb_usuarios SET nome=@nome, senha=@senha, acesso=@acesso, status=@status WHERE cpf=@cpf"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cpf", cpf)
                            command.Parameters.AddWithValue("@nome", nome)
                            command.Parameters.AddWithValue("@senha", senha)
                            command.Parameters.AddWithValue("@acesso", acesso)
                            command.Parameters.AddWithValue("@status", status)
                            command.ExecuteNonQuery()
                        End Using
                        MsgBox("Cadastro atualizado com sucesso!")
                        limpar_campos_cadastro()
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                End Try
            End Using
        End Using
        connection.Close()
    End Sub


    Sub excluir_cadastro(cpf As String)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "DELETE FROM tb_usuarios WHERE cpf=@cpf"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cpf", cpf)
                            command.ExecuteNonQuery()
                        End Using
                        MsgBox("Cadastro excluido com sucesso!")
                        limpar_campos_cadastro()
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                End Try
            End Using
        End Using
        connection.Close()
    End Sub


    Sub alterar_senha(novaSenha)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "UPDATE tb_usuarios SET senha = @novaSenha WHERE cpf = @cpfLogado"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@novaSenha", novaSenha)
                            command.Parameters.AddWithValue("@cpfLogado", cpfLogado)
                            command.ExecuteNonQuery()
                        End Using
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                End Try
            End Using
        End Using
        connection.Close()
    End Sub


    Function checar_senha(senha) As Boolean
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "SELECT senha FROM tb_usuarios WHERE cpf = @cpf"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@cpf", cpfLogado)
                        Using reader As SQLiteDataReader = command.ExecuteReader
                            If reader.HasRows Then
                                reader.Read()
                                If senha = reader.GetString(0) Then
                                    Return True
                                Else
                                    Return False
                                End If
                            Else
                                Return False
                            End If
                        End Using
                    End Using
                Else
                    Return False
                End If
            Catch ex As SQLiteException
                Return False
            Catch ex As Exception
                Return False
            End Try
            connection.Close()
        End Using
    End Function

    'subs para limpar campos
    Sub limpar_campos_login()
        With frm_login
            .txt_cpf.Text = String.Empty
            .txt_senha.Text = String.Empty
        End With
    End Sub

    Sub limpar_campos_cadastro()
        With frm_cadastro_funcionarios
            .txt_nome.Clear()
            .txt_senha.Clear()
            .cmb_acesso.ResetText()
            .cmb_status.ResetText()
        End With
    End Sub

    Sub limpar_campos_alterar_senha()
        With frm_alterar_senha
            .txt_senha.Clear()
            .txt_nova_senha.Clear()
            .txt_confirmar_senha.Clear()
        End With
    End Sub
End Module