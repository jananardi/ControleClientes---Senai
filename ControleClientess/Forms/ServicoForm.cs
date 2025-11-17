using ControleClientess.Repository;

namespace ControleClientess
{
    public partial class ServicoForm : Form
    {
        private readonly ServicoRepository _repository;
        private int? editingId = null;
        public ServicoForm()
        {
            InitializeComponent();
            _repository = new ServicoRepository();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            gridServico.DataSource = _repository.ListarTodos();
        }

        private void LimparCampos()
        {
            txtServicoNome.Clear();
            txtServicoDescricao.Clear();
            txtServicoPreco.Clear();
            txtServicoCategoria.Clear();
            editingId = null;
            gridServico.ClearSelection();
        }

        private void btnServicosVisualizar_Click(object sender, EventArgs e)
        {
            if (gridServico.SelectedRows.Count == 0)
                return;

            var servico = (Servico)gridServico.SelectedRows[0].DataBoundItem;

            txtServicoNome.Text = servico.Nome;
            txtServicoDescricao.Text = servico.Descricao;
            txtServicoPreco.Text = servico.Preco.ToString("0.00");
            txtServicoCategoria.Text = servico.Categoria;

            editingId = servico.Id;

            tcServicos.SelectTab(tpCadastroServico);
        }

        private void btnServicoNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tcServicos.SelectTab(tpCadastroServico);
        }

        private void btnSalvarServico_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtServicoPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var servico = new Servico
            {
                Nome = txtServicoNome.Text.Trim(),
                Descricao = txtServicoDescricao.Text.Trim(),
                Preco = decimal.Parse(txtServicoPreco.Text),
                Categoria = txtServicoCategoria.Text.Trim()
            };

            if (editingId == null)
            {
                _repository.Adicionar(servico);
            }
            else
            {
                servico.Id = editingId.Value;
                _repository.Atualizar(servico);
            }

            LimparCampos();
            AtualizarGrid();
            tcServicos.SelectTab(tpConsultaServico);
        }

        private void btnCancelarServico_Click(object sender, EventArgs e)
        {
            tcServicos.SelectTab(tpConsultaServico);
        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            if (gridServico.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show("Excluir registro?", "Serviços",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var servico = (Servico)gridServico.SelectedRows[0].DataBoundItem;

                _repository.Remover(servico.Id);

                AtualizarGrid();
                tcServicos.SelectTab(tpConsultaServico);
            }
        }
    } 
}

