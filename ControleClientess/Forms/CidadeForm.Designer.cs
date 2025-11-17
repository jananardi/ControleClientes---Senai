namespace ControleClientess
{
    partial class CidadeForm
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
            tcCidade = new TabControl();
            tpConsultaCidade = new TabPage();
            panel3 = new Panel();
            txtPesquisarCidade = new TextBox();
            btnPesquisarCidade = new Button();
            panel2 = new Panel();
            btnNovoCidade = new Button();
            btnVisualizarCidade = new Button();
            panel1 = new Panel();
            gridCidades = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colUF = new DataGridViewTextBoxColumn();
            tpCadastroCidade = new TabPage();
            panel4 = new Panel();
            btnSalvarCidade = new Button();
            btnCancelarCidade = new Button();
            btnExcluirCidade = new Button();
            txtNomeCidade = new TextBox();
            txtUFCidade = new TextBox();
            label = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tcCidade.SuspendLayout();
            tpConsultaCidade.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCidades).BeginInit();
            tpCadastroCidade.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tcCidade
            // 
            tcCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCidade.Controls.Add(tpConsultaCidade);
            tcCidade.Controls.Add(tpCadastroCidade);
            tcCidade.Location = new Point(-3, -23);
            tcCidade.Name = "tcCidade";
            tcCidade.SelectedIndex = 0;
            tcCidade.Size = new Size(678, 424);
            tcCidade.TabIndex = 7;
            // 
            // tpConsultaCidade
            // 
            tpConsultaCidade.Controls.Add(panel3);
            tpConsultaCidade.Controls.Add(panel2);
            tpConsultaCidade.Controls.Add(panel1);
            tpConsultaCidade.Location = new Point(4, 24);
            tpConsultaCidade.Name = "tpConsultaCidade";
            tpConsultaCidade.Padding = new Padding(3);
            tpConsultaCidade.Size = new Size(670, 396);
            tpConsultaCidade.TabIndex = 0;
            tpConsultaCidade.Text = "Consulta";
            tpConsultaCidade.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(txtPesquisarCidade);
            panel3.Controls.Add(btnPesquisarCidade);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(641, 29);
            panel3.TabIndex = 7;
            // 
            // txtPesquisarCidade
            // 
            txtPesquisarCidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisarCidade.Location = new Point(0, 0);
            txtPesquisarCidade.Name = "txtPesquisarCidade";
            txtPesquisarCidade.PlaceholderText = "Pesquisar por nome";
            txtPesquisarCidade.Size = new Size(535, 23);
            txtPesquisarCidade.TabIndex = 3;
            // 
            // btnPesquisarCidade
            // 
            btnPesquisarCidade.Dock = DockStyle.Right;
            btnPesquisarCidade.Image = Properties.Resources.icons8_pesquisar_16;
            btnPesquisarCidade.Location = new Point(550, 0);
            btnPesquisarCidade.Name = "btnPesquisarCidade";
            btnPesquisarCidade.Size = new Size(91, 29);
            btnPesquisarCidade.TabIndex = 7;
            btnPesquisarCidade.Text = "&Pesquisar";
            btnPesquisarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarCidade.UseVisualStyleBackColor = true;
            btnPesquisarCidade.Click += btnPesquisarCidade_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnNovoCidade);
            panel2.Controls.Add(btnVisualizarCidade);
            panel2.Location = new Point(6, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(641, 33);
            panel2.TabIndex = 9;
            // 
            // btnNovoCidade
            // 
            btnNovoCidade.Dock = DockStyle.Right;
            btnNovoCidade.Image = Properties.Resources.icons8_soma_16;
            btnNovoCidade.Location = new Point(483, 0);
            btnNovoCidade.Name = "btnNovoCidade";
            btnNovoCidade.Size = new Size(75, 33);
            btnNovoCidade.TabIndex = 1;
            btnNovoCidade.Text = "&Novo";
            btnNovoCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovoCidade.UseVisualStyleBackColor = true;
            btnNovoCidade.Click += btnNovoCidade_Click;
            // 
            // btnVisualizarCidade
            // 
            btnVisualizarCidade.Dock = DockStyle.Right;
            btnVisualizarCidade.Image = Properties.Resources.icons8_olhos_16__1_1;
            btnVisualizarCidade.Location = new Point(558, 0);
            btnVisualizarCidade.Name = "btnVisualizarCidade";
            btnVisualizarCidade.Size = new Size(83, 33);
            btnVisualizarCidade.TabIndex = 0;
            btnVisualizarCidade.Text = "&Visualizar";
            btnVisualizarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizarCidade.UseVisualStyleBackColor = true;
            btnVisualizarCidade.Click += btnVisualizarCidade_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(gridCidades);
            panel1.Location = new Point(6, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 287);
            panel1.TabIndex = 8;
            // 
            // gridCidades
            // 
            gridCidades.AllowUserToAddRows = false;
            gridCidades.AllowUserToDeleteRows = false;
            gridCidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridCidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCidades.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colUF });
            gridCidades.Location = new Point(0, 0);
            gridCidades.Name = "gridCidades";
            gridCidades.ReadOnly = true;
            gridCidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCidades.Size = new Size(641, 287);
            gridCidades.StandardTab = true;
            gridCidades.TabIndex = 4;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 42;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.DataPropertyName = "Nome";
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colUF
            // 
            colUF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUF.DataPropertyName = "UF";
            colUF.HeaderText = "UF";
            colUF.Name = "colUF";
            colUF.ReadOnly = true;
            // 
            // tpCadastroCidade
            // 
            tpCadastroCidade.Controls.Add(panel4);
            tpCadastroCidade.Controls.Add(txtNomeCidade);
            tpCadastroCidade.Controls.Add(txtUFCidade);
            tpCadastroCidade.Controls.Add(label);
            tpCadastroCidade.Controls.Add(label1);
            tpCadastroCidade.Location = new Point(4, 24);
            tpCadastroCidade.Name = "tpCadastroCidade";
            tpCadastroCidade.Padding = new Padding(3);
            tpCadastroCidade.Size = new Size(670, 396);
            tpCadastroCidade.TabIndex = 1;
            tpCadastroCidade.Text = "Cadastro";
            tpCadastroCidade.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSalvarCidade);
            panel4.Controls.Add(btnCancelarCidade);
            panel4.Controls.Add(btnExcluirCidade);
            panel4.Location = new Point(0, 342);
            panel4.Name = "panel4";
            panel4.Size = new Size(655, 25);
            panel4.TabIndex = 26;
            // 
            // btnSalvarCidade
            // 
            btnSalvarCidade.Dock = DockStyle.Right;
            btnSalvarCidade.Image = Properties.Resources.icons8_salvar_16;
            btnSalvarCidade.ImageAlign = ContentAlignment.BottomLeft;
            btnSalvarCidade.Location = new Point(513, 0);
            btnSalvarCidade.Name = "btnSalvarCidade";
            btnSalvarCidade.Size = new Size(64, 25);
            btnSalvarCidade.TabIndex = 12;
            btnSalvarCidade.Text = "&Salvar";
            btnSalvarCidade.TextAlign = ContentAlignment.TopRight;
            btnSalvarCidade.UseVisualStyleBackColor = true;
            btnSalvarCidade.Click += btnSalvarCidade_Click;
            // 
            // btnCancelarCidade
            // 
            btnCancelarCidade.Dock = DockStyle.Right;
            btnCancelarCidade.Image = Properties.Resources.icons8_cancelar_16;
            btnCancelarCidade.ImageAlign = ContentAlignment.BottomLeft;
            btnCancelarCidade.Location = new Point(577, 0);
            btnCancelarCidade.Name = "btnCancelarCidade";
            btnCancelarCidade.Size = new Size(78, 25);
            btnCancelarCidade.TabIndex = 11;
            btnCancelarCidade.Text = "&Cancelar";
            btnCancelarCidade.TextAlign = ContentAlignment.TopRight;
            btnCancelarCidade.UseVisualStyleBackColor = true;
            btnCancelarCidade.Click += btnCancelarCidade_Click;
            // 
            // btnExcluirCidade
            // 
            btnExcluirCidade.Dock = DockStyle.Left;
            btnExcluirCidade.Image = Properties.Resources.trash;
            btnExcluirCidade.ImageAlign = ContentAlignment.BottomLeft;
            btnExcluirCidade.Location = new Point(0, 0);
            btnExcluirCidade.Name = "btnExcluirCidade";
            btnExcluirCidade.Size = new Size(68, 25);
            btnExcluirCidade.TabIndex = 9;
            btnExcluirCidade.Text = "&Excluir";
            btnExcluirCidade.TextAlign = ContentAlignment.TopRight;
            btnExcluirCidade.UseVisualStyleBackColor = true;
            btnExcluirCidade.Click += btnExcluirCidade_Click;
            // 
            // txtNomeCidade
            // 
            txtNomeCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCidade.Location = new Point(10, 42);
            txtNomeCidade.Name = "txtNomeCidade";
            txtNomeCidade.Size = new Size(246, 23);
            txtNomeCidade.TabIndex = 25;
            // 
            // txtUFCidade
            // 
            txtUFCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUFCidade.Location = new Point(6, 86);
            txtUFCidade.Name = "txtUFCidade";
            txtUFCidade.Size = new Size(250, 23);
            txtUFCidade.TabIndex = 24;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(10, 68);
            label.Name = "label";
            label.Size = new Size(21, 15);
            label.TabIndex = 23;
            label.Text = "UF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 22;
            label1.Text = "Cidade";
            // 
            // CidadeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 376);
            Controls.Add(tcCidade);
            Name = "CidadeForm";
            Text = "CidadeForm";
            tcCidade.ResumeLayout(false);
            tpConsultaCidade.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCidades).EndInit();
            tpCadastroCidade.ResumeLayout(false);
            tpCadastroCidade.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcCidade;
        private TabPage tpConsultaCidade;
        private Panel panel3;
        private TextBox txtPesquisarCidade;
        private Button btnPesquisarCidade;
        private Panel panel2;
        private Button btnNovoCidade;
        private Button btnVisualizarCidade;
        private Panel panel1;
        private DataGridView gridCidades;
        private TabPage tpCadastroCidade;
        private TextBox txtNomeCidade;
        private TextBox txtUFCidade;
        private Label label;
        private Label label1;
        private Panel panel4;
        private Button btnExcluirCidade;
        private Button btnCancelarCidade;
        private Button btnSalvarCidade;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colUF;
    }
}