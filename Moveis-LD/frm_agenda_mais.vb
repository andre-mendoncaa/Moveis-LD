Imports System.Data.SQLite

Public Class frm_agenda_mais

    Public Sub CarregarDados(cod As Integer)
        Using connection As New SQLiteConnection(conString)
            connection.Close()
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    If connection.State = ConnectionState.Open Then
                        Dim commandText As String = "SELECT tb_agenda.data, tb_agenda.tipo, tb_fichas.objeto, tb_fichas.endereco, tb_fichas.contato, tb_fichas.nome FROM tb_agenda INNER JOIN tb_fichas ON tb_agenda.ficha_cod = tb_fichas.cod WHERE tb_agenda.cod=@cod"
                        Using command As New SQLiteCommand(commandText, connection)
                            command.Parameters.AddWithValue("@cod", cod)

                            Using reader As SQLiteDataReader = command.ExecuteReader()
                                If reader.HasRows Then
                                    reader.Read()
                                    lbl_data.Text = reader.GetString(0)
                                    lbl_tipo.Text = reader.GetString(1)
                                    lbl_objeto.Text = reader.GetString(2)
                                    lbl_endereco.Text = reader.GetString(3)
                                    lbl_nome.Text = reader.GetString(4)
                                    lbl_contato.Text = reader.GetString(5)
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
        frm_menu_funcionario.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu_funcionario.Show()
    End Sub
End Class