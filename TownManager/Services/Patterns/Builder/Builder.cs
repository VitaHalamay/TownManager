using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Services.Patterns
{
    public abstract class Builder
    {
        public abstract void UpdateCitizensCount();
        public abstract void UpdateWorkplacesCount();
        public abstract void UpdateCultureLevel();
        public abstract void UpdateProvisionLevel();
        public abstract void UpdateSecurityLevel();
        public abstract void UpdatePrestigeLevel();
        public abstract void UpdateHealthLevel();
    }
}
