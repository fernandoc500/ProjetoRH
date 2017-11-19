using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    [Table("Setor")]
    class Setor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime DataExtincao { get; set; }

        [ForeignKey("SetorPaiId")]
        public Setor SetorPai { get; set; }
        public int SetorPaiId { get; set; }

        [ForeignKey("ResponsavelId")]
        public Empregado Responsavel { get; set; }
        public int ResponsavelId { get; set; }

        [Required]
        public string Atividades { get; set; }
    }
}
