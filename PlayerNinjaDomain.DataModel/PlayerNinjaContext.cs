using PlayerNinjaDomain.Classes;
using System.Data.Entity;

namespace PlayerNinjaDomain.DataModel
{
    public class PlayerNinjaContext : DbContext
    {
        public DbSet<PlayerNinja> PlayerNinjas { get; set; }
        public DbSet<StateClan> StateClans { get; set; }
        public DbSet<SportsNinjaEquipment> Sports { get; set; }

    }
}