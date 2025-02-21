using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Mage : IEntity
    {
        public string Name { get; set; }
        public string Spell { get; set; }
        private readonly MoveCommand MoveCommand;
        private readonly CastCommand CastCommand;
        public Mage()
        {
            Spell = "Fire Bolt";
            MoveCommand = new(this);
            CastCommand = new(this, null);
        }
        public void Move()
        {
            MoveCommand.Execute();
        }

        public void Attack(IEntity target)
        {
            CastCommand.SetTarget(target);
            CastCommand.Execute();
        }
    }
}
