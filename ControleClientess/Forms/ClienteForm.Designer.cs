namespace ControleClientess
{
    partial class ClienteForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tcCliente = new TabControl();
            tpClienteConsulta = new TabPage();
            gridClientes = new DataGridView();
            colid = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlPesquisar = new Panel();
            btnPesquisar = new Button();
            txtPesquisarCliente = new TextBox();
            pnlBotao = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            tpClienteCadastro = new TabPage();
            label12 = new Label();
            txtUF = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtLogradouro = new TextBox();
            cmbCidade = new ComboBox();
            txtCEP = new MaskedTextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtComplemento = new TextBox();
            btnBuscarCepAsync = new Button();
            label5 = new Label();
            label4 = new Label();
            cmbEstadoCivil = new ComboBox();
            label3 = new Label();
            cmbGenero = new ComboBox();
            panel1 = new Panel();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tcCliente.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            pnlPesquisar.SuspendLayout();
            pnlBotao.SuspendLayout();
            tpClienteCadastro.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tcCliente
            // 
            tcCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCliente.Controls.Add(tpClienteConsulta);
            tcCliente.Controls.Add(tpClienteCadastro);
            tcCliente.Location = new Point(-2, -27);
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(645, 368);
            tcCliente.TabIndex = 6;
            tcCliente.TabStop = false;
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(gridClientes);
            tpClienteConsulta.Controls.Add(pnlPesquisar);
            tpClienteConsulta.Controls.Add(pnlBotao);
            tpClienteConsulta.Location = new Point(4, 24);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3);
            tpClienteConsulta.Size = new Size(637, 340);
            tpClienteConsulta.TabIndex = 0;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { colid, colNome, colEmail });
            gridClientes.Dock = DockStyle.Fill;
            gridClientes.Location = new Point(3, 38);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.Size = new Size(631, 267);
            gridClientes.StandardTab = true;
            gridClientes.TabIndex = 0;
            // 
            // colid
            // 
            colid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colid.DataPropertyName = "Id";
            colid.HeaderText = "ID";
            colid.Name = "colid";
            colid.ReadOnly = true;
            colid.Width = 43;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.DataPropertyName = "Nome";
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "E-mail";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // pnlPesquisar
            // 
            pnlPesquisar.Controls.Add(btnPesquisar);
            pnlPesquisar.Controls.Add(txtPesquisarCliente);
            pnlPesquisar.Dock = DockStyle.Top;
            pnlPesquisar.Location = new Point(3, 3);
            pnlPesquisar.Name = "pnlPesquisar";
            pnlPesquisar.Size = new Size(631, 35);
            pnlPesquisar.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Dock = DockStyle.Right;
            btnPesquisar.Image = Properties.Resources.icons8_pesquisar_16;
            btnPesquisar.Location = new Point(544, 0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(87, 35);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisarCliente
            // 
            txtPesquisarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisarCliente.Location = new Point(3, 3);
            txtPesquisarCliente.Name = "txtPesquisarCliente";
            txtPesquisarCliente.PlaceholderText = "Pesquisar por nome";
            txtPesquisarCliente.Size = new Size(535, 23);
            txtPesquisarCliente.TabIndex = 1;
            // 
            // pnlBotao
            // 
            pnlBotao.Controls.Add(btnVisualizar);
            pnlBotao.Controls.Add(btnNovo);
            pnlBotao.Dock = DockStyle.Bottom;
            pnlBotao.Location = new Point(3, 305);
            pnlBotao.Name = "pnlBotao";
            pnlBotao.Size = new Size(631, 32);
            pnlBotao.TabIndex = 2;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Dock = DockStyle.Right;
            btnVisualizar.Image = Properties.Resources.icons8_olhos_16__1_1;
            btnVisualizar.Location = new Point(469, 0);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(86, 32);
            btnVisualizar.TabIndex = 4;
            btnVisualizar.Text = "&Visualizar";
            btnVisualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Dock = DockStyle.Right;
            btnNovo.Image = Properties.Resources.icons8_soma_161;
            btnNovo.Location = new Point(555, 0);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(76, 32);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "&Novo";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tpClienteCadastro
            // 
            tpClienteCadastro.Controls.Add(label12);
            tpClienteCadastro.Controls.Add(txtUF);
            tpClienteCadastro.Controls.Add(label11);
            tpClienteCadastro.Controls.Add(label10);
            tpClienteCadastro.Controls.Add(txtLogradouro);
            tpClienteCadastro.Controls.Add(cmbCidade);
            tpClienteCadastro.Controls.Add(txtCEP);
            tpClienteCadastro.Controls.Add(txtBairro);
            tpClienteCadastro.Controls.Add(txtNumero);
            tpClienteCadastro.Controls.Add(label9);
            tpClienteCadastro.Controls.Add(label8);
            tpClienteCadastro.Controls.Add(label7);
            tpClienteCadastro.Controls.Add(label6);
            tpClienteCadastro.Controls.Add(txtComplemento);
            tpClienteCadastro.Controls.Add(btnBuscarCepAsync);
            tpClienteCadastro.Controls.Add(label5);
            tpClienteCadastro.Controls.Add(label4);
            tpClienteCadastro.Controls.Add(cmbEstadoCivil);
            tpClienteCadastro.Controls.Add(label3);
            tpClienteCadastro.Controls.Add(cmbGenero);
            tpClienteCadastro.Controls.Add(panel1);
            tpClienteCadastro.Controls.Add(txtEmail);
            tpClienteCadastro.Controls.Add(txtNome);
            tpClienteCadastro.Controls.Add(label2);
            tpClienteCadastro.Controls.Add(label1);
            tpClienteCadastro.Location = new Point(4, 24);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3);
            tpClienteCadastro.Size = new Size(637, 340);
            tpClienteCadastro.TabIndex = 1;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AccessibleRole = AccessibleRole.Pane;
            label12.AutoSize = true;
            label12.Location = new Point(509, 193);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 31;
            label12.Text = "UF";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(509, 211);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(100, 23);
            txtUF.TabIndex = 30;
            // 
            // label11
            // 
            label11.AccessibleRole = AccessibleRole.Pane;
            label11.AutoSize = true;
            label11.Location = new Point(332, 193);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 29;
            label11.Text = "Cidade";
            // 
            // label10
            // 
            label10.AccessibleRole = AccessibleRole.Pane;
            label10.AutoSize = true;
            label10.Location = new Point(207, 142);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 28;
            label10.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(205, 160);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(298, 23);
            txtLogradouro.TabIndex = 27;
            // 
            // cmbCidade
            // 
            cmbCidade.FormattingEnabled = true;
            cmbCidade.Location = new Point(332, 211);
            cmbCidade.Name = "cmbCidade";
            cmbCidade.Size = new Size(171, 23);
            cmbCidade.TabIndex = 26;
            cmbCidade.SelectedIndexChanged += cmbCidade_SelectedIndexChanged;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(16, 160);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 25;
            txtCEP.MaskInputRejected += txtCEP_MaskInputRejected;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(207, 211);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(119, 23);
            txtBairro.TabIndex = 24;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(509, 161);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 23;
            // 
            // label9
            // 
            label9.AccessibleRole = AccessibleRole.Pane;
            label9.AutoSize = true;
            label9.Location = new Point(234, 237);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 22;
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.Pane;
            label8.AutoSize = true;
            label8.Location = new Point(205, 193);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 21;
            label8.Text = "Bairro";
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Pane;
            label7.AutoSize = true;
            label7.Location = new Point(509, 142);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 20;
            label7.Text = "Numero";
            // 
            // label6
            // 
            label6.AccessibleRole = AccessibleRole.Pane;
            label6.AutoSize = true;
            label6.Location = new Point(16, 193);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 19;
            label6.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtComplemento.Location = new Point(16, 211);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(183, 23);
            txtComplemento.TabIndex = 15;
            // 
            // btnBuscarCepAsync
            // 
            btnBuscarCepAsync.Location = new Point(122, 160);
            btnBuscarCepAsync.Name = "btnBuscarCepAsync";
            btnBuscarCepAsync.Size = new Size(77, 23);
            btnBuscarCepAsync.TabIndex = 14;
            btnBuscarCepAsync.Text = "Buscar";
            btnBuscarCepAsync.UseVisualStyleBackColor = true;
            btnBuscarCepAsync.Click += btnBuscarCepAsync_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 142);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 13;
            label5.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 68);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 11;
            label4.Text = "Estado civil";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(509, 86);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(121, 23);
            cmbEstadoCivil.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 12);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 9;
            label3.Text = "Genero";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(509, 30);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 24);
            panel1.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Right;
            btnSalvar.Image = Properties.Resources.icons8_salvar_16;
            btnSalvar.ImageAlign = ContentAlignment.BottomLeft;
            btnSalvar.Location = new Point(489, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(64, 24);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "&Salvar";
            btnSalvar.TextAlign = ContentAlignment.TopRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Dock = DockStyle.Left;
            btnExcluir.Image = Properties.Resources.trash;
            btnExcluir.ImageAlign = ContentAlignment.BottomLeft;
            btnExcluir.Location = new Point(0, 0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(68, 24);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "&Excluir";
            btnExcluir.TextAlign = ContentAlignment.TopRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.Image = Properties.Resources.icons8_cancelar_16;
            btnCancelar.ImageAlign = ContentAlignment.BottomLeft;
            btnCancelar.Location = new Point(553, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 24);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.TopRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(16, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(487, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(16, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(487, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 337);
            Controls.Add(tcCliente);
            Name = "ClienteForm";
            Text = "Cadastro de Clientes";
            tcCliente.ResumeLayout(false);
            tpClienteConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            pnlPesquisar.ResumeLayout(false);
            pnlPesquisar.PerformLayout();
            pnlBotao.ResumeLayout(false);
            tpClienteCadastro.ResumeLayout(false);
            tpClienteCadastro.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tcCliente;
        private TabPage tpClienteConsulta;
        private TabPage tpClienteCadastro;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnCancelar;
        private DataGridView gridClientes;
        private Button btnPesquisar;
        private TextBox txtPesquisarCliente;
        private Button btnVisualizar;
        private Button btnNovo;
        private Panel pnlBotao;
        private Panel pnlPesquisar;
        private Panel panel1;
        private ComboBox cmbGenero;
        private Label label3;
        private Label label4;
        private ComboBox cmbEstadoCivil;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtComplemento;
        private Button btnBuscarCepAsync;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private MaskedTextBox txtCEP;
        private Label label10;
        private TextBox txtLogradouro;
        private ComboBox cmbCidade;
        private Label label12;
        private Label label11;
        private DataGridViewTextBoxColumn colid;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private TextBox txtUF;
    }
}