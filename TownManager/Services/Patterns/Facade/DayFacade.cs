using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Services.Strategy;

namespace TownManager.Services.Patterns
{
    public class DayFacade
    {
        GameSingleton gameSingleton;
        IHealthDayStrategy healthDayStrategy;
        IClothesDayStrategy clothesDayStrategy;
        ISparePartsDayStrategy sparePartsDayStrategy;

        public DayFacade()
        {
            gameSingleton = GameSingleton.GetInstance();
            healthDayStrategy = FactoryMethod.GetHealthDayStrategy();
            clothesDayStrategy = FactoryMethod.GetClothesDayStrategy();
            sparePartsDayStrategy = FactoryMethod.GetSparePartsDayStrategy();
        }

        public void RecalculateStatistics()
        {
            gameSingleton.Model.CurrentDay++;

            healthDayStrategy.RecalculateMedcines();
            healthDayStrategy.RecalculateHealth();

            clothesDayStrategy.RecalculateClothesProduction();
            clothesDayStrategy.RecalculateClothesSales();

            sparePartsDayStrategy.RecalculateSparePartsProduction();
            sparePartsDayStrategy.RecalculateDevicesProduction();
            sparePartsDayStrategy.RecalculateDevicesSales();
        }
    }
}
