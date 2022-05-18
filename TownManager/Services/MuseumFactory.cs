using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models;
using TownManager.Models.Enums;
using TownManager.Services.Patterns;

namespace TownManager.Services
{
    public class MuseumFactory : IBuildingFactory
    {
        public void Build()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Buildings.Add(new Museum { Type = BuildingType.Museum });

            var builder = new BuildBuilder();
            builder.UpdateCultureLevel();
            builder.UpdateWorkplacesCount();
            builder.UpdatePrestigeLevel();

        }

        public void Destroy(int index)
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Buildings.RemoveAt(index);

            var builder = new DestroyBuilder();
            builder.UpdateCultureLevel();
            builder.UpdateWorkplacesCount();
            builder.UpdatePrestigeLevel();
        }
    }
}
