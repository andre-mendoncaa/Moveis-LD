<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adicionar_ficha
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_contato = New System.Windows.Forms.TextBox()
        Me.txt_objeto = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contato:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Endereço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Objeto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(153, 46)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(171, 20)
        Me.txt_nome.TabIndex = 5
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(153, 92)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(171, 20)
        Me.txt_endereco.TabIndex = 6
        '
        'txt_contato
        '
        Me.txt_contato.Location = New System.Drawing.Point(153, 138)
        Me.txt_contato.Name = "txt_contato"
        Me.txt_contato.Size = New System.Drawing.Size(171, 20)
        Me.txt_contato.TabIndex = 7
        '
        'txt_objeto
        '
        Me.txt_objeto.Location = New System.Drawing.Point(153, 185)
        Me.txt_objeto.Name = "txt_objeto"
        Me.txt_objeto.Size = New System.Drawing.Size(171, 20)
        Me.txt_objeto.TabIndex = 8
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(153, 231)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(171, 20)
        Me.txt_total.TabIndex = 9
        '
        'btn_voltar
        '
        Me.btn_voltar.Location = New System.Drawing.Point(153, 326)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 23)
        Me.btn_voltar.TabIndex = 10
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'btn_salvar
        '
        Me.btn_salvar.Location = New System.Drawing.Point(249, 326)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(75, 23)
        Me.btn_salvar.TabIndex = 11
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'frm_adicionar_ficha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_objeto)
        Me.Controls.Add(Me.txt_contato)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_adicionar_ficha"
        Me.Text = "frm_adicionar_ficha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_contato As TextBox
    Friend WithEvents txt_objeto As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_salvar As Button
End Class
