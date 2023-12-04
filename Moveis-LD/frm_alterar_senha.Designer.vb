<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alterar_senha
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
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.txt_nova_senha = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_voltar
        '
        Me.btn_voltar.Location = New System.Drawing.Point(69, 196)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 23)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(165, 196)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar.TabIndex = 14
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(140, 142)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(100, 20)
        Me.txt_confirmar_senha.TabIndex = 13
        '
        'txt_nova_senha
        '
        Me.txt_nova_senha.Location = New System.Drawing.Point(140, 83)
        Me.txt_nova_senha.Name = "txt_nova_senha"
        Me.txt_nova_senha.Size = New System.Drawing.Size(100, 20)
        Me.txt_nova_senha.TabIndex = 12
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(140, 30)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(100, 20)
        Me.txt_senha.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Confirmar nova senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nova senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Senha atual:"
        '
        'frm_alterar_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.txt_nova_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_alterar_senha"
        Me.Text = "frm_alterar_senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents txt_nova_senha As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
