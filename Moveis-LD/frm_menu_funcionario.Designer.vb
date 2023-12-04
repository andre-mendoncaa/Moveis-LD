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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AfazeresDataGrid = New ns1.BunifuCustomDataGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ConcluidosDataGrid = New ns1.BunifuCustomDataGrid()
        Me.ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_alterar_senha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AfazeresDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ConcluidosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AfazeresDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AfazeresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AfazeresDataGrid.DoubleBuffered = True
        Me.AfazeresDataGrid.EnableHeadersVisualStyles = False
        Me.AfazeresDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.AfazeresDataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConcluidosDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ConcluidosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConcluidosDataGrid.DoubleBuffered = True
        Me.ConcluidosDataGrid.EnableHeadersVisualStyles = False
        Me.ConcluidosDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.ConcluidosDataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.ConcluidosDataGrid.Location = New System.Drawing.Point(6, 6)
        Me.ConcluidosDataGrid.Name = "ConcluidosDataGrid"
        Me.ConcluidosDataGrid.ReadOnly = True
        Me.ConcluidosDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 142)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(28, 396)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(120, 41)
        Me.btn_sair.TabIndex = 10
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_alterar_senha
        '
        Me.btn_alterar_senha.Location = New System.Drawing.Point(28, 349)
        Me.btn_alterar_senha.Name = "btn_alterar_senha"
        Me.btn_alterar_senha.Size = New System.Drawing.Size(120, 41)
        Me.btn_alterar_senha.TabIndex = 9
        Me.btn_alterar_senha.Text = "Alterar Senha"
        Me.btn_alterar_senha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Bem vindo,"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(69, 206)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(33, 13)
        Me.lbl_nome.TabIndex = 12
        Me.lbl_nome.Text = "Vazio"
        '
        'frm_menu_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 450)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_alterar_senha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_menu_funcionario"
        Me.Text = "frm_menu_funcionario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.AfazeresDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ConcluidosDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_alterar_senha As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nome As Label
End Class
