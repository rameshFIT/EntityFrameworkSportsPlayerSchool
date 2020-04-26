using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlayerNinjaDomain.Classes
{
    public class PlayerNinja
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool InOlymphics { get; set; }

        public StateClan StateClan { get; set; }

        public int StateClanId { get; set; }

        public List<SportsNinjaEquipment> SportsEquipmentOwned { get; set; }
    }
    public class StateClan
    {
        //Clan means group of people united by kinship
        public int Id { get; set; }
        public string StateClanName { get; set; }
        public List<PlayerNinja> Players { get; set; }
    }

    public class SportsNinjaEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SportType typeOfSport;

        [Required]
        public PlayerNinja PlayerNinja { get; set; }
    }  
}
