using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Commands;

public class MoveCommand : ICommand
{
    private readonly IEntity self;
    public MoveCommand(IEntity self)
    {
        this.self = self;
    }
    public void Execute()
    {
        Console.WriteLine($"{self.Name} moves forward.");
    }
}

