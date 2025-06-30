using EstoqueApp.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EstoqueApp.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,1434;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Coti@2025;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }




    }
}
