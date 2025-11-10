namespace ControleClientess
{
    partial class GestaoOrdensForm
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
            tpConsultaGestao = new TabPage();
            tpCadastroGestao = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            btnPesquisarGestao = new Button();
            btnNovoGestao = new Button();
            btnVisualizarGestao = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            IdServico = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            DataAbertura = new DataGridViewTextBoxColumn();
            DataConclusao = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            txtDataConclusaoGestao = new TextBox();
            label4 = new Label();
            txtQuantidadeGestao = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            txtTotalGestao = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            btnExcluirGestao = new Button();
            btnCancelarGestao = new Button();
            btnSalvarGestao = new Button();
            tabControl1.SuspendLayout();
            tpConsultaGestao.SuspendLayout();
            tpCadastroGestao.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpConsultaGestao);
            tabControl1.Controls.Add(tpCadastroGestao);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(673, 347);
            tabControl1.TabIndex = 0;
            // 
            // tpConsultaGestao
            // 
            tpConsultaGestao.Controls.Add(panel3);
            tpConsultaGestao.Controls.Add(panel2);
            tpConsultaGestao.Controls.Add(panel1);
            tpConsultaGestao.Location = new Point(4, 24);
            tpConsultaGestao.Name = "tpConsultaGestao";
            tpConsultaGestao.Padding = new Padding(3);
            tpConsultaGestao.Size = new Size(665, 319);
            tpConsultaGestao.TabIndex = 0;
            tpConsultaGestao.Text = "Consulta";
            tpConsultaGestao.UseVisualStyleBackColor = true;
            // 
            // tpCadastroGestao
            // 
            tpCadastroGestao.Controls.Add(panel4);
            tpCadastroGestao.Controls.Add(txtTotalGestao);
            tpCadastroGestao.Controls.Add(label6);
            tpCadastroGestao.Controls.Add(comboBox2);
            tpCadastroGestao.Controls.Add(comboBox1);
            tpCadastroGestao.Controls.Add(label5);
            tpCadastroGestao.Controls.Add(txtDataConclusaoGestao);
            tpCadastroGestao.Controls.Add(label4);
            tpCadastroGestao.Controls.Add(textBox2);
            tpCadastroGestao.Controls.Add(label3);
            tpCadastroGestao.Controls.Add(txtQuantidadeGestao);
            tpCadastroGestao.Controls.Add(label2);
            tpCadastroGestao.Controls.Add(label1);
            tpCadastroGestao.Location = new Point(4, 24);
            tpCadastroGestao.Name = "tpCadastroGestao";
            tpCadastroGestao.Padding = new Padding(3);
            tpCadastroGestao.Size = new Size(665, 319);
            tpCadastroGestao.TabIndex = 1;
            tpCadastroGestao.Text = "Cadastro";
            tpCadastroGestao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPesquisarGestao);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 23);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(6, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 244);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVisualizarGestao);
            panel3.Controls.Add(btnNovoGestao);
            panel3.Location = new Point(6, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(632, 31);
            panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesquisar por nome";
            textBox1.Size = new Size(514, 23);
            textBox1.TabIndex = 4;
            // 
            // btnPesquisarGestao
            // 
            btnPesquisarGestao.Dock = DockStyle.Right;
            btnPesquisarGestao.Image = Properties.Resources.icons8_pesquisar_16;
            btnPesquisarGestao.Location = new Point(541, 0);
            btnPesquisarGestao.Name = "btnPesquisarGestao";
            btnPesquisarGestao.Size = new Size(91, 23);
            btnPesquisarGestao.TabIndex = 8;
            btnPesquisarGestao.Text = "&Pesquisar";
            btnPesquisarGestao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarGestao.UseVisualStyleBackColor = true;
            // 
            // btnNovoGestao
            // 
            btnNovoGestao.Dock = DockStyle.Right;
            btnNovoGestao.Image = Properties.Resources.icons8_soma_16;
            btnNovoGestao.Location = new Point(557, 0);
            btnNovoGestao.Name = "btnNovoGestao";
            btnNovoGestao.Size = new Size(75, 31);
            btnNovoGestao.TabIndex = 2;
            btnNovoGestao.Text = "&Novo";
            btnNovoGestao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovoGestao.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarGestao
            // 
            btnVisualizarGestao.Dock = DockStyle.Right;
            btnVisualizarGestao.Image = Properties.Resources.icons8_olhos_16__1_1;
            btnVisualizarGestao.Location = new Point(474, 0);
            btnVisualizarGestao.Name = "btnVisualizarGestao";
            btnVisualizarGestao.Size = new Size(83, 31);
            btnVisualizarGestao.TabIndex = 3;
            btnVisualizarGestao.Text = "&Visualizar";
            btnVisualizarGestao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizarGestao.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, IdCliente, IdServico, Preco, Quantidade, DataAbertura, DataConclusao, Total, Status });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(632, 244);
            dataGridView1.TabIndex = 5;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 42;
            // 
            // IdCliente
            // 
            IdCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdCliente.HeaderText = "Cliente";
            IdCliente.Name = "IdCliente";
            // 
            // IdServico
            // 
            IdServico.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdServico.HeaderText = "Servico";
            IdServico.Name = "IdServico";
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // DataAbertura
            // 
            DataAbertura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataAbertura.HeaderText = "Data de Abertura";
            DataAbertura.Name = "DataAbertura";
            // 
            // DataConclusao
            // 
            DataConclusao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataConclusao.HeaderText = "Data de Conclusão";
            DataConclusao.Name = "DataConclusao";
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // txtDataConclusaoGestao
            // 
            txtDataConclusaoGestao.Location = new Point(19, 143);
            txtDataConclusaoGestao.Name = "txtDataConclusaoGestao";
            txtDataConclusaoGestao.Size = new Size(242, 23);
            txtDataConclusaoGestao.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 125);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 18;
            label4.Text = "Data Conclusão";
            // 
            // txtQuantidadeGestao
            // 
            txtQuantidadeGestao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantidadeGestao.Location = new Point(15, 86);
            txtQuantidadeGestao.Name = "txtQuantidadeGestao";
            txtQuantidadeGestao.Size = new Size(246, 23);
            txtQuantidadeGestao.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 68);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 13;
            label2.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 12;
            label1.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 12);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 20;
            label5.Text = "Serviço";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 23);
            comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(288, 30);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(144, 23);
            comboBox2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 12);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 16;
            label3.Text = "Preço";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(460, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 17;
            // 
            // txtTotalGestao
            // 
            txtTotalGestao.Location = new Point(19, 201);
            txtTotalGestao.Name = "txtTotalGestao";
            txtTotalGestao.Size = new Size(242, 23);
            txtTotalGestao.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 183);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 23;
            label6.Text = "Total";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSalvarGestao);
            panel4.Controls.Add(btnCancelarGestao);
            panel4.Controls.Add(btnExcluirGestao);
            panel4.Location = new Point(0, 290);
            panel4.Name = "panel4";
            panel4.Size = new Size(665, 26);
            panel4.TabIndex = 25;
            // 
            // btnExcluirGestao
            // 
            btnExcluirGestao.Dock = DockStyle.Left;
            btnExcluirGestao.Image = Properties.Resources.trash;
            btnExcluirGestao.ImageAlign = ContentAlignment.BottomLeft;
            btnExcluirGestao.Location = new Point(0, 0);
            btnExcluirGestao.Name = "btnExcluirGestao";
            btnExcluirGestao.Size = new Size(68, 26);
            btnExcluirGestao.TabIndex = 8;
            btnExcluirGestao.Text = "&Excluir";
            btnExcluirGestao.TextAlign = ContentAlignment.TopRight;
            btnExcluirGestao.UseVisualStyleBackColor = true;
            // 
            // btnCancelarGestao
            // 
            btnCancelarGestao.Dock = DockStyle.Right;
            btnCancelarGestao.Image = Properties.Resources.icons8_cancelar_16;
            btnCancelarGestao.ImageAlign = ContentAlignment.BottomLeft;
            btnCancelarGestao.Location = new Point(587, 0);
            btnCancelarGestao.Name = "btnCancelarGestao";
            btnCancelarGestao.Size = new Size(78, 26);
            btnCancelarGestao.TabIndex = 10;
            btnCancelarGestao.Text = "&Cancelar";
            btnCancelarGestao.TextAlign = ContentAlignment.TopRight;
            btnCancelarGestao.UseVisualStyleBackColor = true;
            // 
            // btnSalvarGestao
            // 
            btnSalvarGestao.Dock = DockStyle.Right;
            btnSalvarGestao.Image = Properties.Resources.icons8_salvar_16;
            btnSalvarGestao.ImageAlign = ContentAlignment.BottomLeft;
            btnSalvarGestao.Location = new Point(523, 0);
            btnSalvarGestao.Name = "btnSalvarGestao";
            btnSalvarGestao.Size = new Size(64, 26);
            btnSalvarGestao.TabIndex = 11;
            btnSalvarGestao.Text = "&Salvar";
            btnSalvarGestao.TextAlign = ContentAlignment.TopRight;
            btnSalvarGestao.UseVisualStyleBackColor = true;
            // 
            // GestaoOrdensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 367);
            Controls.Add(tabControl1);
            Name = "GestaoOrdensForm";
            Text = "GestaoOrdensForm";
            tabControl1.ResumeLayout(false);
            tpConsultaGestao.ResumeLayout(false);
            tpCadastroGestao.ResumeLayout(false);
            tpCadastroGestao.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpConsultaGestao;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TabPage tpCadastroGestao;
        private TextBox textBox1;
        private Button btnPesquisarGestao;
        private Button btnNovoGestao;
        private Button btnVisualizarGestao;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn IdServico;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn DataAbertura;
        private DataGridViewTextBoxColumn DataConclusao;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Status;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtDataConclusaoGestao;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtQuantidadeGestao;
        private Label label2;
        private Label label1;
        private TextBox txtTotalGestao;
        private Label label6;
        private Panel panel4;
        private Button btnExcluirGestao;
        private Button btnCancelarGestao;
        private Button btnSalvarGestao;
    }
}