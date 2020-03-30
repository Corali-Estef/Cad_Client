using Veiculos.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClienteVeiculos.Contexto
{
    public class DBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Placa_veiculo> Placa_veiculo { get; set; }

        public DbSet<Horario_entrada> Horario_entrada{ get; set; }

        public DbSet<Horario_saida> Horario_saida{ get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}