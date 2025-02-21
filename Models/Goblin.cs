using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Goblin : IEntity
    {
        public string Name { get; set; }
        private readonly AttackCommand AttackCommand = new();
        private readonly MoveCommand MoveCommand = new();

        public void Attack(IEntity target)
        {
            AttackCommand.Execute(this, target);
        }

        public void Move()
        {
            MoveCommand.Execute(this);
        }
    }
}
