using System.Collections.Generic;
using ControleClientess;
namespace ControleClientess
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}
