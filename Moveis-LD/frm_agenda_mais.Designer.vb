<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agenda_mais
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
        Me.lbl_objeto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_concluido = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.lbl_contato = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_objeto
        '
        Me.lbl_objeto.AutoSize = True
        Me.lbl_objeto.Location = New System.Drawing.Point(157, 103)
        Me.lbl_objeto.Name = "lbl_objeto"
        Me.lbl_objeto.Size = New System.Drawing.Size(29, 13)
        Me.lbl_objeto.TabIndex = 27
        Me.lbl_objeto.Text = "Nulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Objeto:"
        '
        'btn_concluido
        '
        Me.btn_concluido.Location = New System.Drawing.Point(197, 252)
        Me.btn_concluido.Name = "btn_concluido"
        Me.btn_concluido.Size = New System.Drawing.Size(183, 23)
        Me.btn_concluido.TabIndex = 25
        Me.btn_concluido.Text = "Marcar como CONCLUÍDO"
        Me.btn_concluido.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Location = New System.Drawing.Point(57, 252)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 23)
        Me.btn_voltar.TabIndex = 24
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'lbl_contato
        '
        Me.lbl_contato.AutoSize = True
        Me.lbl_contato.Location = New System.Drawing.Point(157, 207)
        Me.lbl_contato.Name = "lbl_contato"
        Me.lbl_contato.Size = New System.Drawing.Size(29, 13)
        Me.lbl_contato.TabIndex = 23
        Me.lbl_contato.Text = "Nulo"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(157, 170)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(29, 13)
        Me.lbl_nome.TabIndex = 22
        Me.lbl_nome.Text = "Nulo"
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Location = New System.Drawing.Point(157, 136)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(29, 13)
        Me.lbl_endereco.TabIndex = 21
        Me.lbl_endereco.Text = "Nulo"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(157, 67)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(29, 13)
        Me.lbl_tipo.TabIndex = 20
        Me.lbl_tipo.Text = "Nulo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Contato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Nome da cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tipo:"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(157, 30)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(29, 13)
        Me.lbl_data.TabIndex = 15
        Me.lbl_data.Text = "Nulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Data:"
        '
        'frm_agenda_mais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_objeto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_concluido)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.lbl_contato)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.lbl_endereco)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_agenda_mais"
        Me.Text = "frm_agenda_mais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_objeto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_concluido As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents lbl_contato As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_endereco As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_data As Label
    Friend WithEvents Label1 As Label
End Class
