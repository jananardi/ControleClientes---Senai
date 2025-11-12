using ControleClientess.Migrations;
using ControleClientess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleClientess
{
    public partial class OrdemDeServicoForm : Form
    {
        private readonly OrdemDeServicoRepository _repository;
        private int? editingId = null;
        public OrdemDeServicoForm()
        {
            InitializeComponent();
            _repository = new OrdemDeServicoRepository();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            var ordemDeServicos = _repository.ListarTodos();
            gridGestao.DataSource = ordemDeServicos;
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

            var ordemDeServicos = (OrdemDeServico)gridGestao.SelectedRows[0].DataBoundItem;
            //txtDataConclusaoGestao.Text = ordemDeServicos.DataConclusao;

            //txtNome.Text = cliente.Nome;
            //txtEmail.Text = cliente.Email;
            //cmbGenero.SelectedItem = itemGeneros.FirstOrDefault(
            //    g => g.Valor == cliente.Genero);
            //cmbEstadoCivil.SelectedItem = itemEstado.FirstOrDefault(
            //    e => e.Valor == cliente.Estado);
            //txtCEP.Text = cliente.CEP;
            //txtComplemento.Text = cliente.Complemento;
            //txtLogradouro.Text = cliente.Logradouro;
            //txtBairro.Text = cliente.Bairro;
            //txtNumero.Text = cliente.Numero;
            //var cidade = _cidades.FirstOrDefault(c => c.Id == cliente.Id);
            //cmbCidade.SelectedItem = cidade;
            //cmbCidade.SelectedItem = cliente.Localidade;
            //txtUF.Text = cliente.UF;
            //editingId = cliente.Id;
            //tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnSalvarGestao_Click(object sender, EventArgs e)
        {
            var ordemDeServicos = new OrdemDeServico
            {

                //Quantidade = txtQuantidadeGestao.Text.Trim(),

                //Email = txtEmail.Text.Trim(),
                //Genero = genero.Valor,
                //Estado = estado.Valor,
                //Bairro = txtBairro.Text.Trim(),
                //CEP = txtCEP.Text.Trim(),
                //CidadeId = cidade.Id,
                //Logradouro = txtLogradouro.Text.Trim(),
                //Complemento = txtComplemento.Text.Trim(),
                //Numero = txtNumero.Text.Trim(),
                //UF = txtUF.Text.Trim(),
                //Localidade = cmbCidade.Text.Trim()

                //ordemDeServicoExistente.ClienteId = ordemDeServico.ClienteId;
                //ordemDeServicoExistente.Cliente = ordemDeServico.Cliente;
                //ordemDeServicoExistente.ServicoId = ordemDeServico.ServicoId;
                //ordemDeServicoExistente.Servico = ordemDeServico.Servico;
                //ordemDeServicoExistente.Quantidade = ordemDeServico.Quantidade;
                //ordemDeServicoExistente.DataAbertura = ordemDeServico.DataAbertura;
                //ordemDeServicoExistente.DataConclusao = ordemDeServico.DataConclusao;
                //ordemDeServicoExistente.Status = ordemDeServico.Status;
            };

            if (editingId == null)
                _repository.Adicionar(ordemDeServicos);
            else
            {
                ordemDeServicos.Id = editingId.Value;
                _repository.Atualizar(ordemDeServicos);
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
    }
}
