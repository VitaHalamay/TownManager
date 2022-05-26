using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownManager.Models;

namespace TownManager.Services.Patterns
{
    public interface IBuildingFactory
    {
        public void Build();
        public void Destroy(int index);

    }
}
