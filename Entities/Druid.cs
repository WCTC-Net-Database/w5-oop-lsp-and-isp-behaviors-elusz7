using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Commands;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Entities
{
    public class Druid : IEntity, IShiftable, ICastable
    {
        public string Name { get; set; }
        public string Form { get; set; }
        public string Spell { get; set; }
        private readonly MoveCommand MoveCommand;
        private readonly ShiftCommand ShiftCommand;
        private readonly CastCommand CastCommand;
        private readonly AttackCommand AttackCommand;
        public Druid() 
        {
            this.Spell = "Entangle";
            this.Form = "Bear";
            MoveCommand = new MoveCommand(this);
            ShiftCommand = new ShiftCommand(this);
            CastCommand = new CastCommand(this, null);
            AttackCommand = new AttackCommand(this, null);
        }
        public void Shift(string form)
        {
            this.Form = form;
            ShiftCommand.Execute();
        }
        public void Cast(IEntity target)
        {
            CastCommand.SetTarget(target);
            CastCommand.Execute();
        }

        public void Move()
        {
            MoveCommand.Execute();
        }

        public void Attack(IEntity target)
        {
            AttackCommand.SetTarget(target);
            AttackCommand.Execute();
        }
    }
}
