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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btnVisualizarCidade = new Button();
            btnNovoCidade = new Button();
            btnPesquisarCidade = new Button();
            panel3 = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 9);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesquisar por nome";
            textBox1.Size = new Size(541, 23);
            textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(6, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(641, 281);
            dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(-1, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 287);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNovoCidade);
            panel2.Controls.Add(btnVisualizarCidade);
            panel2.Location = new Point(2, 340);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 33);
            panel2.TabIndex = 6;
            // 
            // btnVisualizarCidade
            // 
            btnVisualizarCidade.Dock = DockStyle.Right;
            btnVisualizarCidade.Image = Properties.Resources.icons8_pesquisar_16;
            btnVisualizarCidade.Location = new Point(561, 0);
            btnVisualizarCidade.Name = "btnVisualizarCidade";
            btnVisualizarCidade.Size = new Size(83, 33);
            btnVisualizarCidade.TabIndex = 0;
            btnVisualizarCidade.Text = "&Visualizar";
            btnVisualizarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizarCidade.UseVisualStyleBackColor = true;
            // 
            // btnNovoCidade
            // 
            btnNovoCidade.Dock = DockStyle.Right;
            btnNovoCidade.Image = Properties.Resources.icons8_soma_16;
            btnNovoCidade.Location = new Point(486, 0);
            btnNovoCidade.Name = "btnNovoCidade";
            btnNovoCidade.Size = new Size(75, 33);
            btnNovoCidade.TabIndex = 1;
            btnNovoCidade.Text = "&Novo";
            btnNovoCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovoCidade.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarCidade
            // 
            btnPesquisarCidade.Dock = DockStyle.Right;
            btnPesquisarCidade.Image = Properties.Resources.icons8_pesquisar_16;
            btnPesquisarCidade.Location = new Point(550, 0);
            btnPesquisarCidade.Name = "btnPesquisarCidade";
            btnPesquisarCidade.Size = new Size(91, 41);
            btnPesquisarCidade.TabIndex = 7;
            btnPesquisarCidade.Text = "&Pesquisar";
            btnPesquisarCidade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisarCidade.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnPesquisarCidade);
            panel3.Location = new Point(2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(641, 41);
            panel3.TabIndex = 5;
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
            Column2.HeaderText = "Nome";
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
            ClientSize = new Size(650, 375);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CidadeForm";
            Text = "CidadeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Button btnNovoCidade;
        private Button btnVisualizarCidade;
        private Button btnPesquisarCidade;
        private Panel panel3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}