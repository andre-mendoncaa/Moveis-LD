Imports System.Data.SQLite

Module mod_fichas
    Sub novaFicha(nome, endereco, contato, objeto, total)
        Using connection As New SQLiteConnection(conString)
            connection.Open()

            Dim commandText As String = "INSERT INTO tb_fichas(nome, endereco, contato, objeto, total) VALUES (@nome, @endereco, @contato, @objeto, @total)"
            Using command As New SQLiteCommand(commandText, connection)
                command.Parameters.AddWithValue("@nome", nome)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@contato", contato)
                command.Parameters.AddWithValue("@objeto", objeto)
                command.Parameters.AddWithValue("@total", total)
                command.ExecuteNonQuery()
            End Using

            MsgBox("Cadastro realizado com sucesso!")
        End Using
        connection.Close()
    End Sub
End Module
