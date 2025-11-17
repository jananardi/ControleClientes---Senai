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
        public void Adicionar(OrdemDeServico ordem)
        {
            if (ordem.DataConclusao.HasValue)
            {
                ordem.DataConclusao = DateTime.SpecifyKind(ordem.DataConclusao.Value, DateTimeKind.Utc);
            }

            ordem.DataAbertura = DateTime.SpecifyKind(ordem.DataAbertura, DateTimeKind.Utc);

            _context.OrdemDeServicos.Add(ordem);
            _context.SaveChanges();
        }
        public List<OrdemDeServico> ListarTodos()
        {
            return _context.OrdemDeServicos
               .Include(o => o.Servico)
               .Include(o => o.Cliente)
               .ToList();
        }
        public OrdemDeServico ObterPorId(int id)
        {
            return _context.OrdemDeServicos.Find(id);
        }
        public void Atualizar(OrdemDeServico ordem)
        {
            var os = _context.OrdemDeServicos.Find(ordem.Id);

            if (os != null)
            {
                os.ClienteId = ordem.ClienteId;
                os.ServicoId = ordem.ServicoId;
                os.Quantidade = ordem.Quantidade;
                os.StatusOS = ordem.StatusOS;

                os.DataConclusao = ordem.DataConclusao.HasValue
                    ? DateTime.SpecifyKind(ordem.DataConclusao.Value, DateTimeKind.Utc)
                    : null;

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
