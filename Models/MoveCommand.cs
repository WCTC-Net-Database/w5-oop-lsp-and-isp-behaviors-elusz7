using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class MoveCommand : ICommand
{
    public void Execute(IEntity self)
    {
        Console.WriteLine($"{self.Name} moves forward.");
    }

    void ICommand.Execute(IEntity self, IEntity target)
    {
        throw new NotImplementedException();
    }
}

