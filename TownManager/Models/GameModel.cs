using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;

namespace TownManager.Models
{
    public class GameModel
    {
        public int CurrentDay { get; set; }
        public List<AbstarctBuilding> Buildings { get; set; }
        public Dictionary<StatisticsType, int> Statistics { get; set; }

        public GameModel()
        {
            Buildings = new List<AbstarctBuilding>();
            Statistics = new Dictionary<StatisticsType, int>();
            foreach (var type in Enum.GetValues(typeof(StatisticsType)))
            {
                Statistics.Add((StatisticsType)type, 0);
            }
        }
    }
}
