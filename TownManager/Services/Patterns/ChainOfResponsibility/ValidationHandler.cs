using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Services.Patterns.ChainOfResponsibility
{
    public class ValidationHandler : AbstractHandler
    {
        public ValidationHandler(AbstractHandler handler) : base(handler)
        {
        }
        public override void Handle(int index)
        {
            var gameSingleton = GameSingleton.GetInstance();
            var building = gameSingleton.Model.Buildings.ElementAtOrDefault(index);
            if(building != null)
            {
                base.Handle(index);
            }
        }
    }
}
