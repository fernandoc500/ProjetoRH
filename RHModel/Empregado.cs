using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    [Table("Empregado")]
    class Empregado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public DateTime DataContratacao { get; set; }

        [Required]
        public decimal Salario { get; set; }

        [Required]
        [ForeignKey("CargoId")]
        public Cargo Cargo { get; set; }
        public int CargoId { get; set; }

        [ForeignKey("SuperiorId")]
        public Empregado Superior { get; set; }
        public int SuperiorId { get; set; }

        public IList<Empregado> Subordinados { get; set; }
    }
}
