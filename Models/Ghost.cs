using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Ghost : IEntity, IFlyable
    {
        public string Name { get; set; }
        private readonly MoveCommand MoveCommand;
        private readonly AttackCommand AttackCommand;
        private readonly FlyCommand FlyCommand;

        public Ghost()
        {
            MoveCommand = new(this);
            AttackCommand = new(this, null);
            FlyCommand = new(this);
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

        public void Fly()
        {
            FlyCommand.Execute();
        }
    }
}
