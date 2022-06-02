using System;
using System.Linq;
using TownManager.Models.Enums;
using TownManager.Services.Strategy;

namespace TownManager.Services.Patterns
{
    public class FactoryMethod
    {
        public static IBuildingFactory GetBuildingFactory(BuildingType buildingType)
        {
            return buildingType switch
            {
                BuildingType.ElectronicsCompany => new ElectronicsCompanyFactory(),
                BuildingType.Hospital => new HospitalFactory(),
                BuildingType.PharmaceuticalCompany => new PharmaceuticalCompanyFactory(),
                BuildingType.ProvisionCompany => new ProvisionCompanyFactory(),
                BuildingType.TextileCompany => new TextileCompanyFactory(),
                BuildingType.MetallurgyCompany => new MetallurgyCompanyFactory(),
                BuildingType.FireStation => new FireStationFactory(),
                BuildingType.Hotel => new HotelFactory(),
                BuildingType.House => new HouseFactory(),
                BuildingType.Museum => new MuseumFactory(),
                BuildingType.PoliceStation => new PoliceStationFactory(),
                BuildingType.Store => new StoreFactory(),
                _ => throw new NotImplementedException(),
            };
        }

        public static IClothesDayStrategy GetClothesDayStrategy()
        {
            var gameSingleton = GameSingleton.GetInstance();
            var buildings = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.TextileCompany);
            if(buildings.Any(a => a.Upgraded))
            {
                return new UpgradedClothesDayStrategy();
            }
            return new ClothesDayStrategy();
        }
        public static ISparePartsDayStrategy GetSparePartsDayStrategy()
        {
            var gameSingleton = GameSingleton.GetInstance();
            var metallurgyCompanies = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.MetallurgyCompany);
            var electronicsCompanies = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.ElectronicsCompany);
            if (metallurgyCompanies.Any(a => a.Upgraded) && electronicsCompanies.Any(a => a.Upgraded))
            {
                return new UpgradedSparePartsStrategy();
            }
            return new SparePartsDayStrategy();
        }
        public static IHealthDayStrategy GetHealthDayStrategy()
        {
            var gameSingleton = GameSingleton.GetInstance();
            var buildings = gameSingleton.Model.Buildings.Where(w => w.Type == BuildingType.PharmaceuticalCompany);
            if (buildings.All(a => a.Upgraded))
            {
                return new UpgradedHealthDayStrategy();
            }
            return new HealthDayStrategy();
        }
    }

}
