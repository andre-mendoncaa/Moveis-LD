﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adicionar_ficha))
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_contato = New System.Windows.Forms.TextBox()
        Me.txt_objeto = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New ns1.BunifuCustomLabel()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.btn_fechar = New ns1.BunifuFlatButton()
        Me.btn_minimizar = New ns1.BunifuFlatButton()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.btn_salvar = New ns1.BunifuThinButton2()
        Me.BunifuCustomLabel7 = New ns1.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(188, 98)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(297, 22)
        Me.txt_nome.TabIndex = 5
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(188, 144)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(297, 22)
        Me.txt_endereco.TabIndex = 6
        '
        'txt_contato
        '
        Me.txt_contato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contato.Location = New System.Drawing.Point(188, 190)
        Me.txt_contato.Name = "txt_contato"
        Me.txt_contato.Size = New System.Drawing.Size(297, 22)
        Me.txt_contato.TabIndex = 7
        '
        'txt_objeto
        '
        Me.txt_objeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_objeto.Location = New System.Drawing.Point(188, 237)
        Me.txt_objeto.Name = "txt_objeto"
        Me.txt_objeto.Size = New System.Drawing.Size(297, 22)
        Me.txt_objeto.TabIndex = 8
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(188, 285)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(297, 22)
        Me.txt_total.TabIndex = 9
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(102, 101)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(50, 19)
        Me.BunifuCustomLabel2.TabIndex = 50
        Me.BunifuCustomLabel2.Text = "Nome"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(99, 147)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(71, 19)
        Me.BunifuCustomLabel1.TabIndex = 51
        Me.BunifuCustomLabel1.Text = "Endereço"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(99, 193)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(62, 19)
        Me.BunifuCustomLabel3.TabIndex = 52
        Me.BunifuCustomLabel3.Text = "Contato"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(102, 237)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(55, 19)
        Me.BunifuCustomLabel4.TabIndex = 53
        Me.BunifuCustomLabel4.Text = "Objeto"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(99, 285)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(43, 19)
        Me.BunifuCustomLabel5.TabIndex = 54
        Me.BunifuCustomLabel5.Text = "Total"
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
        Me.btn_fechar.Location = New System.Drawing.Point(543, 25)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_fechar.selected = False
        Me.btn_fechar.Size = New System.Drawing.Size(42, 38)
        Me.btn_fechar.TabIndex = 67
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
        Me.btn_minimizar.Location = New System.Drawing.Point(501, 25)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_minimizar.selected = False
        Me.btn_minimizar.Size = New System.Drawing.Size(36, 38)
        Me.btn_minimizar.TabIndex = 66
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
        Me.btn_voltar.Location = New System.Drawing.Point(117, 341)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(153, 41)
        Me.btn_voltar.TabIndex = 68
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_salvar
        '
        Me.btn_salvar.ActiveBorderThickness = 1
        Me.btn_salvar.ActiveCornerRadius = 20
        Me.btn_salvar.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_salvar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_salvar.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_salvar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salvar.BackgroundImage = CType(resources.GetObject("btn_salvar.BackgroundImage"), System.Drawing.Image)
        Me.btn_salvar.ButtonText = "Salvar"
        Me.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_salvar.IdleBorderThickness = 1
        Me.btn_salvar.IdleCornerRadius = 20
        Me.btn_salvar.IdleFillColor = System.Drawing.Color.White
        Me.btn_salvar.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_salvar.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_salvar.Location = New System.Drawing.Point(345, 341)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(153, 41)
        Me.btn_salvar.TabIndex = 69
        Me.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.OrangeRed
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(214, 37)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(213, 35)
        Me.BunifuCustomLabel7.TabIndex = 70
        Me.BunifuCustomLabel7.Text = "Adicionar Ficha"
        '
        'frm_adicionar_ficha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 450)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_objeto)
        Me.Controls.Add(Me.txt_contato)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_nome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_adicionar_ficha"
        Me.Text = "frm_adicionar_ficha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_contato As TextBox
    Friend WithEvents txt_objeto As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents btn_fechar As ns1.BunifuFlatButton
    Friend WithEvents btn_minimizar As ns1.BunifuFlatButton
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
    Friend WithEvents btn_salvar As ns1.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel7 As ns1.BunifuCustomLabel
End Class
