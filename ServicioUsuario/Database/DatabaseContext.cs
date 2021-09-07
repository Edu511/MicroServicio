using Microsoft.EntityFrameworkCore;
using ServicioUsuario.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioUsuario.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string data_source = "DESKTOP-T8DE21Q";
            string initial_catalog = "apiBase";
            string user_id = "jose_mercado";
            string password = "edu123";
            optionsBuilder.UseSqlServer(@"data source=" + data_source + "; initial catalog=" + initial_catalog + "; persist security info=True; user id=" + user_id + "; password=" + password + "");
        }
    }
}
