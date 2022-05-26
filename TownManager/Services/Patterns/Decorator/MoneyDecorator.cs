using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;

namespace TownManager.Services.Patterns.Decorator
{
    public class MoneyDecorator : Decorator
    {
        public MoneyDecorator(IBuildingFactory decoratedBuildingFactory) : base(decoratedBuildingFactory)
        {
        }

        public override void Build()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.MoneyCount] -= 100;
            DecoratedBuildingFactory.Build();
        }

        public override void Destroy(int index)
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.MoneyCount] += 80;
            DecoratedBuildingFactory.Destroy(index);
        }
    }
}
