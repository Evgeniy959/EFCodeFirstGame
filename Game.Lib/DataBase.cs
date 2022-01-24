using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
//using Game.Model;

namespace Game.Lib
{
    public sealed class DataBase : DbContext
    {
        public DbSet<Game> TabGames { get; set; }

        public DataBase() { }

        public DataBase(DbContextOptions<DataBase> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        public void Init()
        {
            DbContextOptionsBuilder optionsBuilder = null;
            if (!optionsBuilder.IsConfigured)
            {
                var str = File.ReadAllText("ConnectionString.txt");
                optionsBuilder.UseMySQL(str);
            }
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var str = File.ReadAllText("ConnectionString.txt");
                optionsBuilder.UseMySQL(str);
            }
        }*/
    }
}
