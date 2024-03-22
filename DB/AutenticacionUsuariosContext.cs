using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class AutenticacionUsuariosContext : DbContext
    {
        public AutenticacionUsuariosContext(DbContextOptions<AutenticacionUsuariosContext> options) : base(options) 
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
