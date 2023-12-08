using Microsoft.EntityFrameworkCore;

namespace Woodenson.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<ContactModel> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBaseWoodenson.db");
        }
    }
}
