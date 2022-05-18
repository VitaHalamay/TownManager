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
                BuildingType.Company => new CompanyFactory(),
                BuildingType.Factory => new FactoryFactory(),
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
