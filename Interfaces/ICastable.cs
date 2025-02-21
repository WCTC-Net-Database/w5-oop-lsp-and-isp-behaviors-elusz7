using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_assignment_template.Interfaces
{
    public interface ICastable
    {
        public string Spell { get; set; }
        public void Cast(IEntity target);
    }
}
