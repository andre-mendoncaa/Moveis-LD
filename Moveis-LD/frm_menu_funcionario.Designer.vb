<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu_funcionario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_funcionario))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AfazeresDataGrid = New ns1.BunifuCustomDataGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ConcluidosDataGrid = New ns1.BunifuCustomDataGrid()
        Me.ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.btn_fechar = New ns1.BunifuFlatButton()
        Me.btn_minimizar = New ns1.BunifuFlatButton()
        Me.btn_alterar_senha = New ns1.BunifuThinButton2()
        Me.btn_sair = New ns1.BunifuThinButton2()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AfazeresDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ConcluidosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(175, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(459, 428)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AfazeresDataGrid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(451, 402)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Afazeres"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AfazeresDataGrid
        '
        Me.AfazeresDataGrid.AllowUserToAddRows = False
        Me.AfazeresDataGrid.AllowUserToDeleteRows = False
        Me.AfazeresDataGrid.AllowUserToResizeColumns = False
        Me.AfazeresDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AfazeresDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AfazeresDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.AfazeresDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AfazeresDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AfazeresDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AfazeresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AfazeresDataGrid.DoubleBuffered = True
        Me.AfazeresDataGrid.EnableHeadersVisualStyles = False
        Me.AfazeresDataGrid.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.AfazeresDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.AfazeresDataGrid.Location = New System.Drawing.Point(6, 6)
        Me.AfazeresDataGrid.Name = "AfazeresDataGrid"
        Me.AfazeresDataGrid.ReadOnly = True
        Me.AfazeresDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AfazeresDataGrid.RowHeadersVisible = False
        Me.AfazeresDataGrid.Size = New System.Drawing.Size(439, 375)
        Me.AfazeresDataGrid.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ConcluidosDataGrid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(451, 402)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Concluídos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ConcluidosDataGrid
        '
        Me.ConcluidosDataGrid.AllowUserToAddRows = False
        Me.ConcluidosDataGrid.AllowUserToDeleteRows = False
        Me.ConcluidosDataGrid.AllowUserToResizeColumns = False
        Me.ConcluidosDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ConcluidosDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ConcluidosDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.ConcluidosDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConcluidosDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConcluidosDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ConcluidosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConcluidosDataGrid.DoubleBuffered = True
        Me.ConcluidosDataGrid.EnableHeadersVisualStyles = False
        Me.ConcluidosDataGrid.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.ConcluidosDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.ConcluidosDataGrid.Location = New System.Drawing.Point(6, 6)
        Me.ConcluidosDataGrid.Name = "ConcluidosDataGrid"
        Me.ConcluidosDataGrid.ReadOnly = True
        Me.ConcluidosDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ConcluidosDataGrid.RowHeadersVisible = False
        Me.ConcluidosDataGrid.Size = New System.Drawing.Size(439, 375)
        Me.ConcluidosDataGrid.TabIndex = 0
        '
        'ver
        '
        Me.ver.HeaderText = ""
        Me.ver.Name = "ver"
        Me.ver.ReadOnly = True
        Me.ver.Text = "+"
        Me.ver.UseColumnTextForButtonValue = True
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "+"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Bem vindo,"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(92, 206)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(41, 16)
        Me.lbl_nome.TabIndex = 12
        Me.lbl_nome.Text = "Vazio"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(171, 142)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
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
        Me.btn_fechar.Location = New System.Drawing.Point(582, -4)
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
        Me.btn_minimizar.Location = New System.Drawing.Point(540, -4)
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
        'btn_alterar_senha
        '
        Me.btn_alterar_senha.ActiveBorderThickness = 1
        Me.btn_alterar_senha.ActiveCornerRadius = 20
        Me.btn_alterar_senha.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_alterar_senha.ActiveForecolor = System.Drawing.Color.White
        Me.btn_alterar_senha.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_alterar_senha.BackColor = System.Drawing.SystemColors.Control
        Me.btn_alterar_senha.BackgroundImage = CType(resources.GetObject("btn_alterar_senha.BackgroundImage"), System.Drawing.Image)
        Me.btn_alterar_senha.ButtonText = "Alterar Senha"
        Me.btn_alterar_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alterar_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alterar_senha.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_alterar_senha.IdleBorderThickness = 1
        Me.btn_alterar_senha.IdleCornerRadius = 20
        Me.btn_alterar_senha.IdleFillColor = System.Drawing.Color.White
        Me.btn_alterar_senha.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_alterar_senha.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_alterar_senha.Location = New System.Drawing.Point(14, 324)
        Me.btn_alterar_senha.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_alterar_senha.Name = "btn_alterar_senha"
        Me.btn_alterar_senha.Size = New System.Drawing.Size(153, 41)
        Me.btn_alterar_senha.TabIndex = 69
        Me.btn_alterar_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_sair
        '
        Me.btn_sair.ActiveBorderThickness = 1
        Me.btn_sair.ActiveCornerRadius = 20
        Me.btn_sair.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_sair.ActiveForecolor = System.Drawing.Color.White
        Me.btn_sair.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_sair.BackColor = System.Drawing.SystemColors.Control
        Me.btn_sair.BackgroundImage = CType(resources.GetObject("btn_sair.BackgroundImage"), System.Drawing.Image)
        Me.btn_sair.ButtonText = "Sair"
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_sair.IdleBorderThickness = 1
        Me.btn_sair.IdleCornerRadius = 20
        Me.btn_sair.IdleFillColor = System.Drawing.Color.White
        Me.btn_sair.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_sair.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_sair.Location = New System.Drawing.Point(14, 375)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(153, 41)
        Me.btn_sair.TabIndex = 70
        Me.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_menu_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 450)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_alterar_senha)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_menu_funcionario"
        Me.Text = "frm_menu_funcionario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.AfazeresDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ConcluidosDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ver As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents AfazeresDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents ConcluidosDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents btn_fechar As ns1.BunifuFlatButton
    Friend WithEvents btn_minimizar As ns1.BunifuFlatButton
    Friend WithEvents btn_alterar_senha As ns1.BunifuThinButton2
    Friend WithEvents btn_sair As ns1.BunifuThinButton2
End Class
