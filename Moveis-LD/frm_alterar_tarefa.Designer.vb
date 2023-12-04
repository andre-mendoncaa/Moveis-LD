<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_alterar_tarefa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_realizado = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.txt_func = New System.Windows.Forms.TextBox()
        Me.txt_ficha_cod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_salvar
        '
        Me.btn_salvar.Location = New System.Drawing.Point(172, 377)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(75, 23)
        Me.btn_salvar.TabIndex = 23
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Location = New System.Drawing.Point(55, 377)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(75, 23)
        Me.btn_voltar.TabIndex = 22
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'txt_realizado
        '
        Me.txt_realizado.Location = New System.Drawing.Point(122, 304)
        Me.txt_realizado.Name = "txt_realizado"
        Me.txt_realizado.Size = New System.Drawing.Size(100, 20)
        Me.txt_realizado.TabIndex = 21
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(122, 238)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo.TabIndex = 20
        '
        'txt_data
        '
        Me.txt_data.Location = New System.Drawing.Point(122, 176)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(100, 20)
        Me.txt_data.TabIndex = 19
        '
        'txt_func
        '
        Me.txt_func.Location = New System.Drawing.Point(122, 114)
        Me.txt_func.Name = "txt_func"
        Me.txt_func.Size = New System.Drawing.Size(100, 20)
        Me.txt_func.TabIndex = 18
        '
        'txt_ficha_cod
        '
        Me.txt_ficha_cod.Location = New System.Drawing.Point(122, 49)
        Me.txt_ficha_cod.Name = "txt_ficha_cod"
        Me.txt_ficha_cod.Size = New System.Drawing.Size(100, 20)
        Me.txt_ficha_cod.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Código da ficha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Realizado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Funcionário:"
        '
        'frm_alterar_tarefa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.txt_realizado)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.txt_func)
        Me.Controls.Add(Me.txt_ficha_cod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_alterar_tarefa"
        Me.Text = "frm_alterar_tarefa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_realizado As TextBox
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents txt_data As TextBox
    Friend WithEvents txt_func As TextBox
    Friend WithEvents txt_ficha_cod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
