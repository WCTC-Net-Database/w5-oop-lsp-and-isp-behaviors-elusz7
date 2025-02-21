using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_assignment_template.Interfaces
{
    interface ICommand
    {
        public void Execute(IEntity self);

        public void Execute(IEntity self, IEntity target);
    }
}
