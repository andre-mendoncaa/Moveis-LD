<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lbl_cpf = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_senha = New Guna.UI.WinForms.GunaLabel()
        Me.txt_cpf = New ns1.BunifuMaterialTextbox()
        Me.txt_senha = New ns1.BunifuMaterialTextbox()
        Me.btn_logar = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(137, 186)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(56, 39)
        Me.lbl_cpf.TabIndex = 1
        Me.lbl_cpf.Text = "CPF"
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.Location = New System.Drawing.Point(137, 257)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(85, 39)
        Me.lbl_senha.TabIndex = 2
        Me.lbl_senha.Text = "SENHA"
        '
        'txt_cpf
        '
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cpf.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpf.HintText = ""
        Me.txt_cpf.isPassword = False
        Me.txt_cpf.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_cpf.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cpf.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_cpf.LineThickness = 3
        Me.txt_cpf.Location = New System.Drawing.Point(240, 186)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(370, 39)
        Me.txt_cpf.TabIndex = 6
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_senha
        '
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_senha.HintForeColor = System.Drawing.Color.Empty
        Me.txt_senha.HintText = ""
        Me.txt_senha.isPassword = False
        Me.txt_senha.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_senha.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_senha.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_senha.LineThickness = 3
        Me.txt_senha.Location = New System.Drawing.Point(240, 257)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(370, 39)
        Me.txt_senha.TabIndex = 8
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_logar
        '
        Me.btn_logar.AnimationHoverSpeed = 0.07!
        Me.btn_logar.AnimationSpeed = 0.03!
        Me.btn_logar.BaseColor = System.Drawing.Color.Red
        Me.btn_logar.BorderColor = System.Drawing.Color.Black
        Me.btn_logar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_logar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_logar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_logar.ForeColor = System.Drawing.Color.White
        Me.btn_logar.Image = Nothing
        Me.btn_logar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_logar.Location = New System.Drawing.Point(377, 342)
        Me.btn_logar.Name = "btn_logar"
        Me.btn_logar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_logar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_logar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_logar.OnHoverImage = Nothing
        Me.btn_logar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_logar.Size = New System.Drawing.Size(60, 42)
        Me.btn_logar.TabIndex = 9
        Me.btn_logar.Text = "ENTRAR"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_logar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.lbl_cpf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txt_cpf As ns1.BunifuMaterialTextbox
    Friend WithEvents lbl_senha As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_cpf As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_senha As ns1.BunifuMaterialTextbox
    Friend WithEvents btn_logar As Guna.UI.WinForms.GunaButton
End Class
