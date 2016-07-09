using System.Data.Entity;

namespace BX3_MSI_Giveaway.Models
{
    public class MyDbContext: DbContext
    {
        public DbSet<Facebook> Facebooks { get; set; }
        public DbSet<Form> Forms { get; set; }
    }
}