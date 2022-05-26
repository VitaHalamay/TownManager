using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models;
using TownManager.Models.Enums;
using TownManager.Services.Patterns;

namespace TownManager.Services
{
    public class PoliceStationFactory : IBuildingFactory
    {
        public void Build()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Buildings.Add(new PoliceStation { Type = BuildingType.PoliceStation });

            var builder = new BuildBuilder();
            builder.UpdateWorkplacesCount();
            builder.UpdateSecurityLevel();
        }

        public void Destroy(int index)
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Buildings.RemoveAt(index);

            var builder = new DestroyBuilder();
            builder.UpdateWorkplacesCount();
            builder.UpdateSecurityLevel();
        }
    }
}
