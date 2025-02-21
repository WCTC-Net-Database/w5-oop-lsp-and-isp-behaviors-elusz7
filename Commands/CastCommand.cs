using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Entities;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Commands
{
    class CastCommand : ICommand
    {
        private readonly IEntity Self;
        private IEntity Target;
        private readonly string Spell;

        public CastCommand(IEntity self, IEntity target)
        {
            this.Self = self;
            this.Target = target;
            this.Spell = ((ICastable)Self).Spell;
        }

        public CastCommand(IEntity self, IEntity target, string spell)
        {
            this.Self = self;
            this.Target = target;
            this.Spell = spell;
        }

        public void SetTarget(IEntity target)
        {
            this.Target = target;
        }

        public void Execute()
        {
            Console.WriteLine($"{Self.Name} casts {Spell} at {Target.Name}");
        }
    }
}
