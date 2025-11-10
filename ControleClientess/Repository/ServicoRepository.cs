namespace ControleClientess
{
    public class ServicoRepository
    {
        private readonly AppDbContext _context;
        public ServicoRepository()
        {
            _context = new AppDbContext();
        }
        public void Adicionar(Servico servico)
        {
            _context.Servicos.Add(servico);
            _context.SaveChanges();
        }
        public List<Servico> ListarTodos()
        {
            return _context.Servicos.ToList();
        }
        public Servico ObterPorId(int id)
        {
            return _context.Servicos.Find(id);
        }
        public IEnumerable<Servico> ObterPorNome(string nome)
        {
            return _context.Servicos
            .Where(c => c.Nome.ToLower().Contains(nome.ToLower()))
            .ToList();
        }
        public void Atualizar(Servico servico)
        {
            Servico servicoExistente = ObterPorId(servico.IdServico);
            if (servicoExistente != null)
            {
                servicoExistente.Nome = servico.Nome;
                servicoExistente.Descricao = servico.Descricao;
                servicoExistente.Preco = servico.Preco;
                servicoExistente.Categoria = servico.Categoria;
                _context.SaveChanges();
            }
        }
        public void Remover(int id)
        {
            var servico = _context.Servicos.Find(id);
            if (servico != null)
            {
                _context.Servicos.Remove(servico);
                _context.SaveChanges();
            }
        }
    }
}
