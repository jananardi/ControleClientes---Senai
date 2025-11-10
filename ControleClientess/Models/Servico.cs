namespace ControleClientess
{
    public class Servico
    {
        public int IdServico { get; set; }
        public string Nome{ get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }

        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();
    }
}
