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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarContaeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Ficha = New System.Windows.Forms.TabPage()
        Me.Agenda = New System.Windows.Forms.TabPage()
        Me.TarefasDataGrid = New ns1.BunifuCustomDataGrid()
        Me.btn_modificar_tarefa = New System.Windows.Forms.Button()
        Me.btn_nova_tarefa = New System.Windows.Forms.Button()
        Me.Concluido = New System.Windows.Forms.TabPage()
        Me.ConcluidoDataGrid = New ns1.BunifuCustomDataGrid()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_nova_ficha = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Agenda.SuspendLayout()
        CType(Me.TarefasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Concluido.SuspendLayout()
        CType(Me.ConcluidoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Ficha.Location = New System.Drawing.Point(4, 22)
        Me.Ficha.Name = "Ficha"
        Me.Ficha.Padding = New System.Windows.Forms.Padding(3)
        Me.Ficha.Size = New System.Drawing.Size(460, 385)
        Me.Ficha.TabIndex = 0
        Me.Ficha.Text = "Ficha"
        Me.Ficha.UseVisualStyleBackColor = True
        '
        'Agenda
        '
        Me.Agenda.Controls.Add(Me.TarefasDataGrid)
        Me.Agenda.Controls.Add(Me.btn_modificar_tarefa)
        Me.Agenda.Controls.Add(Me.btn_nova_tarefa)
        Me.Agenda.Location = New System.Drawing.Point(4, 22)
        Me.Agenda.Name = "Agenda"
        Me.Agenda.Padding = New System.Windows.Forms.Padding(3)
        Me.Agenda.Size = New System.Drawing.Size(460, 385)
        Me.Agenda.TabIndex = 1
        Me.Agenda.Text = "Agenda"
        Me.Agenda.UseVisualStyleBackColor = True
        '
        'TarefasDataGrid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TarefasDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TarefasDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TarefasDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TarefasDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TarefasDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TarefasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TarefasDataGrid.DoubleBuffered = True
        Me.TarefasDataGrid.EnableHeadersVisualStyles = False
        Me.TarefasDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.TarefasDataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.TarefasDataGrid.Location = New System.Drawing.Point(6, 6)
        Me.TarefasDataGrid.Name = "TarefasDataGrid"
        Me.TarefasDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TarefasDataGrid.Size = New System.Drawing.Size(448, 309)
        Me.TarefasDataGrid.TabIndex = 2
        '
        'btn_modificar_tarefa
        '
        Me.btn_modificar_tarefa.Location = New System.Drawing.Point(223, 344)
        Me.btn_modificar_tarefa.Name = "btn_modificar_tarefa"
        Me.btn_modificar_tarefa.Size = New System.Drawing.Size(106, 23)
        Me.btn_modificar_tarefa.TabIndex = 1
        Me.btn_modificar_tarefa.Text = "Modificar Tarefa"
        Me.btn_modificar_tarefa.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ConcluidoDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ConcluidoDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.ConcluidoDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConcluidoDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConcluidoDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ConcluidoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConcluidoDataGrid.DoubleBuffered = True
        Me.ConcluidoDataGrid.EnableHeadersVisualStyles = False
        Me.ConcluidoDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.ConcluidoDataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.ConcluidoDataGrid.Location = New System.Drawing.Point(3, 3)
        Me.ConcluidoDataGrid.Name = "ConcluidoDataGrid"
        Me.ConcluidoDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(302, 269)
        Me.DataGridView1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(160, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 4
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
        'frm_menu_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_nova_ficha)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu_gerente"
        Me.Text = "frm_menu_gerente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Agenda.ResumeLayout(False)
        CType(Me.TarefasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Concluido.ResumeLayout(False)
        CType(Me.ConcluidoDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_nova_tarefa As Button
    Friend WithEvents TarefasDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents btn_modificar_tarefa As Button
    Friend WithEvents Concluido As TabPage
    Friend WithEvents ConcluidoDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents btn_nova_ficha As Button
End Class
