using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    [Table("Cargo")]
    public class Cargo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal SalarioBase { get; set; }

        [Required]
        public string Nome { get; set; }

        [ForeignKey("CargoPaiId")]
        public Cargo CargoPai { get; set; }
        public int CargoPaiId { get; set; }
    }
}
