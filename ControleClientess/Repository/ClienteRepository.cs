namespace ControleClientess
{
    class ClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository()
        {
            _context = new AppDbContext();
        }
        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
        public Cliente ObterPorId(int id)
        {
            return _context.Clientes.Find(id);
        }

        public IEnumerable<Cidade> ObterPorNome(string nome)
        {
            return _context.Cidades
            .Where(c => c.Nome.ToLower().Contains(nome.ToLower()))
            .ToList();
        }
        public void Atualizar(Cliente cliente)
        {
            Cliente clienteExistente = ObterPorId(cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Email = cliente.Email;
                clienteExistente.Genero = cliente.Genero;
                clienteExistente.Estado = cliente.Estado;
                clienteExistente.Logradouro = cliente.Logradouro;
                clienteExistente.CEP = cliente.CEP;
                clienteExistente.UF = cliente.UF;
                clienteExistente.Bairro = cliente.Bairro;
                clienteExistente.Estado = cliente.Estado;
                clienteExistente.CidadeId = cliente.CidadeId;
                clienteExistente.Complemento = cliente.Complemento;
                clienteExistente.Numero = cliente.Numero;
                clienteExistente.Localidade = cliente.Localidade;
                clienteExistente.CidadeId = cliente.CidadeId;
                _context.SaveChanges();
            }
        }
        public void Remover(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }

    }
}
