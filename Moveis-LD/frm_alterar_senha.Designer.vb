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
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.txt_nova_senha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(114, 61)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(100, 20)
        Me.txt_senha.TabIndex = 0
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(114, 107)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(100, 20)
        Me.txt_confirmar_senha.TabIndex = 1
        '
        'txt_nova_senha
        '
        Me.txt_nova_senha.Location = New System.Drawing.Point(114, 157)
        Me.txt_nova_senha.Name = "txt_nova_senha"
        Me.txt_nova_senha.Size = New System.Drawing.Size(100, 20)
        Me.txt_nova_senha.TabIndex = 2
        '
        'frm_alterar_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_nova_senha)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Name = "frm_alterar_senha"
        Me.Text = "frm_alterar_senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents txt_nova_senha As TextBox
End Class
