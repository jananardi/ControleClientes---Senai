using ControleClientess.Migrations;
using ControleClientess.Models;
using ControleClientess.Repository;

namespace ControleClientess
{
    public partial class OrdemDeServicoForm : Form
    {
        private readonly OrdemDeServicoRepository _repository;
        private readonly ClienteRepository _clienteRepository;
        private readonly ServicoRepository _servicoRepository;

        private int? editingId = null;

        List<ItemStatusOs> itemStatusOs = new List<ItemStatusOs>
        {
            new ItemStatusOs {Valor = StatusOs.Aberta, Descricao = "Aberta"},
            new ItemStatusOs {Valor = StatusOs.EmAndamento, Descricao = "Em Andamento"},
            new ItemStatusOs {Valor = StatusOs.Concluida, Descricao = "Concluida"},
            new ItemStatusOs {Valor = StatusOs.Cancelada, Descricao = "Cancelada"}
        };

        private void CarregarGenero()
        {
            cmbStatus.DataSource = itemStatusOs;
            cmbStatus.DisplayMember = "Descrição";
            cmbStatus.ValueMember = "Valor";
        }

        public OrdemDeServicoForm()
        {
            _repository = new OrdemDeServicoRepository();
            _clienteRepository = new ClienteRepository();
            _servicoRepository = new ServicoRepository();
            CarregarGenero();
            CarregarCombos();
            AtualizarGrid();
        }

        private void CarregarCombos()
        {
            cmbCliente.DataSource = _clienteRepository.ListarTodos();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";
            cmbCliente.SelectedIndex = -1;

            cmbServico.DataSource = _servicoRepository.ListarTodos();
            cmbServico.DisplayMember = "Descricao";
            cmbServico.ValueMember = "Id";
            cmbServico.SelectedIndex = -1;
        }

        private void AtualizarGrid()
        {
            gridGestao.DataSource = _repository.ListarTodos();
        }

        private void btnNovoGestao_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tcGestao.SelectTab(tpCadastroGestao);
        }

        private void LimparCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbServico.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtQuantidadeGestao.Clear();
            txtPrecoGestao.Clear();
            txtDataConclusaoGestao.Clear();
            txtTotalGestao.Clear();
            editingId = null;
            gridGestao.ClearSelection();
        }

        private void btnVisualizarGestao_Click(object sender, EventArgs e)
        {
            if (gridGestao.SelectedRows.Count == 0)
                return;

            var os = (OrdemDeServico)gridGestao.SelectedRows[0].DataBoundItem;

            cmbCliente.SelectedValue = os.ClienteId;
            cmbServico.SelectedValue = os.ServicoId;
            txtQuantidadeGestao.Text = os.Quantidade.ToString();
            txtDataConclusaoGestao.Text = os.DataConclusao?.ToString("yyyy-MM-dd") ?? "";
            cmbStatus.SelectedItem = itemStatusOs.FirstOrDefault(
                e => e.Valor == os.StatusOS);

            editingId = os.Id;

            tcGestao.SelectTab(tpCadastroGestao);
        }

        private void btnSalvarGestao_Click(object sender, EventArgs e)
        {
            ItemStatusOs status = (ItemStatusOs)cmbStatus.SelectedItem;
            if (cmbCliente.SelectedIndex == -1 || cmbServico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente e um serviço.");
                return;
            }

            var ordemDeServico = new OrdemDeServico
            {
                ClienteId = (int)cmbCliente.SelectedValue,
                ServicoId = (int)cmbServico.SelectedValue,
                Quantidade = int.Parse(txtQuantidadeGestao.Text),
                DataAbertura = DateTime.Now,
                DataConclusao = string.IsNullOrWhiteSpace(txtDataConclusaoGestao.Text)
                                ? null
                                : DateTime.Parse(txtDataConclusaoGestao.Text),
                StatusOS = status.Valor

            };

            if (editingId == null)
                _repository.Adicionar(ordemDeServico);
            else
            {
                ordemDeServico.Id = editingId.Value;
                _repository.Atualizar(ordemDeServico);
            }

            LimparCampos();
            AtualizarGrid();
            tcGestao.SelectTab(tpConsultaGestao);
        }

        private void btnCancelarGestao_Click(object sender, EventArgs e)
        {
            tcGestao.SelectTab(tpConsultaGestao);
        }

        private void btnExcluirGestao_Click(object sender, EventArgs e)
        {
            if (gridGestao.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show("Excluir registro?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cliente = (Cliente)gridGestao.SelectedRows[0].DataBoundItem;
                _repository.Remover(cliente.Id);
                AtualizarGrid();
                tcGestao.SelectTab(tpConsultaGestao);
            }
        }

        private void cmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServico.SelectedItem == null) return;

            var servico = (Servico)cmbServico.SelectedItem;
            txtPrecoGestao.Text = servico.Preco.ToString("0.00");
        }
    }
}
