using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_veiculos.Models.Contexto
{
    public class DBContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Placa_veiculo> Placa_veiculo { get; set; }

        public DbSet<Horario_entrada> Horario_entrada{ get; set; }

        public DbSet<Horario_saida> Horario_saida{ get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
