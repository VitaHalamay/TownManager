using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Models
{
    public class GameModel
    {
        public List<AbstarctBuilding> Buildings { get; set; }
        public int CitizensCount { get; set; }
        public int WorkplacesCount { get; set; }
        public int CultureLevel { get; set; }
        public int ProvisionLevel { get; set; }
        public int SecurityLevel { get; set; }
        public int PrestigeLevel { get; set; }

        public GameModel() 
        {
            Buildings = new List<AbstarctBuilding>();
        }
    }
}
