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
            tcServicos = new TabControl();
            tpConsultaServico = new TabPage();
            panel3 = new Panel();
            btnServicoNovo = new Button();
            btnServicosVisualizar = new Button();
            panel2 = new Panel();
            gridServico = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnServicoPesquisar = new Button();
            textBox1 = new TextBox();
            tpCadastroServico = new TabPage();
            panel4 = new Panel();
            btnExcluirServico = new Button();
            btnSalvarServico = new Button();
            btnCancelarServico = new Button();
            txtServicoCategoria = new TextBox();
            txtServicoPreco = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtServicoDescricao = new TextBox();
            label2 = new Label();
            txtServicoNome = new TextBox();
            label1 = new Label();
            tcServicos.SuspendLayout();
            tpConsultaServico.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridServico).BeginInit();
            panel1.SuspendLayout();
            tpCadastroServico.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tcServicos
            // 
            tcServicos.Controls.Add(tpConsultaServico);
            tcServicos.Controls.Add(tpCadastroServico);
            tcServicos.Location = new Point(-3, -20);
            tcServicos.Name = "tcServicos";
            tcServicos.SelectedIndex = 0;
            tcServicos.Size = new Size(590, 341);
            tcServicos.TabIndex = 0;
            // 
            // tpConsultaServico
            // 
            tpConsultaServico.Controls.Add(panel3);
            tpConsultaServico.Controls.Add(panel2);
            tpConsultaServico.Controls.Add(panel1);
            tpConsultaServico.Location = new Point(4, 24);
            tpConsultaServico.Name = "tpConsultaServico";
            tpConsultaServico.Padding = new Padding(3);
            tpConsultaServico.Size = new Size(582, 313);
            tpConsultaServico.TabIndex = 0;
            tpConsultaServico.Text = "Consulta";
            tpConsultaServico.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btnServicoNovo);
            panel3.Controls.Add(btnServicosVisualizar);
            panel3.Location = new Point(9, 272);
            panel3.Name = "panel3";
            panel3.Size = new Size(563, 32);
            panel3.TabIndex = 2;
            // 
            // btnServicoNovo
            // 
            btnServicoNovo.Dock = DockStyle.Right;
            btnServicoNovo.Image = Properties.Resources.icons8_soma_16;
            btnServicoNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicoNovo.Location = new Point(405, 0);
            btnServicoNovo.Name = "btnServicoNovo";
            btnServicoNovo.Size = new Size(75, 32);
            btnServicoNovo.TabIndex = 1;
            btnServicoNovo.Text = "&Novo";
            btnServicoNovo.UseVisualStyleBackColor = true;
            btnServicoNovo.Click += btnServicoNovo_Click;
            // 
            // btnServicosVisualizar
            // 
            btnServicosVisualizar.Dock = DockStyle.Right;
            btnServicosVisualizar.Image = Properties.Resources.icons8_olhos_16__1_1;
            btnServicosVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicosVisualizar.Location = new Point(480, 0);
            btnServicosVisualizar.Name = "btnServicosVisualizar";
            btnServicosVisualizar.Size = new Size(83, 32);
            btnServicosVisualizar.TabIndex = 0;
            btnServicosVisualizar.Text = "&Visualizar";
            btnServicosVisualizar.TextAlign = ContentAlignment.MiddleRight;
            btnServicosVisualizar.UseVisualStyleBackColor = true;
            btnServicosVisualizar.Click += btnServicosVisualizar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(gridServico);
            panel2.Location = new Point(6, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 226);
            panel2.TabIndex = 1;
            // 
            // gridServico
            // 
            gridServico.AllowUserToAddRows = false;
            gridServico.AllowUserToDeleteRows = false;
            gridServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridServico.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao, Preco, Categoria });
            gridServico.Dock = DockStyle.Fill;
            gridServico.Location = new Point(0, 0);
            gridServico.Name = "gridServico";
            gridServico.ReadOnly = true;
            gridServico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridServico.Size = new Size(566, 226);
            gridServico.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Preco.DataPropertyName = "Preco";
            Preco.HeaderText = "Preco";
            Preco.Name = "Preco";
            Preco.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnServicoPesquisar);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 28);
            panel1.TabIndex = 0;
            // 
            // btnServicoPesquisar
            // 
            btnServicoPesquisar.Dock = DockStyle.Right;
            btnServicoPesquisar.Image = Properties.Resources.icons8_pesquisar_16;
            btnServicoPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicoPesquisar.Location = new Point(483, 0);
            btnServicoPesquisar.Name = "btnServicoPesquisar";
            btnServicoPesquisar.Size = new Size(83, 28);
            btnServicoPesquisar.TabIndex = 10;
            btnServicoPesquisar.Text = "&Pesquisar";
            btnServicoPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnServicoPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesquisar por nome";
            textBox1.Size = new Size(464, 23);
            textBox1.TabIndex = 9;
            // 
            // tpCadastroServico
            // 
            tpCadastroServico.Controls.Add(panel4);
            tpCadastroServico.Controls.Add(txtServicoCategoria);
            tpCadastroServico.Controls.Add(txtServicoPreco);
            tpCadastroServico.Controls.Add(label4);
            tpCadastroServico.Controls.Add(label3);
            tpCadastroServico.Controls.Add(txtServicoDescricao);
            tpCadastroServico.Controls.Add(label2);
            tpCadastroServico.Controls.Add(txtServicoNome);
            tpCadastroServico.Controls.Add(label1);
            tpCadastroServico.Location = new Point(4, 24);
            tpCadastroServico.Name = "tpCadastroServico";
            tpCadastroServico.Padding = new Padding(3);
            tpCadastroServico.Size = new Size(582, 313);
            tpCadastroServico.TabIndex = 1;
            tpCadastroServico.Text = "Cadastro";
            tpCadastroServico.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(btnExcluirServico);
            panel4.Controls.Add(btnSalvarServico);
            panel4.Controls.Add(btnCancelarServico);
            panel4.Location = new Point(0, 287);
            panel4.Name = "panel4";
            panel4.Size = new Size(575, 24);
            panel4.TabIndex = 8;
            // 
            // btnExcluirServico
            // 
            btnExcluirServico.Dock = DockStyle.Left;
            btnExcluirServico.Image = Properties.Resources.trash;
            btnExcluirServico.ImageAlign = ContentAlignment.BottomLeft;
            btnExcluirServico.Location = new Point(0, 0);
            btnExcluirServico.Name = "btnExcluirServico";
            btnExcluirServico.Size = new Size(68, 24);
            btnExcluirServico.TabIndex = 14;
            btnExcluirServico.Text = "&Excluir";
            btnExcluirServico.TextAlign = ContentAlignment.TopRight;
            btnExcluirServico.UseVisualStyleBackColor = true;
            btnExcluirServico.Click += btnExcluirServico_Click;
            // 
            // btnSalvarServico
            // 
            btnSalvarServico.Dock = DockStyle.Right;
            btnSalvarServico.Image = Properties.Resources.icons8_salvar_16;
            btnSalvarServico.ImageAlign = ContentAlignment.BottomLeft;
            btnSalvarServico.Location = new Point(433, 0);
            btnSalvarServico.Name = "btnSalvarServico";
            btnSalvarServico.Size = new Size(64, 24);
            btnSalvarServico.TabIndex = 13;
            btnSalvarServico.Text = "&Salvar";
            btnSalvarServico.TextAlign = ContentAlignment.TopRight;
            btnSalvarServico.UseVisualStyleBackColor = true;
            btnSalvarServico.Click += btnSalvarServico_Click;
            // 
            // btnCancelarServico
            // 
            btnCancelarServico.Dock = DockStyle.Right;
            btnCancelarServico.Image = Properties.Resources.icons8_cancelar_16;
            btnCancelarServico.ImageAlign = ContentAlignment.BottomLeft;
            btnCancelarServico.Location = new Point(497, 0);
            btnCancelarServico.Name = "btnCancelarServico";
            btnCancelarServico.Size = new Size(78, 24);
            btnCancelarServico.TabIndex = 12;
            btnCancelarServico.Text = "&Cancelar";
            btnCancelarServico.TextAlign = ContentAlignment.TopRight;
            btnCancelarServico.UseVisualStyleBackColor = true;
            btnCancelarServico.Click += btnCancelarServico_Click;
            // 
            // txtServicoCategoria
            // 
            txtServicoCategoria.Location = new Point(260, 146);
            txtServicoCategoria.Name = "txtServicoCategoria";
            txtServicoCategoria.Size = new Size(294, 23);
            txtServicoCategoria.TabIndex = 7;
            // 
            // txtServicoPreco
            // 
            txtServicoPreco.Location = new Point(21, 146);
            txtServicoPreco.Name = "txtServicoPreco";
            txtServicoPreco.Size = new Size(164, 23);
            txtServicoPreco.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 128);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 5;
            label4.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 128);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Categoria";
            // 
            // txtServicoDescricao
            // 
            txtServicoDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtServicoDescricao.Location = new Point(21, 92);
            txtServicoDescricao.Name = "txtServicoDescricao";
            txtServicoDescricao.Size = new Size(533, 23);
            txtServicoDescricao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // txtServicoNome
            // 
            txtServicoNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtServicoNome.Location = new Point(21, 37);
            txtServicoNome.Name = "txtServicoNome";
            txtServicoNome.Size = new Size(533, 23);
            txtServicoNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // ServicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 318);
            Controls.Add(tcServicos);
            Name = "ServicoForm";
            Text = "ServicoForm";
            tcServicos.ResumeLayout(false);
            tpConsultaServico.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridServico).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpCadastroServico.ResumeLayout(false);
            tpCadastroServico.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tcServicos;
        private TabPage tpConsultaServico;
        private Panel panel3;
        private Button btnVisualizarServico;
        private Button btnNovoServico;
        private Label label1;
        private TextBox txtServicoDescricao;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private TextBox txtServicoCategoria;
        private TextBox txtServicoPreco;
        private Button btnCancelarServico;
        private Button btnSalvarServico;
        private Button btnExcluirServico;
        private Panel panel1;
        private DataGridView gridServico;
        private Panel panel2;
        private Button btnPesquisarServico;
        private TextBox txtPesquisarServico;
        private Panel panel5;
        private TextBox txtServicoNome;
        private Button btnPesquisarServicos;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private DataGridView dbServico;
        private Button btnVisualizarServicos;
        private Button btnNovoServicos;
        private TabPage tpCadastroServico;
        private TextBox textBox1;
        private Button btnServicoNovo;
        private Button btnServicosVisualizar;
        private Button btnServicoPesquisar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Categoria;
    }
}