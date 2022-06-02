using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;
using TownManager.Services.Patterns;

namespace TownManager.Services.Strategy
{
    public class UpgradedClothesDayStrategy : IClothesDayStrategy
    {
        public void RecalculateClothesProduction()
        {
            var gameSingleton = GameSingleton.GetInstance();

            var companyCount = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.TextileCompany).Count();
            gameSingleton.Model.Statistics[StatisticsType.ClothesCount] += companyCount * 20;
            gameSingleton.Model.Statistics[StatisticsType.DevicesCount] -= companyCount * 1;
        }

        public void RecalculateClothesSales()
        {
            var gameSingleton = GameSingleton.GetInstance();

            var count = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.Store).Count();

            var clothesCount = count * 7;
            gameSingleton.Model.Statistics[StatisticsType.ClothesCount] -= clothesCount;
            gameSingleton.Model.Statistics[StatisticsType.MoneyCount] += clothesCount * 7;

            if (gameSingleton.Model.Statistics[StatisticsType.ClothesCount] <= 0)
            {
                gameSingleton.Model.Statistics[StatisticsType.ClothesCount] = 0;
                gameSingleton.Model.Statistics[StatisticsType.PrestigeLevel]--;
            }
        }
    }
}
