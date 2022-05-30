using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;  

namespace BH_Automoveis.Models
{
    public class BhautomoveisContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=Bhautomoveis;Uid=root;Pwd=;");
        }

        public DbSet<Carronovos> Carrosnovos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    
    }
}