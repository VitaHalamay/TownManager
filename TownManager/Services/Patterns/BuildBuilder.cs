using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Services.Patterns
{
    public class BuildBuilder : Builder
    {
       
        public override void UpdateCitizensCount()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.CitizensCount += 2;
        }

        public override void UpdateCultureLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.CultureLevel += 10;
        }

        public override void UpdatePrestigeLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.PrestigeLevel += 5;
        }

        public override void UpdateProvisionLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.ProvisionLevel += 25;
        }

        public override void UpdateSecurityLevel()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.SecurityLevel += 30;
        }

        public override void UpdateWorkplacesCount()
        {
            var gameSingleton = GameSingleton.GetInstance();
            gameSingleton.Model.WorkplacesCount += 10;
        }
    }
}
