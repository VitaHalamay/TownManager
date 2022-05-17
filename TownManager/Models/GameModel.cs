using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Models
{
    public class GameModel
    {
        public List<AbstarctBuilding> Buildings { get; set; }
        public GameModel() 
        {
            Buildings = new List<AbstarctBuilding>();
        }
    }
}
