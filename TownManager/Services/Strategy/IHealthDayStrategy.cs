using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Services.Strategy
{
    public interface IHealthDayStrategy
    {
        void RecalculateMedcines();
        void RecalculateHealth();
    }
}
