using Microsoft.EntityFrameworkCore;
using ServicioPJ.Database.Entities;

namespace ServicioPJ.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<MicroPJ> DBPJ { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string data_source = "LAPTOP-SP68ANVL";
            string initial_catalog = "apiBase";
            string user_id = "jose_mercado";
            string password = "edu123";
            optionsBuilder.UseSqlServer(@"data source=" + data_source + "; initial catalog=" + initial_catalog + "; persist security info=True; user id=" + user_id + "; password=" + password + "");
        }
    }
}
