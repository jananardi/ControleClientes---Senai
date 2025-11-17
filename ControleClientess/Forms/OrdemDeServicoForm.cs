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

        private void CarregarOrdem()
        {
            cmbStatus.DataSource = itemStatusOs;
            cmbStatus.DisplayMember = "Descricao";
            cmbStatus.ValueMember = "Valor";
        }

        public OrdemDeServicoForm()
        {
            InitializeComponent();
            _repository = new OrdemDeServicoRepository();
            _clienteRepository = new ClienteRepository();
            _servicoRepository = new ServicoRepository();
            CarregarOrdem();
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
            mskDataConclusao.Clear();
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

            mskDataConclusao.Text = os.DataConclusao?.ToString("dd/MM/yyyy") ?? "";

            cmbStatus.SelectedItem = itemStatusOs.FirstOrDefault(
                e => e.Valor == os.StatusOS);
            if (os.Servico != null)
                txtPrecoGestao.Text = os.Servico.Preco.ToString("0.00");

            CalcularTotal();

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

            int quantidade = int.TryParse(txtQuantidadeGestao.Text, out var qtd) ? qtd : 0;

            DateTime? dataConclusao = null;
            string textoData = mskDataConclusao.Text.Replace("/", "").Trim();

            if (!string.IsNullOrEmpty(textoData))
            {
                if (DateTime.TryParseExact(mskDataConclusao.Text, "dd/MM/yyyy", null,
                    System.Globalization.DateTimeStyles.None, out var dt))
                {
                    dataConclusao = dt;
                }
                else
                {
                    MessageBox.Show("Data inválida! Use o formato dd/mm/aaaa.");
                    return;
                }
            }

            var repoServico = new ServicoRepository();
            int servicoId = (int)cmbServico.SelectedValue;
            var servico = repoServico.ObterPorId(servicoId);

            if (servico == null)
            {
                MessageBox.Show("Erro ao buscar o serviço selecionado.");
                return;
            }

            var ordem = new OrdemDeServico
            {
                ClienteId = (int)cmbCliente.SelectedValue,
                ServicoId = servicoId,
                Quantidade = quantidade,
                StatusOS = status.Valor,
                DataConclusao = dataConclusao,
            };

            if (editingId == null)
            {
                ordem.DataAbertura = DateTime.Now;
                _repository.Adicionar(ordem);
                MessageBox.Show("Ordem de Serviço cadastrada com sucesso!");
            }
            else
            {
                ordem.Id = editingId.Value;

                var original = _repository.ObterPorId(editingId.Value);
                ordem.DataAbertura = original.DataAbertura;

                _repository.Atualizar(ordem);
                MessageBox.Show("Ordem de Serviço atualizada com sucesso!");
            }

            LimparCampos();
            AtualizarGrid();
            tcGestao.SelectTab(tpConsultaGestao);
        }



        private void CalcularTotal()
        {
            if (decimal.TryParse(txtPrecoGestao.Text, out var preco) &&
                int.TryParse(txtQuantidadeGestao.Text, out var qtd))
            {
                decimal total = preco * qtd;
                txtTotalGestao.Text = total.ToString("0.00");
            }
            else
            {
                txtTotalGestao.Text = "0.00";
            }
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
                var os = (OrdemDeServico)gridGestao.SelectedRows[0].DataBoundItem;
                _repository.Remover(os.Id);
                AtualizarGrid();
                tcGestao.SelectTab(tpConsultaGestao);
            }
        }

        private void cmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServico.SelectedItem == null) return;

            var servico = (Servico)cmbServico.SelectedItem;
            txtPrecoGestao.Text = servico.Preco.ToString("0.00");

            CalcularTotal();
        }

        private void txtQuantidadeGestao_TextChanged_1(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
