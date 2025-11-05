using BancaEnLinea.BC.Modelos;
using BancaEnLinea.BC.Categorias;
using Microsoft.EntityFrameworkCore;

namespace BancaEnLinea.DA.Config
{
    public class BancaEnLineaContext : DbContext
    {
        public BancaEnLineaContext(DbContextOptions<BancaEnLineaContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
        public DbSet<Beneficiarios> Beneficiarios { get; set; }
        public DbSet<Transferencias> Transferencias { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
