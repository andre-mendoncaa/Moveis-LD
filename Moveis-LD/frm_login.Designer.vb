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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_cpf = New ns1.BunifuCustomLabel()
        Me.lbl_senha = New ns1.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_cpf = New ns1.BunifuMetroTextbox()
        Me.txt_senha = New ns1.BunifuMetroTextbox()
        Me.btn_minimizar = New ns1.BunifuFlatButton()
        Me.btn_fechar = New ns1.BunifuFlatButton()
        Me.btn_logar = New ns1.BunifuThinButton2()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(66, 236)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(65, 37)
        Me.lbl_cpf.TabIndex = 10
        Me.lbl_cpf.Text = "CPF"
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.Location = New System.Drawing.Point(66, 292)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(94, 37)
        Me.lbl_senha.TabIndex = 11
        Me.lbl_senha.Text = "Senha"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(297, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderColorFocused = System.Drawing.Color.OrangeRed
        Me.txt_cpf.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cpf.BorderColorMouseHover = System.Drawing.Color.OrangeRed
        Me.txt_cpf.BorderThickness = 3
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cpf.isPassword = False
        Me.txt_cpf.Location = New System.Drawing.Point(226, 238)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(370, 37)
        Me.txt_cpf.TabIndex = 15
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_senha
        '
        Me.txt_senha.BorderColorFocused = System.Drawing.Color.OrangeRed
        Me.txt_senha.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_senha.BorderColorMouseHover = System.Drawing.Color.OrangeRed
        Me.txt_senha.BorderThickness = 3
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_senha.isPassword = False
        Me.txt_senha.Location = New System.Drawing.Point(226, 292)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(370, 37)
        Me.txt_senha.TabIndex = 16
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Activecolor = System.Drawing.Color.Empty
        Me.btn_minimizar.BackgroundImage = CType(resources.GetObject("btn_minimizar.BackgroundImage"), System.Drawing.Image)
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.BorderRadius = 0
        Me.btn_minimizar.ButtonText = ""
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_minimizar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_minimizar.Iconimage = Nothing
        Me.btn_minimizar.Iconimage_right = Nothing
        Me.btn_minimizar.Iconimage_right_Selected = Nothing
        Me.btn_minimizar.Iconimage_Selected = Nothing
        Me.btn_minimizar.IconMarginLeft = 0
        Me.btn_minimizar.IconMarginRight = 0
        Me.btn_minimizar.IconRightVisible = True
        Me.btn_minimizar.IconRightZoom = 0R
        Me.btn_minimizar.IconVisible = True
        Me.btn_minimizar.IconZoom = 90.0R
        Me.btn_minimizar.IsTab = False
        Me.btn_minimizar.Location = New System.Drawing.Point(673, 12)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_minimizar.selected = False
        Me.btn_minimizar.Size = New System.Drawing.Size(36, 38)
        Me.btn_minimizar.TabIndex = 19
        Me.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_minimizar.Textcolor = System.Drawing.Color.White
        Me.btn_minimizar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_fechar
        '
        Me.btn_fechar.Activecolor = System.Drawing.Color.Empty
        Me.btn_fechar.BackgroundImage = CType(resources.GetObject("btn_fechar.BackgroundImage"), System.Drawing.Image)
        Me.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_fechar.BorderRadius = 0
        Me.btn_fechar.ButtonText = ""
        Me.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fechar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_fechar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_fechar.Iconimage = Nothing
        Me.btn_fechar.Iconimage_right = Nothing
        Me.btn_fechar.Iconimage_right_Selected = Nothing
        Me.btn_fechar.Iconimage_Selected = Nothing
        Me.btn_fechar.IconMarginLeft = 0
        Me.btn_fechar.IconMarginRight = 0
        Me.btn_fechar.IconRightVisible = True
        Me.btn_fechar.IconRightZoom = 0R
        Me.btn_fechar.IconVisible = True
        Me.btn_fechar.IconZoom = 90.0R
        Me.btn_fechar.IsTab = False
        Me.btn_fechar.Location = New System.Drawing.Point(715, 12)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_fechar.selected = False
        Me.btn_fechar.Size = New System.Drawing.Size(42, 38)
        Me.btn_fechar.TabIndex = 20
        Me.btn_fechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_fechar.Textcolor = System.Drawing.Color.White
        Me.btn_fechar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_logar
        '
        Me.btn_logar.ActiveBorderThickness = 1
        Me.btn_logar.ActiveCornerRadius = 20
        Me.btn_logar.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_logar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_logar.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_logar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_logar.BackgroundImage = CType(resources.GetObject("btn_logar.BackgroundImage"), System.Drawing.Image)
        Me.btn_logar.ButtonText = "Entrar"
        Me.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_logar.IdleBorderThickness = 1
        Me.btn_logar.IdleCornerRadius = 20
        Me.btn_logar.IdleFillColor = System.Drawing.Color.White
        Me.btn_logar.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_logar.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_logar.Location = New System.Drawing.Point(297, 372)
        Me.btn_logar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_logar.Name = "btn_logar"
        Me.btn_logar.Size = New System.Drawing.Size(181, 41)
        Me.btn_logar.TabIndex = 22
        Me.btn_logar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 487)
        Me.Controls.Add(Me.btn_logar)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.lbl_cpf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    'Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    'Friend WithEvents btn_logar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lbl_senha As ns1.BunifuCustomLabel
    Friend WithEvents lbl_cpf As ns1.BunifuCustomLabel
    Friend WithEvents txt_senha As ns1.BunifuMetroTextbox
    Friend WithEvents txt_cpf As ns1.BunifuMetroTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_minimizar As ns1.BunifuFlatButton
    Friend WithEvents btn_fechar As ns1.BunifuFlatButton
    Friend WithEvents btn_logar As ns1.BunifuThinButton2
End Class
