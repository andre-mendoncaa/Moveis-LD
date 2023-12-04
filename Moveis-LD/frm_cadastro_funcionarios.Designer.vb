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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_funcionarios))
        Me.cmb_acesso = New System.Windows.Forms.ComboBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.btn_fechar = New ns1.BunifuFlatButton()
        Me.btn_minimizar = New ns1.BunifuFlatButton()
        Me.lbl_cpf = New ns1.BunifuCustomLabel()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New ns1.BunifuCustomLabel()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.btn_atualizar = New ns1.BunifuThinButton2()
        Me.btn_cadastrar = New ns1.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'cmb_acesso
        '
        Me.cmb_acesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_acesso.FormattingEnabled = True
        Me.cmb_acesso.Items.AddRange(New Object() {"funcionario", "gerente"})
        Me.cmb_acesso.Location = New System.Drawing.Point(213, 201)
        Me.cmb_acesso.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_acesso.Name = "cmb_acesso"
        Me.cmb_acesso.Size = New System.Drawing.Size(221, 24)
        Me.cmb_acesso.TabIndex = 20
        '
        'cmb_status
        '
        Me.cmb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"ativo", "inativo"})
        Me.cmb_status.Location = New System.Drawing.Point(213, 242)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(221, 24)
        Me.cmb_status.TabIndex = 30
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
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
        Me.btn_fechar.Location = New System.Drawing.Point(551, 12)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_fechar.selected = False
        Me.btn_fechar.Size = New System.Drawing.Size(42, 38)
        Me.btn_fechar.TabIndex = 33
        Me.btn_fechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_fechar.Textcolor = System.Drawing.Color.White
        Me.btn_fechar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_minimizar.Location = New System.Drawing.Point(500, 12)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_minimizar.selected = False
        Me.btn_minimizar.Size = New System.Drawing.Size(36, 38)
        Me.btn_minimizar.TabIndex = 32
        Me.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_minimizar.Textcolor = System.Drawing.Color.White
        Me.btn_minimizar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(153, 119)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(50, 19)
        Me.lbl_cpf.TabIndex = 35
        Me.lbl_cpf.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(212, 117)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(222, 23)
        Me.txt_nome.TabIndex = 34
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(156, 77)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(33, 19)
        Me.BunifuCustomLabel1.TabIndex = 37
        Me.BunifuCustomLabel1.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(213, 77)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(222, 23)
        Me.txt_cpf.TabIndex = 36
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(153, 160)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(49, 19)
        Me.BunifuCustomLabel2.TabIndex = 39
        Me.BunifuCustomLabel2.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(212, 160)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(222, 23)
        Me.txt_senha.TabIndex = 38
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(156, 201)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(55, 19)
        Me.BunifuCustomLabel3.TabIndex = 40
        Me.BunifuCustomLabel3.Text = "Acesso"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(153, 242)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(49, 19)
        Me.BunifuCustomLabel4.TabIndex = 41
        Me.BunifuCustomLabel4.Text = "Status"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.OrangeRed
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(206, 24)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(236, 35)
        Me.BunifuCustomLabel5.TabIndex = 42
        Me.BunifuCustomLabel5.Text = "Gerenciar Contas"
        '
        'btn_voltar
        '
        Me.btn_voltar.ActiveBorderThickness = 1
        Me.btn_voltar.ActiveCornerRadius = 20
        Me.btn_voltar.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_voltar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_voltar.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_voltar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.ButtonText = "Voltar"
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_voltar.IdleBorderThickness = 1
        Me.btn_voltar.IdleCornerRadius = 20
        Me.btn_voltar.IdleFillColor = System.Drawing.Color.White
        Me.btn_voltar.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_voltar.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_voltar.Location = New System.Drawing.Point(73, 288)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(153, 41)
        Me.btn_voltar.TabIndex = 43
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_atualizar
        '
        Me.btn_atualizar.ActiveBorderThickness = 1
        Me.btn_atualizar.ActiveCornerRadius = 20
        Me.btn_atualizar.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_atualizar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_atualizar.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_atualizar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_atualizar.BackgroundImage = CType(resources.GetObject("btn_atualizar.BackgroundImage"), System.Drawing.Image)
        Me.btn_atualizar.ButtonText = "Atualizar"
        Me.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_atualizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atualizar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_atualizar.IdleBorderThickness = 1
        Me.btn_atualizar.IdleCornerRadius = 20
        Me.btn_atualizar.IdleFillColor = System.Drawing.Color.White
        Me.btn_atualizar.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_atualizar.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_atualizar.Location = New System.Drawing.Point(246, 288)
        Me.btn_atualizar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(153, 41)
        Me.btn_atualizar.TabIndex = 44
        Me.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.ActiveBorderThickness = 1
        Me.btn_cadastrar.ActiveCornerRadius = 20
        Me.btn_cadastrar.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_cadastrar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cadastrar.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_cadastrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cadastrar.BackgroundImage = CType(resources.GetObject("btn_cadastrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cadastrar.ButtonText = "Cadastrar"
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_cadastrar.IdleBorderThickness = 1
        Me.btn_cadastrar.IdleCornerRadius = 20
        Me.btn_cadastrar.IdleFillColor = System.Drawing.Color.White
        Me.btn_cadastrar.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_cadastrar.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_cadastrar.Location = New System.Drawing.Point(422, 288)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(153, 41)
        Me.btn_cadastrar.TabIndex = 45
        Me.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_cadastro_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 355)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.cmb_acesso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadastro_funcionarios"
        Me.Text = "frm_cadastro_funcionarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_acesso As ComboBox
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents btn_fechar As ns1.BunifuFlatButton
    Friend WithEvents btn_minimizar As ns1.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents lbl_cpf As ns1.BunifuCustomLabel
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As ns1.BunifuCustomLabel
    Friend WithEvents btn_cadastrar As ns1.BunifuThinButton2
    Friend WithEvents btn_atualizar As ns1.BunifuThinButton2
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
End Class
