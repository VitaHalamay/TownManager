using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;

namespace TownManager.Services.Patterns.ChainOfResponsibility
{
    public class MoneyHandler : AbstractHandler
    {
        public MoneyHandler(AbstractHandler handler) : base(handler)
        {
        }
        public override void Handle(int index)
        {
            var upgradePrice = 250;
            var gameSingleton = GameSingleton.GetInstance();
            var moneyCount = gameSingleton.Model.Statistics[StatisticsType.MoneyCount];
            if (moneyCount >= upgradePrice)
            {
                base.Handle(index);
            }
        }
    }
}
