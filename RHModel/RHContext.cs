using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    class RHContext : DbContext
    {
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<HistoricoCargo> HistoricoCargo { get; set; }
        public DbSet<HistoricoEmpregadoSetor> HistoricoEmpregadoSetor { get; set; }
        public DbSet<HistoricoSalarioCargo> HistoricoSalarioCargo { get; set; }
        public DbSet<HistoricoSalarioEmpregado> HistoricoSalarioEmpregado { get; set; }
    }
}
