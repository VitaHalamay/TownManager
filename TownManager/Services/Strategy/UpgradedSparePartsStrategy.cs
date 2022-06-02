using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;
using TownManager.Services.Patterns;

namespace TownManager.Services.Strategy
{
    public class UpgradedSparePartsStrategy : ISparePartsDayStrategy
    {
        public void RecalculateSparePartsProduction()
        {
            var gameSingleton = GameSingleton.GetInstance();

            var companyCount = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.MetallurgyCompany).Count();
            gameSingleton.Model.Statistics[StatisticsType.SparePartsCount] += companyCount * 650;

        }

        public void RecalculateDevicesProduction()
        {
            var gameSingleton = GameSingleton.GetInstance();
            var companyCount = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.ElectronicsCompany).Count();
            var devicesPerCompany = 70;
            var sparePartsForDevice = 5;
            var neededSpareParts = companyCount * devicesPerCompany * sparePartsForDevice;
            if (neededSpareParts <= gameSingleton.Model.Statistics[StatisticsType.SparePartsCount])
            {
                gameSingleton.Model.Statistics[StatisticsType.DevicesCount] += companyCount * devicesPerCompany;
                gameSingleton.Model.Statistics[StatisticsType.SparePartsCount] -= neededSpareParts;
            }
            else
            {
                var possibleDevices = gameSingleton.Model.Statistics[StatisticsType.SparePartsCount] / sparePartsForDevice;
                gameSingleton.Model.Statistics[StatisticsType.DevicesCount] += possibleDevices;
                gameSingleton.Model.Statistics[StatisticsType.SparePartsCount] -= possibleDevices * sparePartsForDevice;
            }

        }

        public void RecalculateDevicesSales()
        {
            var gameSingleton = GameSingleton.GetInstance();

            var count = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.Store).Count();

            var devicesCount = count * 3;
            gameSingleton.Model.Statistics[StatisticsType.DevicesCount] -= devicesCount;
            gameSingleton.Model.Statistics[StatisticsType.MoneyCount] += devicesCount * 20;

            if (gameSingleton.Model.Statistics[StatisticsType.DevicesCount] <= 0)
            {
                gameSingleton.Model.Statistics[StatisticsType.DevicesCount] = 0;
                gameSingleton.Model.Statistics[StatisticsType.PrestigeLevel]--;
                gameSingleton.Model.Statistics[StatisticsType.SecurityLevel]--;
            }
        }
    }
}
