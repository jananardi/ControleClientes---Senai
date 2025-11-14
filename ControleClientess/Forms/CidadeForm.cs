using ControleClientess.Migrations;
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
    public partial class CidadeForm : Form
    {
        private readonly CidadeRepository _repository;
        private int? editingId = null;
        public CidadeForm()
        {
            InitializeComponent();
            _repository = new CidadeRepository();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            var cidades = _repository.ListarTodos();
            gridCidades.DataSource = cidades;
        }

        private void LimparCampos()
        {
            txtNomeCidade.Clear();
            txtUFCidade.Clear();
            editingId = null;
            gridCidades.ClearSelection();
        }

        private void btnNovoCidade_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tcCidade.SelectTab(tpCadastroCidade);
        }

        private void btnVisualizarCidade_Click(object sender, EventArgs e)
        {
            if (gridCidades.SelectedRows.Count == 0)
                return;

            var cidade = (Cidade)gridCidades.SelectedRows[0].DataBoundItem;
            txtNomeCidade.Text = cidade.Nome;
            txtUFCidade.Text = cidade.UF;
            tcCidade.SelectTab(tpCadastroCidade);
        }

        private void btnSalvarCidade_Click(object sender, EventArgs e)
        {
            var cidade = new Cidade
            {
                Nome = txtNomeCidade.Text.Trim(),
                UF = txtUFCidade.Text.Trim()
            };

            if (editingId == null)
                _repository.Adicionar(cidade);
            else
            {
                cidade.Id = editingId.Value;
                _repository.Atualizar(cidade);
            }
            LimparCampos();
            AtualizarGrid();
            tcCidade.SelectTab(tpConsultaCidade);
        }

        private void btnCancelarCidade_Click(object sender, EventArgs e)
        {
            tcCidade.SelectTab(tpConsultaCidade);
        }

        private void btnExcluirCidade_Click(object sender, EventArgs e)
        {
            if (gridCidades.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show("Excluir registro?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cidade = (Cidade)gridCidades.SelectedRows[0].DataBoundItem;
                _repository.Remover(cidade.Id);
                AtualizarGrid();
                tcCidade.SelectTab(tpConsultaCidade);
            }
        }

        private void btnPesquisarCidade_Click(object sender, EventArgs e)
        {
            var cidades = _repository.ObterPorNome(txtPesquisarCidade.Text);
            gridCidades.DataSource = cidades;
        }
    }
}
