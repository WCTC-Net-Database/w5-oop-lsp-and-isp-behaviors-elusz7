using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Commands;

public class AttackCommand : ICommand
{
    private readonly IEntity self;
    private IEntity target;
    public AttackCommand(IEntity self, IEntity target)
    {
        this.self = self;
        this.target = target;
    }
    public void SetTarget(IEntity target)
    {
        this.target = target;
    }
    public void Execute()
    {
        Console.WriteLine($"{self.Name} attacks {target.Name}");
    }
}