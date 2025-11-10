namespace ControleClientess.Repository
{
    public class GestaoOrdensRepository
    {
        private readonly AppDbContext _context;
        public GestaoOrdensRepository()
        {
            _context = new AppDbContext();
        }
        public void Adicionar(GestaoOrdens gestaoOrdens)
        {
            _context.GestaoOrdens.Add(gestaoOrdens);
            _context.SaveChanges();
        }
        public List<GestaoOrdens> ListarTodos()
        {
            return _context.GestaoOrdens.ToList();
        }
        public GestaoOrdens ObterPorId(int id)
        {
            return _context.GestaoOrdens.Find(id);
        }
        //public IEnumerable<GestaoOrdens> ObterPorNome(string nome)
        //{
        //    return _context.GestaoOrdens
        //    .Where(c => c.Nome.ToLower().Contains(nome.ToLower()))
        //    .ToList();
        //}
        public void Atualizar(GestaoOrdens gestaoOrdens)
        {
            GestaoOrdens gestaoOrdensExistente = ObterPorId(gestaoOrdens.IdGestao);
            if (gestaoOrdensExistente != null)
            {
                gestaoOrdensExistente.IdCliente = gestaoOrdens.IdCliente;
                gestaoOrdensExistente.IdServico = gestaoOrdens.IdServico;
                gestaoOrdensExistente.Quantidade = gestaoOrdens.Quantidade;
                gestaoOrdensExistente.DataAbertura = gestaoOrdens.DataAbertura;
                gestaoOrdensExistente.DataConclusao = gestaoOrdens.DataConclusao;
                gestaoOrdensExistente.Total = gestaoOrdens.Total;
                _context.SaveChanges();
            }
        }
        public void Remover(int id)
        {
            var gestaoOrdens = _context.GestaoOrdens.Find(id);
            if (gestaoOrdens != null)
            {
                _context.GestaoOrdens.Remove(gestaoOrdens);
                _context.SaveChanges();
            }
        }
    }
}
