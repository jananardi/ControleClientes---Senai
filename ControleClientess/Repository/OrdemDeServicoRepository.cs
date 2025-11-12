using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControleClientess.Repository
{
    public class OrdemDeServicoRepository
    {
        private readonly AppDbContext _context;
        public OrdemDeServicoRepository()
        {
            _context = new AppDbContext();
        }
        public void Adicionar(OrdemDeServico ordemDeServico)
        {
            _context.OrdemDeServicos.Add(ordemDeServico);
            _context.SaveChanges();
        }
        public List<OrdemDeServico> ListarTodos()
        {
            return _context.OrdemDeServicos.ToList();
        }
        public OrdemDeServico ObterPorId(int id)
        {
            return _context.OrdemDeServicos.Find(id);
        }
        public void Atualizar(OrdemDeServico ordemDeServico)
        {
            OrdemDeServico ordemDeServicoExistente = ObterPorId(ordemDeServico.Id);
            if (ordemDeServicoExistente != null)
            {
                ordemDeServicoExistente.ClienteId = ordemDeServico.ClienteId;
                ordemDeServicoExistente.Cliente = ordemDeServico.Cliente;
                ordemDeServicoExistente.ServicoId = ordemDeServico.ServicoId;
                ordemDeServicoExistente.Servico = ordemDeServico.Servico;
                ordemDeServicoExistente.Quantidade = ordemDeServico.Quantidade;
                ordemDeServicoExistente.DataAbertura = ordemDeServico.DataAbertura;
                ordemDeServicoExistente.DataConclusao = ordemDeServico.DataConclusao;
                ordemDeServicoExistente.Status = ordemDeServico.Status;
                _context.SaveChanges();
            }
        }
        public void Remover(int id)
        {
            var ordemDeServico = _context.OrdemDeServicos.Find(id);
            if (ordemDeServico != null)
            {
                _context.OrdemDeServicos.Remove(ordemDeServico);
                _context.SaveChanges();
            }
        }
    }
}
