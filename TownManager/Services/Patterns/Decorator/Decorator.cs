using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Services.Patterns.Decorator
{
    public abstract class Decorator : IBuildingFactory
    {
        protected IBuildingFactory DecoratedBuildingFactory { get; set; }

        public Decorator(IBuildingFactory decoratedBuildingFactory)
        {
            DecoratedBuildingFactory = decoratedBuildingFactory;
        }

        public virtual void Build()
        {
            DecoratedBuildingFactory.Build();
        }

        public virtual void Destroy(int index)
        {
            DecoratedBuildingFactory.Destroy(index);
        }
    }
}
