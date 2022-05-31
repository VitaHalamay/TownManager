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
            
            var observer = gameSingleton.Model.Buildings.Last();
            if(observer.Type == BuildingType.House)
            {
                gameSingleton.Publisher.IncreaseWorkers();
            } 
            else
            {
                gameSingleton.Publisher.Attach(observer);
                gameSingleton.Publisher.Notify();
            }

        }

        public override void Destroy(int index)
        {
            var gameSingleton = GameSingleton.GetInstance();

            var observer = gameSingleton.Model.Buildings[index];
            if(observer.Type == BuildingType.House)
            {
                gameSingleton.Publisher.DecreaseWorkers();
            }
            else if (observer.Type != BuildingType.House && !observer.Active)
            {
                gameSingleton.Publisher.Detach(observer);
            }

            DecoratedBuildingFactory.Destroy(index);

            gameSingleton.Model.Statistics[StatisticsType.MoneyCount] += 80;
        }
    }
}
