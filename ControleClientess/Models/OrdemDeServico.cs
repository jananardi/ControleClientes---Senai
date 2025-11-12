using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientess
{
    public class OrdemDeServico
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }

        [Range(0, 999.999)]
        public decimal Quantidade { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataAbertura { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataConclusao { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Total => Quantidade * (Servico?.Preco ?? 0);

        [Required]
        public string Status { get; set; } = "Aberta";
    }
}
