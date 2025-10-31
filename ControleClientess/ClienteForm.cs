using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace ControleClientess
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteRepository _repository;
        private int? editingId = null;

        List<ItemGenero> itemGeneros = new List<ItemGenero>
        {
            new ItemGenero {Valor = Genero.Masculino, Descricao = "Masculino"},
            new ItemGenero {Valor = Genero.Feminino, Descricao = "Feminino"}
        };

        List<ItemEstado> itemEstado = new List<ItemEstado>
        {
            new ItemEstado {Valor = EstadoCivil.Solteiro, Descricao = "Solteiro"},
            new ItemEstado {Valor = EstadoCivil.Casado, Descricao = "Casado"},
            new ItemEstado {Valor = EstadoCivil.Separado, Descricao = "Separado"},
            new ItemEstado {Valor = EstadoCivil.Divorciado, Descricao = "Divorciado"},
            new ItemEstado {Valor = EstadoCivil.Viuvo, Descricao = "Viuvo"},
            new ItemEstado {Valor = EstadoCivil.UniaoEstavel, Descricao = "UniaoEstavel"}
        };

        private void CarregarGenero()
        {
            cmbGenero.DataSource = itemGeneros;
            cmbGenero.DisplayMember = "Descrição";
            cmbGenero.ValueMember = "Valor";
        }

        private void CarregarEstado()
        {
            cmbEstadoCivil.DataSource = itemEstado;
            cmbEstadoCivil.DisplayMember = "Descrição";
            cmbEstadoCivil.ValueMember = "Valor";
        }

        public ClienteForm()
        {
            InitializeComponent();
            CarregarGenero();
            CarregarEstado();
            _repository = new ClienteRepository();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridClientes.DataSource = clientes;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            txtCEP.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtUF.Clear();
            editingId = null;
            gridClientes.ClearSelection();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;

            var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            cmbGenero.SelectedItem = itemGeneros.FirstOrDefault(
                g => g.Valor == cliente.Genero);
            cmbEstadoCivil.SelectedItem = itemEstado.FirstOrDefault(
                e => e.Valor == cliente.Estado);
            txtCEP.Text = cliente.CEP;
            txtComplemento.Text = cliente.Complemento;
            txtLogradouro.Text = cliente.Logradouro;
            editingId = cliente.Id;
            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ItemGenero genero = (ItemGenero)cmbGenero.SelectedItem;
            ItemEstado estado = (ItemEstado)cmbEstadoCivil.SelectedItem;
            var cliente = new Cliente
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Genero = genero.Valor,
                Estado = estado.Valor,
                Bairro = txtBairro.Text.Trim(),
                CEP = txtCEP.Text.Trim(),
                Logradouro = txtLogradouro.Text.Trim(),
                Complemento = txtComplemento.Text.Trim(),
                Numero = txtNumero.Text.Trim(),
                UF = txtUF.Text.Trim(),
                Localidade = cmbCidade.Text.Trim()
            };

            if (editingId == null)
                _repository.Adicionar(cliente);
            else
            {
                cliente.Id = editingId.Value;
                _repository.Atualizar(cliente);
            }
            LimparCampos();
            AtualizarGrid();
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show("Excluir registro?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
                _repository.Remover(cliente.Id);
                AtualizarGrid();
                tcCliente.SelectTab(tpClienteConsulta);
            }
        }

        private async Task<Endereco> BuscarCepAsync(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Endereco>(responseBody);
                }
                else
                    throw new Exception($"Consultando o CEP. Código de status: {response.StatusCode}");
            }
        }

        private async void btnCep_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim();
            if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Por favor, insira um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Endereco endereco = await BuscarCepAsync(cep);
                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtLogradouro.Text = endereco.Logradouro;
                txtNumero.Text = endereco.Numero;
                txtComplemento.Text = endereco.Complemento;
                cmbCidade.Text = endereco.Localidade;
                txtUF.Text = endereco.UF;
                txtNumero.Focus();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro na requisição HTTP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Desserializando o JSON: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCepAsync_Click(object sender, EventArgs e)
        {
            btnCep_Click(sender, e);
        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cep = txtCEP.Text.Replace("-", "").Trim();

            if (cep.Length > 5)
                txtCEP.Text = cep.Insert(5, "-");

            txtCEP.SelectionStart = txtCEP.Text.Length;
        }
    }
}
