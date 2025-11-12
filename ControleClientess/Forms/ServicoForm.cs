using ControleClientess.Migrations;
using ControleClientess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var servicos = _repository.ListarTodos();
            gridServico.DataSource = servicos;
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
            //txtServicoPreco.Text = servico.Preco;
            txtServicoCategoria.Text = servico.Categoria;
            tcServicos.SelectTab(tpConsultaServico);
        }

        private void btnServicoNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tcServicos.SelectTab(tpCadastroServico);

        }

        private void btnSalvarServico_Click(object sender, EventArgs e)
        {
            var servico = new Servico
            {
                Nome = txtServicoNome.Text.Trim(),
                Descricao = txtServicoDescricao.Text.Trim(),
                //Preco = txtServicoPreco.Text.Trim(),
                Categoria = txtServicoCategoria.Text.Trim()
            };

            if (editingId == null)
                _repository.Adicionar(servico);
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

            if (MessageBox.Show("Excluir registro?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var servico = (Cidade)gridServico.SelectedRows[0].DataBoundItem;
                _repository.Remover(servico.Id);
                AtualizarGrid();
                tcServicos.SelectTab(tpConsultaServico);
            }
        }

    } 
}

