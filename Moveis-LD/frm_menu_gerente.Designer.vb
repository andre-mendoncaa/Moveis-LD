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
        Me.lbl_cod = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_objeto = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Agenda = New System.Windows.Forms.TabPage()
        Me.AgendaDataGrid = New ns1.BunifuCustomDataGrid()
        Me.btn_nova_tarefa = New System.Windows.Forms.Button()
        Me.Concluido = New System.Windows.Forms.TabPage()
        Me.ConcluidoDataGrid = New ns1.BunifuCustomDataGrid()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_nova_ficha = New System.Windows.Forms.Button()
        Me.FichasDataGrid = New ns1.BunifuCustomDataGrid()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem, Me.GerenciarContaeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'GerenciarContaeToolStripMenuItem
        '
        Me.GerenciarContaeToolStripMenuItem.Name = "GerenciarContaeToolStripMenuItem"
        Me.GerenciarContaeToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.GerenciarContaeToolStripMenuItem.Text = "Gerenciar contas"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Ficha)
        Me.TabControl1.Controls.Add(Me.Agenda)
        Me.TabControl1.Controls.Add(Me.Concluido)
        Me.TabControl1.Location = New System.Drawing.Point(320, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(468, 411)
        Me.TabControl1.TabIndex = 1
        '
        'Ficha
        '
        Me.Ficha.Controls.Add(Me.lbl_cod)
        Me.Ficha.Controls.Add(Me.txt_telefone)
        Me.Ficha.Controls.Add(Me.txt_total)
        Me.Ficha.Controls.Add(Me.txt_objeto)
        Me.Ficha.Controls.Add(Me.txt_endereco)
        Me.Ficha.Controls.Add(Me.txt_nome)
        Me.Ficha.Controls.Add(Me.btn_alterar)
        Me.Ficha.Controls.Add(Me.Label7)
        Me.Ficha.Controls.Add(Me.Label5)
        Me.Ficha.Controls.Add(Me.Label4)
        Me.Ficha.Controls.Add(Me.Label3)
        Me.Ficha.Controls.Add(Me.Label2)
        Me.Ficha.Controls.Add(Me.Label1)
        Me.Ficha.Location = New System.Drawing.Point(4, 22)
        Me.Ficha.Name = "Ficha"
        Me.Ficha.Padding = New System.Windows.Forms.Padding(3)
        Me.Ficha.Size = New System.Drawing.Size(460, 385)
        Me.Ficha.TabIndex = 0
        Me.Ficha.Text = "Ficha"
        Me.Ficha.UseVisualStyleBackColor = True
        '
        'lbl_cod
        '
        Me.lbl_cod.AutoSize = True
        Me.lbl_cod.Location = New System.Drawing.Point(364, 40)
        Me.lbl_cod.Name = "lbl_cod"
        Me.lbl_cod.Size = New System.Drawing.Size(33, 13)
        Me.lbl_cod.TabIndex = 19
        Me.lbl_cod.Text = "Vazio"
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(75, 195)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(163, 20)
        Me.txt_telefone.TabIndex = 18
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(75, 251)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 17
        '
        'txt_objeto
        '
        Me.txt_objeto.Location = New System.Drawing.Point(75, 87)
        Me.txt_objeto.Name = "txt_objeto"
        Me.txt_objeto.Size = New System.Drawing.Size(364, 20)
        Me.txt_objeto.TabIndex = 15
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(75, 138)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(364, 20)
        Me.txt_endereco.TabIndex = 14
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(75, 37)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(222, 20)
        Me.txt_nome.TabIndex = 13
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(364, 344)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(75, 23)
        Me.btn_alterar.TabIndex = 12
        Me.btn_alterar.Text = "Alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Objeto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Endereço:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cód.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Agenda
        '
        Me.Agenda.Controls.Add(Me.AgendaDataGrid)
        Me.Agenda.Controls.Add(Me.btn_nova_tarefa)
        Me.Agenda.Location = New System.Drawing.Point(4, 22)
        Me.Agenda.Name = "Agenda"
        Me.Agenda.Padding = New System.Windows.Forms.Padding(3)
        Me.Agenda.Size = New System.Drawing.Size(460, 385)
        Me.Agenda.TabIndex = 1
        Me.Agenda.Text = "Agenda"
        Me.Agenda.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgendaDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AgendaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AgendaDataGrid.DoubleBuffered = True
        Me.AgendaDataGrid.EnableHeadersVisualStyles = False
        Me.AgendaDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.AgendaDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.AgendaDataGrid.Location = New System.Drawing.Point(6, 6)
        Me.AgendaDataGrid.Name = "AgendaDataGrid"
        Me.AgendaDataGrid.ReadOnly = True
        Me.AgendaDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AgendaDataGrid.RowHeadersVisible = False
        Me.AgendaDataGrid.Size = New System.Drawing.Size(448, 309)
        Me.AgendaDataGrid.TabIndex = 2
        '
        'btn_nova_tarefa
        '
        Me.btn_nova_tarefa.Location = New System.Drawing.Point(356, 344)
        Me.btn_nova_tarefa.Name = "btn_nova_tarefa"
        Me.btn_nova_tarefa.Size = New System.Drawing.Size(81, 23)
        Me.btn_nova_tarefa.TabIndex = 0
        Me.btn_nova_tarefa.Text = "Nova Tarefa"
        Me.btn_nova_tarefa.UseVisualStyleBackColor = True
        '
        'Concluido
        '
        Me.Concluido.Controls.Add(Me.ConcluidoDataGrid)
        Me.Concluido.Location = New System.Drawing.Point(4, 22)
        Me.Concluido.Name = "Concluido"
        Me.Concluido.Size = New System.Drawing.Size(460, 385)
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConcluidoDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ConcluidoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConcluidoDataGrid.DoubleBuffered = True
        Me.ConcluidoDataGrid.EnableHeadersVisualStyles = False
        Me.ConcluidoDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.ConcluidoDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.ConcluidoDataGrid.Location = New System.Drawing.Point(3, 3)
        Me.ConcluidoDataGrid.Name = "ConcluidoDataGrid"
        Me.ConcluidoDataGrid.ReadOnly = True
        Me.ConcluidoDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ConcluidoDataGrid.RowHeadersVisible = False
        Me.ConcluidoDataGrid.Size = New System.Drawing.Size(454, 379)
        Me.ConcluidoDataGrid.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 136)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btn_nova_ficha
        '
        Me.btn_nova_ficha.Location = New System.Drawing.Point(196, 79)
        Me.btn_nova_ficha.Name = "btn_nova_ficha"
        Me.btn_nova_ficha.Size = New System.Drawing.Size(75, 23)
        Me.btn_nova_ficha.TabIndex = 5
        Me.btn_nova_ficha.Text = "Nova Ficha"
        Me.btn_nova_ficha.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen
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
        Me.FichasDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.FichasDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.FichasDataGrid.Location = New System.Drawing.Point(13, 179)
        Me.FichasDataGrid.MultiSelect = False
        Me.FichasDataGrid.Name = "FichasDataGrid"
        Me.FichasDataGrid.ReadOnly = True
        Me.FichasDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.FichasDataGrid.RowHeadersVisible = False
        Me.FichasDataGrid.ShowEditingIcon = False
        Me.FichasDataGrid.Size = New System.Drawing.Size(301, 255)
        Me.FichasDataGrid.TabIndex = 6
        '
        'frm_menu_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FichasDataGrid)
        Me.Controls.Add(Me.btn_nova_ficha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
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
    Friend WithEvents btn_nova_tarefa As Button
    Friend WithEvents AgendaDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents Concluido As TabPage
    Friend WithEvents ConcluidoDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents btn_nova_ficha As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FichasDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_alterar As Button
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_objeto As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_cod As Label
End Class
