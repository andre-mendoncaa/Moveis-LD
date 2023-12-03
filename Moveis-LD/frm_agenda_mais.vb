Imports System.Data.SQLite

Public Class frm_agenda_mais

    Private _cod As String

    Public Sub New(ByVal cod As String)
        InitializeComponent()
        _cod = cod
    End Sub

    Private Sub frm_agenda_mais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using connection As New SQLiteConnection(conString)
            connection.Open()
            Try
                If connection.State = ConnectionState.Open Then
                    Dim commandText As String = "SELECT data, tipo, objeto, endereco, nome, contato, realizado FROM tb_agenda WHERE cod = @cod"
                    Using command As New SQLiteCommand(commandText, connection)
                        command.Parameters.AddWithValue("@cod", _cod)

                        Dim reader As SQLiteDataReader = command.ExecuteReader()

                        Using reader
                            If reader.HasRows Then
                                reader.Read()
                                lbl_data.Text = reader.GetString(0)
                                lbl_tipo.Text = reader.GetString(1)
                                lbl_objeto.Text = reader.GetString(2)
                                lbl_endereco.Text = reader.GetString(3)
                                lbl_nome.Text = reader.GetString(4)
                                lbl_contato.Text = reader.GetString(5)
                            Else
                                MsgBox("Ocorreu algum erro. Consulte seu gerente.")
                                Me.Close()
                                frm_menu_funcionario.Show()
                            End If
                            If reader.GetString(6) = "S" Then
                                btn_concluido.Text = "Marcar como NÃO CONCLUÍDO"
                            End If
                        End Using
                    End Using
                End If
            Catch ex As Exception
                MsgBox("Erro de conexão: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu_funcionario.Show()
    End Sub

    Private Sub btn_concluido_Click(sender As Object, e As EventArgs) Handles btn_concluido.Click
        If btn_concluido.Text = "Marcar como CONCLUÍDO" Then
            marcar_concluido(_cod)
            Me.Close()
            frm_menu_funcionario.Show()
        Else
            marcar_nao_concluido(_cod)
            Me.Close()
            frm_menu_funcionario.Show()
        End If
    End Sub
End Class