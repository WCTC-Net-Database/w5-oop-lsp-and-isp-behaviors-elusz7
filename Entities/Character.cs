using W5_assignment_template.Interfaces;
using W5_assignment_template.Commands;

namespace W5_assignment_template.Entities
{
    public class Character : IEntity
    {
        public string Name { get; set; }
        private readonly MoveCommand MoveCommand;
        private readonly AttackCommand AttackCommand;
        public Character()
        {
            MoveCommand = new(this);
            AttackCommand = new(this, null);
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
