using TownManager.Models.Enums;
using TownManager.Services.Patterns.Observer;

namespace TownManager.Models
{
    public abstract class AbstarctBuilding : IObserver
    {
        public BuildingType Type { get; set; }

        public bool Active { get; set; }

        public void Update()
        {
            Active = !Active;
        }
    }
}
