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
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_acesso = New System.Windows.Forms.ComboBox()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_voltar
        '
        Me.btn_voltar.Location = New System.Drawing.Point(11, 260)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(104, 28)
        Me.btn_voltar.TabIndex = 29
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Enabled = False
        Me.btn_atualizar.Location = New System.Drawing.Point(152, 260)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(104, 28)
        Me.btn_atualizar.TabIndex = 26
        Me.btn_atualizar.Text = "ATUALIZAR"
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(152, 94)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(157, 20)
        Me.txt_nome.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nome:"
        '
        'cmb_acesso
        '
        Me.cmb_acesso.FormattingEnabled = True
        Me.cmb_acesso.Items.AddRange(New Object() {"funcionario", "gerente"})
        Me.cmb_acesso.Location = New System.Drawing.Point(152, 179)
        Me.cmb_acesso.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_acesso.Name = "cmb_acesso"
        Me.cmb_acesso.Size = New System.Drawing.Size(157, 21)
        Me.cmb_acesso.TabIndex = 20
        '
        'btn_cadastro
        '
        Me.btn_cadastro.Location = New System.Drawing.Point(152, 227)
        Me.btn_cadastro.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(104, 28)
        Me.btn_cadastro.TabIndex = 22
        Me.btn_cadastro.Text = "CADASTRAR"
        Me.btn_cadastro.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Acesso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CPF:"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(152, 53)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(157, 20)
        Me.txt_cpf.TabIndex = 16
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(152, 135)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(157, 20)
        Me.txt_senha.TabIndex = 19
        '
        'cmb_status
        '
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"ativo", "inativo"})
        Me.cmb_status.Location = New System.Drawing.Point(425, 52)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(157, 21)
        Me.cmb_status.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Status:"
        '
        'frm_cadastro_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 355)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_acesso)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_senha)
        Me.Name = "frm_cadastro_funcionarios"
        Me.Text = "frm_cadastro_funcionarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_acesso As ComboBox
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents Label5 As Label
End Class
