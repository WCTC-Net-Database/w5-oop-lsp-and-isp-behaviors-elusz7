using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Character : IEntity
{
    public string Name { get; set; }
    private readonly MoveCommand MoveCommand = new();
    private readonly AttackCommand AttackCommand = new();

    public void Move()
    {
        MoveCommand.Execute(this);
    }

    public void Attack(IEntity target)
    {
        AttackCommand.Execute(this, target);
    }
}
