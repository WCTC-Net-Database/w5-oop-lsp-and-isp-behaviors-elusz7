using W5_assignment_template.Interfaces;
using W5_assignment_template.Commands;

namespace W5_assignment_template.Entities
{
    public class Mage : IEntity, ICastable
    {
        public string Name { get; set; }
        public string Spell { get; set; }
        private readonly MoveCommand MoveCommand;
        private readonly AttackCommand AttackCommand;
        private readonly CastCommand CastCommand;
        public Mage()
        {
            Spell = "Fire Bolt";
            MoveCommand = new(this);
            AttackCommand = new(this, null);
            CastCommand = new(this, null);
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

        public void Cast(IEntity target)
        {
            CastCommand.SetTarget(target);
            CastCommand.Execute();
        }
    }
}
