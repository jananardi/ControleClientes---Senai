namespace ControleClientess
{
    partial class ServicoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            this.tpConsultaServico = new TabPage();
            tpCadastroServico = new TabPage();
            panel3 = new Panel();
            btnVisualizarServico = new Button();
            btnNovoServico = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnPesquisarServico = new Button();
            txtPesquisarServico = new TextBox();
            txtDescricaoServico = new TextBox();
            txtNomeServico = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            txtCategoriaServico = new TextBox();
            panel4 = new Panel();
            btnExcluirServico = new Button();
            btnCancelarServico = new Button();
            btnSalvarServico = new Button();
            tabControl1.SuspendLayout();
            this.tpConsultaServico.SuspendLayout();
            tpCadastroServico.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tpConsultaServico);
            tabControl1.Controls.Add(tpCadastroServico);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(645, 375);
            tabControl1.TabIndex = 3;
            // 
            // tpConsultaServico
            // 
            this.tpConsultaServico.Controls.Add(panel3);
            this.tpConsultaServico.Controls.Add(panel1);
            this.tpConsultaServico.Controls.Add(panel2);
            this.tpConsultaServico.Location = new Point(4, 24);
            this.tpConsultaServico.Name = "tpConsultaServico";
            this.tpConsultaServico.Padding = new Padding(3);
            this.tpConsultaServico.Size = new Size(637, 347);
            this.tpConsultaServico.TabIndex = 0;
            this.tpConsultaServico.Text = "Consulta";
            this.tpConsultaServico.UseVisualStyleBackColor = true;
            // 
            // tpCadastroServico
            // 
            tpCadastroServico.Controls.Add(panel4);
            tpCadastroServico.Controls.Add(txtCategoriaServico);
            tpCadastroServico.Controls.Add(label4);
            tpCadastroServico.Controls.Add(textBox1);
            tpCadastroServico.Controls.Add(label3);
            tpCadastroServico.Controls.Add(txtDescricaoServico);
            tpCadastroServico.Controls.Add(txtNomeServico);
            tpCadastroServico.Controls.Add(label2);
            tpCadastroServico.Controls.Add(label1);
            tpCadastroServico.Location = new Point(4, 24);
            tpCadastroServico.Name = "tpCadastroServico";
            tpCadastroServico.Padding = new Padding(3);
            tpCadastroServico.Size = new Size(637, 347);
            tpCadastroServico.TabIndex = 1;
            tpCadastroServico.Text = "Cadastro";
            tpCadastroServico.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVisualizarServico);
            panel3.Controls.Add(btnNovoServico);
            panel3.Location = new Point(6, 313);
            panel3.Name = "panel3";
            panel3.Size = new Size(627, 28);
            panel3.TabIndex = 5;
            // 
            // btnVisualizarServico
            // 
            btnVisualizarServico.Dock = DockStyle.Right;
            btnVisualizarServico.Image = Properties.Resources.icons8_olhos_16__1_1;
            btnVisualizarServico.Location = new Point(445, 0);
            btnVisualizarServico.Name = "btnVisualizarServico";
            btnVisualizarServico.Size = new Size(111, 28);
            btnVisualizarServico.TabIndex = 1;
            btnVisualizarServico.Text = "Visualizar";
            btnVisualizarServico.TextAlign = ContentAlignment.MiddleRight;
            btnVisualizarServico.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizarServico.UseVisualStyleBackColor = true;
            // 
            // btnNovoServico
            // 
            btnNovoServico.Dock = DockStyle.Right;
            btnNovoServico.Image = Properties.Resources.icons8_soma_16;
            btnNovoServico.Location = new Point(556, 0);
            btnNovoServico.Name = "btnNovoServico";
            btnNovoServico.Size = new Size(71, 28);
            btnNovoServico.TabIndex = 0;
            btnNovoServico.Text = "&Novo";
            btnNovoServico.TextAlign = ContentAlignment.MiddleRight;
            btnNovoServico.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovoServico.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(6, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 268);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao, Preco, Categoria });
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(622, 259);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 42;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Descricao
            // 
            Descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            // 
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPesquisarServico);
            panel2.Controls.Add(txtPesquisarServico);
            panel2.Location = new Point(7, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(627, 33);
            panel2.TabIndex = 4;
            // 
            // btnPesquisarServico
            // 
            btnPesquisarServico.BackgroundImageLayout = ImageLayout.None;
            btnPesquisarServico.Dock = DockStyle.Right;
            btnPesquisarServico.Image = Properties.Resources.icons8_pesquisar_16;
            btnPesquisarServico.Location = new Point(507, 0);
            btnPesquisarServico.Name = "btnPesquisarServico";
            btnPesquisarServico.Size = new Size(120, 33);
            btnPesquisarServico.TabIndex = 5;
            btnPesquisarServico.Text = "&Pesquisar";
            btnPesquisarServico.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarServico.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarServico.UseVisualStyleBackColor = true;
            // 
            // txtPesquisarServico
            // 
            txtPesquisarServico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisarServico.Location = new Point(3, 3);
            txtPesquisarServico.Name = "txtPesquisarServico";
            txtPesquisarServico.PlaceholderText = "Pesquisar por nome";
            txtPesquisarServico.Size = new Size(498, 23);
            txtPesquisarServico.TabIndex = 4;
            // 
            // txtDescricaoServico
            // 
            txtDescricaoServico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricaoServico.Location = new Point(7, 87);
            txtDescricaoServico.Name = "txtDescricaoServico";
            txtDescricaoServico.Size = new Size(595, 23);
            txtDescricaoServico.TabIndex = 7;
            // 
            // txtNomeServico
            // 
            txtNomeServico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeServico.Location = new Point(7, 31);
            txtNomeServico.Name = "txtNomeServico";
            txtNomeServico.Size = new Size(595, 23);
            txtNomeServico.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 69);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 13);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 132);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Preço";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 132);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Categoria";
            // 
            // txtCategoriaServico
            // 
            txtCategoriaServico.Location = new Point(195, 150);
            txtCategoriaServico.Name = "txtCategoriaServico";
            txtCategoriaServico.Size = new Size(407, 23);
            txtCategoriaServico.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSalvarServico);
            panel4.Controls.Add(btnCancelarServico);
            panel4.Controls.Add(btnExcluirServico);
            panel4.Location = new Point(0, 315);
            panel4.Name = "panel4";
            panel4.Size = new Size(631, 26);
            panel4.TabIndex = 12;
            // 
            // btnExcluirServico
            // 
            btnExcluirServico.Dock = DockStyle.Left;
            btnExcluirServico.Image = Properties.Resources.trash;
            btnExcluirServico.ImageAlign = ContentAlignment.BottomLeft;
            btnExcluirServico.Location = new Point(0, 0);
            btnExcluirServico.Name = "btnExcluirServico";
            btnExcluirServico.Size = new Size(68, 26);
            btnExcluirServico.TabIndex = 7;
            btnExcluirServico.Text = "&Excluir";
            btnExcluirServico.TextAlign = ContentAlignment.TopRight;
            btnExcluirServico.UseVisualStyleBackColor = true;
            // 
            // btnCancelarServico
            // 
            btnCancelarServico.Dock = DockStyle.Right;
            btnCancelarServico.Image = Properties.Resources.icons8_cancelar_16;
            btnCancelarServico.ImageAlign = ContentAlignment.BottomLeft;
            btnCancelarServico.Location = new Point(553, 0);
            btnCancelarServico.Name = "btnCancelarServico";
            btnCancelarServico.Size = new Size(78, 26);
            btnCancelarServico.TabIndex = 9;
            btnCancelarServico.Text = "&Cancelar";
            btnCancelarServico.TextAlign = ContentAlignment.TopRight;
            btnCancelarServico.UseVisualStyleBackColor = true;
            // 
            // btnSalvarServico
            // 
            btnSalvarServico.Dock = DockStyle.Right;
            btnSalvarServico.Image = Properties.Resources.icons8_salvar_16;
            btnSalvarServico.ImageAlign = ContentAlignment.BottomLeft;
            btnSalvarServico.Location = new Point(489, 0);
            btnSalvarServico.Name = "btnSalvarServico";
            btnSalvarServico.Size = new Size(64, 26);
            btnSalvarServico.TabIndex = 10;
            btnSalvarServico.Text = "&Salvar";
            btnSalvarServico.TextAlign = ContentAlignment.TopRight;
            btnSalvarServico.UseVisualStyleBackColor = true;
            // 
            // ServicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 373);
            Controls.Add(tabControl1);
            Name = "ServicoForm";
            Text = "ServicoForm";
            tabControl1.ResumeLayout(false);
            this.tpConsultaServico.ResumeLayout(false);
            tpCadastroServico.ResumeLayout(false);
            tpCadastroServico.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tpCadastroServico;
        private Panel panel3;
        private Button btnVisualizarServico;
        private Button btnNovoServico;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Categoria;
        private Panel panel2;
        private Button btnPesquisarServico;
        private TextBox txtPesquisarServico;
        private TextBox txtDescricaoServico;
        private TextBox txtNomeServico;
        private Label label2;
        private Label label1;
        private TextBox txtCategoriaServico;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Panel panel4;
        private Button btnExcluirServico;
        private Button btnCancelarServico;
        private Button btnSalvarServico;
    }
}