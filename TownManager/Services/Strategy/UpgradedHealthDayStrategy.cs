using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;
using TownManager.Services.Patterns;

namespace TownManager.Services.Strategy
{
    public class UpgradedHealthDayStrategy : IHealthDayStrategy
    {
        public void RecalculateMedcines()
        {
            var gameSingleton = GameSingleton.GetInstance();
            var count = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.PharmaceuticalCompany).Count();
            gameSingleton.Model.Statistics[StatisticsType.MedicinesCount] += count * 50;
            gameSingleton.Model.Statistics[StatisticsType.ClothesCount] -= count * 1;
            gameSingleton.Model.Statistics[StatisticsType.DevicesCount] -= count * 1;
        }
        public void RecalculateHealth()
        {
            var gameSingleton = GameSingleton.GetInstance();
            var count = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.Hospital).Count();
            gameSingleton.Model.Statistics[StatisticsType.MedicinesCount] -= count * 10;
            if (gameSingleton.Model.Statistics[StatisticsType.MedicinesCount] <= 0)
            {
                gameSingleton.Model.Statistics[StatisticsType.MedicinesCount] = 0;
                gameSingleton.Model.Statistics[StatisticsType.HealthLevel]--;
            }
        }
    }
}
