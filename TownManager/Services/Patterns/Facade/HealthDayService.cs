using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;
using TownManager.Services.Patterns;

namespace TownManager.Services
{
    public class HealthDayService
    {
        public void RecalculateMedcines()
        {
            var gameSingleton = GameSingleton.GetInstance();
            var count = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.PharmaceuticalCompany).Count();
            gameSingleton.Model.Statistics[StatisticsType.MedicinesCount] += count * 30;
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
