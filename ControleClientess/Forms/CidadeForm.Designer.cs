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
            tpConsultaCidade = new TabControl();
            tabPage1 = new TabPage();
            tpCadastroCidade = new TabPage();
            panel3 = new Panel();
            textBox1 = new TextBox();
            btnPesquisarCidade = new Button();
            panel2 = new Panel();
            btnNovoCidade = new Button();
            btnVisualizarCidade = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            txtUFCidade = new TextBox();
            label = new Label();
            label1 = new Label();
            txtNomeCidade = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tpConsultaCidade.SuspendLayout();
            tabPage1.SuspendLayout();
            tpCadastroCidade.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tpConsultaCidade
            // 
            tpConsultaCidade.Controls.Add(tabPage1);
            tpConsultaCidade.Controls.Add(tpCadastroCidade);
            tpConsultaCidade.Location = new Point(12, 12);
            tpConsultaCidade.Name = "tpConsultaCidade";
            tpConsultaCidade.SelectedIndex = 0;
            tpConsultaCidade.Size = new Size(663, 398);
            tpConsultaCidade.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(655, 370);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpCadastroCidade
            // 
            tpCadastroCidade.Controls.Add(txtNomeCidade);
            tpCadastroCidade.Controls.Add(txtUFCidade);
            tpCadastroCidade.Controls.Add(label);
            tpCadastroCidade.Controls.Add(label1);
            tpCadastroCidade.Location = new Point(4, 24);
            tpCadastroCidade.Name = "tpCadastroCidade";
            tpCadastroCidade.Padding = new Padding(3);
            tpCadastroCidade.Size = new Size(655, 370);
            tpCadastroCidade.TabIndex = 1;
            tpCadastroCidade.Text = "Cadastro";
            tpCadastroCidade.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnPesquisarCidade);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(641, 29);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesquisar por nome";
            textBox1.Size = new Size(535, 23);
            textBox1.TabIndex = 3;
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
            // 
            // panel2
            // 
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
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(6, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 287);
            panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(641, 287);
            dataGridView1.TabIndex = 4;
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
            // txtNomeCidade
            // 
            txtNomeCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCidade.Location = new Point(10, 42);
            txtNomeCidade.Name = "txtNomeCidade";
            txtNomeCidade.Size = new Size(246, 23);
            txtNomeCidade.TabIndex = 25;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.Width = 42;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Cidade";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "UF";
            Column3.Name = "Column3";
            // 
            // CidadeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 420);
            Controls.Add(tpConsultaCidade);
            Name = "CidadeForm";
            Text = "CidadeForm";
            tpConsultaCidade.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tpCadastroCidade.ResumeLayout(false);
            tpCadastroCidade.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpConsultaCidade;
        private TabPage tabPage1;
        private Panel panel3;
        private TextBox textBox1;
        private Button btnPesquisarCidade;
        private Panel panel2;
        private Button btnNovoCidade;
        private Button btnVisualizarCidade;
        private Panel panel1;
        private DataGridView dataGridView1;
        private TabPage tpCadastroCidade;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtNomeCidade;
        private TextBox txtUFCidade;
        private Label label;
        private Label label1;
    }
}