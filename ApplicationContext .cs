using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data;

namespace bd
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Sotrudnik> Sotrudniki { get; set; } = null!;
        public DbSet<Predmet_zaloga> Predmeti_zaloga { get; set; } = null!;
        public DbSet<Dogovor> Dogovori { get; set; } = null!;
        public DbSet<Klient> Klienti { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sotrudnik>().HasKey(u => u.Код_сотрудника);
            modelBuilder.Entity<Predmet_zaloga>().HasKey(u => u.Код_предмета);
            modelBuilder.Entity<Dogovor>().HasKey(u => u.Номер_договора);
            modelBuilder.Entity<Klient>().HasKey(u => u.Код_клиента);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=@1my1_SQl;database=lombard;",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
