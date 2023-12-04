Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frm_alterar_tarefa
    Dim cod_agenda
    Public Sub CarregarDados(cod As Integer)
        cod_agenda = cod
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "SELECT funcionario, data, tipo, realizado, ficha_cod FROM tb_agenda WHERE cod=@cod"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cod", cod)

                            Using reader As SQLiteDataReader = command.ExecuteReader()
                                If reader.HasRows Then
                                    reader.Read()
                                    txt_func.Text = reader.GetString(0)
                                    txt_data.Text = reader.GetString(1)
                                    txt_tipo.Text = reader.GetString(2)
                                    txt_realizado.Text = reader.GetString(3)
                                    txt_ficha_cod.Text = reader.GetInt16(4)
                                End If
                            End Using
                        End Using
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                End Try
            End Using
            ' Não feche a conexão aqui para que ela seja acessível após a chamada do método.
            connection.Close()
        End Using
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frm_menu_gerente.Show()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs)
        Dim funcionario = txt_func.Text
        Dim data = txt_data.Text
        Dim tipo = txt_tipo.Text
        Dim realizado = txt_realizado.Text
        Dim ficha_cod = txt_ficha_cod.Text
        alterar_agenda(cod_agenda, funcionario, data, tipo, realizado, ficha_cod)
        preencherGridAgenda()
        preencherGridConcluidosGerente()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu_gerente.Show()
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim funcionario = txt_func.Text
        Dim data = txt_data.Text
        Dim tipo = txt_tipo.Text
        Dim realizado = txt_realizado.Text
        Dim ficha_cod = txt_ficha_cod.Text
        alterar_agenda(cod_agenda, funcionario, data, tipo, realizado, ficha_cod)
        preencherGridAgenda()
        preencherGridConcluidosGerente()
    End Sub
End Class
