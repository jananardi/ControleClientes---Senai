namespace ControleClientess
{
    public class GestaoOrdens
    {
        public int IdGestao { get; set; }
        public int IdCliente { get; set; }
        public int IdServico { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataConclusao { get; set; }
        public double Total { get; set; }

        public ICollection<Cliente> Clientes { get; set; }

        public ICollection<Servico> Servicos { get; set; }
    }
}
