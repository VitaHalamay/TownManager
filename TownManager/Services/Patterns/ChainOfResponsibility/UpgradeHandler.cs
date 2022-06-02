using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;

namespace TownManager.Services.Patterns.ChainOfResponsibility
{
    public class UpgradeHandler : AbstractHandler
    {
        public UpgradeHandler(AbstractHandler handler) : base(handler)
        {
        }

        public override void Handle(int index)
        {
            var upgradePrice = 250;
            var gameSingleton = GameSingleton.GetInstance();
            var building = gameSingleton.Model.Buildings[index];
            if (!building.Upgraded)
            {
                gameSingleton.Model.Statistics[StatisticsType.MoneyCount] -= upgradePrice;
                building.Upgraded = true;
                base.Handle(index);
            }
        }
    }
}
