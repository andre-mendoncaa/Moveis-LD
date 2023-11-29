<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_funcionarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.txt_novocpf = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.cmb_acesso = New System.Windows.Forms.ComboBox()
        Me.lbl_novocpf = New System.Windows.Forms.Label()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(110, 65)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf.TabIndex = 0
        '
        'txt_novocpf
        '
        Me.txt_novocpf.Location = New System.Drawing.Point(297, 65)
        Me.txt_novocpf.Name = "txt_novocpf"
        Me.txt_novocpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_novocpf.TabIndex = 1
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(110, 116)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_nome.TabIndex = 2
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(110, 167)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(100, 20)
        Me.txt_senha.TabIndex = 3
        '
        'cmb_acesso
        '
        Me.cmb_acesso.FormattingEnabled = True
        Me.cmb_acesso.Location = New System.Drawing.Point(110, 238)
        Me.cmb_acesso.Name = "cmb_acesso"
        Me.cmb_acesso.Size = New System.Drawing.Size(121, 21)
        Me.cmb_acesso.TabIndex = 4
        '
        'lbl_novocpf
        '
        Me.lbl_novocpf.AutoSize = True
        Me.lbl_novocpf.Location = New System.Drawing.Point(232, 68)
        Me.lbl_novocpf.Name = "lbl_novocpf"
        Me.lbl_novocpf.Size = New System.Drawing.Size(59, 13)
        Me.lbl_novocpf.TabIndex = 5
        Me.lbl_novocpf.Text = "Novo CPF:"
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(235, 339)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 6
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Location = New System.Drawing.Point(235, 296)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_atualizar.TabIndex = 7
        Me.btn_atualizar.Text = "Atualizar"
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(547, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(135, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cadastrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(135, 339)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Voltar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frm_cadastro_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.lbl_novocpf)
        Me.Controls.Add(Me.cmb_acesso)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_novocpf)
        Me.Controls.Add(Me.txt_cpf)
        Me.Name = "frm_cadastro_funcionarios"
        Me.Text = "frm_cadastro_funcionarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents txt_novocpf As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents cmb_acesso As ComboBox
    Friend WithEvents lbl_novocpf As Label
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
