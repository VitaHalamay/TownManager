using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models.Enums;

namespace TownManager.Services.Patterns
{
    public class BuildBuilder : Builder
    {
       
        public override void UpdateCitizensCount()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.CitizensCount] += 2;
        }

        public override void UpdateCultureLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.CultureLevel] += 10;
        }

        public override void UpdateHealthLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.HealthLevel] += 10;
        }

        public override void UpdatePrestigeLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.PrestigeLevel] += 5;
        }

        public override void UpdateProvisionLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.ProvisionLevel] += 25;
        }

        public override void UpdateSecurityLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.SecurityLevel] += 30;
        }

        public override void UpdateWorkplacesCount()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.Statistics[StatisticsType.WorkplacesCount] += 10;
        }
    }
}
