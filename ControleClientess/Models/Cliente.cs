using System.Text.Json.Serialization;

namespace ControleClientess
{
    public class Cliente
    {
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Genero Genero { get; set; }
        public EstadoCivil Estado { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public int? CidadeId { get; set; }
        public Cidade Cidade { get; set; }
    }
}
