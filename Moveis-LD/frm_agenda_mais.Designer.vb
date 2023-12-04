<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_agenda_mais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_agenda_mais))
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New ns1.BunifuCustomLabel()
        Me.lbl_contato = New ns1.BunifuCustomLabel()
        Me.lbl_nome = New ns1.BunifuCustomLabel()
        Me.lbl_endereco = New ns1.BunifuCustomLabel()
        Me.lbl_objeto = New ns1.BunifuCustomLabel()
        Me.lbl_tipo = New ns1.BunifuCustomLabel()
        Me.lbl_data = New ns1.BunifuCustomLabel()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.btn_fechar = New ns1.BunifuFlatButton()
        Me.btn_minimizar = New ns1.BunifuFlatButton()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.BunifuCustomLabel7 = New ns1.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(139, 110)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(41, 19)
        Me.BunifuCustomLabel2.TabIndex = 50
        Me.BunifuCustomLabel2.Text = "Data"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(139, 147)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(39, 19)
        Me.BunifuCustomLabel1.TabIndex = 51
        Me.BunifuCustomLabel1.Text = "Tipo"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(139, 183)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(55, 19)
        Me.BunifuCustomLabel3.TabIndex = 52
        Me.BunifuCustomLabel3.Text = "Objeto"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(139, 299)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(62, 19)
        Me.BunifuCustomLabel4.TabIndex = 55
        Me.BunifuCustomLabel4.Text = "Contato"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(139, 263)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(100, 19)
        Me.BunifuCustomLabel5.TabIndex = 54
        Me.BunifuCustomLabel5.Text = "Nome Cliente"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(139, 226)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(71, 19)
        Me.BunifuCustomLabel6.TabIndex = 53
        Me.BunifuCustomLabel6.Text = "Endereço"
        '
        'lbl_contato
        '
        Me.lbl_contato.AutoSize = True
        Me.lbl_contato.BackColor = System.Drawing.Color.White
        Me.lbl_contato.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contato.Location = New System.Drawing.Point(298, 299)
        Me.lbl_contato.Name = "lbl_contato"
        Me.lbl_contato.Size = New System.Drawing.Size(41, 19)
        Me.lbl_contato.TabIndex = 61
        Me.lbl_contato.Text = "Nulo"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.Color.White
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(298, 263)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(41, 19)
        Me.lbl_nome.TabIndex = 60
        Me.lbl_nome.Text = "Nulo"
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.BackColor = System.Drawing.Color.White
        Me.lbl_endereco.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_endereco.Location = New System.Drawing.Point(298, 226)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(41, 19)
        Me.lbl_endereco.TabIndex = 59
        Me.lbl_endereco.Text = "Nulo"
        '
        'lbl_objeto
        '
        Me.lbl_objeto.AutoSize = True
        Me.lbl_objeto.BackColor = System.Drawing.Color.White
        Me.lbl_objeto.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_objeto.Location = New System.Drawing.Point(298, 183)
        Me.lbl_objeto.Name = "lbl_objeto"
        Me.lbl_objeto.Size = New System.Drawing.Size(41, 19)
        Me.lbl_objeto.TabIndex = 58
        Me.lbl_objeto.Text = "Nulo"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.BackColor = System.Drawing.Color.White
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo.Location = New System.Drawing.Point(298, 147)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(41, 19)
        Me.lbl_tipo.TabIndex = 57
        Me.lbl_tipo.Text = "Nulo"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.BackColor = System.Drawing.Color.White
        Me.lbl_data.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.Location = New System.Drawing.Point(298, 110)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(41, 19)
        Me.lbl_data.TabIndex = 56
        Me.lbl_data.Text = "Nulo"
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
        Me.btn_fechar.Location = New System.Drawing.Point(467, 30)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_fechar.selected = False
        Me.btn_fechar.Size = New System.Drawing.Size(42, 38)
        Me.btn_fechar.TabIndex = 65
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
        Me.btn_minimizar.Location = New System.Drawing.Point(425, 30)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_minimizar.selected = False
        Me.btn_minimizar.Size = New System.Drawing.Size(36, 38)
        Me.btn_minimizar.TabIndex = 64
        Me.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_minimizar.Textcolor = System.Drawing.Color.White
        Me.btn_minimizar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_voltar.Location = New System.Drawing.Point(196, 370)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(153, 41)
        Me.btn_voltar.TabIndex = 66
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.OrangeRed
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(245, 49)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(82, 35)
        Me.BunifuCustomLabel7.TabIndex = 67
        Me.BunifuCustomLabel7.Text = "Ficha"
        '
        'frm_agenda_mais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 450)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.lbl_contato)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.lbl_endereco)
        Me.Controls.Add(Me.lbl_objeto)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_agenda_mais"
        Me.Text = "frm_agenda_mais"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As ns1.BunifuCustomLabel
    Friend WithEvents lbl_contato As ns1.BunifuCustomLabel
    Friend WithEvents lbl_nome As ns1.BunifuCustomLabel
    Friend WithEvents lbl_endereco As ns1.BunifuCustomLabel
    Friend WithEvents lbl_objeto As ns1.BunifuCustomLabel
    Friend WithEvents lbl_tipo As ns1.BunifuCustomLabel
    Friend WithEvents lbl_data As ns1.BunifuCustomLabel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents btn_fechar As ns1.BunifuFlatButton
    Friend WithEvents btn_minimizar As ns1.BunifuFlatButton
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel7 As ns1.BunifuCustomLabel
End Class
