using System.ComponentModel.DataAnnotations;

namespace ControleClientess
{
    public class Servico
    {
            public int Id { get; set; }

            [Required]
            public string Nome { get; set; }

            public string Descricao { get; set; }

            [Required]
            [Range(0, double.MaxValue)]
            public decimal Preco { get; set; }

            [Required]
            public string Categoria { get; set; }
        
    }
}
