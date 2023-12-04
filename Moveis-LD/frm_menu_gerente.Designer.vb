<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu_gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_gerente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarContaeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Ficha = New System.Windows.Forms.TabPage()
        Me.btn_alterar = New ns1.BunifuThinButton2()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.lbl_cpf = New ns1.BunifuCustomLabel()
        Me.lbl_cod = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_objeto = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Agenda = New System.Windows.Forms.TabPage()
        Me.btn_nova_tarefa = New ns1.BunifuThinButton2()
        Me.AgendaDataGrid = New ns1.BunifuCustomDataGrid()
        Me.Concluido = New System.Windows.Forms.TabPage()
        Me.ConcluidoDataGrid = New ns1.BunifuCustomDataGrid()
        Me.desconcluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FichasDataGrid = New ns1.BunifuCustomDataGrid()
        Me.btn_nova_ficha = New ns1.BunifuThinButton2()
        Me.btn_fechar = New ns1.BunifuFlatButton()
        Me.btn_minimizar = New ns1.BunifuFlatButton()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Ficha.SuspendLayout()
        Me.Agenda.SuspendLayout()
        CType(Me.AgendaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Concluido.SuspendLayout()
        CType(Me.ConcluidoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FichasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem, Me.GerenciarContaeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(850, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(43, 23)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'GerenciarContaeToolStripMenuItem
        '
        Me.GerenciarContaeToolStripMenuItem.Name = "GerenciarContaeToolStripMenuItem"
        Me.GerenciarContaeToolStripMenuItem.Size = New System.Drawing.Size(123, 23)
        Me.GerenciarContaeToolStripMenuItem.Text = "Gerenciar contas"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Ficha)
        Me.TabControl1.Controls.Add(Me.Agenda)
        Me.TabControl1.Controls.Add(Me.Concluido)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(320, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(517, 436)
        Me.TabControl1.TabIndex = 1
        '
        'Ficha
        '
        Me.Ficha.Controls.Add(Me.btn_alterar)
        Me.Ficha.Controls.Add(Me.BunifuCustomLabel4)
        Me.Ficha.Controls.Add(Me.BunifuCustomLabel2)
        Me.Ficha.Controls.Add(Me.BunifuCustomLabel3)
        Me.Ficha.Controls.Add(Me.BunifuCustomLabel1)
        Me.Ficha.Controls.Add(Me.lbl_cpf)
        Me.Ficha.Controls.Add(Me.lbl_cod)
        Me.Ficha.Controls.Add(Me.txt_telefone)
        Me.Ficha.Controls.Add(Me.txt_total)
        Me.Ficha.Controls.Add(Me.txt_endereco)
        Me.Ficha.Controls.Add(Me.txt_objeto)
        Me.Ficha.Controls.Add(Me.txt_nome)
        Me.Ficha.Controls.Add(Me.Label2)
        Me.Ficha.Location = New System.Drawing.Point(4, 25)
        Me.Ficha.Name = "Ficha"
        Me.Ficha.Padding = New System.Windows.Forms.Padding(3)
        Me.Ficha.Size = New System.Drawing.Size(509, 407)
        Me.Ficha.TabIndex = 0
        Me.Ficha.Text = "Ficha"
        Me.Ficha.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.ActiveBorderThickness = 1
        Me.btn_alterar.ActiveCornerRadius = 20
        Me.btn_alterar.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_alterar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_alterar.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_alterar.BackColor = System.Drawing.Color.Transparent
        Me.btn_alterar.BackgroundImage = CType(resources.GetObject("btn_alterar.BackgroundImage"), System.Drawing.Image)
        Me.btn_alterar.ButtonText = "Alterar"
        Me.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alterar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_alterar.IdleBorderThickness = 1
        Me.btn_alterar.IdleCornerRadius = 20
        Me.btn_alterar.IdleFillColor = System.Drawing.Color.White
        Me.btn_alterar.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_alterar.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_alterar.Location = New System.Drawing.Point(332, 336)
        Me.btn_alterar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(153, 41)
        Me.btn_alterar.TabIndex = 29
        Me.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(16, 227)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(43, 19)
        Me.BunifuCustomLabel4.TabIndex = 28
        Me.BunifuCustomLabel4.Text = "Total"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(11, 183)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(67, 19)
        Me.BunifuCustomLabel2.TabIndex = 27
        Me.BunifuCustomLabel2.Text = "Telefone"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(11, 135)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(55, 19)
        Me.BunifuCustomLabel3.TabIndex = 26
        Me.BunifuCustomLabel3.Text = "Objeto"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(11, 87)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(71, 19)
        Me.BunifuCustomLabel1.TabIndex = 25
        Me.BunifuCustomLabel1.Text = "Endereço"
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(11, 39)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(50, 19)
        Me.lbl_cpf.TabIndex = 24
        Me.lbl_cpf.Text = "Nome"
        '
        'lbl_cod
        '
        Me.lbl_cod.AutoSize = True
        Me.lbl_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cod.Location = New System.Drawing.Point(423, 41)
        Me.lbl_cod.Name = "lbl_cod"
        Me.lbl_cod.Size = New System.Drawing.Size(43, 17)
        Me.lbl_cod.TabIndex = 19
        Me.lbl_cod.Text = "Vazio"
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(121, 180)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(163, 23)
        Me.txt_telefone.TabIndex = 18
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(121, 225)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 23)
        Me.txt_total.TabIndex = 17
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(121, 87)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(364, 23)
        Me.txt_endereco.TabIndex = 15
        '
        'txt_objeto
        '
        Me.txt_objeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_objeto.Location = New System.Drawing.Point(121, 133)
        Me.txt_objeto.Name = "txt_objeto"
        Me.txt_objeto.Size = New System.Drawing.Size(364, 23)
        Me.txt_objeto.TabIndex = 14
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(121, 38)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(222, 23)
        Me.txt_nome.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cód.:"
        '
        'Agenda
        '
        Me.Agenda.Controls.Add(Me.btn_nova_tarefa)
        Me.Agenda.Controls.Add(Me.AgendaDataGrid)
        Me.Agenda.Location = New System.Drawing.Point(4, 25)
        Me.Agenda.Name = "Agenda"
        Me.Agenda.Padding = New System.Windows.Forms.Padding(3)
        Me.Agenda.Size = New System.Drawing.Size(509, 407)
        Me.Agenda.TabIndex = 1
        Me.Agenda.Text = "Agenda"
        Me.Agenda.UseVisualStyleBackColor = True
        '
        'btn_nova_tarefa
        '
        Me.btn_nova_tarefa.ActiveBorderThickness = 1
        Me.btn_nova_tarefa.ActiveCornerRadius = 20
        Me.btn_nova_tarefa.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_nova_tarefa.ActiveForecolor = System.Drawing.Color.White
        Me.btn_nova_tarefa.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_nova_tarefa.BackColor = System.Drawing.Color.Transparent
        Me.btn_nova_tarefa.BackgroundImage = CType(resources.GetObject("btn_nova_tarefa.BackgroundImage"), System.Drawing.Image)
        Me.btn_nova_tarefa.ButtonText = "Nova Tarefa"
        Me.btn_nova_tarefa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nova_tarefa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nova_tarefa.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_nova_tarefa.IdleBorderThickness = 1
        Me.btn_nova_tarefa.IdleCornerRadius = 20
        Me.btn_nova_tarefa.IdleFillColor = System.Drawing.Color.White
        Me.btn_nova_tarefa.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_nova_tarefa.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_nova_tarefa.Location = New System.Drawing.Point(231, 333)
        Me.btn_nova_tarefa.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_nova_tarefa.Name = "btn_nova_tarefa"
        Me.btn_nova_tarefa.Size = New System.Drawing.Size(223, 41)
        Me.btn_nova_tarefa.TabIndex = 24
        Me.btn_nova_tarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgendaDataGrid
        '
        Me.AgendaDataGrid.AllowUserToAddRows = False
        Me.AgendaDataGrid.AllowUserToDeleteRows = False
        Me.AgendaDataGrid.AllowUserToOrderColumns = True
        Me.AgendaDataGrid.AllowUserToResizeColumns = False
        Me.AgendaDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AgendaDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AgendaDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.AgendaDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AgendaDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgendaDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AgendaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AgendaDataGrid.DoubleBuffered = True
        Me.AgendaDataGrid.EnableHeadersVisualStyles = False
        Me.AgendaDataGrid.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.AgendaDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.AgendaDataGrid.Location = New System.Drawing.Point(7, 6)
        Me.AgendaDataGrid.Name = "AgendaDataGrid"
        Me.AgendaDataGrid.ReadOnly = True
        Me.AgendaDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AgendaDataGrid.RowHeadersVisible = False
        Me.AgendaDataGrid.RowHeadersWidth = 62
        Me.AgendaDataGrid.Size = New System.Drawing.Size(497, 309)
        Me.AgendaDataGrid.TabIndex = 2
        '
        'Concluido
        '
        Me.Concluido.Controls.Add(Me.ConcluidoDataGrid)
        Me.Concluido.Location = New System.Drawing.Point(4, 25)
        Me.Concluido.Name = "Concluido"
        Me.Concluido.Size = New System.Drawing.Size(509, 407)
        Me.Concluido.TabIndex = 2
        Me.Concluido.Text = "Concluido"
        Me.Concluido.UseVisualStyleBackColor = True
        '
        'ConcluidoDataGrid
        '
        Me.ConcluidoDataGrid.AllowUserToAddRows = False
        Me.ConcluidoDataGrid.AllowUserToDeleteRows = False
        Me.ConcluidoDataGrid.AllowUserToResizeColumns = False
        Me.ConcluidoDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ConcluidoDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ConcluidoDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.ConcluidoDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConcluidoDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConcluidoDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ConcluidoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConcluidoDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.desconcluir})
        Me.ConcluidoDataGrid.DoubleBuffered = True
        Me.ConcluidoDataGrid.EnableHeadersVisualStyles = False
        Me.ConcluidoDataGrid.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.ConcluidoDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.ConcluidoDataGrid.Location = New System.Drawing.Point(3, 3)
        Me.ConcluidoDataGrid.Name = "ConcluidoDataGrid"
        Me.ConcluidoDataGrid.ReadOnly = True
        Me.ConcluidoDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ConcluidoDataGrid.RowHeadersVisible = False
        Me.ConcluidoDataGrid.RowHeadersWidth = 62
        Me.ConcluidoDataGrid.Size = New System.Drawing.Size(503, 379)
        Me.ConcluidoDataGrid.TabIndex = 0
        '
        'desconcluir
        '
        Me.desconcluir.HeaderText = ""
        Me.desconcluir.Image = CType(resources.GetObject("desconcluir.Image"), System.Drawing.Image)
        Me.desconcluir.MinimumWidth = 8
        Me.desconcluir.Name = "desconcluir"
        Me.desconcluir.ReadOnly = True
        Me.desconcluir.Width = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FichasDataGrid
        '
        Me.FichasDataGrid.AllowUserToAddRows = False
        Me.FichasDataGrid.AllowUserToDeleteRows = False
        Me.FichasDataGrid.AllowUserToResizeColumns = False
        Me.FichasDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FichasDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.FichasDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.FichasDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FichasDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FichasDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.FichasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FichasDataGrid.DoubleBuffered = True
        Me.FichasDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.FichasDataGrid.EnableHeadersVisualStyles = False
        Me.FichasDataGrid.HeaderBgColor = System.Drawing.Color.OrangeRed
        Me.FichasDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.FichasDataGrid.Location = New System.Drawing.Point(13, 179)
        Me.FichasDataGrid.MultiSelect = False
        Me.FichasDataGrid.Name = "FichasDataGrid"
        Me.FichasDataGrid.ReadOnly = True
        Me.FichasDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.FichasDataGrid.RowHeadersVisible = False
        Me.FichasDataGrid.RowHeadersWidth = 62
        Me.FichasDataGrid.ShowEditingIcon = False
        Me.FichasDataGrid.Size = New System.Drawing.Size(301, 284)
        Me.FichasDataGrid.TabIndex = 6
        '
        'btn_nova_ficha
        '
        Me.btn_nova_ficha.ActiveBorderThickness = 1
        Me.btn_nova_ficha.ActiveCornerRadius = 20
        Me.btn_nova_ficha.ActiveFillColor = System.Drawing.Color.OrangeRed
        Me.btn_nova_ficha.ActiveForecolor = System.Drawing.Color.White
        Me.btn_nova_ficha.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btn_nova_ficha.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nova_ficha.BackgroundImage = CType(resources.GetObject("btn_nova_ficha.BackgroundImage"), System.Drawing.Image)
        Me.btn_nova_ficha.ButtonText = "Nova Ficha"
        Me.btn_nova_ficha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nova_ficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nova_ficha.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_nova_ficha.IdleBorderThickness = 1
        Me.btn_nova_ficha.IdleCornerRadius = 20
        Me.btn_nova_ficha.IdleFillColor = System.Drawing.Color.White
        Me.btn_nova_ficha.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btn_nova_ficha.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btn_nova_ficha.Location = New System.Drawing.Point(163, 110)
        Me.btn_nova_ficha.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_nova_ficha.Name = "btn_nova_ficha"
        Me.btn_nova_ficha.Size = New System.Drawing.Size(153, 41)
        Me.btn_nova_ficha.TabIndex = 23
        Me.btn_nova_ficha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_fechar.Location = New System.Drawing.Point(807, 0)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_fechar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_fechar.selected = False
        Me.btn_fechar.Size = New System.Drawing.Size(29, 37)
        Me.btn_fechar.TabIndex = 25
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
        Me.btn_minimizar.Location = New System.Drawing.Point(767, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Normalcolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHovercolor = System.Drawing.Color.Empty
        Me.btn_minimizar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_minimizar.selected = False
        Me.btn_minimizar.Size = New System.Drawing.Size(34, 37)
        Me.btn_minimizar.TabIndex = 24
        Me.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_minimizar.Textcolor = System.Drawing.Color.White
        Me.btn_minimizar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frm_menu_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 475)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_nova_ficha)
        Me.Controls.Add(Me.FichasDataGrid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu_gerente"
        Me.Text = "frm_menu_gerente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Ficha.ResumeLayout(False)
        Me.Ficha.PerformLayout()
        Me.Agenda.ResumeLayout(False)
        CType(Me.AgendaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Concluido.ResumeLayout(False)
        CType(Me.ConcluidoDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FichasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GerenciarContaeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Ficha As TabPage
    Friend WithEvents Agenda As TabPage
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AgendaDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents Concluido As TabPage
    Friend WithEvents ConcluidoDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents FichasDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_objeto As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_cod As Label
    Friend WithEvents btn_nova_ficha As ns1.BunifuThinButton2
    Friend WithEvents lbl_cpf As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents btn_alterar As ns1.BunifuThinButton2
    Friend WithEvents btn_nova_tarefa As ns1.BunifuThinButton2
    Friend WithEvents btn_fechar As ns1.BunifuFlatButton
    Friend WithEvents btn_minimizar As ns1.BunifuFlatButton
    Friend WithEvents desconcluir As DataGridViewImageColumn
End Class
