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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alterar_senha))
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.txt_nova_senha = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New ns1.BunifuCustomLabel()
        Me.btn_fechar = New ns1.BunifuFlatButton()
        Me.btn_minimizar = New ns1.BunifuFlatButton()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.btn_confirmar = New ns1.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(236, 218)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(254, 22)
        Me.txt_confirmar_senha.TabIndex = 13
        '
        'txt_nova_senha
        '
        Me.txt_nova_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nova_senha.Location = New System.Drawing.Point(236, 176)
        Me.txt_nova_senha.Name = "txt_nova_senha"
        Me.txt_nova_senha.Size = New System.Drawing.Size(254, 22)
        Me.txt_nova_senha.TabIndex = 12
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(236, 140)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(254, 22)
        Me.txt_senha.TabIndex = 11
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(74, 143)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(88, 19)
        Me.BunifuCustomLabel2.TabIndex = 49
        Me.BunifuCustomLabel2.Text = "Senha Atual"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(74, 179)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(88, 19)
        Me.BunifuCustomLabel1.TabIndex = 50
        Me.BunifuCustomLabel1.Text = "Nova Senha"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(74, 221)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(153, 19)
        Me.BunifuCustomLabel3.TabIndex = 51
        Me.BunifuCustomLabel3.Text = "Confirmar nova senha"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.OrangeRed
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(255, 60)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(189, 35)
        Me.BunifuCustomLabel6.TabIndex = 64
        Me.BunifuCustomLabel6.Text = "Alterar Senha"
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
        Me.btn_fechar.Location = New System.Drawing.Point(578, 39)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_fechar.selected = False
        Me.btn_fechar.Size = New System.Drawing.Size(42, 38)
        Me.btn_fechar.TabIndex = 63
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
        Me.btn_minimizar.Location = New System.Drawing.Point(536, 39)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_minimizar.selected = False
        Me.btn_minimizar.Size = New System.Drawing.Size(36, 38)
        Me.btn_minimizar.TabIndex = 62
        Me.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_minimizar.Textcolor = System.Drawing.Color.White
        Me.btn_minimizar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
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
        Me.btn_voltar.Location = New System.Drawing.Point(156, 284)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(153, 41)
        Me.btn_voltar.TabIndex = 65
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_confirmar
        '
        Me.btn_confirmar.ActiveBorderThickness = 1
        Me.btn_confirmar.ActiveCornerRadius = 20
        Me.btn_confirmar.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_confirmar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_confirmar.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_confirmar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_confirmar.BackgroundImage = CType(resources.GetObject("btn_confirmar.BackgroundImage"), System.Drawing.Image)
        Me.btn_confirmar.ButtonText = "Confirmar"
        Me.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_confirmar.IdleBorderThickness = 1
        Me.btn_confirmar.IdleCornerRadius = 20
        Me.btn_confirmar.IdleFillColor = System.Drawing.Color.White
        Me.btn_confirmar.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_confirmar.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_confirmar.Location = New System.Drawing.Point(367, 284)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(153, 41)
        Me.btn_confirmar.TabIndex = 66
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_alterar_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 390)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.txt_nova_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_alterar_senha"
        Me.Text = "frm_alterar_senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents txt_nova_senha As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As ns1.BunifuCustomLabel
    Friend WithEvents btn_fechar As ns1.BunifuFlatButton
    Friend WithEvents btn_minimizar As ns1.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
    Friend WithEvents btn_confirmar As ns1.BunifuThinButton2
End Class
