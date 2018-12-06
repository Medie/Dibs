using Microsoft.EntityFrameworkCore;

namespace MyWeb.Models
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
        : base(options)
        {

        }
        public DbSet<MyWeb.Models.Product> Product{get; set;}
    }
}