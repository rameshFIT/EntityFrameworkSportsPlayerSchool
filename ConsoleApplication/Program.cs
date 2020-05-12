using PlayerNinjaDomain.Classes;
using PlayerNinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertNinjaPlayer();
            Console.ReadKey();
        }

        private static void RamiInsertNinjaPlayerCode()
        {
            PlayerNinja Ramesh = new PlayerNinja();
            Ramesh.DateOfBirth = DateTime.Today;
            Ramesh.Name = "Ramesh Vanamu";
            Ramesh.InOlymphics = true;
            Ramesh.StateClanId = 1;

            PlayerNinjaContext ninjaPlayerConext = new PlayerNinjaContext();

            ninjaPlayerConext.PlayerNinjas.Add(Ramesh);
            ninjaPlayerConext.SaveChanges();
        }

        private static void InsertNinjaPlayer()
        {
            var NinjaPlayer = new PlayerNinja
            {
                Name = "Ramesh",
                InOlymphics = true,
                DateOfBirth = new DateTime(1981, 6, 22),
                StateClanId = 1               
            };

            using (var playerNinjaConext = new PlayerNinjaContext())
            {
                playerNinjaConext.Database.Log = Console.Write;
                playerNinjaConext.PlayerNinjas.Add(NinjaPlayer);
                playerNinjaConext.SaveChanges();
            }
        }

    }
}
