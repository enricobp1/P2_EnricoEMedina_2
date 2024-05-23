using Ecommerce3Ads.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce3Ads.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EcommerceDB;ConnectRetryCount=0");
            //optionsBuilder.UseSqlServer
            //   ("Password=root;Persist Security Info=True;User ID=root;Initial Catalog=EcommerceDB;Data Source=server");
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
    }
}
