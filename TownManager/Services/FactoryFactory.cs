using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models;
using TownManager.Models.Enums;
using TownManager.Services.Patterns;

namespace TownManager.Services
{
    public class FactoryFactory : IBuildingFactory
    {
        public void Build()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Buildings.Add(new Factory { Type = BuildingType.Factory });

            var builder = new BuildBuilder();
            builder.UpdateProvisionLevel();
            builder.UpdateWorkplacesCount();
        }

        public void Destroy(int index)
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Buildings.RemoveAt(index);

            var builder = new DestroyBuilder();
            builder.UpdateProvisionLevel();
            builder.UpdateWorkplacesCount();
        }
    }
}
