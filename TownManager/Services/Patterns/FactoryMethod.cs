using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;

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
    }
}
