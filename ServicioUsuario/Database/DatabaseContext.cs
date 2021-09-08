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
        public DbSet<DatosPJEH> DatosPJEH { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string server_name = "LAPTOP-FJJI83V9";
            string db_name = "prueba_microservicio";
            string user_id = "microservicio_asp";
            string password = "admin_asp";
            optionsBuilder.UseSqlServer(@"data source=" + server_name + "; initial catalog=" + db_name + "; persist security info=True; user id=" + user_id + "; password=" + password + "");
        }
    }
}
