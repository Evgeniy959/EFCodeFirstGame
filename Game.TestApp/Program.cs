using Game.Lib;
using Microsoft.EntityFrameworkCore;
using System;

namespace Game.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataBase();
            db.Init();
            db.TabGames.Add(new Game
            {
                Name = "Counter-Strike",
                Creator = "Valve Corporation",
                Style = "Шутер от первого лица",
                DateOfRelease = "08.11.2000"
            });

            db.TabGames.Add(new Game
            {
                Name = "Warcraft: Orcs & Humans",
                Creator = "Blizzard Entertainment",
                Style = "Стратегия в реальном времени",
                DateOfRelease = "23.11.1994"
            });

            db.SaveChanges();
        }
    }
}
