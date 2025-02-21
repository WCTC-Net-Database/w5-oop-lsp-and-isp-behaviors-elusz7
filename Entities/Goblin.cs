using W5_assignment_template.Interfaces;
using W5_assignment_template.Commands;

namespace W5_assignment_template.Entities
{
    public class Goblin : IEntity
    {
        public string Name { get; set; }
        private readonly AttackCommand AttackCommand;
        private readonly MoveCommand MoveCommand;
        public Goblin()
        {
            MoveCommand = new(this);
            AttackCommand = new(this, null);
        }
        public void Attack(IEntity target)
        {
            AttackCommand.SetTarget(target);
            AttackCommand.Execute();
        }

        public void Move()
        {
            MoveCommand.Execute();
        }
    }
}
