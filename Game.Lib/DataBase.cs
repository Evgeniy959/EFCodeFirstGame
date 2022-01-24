using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Game.Model;

namespace Game.Lib
{
    public class DataBase : DbContext
    {
        public static string connectionStringFile => "/ConnectionString.txt";
        public DbSet<Game> TabGames { get; set; }

        protected DataBase() { }
        public DataBase(DbContextOptions<DataBase> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public static DataBase Init()
        {
            var options = new DbContextOptionsBuilder<DataBase>().UseMySQL(GetConnectionString(connectionStringFile)).Options;
            return new DataBase(options);
        }

        public static string GetConnectionString(string connectionStringFile)
        {
            var streamReader = new StreamReader(Directory.GetCurrentDirectory() + connectionStringFile);
            return streamReader.ReadToEnd();
        }

    }
}
