using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models;
using TownManager.Models.Enums;
using TownManager.Services.Patterns;

namespace TownManager.Services
{
    public class HospitalFactory : IBuildingFactory
    {
        public void Build()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Buildings.Add(new Hospital { Type = BuildingType.Hospital });

            var builder = new BuildBuilder();

            builder.UpdateWorkplacesCount();
            builder.UpdateHealthLevel();
        }

        public void Destroy(int index)
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Buildings.RemoveAt(index);

            var builder = new DestroyBuilder();
            
            builder.UpdateWorkplacesCount();
            builder.UpdateHealthLevel();

        }
    }
}
