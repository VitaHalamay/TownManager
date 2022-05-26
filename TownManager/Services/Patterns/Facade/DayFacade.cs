using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Services.Patterns
{
    public class DayFacade
    {
        GameSingleton gameSingleton;
        HealthDayService healthDayService;
        ClothesDayService clothesDayService;
        SparePartsDayService sparePartsDayService;

        public DayFacade()
        {
            gameSingleton = GameSingleton.GetInstance();
            healthDayService = new HealthDayService();
            clothesDayService = new ClothesDayService();
            sparePartsDayService = new SparePartsDayService();

        }

        public void RecalculateStatistics()
        {

            gameSingleton.Model.CurrentDay++;

            healthDayService.RecalculateMedcines();
            healthDayService.RecalculateHealth();

            clothesDayService.RecalculateClothesProduction();
            clothesDayService.RecalculateClothesSales();

            sparePartsDayService.RecalculateSparePartsProduction();
            sparePartsDayService.RecalculateDevicesProduction();
            sparePartsDayService.RecalculateDevicesSales();
        }
    }
}
