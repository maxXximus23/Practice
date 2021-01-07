using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestAlex.DataAccess.Entities;

namespace DataAccess.TestAlex
{
    class DatabaseContext : DbContext
    {
        private readonly string _connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Database=GamesDb;Trusted_Connection=True;";

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
