using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownManager.Services.Patterns.ChainOfResponsibility
{
    public abstract class AbstractHandler
    {
        public AbstractHandler Handler { get; private set; }
        protected AbstractHandler(AbstractHandler handler)
        {
            Handler = handler;
        }
        public virtual void Handle(int index)
        {
            if (Handler != null)
            {
                Handler.Handle(index);
            }
        }
    }
}
